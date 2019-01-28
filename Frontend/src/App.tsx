import React, { Component } from 'react';

import 'primereact/resources/themes/nova-light/theme.css';
import 'primereact/resources/primereact.min.css';
import 'primeicons/primeicons.css';
import { ProductContainer } from './DataContainers/ProductContainer';
import { ProductContext } from './DataContext/ProductContext';

class App extends Component<{}, { error?: string, products: any[] }> {

  render() {

    return (
      <ProductContext>
        <ProductContainer>
          {({ loading, products }) => {
            if (loading) return "";
            return <h1>{products.toLocaleString()}</h1>
          }}
        </ProductContainer>
      </ProductContext>
    );
  }
}

export default App;
