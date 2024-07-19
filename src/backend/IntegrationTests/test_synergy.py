import requests
import psycopg2
import pytest

# Configurations
API_URL_SYNERGY = "http://localhost:5220/synergies/59"
API_URL_CREATE_SYNERGY = "http://localhost:5220/synergies"
API_URL_CREATE_SYNERGY_UPDATE = "http://localhost:5220/synergies/59/updates"
API_URL_GET_SYNERGY_UPDATES = "http://localhost:5220/synergies/59/updates"
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
def api_data_synergy():
    """
    Fixture that makes a GET request to the API and returns the data.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_SYNERGY, headers=headers)
    response.raise_for_status()  # Raises an error if the request fails
    return response.json()

def test_api_data_in_db_synergy(db_connection, api_data_synergy):
    """
    Integration test that validates if the API data is present and correct in the database.
    """
    cursor = db_connection.cursor()

    item = api_data_synergy
    cursor.execute("""
        SELECT 
            s.type, s.status, 
            sp.id AS sourceProjectId, sp.name AS sourceProjectName, su.name AS sourceUserName, su.enterprise AS sourceUserEnterprise, smi.name AS sourceMicrotheme, sma.name AS sourceMacrotheme,
            tp.id AS targetProjectId, tp.name AS targetProjectName, tu.name AS targetUserName, tu.enterprise AS targetUserEnterprise, tmi.name AS targetMicrotheme, tma.name AS targetMacrotheme
        FROM 
            synergy s
        JOIN 
            project sp ON s.source_project = sp.id
        JOIN 
            "user" su ON sp.id_user = su.id
        JOIN 
            microtheme smi ON sp.id_microtheme = smi.id
        JOIN 
            macrotheme sma ON smi.id_macrotheme = sma.id
        JOIN 
            project tp ON s.target_project = tp.id
        JOIN 
            "user" tu ON tp.id_user = tu.id
        JOIN 
            microtheme tmi ON tp.id_microtheme = tmi.id
        JOIN 
            macrotheme tma ON tmi.id_macrotheme = tma.id
        WHERE 
            s.id = %s
    """, (item['id'],))
    db_value = cursor.fetchone()

    # Verifies if the value in the database matches the value in the API
    assert db_value is not None, f"Item com id {item['id']} não encontrado no banco de dados."
    assert db_value[0] == item['type'], f"Tipo incorreto para id {item['id']}: esperado {item['type']}, obtido {db_value[0]}"
    assert db_value[1] == item['status'], f"Status incorreto para id {item['id']}: esperado {item['status']}, obtido {db_value[1]}"
    assert db_value[2] == item['sourceProjectId'], f"sourceProjectId incorreto para id {item['id']}: esperado {item['sourceProjectId']}, obtido {db_value[2]}"
    assert db_value[3] == item['sourceProjectName'], f"sourceProjectName incorreto para id {item['id']}: esperado {item['sourceProjectName']}, obtido {db_value[3]}"
    assert db_value[4] == item['sourceUserName'], f"sourceUserName incorreto para id {item['id']}: esperado {item['sourceUserName']}, obtido {db_value[4]}"
    assert db_value[5] == item['sourceUserEnterprise'], f"sourceUserEnterprise incorreto para id {item['id']}: esperado {item['sourceUserEnterprise']}, obtido {db_value[5]}"
    assert db_value[6] == item['sourceMicrotheme'], f"sourceMicrotheme incorreto para id {item['id']}: esperado {item['sourceMicrotheme']}, obtido {db_value[6]}"
    assert db_value[7] == item['sourceMacrotheme'], f"sourceMacrotheme incorreto para id {item['id']}: esperado {item['sourceMacrotheme']}, obtido {db_value[7]}"
    assert db_value[8] == item['targetProjectId'], f"targetProjectId incorreto para id {item['id']}: esperado {item['targetProjectId']}, obtido {db_value[8]}"
    assert db_value[9] == item['targetProjectName'], f"targetProjectName incorreto para id {item['id']}: esperado {item['targetProjectName']}, obtido {db_value[9]}"
    assert db_value[10] == item['targetUserName'], f"targetUserName incorreto para id {item['id']}: esperado {item['targetUserName']}, obtido {db_value[10]}"
    assert db_value[11] == item['targetUserEnterprise'], f"targetUserEnterprise incorreto para id {item['id']}: esperado {item['targetUserEnterprise']}, obtido {db_value[11]}"
    assert db_value[12] == item['targetMicrotheme'], f"targetMicrotheme incorreto para id {item['id']}: esperado {item['targetMicrotheme']}, obtido {db_value[12]}"
    assert db_value[13] == item['targetMacrotheme'], f"targetMacrotheme incorreto para id {item['id']}: esperado {item['targetMacrotheme']}, obtido {db_value[13]}"

    cursor.close()

@pytest.fixture
def api_create_synergy():
    """
    Fixture that makes a POST request to the API to create a synergy.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    data = {
        "sourceProject": 9,
        "targetProject": 8,
        "type": "string",
        "status": "string"
    }
    response = requests.post(API_URL_CREATE_SYNERGY, headers=headers, json=data)
    response.raise_for_status()  # Raises an error if the request fails
    return response.json()

