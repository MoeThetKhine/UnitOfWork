using DotNet8.UnitOfWork.DTOs.Feature.PageSetting;

namespace DotNet8.UnitOfWork.DTOs.Feature.Blog;

public class BlogListModel
{
	public IEnumerable<BlogModel> DataLst { get; set; }
	public PageSettingModel PageSetting { get; set; }
}
