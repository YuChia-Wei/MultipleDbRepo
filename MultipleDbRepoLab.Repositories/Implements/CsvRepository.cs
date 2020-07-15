using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using CsvHelper;
using MultipleDbRepoLab.Repositories.Interfaces;

namespace MultipleDbRepoLab.Repositories.Implements
{
    public class CsvRepository<TContextModel> : IRepository<TContextModel>
        where TContextModel : class
    {
        private readonly List<TContextModel> _contextModels;

        public CsvRepository(string csvFilePath)
        {
            _contextModels = new CsvReader(new StreamReader(csvFilePath), CultureInfo.InvariantCulture)
                             .GetRecords<TContextModel>().ToList();
        }

        public (bool result, string message) Create(TContextModel entity)
        {
            if (_contextModels.Contains(entity))
            {
                return (false, "Duplicate");
            }

            _contextModels.Add(entity);

            return (_contextModels.Contains(entity), string.Empty);
        }

        public (bool result, string message) Delete(TContextModel entity)
        {
            if (_contextModels.Contains(entity))
            {
                return (false, "Not Found");
            }

            _contextModels.Remove(entity);

            return (!_contextModels.Contains(entity), string.Empty);
        }

        public TContextModel GetSingle(Expression<Func<TContextModel, bool>> filter)
        {
            return _contextModels.AsQueryable().FirstOrDefault(filter);
        }

        public IEnumerable<TContextModel> LookUpAll()
        {
            return _contextModels;
        }

        public IQueryable<TContextModel> Query(Expression<Func<TContextModel, bool>> filter)
        {
            return _contextModels.AsQueryable().Where(filter);
        }

        public (bool result, string message) Update(TContextModel entity)
        {
            if (_contextModels.Contains(entity))
            {
                return (true, "No Change");
            }

            _contextModels.Add(entity);

            return (_contextModels.Contains(entity), string.Empty);
        }
    }
}