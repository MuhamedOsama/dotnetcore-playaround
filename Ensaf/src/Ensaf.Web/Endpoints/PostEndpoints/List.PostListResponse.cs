using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ensaf.Web.Endpoints.PostEndpoints
{
    public class PostListResponse
    {
        public List<PostRecord> Posts { get; set; } = new();
    }
}
