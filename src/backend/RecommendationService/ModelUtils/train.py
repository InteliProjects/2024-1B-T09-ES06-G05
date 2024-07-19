from surprise import SVD, Dataset, Reader
import pickle
import pandas as pd

dataset = 'ratings.csv' # Path to the dataset file (CSV format)

# Load the dataset into a pandas DataFrame
df_model = pd.read_csv(dataset)

# Define the rating scale expected by Surprise (from 1 to 5)
reader = Reader(rating_scale=(1, 5))

# Load dataset into Surprise's Dataset format
data = Dataset.load_from_df(df_model[['id_user', 'id_project', 'rating']], reader)

# Build the full training set from the data
trainset = data.build_full_trainset()

# Initialize the SVD (Singular Value Decomposition) model
model = SVD()

# Train the model on the training set
model.fit(trainset)

model_path = './model.pkl'   # Path to save the trained model (pickle format)

# Serialize and save the trained model using pickle
with open(model_path, 'wb') as model_file:
    pickle.dump(model, model_file)

print("Model retrained and saved successfully!")   # Print message confirming successful retraining and saving of the model