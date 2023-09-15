# API

**Desenvolvido por:** Igor Cerruti Lima  
**Desafio IBID**

Esta é uma API RESTful de produtos e categorias, criada como parte do Desafio IBID. A API oferece endpoints para gerenciar informações sobre produtos e categorias, permitindo que os desenvolvedores realizem operações como criação, leitura, atualização e exclusão de registros.

Aqui estão os principais endpoints e suas funcionalidades:

- **GET /produtos**: Recupera a lista de todos os produtos disponíveis.
- **GET /produto/{id}**: Retorna informações detalhadas de um produto específico com base em seu ID.
- **POST /produto**: Cria um novo produto com os dados fornecidos no corpo da solicitação.
- **PUT /produto/{id}**: Atualiza os detalhes de um produto existente com base no ID fornecido.
- **DELETE /produto/{id}**: Remove um produto com base em seu ID.

- **GET /categorias**: Retorna a lista de todas as categorias disponíveis.
- **GET /categorias/{id}**: Retorna informações detalhadas de uma categoria específica com base em seu ID.
- **GET /categoria/{id}/produtos**: Recupera todos os produtos associados a uma categoria específica.
- **POST /categorias**: Cria uma nova categoria com os dados fornecidos no corpo da solicitação.
- **PUT /categoria/{id}**: Atualiza os detalhes de uma categoria existente com base no ID fornecido.
- **DELETE /categoria/{id}**: Remove uma categoria com base em seu ID.

Esta API foi desenvolvida usando C# e o framework .NET e utiliza um banco de dados SQLite para armazenamento de dados. Sinta-se à vontade para explorar e utilizar os endpoints para interagir com os recursos de produtos e categorias.

 
 
