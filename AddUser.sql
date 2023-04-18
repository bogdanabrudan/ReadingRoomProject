
CREATE PROCEDURE AddUser
@Username	nvarchar(50),
@Password	nvarchar(50),
@Email	nvarchar(50)

AS
	BEGIN 
		insert into tblUsers(Username, Password, Email)
		values (@Username, @Password, @Email);
	
	END