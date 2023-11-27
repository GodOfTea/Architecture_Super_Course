using System;
using DG.Tweening;
using Lesson_2.Task_2.Characters;
using UnityEngine;

namespace Lesson_2.Task_2.StateMachine.States
{
    public class MovementState : AIState
    {
        private readonly Vector3 _rotationAngle = new Vector3(0f, 180f, 0f);
        private readonly string _stateLog = "Start Move";

        private IWorkChooser _workChooser;

        public MovementState(IStateSwitcher stateSwitcher, AIStateMachineData data, AIBot bot,
            IWorkChooser workChooser) :
            base(stateSwitcher, data, bot)
        {
            _workChooser = workChooser;
        }

        public override void Enter()
        {
            base.Enter();
            MoveTo(Data.CurrentWorkPosition);
        }

        private void MoveTo(Vector3 point)
        {
            Sequence moveSequence = DOTween.Sequence();
            moveSequence.Append(BotTransform.DOLocalRotate(
                BotTransform.localRotation.eulerAngles + _rotationAngle, Config.RotationTime));
            moveSequence.Append(BotTransform.DOMove(point, Config.MoveTime));
            moveSequence.AppendCallback(EndMove);
        }

        private void EndMove()
        {
            Action nextWork = _workChooser.GetWork(Data.CurrentWorkType);
            nextWork();
        }

        protected override void Log(string text)
        {
            base.Log(_stateLog);
        }
    }
}