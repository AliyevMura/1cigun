using Microsoft.AspNetCore.Mvc;

namespace WebFirstTask.Controller
{
    public class HomeController
    {
        public string Index(int id) {

            return "detail" + id;
        }


        public ViewResult About()
        {
            ViewResult viewResult = new ViewResult();
            viewResult.ViewName = "Home";
            return viewResult;
        }
    }
}
