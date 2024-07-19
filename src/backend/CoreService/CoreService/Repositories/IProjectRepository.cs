using CoreService.Models;
using CoreService.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreService.Repositories
{
    // IProjectRepository interface with methods to query the database
    public interface IProjectRepository
    {
        Task<IEnumerable<ProjectSynergyDTO>> GetSynergiesByProjectId(int projectId);
        Task<ProjectDTO> GetProjectById(int projectId);
        Task<int?> CreateProject(ProjectModel projectModel);
        Task<int?> AddRatingToProject(int projectId, RatingModel ratingModel);
        Task<bool> UpdateProject(int projectId, ProjectUpdateModel projectUpdateModel);
        Task<bool> ProjectExists(int projectId);
        Task<bool> DeleteProject(int projectId);
        Task<IEnumerable<ProjectDTO>> GetRecommendedProjects(int userId);
        Task<RatingDTO> GetRatingByProjectAndUser(int projectId, int userId);
        Task<IEnumerable<ProjectDTO>> GetProjectsByUserId(int userId);
    }
}
