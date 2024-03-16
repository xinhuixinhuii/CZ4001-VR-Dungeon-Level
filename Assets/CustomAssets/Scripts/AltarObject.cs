using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarObject : MonoBehaviour
{
    public GameObject item;
    private bool placed = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(item.tag) && !placed)
        {
            Appear.itemCount++;
            placed = true;
        }
    }
}
