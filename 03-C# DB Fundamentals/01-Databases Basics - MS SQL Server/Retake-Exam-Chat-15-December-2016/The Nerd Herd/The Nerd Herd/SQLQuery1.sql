CREATE DATABASE TheNerdHerd
GO
USE TheNerdHerd
GO

CREATE TABLE Credentials(
	Id INT PRIMARY KEY,
	Email VARCHAR(30),
	Password VARCHAR(20)
)

CREATE TABLE Locations(
	Id INT PRIMARY KEY,
	Latitude DECIMAL(8),
	Longitude DECIMAL(8)
)

CREATE TABLE Users(
	Id INT PRIMARY KEY IDENTITY,
	Nickname VARCHAR(25),
	Gender CHAR(1),
	Age INT,
	Location_id INT FOREIGN KEY REFERENCES Locations(Id),
	Credential_id INT FOREIGN KEY REFERENCES Credentials(Id) UNIQUE
)

CREATE TABLE Chats(
	Id INT PRIMARY KEY,
	Title VARCHAR(32),
	StartDate DATE,
	IsActive BIT
)

CREATE TABLE Messages(
	Id INT PRIMARY KEY,
	Content VARCHAR(200),
	SentOn DATE,
	ChatId INT FOREIGN KEY REFERENCES Chats(Id),
	UserId INT FOREIGN KEY REFERENCES Users(Id)
)

CREATE TABLE UsersChats(
	UserId INT FOREIGN KEY REFERENCES Users(Id),
	ChatId INT FOREIGN KEY REFERENCES Chats(Id),
	PRIMARY KEY (UserId, ChatId)
)