using AutoMapper;
using FluentValidation;
using Time_Management.Server.Data.Repositories;
using Time_Management.Server.Models.ViewModels;
using Time_Management.Server.Services.Interfaces;

namespace Time_Management.Server.Services.Implement
{
    public class GoalService : IGoalService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidationService _validationService;
        private readonly IMapper _mapper;

        public GoalService(IUnitOfWork unitOfWork, IValidationService validationService, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _validationService = validationService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GoalViewModel>> GetGoalsAsync(GoalRequestViewModel request)
        {
            // Validate GoalRequestViewModel
            var validationResult = _validationService.Validate(request);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            // Get data            
            var goals = await _unitOfWork.GoalRepository.GetAllAsync(request.PageNumber, request.PageSize);

            // Map to view model
            var goalViewModels = _mapper.Map<IEnumerable<GoalViewModel>>(goals);

            // Return view model
            return goalViewModels;
        }

    }
}
