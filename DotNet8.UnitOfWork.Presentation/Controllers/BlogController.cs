using DotNet8.UnitOfWork.Shared;

namespace DotNet8.UnitOfWork.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogController : ControllerBase
{
	public readonly IUnitOfWork _unitOfWork;

	public BlogController(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}

	[HttpGet]
	public async Task<IActionResult> GetBlogsAsync(int pageNo, int pageSize, CancellationToken cancellationToken)
	{
		var query = _unitOfWork.BlogRepository.Query().Paginate(pageNo, pageSize);
		var lst = await query.ToListAsync(cancellationToken);
		return Ok(lst);
	}
}
