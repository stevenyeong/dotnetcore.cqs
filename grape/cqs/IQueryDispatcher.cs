using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grape.API
{
    public interface IQueryDispatcher<in T1, T2>
        where T1 : IQueryRequest
        where T2 : IResult
    {
        /// <summary>
        /// Dispatches a query and retrieves a query result
        /// </summary>
        /// <typeparam name="TParameter">Request to execute type</typeparam>
        /// <typeparam name="TResult">Request Result to get back type</typeparam>
        /// <param name="query">Request to execute</param>
        /// <returns>Request Result to get back</returns>
        T2 HandleQuery(T1 request);
            
    }
}
