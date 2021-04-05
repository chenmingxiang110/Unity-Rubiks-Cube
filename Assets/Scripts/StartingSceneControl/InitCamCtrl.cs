using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitCamCtrl : MonoBehaviour
{
    public GameObject CamCtrl;
    // Start is called before the first frame update
    void Start()
    {
        GameObject mainCam = GameObject.Find("MainCamCtrl");
        if (mainCam==null) {
            GameObject go = Instantiate(CamCtrl);
            go.name = "MainCamCtrl";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
