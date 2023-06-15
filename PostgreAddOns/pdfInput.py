import psycopg2
from psycopg2.extras import DateRange

# Connect to PostgreSQL database
connectToDB = psycopg2.connect(
    host="localhost",
    database="RentIt",
    user="postgres",
    password="belajardatabase"
)

# Read input PDF
# Jika ingin mengganti PDF, ganti "SC.jpg".
with open('Laporan1.pdf', 'rb') as file:
    pdf_data = file.read()

order_id = 'OR001'
nim = '1302213045'
fasilitas_id = 'SC0004'
tanggal_mulai = '2023-06-04'
tanggal_selesai = '2023-06-05'


cursor = connectToDB.cursor()

insert_query = """
    INSERT INTO Order (order_id, nim, fasilitas_id, tanggal_mulai, tanggal_selesai, file_dokumen)
    VALUES (%s, %s, %s, %s, %s, %s);
"""


cursor.execute(insert_query, (order_id, nim, fasilitas_id, tanggal_mulai, tanggal_selesai, psycopg2.Binary(pdf_data)))
connectToDB.commit()

cursor.close()
connectToDB.close()
