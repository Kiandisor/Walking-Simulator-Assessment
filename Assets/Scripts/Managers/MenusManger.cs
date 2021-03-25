using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenusManger : BaseManager
{
    public static MenusManger         menus_manager;

    private Dictionary<string,Action> menus_functions = new Dictionary<string,Action>();

    // Start is called before the first frame update
    void Awake()
    {
		// If there is not already an instance of GameManager, set it to this.
        if (menus_manager==null) {
            menus_manager=this;
			DontDestroyOnLoad(gameObject);
        }
        //If an instance already exists, destroy whatever this object is to enforce the singleton.
        else if (menus_manager!=this) {
            Destroy(gameObject);
        }
		initialise_data();
    }


	public override void initialise_data()
	{
        var buttons = Resources.FindObjectsOfTypeAll<Button>();

        foreach(var button in buttons) {
			if(menus_functions.ContainsKey(button.name)==false){
                switch (button.name) {
                    case Declarations.buttons._play:
                        menus_functions.Add(Declarations.buttons._play,MenuFunctions.play_game);
                        break;
                    case Declarations.buttons._menu:
                        menus_functions.Add(Declarations.buttons._menu,MenuFunctions.to_main_menu);
                        break;
                    case Declarations.buttons._settings:
                        break;
                    case Declarations.buttons._quit:
                        menus_functions.Add(Declarations.buttons._quit,MenuFunctions.quit_game);
                        break;
                }
            }
        }
	}
    
    public static void late_add(Button[] buttons_to_add)
	{
        foreach(var button in buttons_to_add) {
			if(menus_manager.menus_functions.ContainsKey(button.name)==false){
                switch (button.name) {
                    case Declarations.buttons._play:
                        menus_manager.menus_functions.Add(Declarations.buttons._play,MenuFunctions.play_game);
                        break;
                    case Declarations.buttons._menu:
                        menus_manager.menus_functions.Add(Declarations.buttons._menu,MenuFunctions.to_main_menu);
                        break;
                    case Declarations.buttons._settings:
                        break;
                    case Declarations.buttons._quit:
                        menus_manager.menus_functions.Add(Declarations.buttons._quit,MenuFunctions.quit_game);
                        break;
                }
            }
        }
    }

    public static void run_menu_function(string obj_name) 
    {
		if (menus_manager.menus_functions.ContainsKey(obj_name)) {
            menus_manager.menus_functions[obj_name]();
		}
    }
}
