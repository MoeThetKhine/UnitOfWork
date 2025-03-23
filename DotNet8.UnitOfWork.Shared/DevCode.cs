using Newtonsoft.Json;

namespace DotNet8.UnitOfWork.Shared;

public static class DevCode
{
	public static string ToJson(this object obj) =>
		JsonConvert.SerializeObject(obj, Formatting.Indented);

	public static T ToObject<T>(this string jsonStr) => JsonConvert.DeserializeObject<T>(jsonStr)!;

	public static bool IsNullOrEmpty(this string str) =>
   string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);

}
