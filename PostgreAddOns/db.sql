CREATE TABLE Peminjam (
	nim varchar(10) primary key NOT NULL,
	email varchar(50) NOT NULL,
	password VARCHAR(150) NOT NULL,
	nama varchar(50),
	jurusan varchar (50),
	nomor_tlp varchar (12)
);

CREATE TABLE TableAdmin (
	nip varchar(10) primary key NOT NULL,
	email varchar(50) NOT NULL,
	password VARCHAR(150) NOT NULL,
	nama varchar(50),
	nomor_tlp varchar (12)
);

CREATE TABLE Pengelola_logistik (
	nip varchar(10) primary key NOT NULL,
	email varchar(50) NOT NULL,
	password VARCHAR(150) NOT NULL,
	nomor_tlp varchar (12)
);

CREATE TABLE Fasilitas (
	fasilitas_id varchar(15) primary key,
	gambar_fasilitas BYTEA,
	desc_fasilitas varchar(200),
	harga_fasilitas numeric,
	nama_fasilitas varchar(50),
	ruangan varchar(20)
);

CREATE TABLE Orders(
	order_id varchar(15) PRIMARY KEY,
    nim VARCHAR(10),
    fasilitas_id varchar(15) NOT NULL,
    tanggal_mulai DATE,
	tanggal_selesai DATE,
	file_dokumen BYTEA,
    CONSTRAINT Orders_FK1 FOREIGN KEY (nim) REFERENCES Peminjam (nim),
    CONSTRAINT Orders_FK2 FOREIGN KEY (fasilitas_id) REFERENCES Fasilitas (fasilitas_id)
);

CREATE TABLE Kerusakan (
	kerusakan_id varchar(10) primary key NOT NULL,
	order_id varchar(15),
	fasilitas_id varchar(15),
	dokumen_kerusakan BYTEA,
	CONSTRAINT Kerusakan_FK1 FOREIGN KEY (order_id) REFERENCES Orders (order_id),
    CONSTRAINT Kerusakan_FK2 FOREIGN KEY (fasilitas_id) REFERENCES Fasilitas (fasilitas_id)
);

CREATE TABLE Pembatalan (
	pembatalan_id varchar(10) primary key NOT NULL,
	order_id varchar(15),
	fasilitas_id varchar(15),
	dokumen_pembatalan BYTEA,
	CONSTRAINT Kerusakan_FK1 FOREIGN KEY (order_id) REFERENCES Orders (order_id),
    CONSTRAINT Kerusakan_FK2 FOREIGN KEY (fasilitas_id) REFERENCES Fasilitas (fasilitas_id)
);

insert into peminjam values ('1302213045', 'rasjidzz@student.telkomuniversity.ac.id', 'testing','Muhammad Risjad Shidqi Febian', 'Rekayasa Perangkat Lunak', '0821');
insert into tableadmin values ('1001000', 'aqua@admin.telkomuniversity.ac.id', 'admin', 'Dasep', '0822');

SELECT * FROM tableadmin;
SELECT * FROM Peminjam;
