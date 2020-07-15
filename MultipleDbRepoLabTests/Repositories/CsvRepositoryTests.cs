using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultipleDbRepoLab.Repositories.Entities;
using MultipleDbRepoLab.Repositories.Implements;
using MultipleDbRepoLab.Repositories.Interfaces;

namespace MultipleDbRepoLabTests.Repositories
{
    [TestClass]
    public class CsvRepositoryTests
    {
        private IRepository<DataEntity> _repository;

        [TestInitialize]
        public void SetUp()
        {
            _repository = new CsvRepository<DataEntity>(@"D:\MOCK_DATA.csv");
        }

        [TestMethod]
        public void MethodCallTest_Calculating_Only_Out()
        {
        }
    }
}