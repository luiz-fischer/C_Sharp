# === PROGRAMA LocaCar DESENVOLVIDO EM C# ===

[![Build Status](https://travis-ci.org/condessalovelace/mavenquickstart.svg?branch=master)](https://travis-ci.org/condessalovelace/mavenquickstart) ![Quality Gate](https://sonarcloud.io/api/project_badges/measure?project=br.com%3Amavenquickstart&metric=alert_status) [![Maintenance](https://img.shields.io/badge/Maintained%3F-yes-green.svg)](https://GitHub.com/Naereen/StrapDown.js/graphs/commit-activity) [![Ask Me Anything !](https://img.shields.io/badge/Ask%20me-anything-1abc9c.svg)](https://GitHub.com/Naereen/ama) [![MIT license](https://img.shields.io/badge/License-MIT-blue.svg)](https://lbesson.mit-license.org/)


## Programa desenvolvido com dotnet, EF Core e Mysql 
 ![language](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white) ![BD](https://img.shields.io/badge/MySQL-00000F?style=for-the-badge&logo=mysql&logoColor=white) ![DOTNET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=dot-net&logoColor=white) ![NUGET](https://img.shields.io/badge/NuGet-004880?style=for-the-badge&logo=nuget&logoColor=white) ![GIT](https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white) ![OS](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white) ![VSCODE](https://img.shields.io/badge/Visual_Studio_Code-0078D4?style=for-the-badge&logo=visual%20studio%20code&logoColor=white)

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

- Antes de executar pela primeira vez é recomendado consultar o local de armazenamento das Imagens e quando necessário corrigir o local de armazenamento das Imagens para a execução do programa.
- As imagens estão na Pasta LocaCar\Imagens.
- O local original a ser corrigindo, quando necessário:("C:\\LocaCar\\Imagens\\download1.jpg").

## Install Dependencies

1. `dotnet tool install dotnet-ef -g --version 5.0.5`
2. `dotnet add package Pomelo.EntityFrameworkCore.MySql --version 5.0.0`
3. `dotnet add package Pomelo.EntityFrameworkCore.MySql.Desing --version 1.1.2`
4. `dotnet add package Microsoft.EntityFrameworkCore --version 5.0.6`
5. `dotnet add package Microsoft.EntityFrameworkCore.Desing --version 5.0.6`
6. `dotnet add package Microsoft.Windows.Compatibility --version 3.0.0`

## Building Data Base

1. `dotnet ef migrations add DBv1`
2. `dotnet ef database update`

Após corrigir o local de armazenamento das Imagens, instalar as dependências o Programa pode ser executado.

- dotnet build
- dotnet restore
- dotnet run

## LICENSE [![MIT license](https://img.shields.io/badge/License-MIT-blue.svg)](https://lbesson.mit-license.org/)

### Copyright (c) <2021> LUIZ OTAVIO FISCHER

 Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

 The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.