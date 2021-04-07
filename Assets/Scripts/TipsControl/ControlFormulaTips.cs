using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ControlFormulaTips : MonoBehaviour
{
    public Transform tip;
    public Transform tipMidL;
    public Transform tipMidR;
    public Transform tipCross;
    public Transform tipFishL;
    public Transform tipFishR;
    public Transform tipCorner;
    public Transform tipTriL;
    public Transform tipTriR;
    public Transform tipQuad;
    public Transform CustomAlgoBble;

    Animator CustomAlgoBbleAnim;

    // Start is called before the first frame update
    void Start()
    {
        CustomAlgoBbleAnim = CustomAlgoBble.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleCustomFormula() {
        CustomAlgoBbleAnim.SetBool("isOpen", !CustomAlgoBbleAnim.GetBool("isOpen"));
    }

    public void callOutFormulaTips() {
        Transform tmpTip = tip;
        switch (EventSystem.current.currentSelectedGameObject.name) {
            case "TipMidL":
                tmpTip = tipMidL;
                break;
            case "TipMidR":
                tmpTip = tipMidR;
                break;
            case "TipCross":
                tmpTip = tipCross;
                break;
            case "TipFishL":
                tmpTip = tipFishL;
                break;
            case "TipFishR":
                tmpTip = tipFishR;
                break;
            case "TipCorner":
                tmpTip = tipCorner;
                break;
            case "TipTriL":
                tmpTip = tipTriL;
                break;
            case "TipTriR":
                tmpTip = tipTriR;
                break;
            case "TipQuad":
                tmpTip = tipQuad;
                break;
            default:
                tmpTip = tip;
                break;
        }
        Transform theTip = Instantiate(tmpTip);
        theTip.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        theTip.position = EventSystem.current.currentSelectedGameObject.transform.position;
        theTip.localScale = Vector3.zero;
    }
}
