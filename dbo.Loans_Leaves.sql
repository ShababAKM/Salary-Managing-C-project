CREATE TABLE [dbo].[Loans&Leaves] (
    [Id2]             VARCHAR (50)  NOT NULL,
    [LeaveDays]       INT           NULL,
    [LoanAmount]      INT           NULL,
    [PayAmount]       INT           NULL,
    [SavingsAccount]  INT           NULL,
    [Year]            INT           NULL,
    [DiscriptionL]    VARCHAR (MAX) NULL,
    [TotalLoan]       INT           NULL,
    [SellLeaveAmount] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id2] ASC)
);

