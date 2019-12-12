CREATE PROC AddPatient
@Name VARCHAR(100),
@DateOfBirth datetime2,
@Room int,
@Allergies varchar(200),
@CodeStatus varchar(100)
AS
BEGIN
	INSERT INTO Patient
	VALUES
	(@Name, @DateOfBirth, @Room, @Allergies, @CodeStatus)
END