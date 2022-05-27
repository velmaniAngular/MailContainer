Using  MailContainerTest.Data;
namespace MailContainerTest.Data
{
    public interface IMailContainerDataStoreFactories
    {
        MailContainer GetMailContainerDataStore(string dataStoreType);
    }
}