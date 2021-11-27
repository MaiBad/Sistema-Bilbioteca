USE MASTER
GO

IF DB_ID('BD_BIBLIOTECA') IS NOT NULL	
	DROP DATABASE BD_BIBLIOTECA
GO

CREATE DATABASE BD_BIBLIOTECA
GO

USE BD_BIBLIOTECA
GO

SET DATEFORMAT DMY
GO

CREATE TABLE AUTOR(
id_autor  INT PRIMARY KEY IDENTITY,
nom_autor VARCHAR(50)     NOT NULL,
ape_autor VARCHAR(50)     NOT NULL,
nac_autor VARCHAR(50)     NOT NULL,
)
GO

CREATE TABLE EDITORIAL(
id_edi    INT PRIMARY KEY IDENTITY,
nom_edi   VARCHAR(50)     NOT NULL,
telf_edi  VARCHAR(9)      NOT NULL,
email_edi VARCHAR(50)     NOT NULL,
)
GO

CREATE TABLE LIBRO(
id_libro  INT PRIMARY KEY IDENTITY,
nom_libro VARCHAR(50)     NOT NULL,
id_autor  INT             NOT NULL,
id_edi    INT             NOT NULL,
fech_lanz DATETIME        NOT NULL,
FOREIGN KEY (id_autor) REFERENCES AUTOR(id_autor),
FOREIGN KEY (id_edi)   REFERENCES EDITORIAL(id_edi),
)
GO

CREATE TABLE CARRERA(
id_carr  INT PRIMARY KEY IDENTITY,
nom_carr VARCHAR(50)     NOT NULL,
)
GO

CREATE TABLE ALUMNO(
id_alum   INT PRIMARY KEY IDENTITY,
nom_alum  VARCHAR(50)     NOT NULL,
ape_alum  VARCHAR(50)     NOT NULL,
id_carr   INT             NOT NULL,
FOREIGN KEY (id_carr) REFERENCES CARRERA(id_carr),
)
GO

CREATE TABLE PRESTAMO(
id_pres   INT PRIMARY KEY IDENTITY,
id_alum   INT             NOT NULL,
id_libro  INT             NOT NULL,
fech_devo DATETIME        NOT NULL,
fech_pres DATETIME        NOT NULL,
FOREIGN KEY (id_alum)  REFERENCES ALUMNO(id_alum),
FOREIGN KEY (id_libro) REFERENCES LIBRO(id_libro),
)
GO

CREATE TABLE HORARIO(
id_hora  INT PRIMARY KEY IDENTITY,
fech_ing DATETIME        NOT NULL,
fecha_sa DATETIME        NOT NULL
)
GO

CREATE TABLE AUTOR_FAVORITO(
id_alum  INT NOT NULL,
id_autor INT NOT NULL,
FOREIGN KEY (id_alum) REFERENCES ALUMNO(id_alum),
FOREIGN KEY (id_autor) REFERENCES AUTOR(id_autor),
)
GO

CREATE TABLE CARNET_TARJETA(
id_alum INT NOT NULL,
id_hora INT NOT NULL,
FOREIGN KEY (id_alum) REFERENCES ALUMNO(id_alum),
FOREIGN KEY (id_hora) REFERENCES HORARIO(id_hora),
)
GO

INSERT INTO AUTOR (nom_autor,ape_autor,nac_autor) VALUES
('Cesar Abraham','Vallejo Mendoza','Perú'),
('Mario','Vargas Llosa','Perú'),
('Pablo','Neruda','Chile')

INSERT INTO EDITORIAL (nom_edi,telf_edi,email_edi) VALUES
('Plaza & Janés','987654321','palzayjanes@gmail.com'),
('Ediciones Peisa S.A.C','976543211','peisasac@gmail.com'),
('Oceano','987654398','oceano@gmail.com')

INSERT INTO LIBRO (nom_libro,id_autor,id_edi,fech_lanz) VALUES
('La guerra del fin del mundo',2,1,'01/03/1982'),
('Trilce',1,2,'01/03/2010'),
('20 Poemas de Amor y una Canción Desesperada',3,3,'01/12/2010')

INSERT INTO CARRERA (nom_carr) VALUES
('Tecnologías de la Información y Comunicación'),
('Producción Industrial'),
('Electrónica'),
('Mecánica'),
('Industrias Alimentarias')

INSERT INTO ALUMNO (nom_alum,ape_alum,id_carr) VALUES
('Charles Jeferson','Limay Cabello',1),
('José Luis','Antezano Mejía',1),
('Joseph','Ocadio Moreno',1),
('Milagros','Leguía Sanchez',2),
('Sebastian','Ortega Huamán',2),
('Diego Francisco','Montenegro Goñe',2),
('Kert Luis','Huamán Huamán',3),
('Gabriela Belén','Ruidiaz Masgo',3),
('Sergio','Vilchez Meza',3),
('Gabriel Paolo','Rodriguez Montoya',4),
('Juan José','Hernandez Sotelo',4),
('Luis Enrique','Leiva Ramos',4),
('Roberto Omar','Espinoza Perez',5),
('Brayan Jorge','Ronald Vargas',5),
('Teddy Diego','Vazquez Mego',5)


SELECT * FROM AUTOR
SELECT * FROM EDITORIAL
SELECT * FROM LIBRO
SELECT * FROM CARRERA
SELECT * FROM ALUMNO
SELECT * FROM PRESTAMO
SELECT * FROM HORARIO
SELECT * FROM AUTOR_FAVORITO
SELECT * FROM CARNET_TARJETA

