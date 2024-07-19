import requests
import psycopg2
import pytest

# Configurations
API_URL_USER = "http://localhost:5220/users/1"
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
def api_data_user():
    """
    Fixture that makes a GET request to the API and returns the data.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_USER, headers=headers)
    response.raise_for_status()  # Raises an error if the request fails
    return response.json()

def test_api_data_in_db_user(db_connection, api_data_user):
    """
    Integration test that validates if the API data is present and correct in the database.
    """
    cursor = db_connection.cursor()

    item = api_data_user
    cursor.execute("""
        SELECT 
            id, name, enterprise, position, email
        FROM 
            "user"
        WHERE 
            id = %s
    """, (item['id'],))
    db_value = cursor.fetchone()

    # Verifies if the value in the database matches the value in the API
    assert db_value is not None, f"Item com id {item['id']} não encontrado no banco de dados."
    assert db_value[1] == item['name'], f"Nome incorreto para id {item['id']}: esperado {item['name']}, obtido {db_value[1]}"
    assert db_value[2] == item['enterprise'], f"Enterprise incorreto para id {item['id']}: esperado {item['enterprise']}, obtido {db_value[2]}"
    assert db_value[3] == item['position'], f"Position incorreto para id {item['id']}: esperado {item['position']}, obtido {db_value[3]}"
    assert db_value[4] == item['email'], f"Email incorreto para id {item['id']}: esperado {item['email']}, obtido {db_value[4]}"

    cursor.close()
