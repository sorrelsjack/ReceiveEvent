/*Create DB named EventLocationData*/

CREATE TABLE [dbo].[Events] (
    [Id]        INT IDENTITY  NOT NULL,
    [Location]  NVARCHAR (50) NOT NULL,
    [EventType] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

INSERT INTO Events (Location, EventType) VALUES ('circus', 'elephant stampede');
INSERT INTO Events (Location, EventType) VALUES ('forest', 'fire');
INSERT INTO Events (Location, EventType) VALUES ('jims house', 'front door');

