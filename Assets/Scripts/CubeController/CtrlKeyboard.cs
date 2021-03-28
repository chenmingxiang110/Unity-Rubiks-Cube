using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlKeyboard : MonoBehaviour
{
    public ControlMode cmode;
    public CubeMover cubemover;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cmode.mode==1) {
            if (Input.GetKeyDown(KeyCode.A)) {
                if (Input.GetKey(KeyCode.I)) {
                    cubemover.move("U_L");
                } else if (Input.GetKey(KeyCode.K)) {
                    cubemover.move("D_L");
                }
                else {
                    cubemover.move("A_UL");
                }
            } else if (Input.GetKeyDown(KeyCode.D)) {
                if (Input.GetKey(KeyCode.I)) {
                    cubemover.move("U_R");
                }
                else if (Input.GetKey(KeyCode.K)) {
                    cubemover.move("D_R");
                }
                else {
                    cubemover.move("A_UR");
                }
            } else if (Input.GetKeyDown(KeyCode.W)) {
                if (Input.GetKey(KeyCode.J)) {
                    cubemover.move("L_B");
                }
                else if (Input.GetKey(KeyCode.L)) {
                    cubemover.move("R_B");
                }
                else {
                    cubemover.move("A_RB");
                }
            }
            else if (Input.GetKeyDown(KeyCode.S)) {
                if (Input.GetKey(KeyCode.J)) {
                    cubemover.move("L_F");
                }
                else if (Input.GetKey(KeyCode.L)) {
                    cubemover.move("R_F");
                }
                else {
                    cubemover.move("A_RF");
                }
            } else if (Input.GetKeyDown(KeyCode.Q)) {
                if (Input.GetKey(KeyCode.I)) {
                    cubemover.move("B_L");
                }
                else if (Input.GetKey(KeyCode.K)) {
                    cubemover.move("F_L");
                }
                else {
                    cubemover.move("A_FL");
                }
            }
            else if (Input.GetKeyDown(KeyCode.E)) {
                if (Input.GetKey(KeyCode.I)) {
                    cubemover.move("B_R");
                }
                else if (Input.GetKey(KeyCode.K)) {
                    cubemover.move("F_R");
                }
                else {
                    cubemover.move("A_FR");
                }
            }
        }
    }
}
