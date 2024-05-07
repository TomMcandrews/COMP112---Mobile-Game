using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyro_rotation : MonoBehaviour
{
    float movementScale = 1f;

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

        transform.rotation = phoneRotation;
    }
}
