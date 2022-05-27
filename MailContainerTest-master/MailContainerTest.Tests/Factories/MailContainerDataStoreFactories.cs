Using  MailContainerTest.Data;
namespace MailContainerTest.Factories.Tests
{
    [TestClass()]
    public class MailContainerDataStoreFactoriesTests
    {
        [TestMethod()]
        public void Factory_ShouldReturnBackupContainerDataStore_WhenDataStoreTypeIsBackup()
        {   
            var mailContainerDataStoreFactory = new MailContainerDataStoreFactory();

            var result = mailContainerDataStoreFactory.GetMailContainerDataStore("Backup");
            Assert.InInstanceOfType(result, typeOf(BackupMailContainerDataStore) );
        }
    }
}