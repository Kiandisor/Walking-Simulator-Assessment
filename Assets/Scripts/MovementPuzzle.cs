using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPuzzle : MonoBehaviour
{
    public GameObject player;
    private PlayerMovement player_controller;

    public List<GameObject> platforms = new List<GameObject>();
    private List<JumpInteract> platforms_touched = new List<JumpInteract>();

    // Start is called before the first frame update
    void Start()
    {
       player_controller=player.GetComponent<PlayerMovement>();
        
       foreach(var obj in platforms) {
            platforms_touched.Add(obj.GetComponent<JumpInteract>());
	   } 
    }
    
    private void check_platforms()
	{
		for (int i = 0;i<=platforms.Count;++i) {
            if (player_controller.is_touching(platforms[i])) {
                platforms_touched[i].interact();
            }
        }
	}

    // Update is called once per frame
    void Update()
    {
        check_platforms();
    }
}
