using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Image_Delocator
{
    public static class ProjectFolders
    {

        public static string Desktop()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
        }

        public static string ConfigFolder(string subfolders = null)
        {
            string thisPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                              @"\Image-Delocator\Program Config\";
            if (subfolders != null)
            {
                thisPath += subfolders;
            }
            return thisPath;
        }

        public static string ImagesFolder()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Image-Delocator\Images\";
        }

        public static void CreateCommonFolder()
        {
            try
            {
                DirectoryInfo configDirectory = Directory.CreateDirectory(ConfigFolder());
                DirectoryInfo imagesDirectory = Directory.CreateDirectory(ImagesFolder());
            }
            catch (Exception)
            {
            }

        }
        public static void CreateCommonFolder(string path = null)
        {
            try
            {
                if (path != null)
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }
            }
            catch (Exception)
            {
            }

        }

        public static void CreateCommonFolder(IList<string> paths = null)
        {
            try
            {
                if (paths != null)
                    foreach (var path in paths)
                    {
                        DirectoryInfo di = Directory.CreateDirectory(path);
                    }
            }
            catch (Exception)
            {
            }

        }

    }
}
