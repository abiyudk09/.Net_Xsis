--Quiz Day 4--

create database DB_Hr

use DB_Hr

--create table tb_karyawan(
--id bigint primary key identity(1,1) not null, 
--nip varchar(50) not null,
--nama_depan varchar(50) not null,
--nama_belakang varchar(50) not null,
--jenis_kelamin varchar(50) not null,
--agama varchar(50) not null,
--tempat_lahir varchar(50) not null,
--tgl_lahir date,
--alamat varchar(100) not null,
--pendidikan_terakhir varchar(50) not null,
--tgl_masuk date
--)

--insert into tb_karyawan
--(
--nip, nama_depan,nama_belakang, jenis_kelamin, agama, tempat_lahir, tgl_lahir, alamat, pendidikan_terakhir, tgl_masuk
--)
--values
--('001', 'Hamidi', 'Samsudin', 'Pria', 'Islam', 'Sukabumi', '1977-04-21', 'Jl Sudirman No. 12', 'S1 Teknik Mesin', '2015-12-07'),
--('003', 'Paul', 'Christian', 'Pria', 'Kristen', 'Ambon', '1980-05-27', 'Jl Veteran No. 4', 'S1 Pendidikan Geografi', '2014-01-12'),
--('002', 'Ghandi', 'Wamida', 'Wanita', 'Islam', 'Palu', '1992-01-12', 'Jl Rambutan No. 22', 'SMA Negeri 02 Palu', '2014-12-01')

--drop table tb_karyawan

--create table tb_divisi
--(
--id bigint primary key identity (1,1) not null,
--kd_divisi varchar(50) not null,
--nama_divisi varchar(50) not null
--)

--insert into tb_divisi
--(kd_divisi, nama_divisi)
--values
--('GD', 'Gudang'), ('HRD', 'HRD'), ('KU', 'Keuangan'), ('UM', 'Umum')


--create table tb_jabatan
--(
--id bigint primary key identity(1,1),
--kd_jabatan varchar(50) not null,
--nama_jabatan varchar(50) not null,
--gaji_pokok numeric,
--tunjangan_jabatan numeric
--)

--insert into tb_jabatan
--(
--kd_jabatan, nama_jabatan, gaji_pokok, tunjangan_jabatan
--)
--values
--('MGT', 'Manager', 5500000, 1500000),
--('OB', 'Office Boy', 1900000, 200000),
--('ST', 'Staff', 3000000, 750000),
--('WMGR', 'Wakil Manager', 4000000, 1200000)

--create table tb_pekerjaan
--(
--id bigint primary key identity(1,1) not null,
--nip varchar(50) not null,
--kode_jabatan varchar(50) not null,
--kode_divisi varchar(50) not null,
--tunjangan_kinerja varchar(50),
--kota_penempatan varchar(50)
--)

--insert into tb_pekerjaan
--(nip, kode_jabatan, kode_divisi, tunjangan_kinerja, kota_penempatan)
--values
--('001', 'ST', 'KU', 750000, 'Cianjur'),
--('002', 'OB', 'UM', 350000, 'Sukabumi'),
--('003', 'MGR', 'HRD', 1500000, 'Sukabumi')

--select * from tb_karyawan
--select * from tb_divisi
--select * from tb_jabatan
--select * from tb_pekerjaan



--1
select (k.nama_depan + k.nama_belakang) as Full_Name, j.nama_jabatan, (j.gaji_pokok + j.tunjangan_jabatan) as gaji_tunjangan
from tb_karyawan k join tb_pekerjaan p on k.nip = p.nip 
join tb_jabatan j on p.kode_jabatan = j.kd_jabatan
where (j.gaji_pokok + p.tunjangan_kinerja) < 5000000

--2
select (k.nama_depan + k.nama_belakang) as Full_Name, j.nama_jabatan,div.nama_divisi, 
(j.gaji_pokok + j.tunjangan_jabatan + p.tunjangan_kinerja) as gaji_Total, 0.05*(j.gaji_pokok + j.tunjangan_jabatan + p.tunjangan_kinerja)
as pajak, ((j.gaji_pokok + j.tunjangan_jabatan + p.tunjangan_kinerja)) - (0.05*(j.gaji_pokok + j.tunjangan_jabatan + p.tunjangan_kinerja)) as gaji_bersih
from tb_karyawan k join tb_pekerjaan p on k.nip = p.nip 
join tb_jabatan j on p.kode_jabatan = j.kd_jabatan join
tb_divisi div on p.kode_divisi = div.kd_divisi
where k.jenis_kelamin ='pria' and p.kota_penempatan !='Sukabumi'

