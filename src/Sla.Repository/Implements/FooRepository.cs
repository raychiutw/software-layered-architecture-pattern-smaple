using System.Collections.Generic;
using System.Threading.Tasks;
using Sla.Repository.Enities;
using Sla.Repository.Interfaces;

namespace Sla.Repository.Implements
{
    /// <summary>
    /// Class FooRepository.
    /// Implements the <see cref="Sla.Repository.Interfaces.IFooRepository" />
    /// </summary>
    /// <seealso cref="Sla.Repository.Interfaces.IFooRepository" />
    public class FooRepository : IFooRepository
    {
        /// <summary>
        /// 取得 Foo
        /// </summary>
        /// <param name="dto">查詢條件</param>
        /// <returns></returns>
        public async Task<IEnumerable<Foo>> GetAsync(QueryFoo dto)
        {
            // 資料庫實作

            return null;
        }
    }
}