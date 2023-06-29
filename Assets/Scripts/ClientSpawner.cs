using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientSpawner : MonoBehaviour
{
   
    public GameObject clientToSpawn;
    public GameObject wayPoint;
    private GameObject spawnedObject;
    private Test_script clientMove;

 

    // Start is called before the first frame update
    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    {
    if(spawnedObject == null) spawnedObject = Instantiate(clientToSpawn,transform.position,transform.rotation); 
    clientMove = spawnedObject.GetComponent<Test_script>();
    clientMove.setWaypoint(wayPoint);
    }
}

