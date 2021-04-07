using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBadAlgoTip : MonoBehaviour
{
    public Transform BadAlgoTip;

    Animator BadAlgoTipAnim;
    float clock;
    // Start is called before the first frame update
    void Start()
    {
        BadAlgoTipAnim = BadAlgoTip.GetComponent<Animator>();
        clock = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (clock > 0) {
            clock = clock - Time.deltaTime;
        } else if (BadAlgoTipAnim.GetBool("isOpen")) {
            BadAlgoTipAnim.SetBool("isOpen", false);
        }
    }

    public void setTimer(float f) {
        BadAlgoTipAnim.SetBool("isOpen", true);
        clock = f;
    }
}
