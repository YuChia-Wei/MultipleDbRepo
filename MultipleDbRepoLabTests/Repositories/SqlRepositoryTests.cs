using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultipleDbRepoLab.Repositories.EfCoreContext;
using MultipleDbRepoLab.Repositories.Entities;
using MultipleDbRepoLab.Repositories.Implements;

namespace MultipleDbRepoLabTests.Repositories
{
    [TestClass]
    public class SqlRepositoryTests
    {
        protected DbContextOptions<MyTestContext> ContextOptions { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            ContextOptions = new DbContextOptionsBuilder<MyTestContext>()
                             .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFSample;ConnectRetryCount=0")
                             .Options;

            Seed();
        }

        [TestMethod]
        public void TestSqlGet()
        {
            using (var context = new MyTestContext(ContextOptions))
            {
                var repository = new SqlRepository<Data>(context.Data);

                var item = repository.GetSingle(d => d.ProductCode == "C");

                Assert.AreEqual(item.ProductCode, "C");
            }
        }

        private void Seed()
        {
            using (var context = new MyTestContext(ContextOptions))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var data = new Data
                {
                    MethodCode = "A",
                    IndividuallySet = true,
                    ProductCode = "C",
                    ByLocationId = false,
                    ByLotNumber = false
                };


                context.Add(data);

                context.SaveChanges();
            }
        }
    }
}