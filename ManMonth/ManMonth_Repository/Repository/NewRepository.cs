using ManMonth_IRepository.IRepository;
using ManMonth_Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManMonth_Repository.Repository
{
    public class NewRepository: BaseRepository<NewMan>, INewRepository
    {
        public NewRepository(DbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
