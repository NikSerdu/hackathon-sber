using SberCase.Data;
using SberCase.Models;
using SberCase.Repositories.Interfaces;

namespace SberCase.Repositories.Impls
{
    public class ProfileRepository : BaseRepository<Profile, int>, IProfileRepository
    {
        public ProfileRepository(DatabaseContext context) : base(context)
        {

        }
    }
}
