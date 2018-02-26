DROP PROCEDURE PR_CreateUser
GO

CREATE PROCEDURE PR_CreateAdmin(
	@UserName VARCHAR(15),
	@Password VARCHAR(MAX),
	@responseMessage NVARCHAR(250) OUTPUT
)AS BEGIN
	BEGIN TRY
		INSERT INTO dbo.[Admin] VALUES(@UserName, HASHBYTES('SHA2_512', @Password))
		SET @responseMessage = 'Success'
	END TRY
	BEGIN CATCH
		SET @responseMessage = 'Error'
	END CATCH
END
GO


CREATE PROCEDURE [PR_AdminLogin](
    @Username VARCHAR(15),
    @Password VARCHAR(MAX),
    @responseMessage NVARCHAR(250)='' OUTPUT,
	@IdAdmin INT = NULL OUTPUT
)AS BEGIN
    SET NOCOUNT ON
	SET @IdAdmin=(SELECT [Id] FROM [Admin] WHERE [Username]=@Username AND [Password]=HASHBYTES('SHA2_512', @Password))
	IF(@IdAdmin IS NULL)
		SET @responseMessage='Error'
	ELSE 
		SET @responseMessage='Success'
END
GO

CREATE PROCEDURE [PR_CreateEmployee](
	@Identification NUMERIC(15),
    @Name VARCHAR(255),
	@Lastname VARCHAR(255),
	@Email VARCHAR(MAX),
	@Phone VARCHAR(MAX),
	@Gender VARCHAR(20),
	@MaritalState VARCHAR(20),
	@Adress VARCHAR(MAX),
	@Birthdate DATE,
	@HireDate DATE,
	@Title VARCHAR(255),
	@Salary DECIMAL(32,5),
	@responseMessage NVARCHAR(250) OUTPUT
) AS BEGIN
	BEGIN TRY
		INSERT INTO dbo.[Employee] VALUES(@Identification, @Name, @Lastname, @Email, @Phone, @Gender, @MaritalState,@Adress,@Birthdate, 1)
		DECLARE @IdEmployee INT = @@IDENTITY
		INSERT INTO dbo.[TitleInformation] VALUES(@IdEmployee, @HireDate, @Title, @Salary)
		SET @responseMessage = 'Success'
	END TRY
	BEGIN CATCH
		SET @responseMessage = 'Error'
	END CATCH
END
GO

CREATE PROCEDURE [PR_UpdateEmployee](
	@Identification NUMERIC(15),
    @Name VARCHAR(255),
	@Lastname VARCHAR(255),
	@Email VARCHAR(MAX),
	@Phone VARCHAR(MAX),
	@Gender VARCHAR(20),
	@MaritalState VARCHAR(20),
	@Adress VARCHAR(MAX),
	@Birthdate DATE,
	@HireDate DATE,
	@Title VARCHAR(255),
	@Salary DECIMAL(32,5),
	@responseMessage NVARCHAR(250) OUTPUT
) AS BEGIN
	BEGIN TRY
		UPDATE dbo.[Employee] SET [Name] = @Name, 
								  [Lastname] = @Lastname, 
								  [Email] = @Email, 
								  [Phone] = @Phone, 
								  [Gender] = @Gender, 
								  [MaritalState] = @MaritalState,
								  [Adress] = @Adress,
								  [Birthdate] = @Birthdate
		WHERE [Identification] = @Identification

		DECLARE @IdEmployee INT = (SELECT [Id] FROM [Employee] WHERE [Identification] = @Identification)
		DECLARE @HireTmp DATE = (SELECT TOP 1 [HireDate] FROM [TitleInformation] WHERE [EmployeeId] = 4 ORDER BY HireDate DESC)
		IF (@HireTmp != @HireDate)
			INSERT INTO dbo.[TitleInformation] VALUES(@IdEmployee, @HireDate, @Title, @Salary)
		SET @responseMessage = 'Success'
	END TRY
	BEGIN CATCH
		SET @responseMessage = 'Error'
	END CATCH
END
GO

CREATE PROCEDURE [PR_AddPayment](
	@IdEmployee INT,
    @Amount DECIMAL(32,5),
	@Description VARCHAR(MAX),
	@Date DATE,
	@responseMessage NVARCHAR(250) OUTPUT
)AS BEGIN
	BEGIN TRY
		INSERT INTO dbo.[EmployeePayment] VALUES(@IdEmployee,@Amount,@Description,@Date,1)
		SET @responseMessage = 'Success'
	END TRY
	BEGIN CATCH
		SET @responseMessage = 'Error'
	END CATCH
END
GO


CREATE PROCEDURE [PR_AddVacation](
	@IdEmployee INT,
	@StartDate DATE,
	@EndDate DATE,
	@responseMessage NVARCHAR(250) OUTPUT
)AS BEGIN
	BEGIN TRY
		INSERT INTO dbo.[EmployeeVacation] VALUES(@IdEmployee,@StartDate,@EndDate,1)
		SET @responseMessage = 'Success'
	END TRY
	BEGIN CATCH
		SET @responseMessage = 'Error'
	END CATCH
END
GO
