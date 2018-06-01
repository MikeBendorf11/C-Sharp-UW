/*************************************
Dev: Mijael
Date: 5/21/2018

**************************************/
GO
CREATE --DROP
PROCEDURE dbo.pInsStudents ( 
	@StudentName [nvarchar](100),
	@StudentEmail [nvarchar](100),
	@StudentLogin [nvarchar](50),
	@StudentPassword [nvarchar](50)
)
AS
BEGIN 
  BEGIN TRY
    BEGIN TRANSACTION;
       INSERT INTO [DB_122058_test2].[dbo].[Students]
               (
			    [StudentName],
				[StudentEmail],
				[StudentLogin],
				[StudentPassword]
               )
         VALUES
              (
         	    @StudentName ,
				@StudentEmail,
				@StudentLogin,
				@StudentPassword
              );
    ------------------- Transaction Statement;
    COMMIT TRANSACTION;
    RETURN +100
  END TRY   
  BEGIN CATCH
    ROLLBACK TRANSACTION;
    DECLARE @Message nVarchar(1000);
    SELECT @Message = ERROR_MESSAGE();
    RAISERROR(@Message, 15, 1);     
    RETURN -100     
  END CATCH
END; -- Body of stored procedure;
GO

DECLARE	@return_value int;
EXEC	@return_value = [dbo].[pInsStudents]
		@StudentName = 'w' ,
		@StudentEmail = 'w',
		@StudentLogin = 'w',
		@StudentPassword = 'w';
SELECT	'Return Value' = @return_value;