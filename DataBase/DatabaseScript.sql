USE HumanResources

CREATE TABLE [Admin](
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Username] VARCHAR(15) NOT NULL UNIQUE,
	[Password] VARBINARY(MAX) NOT NULL,
	CONSTRAINT PK_AdminId PRIMARY KEY (Id)
)
GO

CREATE TABLE [ActivityLog](
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Date] DATETIME NOT NULL,
	[Description] VARCHAR(MAX) NOT NULL,
	CONSTRAINT PK_LogId PRIMARY KEY (Id)
)
GO

CREATE TABLE [Employee](
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Identification] NUMERIC(15) NOT NULL,
	[Name] VARCHAR(255) NOT NULL,
	[Lastname] VARCHAR(255) NOT NULL,
	[Email] VARCHAR(MAX) NOT NULL,
	[Phone] VARCHAR(MAX) NOT NULL,
	[Gender] VARCHAR(20) NOT NULL CHECK([GENDER] IN ('Male','Female','Other')),
	[MaritalState] VARCHAR(20) NOT NULL CHECK([MaritalState] IN ('Married', 'Single')),
	[Adress] VARCHAR(MAX) NULL,
	[Birthdate] DATE NOT NULL,
	[State] BIT DEFAULT(1) NOT NULL,
	CONSTRAINT PK_EmployeeId PRIMARY KEY (Id)
)
GO

CREATE TABLE [TitleInformation](
	[EmployeeId] INT NOT NULL,
	[HireDate] DATE NOT NULL,
	[Title] VARCHAR(255) NOT NULL,
	[Salary] DECIMAL(32,5) NOT NULL,
	CONSTRAINT PK_TitleInformation PRIMARY KEY([EmployeeId], [HireDate]),
	CONSTRAINT FK_Employee FOREIGN KEY ([EmployeeId]) REFERENCES [Employee]([Id])
)
GO

CREATE TABLE [ContactInformation](
	[Id] INT IDENTITY(1,1) NOT NULL,
	[EmployeeId] INT NOT NULL,
	[Name] VARCHAR(255) NOT NULL,
	[Relation] VARCHAR(255) NOT NULL,
	[PhoneNumber] NUMERIC(15) NOT NULL,
	[Adress] VARCHAR(MAX) NOT NULL,
	CONSTRAINT PK_ContactId PRIMARY KEY([Id]),
	CONSTRAINT FK_EmployeeContact FOREIGN KEY ([EmployeeId]) REFERENCES [Employee]([Id])
)
GO

CREATE TABLE [EmployeePayment](
	[Id] INT IDENTITY(1,1) NOT NULL,
	[EmployeeId] INT NOT NULL,
	[Amount] DECIMAL(32,5) NOT NULL,
	[Description] VARCHAR(MAX) NOT NULL,
	[Date] DATE NOT NULL,
	[State] BIT NOT NULL,
	CONSTRAINT PK_EmployeePayment PRIMARY KEY([Id]),
	CONSTRAINT FK_EmployeePaymentContact FOREIGN KEY ([EmployeeId]) REFERENCES [Employee]([Id])
)
GO

CREATE TABLE [EmployeeVacation](
	[Id] INT IDENTITY(1,1) NOT NULL,
	[EmployeeId] INT NOT NULL,
	[StartDate] DATE NOT NULL,
	[EndDate] DATE NOT NULL,
	[State] BIT NOT NULL,
	CONSTRAINT PK_EmployeeVacation PRIMARY KEY([Id]),
	CONSTRAINT FK_EmployeeVacationContact FOREIGN KEY ([EmployeeId]) REFERENCES [Employee]([Id])
)
GO