# Dashboard - WaProject
## _Projeto feito como um desafio para a WaProject_

Api com um unico end-point que ira retornar uma pesquisa com vinculo por 3 tabelas por ordenação e paginação

## Recursos

- Asp-net core 5 
- Autenticação via Token simples
- Migrate e Seeds
- Camada ViewModel com explicit operator
- Classe base para Paginação simples
- Camada de Repository
- DockerFile

## Gerar as migrations
Deixei um exemplo pela parte de Data estar separada do projeto principal (Projetos diferentes, mesma Solução)
```sh
dotnet ef migrations add CriacaoDasTabelasPedidoEquipeEProdutoESeeds --startup-project ../WaProject.ECommerce.Dashboard --context DashboardContext
```
