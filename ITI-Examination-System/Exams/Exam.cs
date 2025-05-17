using ITI_Examination_System.Answers;
using ITI_Examination_System.Questions;
using ITI_Examination_System.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Examination_System.Exams
{
    internal abstract class Exam 
    {

        public string Time { get; set; }
        public int NOQuestions { get; set; }
        public Subject Subject { get; set; }
        public Dictionary<Question, AList> QuestionsCorrectAnswers { get;set; }


        public abstract void ShowExam(QList q);




        public int Validate(Question question)
        {
            int countMarks = 0;

            int userInput = 0;
            if (question.GetType() == typeof(TFQuestion))
            {
                do
                {
                    Console.Write("Enter an answer number (1-2): ");
                    userInput = int.Parse(Console.ReadLine()) - 1;
                }
                while (userInput != 0 && userInput != 1);

                Answer userAnswer = question.AnswerList[userInput];

                foreach (var item in QuestionsCorrectAnswers)
                {
                    if (item.Key.GetHashCode() == question.GetHashCode())
                    {
                        if (item.Value[0].GetHashCode() == userAnswer.GetHashCode())
                        {
                            countMarks += question.Marks;
                        }


                    }
                }
            }
            else if (question.GetType() == typeof(COQuestion))
            {

                do
                {
                    Console.Write("Enter an answer number (1-4): ");
                    userInput = int.Parse(Console.ReadLine()) - 1;
                }
                while (userInput < 0 || userInput > 3);

                Answer userAnswer = question.AnswerList[userInput];

                foreach (var item in QuestionsCorrectAnswers)
                {
                    if (item.Key.GetHashCode() == question.GetHashCode())
                    {
                        if (item.Value[0].GetHashCode() == userAnswer.GetHashCode())
                        {
                            countMarks += question.Marks;
                        }


                    }
                }
            }
            else if (question.GetType() == typeof(CAQuestion))
            {
                List<Answer> userAnswers  = new List<Answer>(question.AnswerList.Count);
                bool IsCorrect = false;
                do
                {
                    Console.Write("Enter multiple answers between (1-4) and {0} for exit ");
                    userInput = int.Parse(Console.ReadLine()) - 1;
                    if (userInput >= 0 && userInput < 4) {

                        userAnswers.Add(question.AnswerList[userInput]);
                    }
                }
                while (userInput!=-1);

                foreach (var item in QuestionsCorrectAnswers)
                {
                    if (item.Key.GetHashCode() == question.GetHashCode())
                    {

                        for (int i = 0; i < userAnswers.Count; i++)
                        {
                            IsCorrect = false;
                            for (int j = 0; j < item.Value.Count; j++)
                            {
                                if (userAnswers[j].GetHashCode() == item.Value[i].GetHashCode()) {
                                    IsCorrect = true;
                                    break;
                                }
                            }
                            if (!IsCorrect) {
                                break;
                            }
                        }
                        if (IsCorrect) {
                            countMarks += question.Marks;
                        }
                    }
                }

            }


            return countMarks;

        }
    }
}
