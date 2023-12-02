using System;

namespace Mediator.PlayerComponents
{
    public interface ILosePlayerEvents
    {
        event Action HealthEnded;
    }
}