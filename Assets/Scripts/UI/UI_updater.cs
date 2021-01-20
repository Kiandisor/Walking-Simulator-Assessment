using UnityEngine;
using UnityEngine.UI;

/**  */
public class UI_updater : MonoBehaviour
{
    public Text    gem_text; /*!< Reference to a text object in the UI */
    private int    gems_aquired = 0; /*!< Internal count of the gems collected */
    private int    total_gems   = 0; /*!< Internal count of the gems collected */

    private string base_text = "Gems: "; /*! Base UI text */

    /** Start is called before the first frame update. Initialise the text showing in the UI */
    void Start()
    {
        gem_text.text+=gems_aquired;
        total_gems=crystal_manager.crystal_count();
    }

    /** Get the current collected gems from the crystal manager and add it to the UI text object */
    private void update_text() 
    {
        gems_aquired=crystal_manager.collected_amount();

        gem_text.text=base_text+$"{gems_aquired}/{total_gems}";
    }

    
    /** Update is called once per frame. Update the UI text to the current amount collected */
    void Update()
    {
        update_text();
    }
}
