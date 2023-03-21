using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GiangKhaiMinh_2011062641_BigSchool.Startup))]
namespace GiangKhaiMinh_2011062641_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
