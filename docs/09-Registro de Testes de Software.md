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
## Avaliação

Nessa etapa do nosso projeto, não foram apresentadas falhas na operação do cadastro de usuário e login, por se tratar de um recurso muito bem gerenciado pelo Entity framework.

> **Links Úteis**:
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