def test_api_create_synergy(db_connection, api_create_synergy):
    """
    Integration test that validates if the synergy was created correctly in the database.
    """
    cursor = db_connection.cursor()

    synergy_id = api_create_synergy
    cursor.execute("SELECT type, status FROM synergy WHERE id = %s", (synergy_id,))
    db_value = cursor.fetchone()

    # Verifies if the value in the database matches the value in the API
    assert db_value is not None, f"Sinergia com id {synergy_id} não encontrada no banco de dados."
    assert db_value[0] == "string", f"Tipo incorreto para id {synergy_id}: esperado 'string', obtido {db_value[0]}"
    assert db_value[1] == "string", f"Status incorreto para id {synergy_id}: esperado 'string', obtido {db_value[1]}"

    cursor.close()

@pytest.fixture
def api_create_synergy_update():
    """
    Fixture that makes a POST request to the API to create a synergy update.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    data = {
        "title": "string",
        "description": "string"
    }
    response = requests.post(API_URL_CREATE_SYNERGY_UPDATE, headers=headers, json=data)
    response.raise_for_status()  # Raises an error if the request fails
    return response.json()

def test_api_create_synergy_update(db_connection, api_create_synergy_update):
    """
    Integration test that validates if the synergy update was created correctly in the database.
    """
    cursor = db_connection.cursor()

    update_id = api_create_synergy_update
    cursor.execute("SELECT title, description FROM update WHERE id = %s", (update_id,))
    db_value = cursor.fetchone()

    # Verifies if the value in the database matches the value in the API
    assert db_value is not None, f"Atualização de sinergia com id {update_id} não encontrada no banco de dados."
    assert db_value[0] == "string", f"Título incorreto para id {update_id}: esperado 'string', obtido {db_value[0]}"
    assert db_value[1] == "string", f"Descrição incorreta para id {update_id}: esperado 'string', obtido {db_value[1]}"

    cursor.close()

@pytest.fixture
def api_data_synergy_updates():
    """
    Fixtures that makes a GET request to the API and returns the data.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_CREATE_SYNERGY_UPDATE, headers=headers)
    response.raise_for_status()  # Raises an error if the request fails
    return response.json()

def test_api_data_in_db_synergy_updates(db_connection, api_data_synergy_updates):
    """
    Integration test that validates if the API data is present and correct in the database.
    """
    cursor = db_connection.cursor()

    for item in api_data_synergy_updates:
        cursor.execute("SELECT title, description, datetime FROM update WHERE id = %s", (item['id'],))
        db_value = cursor.fetchone()

        # Verifica se o valor no banco de dados corresponde ao valor da API
        assert db_value is not None, f"Atualização de sinergia com id {item['id']} não encontrada no banco de dados."
        assert db_value[0] == item['title'], f"Título incorreto para id {item['id']}: esperado {item['title']}, obtido {db_value[0]}" 
        assert db_value[1] == item['description'], f"Descrição incorreta para id {item['id']}: esperado {item['description']}, obtido {db_value[1]}"
        assert db_value[2].isoformat() == item['datetime'], f"Data incorreta para id {item['id']}: esperado {item['datetime']}, obtido {db_value[2].isoformat()}"

    cursor.close()
