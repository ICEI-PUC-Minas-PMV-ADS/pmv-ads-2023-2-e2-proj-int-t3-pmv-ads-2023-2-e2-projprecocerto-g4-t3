# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Os detalhes levantados nesse processo foram consolidados na forma de pessoas e histórias de usuários.

## Personas

As pessoas levantadas durante o processo de compreensão do problema são apresentadas nas figuras que se seguem.

![Alt text](<Larissa A-1.png>)
![Alt text](<Igor M-1.png>)
![Alt text](<Renato N-1.png>)
![Alt text](<Bianca C-1.png>)

## Histórias de Usuários

A partir da compreensão do dia a dia das histórias das pessoas identificadas para o projeto, foram registradas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Larissa | Desejo controlar os gastos ao fazer as compras | Para economizar nas compras |
|Larissa |Desejo um jeito fácil e barato de fazer as suas compras mensais | Para gastar menos sem perder tempo |
|Igor | Desejo gastar menos nas compras | Por que não ganha tão bem |
|Igor | Desejo ir menos de mercado em mercado todo mês | Por que está cansada demais para isso |
|Renato | Desejo ter uma maneira mais fácil de fazer as compras | Por que acha estressante sair de casa com a esposa para lugares lotados |
|Renato | Desejo um site e aplicativo para saber onde gastaria menos | Para que consiga realizar suas compras sem estresse de forma econômica |
|Bianca | Desejo saber onde as minhas compras no total ficariam mais baratas | Para ir direto no mercado mais barato |
|Bianca | Desejo saber onde o produto x tem o melhor preço | Para não perder tempo pesquisando preço |

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
| RF-006                 | O sistema deve permitir a gestão das inscrições de usuários em notificações por e-mail, incluindo a adição, remoção e edição de assinaturas relacionadas a promoções e descontos.    | Baixa              |
| RF-007                 | O sistema deve permitir que os usuários comparem os preços dos produtos em diferentes supermercados.    | Alta              |
| RF-008                 | O sistema dever permitir o administrador automatizar promoções  de produtos a partir da data de validade.    | Alta              |
| RF-009                 | O sistema deve permitir que os usuários pesquisem supermercados próximos a sua localização com base em diferentes critérios, como distância, disponibilidade de estacionamento, horário de funcionamento, entre outros.     | Baixa              |


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

| Restrição | Descrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo ultrapassar a data de 06 Dezembro 2023.     |
|RE-02| O projeto deve ser limitado a linguagem de programação C#.       |
|RE-03| O projeto deve ser limitado a um banco de dados relacional.        |
|RE-04| A equipe não pode subcontratar o desenvolvimento do trabalho.        |


## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
