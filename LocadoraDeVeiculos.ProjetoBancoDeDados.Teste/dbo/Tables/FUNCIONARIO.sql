﻿CREATE TABLE [dbo].[FUNCIONARIO] (
    [ID]             UNIQUEIDENTIFIER NOT NULL,
    [LOGIN]          VARCHAR (300)    NOT NULL,
    [SENHA]          VARCHAR (300)    NOT NULL,
    [DATADEADMISSAO] DATETIME         NOT NULL,
    [SALARIO]        FLOAT (53)       NOT NULL,
    [ADMIN]          BIT              NULL,
    [NOME]           VARCHAR (300)    NOT NULL,
    CONSTRAINT [PK_FUNCIONARIO_1] PRIMARY KEY CLUSTERED ([ID] ASC)
);
