insert into dbo.Events(date,registrationStart, registrationEnd, isLocked) 
	values(27-11-2017,1-10-2017,1-11-2017,'false');
insert into dbo.Areas(designation,fk_event,Graphic) 
	values('Erdgeschoss',1,00234999423211);
insert into dbo.Locations(Number,Fk_area,xcoordinate, ycoordinate)
	values(201,1,200,400);
insert into dbo.Categories(name,price,Description)
	values('basic',200,'Nur einen Stand');
insert into dbo.Categories(name,price,Description)
	values('sponsor',400,'Stand + Vortrag');
insert into dbo.Categories(name,price,Description) 
	values('premium sponsor',600,'Stand + Vortrag + Sponsoreitrag');
insert into dbo.Presentations(roomnumber,title,Description,isAccepted) 
	values(252,'Stress = negativ?','Ist Stress wirklich immer negativ oder gibt es auch positvien Stress?','true');
insert into dbo.People(firstname,lastname,email,picture,phonenumber) 
	values('Eric','Buchinger','erik.buchinger@gmx.at',002349239492304,'069919261793');
insert into dbo.People(firstname,lastname,email,picture,phonenumber) 
	values('Marcel','Pautz','marcel.pautz@gmail.com',0023040230402304,'06601992342');
insert into dbo.Contacts(fk_person)
	values(2);
insert into dbo.Addresses(city,postalcode,street,number) 
	values('Linz',4020,'Unionstraße',12);
insert into dbo.Companies(name,ShortDescription,FK_Address,fk_contact,phonenumber,email,homepage,CompanySign,SubjectAreas)
	values('BuchingerServices','Wir sind eine Serviceanlaufstelle für Computerprobleme',1,1,'069923823402','buchinger@services.com','buchinger.com',00234234234234,'Informatik');
insert into dbo.Lecturers(fk_presentation,fk_person)
	values(1,2);
insert into dbo.Bookings(FK_Event,FK_Company,FK_Location,FK_Presentation,fk_category,isAccepted)
	values(1,1,1,1,3,'true');
insert into dbo.Resources(name,description) 
	values('Wlan', 'Wir brauchen Internet'); 
insert into dbo.Resources(name,description)
	values('Tisch', 'Wir brauchen Tische');
insert into dbo.Resources(name,description) 
	values('Sessel', 'Wir brauchen Sessel');
insert into dbo.Resources(name,description) 
	values('Wasser', 'Wir brauchen Wasser');
insert into dbo.Resources(name,Description)
	values('Kaffee', 'Wir brauchen Kaffee');
insert into dbo.ResourceBookings(fk_resource,fk_booking,amount)
	values(1,1,1);
insert into dbo.ResourceBookings(fk_resource,fk_booking,amount)
	values(2,1,2);
insert into dbo.ResourceBookings(fk_resource,fk_booking,amount)
	values(3,1,4);
insert into dbo.ResourceBookings(fk_resource,fk_booking,amount)
	values(4,1,2);
insert into dbo.ResourceBookings(fk_resource,fk_booking,amount)
	values(5,1,1);
insert into dbo.Representatives(FK_Booking,FK_Person) 
	values(1,1);