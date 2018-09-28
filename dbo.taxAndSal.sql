CREATE TABLE [dbo].[taxAndSal] (
    [Id2]       VARCHAR (50) NOT NULL,
    [January]   INT          NULL,
    [February]  INT          NULL,
    [March]     INT          NULL,
    [April]     INT          NULL,
    [May]       INT          NULL,
    [June]      INT          NULL,
    [July]      INT          NULL,
    [August]    INT          NULL,
    [September] INT          NULL,
    [October]   INT          NULL,
    [November]  INT          NULL,
    [December]  INT          NULL,
    [Previous]  INT          NULL,
    [SalaryGrade] VARCHAR(50) NULL, 
    [HomeAl] INT NULL, 
    [HealthAl] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id2] ASC),
    CONSTRAINT [FK_taxAndSal_EmpInformation] FOREIGN KEY ([Id2]) REFERENCES [dbo].[EmpInformation] ([Id2])
);

