using System.Collections.Generic;
using ServiceStack;

namespace TestMVCSite.Models
{
    [Route("/regions", "GET")]
    public class Regions : IReturn<RegionsResponse>
    {
    }

    public class RegionsResponse : IHasResponseStatus
    {
        public List<Region> data { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }

    public class Region
    {
        public string iso { get; set; }
        public string name { get; set; }
    }
}