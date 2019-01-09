using Data;
using Microsoft.AspNetCore.Mvc;

namespace Les190107.Controllers
{
    public class CustomerLayerController : Controller
    {

        ICustomer customerData;

        public CustomerLayerController(ICustomer _data)
        { }


        public IActionResult Index()
        {
            var customers = customerData.GetAll();
            return View();
        }
    }
}