CREATE PROCEDURE AddProfile
@Username	nvarchar(50)
AS
	BEGIN 
		insert into tblProfile(Username)
		values (@Username);
	
	END