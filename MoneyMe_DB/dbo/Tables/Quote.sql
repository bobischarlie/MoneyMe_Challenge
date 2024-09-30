CREATE TABLE [dbo].[Quote] (
    [Id]               UNIQUEIDENTIFIER NOT NULL,
    [AmountRequired]   DECIMAL (8, 2)   NOT NULL,
    [Term]             INT              NOT NULL,
    [Title]            NVARCHAR (90)    NOT NULL,
    [FirstName]        NVARCHAR (90)    NOT NULL,
    [LastName]         NVARCHAR (90)    NOT NULL,
    [DateOfBirth]      DATE             NOT NULL,
    [MobileNo]         NVARCHAR (20)    NOT NULL,
    [Email]            NVARCHAR (90)    NOT NULL,
    [RepaymentAmount]  DECIMAL (8, 2)   NULL,
    [EstablishmentFee] DECIMAL (8, 2)   NULL,
    [TotalInterest]    DECIMAL (8, 2)   NULL,
    [Product]          NVARCHAR (50)    NULL,
    [Status]           INT              NOT NULL,
    CONSTRAINT [PK_Quote] PRIMARY KEY CLUSTERED ([Id] ASC)
);

