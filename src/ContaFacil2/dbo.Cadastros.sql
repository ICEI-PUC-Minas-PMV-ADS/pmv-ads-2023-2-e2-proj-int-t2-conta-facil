CREATE TABLE [dbo].[Cadastros] (
    [Email]     NVARCHAR (450) NOT NULL,
    [Nome]      NVARCHAR (MAX) NULL,
    [Logadouro] NVARCHAR (MAX) NOT NULL,
    [Cidade]    NVARCHAR (MAX) NOT NULL,
    [Uf]        NVARCHAR (MAX) NOT NULL,
    [CEP]       NVARCHAR (MAX) NOT NULL,
    [Telefone]  NVARCHAR (MAX) NOT NULL,
    [Cpf]       NVARCHAR (MAX) NOT NULL,
    [Senha]     NVARCHAR (MAX) NOT NULL,
    [Perfil]    NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Cadastros] PRIMARY KEY CLUSTERED ([Email] ASC)
);

