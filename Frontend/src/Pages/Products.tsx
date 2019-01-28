import React from 'react';
import { ProductContainer } from '../Containers/DataContainers/ProductContainer';
import { Dimmer, Loader } from 'semantic-ui-react';

export class Products extends React.Component {
	render() {
		return (
			<ProductContainer>
				{({ loading, products }) => {
					if (loading) return (
						<Dimmer active inverted>
							<Loader inverted>Loading the products</Loader>
						</Dimmer>
					)
					return products.map(x => x.name).join(',');
				}}
			</ProductContainer>
		)
	}
}
