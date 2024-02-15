using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class dCandidate
    {

        [Key]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string fullName { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string mobile { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string email { get; set; }

        [Column(TypeName = "nvarchar(3)")]
        public string bloodGroup { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string address { get; set; }

    }
}
