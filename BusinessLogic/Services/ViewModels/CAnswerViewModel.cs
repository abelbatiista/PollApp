using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLogic.Services.ViewModels
{
    public class CAnswerViewModel
    {

        public int CodigoEncuesta { get; set; }

        [StringLength(500)]
        public string Persona { get; set; }
        [StringLength(500)]
        public string Pregunta { get; set; }
        [StringLength(500)]
        public string Respuesta { get; set; }

    }
}
