using UnityEngine;
using UnityEngine.UI;

public class ControlCamBg : MonoBehaviour {
    public Image imageBg;
    public float changingSpeed255;
    public float minValue255;

    float changingSpeed;
    float minValue;

    int stage;

    // Start is called before the first frame update
    void Start() {
        stage = 0;
        changingSpeed = changingSpeed255 / 255;
        minValue = minValue255 / 255;
        imageBg.color = new Color(minValue, 1f, 1f);
    }

    // Update is called once per frame
    void Update() {
        Color c = new Color(imageBg.color.r, imageBg.color.g, imageBg.color.b);
        // Debug.Log(c);
        switch (stage) {
            case 0:
                c.b -= Time.deltaTime * changingSpeed;
                if (c.b <= minValue) {
                    c.b = minValue;
                    addOne2Statge();
                }
                imageBg.color = c;
                break;
            case 1:
                c.r += Time.deltaTime * changingSpeed;
                if (c.r >= 1) {
                    c.r = 1;
                    addOne2Statge();
                }
                imageBg.color = c;
                break;
            case 2:
                c.g -= Time.deltaTime * changingSpeed;
                if (c.g <= minValue) {
                    c.g = minValue;
                    addOne2Statge();
                }
                imageBg.color = c;
                break;
            case 3:
                c.b += Time.deltaTime * changingSpeed;
                if (c.b >= 1) {
                    c.b = 1;
                    addOne2Statge();
                }
                imageBg.color = c;
                break;
            case 4:
                c.r -= Time.deltaTime * changingSpeed;
                if (c.r <= minValue) {
                    c.r = minValue;
                    addOne2Statge();
                }
                imageBg.color = c;
                break;
            case 5:
                c.g += Time.deltaTime * changingSpeed;
                if (c.g >= 1) {
                    c.g = 1;
                    addOne2Statge();
                }
                imageBg.color = c;
                break;
        }
    }

    void addOne2Statge() {
        stage += 1;
        if (stage > 5) stage = 0;
    }
}
