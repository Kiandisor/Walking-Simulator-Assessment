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
		crystal_manager.change_collected_status(gameObject,collect_status.collected);
		gameObject.SetActive(false);
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
