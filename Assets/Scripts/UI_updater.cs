﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

public class UI_updater : MonoBehaviour
{
    public Text gem_text;
    private int gems_aquired = 0;

    // Start is called before the first frame update
    void Start()
    {
        gem_text.text+=gems_aquired;
    }

    private void update_text() 
    {
        gems_aquired=crystal_manager.collected_amount();

        gem_text.text="Gems: "+gems_aquired.ToString();
    }

    
    // Update is called once per frame
    void Update()
    {
        update_text();
    }
}