select * from tb_karyawan

--3 
select k.nip, (k.nama_depan + k.nama_belakang) as Full_Name, j.nama_jabatan,div.nama_divisi, 
((j.gaji_pokok + j.tunjangan_jabatan + p.tunjangan_kinerja)*7) * 0.25 as Bonus
from tb_karyawan k 
join tb_pekerjaan p on k.nip = p.nip 
join tb_jabatan j on p.kode_jabatan = j.kd_jabatan 
join tb_divisi div on p.kode_divisi = div.kd_divisi

--4
select k.nip, (k.nama_depan + k.nama_belakang) as Full_Name, j.nama_jabatan,div.nama_divisi, 
(j.gaji_pokok + j.tunjangan_jabatan + p.tunjangan_kinerja) as total_gaji, (j.gaji_pokok + j.tunjangan_jabatan + p.tunjangan_kinerja) * 0.05 as infaq 
from tb_karyawan k join tb_pekerjaan p on k.nip = p.nip 
join tb_jabatan j on p.kode_jabatan = j.kd_jabatan join
tb_divisi div on p.kode_divisi = div.kd_divisi
where p.kode_jabatan = 'MGR'

--5
select k.nip, (k.nama_depan + k.nama_belakang) as Full_Name, j.nama_jabatan,k.pendidikan_terakhir, 2000000 as Tunjangan_Pendidikan, 
(j.gaji_pokok + j.tunjangan_jabatan + 2000000) as total_gaji 
from tb_karyawan k join tb_pekerjaan p on k.nip = p.nip 
join tb_jabatan j on p.kode_jabatan = j.kd_jabatan join
tb_divisi div on p.kode_divisi = div.kd_divisi
where k.pendidikan_terakhir like  'S1%'

--6
select k.nip, (k.nama_depan + k.nama_belakang) as Full_Name, j.nama_jabatan, 
case when p.kode_jabatan = 'MGR' then ((j.gaji_pokok + j.tunjangan_jabatan + p.tunjangan_kinerja)*7) * 0.25
when p.kode_jabatan = 'ST' then ((j.gaji_pokok + j.tunjangan_jabatan + p.tunjangan_kinerja)*5) * 0.25
else ((j.gaji_pokok + j.tunjangan_jabatan + p.tunjangan_kinerja)*2) * 0.25 end as Bonus 
from tb_karyawan k join tb_pekerjaan p on k.nip = p.nip 
join tb_jabatan j on p.kode_jabatan = j.kd_jabatan join
tb_divisi div on p.kode_divisi = div.kd_divisi

--7
alter table tb_karyawan add constraint unique_nip unique(nip)

alter table tb_karyawan drop constraint unique_nip --drop unique

--8
create index idx_nip on tb_karyawan (nip)

drop index idx_nip on tb_karyawan --menghapus index

--9
select 
case when  nama_belakang like 'w%' then (nama_depan +' ' +UPPER(nama_belakang)) else nama_depan +' '+ nama_belakang end
from tb_karyawan
--cara 2
select (nama_depan +' '+ Upper(nama_belakang)) as Full_Name
from tb_karyawan
where nama_belakang like 'W%'
--cara 3
select concat(nama_depan + ' ',(iif(nama_belakang like 'w%',upper(nama_belakang),nama_belakang))) Nama
from tb_karyawan
--10
select k.nip, (k.nama_depan + k.nama_belakang) as Full_Name, k.tgl_masuk, j.nama_jabatan, div.nama_divisi,
DATEDIFF(year, tgl_masuk, GETDATE()) as lama_bekerja,
case when DATEDIFF(year, tgl_masuk, GETDATE()) >= 8 then 
((j.gaji_pokok + j.tunjangan_jabatan + p.tunjangan_kinerja)*0.10) end as Bonus 
from tb_karyawan k join tb_pekerjaan p on k.nip = p.nip 
join tb_jabatan j on p.kode_jabatan = j.kd_jabatan join
tb_divisi div on p.kode_divisi = div.kd_divisi
order by lama_bekerja
