from ModelUtils.load import load_model
from dbUtils.queries import query_all_users, query_all_projects
from ModelUtils.recommendations import generate_and_save_recommendations
from dbUtils.insert_recommendations import insert_data

# Main flow - generate new recommendations
if __name__ == "__main__":
    model = load_model('./ModelUtils/model.pkl')
    
    all_users = query_all_users()
    all_projects = query_all_projects()
    prediction_sorted = generate_and_save_recommendations(model, all_users, all_projects)
    insert_data(prediction_sorted)
    print("Finished!New recommendations have been generated and saved in the database.")