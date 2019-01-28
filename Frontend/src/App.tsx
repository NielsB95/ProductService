import React, { Component } from 'react';

import 'primereact/resources/themes/nova-light/theme.css';
import 'primereact/resources/primereact.min.css';
import 'primeicons/primeicons.css';
import { LoadingContainer } from './UtilContainers/LoadingContainer';
import { ProductContainer } from './DataContainers/ProductContainer';

class App extends Component<{}, { error?: string, products: any[] }> {

  render() {

    return (
      <ProductContainer>
        {({ products }) => {
          return <h1>{products.toLocaleString()}</h1>
        }}
      </ProductContainer>
    );
  }
}

export default App;
