using ManMonth_IRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ManMonth_Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        public DbContext Context { get; set; }

        public BaseRepository(DbContext context)
        {
            this.Context = context;
        }

        #region 增
        public T Insert(T t)
        {
            this.Context.Set<T>().Add(t);
            this.Commit();
            return t;
        }

        public IEnumerable<T> Insert(IEnumerable<T> tList)
        {
            this.Context.Set<T>().AddRange(tList);
            this.Commit();
            return tList;
        }
        #endregion

        #region 删
        public void Delete(T t)
        {
            if (t == null) throw new Exception("t is null");
            this.Context.Set<T>().Attach(t);
            this.Context.Set<T>().Remove(t);
            this.Commit();
        }

        public void Delete(int Id)
        {
            T t = this.Find(Id);
            if (t == null) throw new Exception("t is null");
            this.Context.Set<T>().Remove(t);
            this.Commit();
        }

        public void Delete(IEnumerable<T> tList)
        {
            foreach (var t in tList)
            {
                this.Context.Set<T>().Attach(t);
            }
            this.Context.Set<T>().RemoveRange(tList);
            this.Commit();
        }
        #endregion

        #region 改
        public void Update(T t)
        {
            if (t == null) throw new Exception("t is null");

            this.Context.Set<T>().Attach(t);
            this.Context.Entry<T>(t).State = EntityState.Modified;
            this.Commit();
        }

        public void Update(IEnumerable<T> tList)
        {
            foreach (var t in tList)
            {
                this.Context.Set<T>().Attach(t);
                this.Context.Entry<T>(t).State = EntityState.Modified;
            }
            this.Commit();
        }
        #endregion

        #region 查
        public T Find(int id)
        {
            return this.Context.Set<T>().Find(id);
        }

        public IQueryable<T> Set()
        {
            return this.Context.Set<T>();
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> funcWhere)
        {
            return this.Context.Set<T>().Where<T>(funcWhere);
        }
        #endregion
        public void Commit()
        {
            this.Context.SaveChanges();
        }
    }
}
