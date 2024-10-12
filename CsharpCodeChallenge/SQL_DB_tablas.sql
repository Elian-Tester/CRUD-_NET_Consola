create database CsharpCodeChallengeDB
--user: admin280924
--pass: 280924dbaws
--puerto: 1433

use CsharpCodeChallengeDB

create table Users(
id int primary key identity,
name varchar(200) not null
);

create table Programs_TV(
id int primary key identity,
name varchar(200) not null
);


create table Favorite_TV(
id int primary key not null identity,
idUser int not null,
idProgram_TV int not null,
isFavorite int,
foreign key(idUser) references Users(id),
foreign key (idProgram_TV) references Programs_TV(id)
)



insert into Users values('Mordecai');

insert into Programs_TV values
('The regular show'),
('Phineas y ferb'),
('Los simpson'),
('Hora de aventura'),
('Bob Esponja'),
('KND: los chicos del barrio'),
('Futurama');

select * from Users
select * from Programs_TV
select * from Favorite_TV

