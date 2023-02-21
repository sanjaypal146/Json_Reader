using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Json_Reader
{
    class Logic
    {
        public static string GetFilePath()
        {
            var dialog = new OpenFileDialog();
            FileDetails fileDetails = new FileDetails();
            dialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            dialog.FilterIndex = 1;
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)

            {
                fileDetails.fileNamePath = dialog.FileName;
            }
            else
            {
                fileDetails.fileNamePath = string.Empty;
            }
            return fileDetails.fileNamePath;
        }
        
        public static List<Root> LineDeserialize(string path)
        {
            List<Root> rootList = new List<Root>();
            foreach (string line in File.ReadLines(path))
            {
                Root root= JsonConvert.DeserializeObject<Root>(line);
                rootList.Add(root);
            }
            return rootList;
        }

        //public static List<Root> FileDeserialize(string path)
        //{

        //    string jsonString = "[" + File.ReadAllText(path) + "]";
        //    // RootList rootList = new RootList();
        //    List<Root> rootList = JsonConvert.DeserializeObject<List<Root>>(jsonString);
        //    return rootList;
        //}
    }
}
