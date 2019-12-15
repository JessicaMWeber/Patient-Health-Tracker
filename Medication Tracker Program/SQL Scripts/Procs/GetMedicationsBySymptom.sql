CREATE OR ALTER PROCEDURE GetMedicationsBySymptom
@Symptom VARCHAR(100)
AS
BEGIN
	SELECT * FROM Medications
	WHERE Symptom LIKE '%' + @Symptom + '%'
END
GO