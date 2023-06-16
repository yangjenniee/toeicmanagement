CREATE TABLE [dbo].[TBstudent] (
    [Id]      INT           NOT NULL,
    [name]    NVARCHAR (50) NULL,
    [age]     INT           NULL,
    [phone]   NVARCHAR (50) NULL,
    [school]  NVARCHAR (50) NULL,
    [address] NVARCHAR (50) NULL,
    [goal]    NVARCHAR (50) NULL,
    [test]    INT           NULL,
    [class]   NVARCHAR (50) NULL,
    [date]    NVARCHAR(50)          NULL,
    [cost]    INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

