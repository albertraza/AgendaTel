USE [master]
GO
/****** Object:  Database [AgendaTelefonica]    Script Date: 4/4/2017 10:21:38 PM ******/
CREATE DATABASE [AgendaTelefonica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AgendaTelefonica', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS2012\MSSQL\DATA\AgendaTelefonica.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AgendaTelefonica_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS2012\MSSQL\DATA\AgendaTelefonica_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AgendaTelefonica] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AgendaTelefonica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AgendaTelefonica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AgendaTelefonica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AgendaTelefonica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AgendaTelefonica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AgendaTelefonica] SET ARITHABORT OFF 
GO
ALTER DATABASE [AgendaTelefonica] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [AgendaTelefonica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AgendaTelefonica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AgendaTelefonica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AgendaTelefonica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AgendaTelefonica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AgendaTelefonica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AgendaTelefonica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AgendaTelefonica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AgendaTelefonica] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AgendaTelefonica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AgendaTelefonica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AgendaTelefonica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AgendaTelefonica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AgendaTelefonica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AgendaTelefonica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AgendaTelefonica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AgendaTelefonica] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AgendaTelefonica] SET  MULTI_USER 
GO
ALTER DATABASE [AgendaTelefonica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AgendaTelefonica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AgendaTelefonica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AgendaTelefonica] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [AgendaTelefonica]
GO
/****** Object:  Table [dbo].[Cellphone]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cellphone](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[phone] [varchar](14) NOT NULL,
	[idContact] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contact](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](120) NOT NULL,
	[lastname] [varchar](120) NOT NULL,
	[email] [varchar](120) NOT NULL,
	[idImage] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[House]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[House](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[phone] [varchar](14) NOT NULL,
	[idContact] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Picture]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Picture](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[filePath] [varchar](max) NOT NULL,
	[idContact] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pUsuario]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pUsuario](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](120) NOT NULL,
	[lastname] [varchar](120) NOT NULL,
	[Upassword] [varchar](120) NOT NULL,
	[Nivel] [varchar](50) NOT NULL,
	[pathFoto] [varchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Work]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Work](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[phone] [varchar](14) NOT NULL,
	[idContact] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[addCellPhone]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addCellPhone]
@Telefono varchar(20),
@codigoContacto int
as
insert into Cellphone (phone, idContact) values (@Telefono, @codigoContacto)
GO
/****** Object:  StoredProcedure [dbo].[addHouse]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[addHouse]
@Telefono varchar(20),
@codigoContacto int
as
insert into House (phone, idContact) values (@Telefono, @codigoContacto)

select * from Cellphone
GO
/****** Object:  StoredProcedure [dbo].[addWork]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addWork]
@Telefono varchar(20),
@codigoContacto int
as
insert into Work(phone, idContact) values (@Telefono, @codigoContacto)

GO
/****** Object:  StoredProcedure [dbo].[CellphoneValidationDiff]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CellphoneValidationDiff]
@codigoContacto int,
@telefono varchar(max)
as
select ID as c, phone as t, idContact as con from Cellphone
where idContact != @codigoContacto and phone = @telefono

GO
/****** Object:  StoredProcedure [dbo].[CellphoneValidationSame]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CellphoneValidationSame]
@codigoContacto int,
@telefono varchar(max)
as
select ID as c, phone as t, idContact as con from Cellphone
where idContact = @codigoContacto and phone = @telefono

GO
/****** Object:  StoredProcedure [dbo].[deleteCellphone]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteCellphone]
@numero varchar(max),
@codigoContacto int
as
delete Cellphone where phone = @numero and idContact = @codigoContacto
GO
/****** Object:  StoredProcedure [dbo].[deleteContact]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteContact]
@codigo int
as
delete Contact where ID = @codigo
delete Cellphone where idContact = @codigo
delete House where idContact = @codigo
delete Work where idContact = @codigo
delete Picture where idContact = @codigo

GO
/****** Object:  StoredProcedure [dbo].[deleteHouse]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteHouse]
@numero varchar(max),
@codigoContacto int
as
delete House where phone = @numero and idContact = @codigoContacto
GO
/****** Object:  StoredProcedure [dbo].[deleteImage]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteImage]
@codigoImagen int
as
delete Picture where ID = @codigoImagen
GO
/****** Object:  StoredProcedure [dbo].[deleteUsuario]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteUsuario]
@codigo int
as
delete pUsuario where codigo = @codigo
GO
/****** Object:  StoredProcedure [dbo].[deleteWork]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteWork]
@numero varchar(max),
@codigoContacto int
as
delete Work where phone = @numero and idContact = @codigoContacto
GO
/****** Object:  StoredProcedure [dbo].[getAllCellPhones]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getAllCellPhones]
@codigoContact int
as
select phone as Tel from Cellphone where idContact = @codigoContact
GO
/****** Object:  StoredProcedure [dbo].[getAllHouse]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getAllHouse]
@codigoContact int
as
select phone as Tel from House where idContact = @codigoContact
GO
/****** Object:  StoredProcedure [dbo].[getAllWork]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getAllWork]
@codigoContact int
as
select phone as Tel from Work where idContact = @codigoContact
GO
/****** Object:  StoredProcedure [dbo].[getInfoContact]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getInfoContact]
@nombre varchar(max),
@apellido varchar(max)
as
select ID, name as Nombre, lastname as Apellido, email as Correo, idImage as Foto   from Contact where name = @nombre and lastname = @apellido

GO
/****** Object:  StoredProcedure [dbo].[getInfoContactWID]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getInfoContactWID]
@codigo int
as
select ID as cod, name as n, lastname as l, email as co, idImage as fo from Contact where ID = @codigo
GO
/****** Object:  StoredProcedure [dbo].[getPhoneCellphone]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getPhoneCellphone]
@codigoContacto int,
@telefono varchar(max)
as
select ID as c, phone as t, idContact as con from Cellphone where idContact = @codigoContacto and phone = @telefono
GO
/****** Object:  StoredProcedure [dbo].[getPhoneHouse]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getPhoneHouse]
@codigoContacto int,
@telefono varchar(max)
as
select ID as c, phone as t, idContact as con from House where idContact = @codigoContacto and phone = @telefono
GO
/****** Object:  StoredProcedure [dbo].[getPhoneWork]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getPhoneWork]
@codigoContacto int,
@telefono varchar(max)
as
select ID as c, phone as t, idContact as con from Work where idContact = @codigoContacto and phone = @telefono
GO
/****** Object:  StoredProcedure [dbo].[getUserInfoWID]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getUserInfoWID]
@codigo int
as
select codigo as id, name as n, lastname as l, Upassword as contra, Nivel as ni, pathFoto as fo  from pUsuario where codigo = @codigo

GO
/****** Object:  StoredProcedure [dbo].[getUserInfoWUsername]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[getUserInfoWUsername]
@username varchar(max)
as
select codigo as id, name as n, lastname as l, Upassword as contra, Nivel as ni, pathFoto as fo  from pUsuario where name + '.' + lastname = @username

GO
/****** Object:  StoredProcedure [dbo].[houseValidationDiff]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[houseValidationDiff]
@codigoContacto int,
@telefono varchar(max)
as
select ID as c, phone as t, idContact as con from House
where idContact != @codigoContacto and phone = @telefono

GO
/****** Object:  StoredProcedure [dbo].[houseValidationSame]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[houseValidationSame]
@codigoContacto int,
@telefono varchar(max)
as
select ID as c, phone as t, idContact as con from House
where idContact = @codigoContacto and phone = @telefono
GO
/****** Object:  StoredProcedure [dbo].[listImages]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[listImages]
@codigoContacto int
as
select ID as c, filePath as p, idContact as cc from Picture
where idContact = @codigoContacto

GO
/****** Object:  StoredProcedure [dbo].[loginUsuario]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[loginUsuario]
@nombre varchar(max),
@contrasena varchar(max)
as
Select count(*) from pUsuario 
where name + '.' + lastname = @nombre and Upassword = @contrasena
GO
/****** Object:  StoredProcedure [dbo].[modifyCellphone]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[modifyCellphone]
@codigoNumero int,
@codigoContacto int,
@telefono varchar(max)
as
update Cellphone set phone = @telefono where ID = @codigoNumero and idContact = @codigoContacto

GO
/****** Object:  StoredProcedure [dbo].[modifyContact]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[modifyContact]
@codigo int,
@nombre varchar(120),
@lastname varchar(120),
@email varchar(120)
as
update Contact set name = @nombre, lastname = @lastname, email = @email where ID = @codigo



GO
/****** Object:  StoredProcedure [dbo].[modifyHouse]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[modifyHouse]
@codigoNumero int,
@codigoContacto int,
@telefono varchar(max)
as
update House set phone = @telefono where ID = @codigoNumero and idContact = @codigoContacto

GO
/****** Object:  StoredProcedure [dbo].[modifyUsuario]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[modifyUsuario]
@codigo int,
@nombre varchar(max),
@apellido varchar(max),
@contrasena varchar(max),
@nivel varchar(max),
@foto varchar(max)
as
update pUsuario set name = @nombre, lastname = @apellido, Upassword = @contrasena, Nivel = @nivel, pathFoto = @foto
where codigo = @codigo
GO
/****** Object:  StoredProcedure [dbo].[modifyWork]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[modifyWork]
@codigoNumero int,
@codigoContacto int,
@telefono varchar(max)
as
update Work set phone = @telefono where ID = @codigoNumero and idContact = @codigoContacto

GO
/****** Object:  StoredProcedure [dbo].[registerContact]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[registerContact]
@nombre varchar(120),
@lastname varchar(120),
@email varchar(120),
@codigoImagen int
as
insert into Contact (name, lastname, email, idImage) values (@nombre, @lastname, @email, @codigoImagen)

GO
/****** Object:  StoredProcedure [dbo].[registerImage]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[registerImage]
@Path varchar(max),
@codigoContacto int
as
insert into Picture values (@Path, @codigoContacto)
GO
/****** Object:  StoredProcedure [dbo].[registerUsuario]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[registerUsuario]
@nombre varchar(max),
@apellido varchar(max),
@contrasena varchar(max),
@nivel varchar(max),
@foto varchar(max)
as
Insert into pUsuario (name, lastname, Upassword, Nivel, pathFoto) 
values (@nombre, @apellido, @contrasena, @nivel, @foto)
GO
/****** Object:  StoredProcedure [dbo].[reportContacto]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[reportContacto]
@codigoContacto int
as
select top 1 name, lastname, email, ISNULL(House.phone, ' ') as TelCasa, ISNULL(Work.phone, ' ') as TelTrabajo, ISNULL(Cellphone.phone, ' ') as TelCelular from Contact 
left join House on House.idContact = Contact.ID 
left join Work on Work.idContact = Contact.ID 
left join Cellphone on Cellphone.idContact = Contact.ID




where Contact.ID = @codigoContacto

GO
/****** Object:  StoredProcedure [dbo].[searchEngineContacts]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[searchEngineContacts]
@nombre varchar(max),
@apellido varchar(max)
as
select ID as cod, name as n, lastname as l, email as co from Contact where name like @nombre + '%' and lastname like @apellido + '%'
GO
/****** Object:  StoredProcedure [dbo].[searchEngineUsers]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[searchEngineUsers]
@nombre varchar(max),
@apellido varchar(max)
as
select codigo as id, name as n, lastname as l, Upassword as contra, Nivel as ni, pathFoto as fo  from pUsuario 
where name like @nombre + '%' and lastname like @apellido + '%'
GO
/****** Object:  StoredProcedure [dbo].[userValidation]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[userValidation]
@usernarme varchar(max)
as
select count(*) from pUsuario where name + '.' + lastname = @usernarme
GO
/****** Object:  StoredProcedure [dbo].[validateContact]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[validateContact]
@nombre varchar(max),
@apellido varchar(max)
as
select count(*) from Contact where name = @nombre and lastname = @apellido
GO
/****** Object:  StoredProcedure [dbo].[workValidationDiff]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[workValidationDiff]
@codigoContacto int,
@telefono varchar(max)
as
select ID as c, phone as t, idContact as con from Work
where idContact != @codigoContacto and phone = @telefono

GO
/****** Object:  StoredProcedure [dbo].[WorkValidationSame]    Script Date: 4/4/2017 10:21:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[WorkValidationSame]
@codigoContacto int,
@telefono varchar(max)
as
select ID as c, phone as t, idContact as con from Work
where idContact = @codigoContacto and phone = @telefono

GO
USE [master]
GO
ALTER DATABASE [AgendaTelefonica] SET  READ_WRITE 
GO
