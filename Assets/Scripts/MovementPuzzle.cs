using System.Collections.Generic;
using UnityEngine;

public class MovementPuzzle : MonoBehaviour
{
    public GameObject player;
    private PlayerMovement player_controller;

    public List<GameObject> platforms = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
       player_controller=player.GetComponent<PlayerMovement>();
        
       foreach(var obj in platforms) {
	   } 
    }
    
    private void check_platforms()
	{
		for (int i = 0;i<platforms.Count;++i) {
        }
	}

    // Update is called once per frame
    void Update()
    {
        check_platforms();
    }
}
