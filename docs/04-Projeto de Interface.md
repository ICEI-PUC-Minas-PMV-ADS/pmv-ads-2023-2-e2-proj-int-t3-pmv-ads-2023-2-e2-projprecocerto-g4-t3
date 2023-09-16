
# Projeto de Interface

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Visão geral da interação do usuário pelas telas do sistema e protótipo interativo das telas com as funcionalidades que fazem parte do sistema (wireframes).

 Apresente as principais interfaces da plataforma. Discuta como ela foi elaborada de forma a atender os requisitos funcionais, não funcionais e histórias de usuário abordados nas <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a>.

## Diagrama de Fluxo

O diagrama apresenta o estudo do fluxo de interação do usuário com o sistema interativo e  muitas vezes sem a necessidade do desenho do design das telas da interface. Isso permite que o design das interações seja bem planejado e gere impacto na qualidade no design do wireframe interativo que será desenvolvido logo em seguida.

O diagrama de fluxo pode ser desenvolvido com “boxes” que possuem internamente a indicação dos principais elementos de interface - tais como menus e acessos - e funcionalidades, tais como editar, pesquisar, filtrar, configurar - e a conexão entre esses boxes a partir do processo de interação. Você pode ver mais explicações e exemplos https://www.lucidchart.com/blog/how-to-make-a-user-flow-diagram.

![Exemplo de Diagrama de Fluxo](img/diagramafluxo2.jpg)

As referências abaixo irão auxiliá-lo na geração do artefato “Diagramas de Fluxo”.

> **Links Úteis**:
> - [Fluxograma online: seis sites para fazer gráfico sem instalar nada | Produtividade | TechTudo](https://www.techtudo.com.br/listas/2019/03/fluxograma-online-seis-sites-para-fazer-grafico-sem-instalar-nada.ghtml)

## Fluxo de usuário
Depois de muitas reuniões feitas com a equipe de design o seguinte fluxo do usuário (*user flow*) foi criado, a aplicação pode ser visualizada no esquema abaixo ou no [*user flow* interativo](https://www.figma.com/proto/dVkmoqQF66P44CD6LYjOJJ/Wireframes_proj_precocerto_ADS_PUC_E2?type=design&node-id=140-2&t=VEduiTa35ECnsI9y-0&scaling=contain&page-id=0%3A1&starting-point-node-id=140%3A2). Em ambos, é possível compreender como ocorre a interação do usuário com a interface do projeto Preço Certo.
 
![Wireframes_proj_precocerto_ADS_PUC_E2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/128644865/fbe0c7b6-48f6-4cca-b2ab-a85efb6bb140)

## Wireframes

## Home Page
Ao acessar a home page o usuário pode realizar suas buscas por meio da:
- Caixa de pesquisa;
- Por categoria;
- Por corredor.

## Tela de Login
De inicío o usuário poderá cadastrar-se na própria tela de login apenas conectando suas contas de *Facebook* ou do *Google*, mas caso já tenha uma conta, nesse campo, o usuário encontra-rá encontrar:
- Um campo para seu email;
- Para sua senha;
- Um para cadastrar-se.

## Tela de Cadastro
Quando o usuário decidir se cadastrar, nessa tela ele encontra-rá campos de preenchimento que são eles:
- Nome;
- CEP;
- Endereço (que será preenchido automaticamente com o preenchimento do campo CEP)
- Número e complemento (que não são preenchido automaticamente)
- Email;
- Telefone;
- Um campo para adicionar um foto (totalmente opcional).

## Tela Corredores
Essa tela foi pensada para que o usuário sinta que realmente está andando pelos corredores de um supermercado, sendo assim, nela, o usuário encontra:
- Áreas com as categorias de cada corredor, logo abaixo seus respectivos produtos.

## Tela Produto
Ao clicar em um produto presente na maioria das páginas, ocorrerá o redirecionamento para a tela do produto, onde serão exibidas as seguintes informações:
- Nome do produto;
- Informações básicas como, peso, preço, etc;
- Um campo para o produto ser adicionado ao carrinho.

## Tela Categotia Aberta
Ao clicar em uma categoria específica o usuário encontra a tela de categoria aberta, sendo assim podendo visualizar:
- Todos os produtos relacionados aquela mesma categoria (podendo adicionar ao carrinho ali mesmo).

## Tela Carrinho
Já no carrinho, o usuário pode fazer algumas modificações em sua lista como:
- Adicionar produtos;
- Remover produtos;
- Esvaziar o carrinho (limpando totalmente e zerando sua lista);
- E processeguindo para a comparação de preços.

## Tela Comparação entre Mercados
O momento mais importante do usuário, ao finalizar sua lista e seguir para comparação de preços, na tela Comparar Preços o usuário encontra:
- Sua lista representada em três mercados diferentes e seus respectivos totais;
- Um campo para refazer sua comparação.

## Tela Meus pedidos
Em Meus Pedidos, o usuário pode:
- Acompanhar o andamento de seus pedidos;
- Pesquisar um pedido específico pelo seu ID;
- Ver pedidos antigos;
- Confirmar a entrega;
- Excluir um pedido já finalizado.

## Tela Ofertas
Ao selecionar as ofertas, o usuário pode conferir todos os produtos em promção em determinados mercados naquela semana/dia, nessa tela encontra-se:
- Produtos com desconto;
- Um campo para adiciona-los ao carrinho.

## Tela Cupons
Supermercados distribuem cupons todos os dias, na tela cupons, o usuário pode ver:
- Os cupons disponíveis e suas instruções de uso;
- Os cupons indisponíveis;
- Um botão para selecionar os cupons disponíveis.
 
## Tela Minhas Listas Salvas
Quando o usuário salvar uma lista ela estará em Minhas Listas Salvas, nessa tela o usuário pode:
- Ver os produtos apresentados na lista;
- Ir direto para o mercado onde a lista aparece como mais barata;
- Comprar novamente, sendo redirecionado para o carrinho, sendo obrigado a fazer uma nova comparação (uma vez que os valores dos produtos são fluidos);
- Excluir a lista.

## Tela Mercado escolhido Aberto
Ao encontrar o mercado que considera o melhor se tratando de custo benefício, o usuário pode seleciona-lo e prosseguir suas compras. Nessa tela ele encontra:
- Seus produtos e um botão ao lado para adiciona-los ou retirar-los;
- Um campo para salvar sua lista se necessário;
- Um botão "continuar", que o levar para a próxima etapa, a entrega e o pagamento, **que serão responsabilidades do sepermercado escolhido.**
