using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidate_BO;
using Candidate_DAOs;
using Candidate_Repositories;

namespace Candidate_Services
{
    public class CandidateProfileServ : ICandidateProfileServ
    {

        private readonly ICandidateProfileRepo profilerepo;

        public CandidateProfileServ()
        {
            profilerepo = new CandidateProfileRepo();
        }

        public void DeleteCandidate(CandidateProfile c)
        {
            profilerepo.DeleteCandidate(c);
        }

        public ObservableCollection<CandidateProfile> GetCandidateProfile()
        {
            return profilerepo.GetCandidateProfile();
        }

        public CandidateProfile GetCandidateProfileByID(string id)
        {
            return profilerepo.GetCandidateProfileByID(id);
        }

        public void SaveCandidate(CandidateProfile c)
        {
            profilerepo.SaveCandidate(c);
        }

        public void UpdateCandidate(CandidateProfile c)
        {
            profilerepo.UpdateCandidate(c);
        }
    }
}
