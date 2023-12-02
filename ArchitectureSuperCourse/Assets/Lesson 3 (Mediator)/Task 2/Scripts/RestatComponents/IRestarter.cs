using System;

namespace Mediator
{
    public interface IRestarter
    {
        event Action OnRestart;
    }
}