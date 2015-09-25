namespace Pattern8.LazyInitialization
{
    public class DataContext
    {
        public User GetUserById(int id)
        {
            return new UserProxy // Returning not User but UserProxy! Liskov substitution principle is kept!
            {
                Id = id,
            };
        }
    }
}
