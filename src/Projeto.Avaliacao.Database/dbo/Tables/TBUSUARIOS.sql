CREATE TABLE [dbo].[TBUSUARIOS] (
    [UsuarioID]      INT           IDENTITY (1, 1) NOT NULL,
    [Nome]           VARCHAR (100) NOT NULL,
    [Email]          VARCHAR (50)  NOT NULL,
    [CPF]            VARCHAR (11)  NOT NULL,
    [DataNascimento] DATETIME      NOT NULL,
    [NomeMae]        VARCHAR (100) NOT NULL,
    [DataInclusao]   DATETIME      CONSTRAINT [DF_TBUSUARIOS_DataInclusao] DEFAULT (getdate()) NOT NULL,
    [DataAlteracao]  DATETIME      NULL,
    [Ativo]          BIT           CONSTRAINT [DF_TBUSUARIOS_Ativo] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_TBUSUARIOS] PRIMARY KEY CLUSTERED ([UsuarioID] ASC),
    CONSTRAINT [IX_TBUSUARIOS] UNIQUE NONCLUSTERED ([CPF] ASC)
);

