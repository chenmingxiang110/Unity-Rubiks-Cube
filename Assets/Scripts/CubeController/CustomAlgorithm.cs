using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomAlgorithm : MonoBehaviour
{
    public int stepsLeft;
    public CubeMover cubemover;
    public InputField inputField;
    public ControlBadAlgoTip controlBadAlgoTip;

    string[] current_formula;
    HashSet<string> validMoves;

    // Start is called before the first frame update
    void Start()
    {
        validMoves = new HashSet<string> {
            "x", "x_", "x2", "y", "y_", "y2", "z", "z_", "z2",
            "U", "U_", "U2", "R", "R_", "R2", "F", "F_", "F2",
            "D", "D_", "D2", "L", "L_", "L2", "B", "B_", "B2",
            "E", "E_", "E2", "M", "M_", "M2", "S", "S_", "S2",
            "u", "u_", "u2", "r", "r_", "r2", "f", "f_", "f2",
            "d", "d_", "d2", "l", "l_", "l2", "b", "b_", "b2",
        };
    }

    // Update is called once per frame
    void Update()
    {
        if (stepsLeft > 0) {
            if (cubemover.isAvailable()) {
                string code = current_formula[current_formula.Length - stepsLeft];
                stepsLeft -= 1;
                cubemover.move(code);
                if (stepsLeft <= 0) {
                    cubemover.isLocked = false;
                    current_formula = null;
                }
            }
        }
    }

    public void clearInput() {
        inputField.text = "";
    }

    public void revInput() {
        string[] moves = inputField.text.Trim().Split(' ');
        string[] moves_ = new string[moves.Length];
        for (int i = 0; i<moves.Length; i++) {
            string m = moves[moves.Length - 1 - i];
            if (m[m.Length - 1] == '_' || m[m.Length - 1] == '\'') {
                moves_[i] = m.Substring(0, m.Length - 1);
            } else if (m[m.Length - 1] == '2') {
                moves_[i] = m;
            } else {
                moves_[i] = m+"\'";
            }
        }
        inputField.text = string.Join(" ", moves_);
        return;
    }

    public void runInput() {
        string[] moves = inputField.text.Replace("'", "_").Split(' ');
        List<string> moveList = new List<string>();
        foreach (string m in moves) {
            if (m.Length == 0) continue;
            if (!validMoves.Contains(m)) {
                controlBadAlgoTip.setTimer(3);
                return;
            } else {
                moveList.Add(m);
            }
        }
        moveList = Translator.translate(moveList);
        moves = moveList.ToArray();
        if (!cubemover.isLocked && moves.Length > 0) {
            cubemover.isLocked = true;
            current_formula = moves;
            stepsLeft = moves.Length;
            // clearInput();
        }
        return;
    }
}
