using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ViewModels
{
	public enum ResultType
	{
		None,
		Success,
		NotFound,
		BadRequest,
		Unauthorized,
		ServerError,
	}

	public class Result
	{
		public ResultType Type { get; set; }

		public string? Message { get; set; }

		public Result(ResultType type, string? message = null)
		{
			Type = type;
			Message = message;
		}
	}
}
