using UnityEngine;

/** Base interactable class that manages any object changing colour whenever the mouse is over the object */
public class Interactable : MonoBehaviour
{
	private Color hover_colour = Color.blue; /*!< Colour the object turns to when the mouse is hovering over it */
	private Color original_colour; /*!< Original Colour of the object */
	private MeshRenderer object_mesh; /*!< Current objects mesh renderer */

    // Start is called before the first frame update
    public void Start()
    {
		object_mesh=GetComponent<MeshRenderer>();
		original_colour=object_mesh.material.color;
    }
	
	/** When the mouse is over the current object change the colour of the object to hover_colour */
	void OnMouseOver()
	{
		object_mesh.material.color=hover_colour;
	}

	/** Reset the objects colour back when the mouse is no longer hovering over the object */
	void OnMouseExit()
	{
		object_mesh.material.color=original_colour;
	}

	/** Virtual function to handle different objects being interacted with differently */
	public virtual void interact() 
	{
	}
}
