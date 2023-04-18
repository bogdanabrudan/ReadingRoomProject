CREATE PROCEDURE UpdateProfile
@Username	nvarchar(50),
@Name	nvarchar(50),
@Phone	nvarchar(50),
@Univ	nvarchar(50)

AS
	BEGIN 
		UPDATE tblProfile SET Username = @Username, Name = @Name, Phone = @Phone, Univ = @Univ
		WHERE Username = @Username	
	
	END