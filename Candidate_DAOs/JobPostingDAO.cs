using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidate_BO;

namespace Candidate_DAOs
{
    public class JobPostingDAO
    {
        
        public static List<JobPosting> GetJobPostings() 
        { 
            JobPosting P0001 = new JobPosting(
                "P0001", 
                "System Administrator Specialist (MS Exchange, AD Voice)", 
                "As our company is growing and we offer more service to our teams, we are looking for a Senior System engineer with a broad set of expertise in Messaging, voice systems, mail gateways, encryption (smime), etc.",
                DateTime.Parse("2022-07-01 00:00:00.000"));

            JobPosting P0002 = new JobPosting(
                "P0002",
                "IT Security Manager",
                "Establish the Information Security Plan toward to updated ISO Framework as well as in alignment with IT Strategic Plan",
                DateTime.Parse("2022-07-01 00:00:00.000"));

            JobPosting P0003 = new JobPosting(
                "P0003",
                "(Senior) IT Recruitment Consultant",
                "Developing and maintaining loyal business relationship with them aligning with our company and team business strategies",
                DateTime.Parse("2022-07-01 00:00:00.000"));

            JobPosting P0004 = new JobPosting(
                "P0004",
                "Senior Network Security Engineer",
                "In this role you will provide Security Subject Matter technical and leadership, expertise, support and consultancy/advice within relevant service levels for several cyber security technology systems and services currently in use across NAB.",
                DateTime.Parse("2022-07-01 00:00:00.000"));

            JobPosting P0005 = new JobPosting(
                "P0005",
                "Mobile Game Developer",
                "Responsible for QA phase of those large-scale projects (or multi projects) with 7-8 members. Responsibilities are to instruct the team on quality metrics and testing strategies for each project.",
                DateTime.Parse("2022-07-01 00:00:00.000"));

            var listJobPosting  = new List<JobPosting>();
            try
            {
                listJobPosting.Add(P0001);
                listJobPosting.Add(P0002);
                listJobPosting.Add(P0003);
                listJobPosting.Add(P0004);
                listJobPosting.Add(P0005);
            }
            catch (Exception e) 
            {
                throw new Exception(e.Message);
            }
            return listJobPosting;
        }
        



    }
}
