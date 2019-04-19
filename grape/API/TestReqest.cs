using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grape.API
{
    public class TestReqest : IQueryRequest
    {
        public int ActionId { get; set; }
    }
}
