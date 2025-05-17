using ITI_Examination_System.Answers;
using ITI_Examination_System.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Examination_System.Exams
{
    internal class PracticeExam : Exam
    {
        public override void ShowExam(QList q)
        {
            Console.WriteLine($"Time: {this.Time}");
            Console.WriteLine($"No of the questions: {this.NOQuestions}");
            int countMarks = 0;
            for (int i = 0; i < q.Count; i++)
            {
                Console.WriteLine($"{q[i].Header} -- {q[i].Marks}");
                Console.WriteLine(q[i].Body);
                for (int j = 0; j < q[i].AnswerList.Count; j++)
                {
                    Console.WriteLine($"{j + 1} :  {q[i].AnswerList[j]}");
                }
         

                countMarks += Validate(q[i]);
                Console.WriteLine("__________________________________________");
            }
            Console.Clear();
            Console.WriteLine("__________________________________________");
            Console.WriteLine($"You Scored: {countMarks}");
            Console.WriteLine("__________________________________________");

            Console.WriteLine("Correct Answers");


            foreach (var item in QuestionsCorrectAnswers)
            {
                Console.WriteLine($"Question : {item.Key.ToString()}");

                foreach (var answer in item.Value)
                {
                    Console.WriteLine($"Answer: {answer} ");
                }

                Console.WriteLine("__________________________________________");
            }


        }

     
    }
}
