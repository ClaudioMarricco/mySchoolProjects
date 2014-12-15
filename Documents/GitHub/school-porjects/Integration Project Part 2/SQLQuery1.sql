CREATE TABLE AdmissionRecord
(
AdmissionID INT(30) NOT NULL,
PatientID NVARCHAR(30) NOT NULL,
BedNumber NVARCHAR(30),
SerguryScheduled BIT,
AdminDate DATETIME,
SurgeryDate DATETIME,
DischargeDate DATETIME,
TV BIT,
Phone BIT
);
GO

CREATE TABLE Beds
(
BedNumber NVARCHAR(30) NOT NULL,
BedType NVARCHAR(30),
Occupied BIT,
WardName NVARCHAR(30)
);
GO

CREATE TABLE Doctors
(
DoctorID NVARCHAR(30) NOT NULL,
DrLastName NVARCHAR(30),
DrFirstName NVARCHAR(30),
Specialty NVARCHAR(30)
);
GO

CREATE TABLE Extra_Rates
(
AmenityName NVARCHAR(30),
DailyCost FLOAT(30)
);
GO

CREATE TABLE Extras
(
AdmissionID NVARCHAR(30) NOT NULL,
TV BIT,
Phone BIT,
SemiPrivateRoom BIT,
PrivateRoom BIT
);
GO

CREATE TABLE Logins
(
UserName NVARCHAR(30),
UPassword NVARCHAR(30),
Role NVARCHAR(10)
);
GO

CREATE TABLE Patients
(
HealthNumber NVARCHAR(30) NOT NULL,
DateOfBirth DATETIME,
LastName NVARCHAR(30),
FirstName NVARCHAR(30),
InsuranceNumber NVARCHAR(30) NOT NULL,
DoctorID NVARCHAR(30),
Ward NVARCHAR(30)
);
GO

CREATE TABLE PrivateInformation
(
InsuranceNumberID NVARCHAR(30) NOT NULL,
StreetAddress NVARCHAR(30),
City NVARCHAR(30),
Province NVARCHAR(30),
PostalCode NVARCHAR(30),
PhoneNumber NVARCHAR(30),
NextOfKin NVARCHAR(30),
Relation NVARCHAR(30)
);
GO

CREATE TABLE SurgicalReport
(
HealthNumber NVARCHAR(30) NOT NULL,
LastName NVARCHAR(30),
FirstName NVARCHAR(30),
LeadSurgeonID NVARCHAR(30),
ProcedureType NVARCHAR(30),
DatePerformed NVARCHAR(30),
Duration NVARCHAR(30) 
);

CREATE TABLE InsuranceCoverage
(
InsuranceNumber NVARCHAR(10) NOT NULL,
InsuranceCoverage FLOAT(10)
);

CREATE TABLE HospitalBills
(
BillID NVARCHAR(10) NOT NULL,
BillDate DATETIME,
BillInfo NVARCHAR(500)
);

GO