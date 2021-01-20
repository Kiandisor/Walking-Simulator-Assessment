using System.Collections.Generic;
using UnityEngine;

/** Script which handles toggling objects in the scripts list of GameObjects on and off when interacted with */
public class ObjectToggle : Interactable
{
    public List<GameObject> objects = new List<GameObject>(); /*!< List of GameObjects that can be modified in the unity editor */

    private bool is_toggled = false; /*!< Check if the object the script is attached to has been toggled */

    // Start is called before the first frame update
    void Start()
    {
        base.Start();
    }
	/** Overriden interact function which toggles the internal is_toggled state and set all of the GameObjects in the list to the toggled status */
	public override void interact()
	{
        is_toggled=!is_toggled;
		foreach(var obj in objects) {
            obj.SetActive(is_toggled);
		}
	}
	/** Update is called once per frame. Objects in the list will be toggled on and off based off the toggled status */
	private void Update()
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
