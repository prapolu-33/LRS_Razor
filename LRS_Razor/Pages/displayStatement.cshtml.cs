using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LRS_Razor.Data;
using LRS_Razor.Models;
using LRS_Razor.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace LRS_Razor.Pages
{
    public class displayStatementModel : PageModel
    {
        public List<StatementInfo> rows { get; set; }


        public static ApplicationDbContext getContext()
        {
            string connectionString = ConfigurationHelper.DefaultConnection;
            var options = new DbContextOptionsBuilder<ApplicationDbContext>();
            options.UseSqlServer(connectionString);
            ApplicationDbContext context = new ApplicationDbContext(options.Options);
            return context;
        }
        public void OnGet()
        {
            using (var _db = getContext())
            {
                rows = _db.StatementInfos.FromSql($"getstatements").ToList();
            }
        }
    }

}
