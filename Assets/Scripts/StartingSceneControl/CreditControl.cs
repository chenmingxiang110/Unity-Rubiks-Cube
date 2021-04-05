using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CreditControl : MonoBehaviour
{
    public Transform credit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void callOutCredit() {
        Transform theTip = Instantiate(credit);
        theTip.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        theTip.position = EventSystem.current.currentSelectedGameObject.transform.position;
        theTip.localScale = Vector3.zero;
    }
}
