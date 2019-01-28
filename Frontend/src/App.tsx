import React, { Component } from 'react';

// Import the required css files for styling.
import 'primereact/resources/themes/nova-light/theme.css';
import 'primereact/resources/primereact.min.css';
import 'primeicons/primeicons.css';

import { ProductContext } from './Containers/DataContext/ProductContext';
import { Routing } from './Pages/Routing';

class App extends Component<{}, { error?: string, products: any[] }> {

	render() {

		return (
			<ProductContext>
				<Routing />
			</ProductContext>
		);
	}
}

export default App;
