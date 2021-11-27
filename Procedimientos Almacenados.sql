USE BD_BIBLIOTECA
GO

SET DATEFORMAT DMY
GO

/*
	FORMULARIO DE AUTORES
*/
---LISTA DE AUTORES PARA EL DGV
IF OBJECT_ID('SP_LISTARAUTOR') IS NOT NULL
	DROP PROC SP_LISTARAUTOR
GO
CREATE PROC SP_LISTARAUTOR
AS
	SELECT id_autor AS ID,nom_autor AS NOMBRE, ape_autor AS APELLIDO,
		nac_autor AS PAIS FROM AUTOR ORDER BY NOMBRE ASC
GO

---AGREGAR AUTOR
IF OBJECT_ID('SP_AGREGARAUTOR') IS NOT NULL
	DROP PROC SP_AGREGARAUTOR
GO
CREATE PROC SP_AGREGARAUTOR(
@NOM VARCHAR(50),
@APE VARCHAR(50),
@NAC VARCHAR(50))
AS
	INSERT INTO AUTOR(nom_autor,ape_autor,nac_autor) 
		VALUES(@NOM,@APE,@NAC)
GO

---ELIMINAR AUTOR
IF OBJECT_ID('SP_ELIMINARAUTOR') IS NOT NULL
	DROP PROC SP_ELIMINARAUTOR
GO
CREATE PROC SP_ELIMINARAUTOR(@IDE INT)
AS
	DELETE FROM AUTOR WHERE id_autor=@IDE
GO

---MODIFICAR AUTOR
IF OBJECT_ID('SP_MODIFICARAUTOR') IS NOT NULL
	DROP PROC SP_MODIFICARAUTOR
GO
CREATE PROC SP_MODIFICARAUTOR(
@IDE INT,
@NOM VARCHAR(50),
@APE VARCHAR(50),
@NAC VARCHAR(50))
AS
	UPDATE AUTOR
		SET nom_autor=@NOM,ape_autor=@APE,nac_autor=@NAC
		WHERE id_autor=@IDE
GO

/*
	FORMULARIO DE EDITORIALES
*/
---LISTA DE EDITORIALES EN EL DGV
IF OBJECT_ID('SP_LISTAREDITORIAL') IS NOT NULL
	DROP PROC SP_LISTAREDITORIAL
GO
CREATE PROC SP_LISTAREDITORIAL
AS
	SELECT id_edi AS ID,nom_edi AS EDITORIAL, telf_edi AS TEL�FONO,
		email_edi AS CORREO FROM EDITORIAL ORDER BY EDITORIAL ASC
GO

---AGREGAR EDITORIAL
IF OBJECT_ID('SP_AGREGAREDITORIAL') IS NOT NULL
	DROP PROC SP_AGREGAREDITORIAL
GO
CREATE PROC SP_AGREGAREDITORIAL(
@NOM VARCHAR(50),
@TLF VARCHAR(50),
@EMA VARCHAR(50))
AS
	INSERT INTO EDITORIAL(nom_edi,telf_edi,email_edi) 
		VALUES(@NOM,@TLF,@EMA)
GO

---ELIMINAR EDITORIAL
IF OBJECT_ID('SP_ELIMINAREDITORIAL') IS NOT NULL
	DROP PROC SP_ELIMINAREDITORIAL
GO
CREATE PROC SP_ELIMINAREDITORIAL(@IDE INT)
AS
	DELETE FROM EDITORIAL WHERE id_edi=@IDE
GO

---MODIFICAR EDITORIAL
IF OBJECT_ID('SP_MODIFICAREDITORIAL') IS NOT NULL
	DROP PROC SP_MODIFICAREDITORIAL
GO
CREATE PROC SP_MODIFICAREDITORIAL(
@IDE INT,
@NOM VARCHAR(50),
@TLF VARCHAR(50),
@EMA VARCHAR(50))
AS
	UPDATE EDITORIAL
		SET nom_edi=@NOM,telf_edi=@TLF,email_edi=@EMA
		WHERE id_edi=@IDE
GO

/*
	FORMULARIO DE LIBROS
*/
---LISTA DE AUTORES PARA COMBOBOX
IF OBJECT_ID('SP_AUTORCOMBO') IS NOT NULL
	DROP PROC SP_AUTORCOMBO
GO
CREATE PROC SP_AUTORCOMBO
AS
	SELECT id_autor,nom_autor+SPACE(1)+ape_autor AS autor FROM AUTOR ORDER BY autor ASC

GO

---LISTA DE EDITORIALES PARA COMBOBOX
IF OBJECT_ID('SP_EDITORIALCOMBO') IS NOT NULL
	DROP PROC SP_EDITORIALCOMBO
GO
CREATE PROC SP_EDITORIALCOMBO
AS
	SELECT id_edi,nom_edi FROM EDITORIAL ORDER BY nom_edi ASC

GO

---LISTA DE LIBROS EN EL DGV
IF OBJECT_ID('SP_LISTARLIBRO') IS NOT NULL
	DROP PROC SP_LISTARLIBRO
