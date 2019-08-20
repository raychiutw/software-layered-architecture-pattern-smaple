using AutoMapper;
using Sla.Common.Dto;
using Sla.WebApi.Controllers.Parameters;
using Sla.WebApi.Controllers.ViewModels;

namespace Sla.WebApi.Controllers.Infrastructure
{
    /// <summary>
    /// Class ControllerProfile.
    /// Implements the <see cref="AutoMapper.Profile" />
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class ControllerProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerProfile"/> class.
        /// </summary>
        public ControllerProfile()
        {
            this.CreateMap<QueryFooParameter, QueryFooDto>();
            this.CreateMap<FooDto, FooViewModel>();
        }
    }
}