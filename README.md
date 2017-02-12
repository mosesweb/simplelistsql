# simplelistsql

Simple list of items in a list were you can delete items. Made in C# Forms. 

SQL:

CREATE TABLE [dbo].[Articles] (
    [Id]          INT           NOT NULL,
    [name]        VARCHAR (100) NULL,
    [description] VARCHAR (400) NULL,
    [price]       REAL          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

