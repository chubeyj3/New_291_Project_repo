use [291Project]

DECLARE @ID int

/* Populate Department */
DECLARE @DepIDMin int
DECLARE @DepIDMax int
SET @DepIDMin = 0
SET @DepIDMax = 4

SET @ID = @DepIDMin
WHILE  @ID <= @DepIDMax
BEGIN
	INSERT INTO Department VALUES (@ID, 'DEP' + CAST(@ID as varchar(10)))
	SET @ID = @ID + 1
END

/* Populate WardType */
DECLARE @WardTypeMin int
DECLARE @WardTypeMax int
SET @WardTypeMin = 0
SET @WardTypeMax = 4

SET @ID = @WardTypeMin
WHILE  @ID <= @WardTypeMax
BEGIN
	INSERT INTO WardType VALUES (@ID, 'WARDTYPE' + CAST(@ID as varchar(10)))
	SET @ID = @ID + 1
END

/* Populate Patient */
DECLARE @PatientMin int
DECLARE @PatientMax int
SET @PatientMin = 0
SET @PatientMax = 29

SET @ID = @PatientMin
WHILE @ID <= @PatientMax
BEGIN
	INSERT INTO Patient VALUES (
		@ID,
		'FNAME' + CAST(@ID as varchar(10)),
		'LNAME' + CAST(@ID as varchar(10)),
		'COUNTRY' + CAST(@ID % 5 as varchar(10)),
		'STATE' + CAST(@ID % 3 as varchar(10)),
		'CITY' + CAST(@ID % 2 as varchar(10)),
		'STREETADDRESS' + CAST(@ID * 7 as varchar(10)),
		'POSTALCODE' + CAST(@ID as varchar(10))
	)
	SET @ID = @ID + 1
END

/* Populate Doctor */
DECLARE @DoctorMin int
DECLARE @DoctorMax int
SET @DoctorMin = 0
SET @DoctorMax = 14

SET @ID = @DoctorMin
WHILE  @ID <= @DoctorMax
BEGIN
	/* Generate FKs */
	DECLARE @RandDep int
	SET @RandDep = ROUND(((@DepIDMax - @DepIDMin) * RAND()) + @DepIDMin, 0)

	INSERT INTO Doctor VALUES (
		@ID,
		@RandDep,
		'DUTY_DETAILS' + CAST(@ID as varchar(10)),
		'FNAME' + CAST(@ID as varchar(10)),
		'LNAME' + CAST(@ID as varchar(10))
	)	
	SET @ID = @ID + 1
END

/* Populate Ward */
DECLARE @WardMin int
DECLARE @WardMax int
SET @WardMin = 0
SET @WardMax = 7

SET @ID = @WardMin
WHILE  @ID <= @WardMax
BEGIN
	/* Generate FKs */
	DECLARE @RandTypeID int
	SET @RandTypeID = ROUND(((@WardTypeMax - @WardTypeMin) * RAND()) + @WardTypeMin, 0)

	INSERT INTO Ward VALUES (
		@ID,
		ROUND((RAND() * 100), 0),
		@RandTypeID,
		'STATUS' + CAST(@ID as varchar(10))
	)
	SET @ID = @ID + 1
END

/* Populate PatientRegistration */
DECLARE @PatientRegMin int
DECLARE @PatientRegMax int
SET @PatientRegMin = 0
SET @PatientRegMax = 49

SET @ID = @PatientRegMin
WHILE  @ID <= @PatientRegMax
BEGIN
	/* Generate FKs */
	DECLARE @RandPID int
	DECLARE @RandWID int
	SET @RandPID = ROUND(((@PatientMax - @PatientMin) * RAND()) + @PatientMin, 0)
	SET @RandWID = ROUND(((@WardMax - @WardMin) * RAND()) + @WardMin, 0)

	INSERT INTO PatientRegistration VALUES (
		@ID,
		@RandPID,
		@RandWID,
		CAST(ROUND(@ID * RAND(), 0) as int) % 32,
		CAST(ROUND(@ID * RAND(), 0) as int) % 13,
		ROUND(@ID * RAND(), 0) + 2000,
		CAST(@ID % 25 as varchar(10)) + ':' + CAST(@ID % 60 as varchar(10))
	)	
	SET @ID = @ID + 1
END

/* Populate Consultant */
DECLARE @ConsultantMin int
DECLARE @ConsultantMax int
SET @ConsultantMin = @PatientMin
SET @ConsultantMax = @PatientMax + 25

SET @ID = @ConsultantMin
WHILE  @ID <= @ConsultantMax
BEGIN
	/* Generate FKs */
	DECLARE @RandDID int
	SET @RandDID = ROUND(((@DoctorMax - @DoctorMin) * RAND()) + @DoctorMin, 0)

	INSERT INTO Consultant VALUES (
		@ID % @PatientMax + 1,
		@RandDID
	)	
	SET @ID = @ID + 1
END



INSERT INTO MedSystemUser VALUES ('Admin', 'Admin', 1);
INSERT INTO MedSystemUser VALUES ('Receptionist', 'Receptionist', 2);
