using System.Collections.Generic;

namespace ME.Sdk.Library.Common.Model
{
    public class PagingResult<T>
    {
        public IList<T> Data { get; set; }
    }
}
