import React, { Component } from 'react';

export class Characters extends Component {
  static displayName = Characters.name;

  constructor(props) {
    super(props);
    this.state = { characters: [], loading: true };
  }

  componentDidMount() {
    this.getCharactersData();
  }

  static renderCharactersTable(characters) {
    return (

      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Id</th>
            <th>Name</th>
            <th>URL Slug</th>
            <th>Secret Identity</th>
            <th>Alive</th>
            <th>First Appearance Date</th>
          </tr>
        </thead>
        <tbody>
          {characters.map(character =>
            <tr key={character.id}>
              <td>{character.id}</td>
              <td>{character.name}</td>
              <td>{character.urlSlug}</td>
              <td>{character.secretIdentity}</td>
              <td>{character.alive}</td>
              <td>{character.firstAppearanceDate}</td>
            </tr>
          )}
        </tbody>
      </table>

    );
  }

  render() {

    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Characters.renderCharactersTable(this.state.characters);

    return (

      <div>
        <h1 id="tabelLabel" >Characters</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>

    );
  }

  async getCharactersData() {

    try {

      const response = await fetch('api/Characters');
      const data = await response.json();
      console.log(data);
      this.setState({ characters: data, loading: false });
    } catch (error) {
      console.error(error);
    }

  }
}
