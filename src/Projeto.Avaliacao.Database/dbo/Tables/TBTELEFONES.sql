﻿CREATE TABLE [dbo].[TBTELEFONES] (
    [TelefoneID] INT          IDENTITY (1, 1) NOT NULL,
    [UsuarioID]  INT          NOT NULL,
    [Fone]       VARCHAR (50) NOT NULL,
    [Ativo]      BIT          CONSTRAINT [DF_TBTELEFONES_Ativo] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_TBTELEFONES] PRIMARY KEY CLUSTERED ([TelefoneID] ASC),
    CONSTRAINT [FK_TBTELEFONES_TBUSUARIOS] FOREIGN KEY ([UsuarioID]) REFERENCES [dbo].[TBUSUARIOS] ([UsuarioID])
);

