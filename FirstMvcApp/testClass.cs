using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMvcApp
{
    public class Shape2{

    }
    public class Shape
    {
        public int a { get; set; }
        public int b { get; set; }


        private static Shape Add(Shape s1, Shape s2)
        {
            return new Shape { a = s1.a + s2.a };
        }

        public static Shape AddShape(Shape s1, Shape s2)
        {
            return s1 + s2;
        }

        public static Shape operator +(Shape s1, Shape s2)
        {
            Shape2 sh2 =s1;
            return Add(s1, s2);
        }

        public static implicit operator Shape2(Shape s1)
        {
            return new Shape2 { };
        }


    }
}