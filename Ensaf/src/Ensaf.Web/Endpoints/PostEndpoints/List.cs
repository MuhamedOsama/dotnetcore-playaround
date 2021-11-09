using Ardalis.ApiEndpoints;
using Ensaf.Core.PostAggregate;
using Ensaf.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Ensaf.Web.Endpoints.PostEndpoints
{
    public class List : BaseAsyncEndpoint
        .WithoutRequest
        .WithResponse<PostListResponse>
    {
        private readonly IReadRepository<Post> _repository;

        public List(IReadRepository<Post> repository)
        {
            _repository = repository;
        }

        [HttpGet("/Posts")]
        [SwaggerOperation(
            Summary = "Gets a list of all Posts",
            Description = "Gets a list of all Posts",
            OperationId = "Post.List",
            Tags = new[] { "PostEndpoints" })
        ]
        public override async Task<ActionResult<PostListResponse>> HandleAsync(CancellationToken cancellationToken)
        {
            var response = new PostListResponse();
            response.Posts = (await _repository.ListAsync()) // TODO: pass cancellation token
                .Select(post => new PostRecord(post.Id, post.Title, post.Body))
                .ToList();

            return Ok(response);
        }
    }
}
