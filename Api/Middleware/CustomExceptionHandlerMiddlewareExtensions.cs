﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Middleware
{
	public static class CustomExceptionHandlerMiddlewareExtensions
	{
		public static IApplicationBuilder UseCusomExceptionHandler(this
			IApplicationBuilder builder) 
		{
			return builder.UseMiddleware<CustomExceptionHandlerMiddleware>();
		}
	}
}
