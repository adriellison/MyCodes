# MySQL - Trabalhando com as suas primeiras tabelas

MySQL é um Banco de Dados relacional (RDBMS – Relational Database Management Systems) com um modelo de cliente-servidor.

> **RDBMS** é um software de código aberto ou serviço usado na criação e gerenciamento de bancos de dados baseados no modelo relacional.

**Contents**

- [Ferramentas](#ferramentas)
- [Banco de dados Definição](#banco-de-dados)
- [Código aberto](#código-aberto)
- [Modelo Cliente-Servidor](#modelo-cliente-servidor)
- [SQL](#sql)
- [Como funciona o MySQL?](#como-funciona-o-mysql)
- [Comandos](#comandos)

## Ferramentas

| Nome | Site |
| --- | --- |
| Mysql Installer | <https://dev.mysql.com/downloads/installer/> |
| Mysql Community Server | <https://dev.mysql.com/downloads/mysql/> |
| Workbench | <https://www.mysql.com/products/workbench/> |

## Banco de Dados

Banco de dados é um um local onde dados são armazenados e gerenciados. A palavra “relacional” significa que os dados armazenados estão organizados em tabelas.

Cada tabela está relacionada de alguma maneira. Caso o software não suporte o modelo relacional, então chamamos DBMS.

## Código Aberto

Código aberto significa que você tem a liberdade de usar e modificar. Qualquer pessoa pode instalar o software. Você também pode aprender sobre o código e modificá-lo para melhor atender suas necessidades.

Mas o GPL ([GNU – Licença Pública Geral](https://www.gnu.org/licenses/gpl-3.0.pt-br.html)) determina o que é possível ser feito de acordo com as condições. A versão comercializável da licença também está disponível caso você precise de mais flexibilidade e suporte avançado.

## Modelo Cliente-Servidor

Computadores que rodam softwares de RDBMS são chamados clientes. Sempre que precisam de dados, eles se conectam a um servidor RDBMS.

MySQL é um dos muitos clientes RDBMS disponíveis. RDBMS e MySQL são muitas vezes confundidos como sendo a mesma coisa devido a popularidade do MySQL.

Algumas [aplicações de renome](https://stackshare.io/mysql), como Facebook, Twitter, YouTube, Google e Yahoo! utilizam MySQL para o armazenamento de dados.

Mesmo que tenha sido inicialmente criada para uso ilimitado, atualmente é ele compatível com muitas plataformas importantes como Linux, MacOS, Microsoft Windows e Ubuntu.

## SQL

É também importante saber a diferença entre SQL e MySQL.

O MySQL é uma marca de software RDBMS mais populares que utiliza o modelo cliente-servidor.

Mas como o cliente e o servidor se comunicam em um ambiente RDBMS? Eles usam uma linguagem específica – Structured Query Language (SQL).

Se você encontrar outros nomes que também possuam SQL, como PostgreSQL e Microsoft SQL Server, provavelmente são outras marcas que utilizam a sintaxe SQL.

Um software RDBMS é normalmente escrito em outra linguagem de programação, mas sempre utiliza SQL como linguagem primária para comunicação com o banco de dados.

O próprio MySQL é escrito em C e C++. Pense em todos os países colonizados pela Inglaterra, cada um tem sua história e costumes próprios, mas todos falam inglês.

O cientista da computação Ted Codd desenvolveu SQL no início dos anos 70 com um IBM baseado no modelo relacional. A linguagem se tornou mais popular em 1974 substituindo algumas linguagens ultrapassadas, como ISAM e VISAM.

Colocando a história de lado, o SQL informa ao servidor o que deve ser feito com o dado. Ele desempenha as seguintes funções: 

- **Data Query**: Solicitar informações específicas de um banco de dados.
- **Data Manipulation**: Adicionar, excluir, mudar, ordenar e outras operações para modificar os dados, valores ou visuais.
- **Data Identity**: Definir tipos de dados. _Ex_: mudar dados numéricos para integrais. Isso também inclui definir a relação das tabelas no banco de dados.
- **Data Access Control**: Fornece técnicas de segurança para proteger dados, incluindo quem pode visualizar ou usar as informações armazenadas no banco de dados.

## Como funciona o MySQL?

![Mysql cliente servidor](https://www.hostinger.com.br/tutoriais/wp-content/uploads/sites/12/2019/01/solita%C3%A7%C3%A3o-e-resposta-mysql.png)

A imagem explica a estrutura básica de um modelo cliente-servidor. Um ou mais dispositivos (clientes) conectam com o servidor através de uma rede específica.

Cada cliente pode fazer a solicitação através de uma interface gráfica do usuário (IGU) em suas telas. E o servidor vai produzir o melhor resultado, desde que ambos entendam as instruções. Sem entrar muito nos méritos técnicos, os principais processos que acontecem em um ambiente MySQL são os mesmos.

1. O MySQL cria um banco de dados para armazenamento e manipulação de dados, definindo a relação de cada tabela.

2. Clientes podem fazer solicitações digitando comandos SQL específicos no MySQL.

3. A aplicação do servidor responde com a informação solicitada fazendo aparecer no cliente.

Quanto ao cliente, geralmente se enfatiza qual IGU MySQL é utilizado. Quanto mais leve e simples de usar for o GUI, mais eficiente será.

Alguns dos IGU mais populares são MySQL WorkBench, SequelPro, DBVisualizer e Navicat DB Admin Tool.

Alguns deles são gratuitos, enquanto outros são pagos. Alguns rodam exclusivamente no MacOS, enquanto outros são compatíveis com os maiores sistemas operacionais.

Cada cliente deve escolher um IGU de acordo com suas necessidades. Para gerenciamento de bancos de dados web, incluindo sites WordPress, a opção mais comum é o **phpMyAdmin**.

## Comandos

- Criar banco

```sql
CREATE DATABASE DADOS;
```

- Usar banco

```sql
USE DADOS;
```

- Criar tabela

```sql
CREATE TABLE PESSOAS(
	ID INT PRIMARY KEY NOT NULL,
	NOME VARCHAR(50),
	NASCIMENTO DATE
)
```

- Criar tabela temporária

A parte de declaração que se encontra entre colchetes é opcional:

```sql
CREATE [TEMPORARY] TABLE [IF NOT EXISTS] tbl_name
(create_definition, ...)
```

> **TEMPORARY**: Indica que a tabela criada será temporária, ou seja, ela expira assim que sua **sessão no MySQL** terminar. Use-a sempre que estiver fazendo testes.

> **IF NOT EXISTS**: Verifica a prévia existência da tabela e evita uma interrupção do script causada por erro. Como o MySQL é case sensitive, tabelas com nomes iguais, mas usando letras em caixa alta, como em `tbl_name` e `Tbl_name`, são consideradas tabelas totalmente diferentes.

- Inserir dados

```sql
INSERT INTO PESSOAS (ID, NOME, NASCIMENTO) VALUES (01, 'André Felipe', '1998-05-14');
```

```sql
INSERT PESSOAS VALUES (02, 'Vannessa Amber', '1999-07-20');
```

- Visualizar todos os dados

```sql
SELECT * FROM PESSOAS;
```

- Visualizar campos definidos

```sql
SELECT NOME, NASCIMENTO FROM PESSOAS;
```

- Atualizar dados

```sql
UPDATE PESSOAS SET NOME = 'And Santos' WHERE ID = 01;
```

> **OBS: Se não filtrar os dados, todos os registros serão modificados**

- Selecionar dados de forma ordenada

```sql
SELECT * FROM PESSOAS ORDER BY NOME;
```

De forma descrescente com `DESC` ou crescente com `ASC`

```sql
SELECT * FROM PESSOAS ORDER BY NOME DESC;
```

- Selecionar dados de forma agrupada de acordo com critério

No caso abaixo, posso agrupar as pessoas com o nome igual

```sql
SELECT * FROM PESSOAS GROUP BY NOME;
```

- Contar valores que atendem uma determinada critério

```sql
SELECT COUNT(QTD), GENERO FROM PESSOAS GROUP BY GENERO;
```

- Apagar registro da tabela

```sql
DELETE FROM PESSOAS WHERE ID = 2;
```

---
[>> Voltar ao topo >>](#mysql---trabalhando-com-as-suas-primeiras-tabelas)