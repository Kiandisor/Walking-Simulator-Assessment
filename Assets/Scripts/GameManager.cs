using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    List<GameObject> collectables = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        var objects = FindObjectsOfType<GameObject>();
        foreach(var obj in objects) {
            if(obj.tag =="Collectables") {
                collectables.Add(obj);
			}
        } 
    }
    
    public List<GameObject> get_collectables()
	{
        return collectables;
	}
}
