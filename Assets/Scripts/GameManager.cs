using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    List<GameObject> collectables = new List<GameObject>();

    public static GameManager manager = new GameManager();

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

    public void set_active_object(GameObject object_toggle, bool active)
	{
        foreach(var obj in collectables) {
            if(obj ==object_toggle) {
                obj.SetActive(active);
			}
		}
	}

    public int active_count()
	{
        return collectables.Count();
	}
    
    public List<GameObject> get_collectables()
	{
        return collectables;
	}
}
