

using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.Core
{
    public class JobbManager
    {
        public static string CreateMessage(string title, string message, string alertType)
        {
            var msg = new AlertMessage()
            {
                Title = title,
                Message = message,
                AlertType = alertType
            };
            return JsonConvert.SerializeObject(msg);
        }
        public static string MakeUrl(string url)
        {
            url = url.Replace("I", "i");
            url = url.Replace("İ", "i");
            url = url.Replace("ı", "i");

            url = url.ToLower();

            url = url.Replace("ö", "o");
            url = url.Replace("ğ", "g");
            url = url.Replace("ş", "s");
            url = url.Replace("ü", "u");
            url = url.Replace("ç", "c");

            url = url.Replace(" ", "-");
            url = url.Replace(".", "");

            return url;
        }

        public static string UploadImage(IFormFile file, string url)
        {
            var extension = Path.GetExtension(file.FileName);
            var randomName = $"{url}-{Guid.NewGuid()}{extension}";
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", randomName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            return randomName;
        }
    }
}
