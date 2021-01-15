using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class UIManager : MonoBehaviour
{
    public Text gem_text;
    private int gems_aquired = 0;

    // Start is called before the first frame update
    void Start()
    {
        gem_text.text+=gems_aquired;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.manager.active_count()>gems_aquired) {
            gems_aquired++;
            gem_text.text+=gems_aquired;
        }
    }
}
