using DotNet8.UnitOfWork.Utils.Enums;

namespace DotNet8.UnitOfWork.Utils;

public class Result<T>
{
	public T Data { get; set; }
	public string Message {  get; set; }
	public bool IsSuccess {  get; set; }
	public EnumStatusCode StatusCode { get; set; }
}
