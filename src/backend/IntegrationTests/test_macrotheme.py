import requests
import psycopg2
import pytest

# Configurations
API_URL_MACROTHEMES = "http://localhost:5220/macrothemes"
BEARER_TOKEN = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwibmJmIjoxNzE3Njk0ODUyLCJleHAiOjE3MTgyOTk2NTIsImlhdCI6MTcxNzY5NDg1Mn0.z9_wIyR5n2Yfb3Kae-B1gUWXOYbXkDFfA5iuu5EZziA"
DB_HOST = "silly.db.elephantsql.com"
DB_PORT = "5432"
DB_NAME = "fybsgwhw"
DB_USER = "fybsgwhw"
DB_PASSWORD = "8AkJLYBb4Tn2TxOeny1ticpIicwHxrEA"

@pytest.fixture(scope="module")
def db_connection():
    """
    Fixture that establishes a connection to the database before the tests and closes it after the tests.
    """
    conn = psycopg2.connect(
        host=DB_HOST,
        port=DB_PORT,
        dbname=DB_NAME,
        user=DB_USER,
        password=DB_PASSWORD
    )
    yield conn
    conn.close()

@pytest.fixture
def api_data_macrothemes():
    """
    Fixture that makes a GET request to the API and returns the data.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_MACROTHEMES, headers=headers)
    response.raise_for_status()  # Raises an error if the request fails
    return response.json()

def test_api_data_in_db_macrothemes(db_connection, api_data_macrothemes):
    """
    Integration test that validates if the API data is present and correct in the database.
    """
    cursor = db_connection.cursor()

    for item in api_data_macrothemes:
        cursor.execute("SELECT name FROM macrotheme WHERE id = %s", (item['id'],))
        db_value = cursor.fetchone()

        # Verifies if the value in the database matches the value in the API
        assert db_value is not None, f"Item com id {item['id']} não encontrado no banco de dados."
        assert db_value[0] == item['name'], f"Nome incorreto para id {item['id']}: esperado {item['name']}, obtido {db_value[0]}"

    cursor.close()
API_URL_PROJECTS_BY_MACROTHEME = "http://localhost:5220/macrothemes/6/projects"

@pytest.fixture
def api_data_projects_by_macrotheme():
    """
    Fixture that makes a GET request to the API and returns the data.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_PROJECTS_BY_MACROTHEME, headers=headers)
    response.raise_for_status()  # Raises an error if the request fails
    return response.json()

def test_api_data_in_db_projects_by_macrotheme(db_connection, api_data_projects_by_macrotheme):
    """
    Integration test that validates if the API data is present and correct in the database.
    """
    cursor = db_connection.cursor()

    for item in api_data_projects_by_macrotheme:
        cursor.execute("""
            SELECT name, description, short_description, status FROM project WHERE id = %s
        """, (item['id'],))
        db_value = cursor.fetchone()

        # Verifies if the value in the database matches the value in the API
        assert db_value is not None, f"Item com id {item['id']} não encontrado no banco de dados."
        assert db_value[0] == item['name'], f"Nome incorreto para id {item['id']}: esperado {item['name']}, obtido {db_value[0]}"
        assert db_value[1] == item['description'], f"Descrição incorreta para id {item['id']}: esperado {item['description']}, obtido {db_value[1]}"
        assert db_value[2] == item['shortDescription'], f"Descrição curta incorreta para id {item['id']}: esperado {item['shortDescription']}, obtido {db_value[2]}"
        assert db_value[3] == item['status'], f"Status incorreto para id {item['id']}: esperado {item['status']}, obtido {db_value[3]}"

    cursor.close()
API_URL_MICROTHEMES_BY_MACROTHEME = "http://localhost:5220/macrothemes/6/microthemes"

@pytest.fixture
def api_data_microthemes_by_macrotheme():
    """
    Fixture that makes a GET request to the API and returns the data.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_MICROTHEMES_BY_MACROTHEME, headers=headers)
    response.raise_for_status()  # Raises an error if the request fails
    return response.json()

def test_api_data_in_db_microthemes_by_macrotheme(db_connection, api_data_microthemes_by_macrotheme):
    """
    Integration test that validates if the API data is present and correct in the database.
    """
    cursor = db_connection.cursor()

    for item in api_data_microthemes_by_macrotheme:
        cursor.execute("SELECT name FROM microtheme WHERE id = %s", (item['id'],))
        db_value = cursor.fetchone()

        # Verifies if the value in the database matches the value in the API
        assert db_value is not None, f"Item com id {item['id']} não encontrado no banco de dados."
        assert db_value[0] == item['name'], f"Nome incorreto para id {item['id']}: esperado {item['name']}, obtido {db_value[0]}"

    cursor.close()
