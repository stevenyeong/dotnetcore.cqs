using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grape.API
{
    public class TestHandler : IQueryDispatcher<TestReqest, TestResult>
    {
        public TestResult HandleQuery(TestReqest request)
        {
            return new TestResult()
            {
                Result = "Ok jor"
            };
        }
    }
}
