using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstMvcApp.Models
{
    [MetadataType(typeof(userMeta))]
    public partial class user
    {

        public class userMeta
        {
            [DisplayName("نام کاربری")]
            public string username { get; set; }
            public string password { get; set; }
        }
    }
}