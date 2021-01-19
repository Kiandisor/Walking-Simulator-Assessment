using System.Collections.Generic;
using UnityEngine;

public enum pressed { no,yes }

public class button_manager : MonoBehaviour
{
    public static button_manager _button_manager;

    private List<GameObject> buttons = new List<GameObject>();
    private List<pressed> button_state = new List<pressed>();

	private void Awake()
	{
		// If there is not already an instance of GameManager, set it to this.
        if (_button_manager == null)
        {
            _button_manager = this;
        }
        //If an instance already exists, destroy whatever this object is to enforce the singleton.
        else if (_button_manager != this)
        {
            Destroy(gameObject);
        }

        //Set GameManager to DontDestroyOnLoad so that it won't be destroyed when reloading our scene.
        DontDestroyOnLoad(gameObject);

        var buttons_in_scene = FindObjectsOfType<button>();
        foreach(var obj in buttons_in_scene) {
            if (obj.tag==Declarations.tags._button) {
                buttons.Add(obj.gameObject);
                button_state.Add(pressed.no);
            }
		}
	}
	public static void change_collected_status(GameObject obj, pressed update_state_to) 
    {
        var i =_button_manager.buttons.FindIndex(list_obj => list_obj == obj);
        _button_manager.button_state[i]=update_state_to;
    }

    public static bool all_buttons_pressed()
	{
        return _button_manager.button_state.TrueForAll(states => states == pressed.yes);
	}
}
