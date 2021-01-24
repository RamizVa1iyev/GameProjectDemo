using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Business.Services
{
    public class CheckPersonService
    {
        public bool CheckPerson(string tcNo, DateTime birthDay, string firstName, string lastName)
        {
            if (tcNo.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
