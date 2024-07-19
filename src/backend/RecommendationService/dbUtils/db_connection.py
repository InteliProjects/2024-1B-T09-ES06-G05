import psycopg2
from dotenv import load_dotenv
import os

# Load the .env file
load_dotenv()

# Connection information
host = os.getenv("HOST")
dbname = os.getenv("DBNAME")
user = os.getenv("USER")
password = os.getenv("PASSWORD")
port = os.getenv("PORT")

# Function to get a database connection
def get_db_connection():
    return psycopg2.connect(
        host=host,
        dbname=dbname,
        user=user,
        password=password,
        port=port
    )
