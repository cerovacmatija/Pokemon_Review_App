﻿using Pokemon_Review_App.Models;

namespace Pokemon_Review_App.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerId);
        ICollection<Review> GetReviewsByReviewer(int reviewerId);
        bool CreateReviewer(Reviewer reviewer);
        bool ReviewerExists(int reviewerId);
        bool UpdateReviewer(Reviewer reviewer);
        bool DeleteReviewer(Reviewer reviewer);
        bool Save();
    }
}
