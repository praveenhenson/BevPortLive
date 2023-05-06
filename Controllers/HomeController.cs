using BevPort.Models;
using BevPortRevolution.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http.Headers;
using BevPort.Helpers;
using BevPort_Staging.Controllers;

namespace BevPortRevolution.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration configuration;
        private string BaseAddress = "";
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(ILogger<HomeController> logger, IConfiguration _configuration, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            configuration = _configuration;
            BaseAddress = configuration["BaseAddress"];
            _webHostEnvironment = webHostEnvironment;

        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> ContactUs(ContactUs contact)
        {
            ResponseModel objResp = new ResponseModel();
            string webRootPath = _webHostEnvironment.WebRootPath;
            string contentRootPath = _webHostEnvironment.ContentRootPath;


            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://bevportfunctions20230303194850.azurewebsites.net/");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = new HttpResponseMessage();
                    BaseURL BaseURL = new BaseURL();
                    response = await client.PostAsJsonAsync(BaseURL.CreateContactUs, contact).ConfigureAwait(false);

                    if (response.IsSuccessStatusCode)
                    {
                        string result = response.Content.ReadAsStringAsync().Result;

                        string body = string.Empty;
                        string FilePath = webRootPath + @"\EmailTemplates\ContactTemplate.html";
                        StreamReader str = new StreamReader(FilePath);
                        string Content = str.ReadToEnd();
                        str.Close();
                        Content = Content.Replace("#firstname", contact.FIRSTNAME);
                        var result1 = new EmailController().SendEmail(contact.EMAILID!, "BevPort Contact", Content);
                    }
                    else
                    {
                        objResp.ResponseCode = "fail";
                        objResp.ResponseMessage = "Contact us fail.";
                        return Json(objResp);
                    }
                }
                objResp.ResponseCode = "success";
                objResp.ResponseMessage = "Thank you for contacting us, we will connect you soon!";
                return Json(objResp);
            }
            catch (Exception ex)
            {
                objResp.ResponseMessage = "Some Error";
                return Json(objResp);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}