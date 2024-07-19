from dbUtils.queries import query_all_users, query_all_projects

# Function to generate and save recommendations
def generate_and_save_recommendations(model, all_users, all_projects):
    recommendations = {}

    for user_id in all_users:
        user_recommendations = []

        for project_id in all_projects:
            prediction = model.predict(user_id, project_id)
            user_recommendations.append((user_id, project_id, prediction.est))

        user_recommendations.sort(key=lambda x: x[2], reverse=True)
        recommendations[user_id] = user_recommendations[:20]  
    
    return recommendations
