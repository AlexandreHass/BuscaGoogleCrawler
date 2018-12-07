using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BuscaGoogle.Models
{
    public class Resultado
    {
        public string Titulo { get; set; }

        public string Link { get; set; }

    }
}