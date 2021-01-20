﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/** Manager class for crystals in the game scene with functions that can be used staticly to modify the data of the manager */
public class crystal_manager : MonoBehaviour 
{    
    public static crystal_manager _crystal_manager; /*!< Static crystal manager object */

    private int current_crystals = 0; /*!< Internal total amount of crystals in the scene */

    private List<GameObject> crystals = new List<GameObject>(); /*!< GameObjects of all the crystals in the scene */
    private List<Declarations.collect_status> crystal_status = new List<Declarations.collect_status>(); /*!< Collection status of all the crystals in the scene */
    private List<Declarations.created_time> creation_time = new List<Declarations.created_time>(); /*!< Check for when the Crystal was added to the crystal manager */
    
    /** Set up the manager but attaching it to a object and making it DontDestroy. Sets up the lists of the crystal manager */
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

        initialise_lists();
	}

    /** Get all GameObjects in the scene that is of the Crystal type, add it to the list and increment the overall internal crystal count */
    private void initialise_lists() { 
		var objects = FindObjectsOfType<Crystal>();

        foreach(var obj in objects) {
            if(obj.tag ==Declarations.tags._crystal) {
                crystals.Add(obj.gameObject);
                crystal_status.Add(Declarations.collect_status.not_collected);
                creation_time.Add(Declarations.created_time.start);

                current_crystals++;
			}
        } 
	}
    
    /** Change the collected status of the crystal in the list
     * @param GameObject Object of a crystal 
     * @param collect_status Status to update the crystal too
     **/
    public static void change_collected_status(GameObject obj, Declarations.collect_status update_status_to) 
    {
        var i =_crystal_manager.crystals.FindIndex(list_obj => list_obj == obj);
        _crystal_manager.crystal_status[i]=update_status_to;
    }

    /** Get the amount of collected crystals
     * @return Amount of crystals collected (int)
     */
    public static int collected_amount()
	{
        return _crystal_manager.crystal_status.Count(obj => obj==Declarations.collect_status.collected);
	}

    /** Add a crystal to the crystal manager manually
     * @param GameObject Object of a crystal 
     * @param collect_status Status to set the crystal too
     **/
    public static void late_add(GameObject obj, Declarations.collect_status status)
	{
        _crystal_manager.crystals.Add(obj);
        _crystal_manager.crystal_status.Add(status);
        _crystal_manager.creation_time.Add(Declarations.created_time.late);
	}
}
