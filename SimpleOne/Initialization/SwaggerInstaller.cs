using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace SimpleOne.Initialization;

public static class SwaggerInstaller
{
	public static void InstallSwagger(this IServiceCollection services)
	{
		services.AddSwaggerGen(options =>
		{
			options.SwaggerDoc("v1", new OpenApiInfo
			{
				Version = "v1",
				Title = "Треним алгоритмы",
				Description = "Как же мучительно больно вспоминать эти чёртовы алгоритмы перед каждым поиском работы. На предыдущей работе ты мог делить монолит на микросервисы, настраивать работу брокера сообщений, решать проблемы параллелизма при работе с БД, повышать перфоманс всех API в разы и прочий рокетсайнс. Но всё это нахрен никого не будет волновать, если ты не сможешь рассказать и показать работу алгоритма который расписан на тысячах ресурсов в интернете."
			});
			
			var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
			options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
		});
	}

}