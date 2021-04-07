using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeMover : MonoBehaviour
{
    public Transform centerCube;
    public Transform rootCube;
    public Text text;
    public CubeStatus cubeStatus;
    public ControlTimer controlTimer;
    public bool isLocked;

    Vector3 rotation;
    float rotation_sum;
    int speedMode;
    List<float> speeds;
    Transform root;
    bool shouldDestroy;

    // Start is called before the first frame update
    void Start()
    {
        root = null;
        speedMode = 2;
        speeds = new List<float>(new float[] { 0.8f, 1.6f, 3.2f, 6.4f, 12.8f, 25.6f, 51.2f });
        rotation_sum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (root != null) {
            if (shouldDestroy) {
                if (root.childCount>0) {
                    for (int i = 0; i < root.childCount; i++) {
                        root.GetChild(i).SetParent(rootCube);
                    }
                } else {
                    Destroy(root.gameObject);
                    root = null;
                    shouldDestroy = false;
                }
            } else {
                root.Rotate(rotation);
                rotation_sum += rotation.magnitude;
                if (rotation_sum >= 90) {
                    rotation_sum = 0;
                    if (rotation.x != 0) {
                        if (rotation.x<0) {
                            root.eulerAngles = new Vector3(-90, root.eulerAngles.y, root.eulerAngles.z);
                        } else {
                            root.eulerAngles = new Vector3(90, root.eulerAngles.y, root.eulerAngles.z);
                        }
                    } else if (rotation.y != 0) {
                        if (rotation.y < 0) {
                            root.eulerAngles = new Vector3(root.eulerAngles.x, -90, root.eulerAngles.z);
                        } else {
                            root.eulerAngles = new Vector3(root.eulerAngles.x, 90, root.eulerAngles.z);
                        }
                    } else {
                        if (rotation.z < 0) {
                            root.eulerAngles = new Vector3(root.eulerAngles.x, root.eulerAngles.y, -90);
                        } else {
                            root.eulerAngles = new Vector3(root.eulerAngles.x, root.eulerAngles.y, 90);
                        }
                    }
                    cleanRoot();
                    string status = cubeStatus.GetStatus();
                    //print(status);
                    if (cubeStatus.isFinished(status) && !controlTimer.readyToggle.isOn) {
                        controlTimer.readyToggle.isOn = true;
                        controlTimer.stopTimer();
                    }
                }
            }
        }
    }

    void moveCubes(Vector3 axis, bool is90Degree, bool isAll, int _orientation) {
        if (isAvailable()) {
            List<Transform> ts = findCubesInFront(axis, is90Degree, isAll);
            GameObject emptyGO = new GameObject();
            root = emptyGO.transform;
            foreach (Transform t in ts) {
                t.SetParent(root);
            }
            rotation = axis * _orientation * speeds[speedMode];
        }
    }

    void cleanRoot() {
        if (root!=null) {
            shouldDestroy = true;
        }
    }

    List<Transform> findCubesInFront(Vector3 axis, bool is90Degree, bool isAll) {
        List<Transform> result = new List<Transform>();
        if (isAll) {
            for (int i = 0; i < rootCube.childCount; i++) {
                Transform t = rootCube.GetChild(i);
                Vector3 v = t.position - centerCube.position;
                if (v.magnitude > 1e-4) {
                    result.Add(t);
                }
            }
        } else {
            for (int i = 0; i < rootCube.childCount; i++) {
                Transform t = rootCube.GetChild(i);
                Vector3 v = t.position - centerCube.position;
                if (v.magnitude > 1e-4) {
                    float cosine = Vector3.Dot(v, axis) / (v.magnitude * axis.magnitude);
                    if (is90Degree) cosine = Mathf.Abs(cosine);
                    if ((!is90Degree) && (cosine > 1e-4)) {
                        result.Add(t);
                    }
                    else if (is90Degree && (cosine < 1e-4)) {
                        result.Add(t);
                    }
                }
            }
        }
        return result;
    }

    public void updateRotSpeedText() {
        speedMode += 1;
        if (speedMode >= speeds.Count) speedMode = 0;
        text.text = "Rotation Speed: " + ((int)(speeds[speedMode] * 10)).ToString();
    }

    public bool isAvailable() {
        if (root == null && shouldDestroy == false) {
            return true;
        } else {
            return false;
        }
    }

    public void move(string code) {
        switch (code) {
            case "A_FL":
                moveCubes(rootCube.forward, false, true, 1);
                break;
            case "A_FR":
                moveCubes(rootCube.forward, false, true, -1);
                break;
            case "A_RF":
                moveCubes(rootCube.right, false, true, -1);
                break;
            case "A_RB":
                moveCubes(rootCube.right, false, true, 1);
                break;
            case "A_UR":
                moveCubes(rootCube.up, false, true, -1);
                break;
            case "A_UL":
                moveCubes(rootCube.up, false, true, 1);
                break;
            case "F_L":
                moveCubes(-rootCube.forward, false, false, -1);
                break;
            case "F_R":
                moveCubes(-rootCube.forward, false, false, 1);
                break;
            case "Fm_L":
                moveCubes(-rootCube.forward, true, false, -1);
                break;
            case "Fm_R":
                moveCubes(-rootCube.forward, true, false, 1);
                break;
            case "B_L":
                moveCubes(rootCube.forward, false, false, 1);
                break;
            case "B_R":
                moveCubes(rootCube.forward, false, false, -1);
                break;
            case "R_F":
                moveCubes(rootCube.right, false, false, -1);
                break;
            case "R_B":
                moveCubes(rootCube.right, false, false, 1);
                break;
            case "Rm_F":
                moveCubes(rootCube.right, true, false, -1);
                break;
            case "Rm_B":
                moveCubes(rootCube.right, true, false, 1);
                break;
            case "L_F":
                moveCubes(-rootCube.right, false, false, 1);
                break;
            case "L_B":
                moveCubes(-rootCube.right, false, false, -1);
                break;
            case "U_R":
                moveCubes(rootCube.up, false, false, -1);
                break;
            case "U_L":
                moveCubes(rootCube.up, false, false, 1);
                break;
            case "Um_R":
                moveCubes(rootCube.up, true, false, -1);
                break;
            case "Um_L":
                moveCubes(rootCube.up, true, false, 1);
                break;
            case "D_R":
                moveCubes(-rootCube.up, false, false, 1);
                break;
            case "D_L":
                moveCubes(-rootCube.up, false, false, -1);
                break;
        }
    }
}
