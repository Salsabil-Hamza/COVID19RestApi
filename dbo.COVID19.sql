CREATE TABLE [dbo].[COVID19] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [LastReleaseDate] DATETIME2 (7)  NULL,
    [MortalityRate]   FLOAT (53)     NULL,
    [Population]      FLOAT (53)     NULL,
    [Strategy]        NVARCHAR (MAX) NULL,
    [CityName]        NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_COVID19] PRIMARY KEY CLUSTERED ([Id] ASC)
);

