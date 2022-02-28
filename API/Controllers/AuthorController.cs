 using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Contracts;

namespace API.Controllers
{
    [Route("api/author")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IRepositoryManager _repository;

		[HttpGet]
		public IActionResult GetAuthors()
		{
			try
			{
				var companies = _repository.Author.GetAllAuthors(trackChanges: false);

				return Ok(companies);
			}
			catch (Exception ex)
			{
				//_logger.LogError($"Reading exception: {nameof(GetCompanies)} - action {ex}");

				return StatusCode(500, "Internal server error");
			}
		}

	}
}
