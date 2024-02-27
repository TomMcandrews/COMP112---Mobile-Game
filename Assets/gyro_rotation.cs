using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyro_rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        Quaternion phoneRotation = new Quaternion();
        phoneRotation = Input.gyro.attitude;

        phoneRotation.Set(phoneRotation[0], phoneRotation[1], phoneRotation[2], phoneRotation[3]);

        transform.rotation = phoneRotation;
        Debug.Log(phoneRotation);

    }
}
