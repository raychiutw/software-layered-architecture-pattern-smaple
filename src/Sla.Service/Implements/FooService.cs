using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Sla.Repository.Dtos;
using Sla.Repository.Enities;
using Sla.Repository.Interfaces;
using Sla.Service.Interfaces;

namespace Sla.Service.Implements
{
    /// <summary>
    ///
    /// </summary>
    public class FooService : IFooService
    {
        private IFooRepository _fooRepository;
        private IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="FooService"/> class.
        /// </summary>
        public FooService(
            IFooRepository fooRepository,
            IMapper mapper)
        {
            this._fooRepository = fooRepository;
            this._mapper = mapper;
        }

        /// <summary>
        /// 取得 Foo
        /// </summary>
        /// <param name="dto">查詢條件</param>
        /// <returns></returns>
        public async Task<IEnumerable<FooDto>> GetAsync(QueryFooDto dto)
        {
            // Convert QueryFooDto to QueyFoo
            var queryFoo = this._mapper.Map<QueryFoo>(dto);

            var foo = await this._fooRepository.GetAsync(queryFoo);

            // Convert Foo to FooDto
            var fooDtos = this._mapper.Map<IEnumerable<FooDto>>(foo);

            return fooDtos;
        }
    }
}