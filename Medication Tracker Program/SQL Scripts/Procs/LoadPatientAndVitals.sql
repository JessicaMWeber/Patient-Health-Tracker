CREATE OR ALTER PROCEDURE LoadPatientandVitals
@id int
AS
BEGIN
	SELECT p.ID, [Name], DateOfBirth, Room, Allergies, CodeStatus, Pulse, BPT, BPB, Oxygen, Respiration, Temp  FROM Patient p
	INNER JOIN VitalSigns vs
	ON p.ID = VS.PatientID
	WHERE p.ID = @id
END