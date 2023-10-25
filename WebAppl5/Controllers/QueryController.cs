using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace WebAppl5.Controllers
{
    public class QueryController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ExecuteQuery(QueryModel model)
        {
            if (ModelState.IsValid)
            {
                string connectionString = ConfigurationManager.AppSettings["DatabaseConnection"];

                try
                {
                    using (var connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (var command = new SqlCommand(model.SqlQuery, connection))
                        {
                            using (var adapter = new SqlDataAdapter(command))
                            {
                                var result = new DataTable();
                                adapter.Fill(result);
                                model.Result = result;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Store the error message in the model
                    model.ErrorMessage = ex.Message;
                }
            }
            return View("ExecuteQuery", model);
        }
    }
}
