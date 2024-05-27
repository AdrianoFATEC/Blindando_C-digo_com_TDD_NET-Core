# Blindando Seu Código com TDD e Testes Unitários Usando .NET Core

Esta é uma aplicação de console desenvolvida para demonstrar como blindar seu código utilizando TDD (Test-Driven Development) e testes unitários com .NET Core e XUnit. A aplicação implementa uma calculadora com operações básicas e mantém um histórico das últimas três operações realizadas.

## Funcionalidades

A calculadora possui os seguintes métodos:

- **Somar**: Realiza a soma de dois números.
- **Subtrair**: Realiza a subtração entre dois números.
- **Multiplicar**: Realiza a multiplicação entre dois números.
- **Dividir**: Realiza a divisão entre dois números.
- **Histórico**: Armazena e exibe o histórico das últimas três operações realizadas.

## Tecnologias Utilizadas

- **C#**: Linguagem de programação utilizada.
- **.NET Core**: Plataforma de desenvolvimento utilizada.
- **XUnit**: Framework para testes unitários em .NET.

## Estrutura do Projeto

O projeto é composto por duas partes principais:

1. **Aplicação de Console**: Contém a lógica da calculadora.
2. **Testes Unitários**: Testes para verificar a corretude dos métodos da calculadora, utilizando a biblioteca XUnit.

## Como Executar

### Pré-requisitos

- .NET SDK instalado na máquina.

### Passos para Execução

1. **Clone este repositório**:
    ```bash
    git clone https://github.com/seu-usuario/desafio_tdd_dio.git
    ```

2. **Navegue até o diretório do projeto**:
    ```bash
    cd desafio_tdd_dio
    ```

3. **Restaure as dependências do projeto**:
    ```bash
    dotnet restore
    ```

4. **Execute a aplicação de console**:
    ```bash
    dotnet run --project Caminho/Para/Seu/Projeto
    ```

5. **Para executar os testes, utilize o seguinte comando**:
    ```bash
    dotnet test
    ```

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests.



