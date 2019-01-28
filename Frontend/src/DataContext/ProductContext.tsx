import React from 'react';

interface IProductContextState {

	// The properties within the state of this application.
	state: {
	},

	// Enlist possible functions we want to apply on the state.
}

const context = React.createContext({});

// Export of the consumer, which can be used to obtain data from the context.
export const ProductConsumer = context.Consumer;

/**
 * Extension for the context provider so we can put some more logic to it.
 */
export class ProductContext extends React.Component<{}, IProductContextState> {

	state: IProductContextState = {
		state: {
		}
	};

	render() {
		return (
			<context.Provider value={this.state.state}>
				{this.props.children}
			</context.Provider>
		);
	}
}
