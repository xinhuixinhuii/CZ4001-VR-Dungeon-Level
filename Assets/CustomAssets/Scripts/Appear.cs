using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{

    public static int itemCount = 0;
    public GameObject key;

    private void Update()
    {
        // print(itemCount);
        if(itemCount == 4)
        {
            key.SetActive(true);
        }
    }
}
