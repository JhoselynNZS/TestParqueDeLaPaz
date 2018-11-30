using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AnimalController : Controller
    {
        List<Animal> ListDatos = new List<Animal>();

        // GET: Animal
        public ActionResult Index()
        {
            Animal animal1 = new Animal();
            animal1.codigo = 1;
            animal1.nombre = "rana";
            //{"brr", "birip", "brrah", "croac"}
            animal1.sonidos.SetValue(" brr ",   0);
            animal1.sonidos.SetValue(" birip ", 1); 
            animal1.sonidos.SetValue(" brrah ", 2); 
            animal1.sonidos.SetValue(" croac ", 3);
            ListDatos.Add(animal1);

            Animal animal2 = new Animal();
            animal2.codigo = 2;
            animal2.nombre = "libelula";
            //{"fiu", "plop", "pep"}
            animal2.sonidos.SetValue(" fiu ",  0);
            animal2.sonidos.SetValue(" plop ", 1);
            animal2.sonidos.SetValue(" pep ",  2);
            ListDatos.Add(animal2);

            Animal animal3 = new Animal();
            animal3.codigo = 3;
            animal3.nombre = "grillo";
            //{"cric-cric", "trri-trri", "bri-bri"}
            animal3.sonidos.SetValue(" cric-cric ", 0);
            animal3.sonidos.SetValue(" trri-trri ", 1);
            animal3.sonidos.SetValue(" bri-bri ",   2);
            ListDatos.Add(animal3);

            return View(ListDatos);
        }
    }
}