using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpInteract:ObjectToggle {
    private bool touched = false;
    // Start is called before the first frame update
    void Start()
    {
        base.Start();
    }

    public override void interact()
    {
        touched=true;
    }
}
