using MultipleDbRepoLab.Repositories.Entities;
using MultipleDbRepoLab.Repositories.Interfaces;

namespace MultipleDbRepoLab.Services.Implements
{
    /// <summary>
    /// </summary>
    public class DataService
    {
        private readonly IRepository<Data> _repository;

        public DataService(IRepository<Data> repository)
        {
            _repository = repository;
        }

        /// <summary>
        ///     取消交易
        /// </summary>
        /// <param name="stockTran"></param>
        /// <returns></returns>
        public (bool result, string message) Cancel(Data stockTran)
        {
            return _repository.Delete(stockTran);
        }

        /// <summary>
        ///     建立交易
        /// </summary>
        /// <param name="stockTranDocument"></param>
        /// <returns></returns>
        public (bool result, string message) Create(Data stockTranDocument)
        {
            return _repository.Create(stockTranDocument);
        }

        /// <summary>
        ///     更新交易
        /// </summary>
        /// <param name="stockTranDocument"></param>
        /// <returns></returns>
        public (bool result, string message) Update(Data stockTranDocument)
        {
            return _repository.Update(stockTranDocument);
        }
    }
}