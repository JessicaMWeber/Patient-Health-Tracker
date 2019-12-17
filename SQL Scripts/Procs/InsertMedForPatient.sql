CREATE OR ALTER PROCEDURE InsertMedsForPatient
@id int,
@medID int,
@patientID int,
@medName VARCHAR(100),
@dose VARCHAR(100),
@route VARCHAR(100),
@medtime DATETIME2
AS
BEGIN
	INSERT INTO MedsForPatient
	VALUES
	( @medID, @patientID, @Dose, @Route, @MedTime )
END
GO