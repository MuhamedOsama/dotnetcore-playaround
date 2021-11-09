using Ensaf.Core.ProjectAggregate;
using System.Collections.Generic;

namespace Ensaf.Web.Endpoints.ProjectEndpoints
{
    public class ProjectListResponse
    {
        public List<ProjectRecord> Projects { get; set; } = new();
    }
}
