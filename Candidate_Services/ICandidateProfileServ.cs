﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidate_BO;
using Candidate_DAOs;

namespace Candidate_Services
{
    public interface ICandidateProfileServ
    {
        public ObservableCollection<CandidateProfile> GetCandidateProfile();


        public void SaveCandidate(CandidateProfile c);

        public void UpdateCandidate(CandidateProfile c);

        public void DeleteCandidate(CandidateProfile c);

        public CandidateProfile GetCandidateProfileByID(string id);
    }
}