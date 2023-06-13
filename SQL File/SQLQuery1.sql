
--SQL DAY 01--

--DDL 
--CREATE DB
CREATE DATABASE db_kampus;

create table mahasiswa(
id bigint primary key identity(1,1),
name varchar(50) not null,
address varchar(50) not null,
email varchar(255) null
)

--create view
create view vw_mahasiswa as select * from mahasiswa

--ALTER
--add column
alter table mahasiswa add phone_number varchar(100) not null
--drop table
alter table mahasiswa drop column phone_number
--alter table
alter table mahasiswa alter column email varchar(100) not null

--Drop 
--Drop Database  : drop database db_mahasiswa [nama databasenya]
--Drop Table : drop table mahasiswa [nama tablenya]
--Drop View : drop view vw_mahasiswa [nama viewnya]

--DML (Data Manipulation Language)
--Insert
insert into mahasiswa 
(
name,
address,
email
)
values
(
'Achmad',
'jln Manggis',
'ach@gmail.com'
),
(
'Barmawi',
'jl tanjung',
'ach.br@gmail.com'
),
(
'Armand',
'jln morawa ',
'armd@gmail.com'
),
(
'Fika',
'jln Palembang',
'fik@gmail.com'
)

  --Select
  select id,name, address, email from mahasiswa

  --Update
  update mahasiswa set name = 'Yusuf' where id = 1

  --delete
  delete from mahasiswa where id=2

  --Join



  --TAmbahin table--
  create table biodata(
  id bigint primary key identity(1,1),
  mahasiswa_id bigint,
  tgl_lahir date,
  gender varchar(10)
  )

  insert into biodata
  (
mahasiswa_id,
tgl_lahir,
gender
)
values
(3,'2000-09-02','pria')--, (2,'2000-11-02','pria') --nambahin lebih dari 1 data

select * from biodata

--Join Join with and or n not
select  mhs.id as id_mahasiswa ,mhs.name as nama_mahasiswa, mhs.address as alamat, mhs.email, bio.tgl_lahir as tanggal_lahir,bio.gender gender
from mahasiswa as mhs
join biodata as bio on mhs.id = bio.mahasiswa_id
where not mhs.id = 2 and bio.tgl_lahir = '2000-10-02' or bio.tgl_lahir = '2000-11-02'

--order by (asc / desc)
select * from biodata order by tgl_lahir desc

--Select Top
select top 1 mahasiswa_id from biodata order by mahasiswa_id desc

--Between 
--select * from biodata where mahasiswa_id between 2 and 3 
select * from biodata where tgl_lahir between '2000-01-01' and '2000-10-01' 

--Like
select * from mahasiswa where 
--name like 'a%' 
--name like '%a'
--name like '%r%' -- bebas yang penting mengandung kata r d dalamnnya
--name like '_u%' --ada 1 karakter di depan u belakangnya bebas
--name like 'f_____%' -- ada 5 karakter setelah f, klo kurang gabisa
name like 'a%d' -- awalan akhiran ada unsurnya a dan b tengahnya bebas

--group by
select name from mahasiswa group by name --menghilangkan duplicate

--having
select name, sum(id) as jumlah from mahasiswa group by name having sum(id) > 4 order by jumlah desc