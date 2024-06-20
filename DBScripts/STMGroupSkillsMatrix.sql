USE master
GO

IF EXISTS (SELECT * FROM sys.databases WHERE NAME = 'STMGroupSkillsMatrix')
	ALTER DATABASE [STMGroupSkillsMatrix] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
GO
IF EXISTS (SELECT * FROM sys.databases WHERE NAME = 'STMGroupSkillsMatrix')
	DROP DATABASE STMGroupSkillsMatrix

GO

CREATE DATABASE STMGroupSkillsMatrix
GO

USE STMGroupSkillsMatrix
GO

CREATE TABLE UserStatus (
	StatusId INT NOT NULL IDENTITY (1, 1),
	StatusName NVARCHAR(10) NOT NULL,
	CONSTRAINT pk_UserStatus PRIMARY KEY (StatusId)
)
GO

INSERT INTO UserStatus
	( StatusName )
VALUES
	( 'Active' ),
	( 'Inactive' )
GO

CREATE TABLE [User] (
	UserId INT NOT NULL IDENTITY (1, 1),
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	StatusId INT NOT NULL,
	CONSTRAINT pk_User PRIMARY KEY (UserId),
	CONSTRAINT fk_User_UserStatus FOREIGN KEY (StatusId)
		REFERENCES UserStatus (StatusId)
)
GO

CREATE TABLE Skill (
	SkillId INT NOT NULL IDENTITY (1, 1),
	SkillName NVARCHAR(50) NOT NULL,
	CONSTRAINT pk_Skill PRIMARY KEY (SkillId)
)
GO

CREATE TABLE UserSkill (
	UserSkillId INT NOT NULL IDENTITY (1, 1),
	UserId INT NOT NULL,
	SkillId INT NOT NULL,
	UserSkillScore INT NOT NULL,
	CONSTRAINT pk_UserSkill PRIMARY KEY (UserSkillId),
	CONSTRAINT fk_UserSkill_User FOREIGN KEY (UserId)
		REFERENCES [User] (UserId),
	CONSTRAINT fk_UserSkill_Skill FOREIGN KEY (SkillId)
		REFERENCES Skill (SkillId)
)
GO