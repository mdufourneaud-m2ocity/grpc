namespace Helloworld {
    public interface IGreeter {
      THelloReply SayHello<THelloReply>(IHelloRequest request) where THelloReply : IHelloReply, new();
    }
}
