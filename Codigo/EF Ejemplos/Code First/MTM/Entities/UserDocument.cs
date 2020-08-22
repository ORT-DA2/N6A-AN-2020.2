namespace MTM.Entities
{
    public class UserDocument
    {
        public UserDocument()
        {
            
        }

        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int DocumentId { get; set; }

        public Document Document { get; set; }
    }
}
