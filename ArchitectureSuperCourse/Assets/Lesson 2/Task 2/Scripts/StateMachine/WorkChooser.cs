using System;
using System.Collections.Generic;
using Lesson_2.Task_2.StateMachine.States;
using Lesson_2.Task_2.WorkComponents;

namespace Lesson_2.Task_2.StateMachine
{
    public class WorkChooser : IWorkChooser
    {
        private Dictionary<WorkType, Action> _workStatesMap;
        private IStateSwitcher _stateSwitcher;

        public WorkChooser(IStateSwitcher stateSwitcher)
        {
            _stateSwitcher = stateSwitcher;
            
            _workStatesMap = new Dictionary<WorkType, Action>()
            {
                { WorkType.Mining, () => _stateSwitcher.Switch<MiningState>()},
                { WorkType.Rest, () => _stateSwitcher.Switch<RestState>()},
            };
        }

        public Action GetWork(WorkType type)
        {
            return _workStatesMap[type];
        }
    }
}