USE [master]
GO
/****** Object:  Database [GSB_gesAMM]    Script Date: 17/11/2023 16:05:28 ******/
CREATE DATABASE [GSB_gesAMM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GSB_gesAMM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\GSB_gesAMM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GSB_gesAMM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\GSB_gesAMM_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GSB_gesAMM] SET COMPATIBILITY_LEVEL = 120
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
ALTER DATABASE [GSB_gesAMM] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [GSB_gesAMM] SET DELAYED_DURABILITY = DISABLED 
GO
USE [GSB_gesAMM]
GO
/****** Object:  Table [dbo].[FAMILLE]    Script Date: 17/11/2023 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FAMILLE](
	[FAM_CODE] [nvarchar](255) NULL,
	[FAM_LIBELLE] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HISTORIQUES]    Script Date: 17/11/2023 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HISTORIQUES](
	[HST_dateMAJnorme] [nvarchar](255) NULL,
	[HST_UtilisateurModifNorme] [nvarchar](255) NULL,
	[HST_normeAvantModif] [nvarchar](255) NULL,
	[HST_normeApresModif] [nvarchar](255) NULL,
	[HST_dateNormeAvantModif] [nvarchar](255) NULL,
	[HST_dateNormeApresModif] [nvarchar](255) NULL,
	[HST_numEtape] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEDICAMENT]    Script Date: 17/11/2023 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEDICAMENT](
	[MED_DEPOTLEGAL] [nvarchar](255) NULL,
	[MED_NOMCOMMERCIAL] [nvarchar](255) NULL,
	[FAM_CODE] [nvarchar](255) NULL,
	[MED_COMPOSITION] [nvarchar](255) NULL,
	[MED_EFFETS] [nvarchar](255) NULL,
	[MED_CONTREINDIC] [nvarchar](255) NULL,
	[MED_PRIXECHANTILLON] [nvarchar](255) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE]) VALUES (N'AA', N'Antalgiques en association')
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE]) VALUES (N'AAA', N'Antalgiques antipyrétiques en association')
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE]) VALUES (N'AAC', N'Antidépresseur d''action centrale')
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE]) VALUES (N'AAH', N'Antivertigineux antihistaminique H1')
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE]) VALUES (N'ABA', N'Antibiotique antituberculeux')
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE]) VALUES (N'ABC', N'Antibiotique antiacnéique local')
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE]) VALUES (N'ABP', N'Antibiotique de la famille des béta-lactamines (pénicilline A)')
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE]) VALUES (N'AFC', N'Antibiotique de la famille des cyclines')
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE]) VALUES (N'AFM', N'Antibiotique de la famille des macrolides')
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE]) VALUES (N'AH', N'Antihistaminique H1 local')
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE]) VALUES (N'AIM', N'Antidépresseur imipraminique (tricyclique)')
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE]) VALUES (N'AIN', N'Antidépresseur inhibiteur sélectif de la recapture de la sérotonine')
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE]) VALUES (N'ALO', N'Antibiotique local (ORL)')
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE]) VALUES (N'ANS', N'Antidépresseur IMAO non sélectif')
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE]) VALUES (N'AO', N'Antibiotique ophtalmique')
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE]) VALUES (N'AP', N'Antipsychotique normothymique')
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE]) VALUES (N'AUM', N'Antibiotique urinaire minute')
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE]) VALUES (N'CRT', N'Corticoïde, antibiotique et antifongique à  usage local')
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE]) VALUES (N'HYP', N'Hypnotique antihistaminique')
INSERT [dbo].[FAMILLE] ([FAM_CODE], [FAM_LIBELLE]) VALUES (N'PSA', N'Psychostimulant, antiasthénique')
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'3MYC7', N'TRIMYCINE', N'CRT', N'Triamcinolone (acétonide) + Néomycine + Nystatine', N'Ce médicament est un corticoïde à  activité forte ou très forte associé à  un antibiotique et un antifongique, utilisé en application locale dans certaines atteintes cutanées surinfectées.', N'Ce médicament est contre-indiqué en cas d''allergie à  l''un des constituants, d''infections de la peau ou de parasitisme non traités, d''acné. Ne pas appliquer sur une plaie, ni sous un pansement occlusif.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'ADIMOL9', N'ADIMOL', N'ABP', N'Amoxicilline + Acide clavulanique', N'Ce médicament, plus puissant que les pénicillines simples, est utilisé pour traiter des infections bactériennes spécifiques.', N'Ce médicament est contre-indiqué en cas d''allergie aux pénicillines ou aux céphalosporines.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'AMOPIL7', N'AMOPIL', N'ABP', N'Amoxicilline', N'Ce médicament, plus puissant que les pénicillines simples, est utilisé pour traiter des infections bactériennes spécifiques.', N'Ce médicament est contre-indiqué en cas d''allergie aux pénicillines. Il doit être administré avec prudence en cas d''allergie aux céphalosporines.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'AMOX45', N'AMOXAR', N'ABP', N'Amoxicilline', N'Ce médicament, plus puissant que les pénicillines simples, est utilisé pour traiter des infections bactériennes spécifiques.', N'La prise de ce médicament peut rendre positifs les tests de dépistage du dopage.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'AMOXIG12', N'AMOXI Gé', N'ABP', N'Amoxicilline', N'Ce médicament, plus puissant que les pénicillines simples, est utilisé pour traiter des infections bactériennes spécifiques.', N'Ce médicament est contre-indiqué en cas d''allergie aux pénicillines. Il doit être administré avec prudence en cas d''allergie aux céphalosporines.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'APATOUX22', N'APATOUX Vitamine C', N'ALO', N'Tyrothricine + Tétracaïne + Acide ascorbique (Vitamine C)', N'Ce médicament est utilisé pour traiter les affections de la bouche et de la gorge.', N'Ce médicament est contre-indiqué en cas d''allergie à  l''un des constituants, en cas de phénylcétonurie et chez l''enfant de moins de 6 ans.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'BACTIG10', N'BACTIGEL', N'ABC', N'Erythromycine', N'Ce médicament est utilisé en application locale pour traiter l''acné et les infections cutanées bactériennes associées.', N'Ce médicament est contre-indiqué en cas d''allergie aux antibiotiques de la famille des macrolides ou des lincosanides.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'BACTIV13', N'BACTIVIL', N'AFM', N'Erythromycine', N'Ce médicament est utilisé pour traiter des infections bactériennes spécifiques.', N'Ce médicament est contre-indiqué en cas d''allergie aux macrolides (dont le chef de file est l''érythromycine).', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'BITALV', N'BIVALIC', N'AAA', N'Dextropropoxyphène + Paracétamol', N'Ce médicament est utilisé pour traiter les douleurs d''intensité modérée ou intense.', N'Ce médicament est contre-indiqué en cas d''allergie aux médicaments de cette famille, d''insuffisance hépatique ou d''insuffisance rénale.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'CARTION6', N'CARTION', N'AAA', N'Acide acétylsalicylique (aspirine) + Acide ascorbique (Vitamine C) + Paracétamol', N'Ce médicament est utilisé dans le traitement symptomatique de la douleur ou de la fièvre.', N'Ce médicament est contre-indiqué en cas de troubles de la coagulation (tendances aux hémorragies), d''ulcère gastroduodénal, maladies graves du foie.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'CLAZER6', N'CLAZER', N'AFM', N'Clarithromycine', N'Ce médicament est utilisé pour traiter des infections bactériennes spécifiques. Il est également utilisé dans le traitement de l''ulcère gastro-duodénal, en association avec d''autres médicaments.', N'Ce médicament est contre-indiqué en cas d''allergie aux macrolides (dont le chef de file est l''érythromycine).', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'DEPRIL9', N'DEPRAMIL', N'AIM', N'Clomipramine', N'Ce médicament est utilisé pour traiter les épisodes dépressifs sévères, certaines douleurs rebelles, les troubles obsessionnels compulsifs et certaines énurésies chez l''enfant.', N'Ce médicament est contre-indiqué en cas de glaucome ou d''adénome de la prostate, d''infarctus récent, ou si vous avez reà§u un traitement par IMAO durant les 2 semaines précédentes ou en cas d''allergie aux antidépresseurs imipraminiques.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'DIMIRTAM6', N'DIMIRTAM', N'AAC', N'Mirtazapine', N'Ce médicament est utilisé pour traiter les épisodes dépressifs sévères.', N'La prise de ce produit est contre-indiquée en cas de d''allergie à  l''un des constituants.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'DOLRIL7', N'DOLORIL', N'AAA', N'Acide acétylsalicylique (aspirine) + Acide ascorbique (Vitamine C) + Paracétamol', N'Ce médicament est utilisé dans le traitement symptomatique de la douleur ou de la fièvre.', N'Ce médicament est contre-indiqué en cas d''allergie au paracétamol ou aux salicylates.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'DORNOM8', N'NORMADOR', N'HYP', N'Doxylamine', N'Ce médicament est utilisé pour traiter l''insomnie chez l''adulte.', N'Ce médicament est contre-indiqué en cas de glaucome, de certains troubles urinaires (rétention urinaire) et chez l''enfant de moins de 15 ans.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'EQUILARX6', N'EQUILAR', N'AAH', N'Méclozine', N'Ce médicament est utilisé pour traiter les vertiges et pour prévenir le mal des transports.', N'Ce médicament ne doit pas être utilisé en cas d''allergie au produit, en cas de glaucome ou de rétention urinaire.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'EVILR7', N'EVEILLOR', N'PSA', N'Adrafinil', N'Ce médicament est utilisé pour traiter les troubles de la vigilance et certains symptomes neurologiques chez le sujet agé.', N'Ce médicament est contre-indiqué en cas d''allergie à  l''un des constituants.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'INSXT5', N'INSECTIL', N'AH', N'Diphénydramine', N'Ce médicament est utilisé en application locale sur les piqûres d''insecte et l''urticaire.', N'Ce médicament est contre-indiqué en cas d''allergie aux antihistaminiques.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'JOVAI8', N'JOVENIL', N'AFM', N'Josamycine', N'Ce médicament est utilisé pour traiter des infections bactériennes spécifiques.', N'Ce médicament est contre-indiqué en cas d''allergie aux macrolides (dont le chef de file est l''érythromycine).', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'LIDOXY23', N'LIDOXYTRACINE', N'AFC', N'Oxytétracycline +Lidocaïne', N'Ce médicament est utilisé en injection intramusculaire pour traiter certaines infections spécifiques.', N'Ce médicament est contre-indiqué en cas d''allergie à  l''un des constituants. Il ne doit pas être associé aux rétinoïdes.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'LITHOR12', N'LITHORINE', N'AP', N'Lithium', N'Ce médicament est indiqué dans la prévention des psychoses maniaco-dépressives ou pour traiter les états maniaques.', N'Ce médicament ne doit pas être utilisé si vous êtes allergique au lithium. Avant de prendre ce traitement, signalez à  votre médecin traitant si vous souffrez d''insuffisance rénale, ou si vous avez un régime sans sel.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'PARMOL16', N'PARMOCODEINE', N'AA', N'Codéine + Paracétamol', N'Ce médicament est utilisé pour le traitement des douleurs lorsque des antalgiques simples ne sont pas assez efficaces.', N'Ce médicament est contre-indiqué en cas d''allergie à  l''un des constituants, chez l''enfant de moins de 15 Kg, en cas d''insuffisance hépatique ou respiratoire, d''asthme, de phénylcétonurie et chez la femme qui allaite.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'PHYSOI8', N'PHYSICOR', N'PSA', N'Sulbutiamine', N'Ce médicament est utilisé pour traiter les baisses d''activité physique ou psychique, souvent dans un contexte de dépression.', N'Ce médicament est contre-indiqué en cas d''allergie à  l''un des constituants.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'PIRIZ8', N'PIRIZAN', N'ABA', N'Pyrazinamide', N'Ce médicament est utilisé, en association à  d''autres antibiotiques, pour traiter la tuberculose.', N'Ce médicament est contre-indiqué en cas d''allergie à  l''un des constituants, d''insuffisance rénale ou hépatique, d''hyperuricémie ou de porphyrie.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'POMDI20', N'POMADINE', N'AO', N'Bacitracine', N'Ce médicament est utilisé pour traiter les infections oculaires de la surface de l''oeil.', N'Ce médicament est contre-indiqué en cas d''allergie aux antibiotiques appliqués localement.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'TROXT21', N'TROXADET', N'AIN', N'Paroxétine', N'Ce médicament est utilisé pour traiter la dépression et les troubles obsessionnels compulsifs. Il peut également être utilisé en prévention des crises de panique avec ou sans agoraphobie.', N'Ce médicament est contre-indiqué en cas d''allergie au produit.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'TXISOL22', N'TOUXISOL Vitamine C', N'ALO', N'Tyrothricine + Acide ascorbique (Vitamine C)', N'Ce médicament est utilisé pour traiter les affections de la bouche et de la gorge.', N'Ce médicament est contre-indiqué en cas d''allergie à  l''un des constituants et chez l''enfant de moins de 6 ans.', NULL)
INSERT [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL], [MED_NOMCOMMERCIAL], [FAM_CODE], [MED_COMPOSITION], [MED_EFFETS], [MED_CONTREINDIC], [MED_PRIXECHANTILLON]) VALUES (N'URIEG6', N'URIREGUL', N'AUM', N'Fosfomycine trométamol', N'Ce médicament est utilisé pour traiter les infections urinaires simples chez la femme de moins de 65 ans.', N'La prise de ce médicament est contre-indiquée en cas d''allergie à  l''un des constituants et d''insuffisance rénale.', NULL)
USE [master]
GO
ALTER DATABASE [GSB_gesAMM] SET  READ_WRITE 
GO
