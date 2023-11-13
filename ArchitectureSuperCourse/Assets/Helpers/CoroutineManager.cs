using System.Collections;
using UnityEngine;

namespace Helpers
{
    public class CoroutineManager : MonoBehaviour
    {
        private static CoroutineManager instance
        {
            get
            {
                if (_instance == null)
                {
                    GameObject gameObject = new GameObject("[Coroutine Manager]");
                    _instance = gameObject.AddComponent<CoroutineManager>();
                    DontDestroyOnLoad(gameObject);
                }

                return _instance;
            }
        }

        private static CoroutineManager _instance;

        public static Coroutine StartRoutine(IEnumerator enumerator)
        {
            return instance.StartCoroutine(enumerator);
        }

        public static void StopRoutine(Coroutine routine)
        {
            if (routine != null)
            {
                instance.StopCoroutine(routine);
            }
        }
    }
}