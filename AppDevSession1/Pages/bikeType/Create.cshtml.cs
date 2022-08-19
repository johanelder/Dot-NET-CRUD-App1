using AppDevSession1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AppDevSession1.Model;


namespace AppDevSession1.Pages.bikeType
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public BikeType BikeType { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {

                _db.BikeType.Add(BikeType);
                _db.SaveChanges();

                TempData["success"] = "Bike created successfully";

                return RedirectToPage("Index");
            }

            return Page();

        }
    }
}
