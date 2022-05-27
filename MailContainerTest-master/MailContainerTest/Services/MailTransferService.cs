using System.Net;
using System.Net.Cache;
using System.Collections.Generic;
using MailContainerTest.Data;
using MailContainerTest.Types;
using System.Configuration;
using MailContainerTest.Factories;
using MailContainerTest.BusinessValidators;

namespace MailContainerTest.Services
{
    public class MailTransferService : IMailTransferService
    {

        private readonly IMailContainerDataStoreFactories mailContainerDataStoreFactories;

        private readonly Dictionary<MailType, IMailContainerValidator> mailContainerValidators=
            new  Dictionary<MailType, IMailContainerValidator>(); 

        public MailTransferService(IMailContainerDataStoreFactories _mailContainerDataStoreFactories)
        {
            mailContainerDataStoreFactories=_mailContainerDataStoreFactories;
            mailContainerValidator.Add(MailType.StandardLetter,new StandardLetterValidator());
            mailContainerValidator.Add(MailType.SmallLetter,new SmallLetterValidator());
            mailContainerValidator.Add(MailType.LargeLetter,new LargeLetterValidator());
        }


        public MakeMailTransferResult MakeMailTransfer(MakeMailTransferRequest request)
        {
            var dataStoreType = ConfigurationManager.AppSettings["DataStoreType"];

            MailContainer mailContainer = null;
            var result = new MakeMailTransferResult();
  
            mailContainerDataStoreFactories.GetMailContainerDataStore (dataStoreType);
            mailContainer = mailContainerDataStore.GetMailContainer(request.SourceMailContainerNumber);
          
            mailContainerValidators.TryGetValue(request.MailType, out var mailContainerValidator)
            result.Success =  mailContainerValidator.IsValidMailData(mailContainer, request.NumberOfMailItems)
          
            if (result.Success)
            {
                mailContainer.Capacity -= request.NumberOfMailItems;
                    mailContainerDataStore.UpdateMailContainer(mailContainer);
            }

            return result;
        }
    }
}