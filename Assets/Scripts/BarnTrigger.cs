using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarnTrigger : MonoBehaviour
{

    public static bool ramp1_1;
    public static bool ramp1_2;
    public static bool ramp1_3;
    public static bool ramp2_1;
    public static bool ramp2_2;
    public static bool ramp2_3;
    public static bool ramp3_1;
    public static bool ramp3_2;
    public static bool ramp3_3;
    // Start is called before the first frame update
    void Start()
    {
        Triggers.ramp1 = false;
        Triggers.ramp2 = false;
        Triggers.ramp3 = false;

        ramp1_1 = false;
        ramp1_2 = false;
        ramp1_3 = false;
        ramp2_1 = false;
        ramp2_2 = false;
        ramp2_3 = false;
        ramp3_1 = false;
        ramp3_2 = false;
        ramp3_3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ramp1_1 && ramp1_2 && ramp1_3)
        {
            Triggers.ramp1 = true;
        }
        if (ramp2_1 && ramp2_2 && ramp2_3)
        {
            Triggers.ramp2 = true;
        }
        if (ramp3_1 && ramp3_2 && ramp3_3)
        {
            Triggers.ramp3 = true;
        }
    }
    
    void OnTriggerStay(Collider other) 
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            Triggers.ramp1 = true;
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            Triggers.ramp2 = true;
        }if (Input.GetKeyDown(KeyCode.F3))
        {
            Triggers.ramp3 = true;
        }
    }

    public static void CheckTargetHit(string target)
    {
        if (target == "TRamp1.1")
        {
            ramp1_1 = true;
        }
        if (target == "TRamp1.2")
        {
            ramp1_2 = true;
        }
        if (target == "TRamp1.3")
        {
            ramp1_3 = true;
        }
        if (target == "TRamp2.1")
        {
            ramp2_1 = true;
        }
        if (target == "TRamp2.2")
        {
            ramp2_2 = true;
        }
        if (target == "TRamp2.3")
        {
            ramp2_3 = true;
        }
        if (target == "TRamp3.1")
        {
            ramp3_1 = true;
        }
        if (target == "TRamp3.2")
        {
            ramp3_2 = true;
        }
        if (target == "TRamp3.3")
        {
            ramp3_3 = true;
        }
    }
}
