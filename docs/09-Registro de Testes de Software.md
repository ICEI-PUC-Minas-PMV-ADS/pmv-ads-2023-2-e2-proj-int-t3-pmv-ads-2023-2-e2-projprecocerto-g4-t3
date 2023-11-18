# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="04-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="08-Plano de Testes de Software.md"> Plano de Testes de Software</a>



| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-002 - O sistema deve permitir cadastrar o perfil de administradores autorizados com credenciais únicas |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
|Critério de Êxito | O cadastro foi realizado com sucesso. |

<br>
<br>

![Imagem do WhatsApp de 2023-11-17 à(s) 19 27 20_f84ed663](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/126032592/938e4c85-beb8-4532-bf88-ab5a157a1fc5)



 * Ao acessar nossa aplicação o usuário precisa se cadastrar em nosso sistema e como mostrado na tela acima, o usuário começa inserindo seus dados no formulário de cadastro após clicar no ícone de fazer login.
 * Como a tela mostra o usuario preenche os campos com seus dados e clica no botão verde. Caso o usuário tente acessar o sistema sem inser seus dados nossa validação exibirá a mensagem em cada campo como mostra a tela abaixo:
<br>
   
![Imagem do WhatsApp de 2023-11-17 à(s) 17 50 23_28c6bb20](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/126032592/5b086ef8-c869-411a-9a47-93a55ea441e8)


 * Os campos na tela acima exibem uma mensagem em vermelho informando ao usuário que ele precisa inserir seus dados para criar o cadastro.
<br>


![Imagem do WhatsApp de 2023-11-17 à(s) 19 24 50_32367589](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/126032592/9fc7297e-2448-459e-9431-edc555b099fb)

* A tela acima mostra o usuário cadastrado com sucesso em nossa aplicação, bem como mostra os campos para editar, visualizar ou apagar o usuário que foi cadastrado. Recurso esse do administrador do sistema.
<br>

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/126032592/843b290a-4b17-4eb2-88d5-e17206d1f504)


* Uma vez que tenha um usuário cadastrado, nosso sistema também permite a exclusão de usuários. Como mostrado acima, é exibida uma mensagem de confirmação sobre essa ação.

<br>
<br>

| **Caso de Teste** 	| **CT-02 – Efetuar login**	|
|:---:	|:---	|
|Requisito Associado | RF-001	- O sistema deve permitir o login de administradores autorizados com credenciais únicas |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
|Critério de Êxito | O login foi realizado com sucesso. |

<br>
<br>


![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/126032592/e7a6a7fc-db81-418d-b926-c0de028745b6)


* Após o usuário ter sido cadastrado na tela acima, ele poderá efetuar o login, ele irá preencher os campos com os dados fornecidos no cadastro que são e-mail e senha.
<br>
<br>

![Imagem do WhatsApp de 2023-11-17 à(s) 17 50 07_38021055](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/126032592/bfb45a50-bfca-4ff2-8df2-5dadaf85c56a)


* Como no formulário de cadastro, no de login caso o usuário tente logar sem inserir os dados, ele também receberá mensagens de aviso nos campos obrigatórios para que forneça seus dados.
<br>
<br>

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/126032592/c50485d4-f91e-471b-9fb2-6dd2f2806f40)


* Após o usuário estar logado corretamente, inserindo suas informações de e-mail e senha, seu login será efetivado, e seu nome cadastrado aparecerá no topo da nossa pagina Home, como está destacado em vermelho.

| **Caso de Teste** 	| **CT-03 – Comparar preços**	|
|:---:	|:---	|
|Requisito Associado | RF-008	- O sistema deve permitir que os usuários comparem os preços dos produtos em diferentes supermercados. |
| Objetivo do Teste 	| Verificar se o usuário consegue comparar os preços dos produtos em diferentes supermercados. |
|Critério de Êxito | O preço comparado com sucesso. |

![Comparação](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/128644865/ccec5e85-0f9a-401a-aeb6-80c19768dc75)

* Na tela de comparação o usuário pode verificar com calma em qual mercado efetuar suas compras, mas antes ele deve adicionar os produtos desejados ao carrinho e só então seguir para a comparação de preços.

![WhatsApp Image 2023-11-17 at 19 18 43](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/128644865/ccc6f05a-c242-408b-81da-35f773572b68)

* O usuário pode pesquisar na barra de pesquisa por todos os produtos desejados e se caso estiver com alguma duvida pode selecionar o produto para mais informações.

![WhatsApp Image 2023-11-17 at 18 02 19](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/128644865/ec0f6b37-7f64-4978-b0ac-61fc11b02c2e)

* Quando selecionado, o usuário pode verificar as informações do produto e muito facilmente adiciona-lo ao carrinho.

![WhatsApp Image 2023-11-17 at 18 59 38](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/128644865/99bd66b8-3cd7-427b-911c-edd99df4e6d3)

* A tela de carrinho, quando cheia, é apresentada ao usuário dessa forma, ele pode prosseguir em finalizar compra

![WhatsApp Image 2023-11-17 at 19 00 09](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/128644865/e0a810c5-730c-4254-9010-c449f1626b5a)

* Se o usuário não estiver logado, ele será impedido de concluir sua compra. Se não tiver cadastro deverá fazer um, de forma breve no campo superior direito.

![WhatsApp Image 2023-11-17 at 19 01 20](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/128644865/fc4d332a-e0c0-487d-b2d6-7852d39e528e)

* Após criar sua conta, o usuário pode verificar se o endereço está correto, caso não esteja, pode alterá-lo, caso esteja, pode seguir em finalizar sua compra.

![WhatsApp Image 2023-11-17 at 19 01 56](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/128644865/41727874-a023-4232-9a59-f296376add49)

* Ao finalizar sua compra, o usuário recebe o número de ID do seu pedido.

![WhatsApp Image 2023-11-17 at 19 16 39](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/128644865/5f317b17-a0eb-423b-81d6-e2678d2735e6)
![WhatsApp Image 2023-11-17 at 19 17 15](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/128644865/c43772af-0ac9-48bc-b851-bf50765804ae)

* Caso haja necessidade, ou estiver disponível o cliente pode encontrar cupons por dois caminhos, o primeiro caminho é o aprensentado na primeira imagem, pelo filtro no campo superior esquerdo com o título "Você falou, cupom?" e o segundo caminho é na parte inferior do template, como apresentado na sengunda imagem.

![WhatsApp Image 2023-11-18 at 15 02 42](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/128644865/d59ef70c-926c-450f-808e-6cb3e3f1efa3)

* O usuário pode acompanhar seu pedido pelo campo denominado Meus Pedidos, contendo todas as informações do mesmo.

![WhatsApp Image 2023-11-18 at 15 02 43](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/128644865/8190e67b-1691-40be-9e56-7075d441a996)

* Já em minhas listas o usuário pode ver suas listas, novas e antigas, e se necessário efetuar uma nova compra de forma facil e rápida.

## Extra
## Teste de responsividade
Testamos a aplicação em plataformas diferentes, todos os testes de responsividade foram concluídos sem bugs.

![t1](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/128644865/a982c62c-843f-429d-8f50-03f3020e99e0)
Teste em um Nest Hub Max

![t2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/128644865/6445ade7-5bb0-48b8-877a-49b1c101f301)
Teste em um IPad Air

![t3](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/128644865/db0a8a38-b90e-4ce6-b32b-e48969f7daa1)
Teste em um Iphone SE

## Avaliação

Nessa etapa do nosso projeto, não foram apresentadas falhas na operação do cadastro de usuário, login e simulação de compra, por se tratar de um recurso muito bem gerenciado pelo Entity framework.


