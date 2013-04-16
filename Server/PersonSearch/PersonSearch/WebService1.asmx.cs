using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PersonSearch
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://localhost/PersonWebService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        PersonList listOfPersons = new PersonList();

        [WebMethod]
        public List<Person> search(string searchString)
        {
            return listOfPersons.search(searchString);
        }

        [WebMethod]
        public List<Person> getAll()
        {
            return listOfPersons.getAllPersons();
        }

    }
}
