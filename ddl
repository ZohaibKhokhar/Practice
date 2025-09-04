--DDL
--user Zohaib_CareLite


create table UserRole(
RoleID int primary key identity(1,1),
RoleName varchar(50) not null unique,
);
create table [User](
UserID int primary key identity(1,1),
RoleID int not null foreign key references UserRole(RoleID),
UserName varchar(200) not null unique,
UserEmail varchar(300) not null,
UserPhoneNumber varchar(13) not null,
UserAddress varchar(200) not null,
UserPassword varchar(200) not null
);





