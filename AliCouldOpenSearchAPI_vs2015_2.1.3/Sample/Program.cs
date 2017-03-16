using System;
using AliCloudOpenSearch.com.API;
using AliCloudOpenSearch.com.API.Builder;

namespace Sample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
			const string client_id = "LTAIPjkCtjCZvCIL";
			const string secret_id = "giDKCpKxO4Cu6HPLGxOKSD5ubJpsxg";

			var apiclient = new CloudsearchApi(client_id, secret_id, "http://opensearch-cn-hangzhou.aliyuncs.com");
            var search = new CloudsearchSearch(apiclient);

	        var doc = new CloudsearchDoc("SUSHI_TEST", apiclient);

			doc.Add()

            var builder = new QueryBuilder();
			builder.ApplicationNames("SUSHI_TEST")
                .Query(new Query("云").And(new Query("搜索")))
                .Config(new Config().Format(ReponseFormat.Json));

            var result = search.Search(builder);
            Console.WriteLine(result);

            Console.Read();
        }
    }
}