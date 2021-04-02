using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeStatus : MonoBehaviour
{
    public Transform RubiksCube;

    List<Transform> colorfulFaces;
    // Start is called before the first frame update
    void Start()
    {
        colorfulFaces = new List<Transform>();
        for (int i = 0; i< RubiksCube.childCount; i++) {
            Transform cube = RubiksCube.GetChild(i);
            for (int j = 0; j<cube.childCount; j++) {
                Transform cubeson = cube.GetChild(j);
                string mat_name = cubeson.gameObject.GetComponent<Renderer>().material.name;
                if (cubeson.name.Contains("Face") && !mat_name.Contains("Gray")) {
                    colorfulFaces.Add(cubeson);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string GetStatus() {
        char[] theArray = new char[54];
        
        // right -> left, up -> down, front -> back
        foreach (Transform face in colorfulFaces) {
            // real values should be 1.05 and 1.55, here we use 0.75 and 1.35 for stability
            if (face.position.x > 1.35) {
                // right
                if (face.position.y > 0.75) {
                    // up
                    if (face.position.z < -0.75) {
                        // front
                        theArray[0] = face.GetComponent<Renderer>().material.name[0];
                    } else if (face.position.z > 0.75) {
                        // back
                        theArray[2] = face.GetComponent<Renderer>().material.name[0];
                    } else {
                        //mid
                        theArray[1] = face.GetComponent<Renderer>().material.name[0];
                    }
                } else if (face.position.y < -0.75) {
                    // down
                    if (face.position.z < -0.75) {
                        // front
                        theArray[6] = face.GetComponent<Renderer>().material.name[0];
                    } else if (face.position.z > 0.75) {
                        // back
                        theArray[8] = face.GetComponent<Renderer>().material.name[0];
                    } else {
                        //mid
                        theArray[7] = face.GetComponent<Renderer>().material.name[0];
                    }
                } else {
                    // mid
                    if (face.position.z < -0.75) {
                        // front
                        theArray[3] = face.GetComponent<Renderer>().material.name[0];
                    } else if (face.position.z > 0.75) {
                        // back
                        theArray[5] = face.GetComponent<Renderer>().material.name[0];
                    } else {
                        //mid
                        theArray[4] = face.GetComponent<Renderer>().material.name[0];
                    }
                }
            } else if (face.position.x < -1.35) {
                // left
                if (face.position.y > 0.75) {
                    // up
                    if (face.position.z < -0.75) {
                        // front
                        theArray[9] = face.GetComponent<Renderer>().material.name[0];
                    } else if (face.position.z > 0.75) {
                        // back
                        theArray[11] = face.GetComponent<Renderer>().material.name[0];
                    } else {
                        //mid
                        theArray[10] = face.GetComponent<Renderer>().material.name[0];
                    }
                } else if (face.position.y < -0.75) {
                    // down
                    if (face.position.z < -0.75) {
                        // front
                        theArray[15] = face.GetComponent<Renderer>().material.name[0];
                    } else if (face.position.z > 0.75) {
                        // back
                        theArray[17] = face.GetComponent<Renderer>().material.name[0];
                    } else {
                        //mid
                        theArray[16] = face.GetComponent<Renderer>().material.name[0];
                    }
                } else {
                    // mid
                    if (face.position.z < -0.75) {
                        // front
                        theArray[12] = face.GetComponent<Renderer>().material.name[0];
                    } else if (face.position.z > 0.75) {
                        // back
                        theArray[14] = face.GetComponent<Renderer>().material.name[0];
                    } else {
                        //mid
                        theArray[13] = face.GetComponent<Renderer>().material.name[0];
                    }
                }
            } else if (face.position.y > 1.35) {
                // up
                if (face.position.x > 0.75) {
                    // right
                    if (face.position.z < -0.75) {
                        // front
                        theArray[18] = face.GetComponent<Renderer>().material.name[0];
                    } else if (face.position.z > 0.75) {
                        // back
                        theArray[20] = face.GetComponent<Renderer>().material.name[0];
                    } else {
                        //mid
                        theArray[19] = face.GetComponent<Renderer>().material.name[0];
                    }
                } else if (face.position.x < -0.75) {
                    // left
                    if (face.position.z < -0.75) {
                        // front
                        theArray[24] = face.GetComponent<Renderer>().material.name[0];
                    } else if (face.position.z > 0.75) {
                        // back
                        theArray[26] = face.GetComponent<Renderer>().material.name[0];
                    } else {
                        //mid
                        theArray[25] = face.GetComponent<Renderer>().material.name[0];
                    }
                } else {
                    // mid
                    if (face.position.z < -0.75) {
                        // front
                        theArray[21] = face.GetComponent<Renderer>().material.name[0];
                    } else if (face.position.z > 0.75) {
                        // back
                        theArray[23] = face.GetComponent<Renderer>().material.name[0];
                    } else {
                        //mid
                        theArray[22] = face.GetComponent<Renderer>().material.name[0];
                    }
                }
            } else if (face.position.y < -1.35) {
                // down
                if (face.position.x > 0.75) {
                    // right
                    if (face.position.z < -0.75) {
                        // front
                        theArray[27] = face.GetComponent<Renderer>().material.name[0];
                    } else if (face.position.z > 0.75) {
                        // back
                        theArray[29] = face.GetComponent<Renderer>().material.name[0];
                    } else {
                        //mid
                        theArray[28] = face.GetComponent<Renderer>().material.name[0];
                    }
                } else if (face.position.x < -0.75) {
                    // left
                    if (face.position.z < -0.75) {
                        // front
                        theArray[33] = face.GetComponent<Renderer>().material.name[0];
                    } else if (face.position.z > 0.75) {
                        // back
                        theArray[35] = face.GetComponent<Renderer>().material.name[0];
                    } else {
                        //mid
                        theArray[34] = face.GetComponent<Renderer>().material.name[0];
                    }
                } else {
                    // mid
                    if (face.position.z < -0.75) {
                        // front
                        theArray[30] = face.GetComponent<Renderer>().material.name[0];
                    } else if (face.position.z > 0.75) {
                        // back
                        theArray[32] = face.GetComponent<Renderer>().material.name[0];
                    } else {
                        //mid
                        theArray[31] = face.GetComponent<Renderer>().material.name[0];
                    }
                }
            } else if (face.position.z < -1.35) {
                // front
                if (face.position.x > 0.75) {
                    // right
                    if (face.position.y > 0.75) {
                        // up
                        theArray[36] = face.GetComponent<Renderer>().material.name[0];
                    } else if (face.position.y < -0.75) {
                        // down
                        theArray[38] = face.GetComponent<Renderer>().material.name[0];
                    } else {
                        //mid
                        theArray[37] = face.GetComponent<Renderer>().material.name[0];
                    }
                } else if (face.position.x < -0.75) {
                    // left
                    if (face.position.y > 0.75) {
                        // up
                        theArray[42] = face.GetComponent<Renderer>().material.name[0];
                    } else if (face.position.y < -0.75) {
                        // down
                        theArray[44] = face.GetComponent<Renderer>().material.name[0];
                    } else {
                        //mid
                        theArray[43] = face.GetComponent<Renderer>().material.name[0];
                    }
                } else {
                    // mid
                    if (face.position.y > 0.75) {
                        // up
                        theArray[39] = face.GetComponent<Renderer>().material.name[0];
                    } else if (face.position.y < -0.75) {
                        // down
                        theArray[41] = face.GetComponent<Renderer>().material.name[0];
                    } else {
                        //mid
                        theArray[40] = face.GetComponent<Renderer>().material.name[0];
                    }
                }
            } else if (face.position.z > 1.35) {
                // back
                if (face.position.x > 0.75) {
                    // right
                    if (face.position.y > 0.75) {
                        // up
                        theArray[45] = face.GetComponent<Renderer>().material.name[0];
                    } else if (face.position.y < -0.75) {
                        // down
                        theArray[47] = face.GetComponent<Renderer>().material.name[0];
                    } else {
                        //mid
                        theArray[46] = face.GetComponent<Renderer>().material.name[0];
                    }
                } else if (face.position.x < -0.75) {
                    // left
                    if (face.position.y > 0.75) {
                        // up
                        theArray[51] = face.GetComponent<Renderer>().material.name[0];
                    } else if (face.position.y < -0.75) {
                        // down
                        theArray[53] = face.GetComponent<Renderer>().material.name[0];
                    } else {
                        //mid
                        theArray[52] = face.GetComponent<Renderer>().material.name[0];
                    }
                } else {
                    // mid
                    if (face.position.y > 0.75) {
                        // up
                        theArray[48] = face.GetComponent<Renderer>().material.name[0];
                    } else if (face.position.y < -0.75) {
                        // down
                        theArray[50] = face.GetComponent<Renderer>().material.name[0];
                    } else {
                        //mid
                        theArray[49] = face.GetComponent<Renderer>().material.name[0];
                    }
                }
            }
        }

        // return string.Join("", theArray);
        return new string(theArray);
    }

    public bool isFinished(string status) {
        for (int i = 0; i<6; i++) {
            char c0 = status[i * 9];
            for (int j = 0; j<9; j++) {
                if (status[i*9+j]!=c0) {
                    return false;
                }
            }
        }
        return true;
    }
}
