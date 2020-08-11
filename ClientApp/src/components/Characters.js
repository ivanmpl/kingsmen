import React, { Component } from 'react';

export class Characters extends Component {
  static displayName = Characters.name;

  constructor(props) {
    super(props);
  }

  render() {
    return (
      <div>
        <h1>Characters</h1>
      </div>
    );
  }
}
