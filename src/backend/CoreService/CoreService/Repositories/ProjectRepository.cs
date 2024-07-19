using System;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using CoreService.Models;
using CoreService.DTOs;

namespace CoreService.Repositories
{
    // Delares a public class named ProjectRepository that implements the IProjectRepository interface.
    public class ProjectRepository : IProjectRepository
    {
        // IDbAccess object to access the database.
        private readonly IDbAccess _db;

        // Constructor to initialize the ProjectRepository class.
        public ProjectRepository(IDbAccess dbAccess)
        {
            _db = dbAccess;
        }

        // Gets all projects recommended from the database.
        public async Task<IEnumerable<ProjectDTO>> GetRecommendedProjects(int userId)
        {
            var sql = @"
                SELECT
                    p.id,
                    p.name,
                    p.short_description AS shortdescription,
                    p.description,
                    p.status,
                    u.id AS userid,
                    u.name AS user,
                    u.enterprise,
                    mi.name AS microtheme,
                    ma.name AS macrotheme
                FROM
                    recommendation r
                JOIN
                    project p ON r.id_project = p.id
                JOIN
                    ""user"" u ON p.id_user = u.id
                JOIN
                    microtheme mi ON p.id_microtheme = mi.id
                JOIN
                    macrotheme ma ON mi.id_macrotheme = ma.id
                WHERE
                    r.id_user = @UserId;
            ";

            var projects = await _db.QueryAsync<ProjectDTO>(sql, new { UserId = userId });
            return projects;
        }

        // Gets a project by its id from the database.
        public async Task<ProjectDTO> GetProjectById(int projectId)
        {
            var sql = @"SELECT 
                           p.id, 
                           p.name, 
                           p.short_description AS shortdescription, 
                           p.description, 
                           p.status, 
                           u.id AS userid,
                           u.name AS user, 
                           u.enterprise, 
                           mi.name AS microtheme, 
                           ma.name AS macrotheme
                        FROM 
                           project p
                        JOIN 
                           ""user"" u ON p.id_user = u.id
                        JOIN 
                           microtheme mi ON p.id_microtheme = mi.id
                        JOIN 
                           macrotheme ma ON mi.id_macrotheme = ma.id
                        WHERE 
                           p.id = @ProjectId;
";
            var result = await _db.QueryFirstOrDefaultAsync<ProjectDTO>(sql, new { ProjectId = projectId });

            if (result == null)
            {
                return null;
            }

            return result;
        }

        // Creates a new project in the database. It returns the id of the newly created project.
        public async Task<int?> CreateProject(ProjectModel projectModel)
        {
            var sql = @"
        INSERT INTO project (name, description, short_description, status, id_user, id_microtheme)
        VALUES (@Name, @Description, @ShortDescription, @Status, @UserId, @MicrothemeId)
        RETURNING id;
    ";
            var id = await _db.ExecuteScalarAsync<int?>(sql, new
            {
                Name = projectModel.Name,
                Description = projectModel.Description,
                ShortDescription = projectModel.ShortDescription,
                Status = projectModel.Status,
                UserId = projectModel.UserId,
                MicrothemeId = projectModel.MicrothemeId
            });
            return id;
        }

        // Checks if a project exists
        public async Task<bool> ProjectExists(int projectId)
        {
            var sql = @"SELECT COUNT(1) FROM project WHERE id = @ProjectId";
            var count = await _db.ExecuteScalarAsync<int>(sql, new { ProjectId = projectId });
            return count > 0;
        }

        // Updates an existing project in the database. 
        public async Task<bool> UpdateProject(int projectId, ProjectUpdateModel projectUpdateModel)
        {
            var sql = @"
                UPDATE project
                SET name = @Name, description = @Description, short_description = @ShortDescription, status = @Status
                WHERE id = @ProjectId
                RETURNING *
            ";

            var rowsAffected = await _db.ExecuteAsync(sql, new
            {
                ProjectId = projectId,
                Name = projectUpdateModel.Name,
                Description = projectUpdateModel.Description,
                ShortDescription = projectUpdateModel.ShortDescription,
                Status = projectUpdateModel.Status
            });

            return rowsAffected > 0;
        }

        // Gets synergies by project id from the database. 
        public async Task<IEnumerable<ProjectSynergyDTO>> GetSynergiesByProjectId(int projectId)
        {
            var sql = @"
                SELECT
                    s.id,
                    s.type,
                    s.status,
                    p.id AS ProjectId,
                    p.name AS ProjectName,
                    u.name AS UserName,
                    u.enterprise AS UserEnterprise,
                    mi.name AS Microtheme,
                    ma.name AS Macrotheme
                FROM
                    synergy s
                JOIN
                    project p ON (s.source_project = p.id OR s.target_project = p.id) AND p.id != @ProjectId
                JOIN
                    ""user"" u ON p.id_user = u.id
                JOIN
                    microtheme mi ON p.id_microtheme = mi.id
                JOIN
                    macrotheme ma ON mi.id_macrotheme = ma.id
                WHERE
                    s.source_project = @ProjectId OR s.target_project = @ProjectId;

            ";

            return await _db.QueryAsync<ProjectSynergyDTO>(sql, new { ProjectId = projectId });
        }

        // Adds a rating to a project in the database. It returns the id of the newly created rating.
        public async Task<int?> AddRatingToProject(int projectId, RatingModel ratingModel)
        {
            var sql = @"
                INSERT INTO Interest (rating, datetime, id_User, id_Project)
                VALUES (@Rating, @Datetime, @UserId, @ProjectId)
                RETURNING id
            ";

            var id = await _db.ExecuteScalarAsync<int?>(sql, new
            {
                Rating = ratingModel.Rating,
                Datetime = DateTime.Now,
                UserId = ratingModel.UserId,
                ProjectId = projectId
            });

            return id;
        }

        // Deletes a project from the database. It returns true if the project was successfully deleted.
        public async Task<bool> DeleteProject(int projectId)
        {
            var sql = @"DELETE FROM project WHERE id = @ProjectId";
            var rowsAffected = await _db.ExecuteAsync(sql, new { ProjectId = projectId });
            return rowsAffected > 0;
        }

        public async Task<RatingDTO> GetRatingByProjectAndUser(int projectId, int userId)
        {
            var sql = @"
                SELECT 
                    id, 
                    rating, 
                    datetime
                FROM 
                    interest 
                WHERE 
                    id_project = @ProjectId 
                    AND id_user = @UserId;
            ";
            return await _db.QueryFirstOrDefaultAsync<RatingDTO>(sql, new { ProjectId = projectId, UserId = userId });
        }

        public async Task<IEnumerable<ProjectDTO>> GetProjectsByUserId(int userId)
        {
            var sql = @"
                SELECT 
                    p.id, 
                    p.name, 
                    p.short_description AS shortdescription, 
                    p.description, 
                    p.status, 
                    u.name AS user, 
                    u.enterprise, 
                    mi.name AS microtheme, 
                    ma.name AS macrotheme
                FROM 
                    project p
                JOIN 
                    ""user"" u ON p.id_user = u.id
                JOIN 
                    microtheme mi ON p.id_microtheme = mi.id
                JOIN 
                    macrotheme ma ON mi.id_macrotheme = ma.id
                WHERE 
                    p.id_user = @UserId;
            ";

            return await _db.QueryAsync<ProjectDTO>(sql, new { UserId = userId });
        }
    }

}