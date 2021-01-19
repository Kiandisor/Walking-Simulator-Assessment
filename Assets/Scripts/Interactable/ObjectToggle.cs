using System.Collections.Generic;
using UnityEngine;

public class ObjectToggle : Interactable
{
    public List<GameObject> objects = new List<GameObject>();

    bool is_toggled = false;

    // Start is called before the first frame update
    void Start()
    {
        base.Start();
    }

	public override void interact()
	{
        is_toggled=!is_toggled;
		foreach(var obj in objects) {
            obj.SetActive(is_toggled);
		}
	}

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
