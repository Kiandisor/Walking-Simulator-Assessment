using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


/** Manager class for the levels in the build with functions that can be used staticly to change levels */
public class LevelManager : MonoBehaviour {
    public static LevelManager level_manager; /*!< Static level manager object */

    private Dictionary<string,string> scenes = new Dictionary<string,string>(); /*!< Dictionary of level keys and level paths in the build */

    /** Set up the manager but attaching it to a object and making it DontDestroy. Sets up the dictionary of the level manager */
	private void Awake()
    {
        // If there is not already an instance of GameManager, set it to this.
        if (level_manager == null)
        {
            level_manager = this;
        }
        //If an instance already exists, destroy whatever this object is to enforce the singleton.
        else if (level_manager != this)
        {
            Destroy(gameObject);
        }

        //Set GameManager to DontDestroyOnLoad so that it won't be destroyed when reloading our scene.
        DontDestroyOnLoad(gameObject);

        get_scenes();
    }
    
    /** Add levels to the dictionary */
    private void get_scenes() 
    {
        int level_index = 0;
        foreach(var scene in EditorBuildSettings.scenes) {
			if (scene.enabled) {
                scenes.Add($"Level {level_index}",scene.path);
                level_index++;
			}
		}
    }
    
    /** Change the scene for to one in the build by using the path to search for the scene
     * @param Level_Name name of the key in the dictionary
     */
    public static void change_current_scene(string level_name)
    {
		if (level_manager.scenes.ContainsKey(level_name)) {
                SceneManager.LoadScene(SceneUtility.GetBuildIndexByScenePath(level_manager.scenes[level_name]));
		}
		else {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
    }
}
