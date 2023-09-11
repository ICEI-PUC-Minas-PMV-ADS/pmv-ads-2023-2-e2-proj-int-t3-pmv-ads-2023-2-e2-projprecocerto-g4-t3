
# Metodologia

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Descreva aqui a metodologia de trabalho do grupo para atacar o problema. Definições sobre os ambiente de trabalho utilizados pela  equipe para desenvolver o projeto. Abrange a relação de ambientes utilizados, a estrutura para gestão do código fonte, além da definição do processo e ferramenta através dos quais a equipe se organiza (Gestão de Times).

### ***Product Backlog***

A priorização do *product backlog* foi realizada seguindo o cronograma do Projeto da disciplina. Portanto, cada etapa coincide com uma *sprint* e os entregáveis de cada etapa também são os entregáveis de cada *sprint*, conforme a tabela abaixo.

*Sprint*   | Etapa da Disciplina                                         | Entregável/Artefato 
---------- | ----------------------------------------------------------- | -----------------
1          | [Etapa 1 - Análise e Projeto de Sistemas de Software](https://pucminas.instructure.com/courses/156804/pages/etapa-1-orientacoes-para-implementacao-desta-etapa) | <ul><li>Definição do problema;</li><li>Proposta de solução;</li><li>Personas e Histórias de usuários</li><li>Requisitos e Restrições;</li><li>Diagrama de Casos de Uso;</li><li>Vídeo de 2 minutos sobre o problema e a solução proposta;</li></ul>
2          | [Etapa 2 - Projeto da solução](https://pucminas.instructure.com/courses/156804/pages/etapa-2-orientacoes-para-implementacao-desta-etapa) | <ul><li>Documentação da Metodologia;</li><li>Diagrama de Classes;</li><li>Diagrama de Fluxo;</li><li>Wireframes interativos;</li><li>Modelo Entidade Relacionamento (Projeto Conceitual);</li><li>Projeto da Base de Dados;</li><li>Plano de Testes de Software;</li><li>Plano de Testes de Usabilidade;</li><li>Projeto do Github com Backlog e Plano de Sprints;</li></ul>
3          | [Etapa 3 - Desenvolvimento da solução - Fase 1](https://pucminas.instructure.com/courses/156804/pages/etapa-3-orientacoes-para-implementacao-desta-etapa) | <ul><li>Template padrão da aplicação interativa;</li><li>Prova de Conceito da Arquitetura (POC) - exemplo de implementação com a integração do front-end com o back-end;</li><li>Programação de Funcionalidades;</li><li>Realização e registro dos testes de software;</li><li>Realização e registro dos testes de usabilidade;</li><li>Projeto do Github com Backlog e Plano de Sprints;</li></ul>
4          | [Etapa 4 - Desenvolvimento da solução Fase 2](https://pucminas.instructure.com/courses/156804/pages/etapa-4-orientacoes-para-implementacao-desta-etapa) | <ul><li>Template padrão da aplicação interativa;</li><li>Programação de Funcionalidades;</li><li>Realização e registro dos testes de software;</li><li>Realização e registro dos testes de usabilidade;</li><li>Projeto do Github com Backlog e Plano de Sprints;</li></ul>
5          | [Etapa 5 - Relatórios das avaliações e entrega da solução](https://pucminas.instructure.com/courses/156804/pages/etapa-5-orientacoes-para-implementacao-desta-etapa) | <ul><li>Relatório do teste de software;</li><li>Relatório do teste de usabilidade;</li><li>Apresentação da solução;</li><li>Projeto do Github com Backlog e Plano de Sprints;</li><li>Vídeo de até 3 minutos;</li></ul>

## Gerenciamento de Projeto

### Divisão de Papéis

Os papéis *Scrum* foram estabelecidos da seguinte forma:

Papel                | Responsável
---------------------| -------------------------
***Product Owner***  | ???
***Scrum Master***   | ???
***Developers***     | Simon Henrique Souza C, Stefany Barbosa Ribeiro, Pedro Henrique Gomes de Souza

### Processo

Para a organização e distribuição das tarefas do projeto, o grupo esta utilizando o GitHub, seguindo os critérios de:
- `Product Backlog`: recebe as tarefas a serem trabalhadas e presenta o Backlogdo produto. Todas as atividades identificadas no decorrer do projeto são incorporadas a esta lista.
- `To Do`: esta lista representa o Sprint Backlog que está sendo trabalhado.
- `In progress`: lista das tarefas iniciadas.
- `Done`: nesta lista são colocadas as tarefas finalizadas e as que passaram pelos testes e controle de qualidade.

#### Backlog em ??/??/????:


### Ferramentas

O desenvolvimento deste projeto foi facilitado pelo uso das seguintes ferramentas:

Finalidade                                          | Ferramenta                   | Link de acesso
--------------------------------------------------- |----------------------------- | -----------------------------
Hospedagem do código-fonte                          |                              |
Hospedagem da documentação                          | *Github*                     |
Gerenciamento do projeto                            | *Github*                     |
Criação dos *wireframes* e do *userflow* interativo | *Figma*                      |
Criação do *userflow* estático                      |                              | 
Comunicação assíncrona                              | *WhatsApp*                   |
Comunicação síncrona                                | *Microsoft Teams*            |
Edição de código e texto                            | *Visual Studio Code*         |
Servidor de hospedagem                              |                              |

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `unstable`: versão já testada do software, porém instável
- `testing`: versão em testes do software
- `dev`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida
