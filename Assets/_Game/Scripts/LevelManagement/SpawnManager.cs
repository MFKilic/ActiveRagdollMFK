using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

namespace TemplateFx
{
    public class SpawnManager : Singleton<SpawnManager>
    {
        [SerializeField] GameObject characterObjectPrefab;

        private void OnEnable()
        {
            LevelManager.Instance.eventManager.OnEnemyNewEnemyButtonPressEvent += OnEnemyNewEnemyButtonPressEvent;
        }

        

        private void OnDisable()
        {
            LevelManager.Instance.eventManager.OnEnemyNewEnemyButtonPressEvent -= OnEnemyNewEnemyButtonPressEvent;
        }

        private void OnEnemyNewEnemyButtonPressEvent()
        {
            CreateCharacters();
        }

        public void CreateCharacters()
        {
            GameObject characterObject = Instantiate(characterObjectPrefab,
                Vector3.zero, Quaternion.Euler(0,180,0), LevelManager.Instance.characterHolderTransform);

        }
    }

}

