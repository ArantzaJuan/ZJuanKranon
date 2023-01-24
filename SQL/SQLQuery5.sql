create database ZJuanKranon 
create table Libro 
(IdLibre int primary key identity (1,1),
Autor VARCHAR (50),
TItulo VARCHAR (50),
AñoPublicacion VARCHAR (4),
Editorial VARCHAR (20))

--Crear los Stored Procedures que permitan lo siguiente:
--• Crear nueva información de libro.
--• Consulta de libros por autor.
--• Consulta de libros por título de libro.
--• Consulta de libros por fecha de publicación.
--• Consulta de libros por editorial.
--• Consulta de libros por autor y fecha de publicación.

GO
CREATE PROCEDURE LibroAdd
@Autor VARCHAR (50),
@TItulo VARCHAR (50),
@AñoPublicacion VARCHAR (4),
@Editorial VARCHAR (20)
AS
INSERT INTO Libro(Autor, TItulo, AñoPublicacion,Editorial)
VALUES (@Autor,@TItulo,@AñoPublicacion,@Editorial)
Go
CREATE PROCEDURE LibrosporAutor 
@Autor Varchar (50)
AS
Select IdLibre,Autor, TItulo, AñoPublicacion,Editorial
From Libro  
WHERE Autor= @Autor
GO
CREATE PROCEDURE LibrosporAño
@AñoPublicacion Varchar (4)
AS
Select IdLibre,Autor, TItulo, AñoPublicacion,Editorial
From Libro  
WHERE AñoPublicacion= @AñoPublicacion 
GO
CREATE PROCEDURE LibrosporTitulo
@TItulo VARCHAR (50)
AS
Select IdLibre,Autor, TItulo, AñoPublicacion,Editorial
From Libro  
WHERE TItulo= @TItulo
go
CREATE PROCEDURE libroporEditorial
@Editorial VARCHAR (20)
AS
Select IdLibre,Autor, TItulo, AñoPublicacion,Editorial
From Libro  
WHERE Editorial= @Editorial
GO

CREATE PROCEDURE LibrosporEditorial
@Editorial VARCHAR (20)
AS
Select IdLibre,Autor, TItulo, AñoPublicacion,Editorial
From Libro  
WHERE Editorial= @Editorial
GO

CREATE PROCEDURE LibrosporAutoryAño
@Autor VARCHAR (20),
@AñoPublicacion Varchar (4)
AS
Select IdLibre, Autor, TItulo, AñoPublicacion,Editorial
From Libro  
where Autor Like'%' + @Autor + '%' AND AñoPublicacion LIKE '%' + @AñoPublicacion 

--• Borrado de libros por autor.
--• Borrado de libros por editorial
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