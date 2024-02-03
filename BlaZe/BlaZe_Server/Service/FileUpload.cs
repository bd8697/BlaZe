using BlaZe_Server.Service.IService;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlaZe_Server.Service
{
    public class FileUpload : IFileUpload
    {

        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IHttpContextAccessor httpContextAccesor;

        public FileUpload(IWebHostEnvironment webHostEnvironmentP, IHttpContextAccessor httpContextAccesorP)
        {
            webHostEnvironment = webHostEnvironmentP;
            httpContextAccesor = httpContextAccesorP;
        }

        public bool DeleteFile(string fileName)
        {
            try
            {
                var path = $"{webHostEnvironment.WebRootPath}\\CarImages\\{fileName}";
                if(File.Exists(path))
                {
                    File.Delete(path);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string> UploadFile(IBrowserFile file)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(file.Name);
                var fileName = Guid.NewGuid().ToString() + fileInfo.Extension;
                var folderDirectory = $"{webHostEnvironment.WebRootPath}\\CarImages";
                var path = Path.Combine(webHostEnvironment.WebRootPath, "CarImages", fileName);

                var memoryStreeam = new MemoryStream();
                await file.OpenReadStream().CopyToAsync(memoryStreeam);

                if(!Directory.Exists(folderDirectory))
                {
                    Directory.CreateDirectory(folderDirectory);
                }

                await using (var stream = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    memoryStreeam.WriteTo(stream);
                }
                var url = $"{httpContextAccesor.HttpContext.Request.Scheme}://{httpContextAccesor.HttpContext.Request.Host.Value}";
                var fullPath = $"{url}/CarImages/{fileName}";
                return fullPath;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
