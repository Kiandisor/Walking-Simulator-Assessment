using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum collect_status {
    collected,not_collected
}

public class crystal_manager : MonoBehaviour 
{    
    public static crystal_manager _crystal_manager;

    private readonly List<GameObject> crystals = new List<GameObject>();
    private List<collect_status> crystal_status = new List<collect_status>();

	private void Awake()
    {
        // If there is not already an instance of GameManager, set it to this.
        if (_crystal_manager == null)
        {
            _crystal_manager = this;
        }
        //If an instance already exists, destroy whatever this object is to enforce the singleton.
        else if (_crystal_manager != this)
        {
            Destroy(gameObject);
        }

        //Set GameManager to DontDestroyOnLoad so that it won't be destroyed when reloading our scene.
        DontDestroyOnLoad(gameObject);

        var objects = FindObjectsOfType<Crystal>();

        foreach(var obj in objects) {
            if(obj.tag =="Collectables") {
                crystals.Add(obj.gameObject);
                crystal_status.Add(collect_status.not_collected);
			}
        } 
    }

    private void initialise_lists() { 
            }
    
    public static void change_collected_status(GameObject obj, collect_status update_status_to) 
    {
        for(int i = 0; i<_crystal_manager.crystals.Count;i++) {
            if(_crystal_manager.crystals[i] == obj) {
                _crystal_manager.crystal_status[i]=update_status_to;
			}
		} 
    }

    public static int collected_amount()
	{
        return _crystal_manager.crystal_status.Count(obj => obj==collect_status.collected);
	}
}
