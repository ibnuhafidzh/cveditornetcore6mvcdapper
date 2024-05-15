using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Xml.Linq;

namespace WebApplication.Models
{
    public class DataModel
    {
        [Column("id")]
        public string? Id { get; set; }

        [Display(Name = "Name")]
        [Column("name")]
        public string Name { get; set; }
        [Display(Name = "Gender")]
        [Column("gender")]
        public string Gender { get; set; }
        [Display(Name = "Nationality")]
        [Column("nationality")]
        public string Nationality { get; set; }
        [Display(Name = "Education")]
        [Column("education")]
        public string Education { get; set; }
        [Display(Name = "Skills")]
        [Column("skills")]
        public string Skills { get; set; }
        [Display(Name = "Experience")]
        [Column("experience")]
        public string Experience { get; set; }
    }

}