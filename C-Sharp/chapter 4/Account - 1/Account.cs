using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_4
{
    class Account
    {
        private string name;

       public void SetName(string accountName)
       {
           name = accountName;
       }

       public string GetName()
       {
           return name;
       }
    }
}
