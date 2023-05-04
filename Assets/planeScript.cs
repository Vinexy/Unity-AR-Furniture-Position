using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeScript : MonoBehaviour
{
    [SerializeField] private GameObject chairPrefab;
    void Start()
    {
        if (GameObject.FindGameObjectsWithTag("Plane").Length == 1)
        {
            Instantiate(chairPrefab);
        }
        

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
