BEGIN TRANSACTION;
CREATE TABLE [TB_Arma] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(200) NOT NULL,
    [Dano] int NOT NULL,
    CONSTRAINT [PK_TB_Arma] PRIMARY KEY ([Id])
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Dano', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_Arma]'))
    SET IDENTITY_INSERT [TB_Arma] ON;
INSERT INTO [TB_Arma] ([Id], [Dano], [Nome])
VALUES (1, 35, 'Arco e Flecha'),
(2, 33, 'Espada'),
(3, 31, 'Machado'),
(4, 30, 'Punho'),
(5, 34, 'Chicote'),
(6, 33, 'Foice'),
(7, 32, 'Cajado');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Dano', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_Arma]'))
    SET IDENTITY_INSERT [TB_Arma] OFF;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260428231409_MigracaoArma', N'10.0.5');

COMMIT;
GO

