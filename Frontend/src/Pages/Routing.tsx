import React from 'react';
import { Switch, Route } from 'react-router';
import { BrowserRouter } from 'react-router-dom';
import { Index } from './Index';
import { Contact } from './Contact';
import { Products } from './Products';

export class Routing extends React.Component {

	render() {
		return (
			<BrowserRouter>
				<Switch>
					<Route exact path='/' component={Index} />
					<Route path='/products' component={Products} />
					<Route path='/contact' component={Contact} />
				</Switch>
			</BrowserRouter>
		);
	}
}
