using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGyroController : MonoBehaviour
{
    public Quaternion defaultRot = Quaternion.identity;
    public Quaternion baseRotation = new Quaternion(0, 0, 1, 0);



    void Start()
    {
        GyroManager.Instance.EnableGyro();
    }


    void Update()
    {
        transform.localRotation = GyroManager.Instance.GetGyroRotation() * baseRotation;
    }

    
    public void ResetRotation()
    {
        defaultRot = transform.localRotation;
    }
}
