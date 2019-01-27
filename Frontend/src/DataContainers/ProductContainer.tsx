import React, { ReactNode } from 'react';
import { ILoading } from '../UtilContainers/LoadingContainer';

export interface IRenderProps<IState> {
    children: (data: IState) => ReactNode
}

export interface IProductContainerState extends ILoading {
    error?: string,
    products: any[]
}

export class ProductContainer extends React.Component<IRenderProps<IProductContainerState>, IProductContainerState> {

    // Initilaize the state
    state: IProductContainerState = {
        loading: false,
        error: undefined,
        products: []
    }

    /**
     * Start fetching the data before the component becomes visible.
     */
    public componentWillMount() {
        this.setState({ loading: true });
        setTimeout(() => { }, 1000);
        fetch('http://localhost:5000/products')
            .then(reponse => {
                if (reponse.status == 200)
                    return reponse.json();
                else
                    this.setState({ error: reponse.statusText, loading: false });
            }).then(data => {
                this.setState({ products: data, loading: false });
            })
            .catch(x =>
                this.setState({ error: "Something went wrong", loading: false }
                ));
    }

    public render() {
        return this.props.children(this.state);
    }
}