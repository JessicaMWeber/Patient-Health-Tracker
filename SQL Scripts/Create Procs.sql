CREATE OR ALTER PROCEDURE GetMedicationsBySymptom
@Symptom VARCHAR(100)
AS
BEGIN
	SELECT * FROM Medications
	WHERE Symptom LIKE '%' + @Symptom + '%'
END

CREATE OR ALTER PROCEDURE GetMedicationByName
@Name VARCHAR(100)
AS
BEGIN
	SELECT * FROM Medications
	WHERE Name LIKE '%' + @Name + '%'
END