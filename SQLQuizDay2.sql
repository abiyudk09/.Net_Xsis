
create database db_entertainer
use db_entertainer

create table artis(
kd_artis varchar(100) primary key,
nm_artis varchar(100),
jk varchar (100),
bayaran bigint,
award bigint,
negara varchar (100)
)


insert into artis(
kd_artis,nm_artis,jk,bayaran,award,negara
)
values(
'A001','Robert Downey JR','Pria',3000000000,2,'AS'),
('A002','Angelina Jolie','Wanita',700000000,1,'AS'),
('A003','Jackie Chan','Pria',200000000,7,'HK'),
('A004','Joe Taslim','Pria',350000000,1,'ID'),
('A005','Chelsea Islan','Wanita',300000000,0,'ID')

create table film(
kd_film varchar(10) primary key,
nm_film varchar(55),
genre varchar (55),
artis varchar (55),
produser varchar(55),
pendapatan bigint,
nominasi int
)

insert into film(
kd_film,nm_film,genre,artis,produser,pendapatan,nominasi
)
values(
'F001','Iron Man','G001','A001','PD01',2000000000,3),
('F002','Iron Man 2','G001','A001','PD01',1800000000,2),
('F003','Iron Man 3','G001','A001','PD01',1200000000,0),
('F004','Avenger Civil War','G001','A001','PD01',2000000000,1),
('F005','Spiderman Home Coming','G001','A001','PD01',1300000000,0),
('F006','The Raid','G001','A004','PD03',800000000,5),
('F007','Fast & Furious','G001','A004','PD05',830000000,2),
('F008','Habibie dan Ainun','G004','A005','PD03',670000000,4),
('F009','Police Story','G001','A003','PD02',700000000,3),
('F010','Police Story 2','G001','A003','PD02',710000000,1),
('F011','Police Story 3','G001','A003','PD02',615000000,0),
('F012','Rush Hour','G003','A003','PD05',695000000,2),
('F013','Kungfu Panda','G003','A003','PD05',923000000,5)

create table produser(
kd_produser varchar(10) primary key,
nm_produser varchar(55),
international varchar(55)
)
insert into produser(
kd_produser, nm_produser, international)
values
('PD01', 'Marvel', 'Ya'),
('PD02', 'Hongkong Cinema', 'Ya'),
('PD03', 'Rapi Film', 'Tidak'),
('PD04', 'Parkit', 'Tidak'),
('PD05', 'Paramount Picture', 'Ya')

create table negara(
kd_negara varchar(100) primary key,
nm_negara varchar(100)
)

insert into negara(
kd_negara, nm_negara
)
values
('AS', 'Amerika Serikat'),
('HK', 'Hongkong'),
('ID', 'Indonesia'),
('IN', 'India')

create table genre(
kd_genre varchar(50) primary key,
nm_genre varchar(50)
)

insert into genre(
kd_genre, nm_genre
)
values
('G001', 'Action'),
('G002', 'Horror'),
('G003', 'Comedy'),
('G004', 'Drama'),
('G005', 'Thriller'),
('G006', 'Fiction')

select * from artis
select * from film
select * from produser
select * from negara
select * from genre

--1
select p.nm_produser, sum(f.pendapatan)
from produser as p join film as f on p.kd_produser = f.produser
where p.nm_produser ='Marvel'
group by nm_produser

