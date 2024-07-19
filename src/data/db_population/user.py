import os
import pandas as pd
import psycopg2

actual_dir = os.getcwd()

# Read raw dataset
path_raw_dataset = os.path.join(actual_dir, "dataset", "dataset-raw.xlsx")
df_raw = pd.read_excel(path_raw_dataset, sheet_name="ds-c-levels")

# Read normal dataset
path_normal_dataset = os.path.join(actual_dir, "dataset", "dataset.csv")
df_normal = pd.read_csv(path_normal_dataset)

df_normal_ceos = df_normal.groupby("id_owner").size().reset_index(name='counts')

# Manage connection database
df_merged = pd.merge(df_raw, df_normal_ceos, left_on="id", right_on="id_owner", how="inner")

connection = psycopg2.connect(host="silly.db.elephantsql.com", dbname="fybsgwhw", user="fybsgwhw", password="8AkJLYBb4Tn2TxOeny1ticpIicwHxrEA", port=5432)
cursor = connection.cursor()

# Populate user table
for i, row in df_merged.iterrows():
   email = f"{row["proponente"].split(" ")[0]}{i}@gmail.com"
   try:
        cursor.execute(
            """
                INSERT INTO "user" (id, name, enterprise, position, email, password)
                VALUES (%s, %s, %s, %s, %s, %s);
            """,
            (row['id'], row['proponente'], row['nome da empresa'], row['cargo'], email, "User1234")
        )
   except:
       pass

connection.commit()
cursor.close()

connection.close()
