INSERT INTO Extra_Rates (AmenityName, DailyCost)
VALUES ('Private', '571.00'),
('Semi-private', '267.00'),
('TV', '42.50'),
('Phone', '7.50')
;

INSERT INTO Patients (HealthNumber, InsuranceNumberID, DateOfBirth, FirstName, LastName, Ward, DoctorID)
VALUES ('123456789', '112233', 'May  4 1988 12:00AM', 'Claudio', 'Marricco', 'Surgery', '4444')
;

INSERT INTO PrivateInformation (StreetAddress, City, Province, HealthNumber, PostalCode, PhoneNumber, NextOfKin, Relation)
VALUES ('8770 Joliot-Curie','Montreal','Quebec','123456789','H1E5E5','5558984545','Danny','Brother'),
('1234 Langelier','Montreal','Quebec','987654321','R2Q5E5','5551236565','Pam','Wife')
;

INSERT INTO Patients (HealthNumber, InsuranceNumberID, DateOfBirth, FirstName, LastName, Ward, DoctorID)
VALUES ('987654321', '445566', 'June  24 1985 12:00AM', 'Bob', 'Vance', 'Urology', '8888')
;

INSERT INTO AdmissionRecord (AdmissionID, PatientID, SurgeryScheduled, BedNumber, AdmissionDate, SurgeryDate, DischargeDate, TV, Phone)
VALUES ('5544', '987654321', 'True', 'Uro01', '2013-10-11 00:00:00.000', '2013-10-12 00:00:00.000', '2013-10-14 00:00:00.000', 1, 1),
('8686', '123456789', 'True', 'Sur01', '2013-11-01 00:00:00.000', '2013-11-01 00:00:00.000', '2013-11-02 00:00:00.000', 1, 1)
;

INSERT INTO Doctors (DoctorID, DrFirstName, DrLastName, Specialty)
VALUES ('4444', 'Walter', 'White', 'Neurosociology'),
('5555', 'Rick', 'Hall', 'Internal medicine'),
('6666', 'Emily', 'Jonnz', 'Obstetrics and gynaecology'),
('8888', 'Luke', 'Stevens', 'Urology')
;

INSERT INTO InsuranceCoverage (InsuranceNumber, InsuranceCoverage)
VALUES ('112233', '.9'),
('445566', '.85'),
('778899', '.75')
;

INSERT INTO Logins (UserName, UPassword, Role)
VALUES ('White','4444','Doctor'),
('Hall','5555','Doctor'),
('Jonnz','6666','Doctor'),
('Stevens','8888','Doctor'),
('Betty','3333','Nurse'),
('Jackie','2222','Nurse'),
('Admin','9999','Admin')
;

INSERT INTO SurgicalReport (HealthNumber, FirstName, LastName, LeadSurgeonID, ProcedureType, DatePerformed, Duration)
VALUES ('987654321','Bob','Vance','8888','Prostate','2013-10-12 00:00:00.000','4'),
('123456789','Claudio','Marricco','4444','Knee','2013-11-01 00:00:00.000','5')
;

INSERT INTO Beds (BedNumber, BedType, Occupied, WardName)
VALUES ('Can01','Private',0,'Cancer Unit'),
('Can02','Private',0,'Cancer Unit'),
('Can03','Ward',0,'Cancer Unit'),
('Can04','Ward',0,'Cancer Unit'), 
('Car01','Private',0,'Cardiac Unit'),
('Car02','Ward',0,'Cardiac Unit'),
('Car03','Ward',0,'Cardiac Unit'),
('Ger01','Semi-Private',0,'Geriatric Unit'),
('Ger02','Semi-Private',0,'Geriatric Unit'), 
('Ger03','Semi-Private',0,'Geriatric Unit'), 
('In01','Semi-Private',0,'Intensive Care Unit'), 
('In02','Semi-Private',0,'Intensive Care Unit'), 
('In03','Ward',0,'Intensive Care Unit'),
('In04','Ward',0,'Intensive Care Unit'), 
('Med01','Semi-Private',0,'Medical Unit'), 
('Med02','Ward',0,'Medical Unit'), 
('Med03','Ward',0,'Medical Unit'), 
('Neo01','Private',0,'Neonatal Intensive Care Unit'), 
('Neu01','Private',0,'Neurology Unit'), 
('ObGy01','Private',0,'Obstetric and Gynecology Unit'),
('ObGy02','Private',0,'Obstetric and Gynecology Unit'),
('Ped01','Semi-Private',0,'Pediatric Unit'), 
('Ped02','Semi-Private',0,'Pediatric Unit'), 
('Ped03','Ward',0,'Pediatric Unit'), 
('Ped04','Ward',0,'Pediatric Unit'), 
('PedI01','Private',0,'Pediatric Intensive Care Unit'), 
('Psy01','Private',0,'Psychiatric Unit'), 
('Sur01','Semi-Private',1,'Surgical Unit'), 
('Sur02','Ward',0,'Surgical Unit'), 
('Sur03','Ward',0,'Surgical Unit'), 
('Uro01','Private',1,'Urology Unit') 
;