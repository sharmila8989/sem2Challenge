/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
IF '$(LoadTestData)' = 'true'

BEGIN
-- ENSURE THERE IS NOT DATA IN THE TABLEES BEFORE DEPLOYING TEST DATA
DELETE FROM Student;
DELETE FROM WirelessModules;


-- insert test data
INSERT INTO WirelessModules(MacAddress, IssueDate) VALUES
('4B-9C-6D-09-C0-C3','2017-01-11'),
('76-37-47-F0-2D-98','2018-05-14'),
('51-7E-BA-E5-15-F6','2018-08-09'),
('66-CB-11-81-0F-70','2017-12-05'),
('E4-24-1A-2F-FE-78','2018-07-16');


INSERT INTO Student(Id,studentFname,studentLastname,MacAddress) Values
('s1404326303','Kandace','Wyett','4B-9C-6D-09-C0-C3'),
('s0852437381','Kellby','Grayshan','76-37-47-F0-2D-98'),
('s5332613405','Lula','Darnborough','51-7E-BA-E5-15-F6'),
('s0093188549','Nerti','Steely','66-CB-11-81-0F-70'),
('s3357087510','Christabel','Stairs','E4-24-1A-2F-FE-78');



End;
