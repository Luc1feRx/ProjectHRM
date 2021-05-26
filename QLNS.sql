use QuanLyNhanSu

GO

CREATE TABLE tbUsers(
	Username nvarchar(50) NOT NULL,
	Pass NVARCHAR(50),
	Quyen NCHAR(10),
	Ten NVARCHAR(50),
)

CREATE TABLE tbQuyen(
	MaQuyen INT NOT NULL,
	TenQuyen NVARCHAR(50) NOT NULL
)


INSERT INTO tbUsers
(
    Username,
    Pass,
    Quyen,
    Ten
)
VALUES
(	'admin',
	'asd123',
	'Admin',
	N'Tú'
)

SELECT * FROM tbUsers
SELECT * FROM tbUsers WHERE Username = 'admin' AND Pass = 'asd123'
DELETE FROM dbo.tbUsers WHERE Username = 'admin'

SELECT * FROM tbUsers WHERE Username = 'admin' AND Pass = 'asd123'

SELECT * FROM tbUsers WHERE Username = 'user1'

UPDATE tbUsers SET Pass = 'asd123' WHERE(Username = 'user1' AND Pass = '123')

SELECT * FROM tbQuyen