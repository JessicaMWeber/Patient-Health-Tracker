USE Medicine
GO

CREATE TABLE Patient
(
	ID int PRIMARY KEY IDENTITY(1,1),
	Name VARCHAR(100),
	DateOfBirth datetime2,
	Room int,
	Allergies varchar(200),
	CodeStatus varchar(100)
)