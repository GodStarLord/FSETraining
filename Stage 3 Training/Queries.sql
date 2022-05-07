create database dbTransportCTS

use database dbTransportCTS

create table employees (
	id int identity(1,1) primary key,
	name varchar(20) not null,
	address varchar(100),
	location varchar(30),
	age int check(age>18),
	phone varchar(20),
	email varchar(20),
	)
	
create table drivers (
	id int identity(101,1) primary key,
	name varchar(30),
	phone varchar(20)
	)
	
create table bus (
	--bus_number varchar(20) constraint pk_busno primary key,
	bus_number varchar(20) primary key,
	capacity int check(capacity<50),
	occupancy int default 0
	)

alter table employees
add bus_number varchar(20) constraint fk_busno foreign key references bus(bus_number)

create table trips (
	trip_id int identity(1000,1) constraint pk_trip_id primary key,
	bus_id varchar(20) constraint fk_tripbusno foreign key references bus(bus_number),
	driver_id int references drivers(id),
	stop1 varchar(30),
	stop1_time time,
	stop2 varchar(30),
	stop2_time time,
	stop3 varchar(30),
	stop3_time time
	)
	
create proc proc_InsertEmployee (
	@eName varchar(20),
	@eAddress varchar(1000),
	@eLocation varchar(30),
	@eAge int,
	@ePhone varchar(20),
	@eEmail varchar(50)
	)
as
	insert into employees(name,address,location,age,phone,email)
	values(@eName,@eAddress,@eLocation,@eAge,@ePhone,@eEmail)

create proc proc_InsertDriver (
	@eName varchar(30),
	@ePhone varchar(20)
	)
as
	insert into drivers(name, phone)
	values(@eName, @ePhone)

create proc proc_InsertBus (
	@eBus_Number varchar(20),
	@eCapacity int,
	@eOccupancy int
	)
as
	insert into bus(bus_number,capacity,occupancy)
	values(@eBus_Number,@eCapacity,@eOccupancy)
	
create proc proc_InsertTrips ( 
	@eBusId varchar(20),
	@eDriverId int,
	@eStop1 varchar(30),
	@eStop1_time time,
	@eStop2 varchar(30),
	@eStop2_time time,
	@eStop3 varchar(30),
	@eStop3_time time
	)
as
	insert into trips(bus_id,driver_id,stop1,stop1_time,stop2,stop2_time,stop3,stop3_time)
	values (@eBusId,@eDriverId,@eStop1,@eStop1_time,@eStop2,@eStop2_time,@eStop3,@eStop3_time)
	
create proc proc_allocateBusTomEmployee(@eid int, @busno varchar(10))
as
begin
	begin tran
		update employees set bus_number = @busno where id = @eid;
		declare 
		@bcap int,
		@bocc int
		set @bcap = (select capacity from bus where bus_number = @busno )
		set @bcap = (select occupancy from bus where bus_number = @busno )
		set @bcap = @bcap - 1;
		set @bocc = @bocc + 1;
		update bus set occupancy = @bocc where bus_number = @busno;
		if(@bocc > @bcap )
			rollback
		commit
end


create proc proc_GetBusForEmployee(@eid int)
as
begin
	select bus_number from bus b
	join trips t on b.bus_number = t.bus_id
	where b.capacity > b.occupancy
	and
	(stop1 = 
		(select location from employees where id = @eid)
	or
		stop2 = (select location from employees where id = @eid)
	or
		stop3 = (select location from employees where id = @eid))
end


create proc proc_loginCheck
	(
		@username Varchar (20),
		@password varchar (10)
	)
as
begin
	select count(*) from logininfo where username = @username and password = @password;
end


















	
data source = ; (LocalDb)\MSSQLLocalDB
Integrated Security = true;
Initial Catalog = dbTransportCTS