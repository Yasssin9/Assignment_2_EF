using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_EntityFramework.Model
{
    public class Course_Inst
    {
   
        public int Inst_Id { get; set; }
        public int Course_Id { get; set; }
        public string? Evaluate { get; set; }
    }
}
