using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlMode: MonoBehaviour
{
    public int mode;
    public Button modeButton;
    public Transform rubiksArrows;

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

    public void changeMode()
    {
        mode += 1;
        if (mode >= modes.Count)
        {
            mode = 0;
        }
        if (mode == 0) {
            rubiksArrows.gameObject.SetActive(true);
        } else {
            rubiksArrows.gameObject.SetActive(false);
        }
        modeButton.GetComponentInChildren<Text>().text = modes[mode];
    }
}
