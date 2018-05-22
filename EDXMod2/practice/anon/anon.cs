using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDXLabTwo
{
    class Program
    {
        static void Main(string[] args)
        {

          #region Anon Class

          var anon = new { Name = "Abby", Age = 13 };

          Console.WriteLine(anon.Name + anon.Age);

          #endregion
        }
    }    
}