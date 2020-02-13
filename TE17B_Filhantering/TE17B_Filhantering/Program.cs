using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace TE17B_Filhantering
{
    class Program
    {
        static void Main(string[] args)
        {
            //Monster m = new Monster();

            XmlSerializer monsterSerializer = new XmlSerializer(typeof(Monster));

            FileStream file = File.Open(@"test.txt",
            FileMode.OpenOrCreate, 
            FileAccess.Read);

            Monster m = (Monster) monsterSerializer.Deserialize(file);

        /*monsterSerializer.Serialize(file, m);*/

            file.Close();


            //string monsterNames = File.ReadAllText(@"monsters.txt");
            //Console.WriteLine(monsterNames);

            //string[] names = monsterNames.Split('\n');


            /*List<string> names = File.ReadAllLines(@"monsters.txt").ToList() ;

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(" * " + names[i]);
            }

            names.Add("Albert");

            File.WriteAllLines(@"monsters.txt", names);

            //File.WriteAllText(@"monsters.txt", monsterNames);

            Console.ReadLine();*/

        }
    }
}
