import React from 'react';

export interface ILoading extends React.ComponentState {
	loading: boolean
}

export interface ILoadingContainerProps {
	children: React.Component<any, ILoading>
}

export class LoadingContainer extends React.Component<ILoadingContainerProps> {

	render() {
		this.props.children.props;
		return this.props.children;
	}
}
