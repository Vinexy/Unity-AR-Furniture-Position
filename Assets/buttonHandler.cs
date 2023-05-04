using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonHandler : MonoBehaviour
{
    [SerializeField] private GameObject chairSpawn;
    Vector3 pos;
    // Start is called before the first frame update
    public void onPress()
    {
        
        Instantiate(chairSpawn,pos,Quaternion.identity);
    }
    private void Update()
    {
        pos = new Vector3(GameObject.FindGameObjectsWithTag("Plane")[GameObject.FindGameObjectsWithTag("Plane").Length-1].transform.position.x, GameObject.FindGameObjectsWithTag("Plane")[GameObject.FindGameObjectsWithTag("Plane").Length - 1].transform.position.y + 1.0f, GameObject.FindGameObjectsWithTag("Plane")[GameObject.FindGameObjectsWithTag("Plane").Length - 1].transform.position.z);
    }
}
