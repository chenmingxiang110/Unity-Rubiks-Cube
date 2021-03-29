using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlTimer : MonoBehaviour
{
    public Text text;
    public Toggle readyToggle;

    bool isRunning;
    float current_time;

    // Start is called before the first frame update
    void Start() {
        isRunning = false;
        current_time = 0;
    }

    // Update is called once per frame
    void Update() {
        if (isRunning) {
            current_time += Time.deltaTime;
        }
        text.text = parseTime(current_time);

        if (!readyToggle.isOn && Input.anyKeyDown) {
            readyToggle.isOn = true;
            isRunning = true;
        }
    }

    string parseTime(float t) {
        int n_min = (int)(t / 60);
        if (n_min>99) {
            return "99' 99\" 99";
        }
        int n_sec = (int)(t - n_min * 60);
        int n_msec = (int)((t - n_min * 60 - n_sec) * 100);
        string s_min = n_min.ToString();
        string s_sec = n_sec.ToString();
        string s_msec = n_msec.ToString();
        if (s_min.Length == 1) s_min = "0" + s_min;
        if (s_sec.Length == 1) s_sec = "0" + s_sec;
        if (s_msec.Length == 1) s_msec = "0" + s_msec;
        return s_min + "' "+ s_sec + "\" " + s_msec;
    }

    public void toggleTimer() {
        if (isRunning) {
            isRunning = false;
        } else {
            isRunning = true;
        }
    }

    public void clearTimer() {
        isRunning = false;
        current_time = 0;
    }
}
