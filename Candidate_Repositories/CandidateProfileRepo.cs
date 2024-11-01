using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidate_BO;
using Candidate_DAOs;

namespace Candidate_Repositories
{
    public class CandidateProfileRepo : ICandidateProfileRepo
    {
        

        public void DeleteCandidate(CandidateProfile c) => CandidateProfileDAO.DeleteCandidate(c);


        public ObservableCollection<CandidateProfile> GetCandidateProfile() => CandidateProfileDAO.GetCandidateProfile();
       

        public CandidateProfile GetCandidateProfileByID(string id)=> CandidateProfileDAO.GetCandidateProfileByID(id);
       

        public void SaveCandidate(CandidateProfile c) => CandidateProfileDAO.SaveCandidate(c);
        

        public void UpdateCandidate(CandidateProfile c) => CandidateProfileDAO.UpdateCandidate(c);
        
    }
}
