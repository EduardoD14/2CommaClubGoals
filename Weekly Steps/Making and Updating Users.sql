--USE [ICSFinances]
--GO

--INSERT INTO [dbo].[Users]
--           ([HashedPassword]
--           ,[UserName]
--           ,[FirstName]
--           ,[LastName]
--           ,[EmailAddress]
--           ,[UserLevel]
--           ,[AccountStatus]
--           ,[EntryDate]
--           ,[UpdateDate])
--     VALUES
--	 ('testpassword1','testuser1','testuser1','testuser1','testuser@gmail.com',1,1,CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)          
--GO
SELECT *
FROM [dbo].[Users]


--UPDATE [dbo].[Users]
--   SET [HashedPassword] = 'NewPassword'
--      ,[UpdateDate] = CURRENT_TIMESTAMP
-- WHERE UserId = 1;
--GO

