using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MultipleDbRepoLab.Repositories.Interfaces;

namespace MultipleDbRepoLab.Repositories.Implements
{
    public class SqlRepository<T> : IRepository<T> where T : class
    {
        private DbSet<T> _dataSet;

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public SqlRepository(DbSet<T> dataSet)
        {
            this._dataSet = dataSet;
        }

        /// <summary>
        ///     新增一個entity
        /// </summary>
        /// <param name="entity"></param>
        public (bool result, string message) Create(T entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     刪除單一entity
        /// </summary>
        /// <param name="entity"></param>
        public (bool result, string message) Delete(T entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     取得單一 entity
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public T GetSingle(Expression<Func<T, bool>> filter)
        {
            return _dataSet.Find(filter);
        }

        /// <summary>
        ///     Lookups all.
        /// </summary>
        /// <returns>IQueryable&lt;T&gt;.</returns>
        public IEnumerable<T> LookUpAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     搜尋
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> Query(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     更新一個entity
        /// </summary>
        /// <param name="entity"></param>
        public (bool result, string message) Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}