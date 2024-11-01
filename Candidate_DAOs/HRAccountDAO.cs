using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidate_BO;

namespace Candidate_DAOs
{
    public class HRAccountDAO
    {

        public static Hraccount GetHraccountByEmail(String email)
        {
            Hraccount hraccount = new Hraccount();
            if (email.Equals("admin@hr.com.vn"))
            {
                hraccount.MemberRole = 1;
                hraccount.FullName = "Admin HR";
                hraccount.Email = email;
                hraccount.Password = "123@";
            }

            if (email.Equals("manager@hr.com.vn"))
            {
                hraccount.MemberRole = 2;
                hraccount.FullName = "Manager HR";
                hraccount.Email = email;
                hraccount.Password = "123@";
            }

            if (email.Equals("staff@hr.com.vn"))
            {
                hraccount.MemberRole = 3;
                hraccount.FullName = "Staff HR";
                hraccount.Email = email;
                hraccount.Password = "123@";
            }
            return hraccount;                      
        }
        
    }
}
