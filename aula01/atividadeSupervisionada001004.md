### Semana 1 - Dia 25/05/2022 - Aulas 001a004 - Atividade Supervisionada

### API
* API é uma definição de contratos que permitem a comunicação entre diferentes softwares. Através de um protocolo definido é possível que essa comunicação ocorra. 
* Por exemplo, o BCB (Banco Central do Brasil) possui um conjunto de APIs públicas em (https://dadosabertos.bcb.gov.br/) onde é possível, por exemplo, consultar a cotação do dólar para uma data específica informada através de uma requisição em que são passados os parâmetros definidos no contrato da API (disponível em https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/swagger-ui3/).
* Com os dados obtidos através de uma API, podem se realizar cálculos, operações ou mesmo simplesmente apresentá-los ao usuário.

### REST
* REST é uma sigla para Representational State Transfer.
* REST define um conjunto de restrições e "boas práticas" no desenvolvimento de uma API.
* REST define um conjunto de verbos: GET, PUT, DELETE, POST, PATCH.
* A prática correta seria usar verbos GET para devolver informações, PUT para atualizar informações, DELETE para excluir, POST para adiiconar novas informações, PATCH para atualizar informações isoladas.
* Uma API REST não guarda estado.
* A requisição é realizada via HTTP, sendo possíveis vários formatos, JSON (o mais adotado), plain text, form-data.
* A requisição carrega consigo header (cabeçalho com informações como o host, tokens, cookies, metadados); body (corpo, usualmente com os parâmetros).
* Possui uma comuniçação cliente-servidor.
* Há um contrato estabelecido para a comunitação entre cliente-servidor (uma documentação, por exemplo, Swagger).
* Existência de cache para melhorar a perfomance entre os requests.
* A divisão da arquitetura em camadas, onde tanto o cliente e servidor apenas obtém as respostas ou enviam as requisições, de maneira isolada.
