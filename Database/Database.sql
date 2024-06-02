--Admins table:

CREATE TABLE Admins (
AccountID int PRIMARY KEY IDENTITY(1,1),
Username varchar(50),
Password varchar(50),
AccountRole varchar(50)
);

--Employees table:

CREATE TABLE Employees (
EmployeeID int PRIMARY KEY IDENTITY(1,1),
Name varchar(100),
Email varchar(100),
Phone_Number varchar(20),
Address varchar(200),
Job_Title varchar(50),
Date_of_Hire date,
Date_of_Birth date,
AccountID int,
FOREIGN KEY (AccountID) REFERENCES Admins(AccountID)
);

--Salary table:

CREATE TABLE Salary (
SID int PRIMARY KEY IDENTITY(1,1),
EmployeeID int,
Amount decimal(10,2),
FOREIGN KEY (EmployeeID ) REFERENCES Employees(EmployeeID)
);

--Rooms table:

CREATE TABLE Rooms (
RoomID int PRIMARY KEY,
Room_Number varchar(20),
Room_Type varchar(50),
Availability varchar(20)
);

--Patients table:

CREATE TABLE Patients (
PatientID int PRIMARY KEY IDENTITY(1,1),
Name varchar(100),
Email varchar(100),
Phone_Number varchar(20),
Address varchar(200),
Date_of_Birth date,
Medical_History text
AccountID int,
FOREIGN KEY (AccountID) REFERENCES Admins(AccountID)
);

--Appointments table:

CREATE TABLE Appointments (
AppointmentID int PRIMARY KEY IDENTITY(1,1),
PatientID int,
EmployeeID int,
Appointment_Date_Time datetime,
Appointment_Type varchar(50),
FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),
FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

--Prescriptions table:

CREATE TABLE Prescriptions (
PrescriptionID int PRIMARY KEY IDENTITY(1,1),
PatientID int,
DoctorID int,
Prescription_Date date,
Medication_Name varchar(100),
Dosage varchar(50),
Frequency varchar(50),
Duration varchar(50),
FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),
FOREIGN KEY (DoctorID) REFERENCES Employees(EmployeeID)
);

--Test_Procedures table:

CREATE TABLE Test_Procedures (
TestProcedureID int PRIMARY KEY,
PatientID int,
DoctorID int,
Test_Date date,
Test_Type varchar(50),
Test_Results text,
FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),
FOREIGN KEY (DoctorID) REFERENCES Employees(EmployeeID)
);

--Payments table:

CREATE TABLE Payments (
PaymentID int PRIMARY KEY IDENTITY(1,1),
PatientID int,
Payment_Date_Time datetime,
Payment_Amount decimal(10,2),
Payment_Type varchar(50),
isPaid bool,
FOREIGN KEY (PatientID) REFERENCES Patients(PatientID)
);

