using System;

namespace Mediator
{
    public class Restart : IRestarter, IRestartEnabler
    {
        public event Action OnRestart;

        public void Enable()
        {
            OnRestart?.Invoke();
        }
    }
}