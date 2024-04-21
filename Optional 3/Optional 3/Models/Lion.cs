using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_3.Models
{
    internal class Lion 
    {
      
        public void Parçalamaq(Student student)
        {
            Console.WriteLine($"{student.Name} Code ugrunda oldu.Yaxsi kisi idi. " +
                $"Ay {student.Name} saa 100 defe deyibler ki köçürmey ve kopya vermey olmaz\n ");
                  
        }
        
    }
}
