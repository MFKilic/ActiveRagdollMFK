using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TemplateFx
{

    public class BulletController : MonoBehaviour
    {
        public Rigidbody rbBullet;
        const string ragdollPartsString = "RagdollParts";
        int layerRagdollPartsCount;

        private void Start()
        {
            layerRagdollPartsCount = LayerMask.NameToLayer(ragdollPartsString);
            StartCoroutine(LifeTimer());
        }

        IEnumerator LifeTimer()
        {
            yield return new WaitForSeconds(1);
            gameObject.SetActive(false);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.layer.Equals(layerRagdollPartsCount))
            {
                EnemyPartController enemyPartController = collision.gameObject.GetComponent<EnemyPartController>();
                if(enemyPartController != null)
                {
                    enemyPartController.EnemyPartHit();
                }
            }
            
        }
    }

}



