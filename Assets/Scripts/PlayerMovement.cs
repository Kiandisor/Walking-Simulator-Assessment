using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Player Properties
    public CharacterController player_controller;
    public uint player_speed = 10;
    public float jump_height = 5F;

    // Gravity Properties
    public float gravity = -9.81F;
    Vector3 player_velocity;

    // Ground Detection
    public Transform ground_check;
    public float ground_distance = 0.4F;
    public LayerMask ground_mask;
    bool is_grounded;

    private void reset_velocity() 
    {
        if(is_grounded && player_velocity.y <0) {
            player_velocity.y=-2F;
		}
    }

    private void player_jump()
	{
		if(Input.GetButtonDown("Jump") && is_grounded) {
            player_velocity.y=Mathf.Sqrt(jump_height*-2*gravity);
		}
	}
    
    private void player_move()
	{
		// Get the X and Z position
        float X_pos = Input.GetAxis("Horizontal");
        float Z_pos = Input.GetAxis("Vertical");

        Vector3 move_to = transform.right*X_pos+transform.forward*Z_pos;

        player_controller.Move(move_to * player_speed * Time.deltaTime);
	}

    private void gravity_drag_down()
	{
		// Gravity
        player_velocity.y+=gravity*Time.deltaTime;
        player_controller.Move(player_velocity * Time.deltaTime);
	}

	// Update is called once per frame
	void Update()
    {
        is_grounded=Physics.CheckSphere(ground_check.position,ground_distance,ground_mask);

        reset_velocity();

        player_move();
        
        player_jump();

        gravity_drag_down();
	}
}
