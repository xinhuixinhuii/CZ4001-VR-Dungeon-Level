using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class ForceReceiver : MonoBehaviour
{
    float mass = 60.0f; // defines the character mass
    Vector3 impact = Vector3.zero;
    private CharacterController _controller;

    void Start(){
      _controller = GetComponent<CharacterController>();
    }

    // add a force:
    public void AddImpact(Vector3 direction, float force){
      direction.Normalize();
      if (direction.y < 0) direction.y = -direction.y; // reflect down force on the ground
      impact += direction.normalized * force / mass;
      Debug.Log("Impact: " + impact);
    }

    void Update(){
      // apply the impact force:
      if (impact.magnitude > 0.2) _controller.Move(impact * Time.deltaTime);
      // consumes the impact energy each cycle:
      impact = Vector3.Lerp(impact, Vector3.zero, 5*Time.deltaTime);
    }
}
