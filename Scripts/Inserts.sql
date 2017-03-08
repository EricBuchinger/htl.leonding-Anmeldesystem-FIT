insert into event (id,date,registrationStart, registrationEnd, isLocked) 
	values(1,27.11.2017,1.10.2017,1.11.2017,false);
insert into area (id,designation,fk_event) 
	values(1,"Erdgeschoss",1);
insert into location (id,Number,Fk_area,xcoordinate, ycoordinate)
	values(1,201,1,200,400);
insert into category(id,name,price,discrition)
	values(1,"basic",200,"Nur einen Stand");
insert into category(id,name,price,discrition)
	values(2,"sponsor",400,"Stand + Vortrag");
insert into category(id,name,price,discrition) 
	values(3,"premium sponsor",600,"Stand + Vortrag + Sponsoreitrag");
insert into presentation(id,roomnumber,title,descrition,isAccepted) 
	values(1,252,"Stress = negativ?","Ist Stress wirklich immer negativ oder gibt es auch positvien Stress?",true);
insert into person(id,firstname,lastname,email,phonenumber) 
	values(1,"Eric","Buchinger","erik.buchinger@gmx.at","069919261793");
insert into person(id,firstname,lastname,email,phonenumber) 
	values(2,"Marcel","Pautz","marcel.pautz@gmail.com","06601992342");
insert into contact(id,fk_person)
	values(1,2);
insert into adress(id,city,postalcode,street,number) 
	values(1,"Linz",4020,"Unionstraße",12);
insert into company(id,name,shortdesription,fk_adress,fk_contact,phonenumber,email,homepage,subjectAreas)
	values(1,"BuchingerServices","Wir sind eine Serviceanlaufstelle für Computerprobleme",1,1,"069923823402","buchinger@services.com","buchinger.com","Informatik");
insert into lecturer(id,fk_presentation,fk_person)
	values(1,1,2);
insert into booking(id,fk_event,fk_company,fk_location,fk_presentation,fk_category,isAccepted)
	values(1,1,1,1,3,true);
insert into resource(id,name,description) 
	values(1,"Wlan", "Wir brauchen Internet"); 
insert into resource(id,name,description)
	values(2,"Tisch", "Wir brauchen Tische");
insert into resource(id,name,description) 
	values(3,"Sessel", "Wir brauchen Sessel");
insert into resource(id,name,description) 
	values(4,"Wasser", "Wir brauchen Wasser");
insert into resource(id,name,description)
	values(5,"Kaffee", "Wir brauchen Kaffee");
insert into resourcebooking(id,fk_resource,fk_booking,amount)
	values(1,1,1,1);
insert into resourcebooking(id,fk_resource,fk_booking,amount)
	values(2,2,1,2);
insert into resourcebooking(id,fk_resource,fk_booking,amount)
	values(3,3,1,4);
insert into resourcebooking(id,fk_resource,fk_booking,amount)
	values(4,4,1,2);
insert into resourcebooking(id,fk_resource,fk_booking,amount)
	values(5,5,1,1);
insert into representative(id,fk_booking,fk_person) 
	values(1,1,1);


