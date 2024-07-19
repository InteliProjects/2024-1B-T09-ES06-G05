import os
import pandas as pd
import psycopg2
from datetime import datetime

actual_dir = os.getcwd()

# Read normal dataset
path_raw_dataset = os.path.join(actual_dir, "dataset", "dataset-raw.xlsx")
df_raw = pd.read_excel(path_raw_dataset, sheet_name="ds-avaliação")

connection = psycopg2.connect(host="silly.db.elephantsql.com", dbname="fybsgwhw", user="fybsgwhw", password="8AkJLYBb4Tn2TxOeny1ticpIicwHxrEA", port=5432)

cursor = connection.cursor()

# Populate macrotheme table
for i, row in df_raw.iterrows():
    # Convert NumPy int64 to Python native int
    rating = int(row['avaliação']) if pd.notna(row['avaliação']) else None
    id_user = int(row['id_proponente']) if pd.notna(row['id_proponente']) else None
    id_project = int(row['id_projeto']) if pd.notna(row['id_projeto']) else None

    try:
        cursor.execute(
            """
                INSERT INTO "interest" (id, rating, datetime, id_User, id_Project)
                VALUES (%s, %s, %s, %s, %s);
            """,
            (i, rating, datetime.now(), id_user, id_project)
        )
    except:
        pass

connection.commit()
cursor.close()
connection.close()