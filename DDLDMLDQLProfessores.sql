/* DDL */

USE Roman;
CREATE DATABASE Roman;

CREATE TABLE TiposUsuario(
	IdTipo int identity primary key,
	Nome varchar(255) not null unique
);

CREATE TABLE Usuarios(
	IdUsuario int identity primary key,
	Nome varchar(255) not null,
	IdTipo int foreign key references TiposUsuario(IdTipo),
	Email varchar(255) not null unique,
	Senha varchar(255) not null 
);

CREATE TABLE Temas(
	IdTema int identity primary key,
	Nome varchar(255) not null unique
);

CREATE TABLE Projetos(
	IdProjeto int identity primary key,
	Nome varchar(255) not null,
	Descricao text not null,
	IdTema int foreign key references Temas(IdTema),
	IdUsuario int foreign key references Usuarios(IdUsuario)
);

/* DDL */

/* DML */

Insert into TiposUsuario(Nome)
values ('Professor'),('Aluno');
Insert into Temas(Nome)
values ('HQs'),('Gestão'),('Gestalt');
Insert into Usuarios(Nome,IdTipo,Senha,Email)
values ('Jorge',2,'123456','email@email.com'),('Samara',1,'123456','emailo@email.com'),('Mariana',2,'123456','emaila@email.com'),('Pedro',1,'123456','emai@email.com');
Insert into Projetos(Nome,Descricao,IdTema,IdUsuario)
values ('Controle de estoque','Controle de estoque dale dale dale',2,2),('Quadrinhos','Quadrinhos homem-aranha dale dale dele',1,4);


/* DML */

/* DQL */

Select * from Projetos;
Select * from Usuarios;
Select * from Temas;
Select * from TiposUsuario;

/* DQL */