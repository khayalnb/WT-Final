using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WT.BLL.Utilities
{
    public static class FileExtension
    {
        public static bool CheckFileType(this IFormFile file, string type)
        {
            return file.ContentType.Contains(type);
        }
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType == "image/jpeg" ||
                file.ContentType == "image/jpg" ||
                file.ContentType == "image/png" ||
                file.ContentType == "image/gif" ||
                file.ContentType == "image/jfif";
        }
        public async static Task<string> PhotoSaveAsync(this IFormFile file, string root, string folder)
        {
            string path = Path.Combine(root, folder);
            string fileName = Path.Combine(Guid.NewGuid().ToString() + Path.GetFileName(file.FileName));
            string resultPath = Path.Combine(path, fileName);
            using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return fileName;
        }

 
        public static bool CheckFileSize(this IFormFile file, int sizekb)
        {
            return file.Length / 1024 <= sizekb; 
        }

        public async static Task<string> SaveFileAsync(this IFormFile file, string root, params string[] folder)
        {
            string filename = Guid.NewGuid().ToString() + "_" + file.FileName;
            string resultPath = Path.Combine(root, folder[0], folder[1], filename);
            using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return filename;
        }
        public static void Delete(string root, string folder, string filename)
        {
            string path = Path.Combine(root, folder, filename);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
