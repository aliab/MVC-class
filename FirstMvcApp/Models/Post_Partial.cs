using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstMvcApp.Models
{
    [MetadataType(typeof(postMeta))]
    public partial class post
    {
        [DisplayName("Mark")]
        public int Mark { get; set; }
    }



    public partial class postMeta
    {
        [DisplayName("عنوان")]
        public string title { get; set; }


        public string content { get; set; }


        public int MyProp { get; set; }
    }
}