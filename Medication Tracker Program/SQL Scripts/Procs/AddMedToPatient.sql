CREATE PROC AddMedToPatient
@MedicationsID int,
@PatientID int,
@Dose varchar(50),
@Route varchar(100),
@TimeGiven datetime2
AS
BEGIN
	INSERT INTO MedsForPatient
	VALUES
	( @MedicationsID, @PatientID, @Dose, @Route, @TimeGiven )
END