using UnityEngine;

/** Main player class that manages the user input */
public class PlayerMovement : MonoBehaviour
{
    /** Player Properties */
    public CharacterController player_controller; /*!< Current player position */
    public uint player_speed = 10; /*!< Base move speed for the player */
    public float jump_height = 5F; /*!< Bade jumping height for the player */

    /** Gravity Properties */
    public float gravity = -9.81F; /*!< Pull of the gravity to bring the player to the ground */
    private Vector3 player_velocity; /*!< Current player velocity */

    /** Ground Detection */
    public Transform ground_check; /*!< Posision of the object to check if the player is on the ground */
    public float ground_distance = 0.4F; /*!< Base distance between the player and the ground */
    public LayerMask ground_mask; /*!< Mask of the object for the physics check */
    private bool is_grounded; /*!< State of whether the player is on the ground or not */

    private Transform camera_position; /*!< Current camera position */

    /** Set the camera position to the camera attached to the player object */
	private void Start()
	{
        camera_position=GetComponentInChildren<Camera>().transform;
	}

    /** Check and reset the players velocity if the player is on the ground */
	private void reset_velocity() 
    {
        if(is_grounded && player_velocity.y <0) {
            player_velocity.y=-2F;
		}
    }

    /** Check if the jump button is pressed and the player is grounded to make the player jump */
    private void player_jump()
	{
		if(Input.GetButtonDown(Declarations.inputs._jump_button) && is_grounded) {
            player_velocity.y=Mathf.Sqrt(jump_height*-2*gravity);
		}
	}
    
    /** Move the player through the Character_Controller */
    private void player_move()
	{
		// Get the X and Z position
        float X_pos = Input.GetAxis(Declarations.positions._horizontal_axis);
        float Z_pos = Input.GetAxis(Declarations.positions._vertical_axis);

        Vector3 temp_foward = camera_position.forward;
        Vector3 temp_right = camera_position.right;

        temp_foward.y=0.0F;
        temp_right.y=0.0F;

        temp_foward.Normalize();
        temp_right.Normalize();

        Vector3 move_to = temp_right*X_pos+temp_foward*Z_pos;

        player_controller.Move(move_to * player_speed * Time.deltaTime);
	}

    /** Pull the player back down to the ground */
    private void gravity_drag_down()
	{
		// Gravity
        player_velocity.y+=gravity*Time.deltaTime;
        player_controller.Move(player_velocity * Time.deltaTime);
	}

	/** Update is called once per frame. Updates the current position of the player in the world */
	void Update()
    {
        is_grounded=Physics.CheckSphere(ground_check.position,ground_distance,ground_mask);

        reset_velocity();

        player_move();
        
        player_jump();

        gravity_drag_down();
	}
}
