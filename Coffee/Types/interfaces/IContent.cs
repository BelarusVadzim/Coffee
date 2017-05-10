namespace Coffee {
    public interface IContent {
        //Content.ContentType CurrentContentType { get; }
        int Volume { get; }

        void Add(IContent content);
        IContent Subtraction(int Volume);
    }
}