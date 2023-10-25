using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebAppl5
{
    public class QueryModel
    {
        // Add a property to hold error messages
        public string ErrorMessage { get; set; }
        public string SqlQuery { get; set; }
        public DataTable Result { get; set; }
    }

}