using AutoMapper;
using Time_Management.Server.Data.Entities;
using Time_Management.Server.Models.ViewModels;

namespace Time_Management.Server.Configurations
{    
    public class TMAutoMapperProfile : Profile
    {
        public TMAutoMapperProfile()
        {
            // Entity to ViewModel
            CreateMap<Goal, GoalViewModel>();
            CreateMap<Goal, GoalRequestViewModel>();

            // ViewModel to Entity
            CreateMap<GoalViewModel, Goal>();
            CreateMap<GoalRequestViewModel, Goal>();
        }
    }
}
