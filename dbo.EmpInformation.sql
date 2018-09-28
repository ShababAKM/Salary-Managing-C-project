CREATE TABLE [dbo].[EmpInformation] (
    [Id1]          CHAR (1)     NOT NULL,
    [Id2]          VARCHAR (50) NOT NULL,
    [Name]         VARCHAR (50) NOT NULL,
    [Rank]         VARCHAR (50) NOT NULL,
    [SalaryGrade]  VARCHAR (50) NULL,
    [PhoneNumber]  VARCHAR (50) NULL,
    [EmailAddress] VARCHAR (50) NOT NULL,
    [HomeAddress]  VARCHAR (50) NULL,
    [Password]     VARCHAR (50) NOT NULL,
    [Data]         VARCHAR(50)        NULL,
    [DateofBirth]  VARCHAR (50) NULL,
    [Under]        VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id2] ASC)
);

