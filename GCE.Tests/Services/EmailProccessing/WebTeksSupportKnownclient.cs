using System;
using TechTalk.SpecFlow;

namespace GCE.Tests.Services.EmailProccessing
{

    [Binding]
    public class WebTeksSupportKnownclient
    {
        private readonly EmailProccessingContext _context;

        public WebTeksSupportKnownclient()
        {
            _context = new EmailProccessingContext();
        }


        [Given(@"A new email is received by WebTeks Support from a Known Client Email")]
        public void GivenANewEmailIsReceivedByWebTeksSupportFromAKnownClientEmail()
        {
            
        }
        
        [When(@"it should create a new record in the Email Connector DB")]
        public void WhenItShouldCreateANewRecordInTheEmailConnectorDB()
        {
            
        }
        
        [When(@"Primary-ID \(message-id\) = a unique message identifier from Email Header\(Message-ID\) is saved")]
        public void WhenPrimary_IDMessage_IdAUniqueMessageIdentifierFromEmailHeaderMessage_IDIsSaved()
        {
            throw new NotImplementedException();
        }
        
        [When(@"Message-ID = a unique message identifier from Email Header is saved")]
        public void WhenMessage_IDAUniqueMessageIdentifierFromEmailHeaderIsSaved()
        {
            throw new NotImplementedException();
        }
        
        [When(@"Email message content is saved")]
        public void WhenEmailMessageContentIsSaved()
        {
            throw new NotImplementedException();
        }
        
        [When(@"timestamp is saved")]
        public void WhenTimestampIsSaved()
        {
            throw new NotImplementedException();
        }
        
        [Then(@"The Email Connector functionality gets the new message from mailgun\.com")]
        public void ThenTheEmailConnectorFunctionalityGetsTheNewMessageFromMailgun_Com()
        {
            _context.MailProcessingService.ProccessNewMail();
        }
        [When(@"it should check the references for the first value")]
        public void WhenItShouldCheckTheReferencesForTheFirstValue()
        {
            throw new NotImplementedException();
        }

        [Then(@"Record  in the Email Connector DB exist")]
        public void ThenRecordInTheEmailConnectorDBExist()
        {
            throw new NotImplementedException();
        }

        [Then(@"Email has references")]
        public void ThenEmailHasReferences()
        {
            throw new NotImplementedException();
        }
    }
}
