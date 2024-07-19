from datetime import datetime
from dbUtils.db_connection import get_db_connection
from tqdm import tqdm

# Function to insert data
def insert_data(recommendations):
    connection = get_db_connection()
    cursor = connection.cursor()
        
    insert_query = """
    INSERT INTO Recommendation (score, datetime, status, id_User, id_Project)
    VALUES (%s, %s, %s, %s, %s)
    """

    for user_id, user_recommendations in tqdm(recommendations.items(), desc="Users"):
        for rec in tqdm(user_recommendations, desc="Recommendations", leave=False):
            u_id, p_id, score = rec
            cursor.execute(insert_query, (
                score,
                datetime.now(),
                1,
                u_id,
                p_id
            ))
    
    # Commit and close
    connection.commit()
    cursor.close()
    connection.close()
