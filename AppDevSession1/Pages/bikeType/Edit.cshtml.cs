using AppDevSession1.Data;
using AppDevSession1.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppDevSession1.Pages.bikeType
{
    public class EditModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        [BindProperty]
        public BikeType BikeType { get; set; }


        public EditModel(ApplicationDbContext db)
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
            if (ModelState.IsValid)
            {
                //custom validation
               /* if (BikeType.Type.Any(char.IsDigit))
                {
                    ModelState.AddModelError("BikeType.Type", "The Type of the bike Cannot have any digit");
                    return Page();
                } */

                _db.BikeType.Update(BikeType);
                _db.SaveChanges();

                TempData["success"] = "Bike updated successfully";

                return RedirectToPage("Index");


            }
            


            return Page();
        }

            

        

    }
}

   
