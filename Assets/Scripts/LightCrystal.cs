using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCrystal : Crystal
{
    private bool has_been_collected = false;

    // Start is called before the first frame update
    void Start()
    {
        base.Start();
		crystal_manager.late_add(gameObject,collect_status.not_collected);
    }

	public override void interact()
	{
		base.interact();
		has_been_collected=true;
	}

	// Update is called once per frame
	void Update()
	{
		if (has_been_collected==false) {
			if (Input.GetMouseButtonDown(0)) {
				RaycastHit object_hit;
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

				if (Physics.Raycast(ray,out object_hit)) {
					if (object_hit.collider.gameObject==gameObject) {
						interact();
					}
				}
			}
		}
		else {
			gameObject.SetActive(false);
		}
	}
}
