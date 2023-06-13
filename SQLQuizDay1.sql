use db_penerbit

create database db_penerbit

create table tblPengarang(
Id int primary key identity (1,1) not null,
Kd_Pengarang varchar(7) not null,
Nama varchar (30) not null,
Alamat varchar (80) not null,
Kota varchar (15) not null,
Kelamin varchar(1) not null
)

insert into tblPengarang
(Kd_Pengarang,Nama,Alamat,Kota,Kelamin)
values
('P0001','Ashadi','Jl.Beo 25','Yogya','P'),
('P0002','Rian','Jl.Solo 123','Yogya','P'),
('P0003','Suwadi','Jl.Semangka 13','Bandung','P'),
('P0004','Siti','Jl.Durian 15','Solo','W'),
('P0005','Amir','Gajah 33','Kudus','P'),
('P0006','Suparman','Jl.Harimau 25','Jakarta','P'),
('P0007','Jaja','Jl.Singa 7','Bandung','P'),
('P0008','Saman','Jl.Naga 12','Yogya','P'),
('P0009','Anwar','Jl.Tidar 6A','Magelang','P'),
('P0010','Fatmawati','Jl.REnjana 4','Bogor','W')

select * from tblPengarang

create table tblGaji(
Id int primary key identity (1,1)not null,
Kd_Pengarang varchar (7)not null,
Nama varchar (30) not null,
Gaji decimal (18,4) not null
)

insert into tblGaji
(Kd_Pengarang,Nama,Gaji)
values
('P0002','Rian','600000'),
('P0005','Amir','700000'),
('P0004','Siti','500000'),
('P0003','Suwadi','1000000'),
('P0010','Fatmawati','600000'),
('P0008','Saman','750000')

-- No 1
select count(id)  [Total Pengarang] from tblPengarang

--No 2
select Kelamin, count(Kelamin) as Total
from tblPengarang group by Kelamin

--No 3
select Kota, count(Kota) as Total
from tblPengarang group by Kota 
order by Total desc

--No 4
select Kota, count(Kota) as Total
from tblPengarang group by Kota 
having count(Kota)>1
order by Total desc

--No 5
select max(kd_pengarang) as Terbesar, min(kd_pengarang) as Terkecil
from tblPengarang

--No6
select max(Gaji) as Terbesar, min(Gaji) as Terkecil
from tblGaji

--No7
select gaji
from tblGaji where gaji>600000

--no8
select sum(Gaji) [Total Gaji]
from tblGaji

--no9
select tblPengarang.Kota, sum(Gaji) [Total Gaji]
from tblGaji 
join tblPengarang on tblGaji.Kd_Pengarang = tblPengarang.Kd_Pengarang 
group by tblPengarang.Kota

--no10
select * from tblPengarang where Kd_Pengarang between 'P0003' and 'P0006'

--no11
select * from tblPengarang where Kota = 'yogya' or kota = 'solo' or Kota = 'magelang'

--no12
select * from tblPengarang where not kota = 'yogya'

--no13A
select * from tblPengarang
where nama like 'A%'

--13B
select * from tblPengarang
where nama like '%i'

--13C
select * from tblPengarang
where nama like '__a%'

--13D
select * from tblPengarang
where not nama like '%n'

--14
select * from tblPengarang
join tblGaji  on tblGaji.Kd_Pengarang = tblPengarang.Kd_Pengarang 

--15
select kota
from tblPengarang
join tblGaji on tblGaji.Kd_Pengarang = tblPengarang.Kd_Pengarang 
where Gaji < 1000000
group by Kota

--16
alter table tblPengarang alter column kelamin varchar (10) not null

--17
alter table tblPengarang add Gelar Varchar(12) 

--18
update tblPengarang set Alamat = 'Jl. Cendrawasih 65', Kota = 'Pekanbaru' where Nama = 'Rian'

--19
create view vw_Pengarang as 
select tblPengarang.Kd_Pengarang, tblPengarang.Nama, Kota, Gaji 
from tblPengarang join
tblGaji on tblGaji.Kd_Pengarang = tblPengarang.Kd_Pengarang 


