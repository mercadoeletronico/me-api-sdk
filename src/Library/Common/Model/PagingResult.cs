using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
﻿namespace ME.Sdk.Library.Common.Model
    {
    public class PagingResult<T>
        {
        public IList<T> Data { get; set; }
    }
}
