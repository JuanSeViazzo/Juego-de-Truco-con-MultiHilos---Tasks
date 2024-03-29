USE [master]
GO
/****** Object:  Database [MiTruco]    Script Date: 20/11/2022 16:42:24 ******/
CREATE DATABASE [MiTruco]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NosotrosEllos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\NosotrosEllos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'NosotrosEllos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\NosotrosEllos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MiTruco] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MiTruco].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MiTruco] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MiTruco] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MiTruco] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MiTruco] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MiTruco] SET ARITHABORT OFF 
GO
ALTER DATABASE [MiTruco] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MiTruco] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MiTruco] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MiTruco] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MiTruco] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MiTruco] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MiTruco] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MiTruco] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MiTruco] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MiTruco] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MiTruco] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MiTruco] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MiTruco] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MiTruco] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MiTruco] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MiTruco] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MiTruco] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MiTruco] SET RECOVERY FULL 
GO
ALTER DATABASE [MiTruco] SET  MULTI_USER 
GO
ALTER DATABASE [MiTruco] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MiTruco] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MiTruco] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MiTruco] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MiTruco] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MiTruco] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MiTruco', N'ON'
GO
ALTER DATABASE [MiTruco] SET QUERY_STORE = OFF
GO
USE [MiTruco]
GO
/****** Object:  Table [dbo].[Jugadores]    Script Date: 20/11/2022 16:42:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jugadores](
	[nombre_de_jugador] [nchar](50) NOT NULL,
	[edad] [int] NOT NULL,
	[carta_preferida] [nchar](50) NOT NULL,
	[id_jugador] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Partidas]    Script Date: 20/11/2022 16:42:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partidas](
	[nombre_de_partida] [nchar](30) NOT NULL,
	[puntosJugadorUno] [int] NOT NULL,
	[puntosJugadorDos] [int] NOT NULL,
	[fecha_de_partida] [nchar](30) NOT NULL,
	[idJugadorGanador] [int] NOT NULL,
	[idJugadorPerdedor] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResultadosHistoricos]    Script Date: 20/11/2022 16:42:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResultadosHistoricos](
	[id_de_jugador] [int] NOT NULL,
	[nombre_de_jugador] [nchar](30) NOT NULL,
	[partidas_ganada] [int] NOT NULL,
	[puntos_acumulados] [int] NOT NULL,
	[carta_preferida] [nchar](50) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Jugadores] ON 

INSERT [dbo].[Jugadores] ([nombre_de_jugador], [edad], [carta_preferida], [id_jugador]) VALUES (N'JuanSeArg                                         ', 33, N'7 de espada                                       ', 1)
INSERT [dbo].[Jugadores] ([nombre_de_jugador], [edad], [carta_preferida], [id_jugador]) VALUES (N'NachoLanuuuuu                                     ', 26, N'1 de Espada                                       ', 2)
INSERT [dbo].[Jugadores] ([nombre_de_jugador], [edad], [carta_preferida], [id_jugador]) VALUES (N'HernanTrulala                                     ', 34, N'3 de Espada                                       ', 3)
INSERT [dbo].[Jugadores] ([nombre_de_jugador], [edad], [carta_preferida], [id_jugador]) VALUES (N'MaxiViking                                        ', 31, N'7 de Oro                                          ', 4)
INSERT [dbo].[Jugadores] ([nombre_de_jugador], [edad], [carta_preferida], [id_jugador]) VALUES (N'JoaFlower                                         ', 25, N'5 de Copa                                         ', 5)
INSERT [dbo].[Jugadores] ([nombre_de_jugador], [edad], [carta_preferida], [id_jugador]) VALUES (N'AdrianTakaño                                      ', 22, N'6 de Basto                                        ', 6)
INSERT [dbo].[Jugadores] ([nombre_de_jugador], [edad], [carta_preferida], [id_jugador]) VALUES (N'LuquitaRodrigue                                   ', 30, N'1 de Basto                                        ', 7)
INSERT [dbo].[Jugadores] ([nombre_de_jugador], [edad], [carta_preferida], [id_jugador]) VALUES (N'Pachuli                                           ', 25, N'3 de Copa                                         ', 8)
INSERT [dbo].[Jugadores] ([nombre_de_jugador], [edad], [carta_preferida], [id_jugador]) VALUES (N'Marcontador                                       ', 28, N'12 de Espada                                      ', 9)
INSERT [dbo].[Jugadores] ([nombre_de_jugador], [edad], [carta_preferida], [id_jugador]) VALUES (N'FedeBondi                                         ', 31, N'4 de Copa                                         ', 10)
INSERT [dbo].[Jugadores] ([nombre_de_jugador], [edad], [carta_preferida], [id_jugador]) VALUES (N'LautaChef                                         ', 24, N'3 de Basto                                        ', 11)
INSERT [dbo].[Jugadores] ([nombre_de_jugador], [edad], [carta_preferida], [id_jugador]) VALUES (N'Barby159                                          ', 26, N'2 de Espada                                       ', 12)
INSERT [dbo].[Jugadores] ([nombre_de_jugador], [edad], [carta_preferida], [id_jugador]) VALUES (N'Ornelita                                          ', 36, N'1 de Oro                                          ', 13)
INSERT [dbo].[Jugadores] ([nombre_de_jugador], [edad], [carta_preferida], [id_jugador]) VALUES (N'Estebanquito                                      ', 28, N'6 de Espada                                       ', 14)
INSERT [dbo].[Jugadores] ([nombre_de_jugador], [edad], [carta_preferida], [id_jugador]) VALUES (N'AleRozita                                         ', 35, N'4 de Basto                                        ', 15)
INSERT [dbo].[Jugadores] ([nombre_de_jugador], [edad], [carta_preferida], [id_jugador]) VALUES (N'Ricachon                                          ', 29, N'1 de Espada                                       ', 16)
INSERT [dbo].[Jugadores] ([nombre_de_jugador], [edad], [carta_preferida], [id_jugador]) VALUES (N'Piltrafa                                          ', 33, N'7 de Espada                                       ', 17)
INSERT [dbo].[Jugadores] ([nombre_de_jugador], [edad], [carta_preferida], [id_jugador]) VALUES (N'Sumo                                              ', 25, N'1 de Basto                                        ', 18)
INSERT [dbo].[Jugadores] ([nombre_de_jugador], [edad], [carta_preferida], [id_jugador]) VALUES (N'PatricioRey                                       ', 60, N'12 de Copa                                        ', 19)
INSERT [dbo].[Jugadores] ([nombre_de_jugador], [edad], [carta_preferida], [id_jugador]) VALUES (N'Escaloneta                                        ', 19, N'11 de Espada                                      ', 20)
SET IDENTITY_INSERT [dbo].[Jugadores] OFF
GO
INSERT [dbo].[Partidas] ([nombre_de_partida], [puntosJugadorUno], [puntosJugadorDos], [fecha_de_partida], [idJugadorGanador], [idJugadorPerdedor]) VALUES (N'Jugate un Truco               ', 3, 9, N'20-11-22                      ', 4, 1)
INSERT [dbo].[Partidas] ([nombre_de_partida], [puntosJugadorUno], [puntosJugadorDos], [fecha_de_partida], [idJugadorGanador], [idJugadorPerdedor]) VALUES (N'Jugate un Truco               ', 5, 7, N'20-11-22                      ', 15, 8)
INSERT [dbo].[Partidas] ([nombre_de_partida], [puntosJugadorUno], [puntosJugadorDos], [fecha_de_partida], [idJugadorGanador], [idJugadorPerdedor]) VALUES (N'Jugate un Truco               ', 6, 4, N'20-11-22                      ', 2, 11)
INSERT [dbo].[Partidas] ([nombre_de_partida], [puntosJugadorUno], [puntosJugadorDos], [fecha_de_partida], [idJugadorGanador], [idJugadorPerdedor]) VALUES (N'Jugate un Truco               ', 7, 6, N'20-11-22                      ', 5, 14)
INSERT [dbo].[Partidas] ([nombre_de_partida], [puntosJugadorUno], [puntosJugadorDos], [fecha_de_partida], [idJugadorGanador], [idJugadorPerdedor]) VALUES (N'Jugate un Truco               ', 6, 2, N'20-11-22                      ', 3, 8)
INSERT [dbo].[Partidas] ([nombre_de_partida], [puntosJugadorUno], [puntosJugadorDos], [fecha_de_partida], [idJugadorGanador], [idJugadorPerdedor]) VALUES (N'Jugate un Truco               ', 7, 4, N'20-11-22                      ', 1, 2)
INSERT [dbo].[Partidas] ([nombre_de_partida], [puntosJugadorUno], [puntosJugadorDos], [fecha_de_partida], [idJugadorGanador], [idJugadorPerdedor]) VALUES (N'Jugate un Truco               ', 1, 6, N'20-11-22                      ', 14, 2)
INSERT [dbo].[Partidas] ([nombre_de_partida], [puntosJugadorUno], [puntosJugadorDos], [fecha_de_partida], [idJugadorGanador], [idJugadorPerdedor]) VALUES (N'Jugate un Truco               ', 2, 11, N'20-11-22                      ', 7, 13)
INSERT [dbo].[Partidas] ([nombre_de_partida], [puntosJugadorUno], [puntosJugadorDos], [fecha_de_partida], [idJugadorGanador], [idJugadorPerdedor]) VALUES (N'Jugate un Truco               ', 1, 6, N'20-11-22                      ', 19, 8)
INSERT [dbo].[Partidas] ([nombre_de_partida], [puntosJugadorUno], [puntosJugadorDos], [fecha_de_partida], [idJugadorGanador], [idJugadorPerdedor]) VALUES (N'Jugate un Truco               ', 9, 4, N'20-11-22                      ', 17, 2)
GO
USE [master]
GO
ALTER DATABASE [MiTruco] SET  READ_WRITE 
GO
