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
        public void FindCvsData_ProductCode_is_Dodge()
        {
            var dataEntity = _repository.GetSingle(d => d.ProductCode == "Dodge");

            Assert.AreEqual(dataEntity.ProductCode, "Dodge");
        }
    }
}