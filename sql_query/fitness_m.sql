
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

create table fitness_equipment
(
  id int(11) NOT NULL auto_increment,
  title varchar(100) NOT NULL DEFAULT '' ,
  running_time int(11) NOT NULL,
  count_balls int(11) NOT NULL,
  PRIMARY KEY (id)
);

create table visits
(
  id int(11) NOT NULL auto_increment,
  client_id int(11) ,
  plan_from datetime,
  plan_to datetime,
  visit_from datetime,
  visit_to datetime,
  is_disabled bool,
  isonlygroup bool,
  PRIMARY KEY (id)
);

create table client_use_equipment
(
  id int(11) NOT NULL auto_increment,
  visit_id int(11) ,
  fitness_equipment_id int(11),
  PRIMARY KEY (id)
);

ALTER TABLE client_use_equipment ADD time_from TIME;
ALTER TABLE client_use_equipment ADD time_to TIME;

CREATE TABLE IF NOT EXISTS parameters (
  id int(11) NOT NULL auto_increment,
  title varchar(100) not null,
  value varchar(100),
  PRIMARY KEY (id)
);

ALTER TABLE tickets ADD debt DECIMAL(10,2);
ALTER TABLE tickets ADD pay_before DATE;
