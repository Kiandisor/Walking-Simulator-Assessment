using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClicked : MonoBehaviour
{
    private Button current_button;
    // Start is called before the first frame update
    void Start()
    {
        current_button=gameObject.GetComponent<Button>();

        current_button.onClick.AddListener(run_change_scene);
    }

    // Update is called once per frame
    void run_change_scene()
    {
        MenusManger.run_menu_function(gameObject.name);
    }
}
