using System.Runtime.Serialization;

[Serializable]
internal class KeyExistException : Exception
{
    public KeyExistException()
    {
    }

    public KeyExistException(string? message) : base(message)
    {
    }

    public KeyExistException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected KeyExistException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}