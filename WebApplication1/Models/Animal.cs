using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Animal
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string[] sonidos = new string[4];
        //public string[] sonidos { get =>  sonidos; set => sonidos = value; }
    }
}