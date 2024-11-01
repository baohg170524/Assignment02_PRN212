using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidate_BO;
using Microsoft.EntityFrameworkCore;

namespace Candidate_DAOs
{
    public class CandidateProfileDAO
    {
        private static ObservableCollection<CandidateProfile> listCandidateProfile;

        static CandidateProfileDAO()
        {
            CandidateProfile CANDIDATE0001 = new CandidateProfile(
                "CANDIDATE0001",
                "Alan Clinton",
                DateTime.Parse("1990-09-01 00:00:00.000"),
                "Excellent communication skills with a commitment to understanding customer requirements as well as business objectives.",
                "AlanClinton.PDF",
                "P0002");

            CandidateProfile CANDIDATE0002 = new CandidateProfile(
                "CANDIDATE0002",
                "Ethelbert Harron",
                DateTime.Parse("1993-04-16 00:00:00.000"),
                "Critical thinking skills and an analytical mind with strong problem-solving abilitiess.",
                "EthelbertHarron.PDF",
                "P0002");

            CandidateProfile CANDIDATE0003 = new CandidateProfile(
               "CANDIDATE0003",
               "Kenneth Paul",
               DateTime.Parse("1980-09-24 00:00:00.000"),
               "Highly experienced with various operating systems and databases",
               "KennethPaul.PDF",
               "P0002");

            CandidateProfile CANDIDATE0004 = new CandidateProfile(
               "CANDIDATE0004",
               "Michael Leonard",
               DateTime.Parse("1995-12-30 00:00:00.000"),
               "Proven ability to troubleshoot hardware, software, and network issues quickly and effectively.",
               "MichaelLeonard.PDF",
               "P0002");

            CandidateProfile CANDIDATE0005 = new CandidateProfile(
               "CANDIDATE0005",
               "William Peterr",
               DateTime.Parse("1991-06-28 00:00:00.000"),
               "Problem solving skills to revise existing systems and suggest improvements.",
               "WilliamPeter.PDF",
               "P0003");

            CandidateProfile CANDIDATE0006 = new CandidateProfile(
              "CANDIDATE0006",
              "Edward David Clinton",
              DateTime.Parse("1990-07-13 00:00:00.000"),
              "Patience and ability to train users in both new and existing IT systems.",
              "EdwardDavidClinton.PDF",
              "P0004");

            CandidateProfile CANDIDATE0007 = new CandidateProfile(
            "CANDIDATE0007",
            "Harvey Louis",
            DateTime.Parse("1990-09-01 00:00:00.000"),
            "Enthusiastic about working collaboratively.",
            "Harvey Louis.PDF",
            "P0005");

            listCandidateProfile = new ObservableCollection<CandidateProfile> { 
                CANDIDATE0001,
                CANDIDATE0002,
                CANDIDATE0003,
                CANDIDATE0004,
                CANDIDATE0005,
                CANDIDATE0006,
                CANDIDATE0007 };
        }

        

        public static ObservableCollection<CandidateProfile> GetCandidateProfile()
        {
            return listCandidateProfile;    
        }

        public static void SaveCandidate(CandidateProfile c)
        {
            listCandidateProfile.Add(c);
        }

        public static void UpdateCandidate(CandidateProfile c)
        {
            foreach (CandidateProfile p in listCandidateProfile.ToList())
            {
                if (p.CandidateId.Equals(c.CandidateId))
                {
                    p.CandidateId = c.CandidateId;
                    p.PostingId = c.PostingId;
                    p.Fullname = c.Fullname;
                    p.ProfileUrl = c.ProfileUrl;
                    p.ProfileShortDescription = c.ProfileShortDescription;
                    p.Birthday = c.Birthday;
                }
            }
        }

        public static void DeleteCandidate(CandidateProfile c)
        {
            foreach(CandidateProfile p in listCandidateProfile.ToList())
            {
                if (p.CandidateId.Equals(c.CandidateId))
                {
                    listCandidateProfile.Remove(p);
                }
            }
        }

        public static CandidateProfile GetCandidateProfileByID(string id)
        {
            foreach (CandidateProfile p in listCandidateProfile.ToList())
            {
                if (p.CandidateId.Equals(id))
                {
                    return p;
                }
            }
            return null;
        }

    }
}


        
        
        
        //public List<CandidateProfile> GetCandidates()
        //{
        //    return .GetAll();

        //}
//        public bool removeCandidate(String candidateID)
//        {
//            bool isSuccess = false;

//            CandidateProfile candidate = searchCandidateByID(candidateID);
//            if (candidate != null)
//            {
//                genericDAO.Delete(candidateID);
//                dbcontext.SaveChanges();
//                isSuccess = true;
//            }
//            return isSuccess;

//        }
//        public bool updateCandidate(CandidateProfile candidateProfile)
//        {
//            bool isSuccess = false;
//            dbcontext = new CandidateManagementContext();

//            CandidateProfile candidate = searchCandidateByID(candidateProfile.CandidateId);
//            if (candidate != null)
//            { 
//                dbcontext.Entry<CandidateProfile>(candidateProfile).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
//                dbcontext.SaveChanges();
//                return isSuccess = true;

//            }
//            return isSuccess;

//        }

//        public CandidateProfile searchCandidateByID(string candidateID)
//        {

//            return dbcontext.CandidateProfiles.SingleOrDefault(candidate => candidate.CandidateId.Equals(candidateID));
//        }


//        public bool AddCadidateProfile(CandidateProfile candidateProfile)
//        {
//            bool isSuccess = false;

//            CandidateProfile candidate = searchCandidateByID(candidateProfile.CandidateId);

//            if (candidate == null)
//            {
//                dbcontext.CandidateProfiles.Add(candidateProfile);
//                dbcontext.SaveChanges();
//                return isSuccess = true;

//            }

//            return isSuccess;
//        }
//    }
//}
