namespace Pattern8.LazyInitialization
{
    public class DataContext
    {
        public User GetUserById(int id)
        {
            return new UserProxy
            {
                Id = id,
            };
        }
    }
}
