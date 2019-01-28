import React from 'react';
import { ProductContainer } from '../Containers/DataContainers/ProductContainer';

export class Products extends React.Component {
	render() {
		return (
			<ProductContainer>
				{({ loading, products }) => {
					if (loading) return "Loading .."
					return products.map(x => x.name).join(',');
				}}
			</ProductContainer>
		)
	}
}
