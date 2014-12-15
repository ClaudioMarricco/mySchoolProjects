ALTER TABLE AdmissionRecord
	ADD CONSTRAINT pk_AdmissionID
		PRIMARY KEY (AdmissionID);
		
ALTER TABLE Doctors
	ADD CONSTRAINT pk_DoctorID
		PRIMARY KEY (DoctorID);
		
ALTER TABLE Beds
	ADD CONSTRAINT pk_BedNumber
		PRIMARY KEY (BedNumber);
		
ALTER TABLE Patients
	ADD CONSTRAINT pk_HealthNumber
		PRIMARY KEY (HealthNumber);
		
ALTER TABLE PrivateInformation
	ADD CONSTRAINT pk_HealthNumber
		PRIMARY KEY (HealthNumber);
		
GO