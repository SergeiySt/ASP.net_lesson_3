create database db_news;
go

use db_news;
go


create table Users
(
	id_users int not null identity(1,1) primary key,
	SName nvarchar(50) check (SName <> '') not null,
	SEmail nvarchar(50) check (SEmail <> '') not null,
	SPhone int not null,
	SDate date not null
);

insert into Users values
('Жора', '1234@gmail.com', 0995545687, '2023-09-05'),
('Світлана', '3454@gmail.com', 0899999987, '2023-10-12');
go