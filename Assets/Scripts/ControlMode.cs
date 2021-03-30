using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlMode: MonoBehaviour
{
    public int mode;
    public Button modeButton;
    public Transform rubiksArrows;
    public CubeMover cubemover;
    public ControlShuffle controlShuffle;
    public CubeFormulas cubeFormulas;

    List<string> modes;

    public void Start()
    {
        mode = 0;
        modes = new List<string>();
        modes.Add("Keyboard + Mouse");
        modes.Add("Keyboard");
        
        if (mode==0) {
            rubiksArrows.gameObject.SetActive(true);
        } else {
            rubiksArrows.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (mode == 0 && cubemover.isAvailable() && controlShuffle.stepsLeft<=0 && cubeFormulas.stepsLeft <= 0) {
            rubiksArrows.gameObject.SetActive(true);
        }
        else {
            rubiksArrows.gameObject.SetActive(false);
        }
    }

    public void changeMode() {
        mode += 1;
        if (mode >= modes.Count)
        {
            mode = 0;
        }
        modeButton.GetComponentInChildren<Text>().text = modes[mode];
    }

    public void quitGame() {
        Application.Quit();
    }
}
