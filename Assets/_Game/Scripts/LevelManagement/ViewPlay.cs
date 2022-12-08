using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


namespace TemplateFx
{

    public class ViewPlay : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI textLevel;
        // Start is called before the first frame update
        public void ViewPlayStart()
        {
            textLevel.text = "LEVEL " + LevelManager.Instance.datas.level;
        }
       
        public void RefleshButtonPressed()
        {
            LevelManager.Instance.eventManager.OnEnemyRefleshButtonPress();
        }

        public void NewEnemyButtonPressed()
        {
            LevelManager.Instance.eventManager.OnEnemyNewEnemyButtonPress();
        }

       
    }

}

