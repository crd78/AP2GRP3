USE [master]
GO
/****** Object:  Database [GSB_gesAMM]    Script Date: 15/12/2023 14:39:50 ******/
CREATE DATABASE [GSB_gesAMM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GSB_gesAMM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\GSB_gesAMM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GSB_gesAMM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\GSB_gesAMM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [GSB_gesAMM] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GSB_gesAMM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GSB_gesAMM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ARITHABORT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GSB_gesAMM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GSB_gesAMM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GSB_gesAMM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GSB_gesAMM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GSB_gesAMM] SET  MULTI_USER 
GO
ALTER DATABASE [GSB_gesAMM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GSB_gesAMM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GSB_gesAMM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GSB_gesAMM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GSB_gesAMM] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GSB_gesAMM] SET QUERY_STORE = ON
GO
ALTER DATABASE [GSB_gesAMM] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [GSB_gesAMM]
GO
/****** Object:  Table [dbo].[DECISION]    Script Date: 15/12/2023 14:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DECISION](
	[DCS_ID] [int] NOT NULL,
	[DCS_LIBELLE] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[DCS_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ETAPE]    Script Date: 15/12/2023 14:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ETAPE](
	[ETP_NUM] [int] NOT NULL,
	[ETP_LIBELLE] [nvarchar](50) NOT NULL,
	[ETP_NORME] [nvarchar](20) NULL,
	[ETP_DATE_NORME] [date] NULL,
	[estNormee] [tinyint] NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[ETP_NUM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FAMILLE]    Script Date: 15/12/2023 14:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FAMILLE](
	[FAM_CODE] [nvarchar](3) NOT NULL,
	[FAM_LIBELLE] [nvarchar](255) NULL,
	[FAM_NB_MEDI_AMM] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[FAM_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HISTORIQUE]    Script Date: 15/12/2023 14:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HISTORIQUE](
	[id_changement] [int] IDENTITY(1,1) NOT NULL,
	[dateMiseAjour] [date] NULL,
	[idUtilisateur] [int] NULL,
	[numEtape] [int] NULL,
	[normeAvant] [varchar](255) NULL,
	[normeApres] [varchar](255) NULL,
	[dateNormeAvant] [date] NULL,
	[dateNormeApres] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_changement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEDICAMENT]    Script Date: 15/12/2023 14:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEDICAMENT](
	[MED_DEPOTLEGAL] [nvarchar](10) NOT NULL,
	[MED_NOMCOMMERCIAL] [nvarchar](255) NULL,
	[FAM_CODE] [nvarchar](255) NULL,
	[MED_COMPOSITION] [nvarchar](255) NULL,
	[MED_EFFETS] [nvarchar](255) NULL,
	[MED_CONTREINDIC] [nvarchar](255) NULL,
	[MED_AMM] [int] NULL,
	[MED_ETP_NUM] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MED_DEPOTLEGAL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUBIR]    Script Date: 15/12/2023 14:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUBIR](
	[SBR_MED_DEPOTLEGAL] [nvarchar](10) NOT NULL,
	[SBR_ETP_NUM] [int] NOT NULL,
	[SBR_DCS_ID] [int] NULL,
	[SBR_DATEDECISION] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[SBR_MED_DEPOTLEGAL] ASC,
	[SBR_ETP_NUM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UTILISATEUR]    Script Date: 15/12/2023 14:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UTILISATEUR](
	[id] [int] NOT NULL,
	[username] [varchar](30) NULL,
	[motdepasse] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[prc_ajouterMedicament]    Script Date: 15/12/2023 14:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_ajouterMedicament]
@p_DEPOTLEGAL VARCHAR(255),
@p_NOMCOMMERCIAL VARCHAR(255),
@p_FAM_CODE VARCHAR(255),
@p_COMPOSITION VARCHAR(255),
@p_EFFETS VARCHAR(255),
@p_CONTREINDIC VARCHAR(255)
AS
BEGIN
INSERT INTO MEDICAMENT (
MED_DEPOTLEGAL,
MED_NOMCOMMERCIAL,
FAM_CODE,
MED_COMPOSITION,
MED_EFFETS,
MED_CONTREINDIC
) VALUES (
@p_DEPOTLEGAL,
@p_NOMCOMMERCIAL,
@p_FAM_CODE,
@p_COMPOSITION,
@p_EFFETS,
@p_CONTREINDIC
);
END;
GO
/****** Object:  StoredProcedure [dbo].[prc_decisions]    Script Date: 15/12/2023 14:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_decisions]
AS
BEGIN
Select * from dbo.DECISION
END
GO
/****** Object:  StoredProcedure [dbo].[prc_etapes]    Script Date: 15/12/2023 14:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[prc_etapes]
AS
BEGIN
Select * from dbo.ETAPE
END
GO
/****** Object:  StoredProcedure [dbo].[prc_famille]    Script Date: 15/12/2023 14:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_famille]
AS
BEGIN
Select * from dbo.FAMILLE
END
GO
/****** Object:  StoredProcedure [dbo].[prc_medicamentEnVerif]    Script Date: 15/12/2023 14:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_medicamentEnVerif]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT DISTINCT M.MED_DEPOTLEGAL, F.FAM_LIBELLE, M.MED_NOMCOMMERCIAL,F.FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC,MED_AMM,MED_ETP_NUM
    FROM MEDICAMENT M
    INNER JOIN FAMILLE F ON M.FAM_CODE = F.FAM_CODE
    WHERE EXISTS (
        SELECT 1
        FROM SUBIR S
        WHERE S.SBR_MED_DEPOTLEGAL = M.MED_DEPOTLEGAL
        AND S.SBR_DCS_ID = 2
    );
END
GO
/****** Object:  StoredProcedure [dbo].[prc_saisirDecision]    Script Date: 15/12/2023 14:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_saisirDecision]
@p_DEPOTLEGAL VARCHAR(255),
@p_NUMETAPE INTEGER,
@p_DECISION INTEGER,
@p_DATE NVARCHAR(10)
AS
BEGIN
INSERT INTO SUBIR(
SBR_MED_DEPOTLEGAL,
SBR_ETP_NUM,
SBR_DCS_ID,
SBR_DATEDECISION
) VALUES (
@p_DEPOTLEGAL,
@p_NUMETAPE,
@p_DECISION,
@p_DATE
);
END;
GO
/****** Object:  StoredProcedure [dbo].[prc_userConnection]    Script Date: 15/12/2023 14:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_userConnection]
	@p_USERNAME VARCHAR(255),
	@p_MOTDEPASSE  VARCHAR(255)  -- Utilisez la taille appropriée en fonction de l'algorithme de hachage (ex: SHA-256)
AS
BEGIN
	SELECT USERNAME, MOTDEPASSE
	FROM UTILISATEUR
	WHERE @p_MOTDEPASSE = MOTDEPASSE
	AND @p_USERNAME = USERNAME
END
GO
/****** Object:  StoredProcedure [dbo].[prc_workflows]    Script Date: 15/12/2023 14:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_workflows]
AS
BEGIN
Select * from dbo.SUBIR
END
GO
USE [master]
GO
ALTER DATABASE [GSB_gesAMM] SET  READ_WRITE 
GO
