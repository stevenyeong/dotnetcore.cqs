using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using grape.API;
using Microsoft.AspNetCore.Mvc;

namespace grape.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IQueryDispatcher<TestReqest, TestResult> testQuery;

        public ValuesController(IQueryDispatcher<TestReqest, TestResult> testQuery)
        {
            this.testQuery = testQuery;
        }


        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var result = this.testQuery.HandleQuery(new TestReqest());


            return new string[] { "value1", "value2", result.Result };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        /// <summary>
        /// This is my test Banana Choco end point
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Todo
        ///     {
        ///        "id": 1,
        ///        "name": "Item1",
        ///        "isComplete": true
        ///     }
        ///
        /// </remarks>
        /// <param name="id">oh my id</param>
        /// <param name="quantity">how many?</param>
        /// <returns></returns>
        [HttpGet("/BananaChoco/{id}")]
        public decimal BananaChoco(int id, int quantity)
        {
            return 0M;
        }
    }
}
