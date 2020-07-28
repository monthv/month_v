using ManMonth_IRepository;
using ManMonth_IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ManMonth_Services
{
    public class BaseServices<T> : IBaseServices<T> where T : class, new()
    {
        private readonly IBaseRepository<T> _baseRepository;
        public BaseServices(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        #region 增
        public T Insert(T t)
        {
            return _baseRepository.Insert(t);
        }

        public IEnumerable<T> Insert(IEnumerable<T> tList)
        {
            return _baseRepository.Insert(tList);
        }
        #endregion

        #region 删
        public void Delete(T t)
        {
            _baseRepository.Delete(t);
        }
        public void Delete(int Id)
        {
            _baseRepository.Delete(Id);
        }

        public void Delete(IEnumerable<T> tList)
        {
            _baseRepository.Delete(tList);
        }
        #endregion

        #region 改
        public void Update(T t)
        {
            _baseRepository.Update(t);
        }

        public void Update(IEnumerable<T> tList)
        {
            _baseRepository.Update(tList);
        }
        #endregion

        #region 查
        public T Find(int id)
        {
            return _baseRepository.Find(id);
        }

        public IQueryable<T> Set()
        {
            return _baseRepository.Set();
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> funcWhere)
        {
            return _baseRepository.Query(funcWhere);
        }
        #endregion
        public void Commit()
        {
            _baseRepository.Commit();
        }
    }
}
