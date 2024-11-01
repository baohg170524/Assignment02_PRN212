using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidate_BO;
using Microsoft.EntityFrameworkCore;

namespace Candidate_Repositories
{
    public interface ICandidateProfileRepo
    {
        public ObservableCollection<CandidateProfile> GetCandidateProfile();


        public void SaveCandidate(CandidateProfile c);

        public void UpdateCandidate(CandidateProfile c);

        public void DeleteCandidate(CandidateProfile c);

        public CandidateProfile GetCandidateProfileByID(string id);

    }
}
