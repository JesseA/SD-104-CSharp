using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_IO
{
    class DataAccessor
    {

        String fileName;

        public DataAccessor(String fileName)
        {
            this.fileName = fileName;
        }
        

        public void SaveTextToFile(String text)
        {

        }

        /// <summary>
        /// Returns a List of string objects obtained from the current text file
        /// </summary>
        /// <returns></returns>
        public List<string> GetTextFromFile()
        {
            List<string> fileContents = new List<string>();

            //Try to open text files
            try
            {
                //using block automatically disposes stream after use.
                using (StreamReader textFile = new StreamReader(fileName))
                {
                    fileContents.Add(textFile.ReadLine());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("The following exception occured: " + ex.ToString());
            }


            return fileContents;
        }



    }
}
