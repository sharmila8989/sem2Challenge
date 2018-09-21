CREATE TABLE [dbo].[Student]
(
	[Id] NVARCHAR(50) NOT NULL, 
    [studentFname] NVARCHAR(50) NOT NULL, 
    [studentLastname] NVARCHAR(50) NOT NULL,
	[MacAddress] NVARCHAR(50) NOT NULL, 
	CONSTRAINT PK_STUDENT PRIMARY KEY(Id, MacAddress),
	CONSTRAINT FK_STUDENT_MODULE FOREIGN KEY (MacAddress) REFERENCES WirelessModules(MacAddress),
	
	
)
