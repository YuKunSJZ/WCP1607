-- SQL_NUMBER 0001
create database WrokFlow;
use WrokFlow;
create table Dashboard
(
 DashboardID integer unsigned not null auto_increment
,DashboardName varchar(50) not null
,DashboardLink varchar(512) default null
,DashboardArea varchar(20) 
,CreatedTime datetime
,UpdatedTime datetime
,CreatedBy varchar(20)
,UpdatedBy varchar(20)
,primary key (DashboardID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
;

insert into Dashboard values (1,'¹¤×÷'£¬'http://localhost/home.aspx','LeftSide',now(),now(),'YuKun','YuKun');

create table Users
(
UserID integer not null auto_increment
,Username varchar(50)
,`Password` varchar(124)
,PasswordExpire datetime
,RoleGroup integer
,CreatedBy varchar(50)
,UpdatedBy varchar(50)
,TimeCreated datetime
,TimeUpdated datetime
,primary key(UserID)
)  ENGINE=InnoDB DEFAULT CHARSET=utf8;

insert into Users values (1,'yukun01','yukun01','2017-01-01',1,'yukun01','yukun01',now(),now())
;

