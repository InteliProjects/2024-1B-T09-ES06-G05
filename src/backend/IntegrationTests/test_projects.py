import requests
import psycopg2
import pytest

# Configurations
API_URL_RATING = "http://localhost:5220/projects/1/users/1/ratings"
API_URL_CREATE_PROJECT = "http://localhost:5220/projects"
API_URL_GENERATE_DESCRIPTION = "http://localhost:5220/projects/generate-description"
API_URL_POST_RATING = "http://localhost:5220/projects/1/ratings"
API_URL_RECOMMENDATIONS = "http://localhost:5220/projects/users/1/recommendations"
API_URL_PROJECT = "http://localhost:5220/projects/3"
API_URL_SYNERGIES = "http://localhost:5220/projects/1/synergies"
API_URL_PROJECTS_BY_USER = "http://localhost:5220/projects/users/1"
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

# Integration tests for Projects

@pytest.fixture
def api_create_project():
    """
    Fixture that makes a POST request to the API to create a project.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    data = {
        "name": "teste",
        "description": "pedro",
        "shortDescription": "pedro",
        "status": "ativo",
        "userId": 1,
        "microthemeId": 6
    }
    response = requests.post(API_URL_CREATE_PROJECT, headers=headers, json=data)
    response.raise_for_status()  # Lança um erro se a requisição falhar
    return response.json()

def test_api_create_project(db_connection, api_create_project):
    """
    Integration test that validates if the project was created correctly in the database.
    """
    cursor = db_connection.cursor()

    project_id = api_create_project
    cursor.execute("SELECT name, description, short_description, status FROM project WHERE id = %s", (project_id,))
    db_value = cursor.fetchone()

    #Verifies if the value in the database matches the value in the API
    assert db_value is not None, f"Projeto com id {project_id} não encontrado no banco de dados."
    assert db_value[0] == "teste", f"Nome incorreto para id {project_id}: esperado 'teste', obtido {db_value[0]}"
    assert db_value[1] == "pedro", f"Descrição incorreta para id {project_id}: esperado 'pedro', obtido {db_value[1]}"
    assert db_value[2] == "pedro", f"Descrição curta incorreta para id {project_id}: esperado 'pedro', obtido {db_value[2]}"
    assert db_value[3] == "ativo", f"Status incorreto para id {project_id}: esperado 'ativo', obtido {db_value[3]}"

    cursor.close()

@pytest.fixture
def api_generate_description():
    """
    Fixture that makes a POST request to the API to generate a project description.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    data = {
        "projectName": "string",
        "projectDetails": "string"
    }
    response = requests.post(API_URL_GENERATE_DESCRIPTION, headers=headers, json=data)
    response.raise_for_status()  # Raises an error if the request fails
    return response.text

def test_api_generate_description(db_connection, api_generate_description):
    """
    Integration test that validates if the project description was generated correctly.
    """
    assert 'Nome do Projeto' in api_generate_description, "Descrição gerada não encontrada na resposta da API."

@pytest.fixture
def api_post_rating():
    """
    Fixture that makes a POST request to the API to add a rating to a project.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    data = {
        "rating": 3,
        "userId": 1
    }
    response = requests.post(API_URL_POST_RATING, headers=headers, json=data)
    response.raise_for_status()  # Raises an error if the request fails
    return response.json()

def test_api_post_rating(db_connection, api_post_rating):
    """
    Integration test that validates if the rating was added correctly to the database.
    """
    cursor = db_connection.cursor()

    rating_id = api_post_rating
    cursor.execute("SELECT rating FROM interest WHERE id = %s", (rating_id,))
    db_value = cursor.fetchone()

    #Vefiries if the value in the database matches the value in the API
    assert db_value is not None, f"Avaliação com id {rating_id} não encontrada no banco de dados."
    assert db_value[0] == 3, f"Rating incorreto para id {rating_id}: esperado '3', obtido {db_value[0]}"

    cursor.close()

@pytest.fixture
def api_data_rating():
    """
    Fixture that makes a GET request to the API and returns the data.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_RATING, headers=headers)
    response.raise_for_status()  # Raises an error if the request fails
    return response.json()

def test_api_data_in_db_rating(db_connection, api_data_rating):
    """
    Integration test that validates if the API data is present and correct in the database.
    """
    cursor = db_connection.cursor()

    item = api_data_rating
    cursor.execute("SELECT rating FROM interest WHERE id = %s", (item['id'],))
    db_value = cursor.fetchone()

    # Verifies if the value in the database matches the value in the API
    assert db_value is not None, f"Item com id {item['id']} não encontrado no banco de dados."
    assert db_value[0] == item['rating'], f"Rating incorreto para id {item['id']}: esperado {item['rating']}, obtido {db_value[0]}"

    cursor.close()

@pytest.fixture
def api_data_recommendations():
    """
    Fixtures that makes a GET request to the API and returns the data.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_RECOMMENDATIONS, headers=headers)
    response.raise_for_status()  # Raises an error if the request fails
    return response.json()

def test_api_data_in_db_recommendations(db_connection, api_data_recommendations):
    """
    Integration test that validates if the API data is present and correct in the database.
    """
    cursor = db_connection.cursor()

    for item in api_data_recommendations:
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

@pytest.fixture
def api_data_project():
    """
    Fixture that makes a GET request to the API and returns the data.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_PROJECT, headers=headers)
    response.raise_for_status()  # Raises an error if the request fails
    return response.json()

def test_api_data_in_db_project(db_connection, api_data_project):
    """
    Integration test that validates if the API data is present and correct in the database.
    """
    cursor = db_connection.cursor()

    item = api_data_project
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

@pytest.fixture
def api_data_synergies():
    """
    Fixtures that makes a GET request to the API and returns the data.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_SYNERGIES, headers=headers)
    response.raise_for_status()  # Raises an error if the request fails
    return response.json()

def test_api_data_in_db_synergies(db_connection, api_data_synergies):
    """
    Integration test that validates if the API data is present and correct in the database.
    """
    cursor = db_connection.cursor()

    for item in api_data_synergies:
        cursor.execute("""
            SELECT type, status FROM synergy WHERE id = %s
        """, (item['id'],))
        db_value = cursor.fetchone()

        # Verifies if the value in the database matches the value in the API
        assert db_value is not None, f"Item com id {item['id']} não encontrado no banco de dados."
        assert db_value[0] == item['type'], f"Tipo incorreto para id {item['id']}: esperado {item['type']}, obtido {db_value[0]}"
        assert db_value[1] == item['status'], f"Status incorreto para id {item['id']}: esperado {item['status']}, obtido {db_value[1]}"

    cursor.close()

@pytest.fixture
def api_data_projects_by_user():
    """
    Fixtures that makes a GET request to the API and returns the data.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_PROJECTS_BY_USER, headers=headers)
    response.raise_for_status()  # Raises an error if the request fails
    return response.json()

def test_api_data_in_db_projects_by_user(db_connection, api_data_projects_by_user):
    """
    Integration test that validates if the API data is present and correct in the database.
    """
    cursor = db_connection.cursor()

    for item in api_data_projects_by_user:
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
