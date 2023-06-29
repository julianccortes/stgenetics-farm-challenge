
namespace STgenetics.Farm.Application.Behaviors
{
    using MediatR;
    using MediatR.Pipeline;
    using Microsoft.Extensions.Logging;

    public class LoggingBehaviour<TRequest> : IRequestPreProcessor<TRequest>
           where TRequest : IRequest
    {

        private readonly ILogger _logger;

        public LoggingBehaviour(ILogger<TRequest> logger)
        {
            _logger = logger;
        }

        public async Task Process(TRequest request, CancellationToken cancellationToken)
        {
            var requestName = typeof(TRequest).Name;

           await Task.Run(() => { _logger.LogInformation("STgenetics Farm Request: {Name}{@Request}", requestName, request); }, cancellationToken);
            
        }

    }
}
