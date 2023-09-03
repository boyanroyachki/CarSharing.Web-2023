namespace CarSharing.Services.Data.Interfaces
{
    public interface IAgentService
    {
        //block 1
        // Agent exist by userId and by agentId
        //both async
        Task<bool> AgentExistByIdAsync(string agentId);
        Task<bool> AgentExistByUserIdAsync(string userId);
        //
    }
}
