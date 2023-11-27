using System;
using System.Collections.Generic;
using Lesson_2.Task_2.Characters;
using Lesson_2.Task_2.StateMachine.States;
using Lesson_2.Task_2.WorkComponents;
using UnityEngine;

namespace Lesson_2.Task_2.StateMachine
{
    public class AIStateMachine : IStateSwitcher
    {
        private Dictionary<Type, IState> _statesMap;
        private IState _currentState;
        private WorkChooser _workChooser;

        public AIStateMachine(AIBot bot, Type startState)
        {
            AIStateMachineData data = new AIStateMachineData();
            _workChooser = new WorkChooser(this);
            
            _statesMap = new Dictionary<Type, IState>()
            {
                { typeof(RestState), new RestState(this, data, bot) },
                { typeof(MiningState), new MiningState(this, data, bot) },
                { typeof(MovementState), new MovementState(this, data, bot, _workChooser) },
            };

            Debug.Log("AIStateMachine Inited");
            _currentState = _statesMap[startState];
            _currentState.Enter();
        }

        public void Switch<T>() where T : IState
        {
            IState state = _statesMap[typeof(T)];

            if (_currentState == null)
                throw new Exception("_currentState is Null");

            _currentState.Exit();
            _currentState = state;
            _currentState.Enter();
        }

        public void InputHandler(IWork work) => _currentState.InputHandler(work);
    }
}
