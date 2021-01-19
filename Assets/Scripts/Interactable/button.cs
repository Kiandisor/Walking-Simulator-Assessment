using UnityEngine;

public class button : Interactable 
{
	// Start is called before the first frame update
	void Start()
    {
        base.Start(); 
    }

	public override void interact()
	{
		button_manager.change_collected_status(gameObject,pressed.yes);
	}

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
