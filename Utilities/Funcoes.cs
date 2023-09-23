using System;
using System.Collections.Generic;
using System.IO;
namespace Funcoes
{

    public class FuncoesUtils
    {
        public static List<string> ListAllFilesInDirectoryAndSubdirectories(string rootDirPath, string searchPattern)

        {
            List<string> sparseList = new List<string>();
            var dir = new DirectoryInfo(rootDirPath);
            if (!dir.Exists)
            {
                Console.WriteLine("Directory doesn't exists: " + dir.ToString());
                return null;
            }
            DirectoryInfo sourceDir = new DirectoryInfo(rootDirPath);

            FileInfo[] files = sourceDir.GetFiles(searchPattern);  //Get only files which you need to work with.
            foreach (var myFile in files)
            {
                try
                {
                    Console.WriteLine("Filename:" + myFile.FullName);
                    Console.WriteLine("Filesize:" + myFile.Length);
                    sparseList.Add(myFile.FullName);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            /*
            DirectoryInfo[] subDirectories = sourceDir.GetDirectories();    //Get subdirectories
            foreach (var subDirectory in subDirectories)
            {
                ListAllFilesInDirectoryAndSubdirectories(subDirectory.FullName, searchPattern);
            }*/

            return sparseList;
        }
    }




}

