using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Data;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class ReviewerRepository : IReviewerRepository
    {
        private readonly DataContext _context;

        public ReviewerRepository(DataContext context)
        {
            _context = context;
        }

        public Reviewer GetReviewer(int reviewerId)
        {
            // original 
            //return _context.Reviewers.Where(r => r.Id == reviewerId).Include(e => e.Reviews).FirstOrDefault();

            return _context.Reviewers.Where(r => r.Id == reviewerId).FirstOrDefault();

            // think later code
            //var reviewer = _context.Reviewers
            //                        .Where(r => r.Id == reviewerId)
            //                        .Select(r => new ReviewerAlt1Dto
            //                        {
            //                            Id = r.Id,
            //                            FirstName = r.FirstName,
            //                            LastName = r.LastName,
            //                            Reviews = r.Reviews.Select(rev => new ReviewDto
            //                            {
            //                                Id = rev.Id,
            //                                Title = rev.Title,
            //                                Text = rev.Text,
            //                                Rating = rev.Rating
            //                            }).ToList()
            //                        });
        }

        public ICollection<Reviewer> GetReviewers()
        {
            return _context.Reviewers.ToList();
        }

        public ICollection<Review> GetReviewsByReviewer(int reviewerId)
        {
            return _context.Reviews.Where(r => r.Reviewer.Id == reviewerId).ToList();
        }

        public bool ReviewerExists(int reviewerId)
        {
            return _context.Reviewers.Any(r => r.Id == reviewerId);
        }

        public ICollection<ReviewAlt1> GetReviewsByReviewer1(int reviewerId)
        {
            return _context.Reviews.Where(r => r.Reviewer.Id == reviewerId)
                .Select(r => new ReviewAlt1
                {

                    Id = r.Id,
                    Title = r.Title,
                    Text = r.Text,
                    Rating = r.Rating,
                }).ToList();
        }


    }
}
