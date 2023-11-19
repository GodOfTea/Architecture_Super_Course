namespace Lesson_1.Task_3.MoodComponents
{
    public class MoodLevel
    {
        private IMood _mood;
        private int _index;

        public int Index => _index;

        public MoodLevel(IMood mood, int index)
        {
            _mood = mood;
            _index = index;
        }

        public IMood GetMood()
        {
            return _mood;
        }
    }
}