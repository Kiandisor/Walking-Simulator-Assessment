using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : Interactable
{
    // Start is called before the first frame update
    void Start()
    {
		base.Start(); 
    }

	public override void interact()
	{
		Debug.Log("Crystal");
		gameObject.SetActive(false);
		GameManager.manager.set_active_object(gameObject,false);
	}

	// Update is called once per frame
	void Update()
    {
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit object_hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if(Physics.Raycast(ray,out object_hit)) {
				if (object_hit.collider.gameObject==gameObject) {
					interact();
				}
			}
		}   
    }
}
