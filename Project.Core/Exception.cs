namespace Project.Core;

[Serializable]
class NullIncidentJsonException : Exception
{
    public NullIncidentJsonException()
    {
        
    }
    public NullIncidentJsonException(string message) : base(message)
    {
    }
    public NullIncidentJsonException(string message, Exception nullException) : base(message, nullException)
    {
        
    }
}
[Serializable]
class InvalidIncidentIdReferenceException : Exception
{
    public InvalidIncidentIdReferenceException(){}
    public InvalidIncidentIdReferenceException(string message) : base(message){}
    public InvalidIncidentIdReferenceException(string message, Exception invalidIdException) : base(message, invalidIdException){}
}