# Desafio para desenvolvedor .Net Core

## Link para a aplicação hospedada no Azure: 
> [https://eperin-calc.azurewebsites.net](https://eperin-calc.azurewebsites.net)

## Executar build usando Docker
```
docker-compose up -d
```
Acessar a url http://localhost:8080.

## Executar os testes de Unidade e de Integração
```
dotnet test
```

## Api's
> [/taxajuros](https://eperin-calc.azurewebsites.net/taxajuros)

> [/calculajuros?valorinicial=100&meses=5](https://eperin-calc.azurewebsites.net/calculajuros?valorInicial=100&meses=5)

> [/showmethecode](https://eperin-calc.azurewebsites.net/showmethecode)