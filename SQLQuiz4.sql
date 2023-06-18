--Quiz Day 4--

create database DB_Hr

use DB_Hr

create table tb_karyawan(
id bigint primary key identity(1,1) not null, 
nip varchar(50) not null,
nama_depan varchar(50) not null,
nama_belakang varchar(50) not null,
jenis_kelamin varchar(50) not null,
agama varchar(50) not null,
tempat_lahir varchar(50) not null,
tgl_lahir date,
alamat varchar(100) not null,
pendidikan_terakhir varchar(50) not null,
tgl_masuk date
)

insert into tb_karyawan
(
nip, nama_depan,nama_belakang, jenis_kelamin, agama, tempat_lahir, tgl_lahir, alamat, pendidikan_terakhir, tgl_masuk
)
values
('001', 'Hamidi', 'Samsudin', 'Pria', 'Islam', 'Sukabumi', '1977-04-21', 'Jl Sudirman No. 12', 'S1 Teknik Mesin', '2015-12-07'),
('003', 'Paul', 'Christian', 'Pria', 'Kristen', 'Ambon', '1980-05-27', 'Jl Veteran No. 4', 'S1 Pendidikan Geografi', '2014-01-12'),
('002', 'Ghandi', 'Wamida', 'Wanita', 'Islam', 'Palu', '1992-01-12', 'Jl Rambutan No. 22', 'SMA Negeri 02 Palu', '2014-12-01')

drop table tb_karyawan

create table tb_divisi
(
id bigint primary key identity (1,1) not null,
kd_divisi varchar(50) not null,
nama_divisi varchar(50) not null
)

insert into tb_divisi
(kd_divisi, nama_divisi)
values
('GD', 'Gudang'), ('HRD', 'HRD'), ('KU', 'Keuangan'), ('UM', 'Umum')


create table tb_jabatan
(
id bigint primary key identity(1,1),
kd_jabatan varchar(50) not null,
nama_jabatan varchar(50) not null,
gaji_pokok numeric,
tunjangan_jabatan numeric
)

insert into tb_jabatan
(
kd_jabatan, nama_jabatan, gaji_pokok, tunjangan_jabatan
)
values
('MGT', 'Manager', 5500000, 1500000),
('OB', 'Office Boy', 1900000, 200000),
('ST', 'Staff', 3000000, 750000),
('WMGR', 'Wakil Manager', 4000000, 1200000)

create table tb_pekerjaan
(
id bigint primary key identity(1,1) not null,
nip varchar(50) not null,
kode_jabatan varchar(50) not null,
kode_divisi varchar(50) not null,
tunjangan_kinerja varchar(50),
kota_penempatan varchar(50)
)

insert into tb_pekerjaan
(nip, kode_jabatan, kode_divisi, tunjangan_kinerja, kota_penempatan)
values
('001', 'ST', 'KU', 750000, 'Cianjur'),
('002', 'OB', 'UM', 350000, 'Sukabumi'),
('003', 'MGR', 'HRD', 1500000, 'Sukabumi')


