namespace GreeterServer
{
    using System;
    using System.Threading.Tasks;
    using Grpc.Core;
    using Grpc.Core.Interceptors;

    public class ExceptionInterceptor : Interceptor {
        public override Task<TResponse> UnaryServerHandler<TRequest, TResponse>(
            TRequest                               request,
            ServerCallContext                      context,
            UnaryServerMethod<TRequest, TResponse> continuation) {
            try {
                return base.UnaryServerHandler(request, context, continuation);
            }
            catch (Exception exception) {
                throw new RpcException(new Status(StatusCode.Unknown, exception.Message));
            }
        }
    }
}
