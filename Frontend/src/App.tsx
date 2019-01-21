import React, { Component } from 'react';
import { Card } from 'primereact/card';

import 'primereact/resources/themes/nova-light/theme.css';
import 'primereact/resources/primereact.min.css';
import 'primeicons/primeicons.css';

class App extends Component {
  render() {
    return (
      <Card title='Hello world'></Card>
    );
  }
}

export default App;
