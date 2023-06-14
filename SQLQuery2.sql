--SQL Day 2
use db_kampus

--Min Max Count 
select min(id) from mahasiswa
select max(id) from mahasiswa
select count(id) [Kolom Mahasiswa] from mahasiswa  
select top 1 id from mahasiswa order by id asc --untuk mencari nilia terbesar 
select top 1 id from mahasiswa order by id desc	--untuk mencari nilai teerkecil\\

--buat kolom baru
alter table mahasiswa add nilai int
update mahasiswa set nilai = 80 where id=1
update mahasiswa set nilai = 80 where id=2
update mahasiswa set nilai = 70 where id=3
update mahasiswa set nilai = 100 where id=4
update mahasiswa set nilai = 40 where id=5
update mahasiswa set nilai = 50 where id=6

---avg sum
select avg(nilai) from mahasiswa

--inner join / join biasa
select * from mahasiswa
inner join biodata on mahasiswa.id = biodata.id

--left n right join
select * from mahasiswa
left join biodata on mahasiswa.id = biodata.id -- Menampilkan semua data dari table sebelah kiri walaupun dia null

select * from mahasiswa
right join biodata on mahasiswa.id = biodata.id --menampilkan semua data dari table sebelah kanan walaupun dia null

select * from mahasiswa
left join biodata on mahasiswa.id = biodata.id --menampilkan hanya data sebelah kiri yang tidak memiliki hubungan ke data table sebelah kanan
where biodata.id is null

select * from mahasiswa
right join biodata on mahasiswa.id = biodata.id --menampilkan hanya data sebelah kanan yang tidak memiliki hubungan ke data table sebelah kiri
where mahasiswa.id is null

select * from mahasiswa
full outer join biodata on mahasiswa.id = biodata.id

--distinct
select distinct name /*nama kolomnya yang memiliki data yg sama*/ from mahasiswa 

--group by
select name from mahasiswa group by name

select substring('SQL Tutorial', 1, 3) [INi CONTIoh]

select CHARINDEX('t', 'Customer')

select datalength('w3schools.com')

--case when
select name, address, 
case when nilai >= 80 then 'A' 
when nilai >= 60 then 'B'
else 'C'
end
[hasil nilai]
from mahasiswa order by nilai desc

--CONCAT
select concat(name, address) from mahasiswa
select 'sql' + 'is' + 'fun'

SELECT * FROM mahasiswa

create table Jualan(
id int primary key identity (1,1),
nama varchar (122),
harga int
)

insert into Jualan(
nama, harga)
values 
('indomie', 1500), ('Close-Up', 3500), ('Pepsodent', 3000), ('Brush Formula', 2500), ('Roti Manis', 1000), ('Gula', 3500), ('Sarden', 4500), ('Rokok Sempurna', 11000), ('Rokok 234', 11000)

select nama, CONCAT('Rp.', harga) as Harga, concat('Rp.',harga*100) as Total
from Jualan

--get date 
select getdate()
select day('2023-06-14')
select month('2023-06-14')
select year('2023-06-14')  -- atau select year(getdate())

--dateadd
select DATEADD(year, 1, getdate())	--nambahin tahun
select DATEADD(month, 3, getdate())	--nambahin bulan
select DATEADD(day, 5, getdate())	--nambahin hari

--datediff
select DATEDIFF(month, getdate(), '2024-01-13')
select DATEDIFF(YEAR, '2023-06-14', '2024-01-13')
select DATEDIFF(day, '2023-06-14', '2024-01-13')
select DATEDIFF(HOUR, '2023-06-14', '2024-01-13')

--subquery
select * from mahasiswa mhs
left join biodata bio on mhs.id = bio.mahasiswa_id
where mhs.nilai = (select max(nilai) from mahasiswa)

create table mahasiswanew(
id bigint primary key identity(1,1),
name varchar(50) not null,
address varchar(50) not null,
email varchar(255) null
nilai int
)


insert into mahasiswanew (name,address,email,nilai)
select name,address,email,nilai from mahasiswa

--create view
	create view vw_mahasiswa
	as
	select name from mahasiswa where name = 'Achmad'

--alter view 
alter view vw_mahasiswa
as
select name,address,nilai from mahasiswa where not name = 'achmad'

--create index
create index idx_nameEmail on mahasiswa (name,email)

create unique index idx_id on mahasiswa(id) --unique tidak bisa jika data double

--primary key
create table coba(id int not null, nama varchar(50) not null)
alter table coba add constraint pk_idnama primary key(id,nama) --primary key bisa lebih dr 1 asalkan pembuatannnya bareng gabisa di tambahin
alter table coba drop constraint pk_idnama --ngapus primary key

--unique key
alter table biodata add constraint unique_tgllahir unique(tgl_lahir)
alter table biodata drop constraint unique_tgllahir


--foreign key
alter table biodata
add constraint fk_mahasiswa_id 
foreign key(mahasiswa_id) references mahasiswa(id) --kalo ada idnya yg gaada dia gabisa
