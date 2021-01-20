using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuFunctions : MonoBehaviour
{
	/** Call the level manager change current scene function and return to the main menu */
	public static void to_main_menu()
	{
		LevelManager.change_current_scene(Declarations.levels._main_menu);
	}
	
	public static void play_game()
	{
		LevelManager.change_current_scene(Declarations.levels._forest_level);
	}
	
	/** Quit the game */
	public static void quit_game()
	{
		Application.Quit();
	}
}
