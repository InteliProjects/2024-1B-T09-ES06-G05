using System.Threading.Tasks;

namespace CoreService.Services
{
    // IOpenAIService interface with methods to interact with the OpenAI API
    public interface IOpenAIService
    {
        Task<string> GenerateProjectDescription(string ProjectName, string ProjectDetails);
    }
}