using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLogic.Services.ViewModels
{
    public class CPollViewModel
    {

        public int Codigo { get; set; }

        [StringLength(500)]
        public string Titulo { get; set; }

    }
}
