import os
import pandas as pd
import psycopg2

actual_dir = os.getcwd()

# Read normal dataset
path_normal_dataset = os.path.join(actual_dir, "dataset", "dataset.csv")
df_normal = pd.read_csv(path_normal_dataset)

connection = psycopg2.connect(host="silly.db.elephantsql.com", dbname="fybsgwhw", user="fybsgwhw", password="8AkJLYBb4Tn2TxOeny1ticpIicwHxrEA", port=5432)

cursor = connection.cursor()

df_unique_macrothemes = df_normal.drop_duplicates(subset='macrotheme')

# Populate macrotheme table
for i, row in df_unique_macrothemes.iterrows():
    try:   
        cursor.execute(
            """
                INSERT INTO "macrotheme" (id, name)
                VALUES (%s, %s);
            """,
            (i, row['macrotheme'])
        )
    except:
       pass
connection.commit()
cursor.close()
connection.close()