using APP.DATA;

namespace APP.BUSINESS
{
    public interface IDb
    {
        AppDbContext db { get; }
    }
}
