using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace SimpleOne.Middlewares;

public class ExceptionMiddleware
{
	private readonly IHostEnvironment env;
	private readonly ILogger<ExceptionMiddleware> _logger;

	public ExceptionMiddleware(IHostEnvironment env, ILogger<ExceptionMiddleware> logger)
	{
		this.env = env;
		_logger = logger;
	}

	public async Task Invoke(HttpContext context)
	{
		var ex = context.Features.Get<IExceptionHandlerFeature>()?.Error;

		if (ex == null) return;

		var problemDetails = new ProblemDetails
			{
				Title = "Ошибка приложения",
			};

			if (env.IsDevelopment())
			{
				problemDetails.Detail = string.IsNullOrWhiteSpace(ex.GetBaseException().Message)
					? ex.GetBaseException().InnerException?.Message
					: ex.GetBaseException().Message;
			}
			else
			{
				problemDetails.Detail = string.IsNullOrWhiteSpace(ex.GetBaseException().Message)
					? ex.GetBaseException().InnerException?.Message
					: ex.GetBaseException().Message;
			}

			context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

			_logger.LogError("Ошибка приложения: {error}", JsonSerializer.Serialize(problemDetails, new JsonSerializerOptions
			{
				Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
			}));

			await context.Response.WriteAsJsonAsync(problemDetails);
	}
}