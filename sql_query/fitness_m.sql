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
