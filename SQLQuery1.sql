--create database EMS_DB;
--drop database EMS_DB;

--create table Emp_Details(
--		Emp_id int primary key identity,
--		Ename varchar(50),
--		Dept varchar(50),
--		Desig varchar(50),
--		Join_Date date,
--		Leave_Date Date
--		);

--drop table Emp_Login_Details;

--create table Emp_Login_Details(
--		eid int,
--		foreign key(eid) references Emp_Details(Emp_id),
--		userID varchar(30) unique,
--		userpasswd varchar(30),
--		attribute varchar(2)
--		);

--select * from Emp_Login_Details;

--create table Emp_Personal_Details(
--		eid int,
--		foreign key(eid) references Emp_Details(Emp_id),
--		emp_Gender varchar(10),
--		emp_Email varchar(50) primary key,
--		emp_Mobile_no varchar(12),
--		emp_Address text,
--		emp_DOB date
--		);



--drop table Emp_Educational_Details;

--create table Emp_Educational_Details(
--		eid int,
--		foreign key(eid) references Emp_Details(Emp_id),
--		UG_Degree varchar(50),
--		PG_Degree varchar(50),
--		ph_d varchar(50),
--		Tenth_Mark int,
--		PlusTwo_MArk int,
--		Extra_certificate text
--		);

--select * from Emp_Educational_Details;

--select * from Emp_Leave_info;

--create table Emp_Leave_Info(
--		leave_Id int primary key identity,
--		eid int,
--		foreign key(eid) references Emp_Details(Emp_id),
--		name varchar(50),
--		From_Date date,
--		To_Date date,
--		LeaveType varchar(10),
--		Reason text,
--		attribute varchar(2),
--		Leave_status varchar(10)
--		);

create procedure GetLeaveDate @eid int
as
	select from_date,To_date from Emp_Leave_Info where eid =  @eid and Leave_status = 'Accecpted'
go

--drop procedure GetLeaveDate;

--exec GetLeaveDate 1014

--drop table Emp_Leave_Info;

--create table Emp_salary_info (eid int,base_salary real,monthly_dispatch real,foreign key(eid) references Emp_Details(emp_id));

--drop table Emp_salary_info;
--drop procedure InsertSalary;

--select *from Emp_salary_info

--create procedure SearchSalary @eid int
--as
--	select * from  Emp_Salary_info where eid = @eid
--go

--create procedure InsertSalary @eid int,@b_s real,@monthly_dispatch real
--as
--	begin
--		insert into Emp_salary_info values(@eid,@b_s,@monthly_dispatch);
--	end
--go

--exec SearchSalary 1014


--exec InsertSalary 1,1200000,100000;

--drop table Emp_Leave_Info;

--select Emp_Details.Emp_id,Emp_Details.Ename,Emp_Personal_Details.emp_Gender,Emp_Details.Dept,Emp_Details.Desig,Emp_Details.Join_Date,
--		Emp_Personal_Details.emp_Mobile_no,Emp_Personal_Details.emp_Email,Emp_Personal_Details.emp_Address,Emp_Personal_Details.emp_DOB
--		from Emp_Details left join Emp_Personal_Details on Emp_Details.Emp_id = Emp_Personal_Details.eid;

--create procedure LoadDetails 
--as
--	begin
--		select Emp_Details.Emp_id,Emp_Details.Ename,Emp_Personal_Details.emp_Gender,Emp_Details.Dept,Emp_Details.Desig,Emp_Details.Join_Date,
--		Emp_Personal_Details.emp_Mobile_no,Emp_Personal_Details.emp_Email,Emp_Personal_Details.emp_Address,Emp_Personal_Details.emp_DOB
--		from Emp_Details left join Emp_Personal_Details on Emp_Details.Emp_id = Emp_Personal_Details.eid;
--	end
--go


--create procedure LoginDetails @user varchar(30), @passwd varchar(30)
--as	
--	begin
--		select * from Emp_Login_Details where userID = @user and userpasswd = @passwd
--	end
--go

--insert into Emp_Details(Ename,Dept,Desig,Join_Date) values('Hari Prasath','Software Developer','DOTNET-Developer','2019-06-25');

--insert into Emp_Personal_Details values(1,'Male','hprasath21212@gmail.com','7448915571','Theni','2001-10-11');

--insert into Emp_Login_Details values(1,'admin','1234','S');

 create procedure BasicInfo @Name varchar(35), @Dept varchar(30), @Desig varchar(30) 
 as
	begin
		insert into Emp_Details(Ename,Dept,Desig,Join_Date) values(@Name,@Dept,@Desig,GETDATE()) 
	end
go


