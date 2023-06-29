using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    private GameObject spawnedObject;
 

    // Start is called before the first frame update
    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    {
    if(spawnedObject == null) spawnedObject = Instantiate(objectToSpawn,transform.position,transform.rotation); 
    }
}
