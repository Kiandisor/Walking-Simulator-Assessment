using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InactiveCrystal : Crystal 
{
    bool active = false;

    // Start is called before the first frame update
    void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        active=button_manager.all_buttons_pressed();

        if (active == true) {
            if (Input.GetMouseButtonDown(Declarations.inputs._left_click)) {
                RaycastHit object_hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray,out object_hit)) {
                    if (object_hit.collider.gameObject==gameObject) {
                        interact();
                    }
                }
            }
        }

    }
}
