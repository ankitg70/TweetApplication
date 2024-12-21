using Azure.Messaging.ServiceBus;

namespace TweetApp.MessegeSender
{
    public class KafkaSender : IKafkaSender
    {
        async public void Publish(string message)
        {
            var conStr = "Endpoint=sb://tweetservicebus.servicebus.windows.net/;SharedAccessKeyName=TweetAppPolicy;SharedAccessKey=nkWpZwH1E4Cv9F3hnrHQdzDYWYvl/GN/RFozH5CODbA=;EntityPath=tweetapptopic";
            var client = new ServiceBusClient(conStr);
            var sender = client.CreateSender("tweetapptopic");
            var Message = new ServiceBusMessage(message);
            await sender.SendMessageAsync(Message);

        }
    }
}
