using MediatR;

namespace Core.Common.Behaviors;

public class UnhandledExceptionBehaviour<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    //private readonly ILogger _logger = Log.ForContext<TRequest>();

    public async Task<TResponse> Handle
    (
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken
    )
    {
        try { return await next(); }
        catch (Exception ex)
        {
            string requestName = typeof(TRequest).Name;
            //_logger.Error
            //(
            //    ex,
            //    "Request: Unhandled Exception for Request {@Name} {@Request}",
            //    requestName, request
            //);
            throw;
        }
    }
}