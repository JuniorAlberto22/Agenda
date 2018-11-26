CREATE TABLE PESSOA(
	ID_PESSOA INT NOT NULL,
	NOME VARCHAR(100),
	EMAIL VARCHAR(100),
	CONSTRAINT PK_PESSOA PRIMARY KEY(ID_PESSOA) 
);

CREATE TABLE TIPO_TELEFONE(
	ID_TIPO_TELEFONE INT NOT NULL,
	TIPO VARCHAR(10),
	CONSTRAINT PK_TIPO_TELEFONE PRIMARY KEY (ID_TIPO_TELEFONE)
);

CREATE TABLE TELEFONE(
	ID_TELEFONE INT NOT NULL,
	ID_PESSOA INT NOT NULL,
	ID_TIPO_TELEFONE INT NOT NULL,
	TELEFONE VARCHAR(14) NOT NULL,
	CONSTRAINT PK_TELEFONE PRIMARY KEY (ID_TELEFONE),
	CONSTRAINT FK_PESSOA FOREIGN KEY (ID_PESSOA) REFERENCES PESSOA(ID_PESSOA),
	CONSTRAINT FK_TIPO_TELEFONE FOREIGN KEY (ID_TIPO_TELEFONE) REFERENCES TIPO_TELEFONE(ID_TIPO_TELEFONE)
);

CREATE TABLE ATIVIDADE(
	ID_ATIVIDADE INT NOT NULL,
	ID_PESSOA INT NOT NULL,
	DESCRICAO_ATIVIDADE TEXT,
	DATA_HORA DATETIME,
	CONSTRAINT PK_ATIVIDADE PRIMARY KEY (ID_ATIVIDADE),
	CONSTRAINT FK_ATIVIDADE_OWNER FOREIGN KEY (ID_PESSOA) REFERENCES PESSOA(ID_PESSOA)
);

CREATE TABLE ATIVIDADE_PESSOA(
	ID_ATIVIDADE_PESSOA INT NOT NULL,
	ID_PESSOA INT NOT NULL,
	ID_ATIVIDADE INT NOT NULL,
	CONSTRAINT PK_ATIVIDADE_PESSOA PRIMARY KEY (ID_ATIVIDADE_PESSOA),
	CONSTRAINT FK_ATIVIDADE_PESSOA FOREIGN KEY (ID_PESSOA) REFERENCES PESSOA(ID_PESSOA),
	CONSTRAINT FK_ATIVIDADE FOREIGN KEY (ID_ATIVIDADE) REFERENCES ATIVIDADE(ID_ATIVIDADE)
);
