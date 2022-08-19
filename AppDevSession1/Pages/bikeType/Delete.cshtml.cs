using AppDevSession1.Data;
using AppDevSession1.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppDevSession1.Pages.bikeType
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public BikeType BikeType { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            BikeType = _db.BikeType.Find(id);
            //BikeType = _db.BikeType.FirstOrDefault(type => type.Id == id);
            //BikeType = _db.BikeType.SingleOrDefault(type => type.Id == id);
            //BikeType = _db.BikeType.Where(type => type.Id == id).FirstOrDefault();
        }

        public IActionResult OnPost()
        {
            var bikeTypeFromDb = _db.BikeType.Find(BikeType.Id);
            _db.BikeType.Remove(bikeTypeFromDb);
            _db.SaveChanges();

            TempData["delete"] = "Bike deleted successfully";

            return RedirectToPage("Index");

        }

    }
}
