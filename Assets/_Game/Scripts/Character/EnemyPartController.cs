using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TemplateFx
{
    public class EnemyPartController : MonoBehaviour
    {
        [HideInInspector] public ConfigurableJoint configurableJoint;
        // Start is called before the first frame update
        void Start()
        {
            if(configurableJoint == null)
            {
                configurableJoint = GetComponent<ConfigurableJoint>();
            }
        }

        public void RefleshJoint()
        {
            JointDrive jointDriveX = configurableJoint.angularXDrive;
            jointDriveX.positionSpring = 1000;
            configurableJoint.angularXDrive = jointDriveX;

            JointDrive jointDriveYZ = configurableJoint.angularYZDrive;
            jointDriveYZ.positionSpring = 1000;
            configurableJoint.angularYZDrive = jointDriveYZ;
        }

        public void EnemyPartHit()
        {
            JointDrive jointDriveX = configurableJoint.angularXDrive;
            jointDriveX.positionSpring = 1;
            configurableJoint.angularXDrive = jointDriveX;

            JointDrive jointDriveYZ = configurableJoint.angularYZDrive;
            jointDriveYZ.positionSpring = 1;
            configurableJoint.angularYZDrive = jointDriveYZ;

        }

       
    }
}


