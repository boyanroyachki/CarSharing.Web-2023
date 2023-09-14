using CarSharing.Data;
using CarSharing.Data.Models;
using CarSharing.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarSharing.Services.Data
{
    public class AgentService : IAgentService
    {
        private readonly ApplicationDbContext data;
        public AgentService(ApplicationDbContext data) => this.data = data;

        //Block 1
        public async Task<bool> AgentExistByIdAsync(string agentId)
        {
            var targetAgent = await this.data.Agents.FirstOrDefaultAsync(x => x.Id.ToString() == agentId);
            return targetAgent != null;
        }

        public async Task<bool> AgentExistByUserIdAsync(string userId)
        {
            var targetAgent = await this.data.Agents.FirstOrDefaultAsync(x => x.UserId.ToString() == userId);
            return targetAgent != null;
        }

		public async Task<string> GetAgentIdByUserIdAsync(string userId)
		{
            Agent agent = await this.data.Agents.FirstOrDefaultAsync(x => x.UserId.ToString() == userId);
            return agent.Id.ToString();
		}
		//
	}
}
