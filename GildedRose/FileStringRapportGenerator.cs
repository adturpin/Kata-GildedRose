using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{

    public class FileStringRapportGenerator<T> : IGenerator where T :Item
    {
        private readonly string _path;

        public FileStringRapportGenerator(string path)
        {
            _path = path;
            if (File.Exists(_path))
                File.Delete(_path);
        }

        void IGenerator.GenerateRapport(Rapport rapport)
        {
            string day = "-------- day {0} --------";
            writeStringInStream("OMGHAI!");
            foreach (RapportSection<T> section in ((Rapport<T>)rapport).Sections)
            {
                string currentDay = String.Format(day, section.JourDuRapport);
                writeStringInStream(currentDay);
                string header = section.GetHeader();
                writeStringInStream(header);
                foreach (T data in section.GetDataItems())
                {
                    string sData = RapportDataFormatter.Stringifyer(data);
                    writeStringInStream(sData);
                }

                writeStringInStream(string.Empty);
            } 
        }

        private void writeStringInStream(string text)
        {
            FileStream fileStream;

            if(File.Exists(_path))
                fileStream = new FileStream(_path, FileMode.Append);
            else
                fileStream = new FileStream(_path, FileMode.Create);

            using (fileStream)
            {
                byte[] byteArray = ASCIIEncoding.ASCII.GetBytes(text+ Environment.NewLine);
                fileStream.Write(byteArray, 0, byteArray.Length);
            }
        }
    }
}
