using AppDevSession1.Data;
using AppDevSession1.Migrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BikeType = AppDevSession1.Model.BikeType;

namespace AppDevSession1.Pages.bikeType
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public DbSet<BikeType> bikeTypes { get; set; }

        public int Counter { get; set; } 
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
           bikeTypes = _db.BikeType;
        }

        public void OnPost()
        {

        }
    }
}
