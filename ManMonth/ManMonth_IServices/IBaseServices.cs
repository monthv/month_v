using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ManMonth_IServices
{
    public interface IBaseServices<T> where T : class, new()
    {
        #region 增
        T Insert(T t);

        IEnumerable<T> Insert(IEnumerable<T> tList);
        #endregion

        #region 删
        void Delete(int Id);

        void Delete(T t);

        void Delete(IEnumerable<T> tList);
        #endregion

        #region 改
        void Update(T t);

        void Update(IEnumerable<T> tList);
        #endregion

        #region 查
        T Find(int id);

        IQueryable<T> Set();

        IQueryable<T> Query(Expression<Func<T, bool>> funcWhere);
        #endregion
        void Commit();
    }
}
