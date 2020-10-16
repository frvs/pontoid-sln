CREATE TABLE dbo.School (
	Id varchar(50) PRIMARY KEY, 
	Name varchar(50), 
	InepCode int
)

CREATE TABLE dbo.Class (
	Id varchar(50) PRIMARY KEY, 
	SchoolId varchar(50) FOREIGN KEY REFERENCES dbo.School(Id), 
	Description varchar(50), 
	Grade int, 
	Turn int
)

CREATE TABLE dbo.Student (
	Id varchar(50) PRIMARY KEY, 
	ClassId varchar(50) FOREIGN KEY REFERENCES dbo.Class(Id), 
	Name varchar(50), 
	BirthDate datetime, 
	Cpf varchar(11)
)

CREATE TABLE dbo.LogException (
	Id varchar(50) PRIMARY KEY, 
	Message varchar(max), 
	Stack varchar(max), 
	Hour datetime
)
