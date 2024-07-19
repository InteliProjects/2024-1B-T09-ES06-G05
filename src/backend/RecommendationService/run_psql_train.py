import os
import tempfile
from dotenv import load_dotenv
import subprocess

# Load environment variables from .env file
load_dotenv()

# Get password from environment variable
password = os.getenv('password')

# Define the SQL command
sql_command = (
    "COPY (SELECT id_user, id_project, rating FROM interest) TO STDOUT WITH CSV HEADER;"
)

# Create a temporary file to store the SQL command
with tempfile.NamedTemporaryFile(delete=False, mode='w') as temp_sql_file:
    temp_sql_file.write(sql_command)
    temp_sql_filename = temp_sql_file.name

# Define the psql command to read the SQL file and redirect output to the CSV file
command = (
    f'psql "host=silly.db.elephantsql.com port=5432 dbname=fybsgwhw user=fybsgwhw password={password}" '
    f'< "{temp_sql_filename}" > "C:\\Users\\Inteli\\Documents\\2024-1B-T09-ES06-G05\\src\\backend\\RecommendationService\\ModelUtils\\ratings.csv"'
)

# Execute the psql command
try:
    subprocess.run(command, shell=True, check=True)
    print("psql command executed successfully")
except subprocess.CalledProcessError as e:
    print(f"Error executing psql command: {e}")

# Remove the temporary SQL file after execution
os.remove(temp_sql_filename)
