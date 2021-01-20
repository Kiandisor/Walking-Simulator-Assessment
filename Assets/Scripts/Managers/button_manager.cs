using System.Collections.Generic;
using UnityEngine;


/** Manager class for buttons in the game scene with functions that can be used staticly to modify the data of the manager */
public class button_manager : MonoBehaviour
{
    public static button_manager _button_manager;

    private List<GameObject> buttons = new List<GameObject>(); /*!< GameObjects of all the buttonss in the scene */
    private List<Declarations.pressed> button_state = new List<Declarations.pressed>();

    private void Awake()
    {
        // If there is not already an instance of GameManager, set it to this.
        if (_button_manager==null) {
            _button_manager=this;
        }
        //If an instance already exists, destroy whatever this object is to enforce the singleton.
        else if (_button_manager!=this) {
            Destroy(gameObject);
        }

        //Set GameManager to DontDestroyOnLoad so that it won't be destroyed when reloading our scene.
        DontDestroyOnLoad(gameObject);

        initialise_lists();
    }

    private void initialise_lists() 
    {
        var buttons_in_scene = FindObjectsOfType<button>();
        foreach(var obj in buttons_in_scene) {
            if (obj.tag==Declarations.tags._button) {
                buttons.Add(obj.gameObject);
                button_state.Add(Declarations.pressed.no);
            }
		}
    }

	/** Change the pressed status of the button in the list
     * @param GameObject Object of a button
     * @param pressed_status Status to update the button too
     **/
	public static void change_pressed_status(GameObject obj, Declarations.pressed update_state_to) 
    {
        var i =_button_manager.buttons.FindIndex(list_obj => list_obj == obj);
        _button_manager.button_state[i]=update_state_to;
    }

	/** Change the pressed status of the button in the list
     * @return bool Result of all buttons being pressed or not
     */
    public static bool all_buttons_pressed()
	{
        return _button_manager.button_state.TrueForAll(states => states == Declarations.pressed.yes);
	}
}
