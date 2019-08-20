using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sla.Common.Dto;
using Sla.Service.Interface;
using Sla.WebApi.Controllers.Parameters;
using Sla.WebApi.Controllers.ViewModels;

namespace Sla.WebApi.Controllers
{
    /// <summary>
    /// FooController
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class FooController : ControllerBase
    {
        private IFooService _fooService;
        private IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="FooController"/> class.
        /// </summary>
        public FooController(
            IFooService fooService,
            IMapper mapper)
        {
            this._fooService = fooService;
            this._mapper = mapper;
        }

        /// <summary>
        /// Get Foo
        /// </summary>
        /// <param name="parameter">查詢參數</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<FooViewModel>> Get(QueryFooParameter parameter)
        {
            // Convert FooParameter to QuryFooDto
            var queryFooDto = this._mapper.Map<QueryFooDto>(parameter);

            var fooDto = await this._fooService.Get(queryFooDto);

            // Convert FooDto to FooViewModel
            var fooViewModels = this._mapper.Map<IEnumerable<FooViewModel>>(fooDto);

            return fooViewModels;
        }
    }
}