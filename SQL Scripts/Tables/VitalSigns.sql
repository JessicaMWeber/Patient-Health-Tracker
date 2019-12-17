CREATE TABLE VitalSigns
(
	ID int PRIMARY KEY IDENTITY (1,1),
	PatientID int FOREIGN KEY REFERENCES Patient (ID),
	Pulse int,
	BPT int,
	BPB int,
	Oxygen int,
	Respiration int,
	Temp decimal (3, 1)
)
