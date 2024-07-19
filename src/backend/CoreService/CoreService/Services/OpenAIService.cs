using OpenAI_API;
using OpenAI_API.Chat;
using System.Threading.Tasks;

namespace CoreService.Services
{
    // Represents a service for generating project descriptions using OpenAI API.
    public class OpenAIService : IOpenAIService
    {
        private readonly OpenAIAPI _openAIAPI;

        // Initializes a new instance of the OpenAIService class.
        public OpenAIService(IConfiguration configuration)
        {
            _openAIAPI = new OpenAIAPI(configuration["OpenAI:ApiKey"]);
        }

        // Generates a project description based on the project name and details.
        public async Task<string> GenerateProjectDescription(string projectName, string projectDetails)
        {
            var chat = _openAIAPI.Chat.CreateConversation();

            chat.Model = "gpt-4-turbo";

            chat.RequestParameters.Temperature = 0;
            
            chat.RequestParameters.MaxTokens = 500;

            chat.AppendSystemMessage("Você é um assistente que gera descrições de projetos limpas e profissionais para uma plataforma de rede social para CEOs. Certifique-se de que as descrições estão formatadas sem quaisquer aspas, barras ou caracteres incomuns. O conteúdo retornado deve ser diretamente a descrição, sem cabeçalhos. Para quebra de linha inclua '\n'");

            chat.AppendUserInput($"Gere uma descrição do projeto com base nos seguintes detalhes.Nome do Projeto: {projectName}. Detalhes do Projeto: {projectDetails}");

            var response = await chat.GetResponseFromChatbotAsync();

            return response;
        }
    }
}
