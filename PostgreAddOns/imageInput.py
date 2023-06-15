import psycopg2
from psycopg2.extras import DateRange

# Connect to PostgreSQL database
connectToDB = psycopg2.connect(
    host="localhost",
    database="RentIt",
    user="postgres",
    password="belajardatabase"
)

# Read input image
# Jika ingin mengganti gambar, ganti "SC.jpg".
with open('AUDIT.jpg', 'rb') as file:
    image_data = file.read()

fasilitas_id = 'AUDIT0001'
desc_fasilitas = 'AUDIT ADALAH BLA BLA BLA'
harga_fasilitas = 7000000.0
nama_fasilitas = 'Auditorium'
available_date = [date for date in ['2023-06-14', '2023-06-20', '2023-06-26']]
ruangan = 'Audit'

cursor = connectToDB.cursor()

insert_query = """
    INSERT INTO Fasilitas (fasilitas_id, gambar_fasilitas, desc_fasilitas, harga_fasilitas, nama_fasilitas, available_date, ruangan)
    VALUES (%s, %s, %s, %s, %s, ARRAY(SELECT array_agg(d)::date[] FROM unnest(%s) AS d), %s);
"""

cursor.execute(insert_query, (fasilitas_id, psycopg2.Binary(image_data), desc_fasilitas, harga_fasilitas, nama_fasilitas, available_date, ruangan))
connectToDB.commit()

cursor.close()
connectToDB.close()
