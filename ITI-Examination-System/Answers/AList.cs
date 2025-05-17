using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Examination_System.Answers
{
    internal class AList :List<Answer>    
    {

        

        public new void Add(Answer answer) { 
        
            base.Add(answer);

        
        }
    }
}
