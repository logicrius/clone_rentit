import psycopg2
from psycopg2 import sql

# Connect ke PostgreSQL database
connectToDB = psycopg2.connect(
    host="localhost",
    database="LocalRentIt",
    user="postgres",
    password="adminpbo"
)

# Baca input image
with open('SC.jpg', 'rb') as file:
    image_data = file.read()

building_id = 12345  # Isinya 000N, contoh = 0001, 0002, dll
bulidng_desc = '' # Isinya deskripsi fasilitas
building_price = 0.0 # Isinya harga sewa
building_rentDate = '2023-05-03' # Isinya tanggal bisa disewa (tidak pake jam) formatnya 'YYYY-MM-DD'
building_room = '' # Isinya nama ruangannya (sesuai ama building_name) contoh building_name = TULT, jadi building_room = TULT 07-18
building_name =  '' # Isinya nama bangunan, contoh = TULT, Gedung Kuliah Umum, dll

cursor = connectToDB.cursor()
insert_query = sql.SQL("INSERT INTO rentedBuilding (building_Id, building_Picture, building_Desc, building_Price, building_RentDate, building_Room, building_Name) VALUES (%s, %s, %s, %s, %s, %s, %s);")
cursor.execute(insert_query, [building_id, psycopg2.Binary(image_data), bulidng_desc, building_price, building_rentDate, building_room, building_name])
connectToDB.commit()

cursor.close()
connectToDB.close()
