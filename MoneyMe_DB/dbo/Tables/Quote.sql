CREATE TABLE [dbo].[Quote] (
    [Id]             UNIQUEIDENTIFIER NOT NULL,
    [AmountRequired] DECIMAL (18, 2)  NOT NULL,
    [Term]           INT              NOT NULL,
    [Title]          NVARCHAR (90)    NOT NULL,
    [FirstName]      NVARCHAR (90)    NOT NULL,
    [LastName]       NVARCHAR (90)    NOT NULL,
    [DateOfBirth]    DATE             NOT NULL,
    [MobileNo]       NVARCHAR (20)    NOT NULL,
    [Email]          NVARCHAR (90)    NOT NULL,
    CONSTRAINT [PK_Quote] PRIMARY KEY CLUSTERED ([Id] ASC)
);

