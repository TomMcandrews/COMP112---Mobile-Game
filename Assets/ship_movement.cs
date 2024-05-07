using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class ship_movement : MonoBehaviour
{

    public GameObject Ship;
    public float Rotation;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        Speed = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        Ship = GameObject.Find("Ship");

        if (Ship.transform.eulerAngles.x <= 180f)
        {
            Rotation = Ship.transform.eulerAngles.y;
        }
        else
        {
            Rotation = Ship.transform.eulerAngles.y - 360f;
        }

        //if (Rotation > 25)
        //{
        //    transform.Translate(Vector3.right * Speed * Time.deltaTime);
        //}
        //else if(Rotation < -25)
        //{
        //    transform.Translate(Vector3.left * Speed * Time.deltaTime);
        //}

        Debug.Log(Rotation);

    }
}
