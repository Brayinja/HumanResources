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

CREATE PROCEDURE [PR_CrateEmployee](
	@Identification NUMERIC(15),
    @Name VARCHAR(255),
	@Lastname VARCHAR(255),
	@Email VARCHAR(MAX),
	@Phone VARCHAR(MAX),
	@Gender VARCHAR(20),
	@MaritalState VARCHAR(20),
	@Adress VARCHAR(MAX),
	@Birthdate DATE,
	@responseMessage NVARCHAR(250) OUTPUT
) AS BEGIN
	BEGIN TRY
		INSERT INTO dbo.[Employee] VALUES(@Identification, @Name, @Lastname, @Email, @Phone, @Gender, @MaritalState,@Adress,@Birthdate, 1)
		SET @responseMessage = 'Success'
	END TRY
	BEGIN CATCH
		SET @responseMessage = 'Error'
	END CATCH
END
GO