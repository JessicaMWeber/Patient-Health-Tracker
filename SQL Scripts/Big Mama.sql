USE Workingtemp
GO

DROP PROC dbo.AddMedToPatient
DROP PROC dbo.AddPatient
DROP PROC dbo.GetMedicationByName
DROP PROC dbo.GetMedicationsBySymptom
DROP PROC dbo.GetPatient
DROP PROC dbo.GetPatientIDS
DROP PROC dbo.InsertPatient
DROP PROC dbo.LoadPatientandVitals
DROP PROC dbo.SavePatient
DROP PROC dbo.SaveVitalSigns
DROP PROC dbo.InsertMedsForPatient
DROP PROC dbo.GetMedsForPatient
GO

DROP TABLE MedsForPatient
DROP TABLE Medications
DROP TABLE VitalSigns
DROP TABLE Patient
GO

CREATE TABLE Patient
(
	ID int PRIMARY KEY IDENTITY(1,1),
	PatientName VARCHAR(100),
	DateOfBirth datetime2,
	Room int,
	Allergies varchar(200),
	CodeStatus varchar(100)
)
GO

CREATE TABLE Medications
(
	ID int PRIMARY KEY IDENTITY(1,1),
	Name varchar(100),
	Symptom varchar(100)
)
GO

CREATE TABLE MedsForPatient
(
	ID int IDENTITY (1,1),
	MedID int FOREIGN KEY REFERENCES Medications(ID),
	PatientID int FOREIGN KEY REFERENCES Patient(ID),
	Dose varchar(50),
	[Route] varchar(100),
	MedTime datetime2
)
GO

CREATE TABLE VitalSigns
(
	ID int PRIMARY KEY IDENTITY (1,1),
	PatientID int FOREIGN KEY REFERENCES Patient (ID),
	Pulse int,
	BloodPressureTop int,
	BloodPressureBottom int,
	Oxygen int,
	Respiration int,
	Temp decimal (3, 1)
)
GO

CREATE PROCEDURE LoadPatientandVitals
@id int
AS
BEGIN
	SELECT p.ID, PatientName, DateOfBirth, Room, Allergies, CodeStatus, Pulse, BloodPressureTop, BloodPressureBottom, Oxygen, Respiration, Temp  FROM Patient p
	INNER JOIN VitalSigns vs
	ON p.ID = VS.PatientID
	WHERE p.ID = @id
END
GO

CREATE PROC AddPatient
@PatientName VARCHAR(100),
@DateOfBirth datetime2,
@Room int,
@Allergies varchar(200),
@CodeStatus varchar(100)
AS
BEGIN
	INSERT INTO Patient
	VALUES
	(@PatientName, @DateOfBirth, @Room, @Allergies, @CodeStatus)
END
GO

CREATE PROCEDURE SaveVitalSigns
@patientID int,
@pulse int,
@BloodPressureTop int,
@BloodPressureBottom int,
@oxygen int,
@resp int,
@temp decimal (3, 1)
AS
BEGIN	
	UPDATE VitalSigns
	SET Pulse = @pulse,
		BloodPressureTop = @BloodPressureTop,
		BloodPressureBottom = @BloodPressureBottom,
		Oxygen = @oxygen,
		Respiration = @resp,
		Temp = @temp
	WHERE PatientID = @patientID
END
GO

CREATE PROCEDURE InsertMedsForPatient
@id int,
@medID int,
@patientID int,
@medName VARCHAR(100),
@dose VARCHAR(100),
@route VARCHAR(100),
@medtime DATETIME2
AS
BEGIN
	INSERT INTO MedsForPatient
	VALUES
	( @medID, @patientID, @Dose, @Route, @MedTime )
END
GO

