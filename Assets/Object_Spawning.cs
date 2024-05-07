using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using TMPro;

public class Object_Spawning : MonoBehaviour
{
    public GameObject Point1;
    public GameObject Point2;
    public GameObject Point3;
    public GameObject Point4;
    public GameObject Point5;

    public GameObject Obstacle1;
    public GameObject Obstacle2;
    public GameObject Obstacle3;
    public GameObject RespawnTrigger;
    public float Score = 0;
    public TMP_Text ScoreText;

    public int LocationPointer;

    // Start is called before the first frame update
    void Start()
    {
        SpawnObstacle1();
        SpawnObstacle2();
        SpawnObstacle3();
    }

    // Update is called once per frame
    void Update()
    {
        Point1 = GameObject.Find("Point 1");
        Point2 = GameObject.Find("Point 2");
        Point3 = GameObject.Find("Point 3");
        Point4 = GameObject.Find("Point 4");
        Point5 = GameObject.Find("Point 5");

        Obstacle1 = GameObject.Find("Obstacle1");
        Obstacle2 = GameObject.Find("Obstacle2");
        Obstacle3 = GameObject.Find("Obstacle3");

        Obstacle1.transform.Translate(new Vector3(0,0,1) * 5 * Time.deltaTime);
        Obstacle2.transform.Translate(new Vector3(0,0,1) * 5 * Time.deltaTime);
        Obstacle3.transform.Translate(new Vector3(0,0,1) * 5 * Time.deltaTime);
    }

    void SpawnObstacle1()
    {
        //Picks one of 5 spawn locations for the obstacle and teleports it there
        LocationPointer = Random.Range(1, 11);
        if (LocationPointer == 1) 
        {
            Obstacle1.transform.position = Point1.transform.position;
        }
        else if (LocationPointer == 2) 
        {
            Obstacle1.transform.position = Point2.transform.position;
        }
        else if (LocationPointer == 3)
        {
            Obstacle1.transform.position = Point3.transform.position;
        }
        else if (LocationPointer == 4)
        {
            Obstacle1.transform.position = Point4.transform.position;
        }
        else if (LocationPointer == 5)
        {
            Obstacle1.transform.position = Point5.transform.position;
        }


        Debug.Log(LocationPointer);
    }

    void SpawnObstacle2()
    {
        //Picks one of 5 spawn locations for the obstacle and teleports it there
        LocationPointer = Random.Range(1, 11);
        if (LocationPointer == 1)
        {
            Obstacle1.transform.position = Point1.transform.position;
        }
        else if (LocationPointer == 2)
        {
            Obstacle2.transform.position = Point2.transform.position;
        }
        else if (LocationPointer == 3)
        {
            Obstacle2.transform.position = Point3.transform.position;
        }
        else if (LocationPointer == 4)
        {
            Obstacle2.transform.position = Point4.transform.position;
        }
        else if (LocationPointer == 5)
        {
            Obstacle2.transform.position = Point5.transform.position;
        }
        


        Debug.Log(LocationPointer);
    }

    void SpawnObstacle3()
    {
        LocationPointer = Random.Range(1, 11);
        if (LocationPointer == 1)
        {
            Obstacle3.transform.position = Point1.transform.position;
        }
        else if (LocationPointer == 2)
        {
            Obstacle3.transform.position = Point2.transform.position;
        }
        else if (LocationPointer == 3)
        {
            Obstacle3.transform.position = Point3.transform.position;
        }
        else if (LocationPointer == 4)
        {
            Obstacle3.transform.position = Point4.transform.position;
        }
        else if (LocationPointer == 5)
        {
            Obstacle3.transform.position = Point5.transform.position;
        }

        Debug.Log(LocationPointer);
    }

    void OnTriggerEnter(Collider Other)
    {
        SpawnObstacle1();
        SpawnObstacle2();
        SpawnObstacle3();
    }
    
}
