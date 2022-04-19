using Microsoft.AspNetCore.Mvc;
using Core_WebApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Core_WebApp.Controllers
{
    public class FileUploadController : Controller
    {
        IWebHostEnvironment hostEnvironment;
        public FileUploadController(IWebHostEnvironment hostEnvironment)
        {
            this.hostEnvironment = hostEnvironment; 
        }
        public IActionResult Index()
        {
            List<ProfileData> profiles = new List<ProfileData>();
            return View(profiles);
        }

        public IActionResult Upload()
        {
            ProfileData data = new ProfileData();
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Upload(ProfileData data)
        {
            // REad the Current Directtory that is mapped with WebServer
            var folder = Path.Combine(Directory.GetCurrentDirectory(), "UploadedImages");
            // Get the File Objet
            IFormFile file = data.ProfilePicture;
            // Process It
            // Always Check Length of file
            if (file.Length > 0)
            {
                // REad the Uploaded File Name
                var postedFileName = ContentDispositionHeaderValue
                  .Parse(file.ContentDisposition)
                    .FileName.Trim('"');

                // set the file path as FolderName/FileName
                // var finalPath = Path.Combine(folder, postedFileName);
                var finalPath = Path.Combine(hostEnvironment.WebRootPath, "images", postedFileName);
                using (var fs = new FileStream(finalPath, FileMode.Create))
                {
                    // Create a File into the folder
                    await file.CopyToAsync(fs);
                }
                data.UploadStatus = "File is Uploaded Successfully";
                data.FileName = file.FileName;
            }
            else
            {
                data.UploadStatus = "File is Upload Failed";
            }
            return View(data);
        }
    }
}
