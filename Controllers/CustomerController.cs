using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using WebApplication4.Date;

namespace WebApplication4.Controllers
{
    public class CustomerController : Controller
    {
        public CustomerController()
        {
        }
        public class CustomerHomeController : Controller
        {
            private readonly MVCDBContext mvcDBContext;

            public CustomerHomeController(MVCDBContext mvcDBContex)
            {
                this.mvcDBContext = mvcDBContex;
            }

            [HttpGet]
            public async Task<IActionResult> ListCust()
            {
                var customers = await mvcDBContext.Customers.ToListAsync();
                return View(customers);
            }

        }
    }
    
}
