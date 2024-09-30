CREATE TABLE [dbo].[Blacklist] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Value]       NVARCHAR (90)    NOT NULL,
    [Description] NVARCHAR (100)   NOT NULL,
    [Type]        INT              CONSTRAINT [DF_Blacklist_Type] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Blacklist] PRIMARY KEY CLUSTERED ([Id] ASC)
);

