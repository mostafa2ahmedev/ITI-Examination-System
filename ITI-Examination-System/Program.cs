using ITI_Examination_System.Answers;
using ITI_Examination_System.Exams;
using ITI_Examination_System.Questions;
using ITI_Examination_System.Subjects;

namespace ITI_Examination_System
{
    internal class Program
    {

        public static void SelectExam(Exam ex,QList q) {
        
            ex.ShowExam(q);
        }
        static void Main(string[] args)
        {
            QList questionList = new QList();
            ///{
            ///
            ///     new Question()
            ///     {
            ///         Header = "Choose One",
            ///         Body = "What is the difference between int, float, and double in C#?",
            ///         Marks = 2,
            ///         AnswerList = new AList()
            ///         {
            ///             new Answer { AnswerR = "int is for whole numbers, float is for small decimal numbers, double is for larger decimal numbers." }, // ✅ correct
            ///             new Answer { AnswerR = "int and float are the same, double is for strings." },
            ///             new Answer { AnswerR = "float is only used in loops, double is for booleans." },
            ///             new Answer { AnswerR = "int is only for negative numbers." }
            ///         }
            ///     },
            ///
            ///     new Question()
            ///     {
            ///         Header = "Choose One",
            ///         Body = "Which keyword is used to define a method in C#?",
            ///         Marks = 1,
            ///         AnswerList = new AList()
            ///         {
            ///             new Answer { AnswerR = "void" }, // ✅ correct
            ///             new Answer { AnswerR = "method" },
            ///             new Answer { AnswerR = "function" },
            ///             new Answer { AnswerR = "define" }
            ///         }
            ///     },
            ///
            ///     new Question()
            ///     {
            ///         Header = "True / False",
            ///         Body = "Inheritance allows one class to acquire the properties of another class.",
            ///         Marks = 1,
            ///         AnswerList = new AList()
            ///         {
            ///             new Answer { AnswerR = "True" }, // ✅ correct
            ///             new Answer { AnswerR = "False" }
            ///         }
            ///     },
            ///
            ///     new Question()
            ///     {
            ///         Header = "Choose One",
            ///         Body = "Which block is used to handle exceptions in C#?",
            ///         Marks = 2,
            ///         AnswerList = new AList()
            ///         {
            ///             new Answer { AnswerR = "try-catch" }, // ✅ correct
            ///             new Answer { AnswerR = "try-else" },
            ///             new Answer { AnswerR = "try-then" },
            ///             new Answer { AnswerR = "try-finally" }
            ///         }
            ///     }
            /// };



            questionList.Add(new COQuestion()
            {
                Header = "Choose One",
                Body = "What is the difference between int, float, and double in C#?",
                Marks = 2,
                AnswerList = new AList()
                   {
                  new Answer { AnswerR = "int is for whole numbers, float is for small decimal numbers, double is for larger decimal numbers." },
                  new Answer { AnswerR = "int and float are the same, double is for strings." },
                  new Answer { AnswerR = "float is only used in loops, double is for booleans." },
                  new Answer { AnswerR = "int is only for negative numbers." }
                          }
            });

            questionList.Add(new COQuestion()
            {
                Header = "Choose One",
                Body = "Which keyword is used to define a method in C#?",
                Marks = 1,
                AnswerList = new AList()
                          {
                  new Answer { AnswerR = "void" },
                  new Answer { AnswerR = "method" },
                  new Answer { AnswerR = "function" },
                  new Answer { AnswerR = "define" }
                          }
            });

            questionList.Add(new TFQuestion()
            {
                Header = "True / False",
                Body = "Inheritance allows one class to acquire the properties of another class.",
                Marks = 1,
                AnswerList = new AList()
                          {
                  new Answer { AnswerR = "True" },
                  new Answer { AnswerR = "False" }
                          }
            });

            questionList.Add(new CAQuestion()
            {
                Header = "Choose Two",
                Body = "Which blocks are used to handle exceptions in C#?",
                Marks = 2,
                AnswerList = new AList()
                      {
                        new Answer { AnswerR = "try-catch" },     // correct
                        new Answer { AnswerR = "try-finally" },   // correct
                        new Answer { AnswerR = "try-else" },
                        new Answer { AnswerR = "try-then" }
                     }
            });


                  
            string type = Console.ReadLine();
            
            
            Dictionary<Question, AList> qu = new Dictionary<Question, AList>();


            // correct answers
            for (int i = 0; i < questionList.Count; i++)
            {
                Question q = questionList[i];

                if (q.GetType() == typeof(COQuestion)|| q.GetType() == typeof(TFQuestion))
                {
                    qu.Add(q, [q.AnswerList[0]]);
                }
                else{
                    qu.Add(q, [q.AnswerList[0], q.AnswerList[1]]);
                }
         
              
            }

            switch (type)
            {
                case "Final":
                 
                    SelectExam(new FinalExam() { 
                    NOQuestions = questionList.Count,
                    Time = "10 min",
                    Subject = new Subject() { SubjectName = "Programming"},
                    QuestionsCorrectAnswers= qu
                    }, questionList);
                    break;
                case "Practical":
                    SelectExam(new PracticeExam(){
                        NOQuestions = questionList.Count,
                        Time = "10 min",
                        Subject = new Subject() { SubjectName = "Programming" },
                        QuestionsCorrectAnswers = qu
                    }, questionList);
                    break;

                default:
                    Console.WriteLine("wrong choice");
                    break;

            }

        }
    }
}
