using System.Collections.Generic;
using System.Threading.Tasks;
using Sla.Common.Enities;
using Sla.Repository.Interface;

namespace Sla.Repository.Implement
{
    /// <summary>
    /// Class FooRepository.
    /// Implements the <see cref="Sla.Repository.Interface.IFooRepository" />
    /// </summary>
    /// <seealso cref="Sla.Repository.Interface.IFooRepository" />
    public class FooRepository : IFooRepository
    {
        /// <summary>
        /// 取得 Foo
        /// </summary>
        /// <param name="dto">查詢條件</param>
        /// <returns></returns>
        public async Task<IEnumerable<Foo>> Get(QueryFoo dto)
        {
            // 資料庫實作

            return null;
        }
    }
}