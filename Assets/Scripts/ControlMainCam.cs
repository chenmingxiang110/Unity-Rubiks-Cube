using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMainCam : MonoBehaviour
{
    public float max_speed;
    
    Vector3 target_position;
    Vector3 target_rotation_euler;
    Quaternion target_rotation;
    Vector3 current_position;
    Quaternion current_rotation;
    string current_scene;

    float total_time;
    float speed;
    bool startingMoving;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        GameObject mainCam = GameObject.Find("Main Camera");
        current_position = mainCam.transform.position;
        current_rotation = mainCam.transform.rotation;
        target_position = new Vector3(2f, 3.5f, -6f);
        target_rotation_euler = new Vector3(32, 324, 0);

        current_scene = SceneManager.GetActiveScene().name;
        startingMoving = true;
        total_time = 0;
        target_rotation = Quaternion.Euler(target_rotation_euler);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject mainCam = GameObject.Find("Main Camera");
        if (!SceneManager.GetActiveScene().name.Equals(current_scene)) {
            current_scene = SceneManager.GetActiveScene().name;
            startingMoving = true;
            total_time = 0;
            if (current_scene.Contains("Starting")) {
                target_position = new Vector3(2f, 3.5f, -6f);
                target_rotation_euler = new Vector3(32, 324, 0);
            } else if (current_scene.Contains("Main")) {
                target_position = new Vector3(3.5f, 3.5f, -5f);
                target_rotation_euler = new Vector3(32, 328, 0);
            }
            target_rotation = Quaternion.Euler(target_rotation_euler);
        } else if (startingMoving) {
            if (total_time < 0.1f) {
                total_time += Time.deltaTime;
            } else if (total_time < 10f) {
                total_time += Time.deltaTime;
                float pos_diff = Vector3.Distance(current_position, target_position);
                float angle_diff = Quaternion.Angle(current_rotation, target_rotation);
                if (pos_diff < 0.015f && angle_diff < 0.15f) {
                    startingMoving = false;
                }

                if (speed < 1) {
                    speed += speed + Time.deltaTime * 0.15f;
                } else {
                    speed = 1;
                }
                current_position = Vector3.Lerp(
                    current_position, target_position,
                    speed * max_speed * Time.deltaTime
                );
                current_rotation = Quaternion.Lerp(
                    current_rotation, target_rotation,
                    speed * max_speed * Time.deltaTime
                );
            }
        }
        mainCam.transform.position = current_position;
        mainCam.transform.rotation = current_rotation;
    }
}
