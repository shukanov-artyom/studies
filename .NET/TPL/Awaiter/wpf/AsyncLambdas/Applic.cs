using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AsyncLambdas
{
    internal class Applic
    {
        private Func<string, Task<int>> lam = Lam;

        private static async Task<int> Lam(string s)
        {
            return (await new WebClient().DownloadDataTaskAsync(s)).Length;
        }

        private static string[] uris =
            new[]
            {
                "www.tut.by",
                "www.onliner.by",
                "www.belgazeta.by"
            };

        public async Task<int> GetTotalLength1()
        {
            Func<string, Task<int>> ff = async u => (await new WebClient().DownloadDataTaskAsync(u)).Length;
            IEnumerable<Task<int>> v = uris.Select(ff);
            int[] r = Task.WhenAll(v).Result;
            return r.Sum();
        }


    }
}
