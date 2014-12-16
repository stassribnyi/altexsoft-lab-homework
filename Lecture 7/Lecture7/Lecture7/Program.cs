using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7
{
    class Program
    {
        static void Main(string[] args)
        {

            Folder nFolder = new Folder
            {
                new CompactDisk(
                "First",
                new Dictionary<string, string>()
                {
                    {"Sinonim1", "Antonim1" },
                    {"Sinonim2", "Antonim2" },
                    {"Sinonim3", "Antonim33" },
                    {"Sinonim4", "Antonim4" },
                    {"Sinonim5", "Antonim5" },
                }),
                new CompactDisk(
                "Second",
                new Dictionary<string, string>()
                {
                    {"Sinonim1", "Antonim1" },
                    {"Sinonim2", "Antonim2" },
                    {"Sinonim3", "Antonim32" },
                    {"Sinonim4", "Antonim4" },
                    {"Sinonim5", "Antonim5" },
                }),
                new CompactDisk(
                "Third",
                new Dictionary<string, string>()
                {
                    {"Sinonim1", "Antonim1" },
                    {"Sinonim2", "Antonim2" },
                    {"Sinonim3", "Antonim1" },
                    {"Sinonim4", "Antonim4" },
                    {"Sinonim5", "Antonim5" },
                }),
            };

            var querry =
                from item in nFolder
                from t in item
                where t.Key == "Sinonim3"
                select t;

            Console.WriteLine(nFolder);

            foreach (var item in querry)
            {
               
                Console.WriteLine(item.Key + " - " + item.Value);
            }

            CompactDisk disk = new CompactDisk();

            nFolder.Add(disk);

            Console.WriteLine(nFolder);
            
            Console.ReadKey();
        }
    }
}
