import psycopg2
from psycopg2 import sql

def convert_pdf_to_bytea(file_path):
    with open(file_path, 'rb') as file:
        bytea_data = file.read()
    return bytea_data

def insert_order(connection, order_id, nim, fasilitas_id, tanggal_mulai, tanggal_selesai, file_dokumen):
    try:
        cursor = connection.cursor()
        query = sql.SQL("INSERT INTO Orders (order_id, nim, fasilitas_id, tanggal_mulai, tanggal_selesai, file_dokumen) "
                        "VALUES (%s, %s, %s, %s, %s, %s)")
        cursor.execute(query, (order_id, nim, fasilitas_id, tanggal_mulai, tanggal_selesai, file_dokumen))
        connection.commit()
        print("Data berhasil dimasukkan ke dalam tabel Orders.")
    except (Exception, psycopg2.Error) as error:
        print("Terjadi kesalahan saat memasukkan data ke dalam tabel Orders:", error)

# Konfigurasi koneksi ke database
db_host = "localhost"
db_name = "RentIt"
db_user = "postgres"
db_password = "belajardatabase"

# Informasi order
order_id = "order001"
nim = "1302213045"
fasilitas_id = "SC0004"
tanggal_mulai = "2023-06-15"
tanggal_selesai = "2023-06-17"

# Lokasi file PDF yang ingin diubah menjadi bytea
pdf_file_path = "Laporan1.pdf"

try:
    connection = psycopg2.connect(
        host=db_host,
        database=db_name,
        user=db_user,
        password=db_password
    )
    bytea_data = convert_pdf_to_bytea(pdf_file_path)
    insert_order(connection, order_id, nim, fasilitas_id, tanggal_mulai, tanggal_selesai, bytea_data)
except (Exception, psycopg2.Error) as error:
    print("Terjadi kesalahan saat menghubungkan ke database atau memasukkan data:", error)
finally:
    if connection:
        connection.close()
