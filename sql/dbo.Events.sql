USE [EventLocationData]
GO

/****** Object: Table [dbo].[Events] Script Date: 12/3/2018 6:17:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Events] (
    [Id]        INT           NOT NULL,
    [Location]  NVARCHAR (50) NOT NULL,
    [EventType] NVARCHAR (50) NOT NULL
);


