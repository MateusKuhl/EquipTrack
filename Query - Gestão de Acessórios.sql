CREATE DATABASE gestao_de_acessorios;
GO

USE gestao_de_acessorios;
GO

CREATE TABLE login
(
	id INT IDENTITY PRIMARY KEY NOT NULL ,
	ra VARCHAR(30) NOT NULL ,
	senha VARCHAR(30) NOT NULL ,
)


CREATE TABLE funcionario
(
	id_Funcionario INT IDENTITY PRIMARY KEY NOT NULL,
	nome_Funcionario VARCHAR(45) NOT NULL ,
	cargo_Funcionario VARCHAR(30) NOT NULL ,
	email_Funcionario VARCHAR(30) NOT NULL,
	
)

CREATE TABLE item
(
	id_Item INT IDENTITY PRIMARY KEY NOT NULL, -- INDICA QUE A COLUNA É UMA PRIMARY KEY, E REALIZA O AUTOINCREMENT
	nome_Item VARCHAR(45) NOT NULL ,
	situacao_Item VARCHAR(15) NOT NULL,
	quantidade_Item INT NOT NULL,

)

CREATE TABLE agenda_funcionario
(
	id_Funcionario INT FOREIGN KEY REFERENCES funcionario(id_Funcionario),
	id_Agendamentos INT IDENTITY PRIMARY KEY NOT NULL,
	data_Agendamento date NOT NULL ,
	horario VARCHAR(15) ,
	situacao_Agendamento VARCHAR(12) ,
	bloco VARCHAR(3) ,
	sala VARCHAR(15) ,
)

CREATE TABLE item_agenda
(
	id_Item_Agenda INT IDENTITY PRIMARY KEY NOT NULL,
	id_Item INT FOREIGN KEY REFERENCES item(id_Item),
	id_Agendamentos INT FOREIGN KEY REFERENCES agenda_funcionario(id_Agendamentos),
	quantidade_Itens INT NOT NULL,
)