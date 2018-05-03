using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Grant121_ioDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Videogame videogame1 = InitializeVideogame(1,"Persona 4", Videogame.PlatformName.SONY);
            Videogame videogame2 = InitializeVideogame(2,"Night in the Woods",Videogame.PlatformName.NINTENDO);

            WriteCsvFile(videogame1);
            videogame1 = ReadCsvFile();

            WriteXmlFile(new Videogame[2]{videogame1, videogame2});
            Videogame[] videogames = ReadXmlFile();

            Console.WriteLine(videogame1.Id+", "+videogame1.Name+", "+videogame1.Platform);
            Console.WriteLine(videogame2.Id+", "+videogame2.Name+", "+videogame2.Platform);
            Console.ReadKey();
        }

        public static Videogame InitializeVideogame(int id, string name, Videogame.PlatformName platform)
        {
            Videogame videogame = new Videogame()
            {
                Id = id,
                Name = name,
                Platform = platform
            };

            return videogame;
        }

        public static void WriteCsvFile(Videogame videogame)
        {
            StreamWriter sWriter = new StreamWriter("Data.csv");

            StringBuilder sb = new StringBuilder();
            sb.Clear();
            sb.Append(videogame.Id+",");
            sb.Append(videogame.Name+",");
            sb.Append(videogame.Platform);
            sb.ToString();

            using (sWriter)
            {
                sWriter.Write(sb);
            }
        }

        public static Videogame ReadCsvFile()
        {
            Videogame videogame = new Videogame();

            StreamReader sReader = new StreamReader("Data.csv");

            string videogameString;
            using (sReader)
            {
                videogameString = sReader.ReadLine();
            }

            string[] videogameArray = videogameString.Split(',');

            videogame.Id = int.Parse(videogameArray[0]);
            videogame.Name = videogameArray[1];
            videogame.Platform = (Videogame.PlatformName)Enum.Parse(typeof(Videogame.PlatformName), videogameArray[2]);

            return videogame;
        }

        public static void WriteXmlFile(Videogame[] videogame)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Videogame[]));
            StreamWriter sWriter = new StreamWriter("Data.xml");

            using (sWriter)
            {
                serializer.Serialize(sWriter, videogame);
            }
        }

        public static Videogame[] ReadXmlFile()
        {
            Videogame[] videogame = new Videogame[2];
            XmlSerializer serializer = new XmlSerializer(typeof(Videogame[]));
            StreamReader sReader = new StreamReader("Data.xml");

            using (sReader)
            {
                Object xmlObject = serializer.Deserialize(sReader);
                videogame = (Videogame[])xmlObject;
            }

            return videogame;
        }
    }
}
