using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Examination_System.Answers
{
    internal class Answer
    {
        public string AnswerR { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }

            Answer answer = (Answer)obj;
            return AnswerR == answer.AnswerR;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(AnswerR);
        }

        public override string ToString()
        {
            return AnswerR;
        }
    }

}
