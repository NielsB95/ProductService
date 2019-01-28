import React, { Component } from 'react';

import 'primereact/resources/themes/nova-light/theme.css';
import 'primereact/resources/primereact.min.css';
import 'primeicons/primeicons.css';
import { ProductContainer } from './DataContainers/ProductContainer';
import { ProductContext } from './DataContext/ProductContext';

import { DataTable } from 'primereact/datatable';
import { Column } from 'primereact/column';

class App extends Component<{}, { error?: string, products: any[] }> {

	render() {

		return (
			<ProductContext>
				<ProductContainer>
					{({ loading, products }) => {
						if (loading) return "Loading ...";
						return (
							<DataTable value={products} >
								<Column field='name' header='Product omschrijving' />
								<Column field='category.name' header='Categorie' />
							</DataTable>
						)
					}}
				</ProductContainer>
			</ProductContext>
		);
	}
}

export default App;
