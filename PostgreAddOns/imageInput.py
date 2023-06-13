import psycopg2
from psycopg2.extras import DateRange

# Connect to PostgreSQL database
connectToDB = psycopg2.connect(
    host="localhost",
    database="LocalRentIt",
    user="postgres",
    password="adminpbo"
)

# Read input image
with open('SC.jpg', 'rb') as file:
    image_data = file.read()

fasilitas_id = 'SC0004'
desc_fasilitas = 'Student Center tempat kesekretariatan yang memiiliki fungsi administrasi, konsolidasi, latihan dan penyimpanan barang.'
harga_fasilitas = 5000000.0
nama_fasilitas = 'Student Center'
available_date = [date for date in ['2023-06-04', '2023-06-05', '2023-06-06']]
ruangan = 'Room 109'

cursor = connectToDB.cursor()

insert_query = """
    INSERT INTO Fasilitas (fasilitas_id, gambar_fasilitas, desc_fasilitas, harga_fasilitas, nama_fasilitas, available_date, ruangan)
    VALUES (%s, %s, %s, %s, %s, ARRAY(SELECT array_agg(d)::date[] FROM unnest(%s) AS d), %s);
"""

cursor.execute(insert_query, (fasilitas_id, psycopg2.Binary(image_data), desc_fasilitas, harga_fasilitas, nama_fasilitas, available_date, ruangan))
connectToDB.commit()

cursor.close()
connectToDB.close()
