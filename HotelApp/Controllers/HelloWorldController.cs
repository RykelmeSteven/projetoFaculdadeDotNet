using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace HotelApp.Controllers{
    public class HelloWorldController: Controller{

        public IActionResult Index(){
            return View();
        }

        
        public string Welcome(string nome, int id = -1){
            return HtmlEncoder.Default.Encode(
                $"ID: {id} Nome:{nome}"
            );
        }
    }
}