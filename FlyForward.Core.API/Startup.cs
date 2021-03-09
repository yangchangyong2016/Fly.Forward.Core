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
	///�̳л�����
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

	//	// ����ʱ�����ô˷����� ʹ�ô˷�����������ӵ�������
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
	//				Title = $"{"v1"} �ӿ��ĵ�����{RuntimeInformation.FrameworkDescription}",
	//				Description = $"{"v1"} HTTP API " + "v1",
	//				Contact = new OpenApiContact { Name = "v1", Email = "FlyForward.Core@xxx.com", Url = new Uri("https://neters.club") },
	//				License = new OpenApiLicense { Name = "v1" + " �ٷ��ĵ�", Url = new Uri("http://apk.neters.club/.doc/") }
	//			});
	//			c.OrderActionsBy(o => o.RelativePath);
	//			//c.RoutePrefix = "";
	//		});
	//	}

	//	// ����ʱ�����ô˷����� ʹ�ô˷���������HTTP����ܵ���
	//	public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
	//	{
	//		if (env.IsDevelopment())
	//		{
	//			app.UseDeveloperExceptionPage();
	//			app.UseSwagger();
	//			app.UseSwaggerUI(c =>
	//			{
	//				c.SwaggerEndpoint($"/swagger/V1/swagger.json", $"{"3"} V1");

	//				//·�����ã�����Ϊ�գ���ʾֱ���ڸ�������localhost:8001�����ʸ��ļ�,ע��localhost:8001/swagger�Ƿ��ʲ����ģ�ȥlaunchSettings.json��launchUrlȥ����������뻻һ��·����ֱ��д���ּ��ɣ�����ֱ��дc.RoutePrefix = "doc";
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
