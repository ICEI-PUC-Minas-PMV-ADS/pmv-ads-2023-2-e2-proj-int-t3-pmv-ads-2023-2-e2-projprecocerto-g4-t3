# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="04-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="08-Plano de Testes de Software.md"> Plano de Testes de Software</a>



| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-002 - O sistema deve permitir cadastrar o perfil de administradores autorizados com credenciais únicas |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
|Critério de Êxito | O cadastro foi realizado com sucesso. |

<br>
<br>

![Cadastro_usuario](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/77369235/59e5f200-142a-4843-86c2-c761d03eba48)


 * Ao acessar nossa aplicação o usuário precisa se cadastrar em nosso sistema e como mostrado na tela acima, o usuário começa inserindo seus dados no formulário de cadastro após clicar no ícone de fazer login.
 * Como a tela mostra o usuario preenche os campos com seus dados e clica no botão verde. Caso o usuário tente acessar o sistema sem inser seus dados nossa validação exibirá a mensagem em cada campo como mostra a tela abaixo:
<br>
   
![Cadastro_validacao](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/77369235/dd922b40-12cf-4875-98ba-8b59bb30a82f)

 * Os campos na tela acima exibem uma mensagem em vermelho informando ao usuário que ele precisa inserir seus dados para criar o cadastro.
<br>

![Usuario_cadastrado](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/77369235/e4fadcd8-16bb-427c-9deb-45220a69d682)

* A tela acima mostra o usuário cadastrado com sucesso em nossa aplicação, bem como mostra os campos para editar, visualizar ou apagar o usuário que foi cadastrado. Recurso esse do administrador do sistema.
<br>

![Apagando_cadastro_usuario](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/77369235/66142e8d-8d42-4b08-bf0e-41f74070425d)


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


![Login_usuario](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/77369235/b5cf9a85-e877-4300-a4c4-279f13ee4cae)

* Após o usuário ter sido cadastrado na tela acima, ele poderá efetuar o login, ele irá preencher os campos com os dados fornecidos no cadastro que são e-mail e senha.
<br>
<br>

![Login_validacao](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/77369235/b2b0e82a-1c61-4c29-b5c3-ab68440018bb)

* Como no formulário de cadastro, no de login caso o usuário tente logar sem inserir os dados, ele também receberá mensagens de aviso nos campos obrigatórios para que forneça seus dados.
<br>
<br>

![Usuario_logado](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-pmv-ads-2023-2-e2-projprecocerto-g4-t3/assets/77369235/a00328ae-6ea5-49c4-9b1a-d1d38635d63f)

* Após o usuário estar logado corretamente, inserindo suas informações de e-mail e senha, seu login será efetivado, e seu nome cadastrado aparecerá no topo da nossa pagina Home, como destacado pelo retângulo vermelho.
## Avaliação

Nessa etapa do nosso projeto, não foram apresentadas falhas na operação do cadastro de usuário e login, por se tratar de um recurso muito bem gerenciado pelo Entity framework.

> **Links Úteis**:
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
