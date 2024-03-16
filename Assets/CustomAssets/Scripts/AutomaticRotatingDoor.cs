using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class AutomaticRotatingDoor : MonoBehaviour
{
    public GameObject movingDoor;
    public GameObject key;

    public float maximumOpening = -0.7071f;
    public float movementSpeed = 5f;

    int timesEntered = 0;
    bool itemIsHere;
    public AudioSource audioData;

    void Start()
    {
        itemIsHere = false;
    }

    void Update()
    {
        if (itemIsHere)
        {
            if (movingDoor.transform.rotation.y > maximumOpening)
            {
                movingDoor.transform.Rotate(0f, -movementSpeed * Time.deltaTime, 0f, Space.Self);
            }
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (key.CompareTag(col.gameObject.tag))
        {
            if(timesEntered == 0)
            {
                audioData.Play();
            }
            timesEntered++;
            itemIsHere = true;
        }
    }
}