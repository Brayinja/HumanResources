--Declare @caca varchar(max)
--exec PR_CreateAdmin 'Admin', 'Hola', @caca out
--SELECT @caca
--SELECT * FROM dbo.Admin

--Declare @caca varchar(max)
--Declare @caca2 int
--exec PR_AdminLogin 'Admin', 'Holaa', @caca out, @caca2 out
--SELECT @caca
--SELECT @caca2


--Declare @caca varchar(max)
--declare @cacadate date = CONVERT(DATE,'1420-04-20',120)
--exec [PR_CrateEmployee] 1234,'Hola','Kokum', 'kokum@gmail.com','123141,1231231','Male','Married','La picha',@cacadate, @caca out
--SELECT @caca
--SELECT * FROM dbo.Employee

--Declare @caca varchar(max)
--declare @cacadate date = CONVERT(DATE,'1435-04-20',120)
--exec [PR_UpdateEmployee] 1234,'Hola','Kokum', 'kokum@gmail.com','123141,1231231','Male','Married','La picha',@cacadate,@cacadate,'Caca',425,@caca out
--SELECT @caca
--SELECT * FROM dbo.Employee
--SELECT * FROM dbo.TitleInformation	

--Declare @caca varchar(max)
--declare @cacadate date = CONVERT(DATE,'1435-04-20',120)
--exec [PR_AddPayment] 4,420,'Salario',@cacadate, @caca out
--SELECT @caca
--SELECT * FROM dbo.[EmployeePayment]

--Declare @caca varchar(max)
--declare @cacadate date = CONVERT(DATE,'1435-04-20',120)
--declare @cacadate2 date = CONVERT(DATE,'1475-04-20',120)
--exec [PR_AddVacation] 4,@cacadate,@cacadate2, @caca out
--SELECT @caca
--SELECT * FROM dbo.[EmployeeVacation]