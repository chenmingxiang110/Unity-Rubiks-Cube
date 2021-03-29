using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipsMover : MonoBehaviour
{
    public float speed;

    int mode;
    Vector3 target_position;
    Vector3 destroy_position;

    // Start is called before the first frame update
    void Start()
    {
        mode = 1; // 1: opening; 0: stay; -1: closing
        target_position = new Vector3(960, 540, 0);
        destroy_position = new Vector3(960, -540, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (mode==-1) {
            transform.position = Vector3.Lerp(transform.position, destroy_position, 4 * speed * Time.deltaTime);
        } else {
            transform.position = Vector3.Lerp(transform.position, target_position, 4 * speed * Time.deltaTime); 
        }
        if (mode==1) {
            transform.localScale += new Vector3(
                Time.deltaTime * speed,
                Time.deltaTime * speed,
                Time.deltaTime * speed
            );
            if (transform.localScale.x>=1) {
                transform.localScale = new Vector3(1, 1, 1);
                mode = 0;
            }
        } else if (mode==-1) {
            transform.localScale -= new Vector3(
                Time.deltaTime * speed,
                Time.deltaTime * speed,
                Time.deltaTime * speed
            );
            if (transform.localScale.x <= 0) {
                transform.localScale = Vector3.zero;
                Destroy(transform.gameObject);
            }
        }
    }

    public void close() {
        mode = -1;
    }
}
