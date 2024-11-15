--CREATE DATABASE ACADEMY
--USE ACADEMY

--CREATE TABLE Students
--(
--	Id int IDENTITY PRIMARY KEY,
--	FirstName nvarchar(16),
--	LastName nvarchar(20),
--	DataOfBirth date,
--	Username nvarchar(32),
--	Password nvarchar(64),
--	EnrollmentDate date
--)

--CREATE TABLE Departments
--(
--	Id int IDENTITY PRIMARY KEY,
--	DepartmentName nvarchar(32)
--)

--CREATE TABLE Instructors 
--(
--	Id int IDENTITY PRIMARY KEY,
--	FirstName nvarchar(16),
--	LastName nvarchar(20),
--	HireDate date,
--	DepartmentId int REFERENCES Departments(Id),
--	Username nvarchar(32),
--	Password nvarchar(64),
--	FIN nvarchar(16)
--)

--CREATE TABLE Groups 
--(
--	Id int IDENTITY PRIMARY KEY,
--	GroupName nvarchar(16),
--	DepartmentId int REFERENCES Departments(Id),
--	StartDate date,
--	EndDate date
--)

--CREATE TABLE Enrollments  
--(
--	Id int IDENTITY PRIMARY KEY,
--	StudentId int REFERENCES Students(Id),
--	GroupId int REFERENCES Groups(Id)
--)



--CREATE TABLE ClassesTable  
--(
--	Id int IDENTITY PRIMARY KEY,
--	GroupId int REFERENCES Groups(Id),
--	InstructorId int REFERENCES Instructors(Id),
--	Schedule nvarchar(32),
--	RoomName nvarchar(16)
--)

--ALTER TABLE ClassesTable
--ALTER COLUMN Schedule nvarchar(32)


--CREATE PROCEDURE InsertStudents (
--	@FirstName nvarchar(16),
--	@LastName nvarchar(20),
--	@DataOfBirth date,
--	@Username nvarchar(32),
--	@Password nvarchar(64)
--	)
--AS
--BEGIN
--	INSERT INTO Students (FirstName,LastName ,DataOfBirth ,Username ,Password ,EnrollmentDate)
--	VALUES (@FirstName,
--	@LastName ,
--	@DataOfBirth ,
--	@Username ,
--	@Password ,
--	GETDATE() )
--END

--EXEC InsertStudents N'Fərid', N'Nəcəfov','2005-04-02' , N'Najafoff', N'ferid1234'

--SELECT *FROM Students

--CREATE PROCEDURE InsertDepartments (
--	@DepartmentName nvarchar(32)
--	)
--AS
--BEGIN
--	INSERT INTO Departments (DepartmentName)
--	VALUES (@DepartmentName)
--END

--EXEC InsertDepartments N'IT Brains'

SELECT *FROM Departments

--CREATE PROCEDURE InsertInstructors (
--	@FirstName nvarchar(16),
--	@LastName nvarchar(20),
--	@HireDate date,
--	@DepartmentId int,
--	@Username nvarchar(32),
--	@Password nvarchar(64),
--	@FIN nvarchar(16)
--	)
--AS
--BEGIN
--	INSERT INTO Instructors (FirstName,LastName ,HireDate ,DepartmentId,Username ,Password ,FIN)
--	VALUES (@FirstName,
--	@LastName ,
--	@HireDate ,
--	@DepartmentId,
--	@Username ,
--	@Password ,
--	@FIN)
--END

--EXEC InsertInstructors N'Vilayət', N'Əliyev','2023-03-15' , 1,N'Aliyeff_022', N'Aliyeff1',N'2AB2CDE'

SELECT *FROM Instructors

--CREATE PROCEDURE InsertGroups(
--	@GroupName nvarchar(16),
--	@DepartmentId int,
--	@StartDate date,
--	@EndDate date
--	)
--AS
--BEGIN
--	INSERT INTO Groups (GroupName,
--	DepartmentId,
--	StartDate,
--	EndDate)
--	VALUES (@GroupName,
--	@DepartmentId,
--	@StartDate,
--	@EndDate)
--END

--EXEC InsertGroups N'AB108',1,'2024-10-01','2025-01-30'

SELECT*FROM Enrollments

--CREATE PROCEDURE InsertEnrollments (
--	@StudentId int,
--	@GroupId int
--	)
--AS
--BEGIN
--	INSERT INTO Enrollments (StudentId ,GroupId)
--	VALUES (@StudentId,@GroupId)
--END

--EXEC InsertEnrollments 3,1

--CREATE PROCEDURE InsertClassesTable (
--	@GroupId int,
--	@InstructorId int,
--	@Schedule nvarchar(32),
--	@RoomName nvarchar(16)
--	)
--AS
--BEGIN
--	INSERT INTO ClassesTable (GroupId,
--	InstructorId,
--	Schedule,
--	RoomName)
--	VALUES (@GroupId,
--	@InstructorId,
--	@Schedule,
--	@RoomName)
--END

--EXEC InsertClassesTable 1,1,'Mon/Tue/Wed/Thu/Fri 08:00-14:00','Yupiter'

--SELECT s.Id , s.FirstName as Ad, s.LastName as Soyad, g.GroupName as [Qrup Adı],ct.Schedule as [Dərs Vaxtları],ct.RoomName as [Otaq Adı] FROM Students as s
--JOIN Enrollments as e
--ON e.StudentId=s.Id
--JOIN Groups as g
--ON e.GroupId=g.Id
--JOIN ClassesTable as ct
--ON ct.GroupId = g.Id