CREATE PROCEDURE InsertPatient
@name VARCHAR(100),
@bday DATETIME2,
@room int,
@allergies VARCHAR(100),
@codestatus VARCHAR(100),
@pulse int,
@BloodPressureTop int,
@BloodPressureBottom int,
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
	VALUES (@PatientID, @pulse , @BloodPressureTop , @BloodPressureBottom, @oxygen, @resp, @temp)

	SELECT @PatientID ID
END
GO

CREATE OR ALTER PROCEDURE GetPatient
@ID int
AS
BEGIN
	SELECT p.ID, p.PatientName, p.DateOfBirth, p.Room, p.Allergies, p.CodeStatus,
		   vs.Pulse, vs.BloodPressureTop, vs.BloodPressureBottom, vs.Oxygen, vs.Respiration, vs.Temp FROM Patient p
	INNER JOIN [CAPITAL\avankeulen3].VitalSigns vs
	ON p.ID = vs.PatientID
	WHERE p.ID = @ID
END
GO

CREATE OR ALTER PROCEDURE SavePatient
@patientID int,
@name VARCHAR(100),
@bday DATETIME2,
@room int,
@allergies VARCHAR(100),
@codestatus VARCHAR(100)
AS 
BEGIN

	UPDATE Patient
	SET PatientName = @name,
		DateOfBirth = @bday,
		Room = @room,
		Allergies = @allergies,
		CodeStatus = @codestatus
	WHERE ID = @patientID
END
GO

CREATE PROCEDURE GetPatientIDS
AS
BEGIN
	SELECT PatientName, ID FROM Patient
	ORDER BY ID
END
GO

CREATE PROCEDURE GetMedicationsBySymptom
@Symptom VARCHAR(100)
AS
BEGIN
	SELECT * FROM Medications
	WHERE Symptom LIKE '%' + @Symptom + '%'
END
GO

CREATE PROCEDURE GetMedicationByName
@Name VARCHAR(100)
AS
BEGIN
	SELECT * FROM Medications
	WHERE [Name] LIKE '%' + @Name + '%'
END
GO

CREATE PROC AddMedToPatient
@MedID int,
@PatientID int,
@Dose varchar(50),
@Route varchar(100),
@MedTime datetime2
AS
BEGIN
	INSERT INTO MedsForPatient
	VALUES
	( @medID, @PatientID, @Dose, @Route, @MedTime )
END
GO

CREATE PROCEDURE GetMedsForPatient
@PatientID int
AS
BEGIN
	SELECT m.ID, m.Name, m.Symptom, mfp.Dose, mfp.Route, mfp.MedTime FROM MedsForPatient mfp
	INNER JOIN Medications m
	ON m.ID = mfp.MedID
	WHERE mfp.PatientID = @PatientID
END
GO


