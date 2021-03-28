using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlShuffle : MonoBehaviour
{
    public Text shuffleText;
    public CubeMover cubemover;

    System.Random rnd;
    int stepsLeft;
    int mode;
    List<string> modes;
    List<string> movingCodes;

    // Start is called before the first frame update
    void Start()
    {
        rnd = new System.Random();

        stepsLeft = 0;
        mode = 0;
        modes = new List<string>();
        modes.Add("Shuffle (10 Steps)");
        modes.Add("Shuffle (20 Steps)");
        modes.Add("Shuffle (40 Steps)");

        movingCodes = new List<string>(new string[] {
            "F_L","F_R","Fm_L","Fm_R","B_L","B_R",
            "R_F","R_B","Rm_F","Rm_B","L_F","L_B",
            "U_R","U_L","Um_R","Um_L","D_R","D_L" });
    }

    // Update is called once per frame
    void Update()
    {
        if (stepsLeft>0) {
            if (cubemover.isAvailable()) {
                stepsLeft -= 1;
                string code = movingCodes[rnd.Next(movingCodes.Count)];
                cubemover.move(code);
            }
        }
    }

        // Update is called once per frame
        public void modeIncrease() {
        mode += 1;
        if (mode >= modes.Count) {
            mode = 0;
        }
        shuffleText.text = modes[mode];
    }

    public void modeReduce() {
        mode -= 1;
        if (mode < 0) {
            mode = modes.Count-1;
        }
        shuffleText.text = modes[mode];
    }

    public void shuffleCube() {
        switch (mode) {
            case 0:
                stepsLeft = 10;
                break;
            case 1:
                stepsLeft = 20;
                break;
            case 2:
                stepsLeft = 40;
                break;
        }
    }
}
