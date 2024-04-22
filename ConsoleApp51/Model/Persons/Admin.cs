using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51.Model.Persons
{
    internal class Admin : Person
    {

        public override string DisplayInfo()
        {
            return            $" UserName: {UserName}\n" +
                              $" Password: {Password}\n" +
                              $" FirstName: {FirstName}\n" +
                              $" LastName: {LastName}\n" +
                              $" Age: {Age}\n" +
                              $" Mail: {Mail}\n"; ;
        }
    }
}
