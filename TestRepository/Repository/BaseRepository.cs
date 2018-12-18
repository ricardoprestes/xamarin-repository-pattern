using SQLite;

namespace TestRepository.Repository
{
    public abstract class BaseRepository
    {
        protected SQLiteConnection Connection { get; private set; }

        public BaseRepository(SQLiteConnection conn)
        {
            Connection = conn;
        }
    }
}
