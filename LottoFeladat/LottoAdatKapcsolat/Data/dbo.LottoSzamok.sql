CREATE TABLE [dbo].[LottoSzamok] (
    [Id]    INT IDENTITY (1, 1) NOT NULL,
    [Szam1] INT NOT NULL,
    [Szam2] INT NOT NULL,
    [Szam3] INT NOT NULL,
    [Szam4] INT NOT NULL,
    [Szam5] INT NOT NULL,
    [Szam6] INT NOT NULL, 
    [Szam7] INT NOT NULL, 
    CONSTRAINT [PK_LottoSzamok] PRIMARY KEY CLUSTERED ([Id] ASC)
);

