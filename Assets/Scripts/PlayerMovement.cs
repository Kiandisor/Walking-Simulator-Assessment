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

    private Transform camera_position;

	private void Start()
	{
        camera_position=GetComponentInChildren<Camera>().transform;
	}

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

        Vector3 temp_foward = camera_position.forward;
        Vector3 temp_right = camera_position.right;

        temp_foward.y=0.0F;
        temp_right.y=0.0F;

        temp_foward.Normalize();
        temp_right.Normalize();

        Vector3 move_to = temp_right*X_pos+temp_foward*Z_pos;

        player_controller.Move(move_to * player_speed * Time.deltaTime);
	}

    private void gravity_drag_down()
	{
		// Gravity
        player_velocity.y+=gravity*Time.deltaTime;
        player_controller.Move(player_velocity * Time.deltaTime);
	}	

    public bool is_touching(GameObject obj)
	{
        return Physics.CheckSphere(obj.transform.position,ground_distance);
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
