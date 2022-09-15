# gs-backend-modelo
Projeto modelo para criação de um MS em .Net 6.<br/>
Estrutura contempla uma API, multidiomas, com tratativa de erro global, validacoes de campos de entrada, mensagens informativas,
<br/>

## Estrutura do projeto:
- [GS.Backend.Dominios] Representa os dominios de negocio da aplicao, tanto entradas e saidas, quanto os idiomas, excecoes, middlewares, notificacoes, validacoes, processadores e contratos de servicos externos. Aqui ficam os objetos bases para o projeto.
- [GS.Backend.Infra] Configura os servicos que irao compor aplicacao, associacao de command pattern, contratos com servicos externos, idiomas, headers, tudo que deve ser adicionado pela startup do projeto.
- [GS.Backend.Ms] API, projeto o qual tem a classe principal que inicia aplicacao, mas antes adiciona tudo que foi relatado na infra para o funcionamento pleno e saudavel do micro servico.
- [GS.Backend.ServicosExternos] As acoes do negocio, projeto o qual realmente acontece os processamentos.