# Teste Pratico DeMaria
----------------------
* Utilizado para elaboração da interface a biblioteca Krypton Toolkit da Component Factory, é uma blibioteca de código aberto para estilização dos Forms, pode ser usado comercialmente sem problemas! 
* Utilizado o pacote Noto Emoji Objects for Google, para os icones, um pacote gratuito de icones fornecido pela Google de uso aberto para distribuição comercial!
* Utilizado PostgreSQL 16.0 (PostgreSQL 16.0, compiled by Visual C++ build 1935, 64-bit).
----------------------
Sobre o Banco de dados: 
* Todos os scripts de criação de banco, tabelas, viewers e usuário de acesso, estão na pasta SCRIPTS dentro do projeto.<br>
  <br>Diagrama do Bando de dados:
  
  ![image](https://github.com/FP-Tainan/TestePraticoDeMaria/assets/147334601/43634468-29ca-47ac-9718-ebb577c537a6)
----------------------
O projeto foi divido em pastas para manter a ordem e facilitar durante a manutenção: 
* Pasta Classes:
  Armazena os arquivos dos Objetos principais onde estão a regra de negócio, além disso contém sub-pastas para melhor navegação, sub pastas:
  * database(Aramazena toda a logica de conexão e comunicação com o banco de dados)
  * Enum(pasta onde os Enumeradores ficam armazenados)
  * Integracoes(Pasta onde estão as classes de manipulação de API's)
  * Utils ( pasta onde ficam as classes auxiliares, como validadores, criptografia e outros semenhantes)
* Pasta Forms:
  Armazena Os formulários do Projeto.
* Pasta Relatórios:
  Armazena os arquivos base de cada relatório do sistema.
* Pasta Resources:
  Armazena os icones e imagens usados no sistema.
* Pasta Scripts:
  Armazena os scripts de criação do banco de dados, criação de usuário de acesso, criação de tabelas e criação de viewers.
  
![image](https://github.com/FP-Tainan/TestePraticoDeMaria/assets/147334601/54c0546b-ac16-4060-8e8a-e2e5d1d99101)

----------------------
Visão geral das telas: 

Tela de cadastro de clientes:

Funcionalidades: 
* Operações CRUD.
* Busca de cliente por nome ou CPF / CNPJ
* Validação de CPF / CNPJ ( fica vermelho se não é válido, fica verde se é válido)
* Mascara automática para: CPF, CNPJ, Telefone, Celular e CEP
* Pesquisa de CEP entregada via API, para preenchimento mais rápido do endereço
* Abertura de pedido de venda direcionando o usuário a tela de Vendas, já preenchendo os dados do cliente com os dados do cliente que está com o cadastro aberto
![image](https://github.com/FP-Tainan/TestePraticoDeMaria/assets/147334601/91459b82-9261-48f3-a26c-b10261f93cea)

Tela de cadastro de Produtos:

Funcionalidades: 
* Operações CRUD.
* Busca de produto por nome
![image](https://github.com/FP-Tainan/TestePraticoDeMaria/assets/147334601/f25117ff-8bde-46dc-a0dc-b86bc743787d)

Tela de cadastro de Vendas:

Funcionalidades: 
* Operações CRUD.
* Busca de produto por número do pedido
* Navegação rápida entre pedidos (anteiror e próximo)
* Lançamentos de Produtos e atualização de lista de produtos do pedido em tempo real
* Resumo do pedido (valor total, valor pago, saldo) atualizados em tempo real conforme lançamentos de produtos e movimentação financeira no caixa
* Atualização do estoque dos produtos conforme finalização do pedido, o sistema entende que ao finalizar a venda, o cliente da empresa já retirou os produtos e fez o acerto do caixa, não é possivel finalizar a venda sem acertar o caixa!
![image](https://github.com/FP-Tainan/TestePraticoDeMaria/assets/147334601/10963ba7-7ba8-4049-8482-a86383e5a8cc)

Tela de caixa: 

Funcionalidades: 
* Caixa vinculado a venda, não é possivel abrir um caixa, sem um numero de pedido de venda vinculado.
* Operação Insert e Read, não é possivel remover os lançamentos no caixa nem altera-los!
* Saida e entrada de valores.
* Visão geral da lista de produtos do pedido de venda e visão do valor total a ser pago.
![image](https://github.com/FP-Tainan/TestePraticoDeMaria/assets/147334601/ef1a1e5d-84d4-429a-987b-970d741267ec)

Tela de Relatórios:

Funcionalidades: 
* Gerar relatórios de controle de estoque, clientes cadastrados, vendas realizadas por período 
![image](https://github.com/FP-Tainan/TestePraticoDeMaria/assets/147334601/8e5bef1c-df8d-44ca-a0d6-26f7639da649)
