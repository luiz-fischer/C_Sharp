# ========= PROGRAMA LocaCar DESENVOLVIDO EM C# =========

[![Build Status](https://travis-ci.org/condessalovelace/mavenquickstart.svg?branch=master)](https://travis-ci.org/condessalovelace/mavenquickstart) ![Quality Gate](https://sonarcloud.io/api/project_badges/measure?project=br.com%3Amavenquickstart&metric=alert_status)

## Programa desenvolvido com dotnet, EF Core e Mysql

## Project Description

Esse Projeto ilustra a estrutura gerada através da utilização do linguagem C#, o Programa foi desenvolvido em formato CRUD para Objetos como clientes, carros e locações.

## Features

- [x] Cadastro de Clientes
- [x] Cadastro de Veiculo
- [x] Cadastro de Locações
- [x] Lista de Clientes
- [x] Lista de Veiculo
- [x] Lista de Locações
- [x] Excluir Clientes
- [x] Excluir Veiculo
- [x] Excluir Locações
- [x] Consultar Clientes
- [x] Consultar Veiculo
- [x] Consultar Locações
- [x] Alterar Clientes
- [x] Alterar Veiculo
- [x] Alterar Locações

## Getting started

- Antes de começecar o Programa contem imagens , quando necessário corrigir os caminhos das Imagens para a execução do programa.
- As imagens estao na Pasta LocaCar\Imagens.
- Caminho original a ser corrigindo, quando necessário:("C:\\LocaCar\\Imagens\\download1.jpg").

## Install Dependencies

1. `dotnet tool install dotnet-ef -g --version 5.0.5`
2. `dotnet add package Pomelo.EntityFrameworkCore.MySql --version 5.0.0`
3. `dotnet add package Pomelo.EntityFrameworkCore.MySql.Desing --version 1.1.2`
4. `dotnet add package Microsoft.EntityFrameworkCore --version 5.0.6`
5. `dotnet add package Microsoft.EntityFrameworkCore.Desing --version 5.0.6`
6. `dotnet add package Microsoft.Windows.Compatibility --version 3.0.0`
7. `dotnet ef migrations add InitialDB`
8. `dotnet ef database update`

Após corrigir os caminhos e instalar as dependencias apenas executar p programa com dotnet run.

