using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Web_API.Models.Entity
{
    public class Visitor
    {
        [Key]
        public int Passport_Number { get;set; }
        public  string First_Name { get;set; }
        public string Sekond_Name{get; set; }
        public string Patronymic { get; set; }
        public string Phone_Number { get; set; }
        //public string Secret { get; set; }
    }
}