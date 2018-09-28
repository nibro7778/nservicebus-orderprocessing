using System.Threading.Tasks;
using NServiceBus;
using Order.Message;

namespace Order.Handlers
{
    public class ProcessOrderCommandHandler : IHandleMessages<ProcessOrderCommand>
    {
        public Task Handle(ProcessOrderCommand message, IMessageHandlerContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}
