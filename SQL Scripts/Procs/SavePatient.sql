CREATE OR ALTER PROCEDURE SavePatient
@patientID int,
@name VARCHAR(100),
@bday DATETIME2,
@room int,
@allergies VARCHAR(100),
@codestatus VARCHAR(100)
AS 
BEGIN

	UPDATE Patient
	SET [Name] = @name,
		DateOfBirth = @bday,
		Room = @room,
		Allergies = @allergies,
		CodeStatus = @codestatus
	WHERE ID = @patientID
END