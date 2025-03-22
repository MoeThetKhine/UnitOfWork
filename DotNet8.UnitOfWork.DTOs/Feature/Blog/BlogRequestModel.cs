﻿namespace DotNet8.UnitOfWork.DTOs.Feature.Blog;

#region BlogRequestModel

public class BlogRequestModel
{
	public string BlogTitle { get; set; } = null!;
	public string BlogAuthor { get; set; } = null!;
	public string BlogContent { get; set; } = null!;
}

#endregion