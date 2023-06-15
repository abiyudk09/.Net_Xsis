use db_kampus

--SQL DAY 3

select * from mahasiswa
select * from biodata

--membuat parameter
create procedure sp_RetriveMahasiswa
as
begin
select name, address, email, nilai from mahasiswa
end

--exec untuk run / memanggil
exec sp_RetriveMahasiswa

--alter parameter
alter procedure sp_RetriveMahasiswa
	@id int
as
begin
select name, address, email, nilai from mahasiswa
where id = @id
end

exec sp_RetriveMahasiswa 1

--function
create function fn_total_mahasiswa
(
	@id int
)
returns int
as
begin
	declare @hasil int
	select @hasil = count(id) from mahasiswa
	return @hasil
end

select dbo.fn_total_mahasiswa (1)


--Create STORED PROCEDURE
CREATE PROCEDURE sp_RetrieveStudents
	--Param
AS
BEGIN
	SELECT name, address, email, _values FROM students

END

--EXEC/Run STORED PROCEDURE
EXEC sp_RetrieveStudents

--Alter STORED PROCEDURE
GO
ALTER PROCEDURE sp_RetrieveStudents
	@id int,
	@name VARCHAR(50)
AS
BEGIN
	SELECT id, name, address, email, _values FROM students
	WHERE id = @id AND name = @name
END
GO

EXEC sp_RetrieveStudents 2, 'Fachri Kusnaini'


--FUNCTION
GO
CREATE FUNCTION fn_totalStudents
(
	@id INT
)
RETURNS INT 
AS
BEGIN
	-- Add the SELECT statement with parameter references here
	DECLARE @result INT
	SELECT @result = COUNT(id) FROM students
	RETURN @result

END
GO

--RUN FUNCTION



GO
ALTER FUNCTION fn_totalStudents
(
	@id INT,
	@name VARCHAR(50)
)
RETURNS INT 
AS
BEGIN
	-- Add the SELECT statement with parameter references here
	DECLARE @result INT
	SELECT @result = COUNT(id) FROM students WHERE id = @id AND name = @name
	RETURN @result

END
GO

SELECT dbo.fn_totalStudents(2, 'Fachri Kusnaini')


--Tester select Function students

SELECT stdn.id, stdn.name, dbo.fn_totalStudents(stdn.id, stdn.name)[Tester Function]
FROM students AS stdn
JOIN biodata AS bio ON bio.id_students = stdn.id

--truncate table
truncate table [namatable] --untuk menghapus isi data pada column table dan meriset PK dari 1