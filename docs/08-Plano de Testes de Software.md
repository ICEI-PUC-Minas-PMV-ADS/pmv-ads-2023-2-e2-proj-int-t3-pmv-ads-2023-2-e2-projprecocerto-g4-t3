# Plano de Testes de Software

Os requisitos para realização dos testes de software são: <br>
 * Computador ou smartphone com acesso a um navegador. <br>
 * Navegador da Internet - Chrome, Firefox ou Edge <br>

Os testes funcionais a serem realizados no aplicativo são descritos a seguir.
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-002 - O sistema deve permitir cadastrar o perfil de administradores autorizados com credenciais únicas |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (Nome, CEP, Endereço, Complemento, Número, E-mail, Telefone, Senha,  Confirmar senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-02 – Efetuar login**	|
|Requisito Associado | RF-001	- O sistema deve permitir o login de administradores autorizados com credenciais únicas |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | O login foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-03 – Comparar preços**	|
|Requisito Associado | RF-008	- O sistema deve permitir que os usuários comparem os preços dos produtos em diferentes supermercados. |
| Objetivo do Teste 	| Verificar se o usuário consegue comparar os preços dos produtos em diferentes supermercados. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Localizar um produto <br> - Adiconar ao carrinho <br> - Ir no carrinho <br> - Clicar no filtro <br> - Escolher um supermercado <br> - Clicar em "Comparar preço"|
|Critério de Êxito | O preço comparado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-04 – Visualizar promoções**	|
|Requisito Associado | RF-011	- O sistema deve permitir que os usuários visualizem promoções. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar as promoções |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Visualizar a página principal <br> - Clica na aba de promoções <br> - Localiza o banner as promoções <br> - Interege com as promoçoes |
|Critério de Êxito | O usuário visualiza as promoções com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-05 – Visualizar promoções**	|
|Requisito Associado | RF-010	- O sistema deve permitir que os usuários pesquisem produtos com base em vários critérios, como nome, preço e categoria. |
| Objetivo do Teste 	| Verificar se o usuário consegue pesquisar produtos |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Visualizar a página principal <br> - Localizar a barra de pesquisa <br> - Digitar o nome do produto |
|Critério de Êxito |  O usuário poderá vizualizar o produto desejado. |
|  	|  	|
| **Caso de Teste** 	| **CT-06 – Promoções a partir da Data de Validade**	|
|Requisito Associado | RF-009 - O sistema deve permitir ao administrador automatizar promoções de produtos a partir da data de validade. |
| Objetivo do Teste 	| Verificar se o administrador consegue configurar promoções de produtos que serão ativadas com base na data de validade. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Acessar o sistema como administrador. <br> - Navegar até a seção de configuração de promoções ou produtos <br> - Escolher o produto ao qual a promoção será aplicada  <br> - Definir a data de início da promoção <br> - Definir a data de validade do produto <br> - Especificar as condições para ativar a promoção <br> - Salvar as configurações da promoção|
|Critério de Êxito |  promoção configurada é ativada quando a data de validade do produto atinge a data de início da promoção. |
|  	|  	|
| **Caso de Teste** 	| **CT-07 – Inscrições em Notificações por E-mail**	|
|Requisito Associado | RF-007	- O sistema deve permitir a gestão das inscrições de usuários em notificações por e-mail, incluindo a adição, remoção e edição de assinaturas relacionadas a promoções e descontos. |
| Objetivo do Teste 	| Verificar se os usuários podem gerenciar suas inscrições em notificações por e-mail, incluindo adição, remoção e edição de assinaturas relacionadas a promoções e descontos. |
| Passos 	|  - Acessar o navegador <br> - Informar o endereço do site <br> - Navegar até as configurações de notificações por e-mail <br> - Adicionar uma nova inscrição em notificações por e-mail relacionadas a promoções e descontos <br> - Verificar se é possível remover uma inscrição existente em notificações por e-mail relacionadas a promoções e descontos <br> - Editar uma inscrição existente em notificações por e-mail relacionadas a promoções e descontos <br> - Salvar as configurações |
|Critério de Êxito |  O usuário consegue adicionar, remover e editar suas inscrições em notificações por e-mail relacionadas a promoções e descontos com sucesso |
|  	|  	|
| **Caso de Teste** 	| **CT-08 – Gerenciamento de Informações de Clientes**	|
|Requisito Associado | RF-004	- O sistema deve permitir a criação, visualização, edição e exclusão de informações de clientes, incluindo nome, endereço, e-mail e telefone. |
| Objetivo do Teste 	| Verificar se o sistema permite o gerenciamento eficaz das informações de clientes |
| Passos 	|  - Acessar o navegador <br> - Informar o endereço do site <br> - Acessar o sistema como um usuário com permissões de administrador <br> - Navegar até a seção de gerenciamento de clientes <br> - Criar um novo registro de cliente <br> - Salvar o novo registro de cliente <br> - Visualizar informações de clientes existentes <br> - Editar as informações de um cliente existente <br> - Excluir um registro de cliente existente |
|Critério de Êxito |  O sistema permite a criação, visualização, edição e exclusão de informações de clientes de forma eficaz e precisa |
|  	|  	|
