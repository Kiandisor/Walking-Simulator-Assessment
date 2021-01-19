using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    public static LevelManager level_manager;

    private Dictionary<string,string> scenes = new Dictionary<string,string>();

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
