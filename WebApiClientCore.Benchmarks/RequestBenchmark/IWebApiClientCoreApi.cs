﻿using System.Threading.Tasks;
using WebApiClientCore.Attributes;

namespace WebApiClientCore.Benchmarks.RequestBenchmark
{
    public interface IWebApiClientCoreApi
    {
        [HttpGet("/benchmarks/{id}")]
        Task<Model> GetAsyc([PathQuery] string id);

        [HttpPost("/benchmarks")]
        Task<Model> PostAsync([Parameter(Kind.JsonBody)] Model model);
    }
}
