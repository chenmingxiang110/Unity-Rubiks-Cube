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
        speedMode = 1;
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

    public List<string> translate(List<string> std_moves) {
        List<string> result = new List<string>();

        foreach (string s in std_moves) {
            switch (s) {
                case "x":
                    result.Add("A_RB");
                    break;
                case "x_":
                    result.Add("A_RF");
                    break;
                case "x2":
                    result.Add("A_RF");
                    result.Add("A_RF");
                    break;
                case "y":
                    result.Add("A_UL");
                    break;
                case "y_":
                    result.Add("A_UR");
                    break;
                case "y2":
                    result.Add("A_UR");
                    result.Add("A_UR");
                    break;
                case "z":
                    result.Add("A_FR");
                    break;
                case "z_":
                    result.Add("A_FL");
                    break;
                case "z2":
                    result.Add("A_FL");
                    result.Add("A_FL");
                    break;
                case "U":
                    result.Add("U_L");
                    break;
                case "U_":
                    result.Add("U_R");
                    break;
                case "U2":
                    result.Add("U_R");
                    result.Add("U_R");
                    break;
                case "R":
                    result.Add("R_B");
                    break;
                case "R_":
                    result.Add("R_F");
                    break;
                case "R2":
                    result.Add("R_B");
                    result.Add("R_B");
                    break;
                case "F":
                    result.Add("F_R");
                    break;
                case "F_":
                    result.Add("F_L");
                    break;
                case "F2":
                    result.Add("F_R");
                    result.Add("F_R");
                    break;
                case "D":
                    result.Add("D_R");
                    break;
                case "D_":
                    result.Add("D_L");
                    break;
                case "D2":
                    result.Add("D_R");
                    result.Add("D_R");
                    break;
                case "L":
                    result.Add("L_F");
                    break;
                case "L_":
                    result.Add("L_B");
                    break;
                case "L2":
                    result.Add("L_F");
                    result.Add("L_F");
                    break;
                case "B":
                    result.Add("B_L");
                    break;
                case "B_":
                    result.Add("B_R");
                    break;
                case "B2":
                    result.Add("B_L");
                    result.Add("B_L");
                    break;
                case "E":
                    result.Add("Um_R");
                    break;
                case "E_":
                    result.Add("Um_L");
                    break;
                case "E2":
                    result.Add("Um_R");
                    result.Add("Um_R");
                    break;
                case "M":
                    result.Add("Rm_F");
                    break;
                case "M_":
                    result.Add("Rm_B");
                    break;
                case "M2":
                    result.Add("Rm_F");
                    result.Add("Rm_F");
                    break;
                case "S":
                    result.Add("Fm_R");
                    break;
                case "S_":
                    result.Add("Fm_L");
                    break;
                case "S2":
                    result.Add("Fm_R");
                    result.Add("Fm_R");
                    break;
                case "u":
                    result.Add("U_L");
                    result.Add("Um_L");
                    break;
                case "u_":
                    result.Add("U_R");
                    result.Add("Um_R");
                    break;
                case "u2":
                    result.Add("U_R");
                    result.Add("U_R");
                    result.Add("Um_R");
                    result.Add("Um_R");
                    break;
                case "r":
                    result.Add("R_B");
                    result.Add("Rm_B");
                    break;
                case "r_":
                    result.Add("R_F");
                    result.Add("Rm_F");
                    break;
                case "r2":
                    result.Add("R_B");
                    result.Add("R_B");
                    result.Add("Rm_B");
                    result.Add("Rm_B");
                    break;
                case "f":
                    result.Add("F_R");
                    result.Add("Fm_R");
                    break;
                case "f_":
                    result.Add("F_L");
                    result.Add("Fm_L");
                    break;
                case "f2":
                    result.Add("F_R");
                    result.Add("F_R");
                    result.Add("Fm_R");
                    result.Add("Fm_R");
                    break;
                case "d":
                    result.Add("D_R");
                    result.Add("Um_R");
                    break;
                case "d_":
                    result.Add("D_L");
                    result.Add("Um_L");
                    break;
                case "d2":
                    result.Add("D_R");
                    result.Add("D_R");
                    result.Add("Um_R");
                    result.Add("Um_R");
                    break;
                case "l":
                    result.Add("L_F");
                    result.Add("Rm_F");
                    break;
                case "l_":
                    result.Add("L_B");
                    result.Add("Rm_B");
                    break;
                case "l2":
                    result.Add("L_F");
                    result.Add("L_F");
                    result.Add("Rm_F");
                    result.Add("Rm_F");
                    break;
                case "b":
                    result.Add("B_L");
                    result.Add("Fm_L");
                    break;
                case "b_":
                    result.Add("B_R");
                    result.Add("Fm_R");
                    break;
                case "b2":
                    result.Add("B_L");
                    result.Add("B_L");
                    result.Add("Fm_L");
                    result.Add("Fm_L");
                    break;
            }
        }

        return result;
    }
}
