using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TemplateFx
{

    public class PlayerGunController : MonoBehaviour
    {
        [SerializeField] GameObject bulletObjectPrefab;

       

        // Update is called once per frame
        void Update()
        {

            if (Input.GetMouseButtonDown(0))
            {
                FireBullet(AimLockVector());
            }

        }

        private Vector3 AimLockVector()
        {
            Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Vector3 ballMove = Vector3.zero;

            if (Physics.Raycast(_ray, out hit, 100f))
            {
                ballMove = hit.point;
            }
            else
            {
                ballMove = _ray.origin + _ray.direction * 100f;
            }

            return ballMove;

        }
        private void FireBullet(Vector3 aimVector)
        {
            GameObject bulletObject = Instantiate(bulletObjectPrefab, transform.position,
                transform.rotation, LevelManager.Instance.enviromentHolderTransform);

            BulletController bulletController = bulletObject.GetComponent<BulletController>();
            Rigidbody rbBullet = bulletController.rbBullet;

            bulletController.transform.LookAt(aimVector);
            rbBullet.velocity = bulletController.transform.forward * 20;
        

        }
    }

}

