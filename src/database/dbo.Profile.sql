
IF EXISTS (SELECT * FROM information_schema.tables WHERE table_schema = 'dbo' AND table_name = 'profile' )
BEGIN
    DROP TABLE dbo.profile
END

CREATE TABLE Profile
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	Username NVARCHAR(100) UNIQUE NOT NULL,
	Password NVARCHAR(50) NOT NULL,
	PasswordSalt NVARCHAR(4) NOT NULL
)
