using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TemplateFx
{
    public class EnemyPartManager : MonoBehaviour
    {
        public EnemyPartController[] enemyPartControllerArray;

        private void OnEnable()
        {
            LevelManager.Instance.eventManager.OnEnemyRefleshButtonPressEvent += OnEnemyRefleshButtonPressEvent;
        }

       

        private void OnDisable()
        {
            LevelManager.Instance.eventManager.OnEnemyRefleshButtonPressEvent -= OnEnemyRefleshButtonPressEvent;
        }

        private void OnEnemyRefleshButtonPressEvent()
        {
            RefleshEnemy();
        }

        private void RefleshEnemy()
        {
            foreach(EnemyPartController enemyPartController in enemyPartControllerArray)
            {
                enemyPartController.RefleshJoint();
            }
        }
    }
}

