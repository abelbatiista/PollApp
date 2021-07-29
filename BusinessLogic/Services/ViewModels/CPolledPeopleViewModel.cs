using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLogic.Services.ViewModels
{
    public class CPolledPeopleViewModel
    {

        public int Codigo { get; set; }

        [StringLength(500)]
        public string Nombre { get; set; }

    }
}
