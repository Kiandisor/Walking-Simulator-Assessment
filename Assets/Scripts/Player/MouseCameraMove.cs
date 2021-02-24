using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** Class that handles setting up the camera, locking the mouse to the middle of the screen and rotating with mouse movement  */
public class MouseCameraMove : MonoBehaviour
{
    public Transform player_body; /*!< Position of the player body */

    public float mouse_speed = 10F; /*!< Player mouse speed */
    public float X_rotation = 0F; /*!< Default rotation on the X axis */

    private float mouse_X = 0.0F;
    private float mouse_Y = 0.0F;

    // Start is called before the first frame update
	void Start()
	{
        Cursor.lockState=CursorLockMode.Locked; // Lock the cursor to the centre of the screen
	}

	/** Update is called once per frame. Sets the current rotation to the position to the mouse */
	void Update()
    {
#if UNITY_WIN
        mouse_X = Input.GetAxis(Declarations.inputs._mouse_x_axis) * mouse_speed * Time.deltaTime; // Current X position of mouse
        mouse_Y = Input.GetAxis(Declarations.inputs._mouse_y_axis) * mouse_speed * Time.deltaTime; // Current Y position of mouse
#elif UNITY_PS4
        float mouse_X = Input.GetAxis(Declarations.inputs._joystick_x_axis) * mouse_speed * Time.deltaTime; // Current X position of mouse
        float mouse_Y = Input.GetAxis(Declarations.inputs._joystick_y_axis) * mouse_speed * Time.deltaTime; // Current Y position of mouse
#endif
        // Clamp the X rotation to be between 90 and -90
        X_rotation-=mouse_Y;
        X_rotation=Mathf.Clamp(X_rotation,-90F,90F);
        
        // Rotate each axis
        transform.localRotation=Quaternion.Euler(X_rotation,0F,0F);
        player_body.Rotate(Vector3.up * mouse_X);
    }
}
