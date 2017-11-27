CREATE TABLE Credentials(
	Id INT PRIMARY KEY IDENTITY,
	Email VARCHAR(30),
	Password VARCHAR(20)
)

CREATE TABLE Locations(
	Id INT PRIMARY KEY IDENTITY,
	Latitude FLOAT,
	Longitude FLOAT
)

CREATE TABLE Users(
	Id INT PRIMARY KEY IDENTITY,
	Nickname VARCHAR(25),
	Gender CHAR(1),
	Age INT,
	LocationId  INT FOREIGN KEY REFERENCES Locations(Id),
	CredentialId INT FOREIGN KEY REFERENCES Credentials(Id) UNIQUE
)

CREATE TABLE Chats(
	Id INT PRIMARY KEY IDENTITY,
	Title VARCHAR(32),
	StartDate DATE,
	IsActive BIT
)

CREATE TABLE Messages(
	Id INT PRIMARY KEY IDENTITY,
	Content VARCHAR(200),
	SentOn DATE,
	ChatId INT FOREIGN KEY REFERENCES Chats(Id),
	UserId INT FOREIGN KEY REFERENCES Users(Id)
)

CREATE TABLE UsersChats(
	UserId INT FOREIGN KEY REFERENCES Users(Id),
	ChatId INT FOREIGN KEY REFERENCES Chats(Id),
	PRIMARY KEY (ChatId, UserId)
)