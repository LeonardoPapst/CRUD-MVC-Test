using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_MVC_Test.Models
{
    public class ViewModel
    {
        public Pessoa Pessoa { get; set; }
        public IEnumerable<Pessoa> Pessoas { get; set; }
    }
}