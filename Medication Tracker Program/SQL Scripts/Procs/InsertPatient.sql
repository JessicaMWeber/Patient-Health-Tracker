CREATE OR ALTER PROCEDURE InsertPatient
@name VARCHAR(100),
@bday DATETIME2,
@room int,
@allergies VARCHAR(100),
@codestatus VARCHAR(100),
@pulse int,
@bpt int,
@bpb int,
@oxygen int,
@resp int,
@temp decimal
AS
BEGIN
	DECLARE @Table TABLE (ID int)
	DECLARE @PatientID int

	INSERT INTO Patient
	OUTPUT INSERTED.ID INTO @Table
	VALUES (@name, @bday, @room, @allergies, @codestatus)

	SELECT @PatientID = ID FROM @Table

	INSERT INTO VitalSigns 
	VALUES (@PatientID, @pulse , @bpt , @bpb, @oxygen, @resp, @temp)

	SELECT @PatientID ID
END