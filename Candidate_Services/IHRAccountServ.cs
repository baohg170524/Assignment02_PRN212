using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidate_BO;

namespace Candidate_Services
{
     public interface IHRAccountServ
    {
        public Hraccount GetHraccountByEmail(String email);
    }
}
