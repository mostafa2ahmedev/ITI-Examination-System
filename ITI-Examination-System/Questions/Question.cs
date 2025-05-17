using ITI_Examination_System.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Examination_System.Questions
{
    internal class Question
    {
        public string Body { get; set; }
        public string Header { get; set; }
        public int Marks { get; set; }
                                        
        // Association 
        public AList AnswerList { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            Question question = (Question)obj;

            return Header.Equals(question.Header) &&
                   Body.Equals(question.Body) &&
                   Marks.Equals(question.Marks);

        }

        public override int GetHashCode()
        {
       
            return HashCode.Combine(Body,Header,Marks);
        }


        public override string ToString()
        {
            return $"Header: {Header}\n Body:{Body}\n Marks:{Marks}\n";
        }
    }
}
