using DotNet8.UnitOfWork.DTOs.Feature.Blog;

namespace DotNet8.UnitOfWork.Presentation
{
	public static class ChangeModel
	{
		public static TblBlog Change(this BlogRequestModel requestModel)
		{
			return new TblBlog
			{
				BlogTitle = requestModel.BlogTitle,
				BlogAuthor = requestModel.BlogAuthor,
				BlogContent = requestModel.BlogContent,
			};
		}
	}
}
