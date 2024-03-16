using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private InputActionProperty jumpButton;
    [SerializeField] private float jumpHeight = 3f;
    [SerializeField] private CharacterController cc;
    [SerializeField] private LayerMask groundLayers;

    private float gravity = Physics.gravity.y;
    private Vector3 movement;

    private void Update()
    {
        if (jumpButton.action.WasPressedThisFrame())
        {
            Jump();
        }
        if(Climber.climbingHand is null)
        {
            movement.y += gravity * Time.deltaTime;
            cc.Move(movement * Time.deltaTime);
        }

    }

    private void Jump()
    {
        movement.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
    }
}
