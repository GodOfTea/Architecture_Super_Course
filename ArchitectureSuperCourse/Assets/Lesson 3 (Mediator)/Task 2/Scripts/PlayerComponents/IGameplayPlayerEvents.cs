using System;

namespace Mediator.PlayerComponents
{
    public interface IGameplayPlayerEvents
    {
        public event Action<int> LevelUpdated;
        public event Action<int> HealthUpdated;
    }
}