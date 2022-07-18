using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksNS.Data
{
    public static class AdventureWorksContextExtension
    {
        public static IServiceCollection AdventureWorksDBContext(
            this IServiceCollection services,
            string strCnx = "Data Source=DESKTOP-3RM6B1F;Initial Catalog=AdventureWorksLT2019;Integrated Security=false;User=sa;Password=12345;")
        {
            services.AddDbContext<AdventureWorksDB>(options => options.UseSqlServer(strCnx));
            return services;
        }
    }
}