--create procedure GetId @name varchar(35)
--as
--	begin
--		select * from Emp_Details where Ename = @name
--	end
--go

--create procedure Personal_Info @eid int, @Gender varchar(10), @Email varchar(50), @mobile_no varchar(12), @Address text, @DOB date
--as
--	begin
--		insert into Emp_Personal_Details values(@eid,@Gender,@Email,@mobile_no,@Address,@DOB);
--	end
--go

--drop procedure Personal_Info;

--create procedure Educational_Info @eid int,@UG_D varchar(50),@PG_D varchar(50),@PH_D varchar(50),@Mark10 int,@Mark12 int,@ExtraCert text
--as 
--	begin
--		insert into Emp_Educational_Details values (@eid,@UG_D,@PG_D,@PH_D,@Mark10,@Mark12,@ExtraCert)
--	end
--go

create procedure Insert_Login_Credencial @eid int, @user varchar(30), @passwd varchar(30), @attribute varchar(2)
as
	begin
		insert into Emp_Login_Details values(@eid,@user,@passwd,@attribute)
	end
go


--delete Emp_Details where Emp_Id =4 ;

--drop procedure Educational_Info;

--exec Educational_Info 4,'MCA','AeroSpace',480,600,'Pyhton Course'


--create procedure GetBacicData @eid int
--as
--	begin
--		select * from Emp_Details where Emp_Id = @eid
--	end
--go

--create procedure GetPersonalData @eid int
--as
--	begin
--		select * from Emp_Personal_Details where eid = @eid
--	end
--go

--create procedure GetEducationalData @eid int
--as
--	begin
--		select * from Emp_Educational_Details where eid = @eid
--	end
--go
-- for login info change!!!!!!!!!
--create procedure UpdateLoginData @eid int, @user varchar(50), @passwd varchar(50)
--as
--	begin
--		update Emp_Login_Details set userID = @user, userpasswd = @passwd  where eid = @eid 
--	end
--go


--drop procedure GetLoginData;



--create procedure UpdateInfo @eid int, @Email varchar(50), @mobile_no varchar(12), @Address text, @DOB date,
--							@UG_D varchar(50),@PG_D varchar(50),@PH_D varchar(50),@Mark10 int,@Mark12 int,@ExtraCert text
--as
--	begin
--		update Emp_Personal_Details set emp_Email = @Email, emp_Mobile_no = @mobile_no, emp_Address = @Address, emp_DOB = @DOB where eid = @eid;
--		update Emp_Educational_Details set UG_Degree = @UG_D, PG_Degree = @PG_D, ph_d = @PH_D, Tenth_Mark = @Mark10, PlusTwo_MArk = @Mark12, Extra_certificate = @ExtraCert where eid = @eid
--	end
--go

--drop procedure UpdateInfo;


--create procedure CountEmp 
--as 
--	select * from Emp_Details;
--go

--drop procedure CountEmp;

--drop procedure InsertLeave;

--create procedure InsertLeave @eid int,@name varchar(50), @From_date date, @To_date date, @LeaveType varchar(20), @Reason text,@attr varchar(2), @status varchar(10)
--as
--	begin
--		insert into Emp_Leave_info values(@eid,@name,@From_date,@To_date,@LeaveType,@Reason,@attr,@status)
--	end
--go


create procedure Specific_Leave_Record @eid int
as
	begin
		select eid,name,From_Date,To_Date,LeaveType,Reason,Leave_status from Emp_Leave_info where eid = @eid
	end
go

--drop procedure Specific_Leave_Record;

--exec Specific_Leave_Record 1014,'Accecpted';


--create procedure SortedDesigDetails @desig varchar(50)
--as 
--	begin
--		select Emp_Details.Emp_id,Emp_Details.Ename,Emp_Personal_Details.emp_Gender,Emp_Details.Dept,Emp_Details.Desig,Emp_Details.Join_Date,
--		Emp_Personal_Details.emp_Mobile_no,Emp_Personal_Details.emp_Email,Emp_Personal_Details.emp_Address,Emp_Personal_Details.emp_DOB
--		from Emp_Details left join Emp_Personal_Details on Emp_Details.Emp_id = Emp_Personal_Details.eid where  Emp_Details.Desig = @desig;
--	end
--go

--create procedure SetPermission @Leave_id int, @status varchar(20)
--as
--	begin
--		update Emp_Leave_Info set Leave_status = @status where Leave_id = @Leave_id
--	end
--go

--create procedure countPermission 
--as 
--	begin 
--		select * from Emp_Leave_Info where leave_status = 'Waiting' 
--	end 
--go

--drop procedure countpermission;
--exec SetPermission 3,'Accepted'

--exec countpermission;