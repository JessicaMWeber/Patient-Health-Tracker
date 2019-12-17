CREATE OR ALTER PROCEDURE GetMedsForPatient
@PatientID int
AS
BEGIN
	SELECT m.Name, mfp.Dose, mfp.Route, mfp.MedTime FROM MedsForPatient mfp
	INNER JOIN Medications m
	ON m.ID = mfp.MedID
	WHERE mfp.PatientID = @PatientID
END
GO