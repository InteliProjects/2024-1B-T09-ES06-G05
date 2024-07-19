import os
import pandas as pd
import psycopg2

actual_dir = os.getcwd()

# Read normal dataset
path_normal_dataset = os.path.join(actual_dir, "dataset", "dataset.csv")
df_normal = pd.read_csv(path_normal_dataset)

connection = psycopg2.connect(host="silly.db.elephantsql.com", dbname="fybsgwhw", user="fybsgwhw", password="8AkJLYBb4Tn2TxOeny1ticpIicwHxrEA", port=5432)

cursor = connection.cursor()

df_unique_microtheme = df_normal.drop_duplicates(subset='microtheme')

# Populate macrotheme table
for i, row in df_unique_microtheme.iterrows():
    try:    
            cursor.execute("SELECT id FROM macrotheme WHERE name = %s", (row['macrotheme'],))
            id_macrotheme = cursor.fetchone()

            cursor.execute(
            """
                INSERT INTO "microtheme" (id, name, id_Macrotheme)
                VALUES (%s, %s, %s);
            """,
            (i, row['microtheme'], id_macrotheme)
        )
    except:
        pass
connection.commit()
cursor.close()
connection.close()