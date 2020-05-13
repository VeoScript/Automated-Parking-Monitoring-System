create database parking

use parking

create table useraccount(
	id int identity primary key not null,
	name varchar(255) unique not null,
	position varchar(255) not null,
	username varchar(255) not null,
	password varchar(255) not null
)

insert into useraccount(name, position, username, password) values('Jerome Villaruel', 'ADMIN', 'veo', '123')

create table vehicle(
	id int identity primary key not null,
	plateno varchar(255) unique not null,
	operator varchar(255) unique not null,
	vehiclename varchar(255) not null,
	vehicletype varchar(255) not null
)

create table monitoring(
	autoID int identity primary key not null,
	id int not null,
	plateno varchar(255) not null,
	operator varchar(255) not null,
	vehiclename varchar(255) not null,
	vehicletype varchar(255) not null,
	timein varchar(255) not null,
	timeout varchar(255),
	dateparkedin varchar(255),
	dateparkedout varchar(255),
	status varchar(255) not null
)

create table parkingslot(
	id int identity primary key not null,
	slot int not null,
	remaining int,
)

select * from monitoring

delete from monitoring