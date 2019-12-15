CREATE OR ALTER PROCEDURE SaveVitalSigns
@patientID int,
@pulse int,
@bpt int,
@bpb int,
@oxygen int,
@resp int,
@temp decimal
AS
BEGIN	
	UPDATE VitalSigns
	SET Pulse = @pulse,
		BPT = @bpt,
		BPB = @bpb,
		Oxygen = @oxygen,
		Respiration = @resp,
		Temp = @temp
	WHERE PatientID = @patientID
END