create database bd_Prototipo_AtvFinal;
use bd_Prototipo_AtvFinal;


create table funcionario(
id_Fun integer primary key auto_increment,
nome_Fun varchar(300),
email_Fun varchar(300),
endereco_Fun varchar(200),
estado_Fun varchar(100),
cidade_Fun varchar(200),
telefone_Fun varchar(50),
rg_Fun varchar(10),
cpf_Fun varchar(11),
data_nas_Fun date, 
funcao_social_Fun varchar(200),
estado_civil_Fun varchar(100),
salario_Fun double
);

Alter table funcionario
modify column cpf_Fun varchar(20);

create table empresa(
id_Emp integer primary key auto_increment,
cnpj_Emp varchar(50),
situacao_cadastral_Emp varchar(200),
capital_social_Emp varchar(200),
razao_social_Emp varchar(200),
nome_fantasia_Emp varchar(200),
tipo_Emp varchar(200),
data_inicio_atividade_Emp date,
telefone_Emp varchar(20),
regime_tributario_Emp varchar (200),
cidade_Emp varchar(200),
natureza_jur_Emp varchar(150),
estado_Emp varchar(100),
porte_Empresa_Emp varchar(100),
nome_proprietario_Emp varchar(300),
cpf_proprietario_Emp varchar(20)
);


select * from funcionario;
