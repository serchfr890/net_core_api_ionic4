Create database Noticias;

Use database Noticias;

Create table Noticia(
	NoticiaID int primary key identity(1,1),
	Titulo varchar(120),
	Descripcion varchar(200),
	Contenido varchar(max),
	Fecha Datetime,
	AutorId int
);

Create table Autor(
	AutorID int primary key identity(1,1),
	Nombre varchar(100),
	Apellido varchar(100)
)