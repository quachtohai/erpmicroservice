using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.Search
{
    public class SearchResult<TEntity>(
        bool success, string message, IEnumerable<TEntity> result
        )
    {
        public bool Success { get; } = success;
        public string Message { get; } = message;
        public IEnumerable<TEntity> Result { get; } = result;


    }
}
