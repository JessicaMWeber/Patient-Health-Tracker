CREATE OR ALTER PROCEDURE GetMedicationByName
@Name VARCHAR(100)
AS
BEGIN
	SELECT * FROM Medications
	WHERE [Name] LIKE '%' + @Name + '%'
END
GO