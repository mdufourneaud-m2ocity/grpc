namespace Helloworld {
    using System;

    public class GreeterCore : IGreeter {
        public THelloReply SayHello<THelloReply>(IHelloRequest request) where THelloReply : IHelloReply, new() {
            throw new Exception(":(");
            return new THelloReply { Message = "Hello " + request.Name };
        }
    }
}
