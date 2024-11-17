--CREATE DATABASE HOSPITAL
--USE HOSPITAL

CREATE TABLE Doctors
(
	Id int identity primary key,
	FirstName nvarchar(16),
	LastName nvarchar(20),
	Email nvarchar(64),
	PhoneNumber nvarchar(32),
	IsDeleted bit DEFAULT 0 NOT NULL,
	CreatedAt datetime2,
	LastModifiedDate datetime2
)

ALTER PROCEDURE InsertAllDoctors (
	@FirstName nvarchar(16),
	@LastName nvarchar(20),
	@Email nvarchar(64),
	@PhoneNumber nvarchar(32))
AS
BEGIN
	INSERT INTO Doctors (FirstName,LastName,Email,PhoneNumber)
	VALUES 
	(@FirstName,@LastName,@Email,@PhoneNumber);
	
END

EXEC InsertAllDoctors 
@FirstName=N'Rəvan',
@LastName=N'Bayramov',
@Email=N'rvanvb-ab108@code.edu.az',
@PhoneNumber=N'+994 10 100 10 10'

SELECT * FROM Doctors