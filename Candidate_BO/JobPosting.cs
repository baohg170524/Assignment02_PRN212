using System;
using System.Collections.Generic;

namespace Candidate_BO
{
    public partial class JobPosting
    {
        public JobPosting()
        {
            CandidateProfiles = new HashSet<CandidateProfile>();
        }

        public JobPosting(string postingId, string jobPostingTitle, string? description, DateTime? postedDate)
        {
            PostingId = postingId;
            JobPostingTitle = jobPostingTitle;
            Description = description;
            PostedDate = postedDate;
        }

        public string PostingId { get; set; } = null!;
        public string JobPostingTitle { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? PostedDate { get; set; }

        public virtual ICollection<CandidateProfile> CandidateProfiles { get; set; }
    }
}
