# API - Desenvolvido por Igor Cerruti Lima (Desafio IBID)

## Descrição

Esta é uma API RESTful de produtos e categorias, desenvolvida como parte do Desafio IBID. A API fornece endpoints para gerenciar informações sobre produtos e categorias, permitindo que os desenvolvedores executem operações de CRUD (Create, Read, Update e Delete) em registros.

## Endpoints Principais

- **Listar Produtos**: `GET /produtos` - Recupera a lista de todos os produtos disponíveis.
- **Detalhes do Produto**: `GET /produto/{id}` - Retorna informações detalhadas de um produto com base no seu ID.
- **Criar Produto**: `POST /produto` - Cria um novo produto com os dados fornecidos no corpo da solicitação.
- **Atualizar Produto**: `PUT /produto/{id}` - Atualiza os detalhes de um produto existente com base no ID fornecido.
- **Excluir Produto**: `DELETE /produto/{id}` - Remove um produto com base no seu ID.

- **Listar Categorias**: `GET /categorias` - Retorna a lista de todas as categorias disponíveis.
- **Detalhes da Categoria**: `GET /categorias/{id}` - Retorna informações detalhadas de uma categoria com base no seu ID.
- **Produtos por Categoria**: `GET /categoria/{id}/produtos` - Recupera todos os produtos associados a uma categoria específica.
- **Criar Categoria**: `POST /categorias` - Cria uma nova categoria com os dados fornecidos no corpo da solicitação.
- **Atualizar Categoria**: `PUT /categoria/{id}` - Atualiza os detalhes de uma categoria existente com base no ID fornecido.
- **Excluir Categoria**: `DELETE /categoria/{id}` - Remove uma categoria com base no seu ID.

## Tecnologias Utilizadas

- Linguagem de Programação: C#
- Framework: .NET
- Banco de Dados: SQLite

