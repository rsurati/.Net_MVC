using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Camp
    {
        [Key]
           public int Cid { get; set; }
            public string Ctopic { get; set; }
            public int Cduration { get; set; }
            public int Srequired { get; set; }

            public string Fileuploaded { get; set; }

    }
}