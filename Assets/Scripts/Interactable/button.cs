using UnityEngine;

/** Derived button class from interactable */
public class button : Interactable 
{
	// Start is called before the first frame update
	void Start()
    {
        base.Start(); 
    }

	/** Overriden interact function which marks the button as pressed in the button manager */
	public override void interact()
	{
		button_manager.change_pressed_status(gameObject,Declarations.pressed.yes);
	}

	/** Update is called once per frame. Checks to see if the user has clicked on the object */
	public void Update()
	{
		if (Input.GetMouseButtonDown(Declarations.inputs._left_click)) {
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
