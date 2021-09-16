using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAppTest.Models
{
    public class TestModel
    {
        [Range(0,100)]
        [Display(Name = "First Number")]
        public int FirstNumber { get; set; }
        [Range(0,100)]
        [Display(Name = "Second Number")]
        public int SecondNumber { get; set; }
        [Display(Name = "Operation Type")]
        public string OperationType { get; set; }
    }
}