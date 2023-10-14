namespace TaskManagement.Application;

public class DuplicateTitleException : Exception
{
    public DuplicateTitleException(string message) : base(message) {
    }
}