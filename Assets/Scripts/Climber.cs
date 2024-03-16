using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Climber : MonoBehaviour
{
    private CharacterController character;
    public static string climbingHand = null;
    private ContinuousMoveProviderBase continuousMoveProvider;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        continuousMoveProvider = GetComponent<ContinuousMoveProviderBase>();
    }

    // Update is called once per frame
    void Update()
    {
        if(climbingHand is not null)
        {
            // Debug.Log("DISABLED CONTINUOUS MOVE PROVIDER");
            continuousMoveProvider.enabled = false;
            Climb();
        }
        else
        {
            continuousMoveProvider.enabled = true;
        }
    }

    // Calculate climbing movement
    void Climb()
    {
        // Debug.Log("CLIMBING");

        
        if(climbingHand == "Left")
        {
            InputDevices.GetDeviceAtXRNode(XRNode.LeftHand).TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 velocity);
            character.Move(transform.rotation * -velocity * Time.fixedDeltaTime);
            Debug.Log("MOVING IN DIRECTION: " + transform.rotation * -velocity * Time.fixedDeltaTime);
        }
        else if(climbingHand == "Right")
        {
            InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 velocity);
            
            character.Move(transform.rotation * -velocity * Time.fixedDeltaTime);
            Debug.Log("MOVING IN DIRECTION: " + transform.rotation * -velocity * Time.fixedDeltaTime);
        }
        
    }
}
