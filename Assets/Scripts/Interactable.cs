using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
	Color hover_colour = Color.blue;
	Color original_colour;
	MeshRenderer object_mesh;

    // Start is called before the first frame update
    public void Start()
    {
		object_mesh=GetComponent<MeshRenderer>();
		original_colour=object_mesh.material.color;
    }

	void OnMouseOver()
	{
		object_mesh.material.color=hover_colour;
	}

	void OnMouseExit()
	{
		object_mesh.material.color=original_colour;
	}

	public virtual void interact() 
	{
	}
}
