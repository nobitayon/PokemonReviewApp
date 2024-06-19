using PokemonReviewApp.Models;

namespace PokemonReviewApp.Dto
{
    public class ReviewerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class ReviewerAlt1Dto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<ReviewDto> Reviews { get; set; }
    }
}
