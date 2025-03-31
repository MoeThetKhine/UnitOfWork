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

	#region GetBlogsAsync

	[HttpGet]
	public async Task<IActionResult> GetBlogsAsync(int pageNo, int pageSize, CancellationToken cancellationToken)
	{
		var query = _unitOfWork.BlogRepository.Query().Paginate(pageNo, pageSize);
		var lst = await query.ToListAsync(cancellationToken);
		return Ok(lst);
	}

	#endregion

	#region GetBlogByIdAsync

	[HttpGet("{id}")]
	public async Task<IActionResult> GetBlogByIdAsync(int id, CancellationToken cs)
	{
		var blog = await _unitOfWork.BlogRepository
			.Query(b => b.BlogId == id)
			.FirstOrDefaultAsync(cs);

		if(blog is null)
		{
			return NotFound(new { Message = $"Blog with ID{id} not found." });
		}
		return Ok(blog);
	}

	#endregion

	#region CreateBlogAsync

	[HttpPost]
	public async Task<IActionResult> CreateBlogAsync([FromBody] BlogRequestModel newBlog, CancellationToken cancellationToken)
	{
		if (newBlog is null)
		{
			return BadRequest(new { Message = "Invalid blog data." });
		}

		var blogEntity = newBlog.Change();

		await _unitOfWork.BlogRepository.AddAsync(blogEntity,cancellationToken);
		await _unitOfWork.BlogRepository.SaveChangesAsync(cancellationToken);

		return Ok("New Blog is Created");
	}

	#endregion

	#region UpdateBlogAsync

	[HttpPut("{id}")]
	public async Task<IActionResult> UpdateBlogAsync(int id, [FromBody] BlogRequestModel updateBlog, CancellationToken cancellationToken)
	{
		if (updateBlog is null)
		{
			return BadRequest(new { Message = "Invalid blog data." });
		}

		var blogEntity = await _unitOfWork.BlogRepository.Query(x  => x.BlogId == id).FirstOrDefaultAsync(cancellationToken);

		if(blogEntity is null)
		{
			return NotFound(new { Message = $"Blog with ID {id} not found." });
		}

		blogEntity.BlogTitle = updateBlog.BlogTitle;
		blogEntity.BlogAuthor = updateBlog.BlogAuthor;
		blogEntity.BlogContent = updateBlog.BlogContent;

		_unitOfWork.BlogRepository.Update(blogEntity);
		await _unitOfWork.BlogRepository.SaveChangesAsync(cancellationToken);

		return Ok(new { Message = "Blog Updated Successfully.", blogEntity });
	}

	#endregion

	#region DeleteBlogAsync

	[HttpDelete("{id}")]
	public async Task<IActionResult> DeleteBlogAsync(int id, CancellationToken cs)
	{
		var blogEntity = await _unitOfWork.BlogRepository.Query(x => x.BlogId == id).FirstOrDefaultAsync(cs);

		if (blogEntity is null)
		{
			return NotFound(new { Message = $"Blog with ID {id} not found." });
		}

		_unitOfWork.BlogRepository.Delete(blogEntity);
		await _unitOfWork.BlogRepository.SaveChangesAsync(cs);

		return Ok(new { Message = "Blog deleted successfully." });
	}

	#endregion
}
