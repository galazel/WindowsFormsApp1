CREATE DATABASE EbotoDB
USE GalagarDB

CREATE TABLE Departments(
	DepartmentId INT PRIMARY KEY IDENTITY(1,1),
	DepartmentName VARCHAR(100)
)
CREATE TABLE Positions(
	PositionId INT PRIMARY KEY IDENTITY(1,1),
	PositionName VARCHAR(100)
)
CREATE TABLE Elections(
	ElectionId INT PRIMARY KEY IDENTITY(1,1),
	ElectionName VARCHAR(100),
	Description VARCHAR(100),
	Status bit,
	EndStatus bit,
	DepartmentId INT,
	CONSTRAINT FK_Elections_DepartmentId FOREIGN KEY(DepartmentId) REFERENCES Departments(DepartmentId),
)

CREATE TABLE Candidates(
	CandidateId INT PRIMARY KEY IDENTITY(1,1),
	CandidateName VARCHAR(100),
	Partylist VARCHAR(100),
	PositionId INT,
	CONSTRAINT FK_Candidates_PositionId FOREIGN KEY(PositionId) REFERENCES Positions(PositionId),
	Motto VARCHAR(100),
	Image VARCHAR(100),
	DepartmentId INT,
	CONSTRAINT FK_Candidates_DepartmentId FOREIGN KEY(DepartmentId) REFERENCES Departments(DepartmentId),
	ElectionId INT,
	CONSTRAINT FK_Candidates_ElectionId FOREIGN KEY(ElectionId) REFERENCES Elections(ElectionId),
)
CREATE TABLE Voters (
    VoterId INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    MiddleName NVARCHAR(100) NOT NULL,
    BirthDate DATE NOT NULL,
    ContactNumber NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Province NVARCHAR(100) NOT NULL,
    Barangay NVARCHAR(100) NOT NULL,
    City NVARCHAR(100) NOT NULL,
    Year NVARCHAR(100) NOT NULL,
    Section NVARCHAR(100) NOT NULL,
    Username NVARCHAR(100) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    Image NVARCHAR(100) NULL,
    Status BIT NOT NULL,
    DepartmentId INT NULL,
	CONSTRAINT FK_Voters_DepartmentId FOREIGN KEY(DepartmentId) REFERENCES Departments(DepartmentId),
    VotedCandidatesId INT NULL,
	CONSTRAINT FK_Voters_VotedCandidatesId FOREIGN KEY(VotedCandidatesId) REFERENCES VotedCandidates(VotedCandidatesId),
);

CREATE TABLE VotedCandidates(
	VotedCandidatesId INT PRIMARY KEY IDENTITY(1,1),
	VoterId INT ,
	CONSTRAINT FK_VotedCandidates_VoterId FOREIGN KEY(VoterId) REFERENCES Voters(VoterId),
	CandidateId INT , 
	CONSTRAINT FK_VotedCandidates_CandidateId FOREIGN KEY(CandidateId) REFERENCES Candidates(CandidateId),
	ElectionId INT , 
	CONSTRAINT FK_VotedCandidates_ElectionId FOREIGN KEY(ElectionId) REFERENCES Elections(ElectionId),
	PositionId INT
	CONSTRAINT FK_VotedCandidates_PositionId FOREIGN KEY(PositionId) REFERENCES Positions(PositionId),
)

CREATE TABLE Winners(
	WinnerId INT PRIMARY KEY IDENTITY(1,1),
	ElectionId INT , 
	CONSTRAINT FK_Winners_ElectionId FOREIGN KEY(ElectionId) REFERENCES Elections(ElectionId),
	CandidateId INT , 
	CONSTRAINT FK_Winners_CandidateId FOREIGN KEY(CandidateId) REFERENCES Candidates(CandidateId),
	Count INT,
	PositionId INT
	CONSTRAINT FK_Winners_PositionId FOREIGN KEY(PositionId) REFERENCES Positions(PositionId),
)