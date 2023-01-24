create database ZJuanKranon 
create table Libro 
(IdLibre int primary key identity (1,1),
Autor VARCHAR (50),
TItulo VARCHAR (50),
A�oPublicacion VARCHAR (4),
Editorial VARCHAR (20))

--Crear los Stored Procedures que permitan lo siguiente:
--� Crear nueva informaci�n de libro.
--� Consulta de libros por autor.
--� Consulta de libros por t�tulo de libro.
--� Consulta de libros por fecha de publicaci�n.
--� Consulta de libros por editorial.
--� Consulta de libros por autor y fecha de publicaci�n.

GO
CREATE PROCEDURE LibroAdd
@Autor VARCHAR (50),
@TItulo VARCHAR (50),
@A�oPublicacion VARCHAR (4),
@Editorial VARCHAR (20)
AS
INSERT INTO Libro(Autor, TItulo, A�oPublicacion,Editorial)
VALUES (@Autor,@TItulo,@A�oPublicacion,@Editorial)
Go
CREATE PROCEDURE LibrosporAutor 
@Autor Varchar (50)
AS
Select IdLibre,Autor, TItulo, A�oPublicacion,Editorial
From Libro  
WHERE Autor= @Autor
GO
CREATE PROCEDURE LibrosporA�o
@A�oPublicacion Varchar (4)
AS
Select IdLibre,Autor, TItulo, A�oPublicacion,Editorial
From Libro  
WHERE A�oPublicacion= @A�oPublicacion 
GO
CREATE PROCEDURE LibrosporTitulo
@TItulo VARCHAR (50)
AS
Select IdLibre,Autor, TItulo, A�oPublicacion,Editorial
From Libro  
WHERE TItulo= @TItulo
go
CREATE PROCEDURE libroporEditorial
@Editorial VARCHAR (20)
AS
Select IdLibre,Autor, TItulo, A�oPublicacion,Editorial
From Libro  
WHERE Editorial= @Editorial
GO

CREATE PROCEDURE LibrosporEditorial
@Editorial VARCHAR (20)
AS
Select IdLibre,Autor, TItulo, A�oPublicacion,Editorial
From Libro  
WHERE Editorial= @Editorial
GO

CREATE PROCEDURE LibrosporAutoryA�o
@Autor VARCHAR (20),
@A�oPublicacion Varchar (4)
AS
Select IdLibre, Autor, TItulo, A�oPublicacion,Editorial
From Libro  
where Autor Like'%' + @Autor + '%' AND A�oPublicacion LIKE '%' + @A�oPublicacion 

--� Borrado de libros por autor.
--� Borrado de libros por editorial
GO
CREATE PROCEDURE LibroDeleteAutor
@Autor VARCHAR(50)
AS DELETE FROM Libro
WHERE Autor = @Autor
GO

CREATE PROCEDURE LibroDeleteEditorial
@Editorial VARCHAR(50)
AS DELETE FROM Libro
WHERE Editorial = @Editorial