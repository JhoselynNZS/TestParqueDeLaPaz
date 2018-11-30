using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CancionController : Controller
    {
        String NotasCancion = "";
        List<SecuenciaNotas> Combinaciones = new List<SecuenciaNotas>();


        public void SiguienteNota(String NotaInicial)
        {
            int pos = -1;
            for (int i = 0; i < Combinaciones.Count(); i++)
            {
                if (String.Equals(Combinaciones.ElementAt(i).nota, NotaInicial))
                {
                    pos = Combinaciones.ElementAt(i).codSigNota;
                    if (pos >= 0)
                        NotasCancion = NotasCancion + Combinaciones.ElementAt(pos).nota + "  ";
                }
            }

            if (pos >= 0)
            {
                NotaInicial = Combinaciones.ElementAt(pos).nota;
                SiguienteNota(NotaInicial);
            }
        }


        // GET: Cancion
        public ActionResult Index(String nota)
        {
            string NotaInicial = nota;

            SecuenciaNotas secuencia1 = new SecuenciaNotas();
            secuencia1.codigo = 0; secuencia1.nota = "brr"; secuencia1.codSigNota = 1;
            Combinaciones.Add(secuencia1);

            SecuenciaNotas secuencia2 = new SecuenciaNotas();
            secuencia2.codigo = 1; secuencia2.nota = "fiu"; secuencia2.codSigNota = 2;
            Combinaciones.Add(secuencia2);

            SecuenciaNotas secuencia3 = new SecuenciaNotas();
            secuencia3.codigo = 2; secuencia3.nota = "cric-cric"; secuencia3.codSigNota = 8;
            Combinaciones.Add(secuencia3);

            SecuenciaNotas secuencia4 = new SecuenciaNotas();
            secuencia4.codigo = 3; secuencia4.nota = "pep"; secuencia4.codSigNota = 4;
            Combinaciones.Add(secuencia4);

            SecuenciaNotas secuencia5 = new SecuenciaNotas();
            secuencia5.codigo = 4; secuencia5.nota = "birip"; secuencia5.codSigNota = 5;
            Combinaciones.Add(secuencia5);

            SecuenciaNotas secuencia6 = new SecuenciaNotas();
            secuencia6.codigo = 5; secuencia6.nota = "trri-trri"; secuencia6.codSigNota = 9;
            Combinaciones.Add(secuencia6);

            SecuenciaNotas secuencia7 = new SecuenciaNotas();
            secuencia7.codigo = 6; secuencia7.nota = "bri-bri"; secuencia7.codSigNota = 7;
            Combinaciones.Add(secuencia7);

            SecuenciaNotas secuencia8 = new SecuenciaNotas();
            secuencia8.codigo = 7; secuencia8.nota = "plop"; secuencia8.codSigNota = 2;
            Combinaciones.Add(secuencia8);

            SecuenciaNotas secuencia9 = new SecuenciaNotas();
            secuencia9.codigo = 8; secuencia9.nota = "brrah"; secuencia9.codSigNota = -1;
            Combinaciones.Add(secuencia9);

            SecuenciaNotas secuencia10 = new SecuenciaNotas();
            secuencia10.codigo = 9; secuencia10.nota = "croac"; secuencia10.codSigNota = -1;
            Combinaciones.Add(secuencia10);

            SiguienteNota(NotaInicial);

            ViewData["cancion"] = NotasCancion;

            return View();
        }



    }
}