INSERT INTO Medications VALUES ('acetaminophen (Tylenol/APAP)', 'pain')
INSERT INTO Medications VALUES ('acetaminophen/codeine (Tylenol #3)', 'pain')
INSERT INTO Medications VALUES ('albuterol (Proair, Proventil)', 'breathing difficulty ')
INSERT INTO Medications VALUES ('alendronate (Fosamax)', 'osteoporosis ')
INSERT INTO Medications VALUES ('allopurinol', 'gout')
INSERT INTO Medications VALUES ('alprazolam (Xanax)', 'anxiety')
INSERT INTO Medications VALUES ('aluminum hydroxide, magnesium hydroxide (Maalox)', 'heartburn')
INSERT INTO Medications VALUES ('amitriptyline (Elavil)', 'depression')
INSERT INTO Medications VALUES ('amlodipine (Norvasc)', 'HTN')
INSERT INTO Medications VALUES ('amoxicillin (Amoxil)', 'infection')
INSERT INTO Medications VALUES ('aripiprazole (Abilify)', 'sleep')
INSERT INTO Medications VALUES ('artificial tears ', 'dry eyes')
INSERT INTO Medications VALUES ('ascorbic acid (vitamin C)', 'vitamin')
INSERT INTO Medications VALUES ('aspirin + ER dipyridamole (Aggrenox)', 'blood clots')
INSERT INTO Medications VALUES ('aspirin/acetylsalicylic acid (ASA)', 'pain')
INSERT INTO Medications VALUES ('atenolol (Tenormin)', 'HTN')
INSERT INTO Medications VALUES ('atorvastatin (Lipitor)', 'high cholestrol')
INSERT INTO Medications VALUES ('baclofen', 'muscle tension')
INSERT INTO Medications VALUES ('betaxolol (Betoptic)', 'glaucoma')
INSERT INTO Medications VALUES ('bimatoprost (Lumigan)', 'glaucoma')
INSERT INTO Medications VALUES ('bisacodyl (Dulcolax)', 'constipation')
INSERT INTO Medications VALUES ('bismuth subsalicylate (Pepto-Bismol)', 'diarrhea')
INSERT INTO Medications VALUES ('brimonidine (Alphagan)', 'glaucoma')
INSERT INTO Medications VALUES ('budesonide + formoterol (Symbicort)', 'asthma')
INSERT INTO Medications VALUES ('budesonide (Pulmicort)', 'breathing difficulty ')
INSERT INTO Medications VALUES ('bumetanide', 'HTN')
INSERT INTO Medications VALUES ('buspirone (Buspar)', 'anxiety')
INSERT INTO Medications VALUES ('calcitonin (Miacalcin, Fortical)', 'osteoporosis ')
INSERT INTO Medications VALUES ('calcium carbonate (Tums)', 'nausea')
INSERT INTO Medications VALUES ('calcium (Os-cal)', 'vitamin')
INSERT INTO Medications VALUES ('captopril (Capoten)', 'HTN')
INSERT INTO Medications VALUES ('carbamazepine (Tegretol)', 'convulsions')
INSERT INTO Medications VALUES ('cefdinir', 'infection')
INSERT INTO Medications VALUES ('celecoxib (Celebrex)', 'pain')
INSERT INTO Medications VALUES ('cephalexin (Keflex)', 'infection')
INSERT INTO Medications VALUES ('cetirizine (Zyrtec)', 'allergies')
INSERT INTO Medications VALUES ('cholestyramine (Questran)', 'high cholestrol')
INSERT INTO Medications VALUES ('cimetidine (Tagamet)', 'stomach ulcer')
INSERT INTO Medications VALUES ('citalopram (Celexa)', 'depression')
INSERT INTO Medications VALUES ('clindamycin (Cleocin)', 'infection')
INSERT INTO Medications VALUES ('clonazepam (Klonopin)', 'convulsions')
INSERT INTO Medications VALUES ('clopidogrel (Plavix)', 'high cholestrol')
INSERT INTO Medications VALUES ('codeine', 'cough')
INSERT INTO Medications VALUES ('conjugated estrogen (Premarin)', 'hormone')
INSERT INTO Medications VALUES ('cortisone', 'inflammation ')
INSERT INTO Medications VALUES ('cyanocobalamin (Vitamin B12)', 'vitamin')
INSERT INTO Medications VALUES ('cyclobenzaprine', 'muscle tension')
INSERT INTO Medications VALUES ('dexamethasone (Decadron)', 'inflammation ')
INSERT INTO Medications VALUES ('diazepam (Valium)', 'anxiety')
INSERT INTO Medications VALUES ('digoxin (Lanoxin)', 'heart failure')
INSERT INTO Medications VALUES ('diltiazen (Cardizem)', 'HTN')
INSERT INTO Medications VALUES ('diphenhydramine (Benadryl)', 'allergies')
INSERT INTO Medications VALUES ('divalproex sodium (Depakote)', 'convulsions')
INSERT INTO Medications VALUES ('docusate sodium (Colace)', 'constipation')
INSERT INTO Medications VALUES ('donepezil (Aricept)', 'dementia')
INSERT INTO Medications VALUES ('duloxetine', 'depression')
INSERT INTO Medications VALUES ('enalapril (Vasotec)', 'HTN')
INSERT INTO Medications VALUES ('enoxaparin (Lovenox)', 'blood clots')
INSERT INTO Medications VALUES ('escitalopram (Lexapro)', 'depression')
INSERT INTO Medications VALUES ('esomeprazole (Nexium)', 'heartburn')
INSERT INTO Medications VALUES ('estradiol', 'hormone')
INSERT INTO Medications VALUES ('ezetimibe (Zetia)', 'high cholestrol')
INSERT INTO Medications VALUES ('famotidine (Pepcid)', 'heartburn')
INSERT INTO Medications VALUES ('fentanyl transdermal (Duragesic)', 'pain')
INSERT INTO Medications VALUES ('ferrous sulfate (Feosol)', 'anemia')
INSERT INTO Medications VALUES ('fexofenadine (Allegra)', 'allergies')
INSERT INTO Medications VALUES ('finasteride (Proscar)', 'hormone')
INSERT INTO Medications VALUES ('fluticasone + salmeterol (Advair)', 'asthma')
INSERT INTO Medications VALUES ('fluticasone (Flovent)', 'breathing difficulty ')
INSERT INTO Medications VALUES ('folic acid', 'vitamin')
INSERT INTO Medications VALUES ('furosemide (Lasix)', 'HTN')
INSERT INTO Medications VALUES ('gabapentin (Neurontin)', 'convulsions')
INSERT INTO Medications VALUES ('gemfibrozil (Lopid)', 'high cholestrol')
INSERT INTO Medications VALUES ('gentamicin', 'eye infection')
INSERT INTO Medications VALUES ('glimepiride (Amaryl)', 'diabetes')
INSERT INTO Medications VALUES ('glipizide (Glucotrol)', 'diabetes')
INSERT INTO Medications VALUES ('glucogan', 'diabetes')
INSERT INTO Medications VALUES ('glyburide (DiaBeta)', 'diabetes')
INSERT INTO Medications VALUES ('guaifenesin (Mucinex)', 'cough')
INSERT INTO Medications VALUES ('haloperidol (Haldol)', 'psychosis')
INSERT INTO Medications VALUES ('heparin', 'blood clots')
INSERT INTO Medications VALUES ('humulin (insulin)', 'diabetes')
INSERT INTO Medications VALUES ('hydralazine', 'HTN')
INSERT INTO Medications VALUES ('hydrochlorothiazide / HCTZ', 'HTN')
INSERT INTO Medications VALUES ('hydrocodone/acetaminophen (Lortab, Norco, Vicodin)', 'pain')
INSERT INTO Medications VALUES ('hydrocortisone (Solu-Cortef)', 'inflammation ')
INSERT INTO Medications VALUES ('hydroxyzine (Vistaril)', 'anxiety')
INSERT INTO Medications VALUES ('ibuprofen (Motrin, Advil)', 'pain')
INSERT INTO Medications VALUES ('insulin glargine (insulin)', 'diabetes')
INSERT INTO Medications VALUES ('iodine, iodide', 'overactive thyroid ')
INSERT INTO Medications VALUES ('ipratropium + albuterol (Duoneb)', 'breathing difficulty ')
INSERT INTO Medications VALUES ('ipratropium (Atrovent)', 'breathing difficulty ')
INSERT INTO Medications VALUES ('iron polysaccharide (Niferex)', 'anemia')
INSERT INTO Medications VALUES ('isosorbide (Imdur, Isordil)', 'angina')
INSERT INTO Medications VALUES ('ketorolac (Toradol)', 'pain')
INSERT INTO Medications VALUES ('labetalol', 'HTN')
INSERT INTO Medications VALUES ('lactulose', 'constipation')
INSERT INTO Medications VALUES ('lamotrigine (Lamictal)', 'convulsions')
INSERT INTO Medications VALUES ('lansoprazole (Prevacid)', 'heartburn')
INSERT INTO Medications VALUES ('latanoprost (Xalatan)', 'glaucoma')
INSERT INTO Medications VALUES ('levalbuterol (Xopenex)', 'breathing difficulty ')
INSERT INTO Medications VALUES ('levodopa + carbidopa (Sinemet)', 'parkinsons')
INSERT INTO Medications VALUES ('levofloxacin (Levaquin)', 'infection')
INSERT INTO Medications VALUES ('levothyroxine (Levoxyl, Synthroid)', 'hormone')
INSERT INTO Medications VALUES ('lisinopril (Zestril)', 'HTN')
INSERT INTO Medications VALUES ('loperamide (Imodium)', 'diarrhea')
INSERT INTO Medications VALUES ('loratadine (Claritin)', 'allergies')
INSERT INTO Medications VALUES ('lorazepam (Antivan)', 'anxiety')
INSERT INTO Medications VALUES ('losartan (Cozaar)', 'HTN')
INSERT INTO Medications VALUES ('magnesium hydroxide (Milk of Mag)', 'constipation')
INSERT INTO Medications VALUES ('megestrol (Megace)', 'hormone')
INSERT INTO Medications VALUES ('meloxicam (Mobic)', 'pain')
INSERT INTO Medications VALUES ('memantine (Namenda)', 'dementia')
INSERT INTO Medications VALUES ('meperidine (Demerol)', 'pain')
INSERT INTO Medications VALUES ('mesalamine (Asacol)', 'pain')
INSERT INTO Medications VALUES ('metformin (Glucophage)', 'diabetes')
INSERT INTO Medications VALUES ('methotrexate', 'cancer')
INSERT INTO Medications VALUES ('methylprednisolone (Solu-medrol)', 'inflammation ')
INSERT INTO Medications VALUES ('metoclopramide (Reglan)', 'nasea')
INSERT INTO Medications VALUES ('metolazone (Zaroxolyn)', 'HTN')
INSERT INTO Medications VALUES ('metoprolol (Lopressor, Toprol-XL)', 'HTN')
INSERT INTO Medications VALUES ('mirtazapine (Remeron)', 'depression')
INSERT INTO Medications VALUES ('montelukast (Singulair)', 'breathing difficulty ')
INSERT INTO Medications VALUES ('morphine (MS)', 'pain')
INSERT INTO Medications VALUES ('multi-vitamin with mineral (Ocuvite)', 'vitamin')
INSERT INTO Medications VALUES ('mupirocin (Bactroban)', 'infection')
INSERT INTO Medications VALUES ('naproxen', 'pain')
INSERT INTO Medications VALUES ('nitrofurantoin (Macrodantin/Macrobid)', 'UTI')
INSERT INTO Medications VALUES ('nitroglycerine', 'angina')
INSERT INTO Medications VALUES ('nitro-patch', 'angina')
INSERT INTO Medications VALUES ('nitrostat', 'angina')
INSERT INTO Medications VALUES ('novolin (insulin)', 'diabetes')
INSERT INTO Medications VALUES ('nystatin (Mycostatin)', 'fungal infection')
INSERT INTO Medications VALUES ('ofloxacin', 'eye infection')
INSERT INTO Medications VALUES ('olmesartan (Benicar)', 'HTN')
INSERT INTO Medications VALUES ('omeprazole (Prilosec)', 'heartburn')
INSERT INTO Medications VALUES ('ondansetron (Zofran)', 'nausea')
INSERT INTO Medications VALUES ('oxybutin (Ditropan XL)', 'overactive bladder')
INSERT INTO Medications VALUES ('oxycodone (Oxycontin)', 'pain')
INSERT INTO Medications VALUES ('pantoprazole (Protonix)', 'heartburn')
INSERT INTO Medications VALUES ('paroxetine (Paxil)', 'depression')
INSERT INTO Medications VALUES ('phenobarbital', 'convulsions')
INSERT INTO Medications VALUES ('phenytoin (Dilantin)', 'convulsions')
INSERT INTO Medications VALUES ('pilocarpine', 'glaucoma')
INSERT INTO Medications VALUES ('pioglitazone (Actos)', 'diabetes')
INSERT INTO Medications VALUES ('polyethylene glycol (Miralax)', 'constipation')
INSERT INTO Medications VALUES ('potassium chloride (Klor-Con, K-Tab, K-Dur)', 'vitamin')
INSERT INTO Medications VALUES ('prednisolone', 'inflammation ')
INSERT INTO Medications VALUES ('prednisone', 'inflammation ')
INSERT INTO Medications VALUES ('prochlorperazine', 'nausea')
INSERT INTO Medications VALUES ('promethazine', 'allergies')
INSERT INTO Medications VALUES ('pseudoephedrine (Sudafed)', 'congestion')
INSERT INTO Medications VALUES ('psyllium (Metamucil)', 'constipation')
INSERT INTO Medications VALUES ('quetiapine (Seroquel)', 'psychosis')
INSERT INTO Medications VALUES ('quinapril (Accupril)', 'HTN')
INSERT INTO Medications VALUES ('ralozifene (Evista)', 'osteoporosis ')
INSERT INTO Medications VALUES ('ramapril (Altace)', 'HTN')
INSERT INTO Medications VALUES ('ranitidine (Zantac)', 'heartburn')
INSERT INTO Medications VALUES ('risedronate (Actonel)', 'osteoporosis ')
INSERT INTO Medications VALUES ('risperidone (Risperdal)', 'psychosis')
INSERT INTO Medications VALUES ('rosuvastatin (Crestor)', 'high cholestrol')
INSERT INTO Medications VALUES ('sennosides (Senokot, Ex-Lax, Senna)', 'constipation')
INSERT INTO Medications VALUES ('sertraline (Zoloft)', 'depression')
INSERT INTO Medications VALUES ('simethicone (Gas-x/ Mylanta)', 'gas')
INSERT INTO Medications VALUES ('simvastatin (Zocor)', 'high cholestrol')
INSERT INTO Medications VALUES ('sitagliptin (Januvia)', 'diabetes')
INSERT INTO Medications VALUES ('spironolactone (Aldactone)', 'HTN')
INSERT INTO Medications VALUES ('sulfamethoxazole-trimethoprim (Bacterium/Septra)', 'infection')
INSERT INTO Medications VALUES ('tamoxifen', 'cancer')
INSERT INTO Medications VALUES ('tamsulosin (Flomax)', 'overactive bladder')
INSERT INTO Medications VALUES ('temazepam (Restoril)', 'sleep')
INSERT INTO Medications VALUES ('terazosin', 'HTN')
INSERT INTO Medications VALUES ('timolol (Timoptic)', 'glaucoma')
INSERT INTO Medications VALUES ('tiotropium (Spiriva)', 'breathing difficulty ')
INSERT INTO Medications VALUES ('tolterodine (Detrol)', 'overactive bladder')
INSERT INTO Medications VALUES ('tramadol (Ultram)', 'pain')
INSERT INTO Medications VALUES ('travoprost (Travatan)', 'glaucoma')
INSERT INTO Medications VALUES ('trazodone', 'depression')
INSERT INTO Medications VALUES ('valproic acid (Depakene)', 'convulsions')
INSERT INTO Medications VALUES ('valsartan (Diovan)', 'HTN')
INSERT INTO Medications VALUES ('verapamil (Isoptin SR)', 'HTN')
INSERT INTO Medications VALUES ('Vitamin E', 'vitamin')
INSERT INTO Medications VALUES ('warfarin (Coumadin)', 'blood clots')
INSERT INTO Medications VALUES ('zolpidem (Ambien)', 'sleep')
INSERT INTO Medications VALUES ('cough drop', 'cough')
INSERT INTO Medications VALUES ('protien powder', 'vitamin')
GO