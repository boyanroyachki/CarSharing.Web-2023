using AutoMapper;

namespace CarSharing.Services.Mapping.Interfaces
{
    public interface IHaveCustomMappings
    {
        void CreateMappings(IProfileExpression configuration);
    }
}
