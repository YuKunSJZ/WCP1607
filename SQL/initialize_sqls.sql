-- SQL_NUMBER 0001
create database OABase;
use OABase;

CREATE TABLE `Users` (
  `UserID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `UserName` varchar(12) NOT NULL,
  `RoleID` int(11) NOT NULL DEFAULT '1',
  `LocationID` int(11) NOT NULL DEFAULT '0',
  `Language` varchar(2) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Phone` varchar(50) DEFAULT NULL,
  `Mobile` varchar(50) DEFAULT NULL,
  `Fax` varchar(50) DEFAULT NULL,
  `Department` varchar(50) DEFAULT NULL,
  `JobTitle` varchar(50) DEFAULT NULL,
  `EmployeeNum` int(11) DEFAULT NULL,
  `StartDate` date DEFAULT NULL,
  `City` varchar(30) DEFAULT NULL,
  `Password` varchar(12) NOT NULL DEFAULT 'ie*e93k90cke',
  `PasswordExpireDate` datetime DEFAULT NULL,
  `LogonFailureCount` int(11) NOT NULL DEFAULT '0',
  `Profile` varchar(4000) DEFAULT NULL,
  `TimeUpdated` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `UpdatedBy` varchar(12) DEFAULT NULL,
  `TimeCreated` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `CreatedBy` varchar(12) DEFAULT NULL,
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `IX_Users` (`UserName`),
) ENGINE=InnoDB DEFAULT CHARSET=utf8
;

INSERT INTO Users (
`UserID`             
,`Name`               
,`UserName`           
,`RoleID`             
,`LocationID`         
,`Language`           
,`Email`              
,`Phone`              
,`Mobile`             
,`Fax`                
,`Department`         
,`JobTitle`           
,`EmployeeNum`        
,`StartDate`          
,`City`               
,`Password`           
,`PasswordExpireDate` 
,`LogonFailureCount`  
,`Profile`            
,`TimeUpdated`        
,`UpdatedBy`          
,`TimeCreated`        
,`CreatedBy`          
)
VALUES
(
,1      -- `UserID`               
,'赵玉坤'      -- `Name`                
,'yukun'      -- `UserName`            
,1      -- `RoleID`              
,1     -- `LocationID`          
,'cn'     -- `Language`            
,'yukun@encom8.com'      -- `Email`               
,'13739795066'      -- `Phone`               
,'13739795066'      -- `Mobile`              
,'03228989977'      -- `Fax`                 
,'IT Maintance'      -- `Department`          
,'开发DBA'      -- `JobTitle`            
,'T201605050001'      -- `EmployeeNum`         
,now()      -- `StartDate`           
,'石家庄'      -- `City`                
,'yukun01'      -- `Password`            
,'2017-01-01'      -- `PasswordExpireDate`  
,0      -- `LogonFailureCount`   
,'I like Computer Scince'      -- `Profile`             
,now()      -- `TimeUpdated`         
,'yukun'      -- `UpdatedBy`           
,now()      -- `TimeCreated`         
,'yukun'      -- `CreatedBy`           
);
