using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMControllerApp_TK.Utilities
{
    class FileHandling
    {
        public string fullPath;
        public StreamReader iFile;
        public StreamWriter oFile;
        public List<string> fileText;
        public static FileHandling instance;
        public static FileHandling getInstance()
        {
            if (instance == null) instance = new FileHandling();
            return instance;
        }
        
        private FileHandling()
        {
            //fullPath = @"C:\Users\Acer\Desktop\demo.txt";
        }
        public bool initialize(string path)
        {
            if (!File.Exists(path)) return false;

            fullPath = path;
            iFile = new StreamReader(fullPath);
            fileText = new List<string>();
            int counter = 0;
            string line;

            while ((line = iFile.ReadLine()) != null)
            {
                fileText.Add(line);
                counter++;
            }
            iFile.Close();
            return true;
        }
        public string readLineAtIndex(int idx)
        {
            if (idx >= fileText.Count) return "Empty";
            return fileText[idx];
        }
        public string writeLineAtEnd(string str)
        {
            oFile = File.AppendText(fullPath);
            oFile.WriteLine(str);
            oFile.Close();
            return str;
        }
        public bool refresh()
        {
            if (!File.Exists(fullPath)) return false;
            initialize(fullPath);
            return true;
        }
        public bool clear()
        {
            if (!File.Exists(fullPath)) return false;
            File.WriteAllText(fullPath, string.Empty);
            return true;
        }
    }
}
