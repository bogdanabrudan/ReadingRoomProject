CREATE PROCEDURE UpdateUser
@Id int,
@Username	nvarchar(50),
@Password	nvarchar(50),
@Email	nvarchar(50)

AS
	BEGIN 
		UPDATE tblUsers SET Username = @Username, Password = @Password, Email = @Email
		WHERE Id = @Id	
	
	END
