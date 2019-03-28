CREATE TABLE [Department] (
	[DepartmentID] int,
	[Name] varchar(25),
	PRIMARY KEY ([DepartmentID])
);

CREATE TABLE [Doctor] (
	[DoctorID] int,
	[DepartmentID] int,
	[DutyDetails] varchar(100),
	PRIMARY KEY ([DoctorID]),
	FOREIGN KEY ([DepartmentID]) REFERENCES Department
);

CREATE TABLE [WardType] (
	[WardID] int,
	[Type] varchar(25),
	PRIMARY KEY ([WardID])
);

CREATE TABLE [Ward] (
	[WardID] int,
	[Capacity] int,
	[TypeID] int,
	[Status] varchar(25),
	PRIMARY KEY ([WardID]),
	FOREIGN KEY ([TypeID]) REFERENCES WardType ([Type])
);

CREATE TABLE [Patient] (
	[PID] int,
	[FirstName] varchar(25),
	[LastName] varchar(25),
	[Country] varchar(25),
	[State] varchar(25),
	[City] varchar(25),
	[StreetAddress] varchar(25),
	[PostalCode] varchar(25),
	PRIMARY KEY ([PID])
);

CREATE TABLE [PatientContactInfo] (
	[Contact] varchar(25), /* Phone number, email address, ... */
	[PID] int,
	[ContactType] varchar(25), /* Phone, Email, ... */
	[Description] varchar(25), /* Work, Home, ... */
	PRIMARY KEY ([Contact], [PID]),
	FOREIGN KEY ([PID]) REFERENCES Patient
);

CREATE TABLE [PatientRegistration] (
	[RegistrationNumber] int,
	[PID] int,
	[WardID] int,
	[Day] int,
	[Month] int,
	[Year] int,
	[Time] varchar(5), /*__:__ (24 hour format) */
	PRIMARY KEY ([RegistrationNumber]),
	FOREIGN KEY ([PID]) REFERENCES Patient,
	FOREIGN KEY ([WardID]) REFERENCES Ward
);

CREATE TABLE [Consultant] (
	[PatientRegNum] int,
	[DoctorID] int,
	PRIMARY KEY ([PatientRegNum], [DoctorID]),
	FOREIGN KEY ([PatientRegNum]) REFERENCES PatientRegistration ([RegistrationNumber]),
	FOREIGN KEY ([DoctorID]) REFERENCES Doctor
);