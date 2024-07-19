import pickle

# Function to load the model
def load_model(path='./model.pkl'):
    with open(path, 'rb') as rfile:
        model = pickle.load(rfile)
    return model
