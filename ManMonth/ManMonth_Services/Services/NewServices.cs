using ManMonth_IRepository;
using ManMonth_IServices.IServices;
using ManMonth_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManMonth_Services.Services
{
    public class NewServices: BaseServices<NewMan>, INewServices
    {
        public NewServices(IBaseRepository<NewMan> baseRepository)
           : base(baseRepository)
        {

        }
    }
}
