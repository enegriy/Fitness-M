
CREATE TABLE IF NOT EXISTS clients (
  id int(11) NOT NULL auto_increment,
  number bigint NOT NULL  ,
  surname varchar(100) NOT NULL DEFAULT '' ,
  name varchar(100) NOT NULL DEFAULT '' ,
  lastname varchar(100) DEFAULT '' ,
  datebirth date ,
  phone varchar(15) ,
  address varchar(150) ,
  note varchar(100) ,
  PRIMARY KEY (id)
);


Create unique index unque_number on clients(number);


CREATE TABLE IF NOT EXISTS users (
  id int(11) NOT NULL auto_increment,
  name varchar(20) NOT NULL ,
  passwd varchar(20) NOT NULL ,
  role_number int(1) NOT NULL ,
  PRIMARY KEY (id)
);


CREATE TABLE IF NOT EXISTS kind_tickets (
  id int(11) NOT NULL auto_increment,
  period int(6) ,
  count_balls int(11),
  count_visits int(11),
  isonlygroup bool,
  isinactive bool ,
  PRIMARY KEY (id)
);

ALTER TABLE kind_tickets ADD price DECIMAL NOT NULL;
ALTER TABLE kind_tickets CHANGE price price DECIMAL(10,2)  NOT NULL;


CREATE TABLE IF NOT EXISTS tickets (
  id int(11) NOT NULL auto_increment,
  datefinish date NOT NULL ,
  balance int(11) NOT NULL  ,
  client_id int(11) NOT NULL  ,
  kind_tickets_id int(11) NOT NULL  ,
  PRIMARY KEY (id)
);