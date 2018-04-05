

IF EXISTS (SELECT * FROM information_schema.tables WHERE table_schema = 'dbo' AND table_name = 'event' )
BEGIN
    DROP TABLE dbo.event
END

--CREATE TABLE dbo.Event
--(
--	Id INT NOT NULL PRIMARY KEY IDENTITY,
--	EventfulId NVARCHAR(18) NOT NULL,
--	ProfileId INT NOT NULL REFERENCES dbo.profile(Id),
--	IsRecommended BIT
--)

--GO

--CREATE UNIQUE NONCLUSTERED INDEX IX_Event_EventfulId ON Event (EventfulId, ProfileId)
