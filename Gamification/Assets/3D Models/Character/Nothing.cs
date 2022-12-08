using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nothing : MonoBehaviour
{
        private Transform Eye_l;
        private Transform Eye_r;
        private Transform Hend;
        private bool StateMachineBehaviour = false;

        void Start () 
        {
        Eye_l = this.GetComponent<Transform>().Find("root/hip/spine_01/spine_02/spine_03/neck/head/eye_l");
        Eye_r = this.GetComponent<Transform>().Find("root/hip/spine_01/spine_02/spine_03/neck/head/eye_r");
        }

        void Update () 
        {
        if(Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.J)) Rotate();
        }
        void Rotate()
        {
            if(StateMachineBehaviour == false)
            {
                Eye_l.Rotate(new Vector3(80, 0, 0), Space.World);
                Eye_r.Rotate(new Vector3(0, 20, 0), Space.Self);
                StateMachineBehaviour = true; 
            }
            else
            {
                Eye_l.Rotate(new Vector3(-80, 0, 0), Space.World);
                Eye_r.Rotate(new Vector3(0, -20, 0), Space.Self);
                StateMachineBehaviour = false; 
            }


        }
}
