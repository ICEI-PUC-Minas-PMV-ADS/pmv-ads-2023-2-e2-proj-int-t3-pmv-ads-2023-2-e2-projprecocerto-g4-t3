# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Os detalhes levantados nesse processo foram consolidados na forma de pessoas e histórias de usuários.

## Personas

As pessoas levantadas durante o processo de compreensão do problema são apresentadas nas figuras que se seguem.

![Alt text](<Larissa A.png>)
![Alt text](<Igor M.png>)
![Alt text](<Renato N.png>)
![Alt text](<Bianca C.png>)

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| **Requisito Funcional** | **Descrição**                                                                                                                                                                | **Classificação** |
|--------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-------------------|
| RF-001                 | O sistema deve permitir o login de administradores autorizados com credenciais únicas    | Alta             |
| RF-002                 | O sistema deve possibilitar a visualização e edição das informações das contas de usuário, incluindo nome, e-mail, papel no sistema, e status de ativação    | Média              |
| RF-003                 | O sistema deve permitir a criação, visualização, edição e exclusão de informações de clientes, incluindo nome, endereço, e-mail e telefone    | Alta              |
| RF-004                 | O sistema deve possibilitar a gestão de produtos, permitindo adicionar, editar, remover e categorizar itens, além de especificar informações como nome, preço e descrição.    | Alta              |
| RF-005                 | O sistema deve permitir a visualização das avaliações e opiniões dos usuários sobre supermercados e produtos, além de possibilitar a remoção de avaliações inadequadas.    | Baixa              |

### Requisitos não Funcionais

| **Requisito Não Funcional** | **Descrição**                                                                                                                                                                | **Classificação** |
|--------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-------------------|
| RNF-001                  | Publicação em Ambiente Online: O site deve ser disponibilizado em um ambiente acessível publicamente na Internet, podendo ser hospedado em plataformas como Repl.it, GitHub Pages ou Heroku.                  | MÉDIA             |
| RNF-002                  | Segurança contra Malwares: O site deve ser robustamente protegido contra ameaças como malwares e trojans, assegurando a integridade e confiabilidade das operações.                   | ALTA              |
| RNF-003                  | Compatibilidade com Navegadores: O site deve ser compatível com os principais navegadores utilizados no mercado, incluindo Google Chrome, Firefox e Microsoft Edge, garantindo uma experiência consistente para os usuários. | ALTA              |
| RNF-004                  | Escalabilidade de Desempenho: O site deve ser capaz de suportar um elevado volume de usuários simultâneos sem comprometer o desempenho, mantendo sua eficiência mesmo em situações de alta demanda.  | ALTA              |
| RNF-005                  | Disponibilidade Contínua: O site deve permanecer operacional 24 horas por dia, todos os dias da semana, garantindo sua acessibilidade constante aos usuários.                          | ALTA              |
| RNF-006                  | Tecnologias de Desenvolvimento: O site será desenvolvido utilizando as linguagens HTML5 e JavaScript, garantindo a utilização de tecnologias modernas e amplamente aceitas.        | ALTA              |
| RNF-007                  | Responsividade em Dispositivos Móveis: O site deverá ser responsivo, proporcionando uma experiência adequada de visualização em dispositivos móveis, otimizando a usabilidade nesses contextos.  | MÉDIA             |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
