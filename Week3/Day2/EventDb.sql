CREATE DATABASE Event
USE Event;

CREATE TABLE UserInfo (
    EmailId VARCHAR(100) PRIMARY KEY,
    UserName VARCHAR(50) NOT NULL CHECK (LEN(UserName) BETWEEN 1 AND 50),
    Role VARCHAR(20) NOT NULL CHECK (Role IN ('Admin','Participant')),
    Password VARCHAR(20) NOT NULL CHECK (LEN(Password) BETWEEN 6 AND 20)
);

CREATE TABLE EventDetails (
    EventId INT PRIMARY KEY,
    EventName VARCHAR(50) NOT NULL CHECK (LEN(EventName) BETWEEN 1 AND 50),
    EventCategory VARCHAR(50) NOT NULL CHECK (LEN(EventCategory) BETWEEN 1 AND 50),
    EventDate DATETIME NOT NULL,
    Description VARCHAR(255) NULL,
    Status VARCHAR(20) NOT NULL CHECK (Status IN ('Active','In-Active'))
);

CREATE TABLE SpeakersDetails (
    SpeakerId INT PRIMARY KEY,
    SpeakerName VARCHAR(50) NOT NULL CHECK (LEN(SpeakerName) BETWEEN 1 AND 50)
);

CREATE TABLE SessionInfo (
    SessionId INT PRIMARY KEY,
    EventId INT NOT NULL,
    SessionTitle VARCHAR(50) NOT NULL CHECK (LEN(SessionTitle) BETWEEN 1 AND 50),
    SpeakerId INT NOT NULL,
    Description VARCHAR(255) NULL,
    SessionStart DATETIME NOT NULL,
    SessionEnd DATETIME NOT NULL,
    SessionUrl VARCHAR(255),
    CONSTRAINT FK_Session_Event FOREIGN KEY (EventId) REFERENCES EventDetails(EventId),
    CONSTRAINT FK_Session_Speaker FOREIGN KEY (SpeakerId) REFERENCES SpeakersDetails(SpeakerId)
);

CREATE TABLE ParticipantEventDetails (
    Id INT PRIMARY KEY,
    ParticipantEmailId VARCHAR(100) NOT NULL,
    EventId INT NOT NULL,
    SessionId INT NOT NULL,
    IsAttended BIT NOT NULL CHECK (IsAttended IN (0,1)),
    CONSTRAINT FK_Participant_User FOREIGN KEY (ParticipantEmailId) REFERENCES UserInfo(EmailId),
    CONSTRAINT FK_Participant_Event FOREIGN KEY (EventId) REFERENCES EventDetails(EventId),
    CONSTRAINT FK_Participant_Session FOREIGN KEY (SessionId) REFERENCES SessionInfo(SessionId)
);


INSERT INTO UserInfo VALUES
('admin@gmail.com','Admin','Admin','admin456'),
('ram@gmail.com','Ram','Participant','ram789'),
('neha@gmail.com','neha','Participant','neha123'),
('vikram@gmail.com','Vikram','Participant','vikram456');


INSERT INTO EventDetails VALUES
(101,'Web Development Bootcamp','Technology','2026-07-12','Full stack web development training','Active'),
(102,'Data Science Workshop','Data Science','2026-08-05','Hands-on machine learning workshop','Active');


INSERT INTO SpeakersDetails VALUES
(201,'Mr. Arjun'),
(202,'Dr. Kavita');


INSERT INTO SessionInfo VALUES
(301,101,'Introduction to HTML',201,'Basics of HTML and webpage structure',
'2026-07-12 09:30','2026-07-12 10:30','www.websession1.com'),

(302,102,'Machine Learning Basics',202,'Introduction to ML algorithms',
'2026-08-05 10:00','2026-08-05 11:30','www.datasession1.com');

INSERT INTO ParticipantEventDetails VALUES
(401,'ram@gmail.com',101,301,1),
(402,'neha@gmail.com',102,302,0),
(403,'vikram@gmail.com',102,302,1);

SELECT * FROM UserInfo;
SELECT * FROM EventDetails;
SELECT * FROM SpeakersDetails;
SELECT * FROM SessionInfo;
SELECT * FROM ParticipantEventDetails;


SELECT s.SessionTitle, sp.SpeakerName, e.EventName, s.SessionStart, s.SessionEnd
FROM SessionInfo s
JOIN SpeakersDetails sp ON s.SpeakerId = sp.SpeakerId
JOIN EventDetails e ON s.EventId = e.EventId;

SELECT p.ParticipantEmailId, u.UserName, e.EventName, s.SessionTitle, p.IsAttended
FROM ParticipantEventDetails p
JOIN UserInfo u ON p.ParticipantEmailId = u.EmailId
JOIN EventDetails e ON p.EventId = e.EventId
JOIN SessionInfo s ON p.SessionId = s.SessionId