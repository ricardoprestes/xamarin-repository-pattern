using SQLite;

namespace TestRepository.Service
{
    public abstract class BaseService
    {
        protected SQLiteConnection Connection { get; private set; }

        public BaseService(SQLiteConnection conn)
        {
            Connection = conn;
        }
    }
}
