using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using developwithpassion.specifications;
using Machine.Specifications;
using EasyHttp.Http;
using nuserve;
using developwithpassion.specifications.nsubstitue;
using System.Net;
using System.Diagnostics;

namespace nuserve.integration.specs
{
    public class when : Observes<InProcessPackageServer, NancyPackageServer>
    {
        static HttpClient client;

        private static string UrlFor(string rootRelativePath)
        {
            return sut.EndpointUri.ToString().TrimEnd('/') + rootRelativePath;
        }

        Establish context = () =>
        {
            client = new HttpClient();
        };

        Because of = () => sut.Start();

        Cleanup after_each = () =>
        {
            sut.Stop();
        };

        It can_handle_a_post = () =>
       {
           var encoding = "application/x-www-form-urlencoded";
           client.Post(UrlFor("/nancy/drew"), new Dictionary<string, object>(), encoding);
       };
    }
}
