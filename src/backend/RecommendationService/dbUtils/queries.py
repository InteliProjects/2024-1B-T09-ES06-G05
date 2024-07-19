from dbUtils.db_connection import get_db_connection

# Function to get all users
def query_all_users():
    connection = get_db_connection()
    cursor = connection.cursor()
    
    query = 'SELECT id FROM public."user"'
    cursor.execute(query)
    results = cursor.fetchall()
    
    cursor.close()
    connection.close()
    
    return [result[0] for result in results]

# Function to get all projects
def query_all_projects():
    connection = get_db_connection()
    cursor = connection.cursor()
    
    query = 'SELECT id FROM public."project"'
    cursor.execute(query)
    results = cursor.fetchall()
    
    cursor.close()
    connection.close()
    
    return [result[0] for result in results]
