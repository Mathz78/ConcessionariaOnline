import React, { Component } from 'react';

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
    this.state = { forecasts: [], loading: true };
  }

  componentDidMount() {
    this.populateWeatherData();
  }

  static renderForecastsTable(forecasts) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Primeiro Nome</th>
            <th>Último nome</th>
            <th>Nota</th>
          </tr>
        </thead>
        <tbody>
          {forecasts.map(forecast =>
            <tr key={forecast.date}>
              <td>{forecast.name}</td>
              <td>{forecast.lastName}</td>
              <td>5</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchData.renderForecastsTable(this.state.forecasts);

    return (

      <div>
        <div>
          <h1 id="tabelLabel" >Lista contendo os nossos principais funcionários</h1>
          <p>Este lista contempla os melhores funcionários do mês atual!.</p>
          {contents}
        </div>

        <div class="card">
            <div class="card-body">
                <div class="form-row">
                  <h1 class="text-center mt-3"> Um pouco de nossa história</h1>
                  <p>
                      Nós fizemos um sistema onde o cliente pode entrar no site e efetuar a compra do seu
                      carro sem burocracia podendo fazer a compra por transferência,cartão de crédito
                      ou débito e pix. Podendo agendar a retirada ou receber o carro em sua casa,
                      como o sistema é online diminuiremos o número de funcionários e gastos,assim
                      diminuindo os valores que serão repassados nas vendas dos carros,com isso
                      nossa concessionária teria um ótimo preço no mercado.
                  </p>
                </div>
            </div>
        </div>
      </div>
    );
  }

  async populateWeatherData() {
    const response = await fetch('api/user');
    const data = await response.json();
    this.setState({ forecasts: data, loading: false });
  }
}
