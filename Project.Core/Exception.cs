using System.Text.Json.Serialization;

namespace Project.Core;

[Serializable]
public class JsonDNEException : Exception
{
    public JsonDNEException(){}
    public JsonDNEException(string message) : base(message){}
    public JsonDNEException(string message, Exception DefaultMapDNEException) : base (message, DefaultMapDNEException){}
}
[Serializable]
public class InvalidIDException : Exception
{
    public InvalidIDException(){}
    public InvalidIDException(string message) : base(message){}
    public InvalidIDException(string message, Exception invalidIdException) : base(message, invalidIdException){}
}
[Serializable]
public class NullJsonException : Exception
{
    public NullJsonException(){}
    public NullJsonException(string message) : base(message){}
    public NullJsonException(string message, Exception invalidIdException) : base(message, invalidIdException){}
}