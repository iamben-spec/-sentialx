CREATE TABLE Users (
    UserID       INT IDENTITY(1,1) PRIMARY KEY,
    Username     VARCHAR(50)  NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    Role         VARCHAR(20)  NOT NULL DEFAULT 'User',
    CreatedAt    DATETIME     NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Events (
    EventID     INT IDENTITY(1,1) PRIMARY KEY,
    UserID      INT          NOT NULL,
    EventType   VARCHAR(30)  NOT NULL,
    Description VARCHAR(255) NOT NULL,
    Timestamp   DATETIME     NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_Events_Users FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

CREATE TABLE Alerts (
    AlertID    INT IDENTITY(1,1) PRIMARY KEY,
    EventID    INT          NOT NULL,
    AlertType  VARCHAR(50)  NOT NULL,
    Severity   VARCHAR(10)  NOT NULL,
    IsResolved BIT          NOT NULL DEFAULT 0,
    Timestamp  DATETIME     NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_Alerts_Events FOREIGN KEY (EventID) REFERENCES Events(EventID)
);

INSERT INTO Users (Username, PasswordHash, Role)
VALUES (
    'admin',
    '0A041B9462CAA4A31BAC3567E0B6E6FD9100787DB2AB433D96F6D178CABFCE90',
    'Admin'
);