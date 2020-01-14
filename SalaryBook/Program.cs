using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;

namespace SalaryBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //������log����serilog���������
            Log.Logger = new LoggerConfiguration()
                //������־����ļ���Ϊ��debug
                .MinimumLevel.Debug()
                //�����Microsoft����־����С��¼�ȼ�Ϊinfo
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                //���������̨
                .WriteTo.Console()
                //����־���浽�ļ��У����������ֱ�����־��·����������־�ļ���Ƶ�Σ���ǰ��һ��һ���ļ���
                .WriteTo.File(Path.Combine("logs", @"log.txt"), rollingInterval: RollingInterval.Day)
                .CreateLogger();
            CreateHostBuilder(args)
                .UseSerilog()
                .Build()
                .Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