GO
CREATE PROC SP_LISTARLIBRO
AS
	SELECT L.id_libro AS ID,L.nom_libro AS LIBRO, A.nom_autor+SPACE(1)+A.ape_autor AS AUTOR,
		E.nom_edi AS EDITORIAL, L.fech_lanz AS LANZAMIENTO FROM LIBRO L 
	JOIN AUTOR A ON A.id_autor= L.id_autor
	JOIN EDITORIAL E ON E.id_edi = L.id_edi
GO

---AGREGAR LIBRO
IF OBJECT_ID('SP_AREGARLIBRO') IS NOT NULL
	DROP PROC SP_AREGARLIBRO
GO
CREATE PROC SP_AREGARLIBRO(
@NOM VARCHAR(50),
@AUT INT,
@EDI INT,
@LAN DATETIME)
AS
	INSERT INTO LIBRO (nom_libro,id_autor,id_edi,fech_lanz)
		VALUES(@NOM,@AUT,@EDI,@LAN)
GO

---ELIMINAR LIBRO
IF OBJECT_ID('SP_ELIMINARLIBRO') IS NOT NULL
	DROP PROC SP_ELIMINARLIBRO
GO
CREATE PROC SP_ELIMINARLIBRO(@IDE INT)
AS
	DELETE FROM LIBRO WHERE id_libro=@IDE
GO

---MODIFICAR LIBRO
IF OBJECT_ID('SP_MODIFICARLIBRO') IS NOT NULL
	DROP PROC SP_MODIFICARLIBRO
GO
CREATE PROC SP_MODIFICARLIBRO(
@IDE INT,
@NOM VARCHAR(50),
@AUT INT,
@EDI INT,
@LAN DATETIME)
AS
	UPDATE LIBRO
		SET nom_libro=@NOM,id_autor=@AUT,id_edi=@EDI,fech_lanz=@LAN
		WHERE id_libro=@IDE
GO

/*
	FORMULARIO PRESTAMOS
*/
---LISTA DE ALUMNOS PARA COMBOBOX
IF OBJECT_ID('SP_ALUMNOCOMBO') IS NOT NULL
	DROP PROC SP_ALUMNOCOMBO
GO
CREATE PROC SP_ALUMNOCOMBO
AS
	SELECT id_alum,nom_alum+SPACE(1)+ape_alum AS alumno FROM ALUMNO ORDER BY alumno ASC

GO

---LISTA DE LIBROS PARA COMBOBOX
IF OBJECT_ID('SP_LIBROCOMBO') IS NOT NULL
	DROP PROC SP_LIBROCOMBO
GO
CREATE PROC SP_LIBROCOMBO
AS
	SELECT id_libro,nom_libro FROM LIBRO ORDER BY nom_libro ASC

GO

---LISTA DE PRESTAMOS EN EL DGV
IF OBJECT_ID('SP_LISTARPRESTAMO') IS NOT NULL
	DROP PROC SP_LISTARPRESTAMO
GO
CREATE PROC SP_LISTARPRESTAMO
AS
	SELECT P.id_pres AS N�MERO,A.nom_alum+SPACE(1)+A.ape_alum AS ALUMNO, L.nom_libro AS LIBRO,
		P.fech_pres AS PR�STAMO, P.fech_devo AS DEVOLUCI�N FROM PRESTAMO P
	JOIN ALUMNO A ON A.id_alum= P.id_alum
	JOIN LIBRO L ON L.id_libro = P.id_libro
GO

---AGREGAR PRESTAMO
IF OBJECT_ID('SP_AREGARPRESTAMO') IS NOT NULL
	DROP PROC SP_AREGARPRESTAMO
GO
CREATE PROC SP_AREGARPRESTAMO(
@ALU INT,
@LIB INT,
@PRE DATETIME,
@DEV DATETIME)
AS
	INSERT INTO PRESTAMO(id_alum,id_libro,fech_pres,fech_devo)
		VALUES(@ALU,@LIB,@PRE,@DEV)
GO

---ELIMINAR PRESTAMO
IF OBJECT_ID('SP_ELIMINARPRESTAMO') IS NOT NULL
	DROP PROC SP_ELIMINARPRESTAMO
GO
CREATE PROC SP_ELIMINARPRESTAMO(@IDE INT)
AS
	DELETE FROM PRESTAMO WHERE id_pres=@IDE
GO

---MODIFICAR PRESTAMO
IF OBJECT_ID('SP_MODIFICARPRESTAMO') IS NOT NULL
	DROP PROC SP_MODIFICARPRESTAMO
GO
CREATE PROC SP_MODIFICARPRESTAMO(
@IDE INT,
@ALU INT,
@LIB INT,
@PRE DATETIME,
@DEV DATETIME)
AS
	UPDATE PRESTAMO
		SET id_alum=@ALU,id_libro=@LIB,fech_pres=@PRE,fech_devo=@DEV
		WHERE id_pres=@IDE
GO
