using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public uint player_speed = 10;
    public uint rotation_speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // !Check the input of the player and move the object
    void check_input() 
    {
		if (Input.GetKey(KeyCode.W)) {
            gameObject.transform.Translate(Vector3.forward*Time.deltaTime*player_speed);
        }
		if (Input.GetKey(KeyCode.A)) {
			gameObject.transform.Translate(Vector3.left*Time.deltaTime*player_speed);
        }
		if (Input.GetKey(KeyCode.S)) {
			gameObject.transform.Translate(Vector3.back*Time.deltaTime*player_speed);
        }
		if (Input.GetKey(KeyCode.D)) { 
			gameObject.transform.Translate(Vector3.right*Time.deltaTime*player_speed);
        }
		if (Input.GetKey(KeyCode.E)) { }
    }

    // Update is called once per frame
    void Update()
    {
        check_input();        
    }
}
