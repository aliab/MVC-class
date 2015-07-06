using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstMvcApp.Models
{
    public class StudentViewModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
    public class Student
    {
        [Required(ErrorMessage="{0} باید حتما وارد شود")]
        [StringLength(40,MinimumLength=10,ErrorMessage="طول نام باید ده تا 40 کاراکتر باشد")]
        [DisplayName("نام")]
        public string Name { get; set; }


        [DisplayName("نام خانوادگی")]
        public string LastName { get; set; }


        [DisplayName("ش دانشجویی")]
        public string Number { get; set; }


        [DisplayName("نمره")]
        [Range(0,40,ErrorMessage="{0} باید بین {1} تا {2} باشد")]
        public int Mark { get; set; }

        public static List<Student> GetAll()
        {
            return new List<Student> { 
            new Student{Name= "Ali", LastName = "Alavi", Number="1254", Mark = 0},
            new Student{Name= "Ali1", LastName = "Alavi1", Number="1252", Mark = 1},
            new Student{Name= "Ali2", LastName = "Alavi2", Number="1253", Mark = 2},
            new Student{Name= "Ali3", LastName = "Alavi3", Number="1255", Mark = 3},
            new Student{Name= "Ali3", LastName = "Alavi3", Number="1255", Mark = 3},
            new Student{Name= "Ali3", LastName = "Alavi3", Number="1255", Mark = 3},
            new Student{Name= "Ali3", LastName = "Alavi3", Number="1255", Mark = 3},
            new Student{Name= "Ali3", LastName = "Alavi3", Number="1255", Mark = 3},
            new Student{Name= "Ali3", LastName = "Alavi3", Number="1255", Mark = 3},
            new Student{Name= "Ali3", LastName = "Alavi3", Number="1255", Mark = 3},
            new Student{Name= "Ali3", LastName = "Alavi3", Number="1255", Mark = 3},
            new Student{Name= "Ali3", LastName = "Alavi3", Number="1255", Mark = 3},
            new Student{Name= "Ali3", LastName = "Alavi3", Number="1255", Mark = 3},
            new Student{Name= "Ali3", LastName = "Alavi3", Number="1255", Mark = 3},
            new Student{Name= "Ali3", LastName = "Alavi3", Number="1255", Mark = 3},
            new Student{Name= "Ali3", LastName = "Alavi3", Number="1255", Mark = 3},
            new Student{Name= "Ali3", LastName = "Alavi3", Number="1255", Mark = 3},
            };
        }


    }


}