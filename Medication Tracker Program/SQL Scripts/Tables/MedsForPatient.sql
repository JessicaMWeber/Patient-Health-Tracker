CREATE TABLE MedsForPatient
(
	ID int IDENTITY (1,1),
	MedID int FOREIGN KEY REFERENCES Medications(ID),
	PatientID int FOREIGN KEY REFERENCES Patient(ID),
	Dose varchar(50),
	[Route] varchar(100),
	MedTime datetime2
)