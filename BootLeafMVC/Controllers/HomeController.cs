using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;
using BootLeafMVC.Models;
using Dapper;
using Newtonsoft.Json;

namespace BootLeafMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult GetTheatres()
        {

         SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bootleaf"].ConnectionString);
         connection.Open();

         var results = connection.Query<Theatre>("BootLeaf.dbo.spGetTheatres", commandType: CommandType.StoredProcedure).ToList();

         //string json = JsonConvert.SerializeObject(results, Formatting.Indented);

        var theatreGeoJson = new TheatreGeoJson();
        var theatreFeatureList = new List<TheatreFeature>();

        theatreGeoJson.type = "FeatureCollection";
        theatreGeoJson.features = theatreFeatureList;
       
            foreach (var result in results)
            {
                var theatreFeature = new TheatreFeature();


                theatreFeature.type = "Feature";
                theatreFeature.id = result.Id;
                theatreFeature.properties = string.Format("{{\"NAME\":\"{0}\"}}", result.Name);
                theatreFeature.geometry = string.Format("{{\"type\":\"Point\",\"coordinates\":[{0},{1}]}}", result.Longitude, result.Latitude);

                theatreFeatureList.Add(theatreFeature);

            }

           
            string json = JsonConvert.SerializeObject(theatreGeoJson, Formatting.Indented);

         return null; 

        }

    }
}
