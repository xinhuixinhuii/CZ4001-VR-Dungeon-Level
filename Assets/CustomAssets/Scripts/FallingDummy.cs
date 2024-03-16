using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FallingDummy : MonoBehaviour
{
    private Animator anim;
    public GameObject keyBarrier;
    public AudioSource audioData;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Throwable"))
        {
            anim = GetComponent<Animator>();
            anim.SetTrigger("Dies");
            keyBarrier.SetActive(false);
            audioData.PlayDelayed(1);
        }
    }
}
