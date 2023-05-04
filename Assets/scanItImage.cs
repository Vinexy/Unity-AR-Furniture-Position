using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scanItImage : MonoBehaviour
{
    private void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Plane").Length > 0)
        {
            gameObject.SetActive(false);
        }
    }
}
