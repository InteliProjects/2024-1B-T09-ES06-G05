using CoreService.DTOs;
using CoreService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreService.Repositories
{
    // ISynergyRepository interface with methods to query the database 
    public interface ISynergyRepository
    {
        Task<bool> SynergyExistsByProjectsIds(int sourceProjectId, int targetProjectId);
        Task<int?> CreateSynergy(SynergyModel synergy);
        Task<SynergyDTO> GetSynergyById(int synergyId);
        Task<bool> SynergyExistsBySynergyId(int synergyId);
        Task<int?> CreateSynergyUpdate(int synergyId, SynergyUpdateModel synergyUpdateModel);
        Task<IEnumerable<SynergyUpdateDTO>> GetUpdatesBySynergyId(int synergyId);
    }
}
