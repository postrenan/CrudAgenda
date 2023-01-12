integer
real
serial
numeric

varchar(n)
char(n)
text

boolean

date
time
timestamp

CREATE TABLE agenda(
    id SERIAL,
	data_inicio DATE,
	data_final DATE,
	prazo INTEGER,
	titulo VARCHAR (255),
	descrição TEXT,
	responsavel VARCHAR(255),
	atividades TEXT,
	status BOOLEAN
)


SELECT * FROM agenda;

INSERT INTO agenda(
	id SERIAL,
	data_inicio DATE,
	data_final DATE,
	prazo DATE,
	titulo VARCHAR (255),
	descrição TEXT,
	responsavel VARCHAR(255),
	atividades TEXT,
	status BOOLEAN
)

VALUES (
	id SERIAL,
	data_inicio = 2022-12-29 ,
	data_final = 2023-01-05,
	prazo = 20 ,
	titulo = 'TRABALHO DE GRADUAÇÃO',
	descrição = 'LOREM IPSUM' ,
	responsavel = 'RENAN',
	atividades = 'LOREM LOREM LOREM',
	status = TRUE
	
)


