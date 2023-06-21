create database ft1_ess319
use ft1_ess319


--1
select * from biodata b 
join employee e on b.id = e.biodata_id
join employee_position ep on e.id = ep.employee_id 
join position p on ep.position_id = p.id

--2 --data masih double
select e.nip,  CONCAT(b.first_name + ' ',b.last_name), DATEDIFF(day,start_date,end_date) [cuti diambil]
from biodata b 
join employee e on b.id = e.biodata_id
join leave_request lr on e.id = lr.employee_id
group by e.nip, b.first_name, b.last_name, start_date, end_date

--cara lain
select e.nip, concat(b.first_name, last_name),sum(el.regular_quota) as cuti from employee as e
join biodata as b on e.biodata_id = b.id
join employee_leave as el on e.id = el.employee_id
join leave as l on e.id = l.id
group by e.nip, b.first_name, last_name

--3 kurang anaknya
select CONCAT (b.first_name + ' ',b.last_name) [Nama lengkap], p.name, 
DATEDIFF(year,dob, GETDATE()) as usia, CASE
           WHEN COUNT(f.id) > 0 THEN COUNT(f.id)
           ELSE 0
       END AS [Jml. Anak]	
from biodata b 

join employee e on b.id = e.biodata_id
join employee_position ep on e.id = ep.employee_id 
join position p on ep.position_id = p.id
left join family f ON b.id = f.biodata_id
GROUP BY b.id, b.first_name, b.last_name, p.name, b.dob
ORDER BY b.id;

SELECT CONCAT(b.first_name, ' ', b.last_name) AS [Nama Lengkap],
       p.name AS [Jabatan],
       DATEDIFF(YEAR, b.dob, GETDATE()) AS [Usia],
       CASE
           WHEN COUNT(f.id) > 0 THEN COUNT(f.id)
           ELSE 0
       END AS [Jml. Anak]
FROM biodata b
JOIN employee e ON b.id = e.biodata_id
JOIN employee_position ep ON e.id = ep.employee_id
JOIN position p ON ep.position_id = p.id
LEFT JOIN family f ON b.id = f.biodata_id
GROUP BY b.id, b.first_name, b.last_name, p.name, b.dob
ORDER BY b.id;

--4
select CONCAT (b.first_name + ' ',b.last_name) [Nama lengkap], nip, status, salary
from biodata b 
join employee e on b.id = e.biodata_id
where pob = 'jakarta' and address not like '%jakarta'

--5 
select e.status as stat, count(*) as jumlah
from employee as e
group by e.status

--6 belum muncul
select CONCAT (b.first_name + ' ',b.last_name) [Nama lengkap], tt.name, sum(DATEDIFF(day, tr.start_date, tr.end_date)) * tt.travel_fee as fee
from biodata b 
join employee e on b.id = e.biodata_id
join travel_request tr on e.id = tr.employee_id
join travel_type tt on tr.travel_type_id = tt.id
--join travel_settlement ts on tr.id = ts.travel_request_id
--group by b.first_name

--7

SELECT CONCAT(b.first_name, ' ', b.last_name) AS "Nama Lengkap", d.name AS "Departemen"
FROM biodata b
JOIN employee e ON b.id = e.biodata_id
JOIN employee_position ep ON e.id = ep.employee_id
JOIN position p ON ep.position_id = p.id
JOIN department d ON p.id = d.id
where e.id = '1' or e.id = '2'


--8
select concat(b.first_name, ' ', b.last_name) [Nama Lengkap],
  CASE WHEN b.marital_status = 1 THEN 'Menikah'
    ELSE 'Lajang' END AS marital_status,
  f.name AS pasangan
FROM
  biodata b
LEFT JOIN
  family f ON b.id = f.biodata_id
WHERE
  f.status = 'Suami' AND f.biodata_id IN (
    SELECT biodata_id
    FROM family
    WHERE status = 'Anak'
  )

  --9
  select b.* from biodata b
  left join employee e on b.id = e.biodata_id
left join employee_position ep on e.id = ep.employee_id 
--join position p on ep.position_id = p.id
where ep.position_id is null

--10 
select count(dob) 
from biodata
where dob between '1991' AND '1993' 


















































select status as status_karyawan, count(status) as jumlah_karyawan
from employee e
join biodata b
on b.id = e.biodata_id
group by status

--2. Tampilkan data biodata yang tidak memiliki posisi kepegawaian
select concat(first_name, ' ', last_name ) as nama_lengkap
from biodata b left join employee e
on b.id= e.biodata_id
where biodata_id is null

-- 3.Buatklah query untuk menampilkan nama lengkap karyawan, 
--   status pernikahan, nama pasangan(suami/istri) yang sudah memiliki ana
select concat(first_name, ' ', last_name) as nama_lengkap
from biodata b
join employee e
on b.id = e.biodata_id

-- 4. nama lengkap dan departemen 
select concat(first_name, ' ', last_name) as nama_lengkap, d.name as department
from biodata b right join department d
on b.id = d.id
where first_name  like 'R%'

select * from department

-- 5. (gatau benar atau salah) Hitung ada berapa karyawan yang lahir pada tahun 1991 dan 1992
select count (dob) as jumlah_karyawan
from biodata
where dob = '1991' or dob = '1992'

-- 6.Tampilkan data biodata yang memiliki jabatan/posisi
select concat(first_name, ' ', last_name ) as nama_lengkap,
dob as tanggal_lahir,
address as alamat,
p.name as jabatan
from biodata b left join employee e
on b.id= e.biodata_id
join position p
on b.id = p.id
where biodata_id is not null

-- 7. Tampilkan data karyawan yang lahir di Jakarta namun tidak tinggal di Jakarta

select concat(first_name, ' ', last_name) as nama_lengkap,
pob as tempat_lahir, 
address as alamat_tinggal
from biodata
where pob like '%jakarta%' and address not like '%jakarta%'

-- 8. (belomselese)Tampilkan fullname, jabatan, usia, dan jumlah anak dari masing-masing karyawan saat ini (kalau tidak ada anak tulis 0 (nol) atau \'-\' saja)
select concat(first_name, ' ', last_name) as nama_lengkap,
p.name as jabatan
from biodata b join position p
on b.id = p.id

-- 9. Hitung berapa hari cuti yang sudah diambil masing-masing karyawan


-- 10. (total pengeluaran belom )Tampilkan nama karyawan, jenis perjalanan dinas, tanggal perjalanan dinas, dan total pengeluarannya selama perjalanan dinas tersebut

select concat(first_name,' ', last_name) as nama_karyawan,
l.name as perjalanan_dinas,
lr.start_date as tanggal_perjalanan_dinas
from biodata b join employee e
on b.id = e.biodata_id
join leave_request lr
on lr.employee_id = e.id
join leave l
on lr.leave_id = l.id
