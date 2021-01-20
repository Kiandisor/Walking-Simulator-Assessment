using UnityEngine;

/** Derived Crystal class from interactable which is the main collectable in the game */
public class Crystal : Interactable
{
    /** Start is called before the first frame update */
    void Start()
    {
		base.Start();
    }

	/** Overriden interact function which marks the crystal as collected in the crystal manager and disables the object */
	public override void interact()
	{
		Debug.Log("Crystal");
		crystal_manager.change_collected_status(gameObject,Declarations.collect_status.collected);
		gameObject.SetActive(false);
	}

	/** Update is called once per frame. Checks to see if the user has clicked on the object */
	void Update()
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
