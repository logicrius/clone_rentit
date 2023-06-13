CREATE TABLE userLogin (
	username VARCHAR(150) primary key,
	password VARCHAR(150),
	rentedBuilding NUMERIC
);

CREATE TABLE rentedBuilding (
	building_Id NUMERIC primary key,
	building_Picture BYTEA,
	building_Desc VARCHAR (1500),
	building_Price NUMERIC,
	building_RentDate DATE,
	building_Room VARCHAR (1500),
	building_Name VARCHAR (1500)
);

CREATE TABLE userOrder(
	rental_id SERIAL PRIMARY KEY,
    username VARCHAR(150),
    building_Id NUMERIC,
    building_RentDate DATE,
    CONSTRAINT userOrder_FK1 FOREIGN KEY (username) REFERENCES userLogin (username),
    CONSTRAINT userOrder_FK2 FOREIGN KEY (building_Id) REFERENCES rentedBuilding (building_Id),
    UNIQUE (building_Id, building_RentDate)
);

ALTER TABLE rentedBuilding ALTER COLUMN building_Id TYPE NUMERIC;
ALTER TABLE userLogin ADD COLUMN building_Id INTEGER;
ALTER TABLE userlogin ADD CONSTRAINT userlogin_FK FOREIGN KEY (building_Id) REFERENCES rentedBuilding (building_Id);
ALTER TABLE userLogin ADD CONSTRAINT userlogin_PK PRIMARY KEY (username);

SELECT * FROM rentedBuilding;

INSERT INTO userLogin VALUES('juliandrigifari@student.telkomuniversity.ac.id','praktikum');