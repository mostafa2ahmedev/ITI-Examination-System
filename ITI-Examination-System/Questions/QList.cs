using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Examination_System.Questions
{
    internal class QList : List<Question>
    {


        public new void Add(Question item) {

            string filePath = $"W:\\ITI\\C#\\ITI-Examination-System\\log{GetHashCode()}.txt";

            using (TextWriter writer = new StreamWriter(filePath, append: true))
            {
                writer.WriteLine($"{item.Header} --- {item.Marks}" );
                Console.WriteLine();      
                writer.WriteLine(item.Body);
                writer.WriteLine("-----------");
            }
     

            using (TextReader reader = new StreamReader(filePath))
            {
                string content = reader.ReadToEnd();
            }


            base.Add(item);
        }
    }
}
