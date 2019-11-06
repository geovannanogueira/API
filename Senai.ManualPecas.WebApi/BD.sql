create database T_ManualPecas

use T_ManualPecas

create table Pecas
(	
	IdPeca int primary key identity
	,Nome	varchar(255) not null
	,Preco	varchar(255) not null
);

create table Fornecedores
(
	IdFornecedor int primary key identity
	,Nome varchar(255) not null
);

create table Pecas_Funcionarios
(
	IdFornecedor	int foreign key references Fornecedores(IdFornecedor)
	,IdPeca			int foreign key references Pecas(IdPeca)
);

create table Usuarios 
(
	IdUsuario	int primary key identity
	,Email		varchar(255) not null unique
	,Senha		varchar(255) not null
);

insert into Pecas (Nome, Preco) values ('Peca A' , '20 reais')
									,('Peca B' , '25 reais');

insert into Fornecedores (Nome) values ('Fornecedor 1')
									,('Fornecedor 2');

insert into Pecas_Funcionarios (IdFornecedor,IdPeca) values ( 1 , 1)
															,( 2 , 2);

insert into Usuarios (Email, Senha) values ('admin@admin.com' , 'admin')
									,('cliente@cliente.com' , 'cliente');

select * from Pecas

select * from Fornecedores

select * from Pecas_Funcionarios

select * from Usuarios