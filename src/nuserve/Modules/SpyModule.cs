using System;
using System.Linq;
using Nancy;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;

namespace nuserve
{
    public class SpyModule : NancyModule
    {
        private Nancy.Response SpyOnParameters(object parameters)
        {
            if (this.Request.Uri.ToString() == "/Packages()")
            {
                Console.WriteLine("caught it");
                return "";
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine().AppendLine("caught request:").AppendLine("-----");
            sb.AppendLine("Request:");

            this.Request.GetType().GetProperties().Each(prop =>
            {
                var val = prop.GetValue(this.Request, null);
                sb.AppendFormat("'{0}' - '{1}'", prop.Name, val).AppendLine();
            });

            sb.AppendLine("Parameters:");
            var dd = parameters as DynamicDictionary;
            dd.GetDynamicMemberNames().Each(name =>
            {
                sb.AppendFormat("'{0}' - '{1}'", name, dd[name]).AppendLine();
            });

            sb.AppendLine("-----").AppendLine();
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }
        public SpyModule()
        {
            Get["/{path}"] = parameters => SpyOnParameters(parameters);
            Post["/{path}"] = parameters => SpyOnParameters(parameters);
        }
    }
}
