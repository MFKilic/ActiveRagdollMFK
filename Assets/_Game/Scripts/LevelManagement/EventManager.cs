using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TemplateFx
{
    public class EventManager : MonoBehaviour
    {
        public delegate void OnFirstInputDelegate();
        public event OnFirstInputDelegate OnFirstInputEvent;

        public delegate void OnEnemyRefleshButtonPressDelegate();
        public event OnEnemyRefleshButtonPressDelegate OnEnemyRefleshButtonPressEvent;

        public delegate void OnEnemyNewEnemyButtonPressDelegate();
        public event OnEnemyNewEnemyButtonPressDelegate OnEnemyNewEnemyButtonPressEvent;

        public void OnEnemyRefleshButtonPress()
        {
            OnEnemyRefleshButtonPressEvent?.Invoke();
        }

        public void OnEnemyNewEnemyButtonPress()
        {
            OnEnemyNewEnemyButtonPressEvent?.Invoke();
        }

        public void OnFirstInputIsPressed()
        {
            OnFirstInputEvent?.Invoke();
        }
       
    }
}

