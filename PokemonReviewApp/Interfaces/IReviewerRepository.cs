using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerId);
        ICollection<Review> GetReviewsByReviewer(int reviewerId);
        ICollection<ReviewAlt1> GetReviewsByReviewer1(int reviewerId);
        bool ReviewerExists(int reviewerId);

    }
}
