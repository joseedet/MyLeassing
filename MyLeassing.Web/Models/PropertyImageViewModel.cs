using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MyLeassing.Web.Data.Entities;
using Microsoft.AspNetCore.Http;

namespace MyLeassing.Web.Models
{
         
    public class PropertyImageViewModel : PropertyImage
        {
            [Display(Name = "Image")]
            public IFormFile ImageFile { get; set; }
        }
   
}
