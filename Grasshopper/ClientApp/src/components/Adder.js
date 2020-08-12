import React, { Component } from 'react';

export class Adder extends Component {
    constructor(props) {
        super(props)

        this.state = {
            firstNumber: 0,
            secondNumber: 0
        }

        this.firstNumberChanged = this.firstNumberChanged.bind(this)
        this.secondNumberChanged = this.secondNumberChanged.bind(this)
    }

    firstNumberChanged(event) {
        this.setState({ firstNumber: event.target.value })
    }

    secondNumberChanged(event) {
        this.setState({ secondNumber: event.target.value })
    }

    render(){
        return (
            <div>
                <input type="number" value={this.state.firstNumber} onChange={this.firstNumberChanged}/>
                <input type="number" value={this.state.secondNumber} onChange={this.secondNumberChanged}/>
                <h4>{this.state.firstNumber + this.state.secondNumber}</h4>
            </div>
        );
    }
}