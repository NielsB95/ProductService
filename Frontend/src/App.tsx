import React, { Component } from 'react';

// Import styling
import 'semantic-ui-css/semantic.min.css';

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
