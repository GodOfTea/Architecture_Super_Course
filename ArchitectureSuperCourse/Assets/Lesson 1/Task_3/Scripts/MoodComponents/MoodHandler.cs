using System;
using System.Linq;
using Lesson_1.Task_3.Enumerations;
using UnityEngine;

namespace Lesson_1.Task_3.MoodComponents
{
    public class MoodHandler
    {
        private const int DefaultMoodIndex = 5;
        private const int MinMoodIndex = 0;
        private const int MaxMoodIndex = 10;
        
        private MoodLevel[] _moodLevels;
        private IMood _currentMood;
        private int _moodIndex;

        public event Action<IMood> MoodChanged;
        public event Action<int> MoodValueChanged;

        public int StartMoodIndex => DefaultMoodIndex;
        public IMood CurrentMood => _currentMood; /* Добавлено только ради получения значения на старте. 
                                                    Можно убрать event MoodChanged, но с ивентом код кажется удобнее */
        public MoodHandler(MoodsList moodsList)
        {
            _moodIndex = DefaultMoodIndex;
            _moodLevels = new MoodLevel[]
            {
                new MoodLevel(moodsList.GetMood(MoodType.Annoyed), 2),
                new MoodLevel(moodsList.GetMood(MoodType.Flattered), 8),
                new MoodLevel(moodsList.GetMood(MoodType.Calm), 3),
            }.OrderBy(level => level.Index).ToArray();

            TryChangeMood();
        }

        public void IncreaseMood()
        {
            ++_moodIndex;

            if (_moodIndex >= MaxMoodIndex)
                _moodIndex = MaxMoodIndex;
            
            MoodValueChanged?.Invoke(_moodIndex);

            if (TryChangeMood())
                MoodChanged?.Invoke(_currentMood);
        }

        public void DecreaseMood()
        {
            --_moodIndex;
            
            if (_moodIndex <= MinMoodIndex)
                _moodIndex = MinMoodIndex;
            
            MoodValueChanged?.Invoke(_moodIndex);
            
            if (TryChangeMood())
                MoodChanged?.Invoke(_currentMood);
        }

        private bool TryChangeMood()
        {
            IMood mood = _moodLevels.First().GetMood();
            foreach (MoodLevel moodLevel in _moodLevels)
            {
                if (_moodIndex >= moodLevel.Index)
                    mood = moodLevel.GetMood();
            }

            if (mood != _currentMood)
            {
                _currentMood = mood;
                return true;
            }

            return false;
        }
    }
}