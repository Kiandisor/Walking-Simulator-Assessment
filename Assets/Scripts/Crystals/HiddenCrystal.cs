using UnityEngine;

/** Specialised crystal which handles the game object starting off as inactive */
public class HiddenCrystal : Crystal
{
    private bool has_been_collected = false; /*!< Internal state of the object being collected or not which decides if the gameObject can re-appear */

    /** Start is called before the first frame update. Adds the crystal to the crystal manager as a late addition */
    void Awake()
    {
		Start();
		crystal_manager.late_add(gameObject,collect_status.not_collected);
    }

	/** Overriden interact function which calls the base crystal interact and mark the object as collected internally */
	public override void interact()
	{
		base.interact();
		has_been_collected=true;
	}

	/** Update is called once per frame. Mouse input will vary based the status of the object being collected or not */
	void Update()
	{
		if (has_been_collected==false) {
			if (Input.GetMouseButtonDown(Declarations.inputs._left_click)) {
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
