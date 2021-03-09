using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using NetCore.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace FlyForward.Core.API
{
	/// <summary>
	///继承基础的
	/// </summary>
	public class Startup : StartupAbstract
	{
		public Startup(IHostEnvironment env, IConfiguration cfg) : base(env, cfg)
		{
		}
	}
	//public class Startup
	//{
	//	public Startup(IConfiguration configuration)
	//	{
	//		Configuration = configuration;
	//	}

	//	public IConfiguration Configuration { get; }

	//	// 运行时将调用此方法。 使用此方法将服务添加到容器。
	//	public void ConfigureServices(IServiceCollection services)
	//	{
	//		services.AddControllers();
	//		services.AddHttpContextAccessor();
	//		services.AddSwaggerGen(c =>
	//		{
	//			//c.SwaggerDoc("v1", new OpenApiInfo { Title = "Lite.API", Version = "v1" });
	//			c.SwaggerDoc("v1", new OpenApiInfo
	//			{
	//				Version = "v1",
	//				Title = $"{"v1"} 接口文档——{RuntimeInformation.FrameworkDescription}",
	//				Description = $"{"v1"} HTTP API " + "v1",
	//				Contact = new OpenApiContact { Name = "v1", Email = "FlyForward.Core@xxx.com", Url = new Uri("https://neters.club") },
	//				License = new OpenApiLicense { Name = "v1" + " 官方文档", Url = new Uri("http://apk.neters.club/.doc/") }
	//			});
	//			c.OrderActionsBy(o => o.RelativePath);
	//			//c.RoutePrefix = "";
	//		});
	//	}

	//	// 运行时将调用此方法。 使用此方法来配置HTTP请求管道。
	//	public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
	//	{
	//		if (env.IsDevelopment())
	//		{
	//			app.UseDeveloperExceptionPage();
	//			app.UseSwagger();
	//			app.UseSwaggerUI(c =>
	//			{
	//				c.SwaggerEndpoint($"/swagger/V1/swagger.json", $"{"3"} V1");

	//				//路径配置，设置为空，表示直接在根域名（localhost:8001）访问该文件,注意localhost:8001/swagger是访问不到的，去launchSettings.json把launchUrl去掉，如果你想换一个路径，直接写名字即可，比如直接写c.RoutePrefix = "doc";
	//				c.RoutePrefix = "";
	//			});
	//		}

	//		app.UseRouting();

	//		app.UseAuthorization();

	//		app.UseEndpoints(endpoints =>
	//		{
	//			endpoints.MapControllers();
	//		});
	//	}
	//}
}
