namespace XTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Initialize()
        {
            ////Add Initializations Exemple
            //var options = new DbContextOptionsBuilder<DbContextName>().UseInMemoryDatabase(databaseName: "ConnectionName").Options;
            //DbContextName context = new DbContextName(options);
            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();
            //_configuration = new ConfigurationBuilder().AddJsonFile("appsettings.test.json").Build();
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}