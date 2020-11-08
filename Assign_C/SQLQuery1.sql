
--Createing table 'students'
CREATE TABLE [dbo].[Students](
[Id] int IDENTITY(1,1) NOT NULL,
[FirstName] nvarchar(max) NOT NULL,
[LastName] nvarchar(max) NOT NULL,
[DateOfBirth] Date NULL,
	[UserId] nvarchar(max) NOT NULL
PRIMARY KEY(Id));
GO

--Createing table 'Courses'
CREATE TABLE [dbo].[Courses](
[Id] int IDENTITY(1,1) NOT NULL,
[Name] nvarchar(max) NOT NULL,
[Description] nvarchar(max) NOT NULL,
[StartDate] DateTime NOT NULL,
[EndDate] Datetime NOT NULL,
[StudentId] int NOT NULL
PRIMARY KEY(Id)
FOREIGN KEY (StudentId) REFERENCES Students(Id));
GO

--Createing table 'Enrollments'
CREATE TABLE [dbo].[Enrollments]
(
[Id] int IDENTITY(1,1) NOT NULL,
[StudentID] int NOT NULL,
[CourseID] int NOT NULL,
PRIMARY KEY(Id),
FOREIGN KEY (StudentID) REFERENCES Students(Id),
FOREIGN KEY(CourseID) REFERENCES Courses(Id)

);
GO