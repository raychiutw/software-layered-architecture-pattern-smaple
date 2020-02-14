using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Sla.Repository.Dto;
using Sla.Repository.Enities;
using Sla.Repository.Interface;
using Sla.Service.Interface;

namespace Sla.Service
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
        public async Task<IEnumerable<FooDto>> Get(QueryFooDto dto)
        {
            // Convert QueryFooDto to QueyFoo
            var queryFoo = this._mapper.Map<QueryFoo>(dto);

            var foo = await this._fooRepository.Get(queryFoo);

            // Convert Foo to FooDto
            var fooDtos = this._mapper.Map<IEnumerable<FooDto>>(foo);

            return fooDtos;
        }
    }
}