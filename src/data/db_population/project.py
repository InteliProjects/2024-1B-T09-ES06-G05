import os
import pandas as pd
import psycopg2

actual_dir = os.getcwd()

# Read normal dataset
path_normal_dataset = os.path.join(actual_dir, "dataset", "dataset.csv")
df_normal = pd.read_csv(path_normal_dataset)

connection = psycopg2.connect(host="silly.db.elephantsql.com", dbname="fybsgwhw", user="fybsgwhw", password="8AkJLYBb4Tn2TxOeny1ticpIicwHxrEA", port=5432)

cursor = connection.cursor()

df_unique_projects = df_normal.drop_duplicates(subset='id_project')

cursor = connection.cursor()

#Populate projects table
for i, row in df_unique_projects.iterrows():
    try:
        cursor.execute("SELECT id FROM microtheme WHERE name = %s", (row['microtheme'],))
        id_microtheme = cursor.fetchone()        
        cursor.execute(
            """
            INSERT INTO project (id, id_User, name, id_microtheme, status, short_description, description)
            VALUES (%s, %s, %s, %s, %s, %s, %s)
            """,
            (row['id_project'], row['id_owner'], row['project_name'], id_microtheme, row['status'], "teste2313", "teste1234")
        )
    except:
        pass
# Commit changes and close connection
connection.commit()
cursor.close()
connection.close()
