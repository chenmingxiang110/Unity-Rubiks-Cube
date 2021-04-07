using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CFOPmain : MonoBehaviour
{
    public CubeStatus cubeStatus;
    public bool isAuto;
    public CubeMover cubemover;

    List<string> current_moves;
    int stepsLeft;

    SolverPLL solverPLL;
    SolverOLL solverOLL;
    SolverF2L solverF2L;
    SolverF1L solverF1L;
    SolverCross solverCross;

    // Start is called before the first frame update
    void Start()
    {
        isAuto = false;
        current_moves = new List<string>();
        stepsLeft = 0;

        solverPLL = new SolverPLL();
        solverOLL = new SolverOLL();
        solverF2L = new SolverF2L();
        solverF1L = new SolverF1L();
        solverCross = new SolverCross();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAuto) {
            if (stepsLeft > 0) {
                string code = current_moves[current_moves.Count - stepsLeft];
                if (cubemover.isAvailable()) {
                    stepsLeft -= 1;
                    cubemover.move(code);
                }
            } else {
                Solve();
            }
        }
    }

    public void Solve() {
        if (cubemover.isAvailable()) {
            string status = cubeStatus.GetStatus();
            // Lock the mover, and unlock when finished
            string stage = findCurrentStage(status);
            //print(stage);
            switch (stage) {
                case "Cross":
                    current_moves = solverCross.Solve(status);
                    stepsLeft = current_moves.Count;
                    break;
                case "F1L":
                    current_moves = solverF1L.Solve(status);
                    stepsLeft = current_moves.Count;
                    break;
                case "F2L":
                    current_moves = solverF2L.Solve(status);
                    stepsLeft = current_moves.Count;
                    break;
                case "OLL":
                    current_moves = solverOLL.Solve(status);
                    stepsLeft = current_moves.Count;
                    break;
                case "PLL":
                    current_moves = solverPLL.Solve(status);
                    stepsLeft = current_moves.Count;
                    break;
                case "Finished":
                    toggleAuto();
                    break;
            }
        }
    }

    public void toggleAuto() {
        if (isAuto) {
            isAuto = !isAuto;
            cubemover.isLocked = false;
            current_moves = new List<string>();
            stepsLeft = 0;
        } else {
            if (!cubemover.isLocked) {
                isAuto = !isAuto;
                cubemover.isLocked = true;
            }
        }
    }

    bool hasCross(string status) {
        if (status[28] == status[31] && status[30] == status[31] &&
            status[32] == status[31] && status[34] == status[31] &&
            status[13] == status[16] && status[22] == status[25] &&
            status[40] == status[43] && status[49] == status[52]) {
            return true;
        }
        return false;
    }

    bool hasF1L(string status) {
        for (int i = 28; i < 36; i++) {
            if (status[i] != status[27]) {
                return false;
            }
        }
        if (status[13] != status[16]) {
            return false;
        }
        if (status[22] != status[25]) {
            return false;
        }
        if (status[40] != status[43]) {
            return false;
        }
        if (status[49] != status[52]) {
            return false;
        }
        return true;
    }

    bool hasF2L(string status) {
        for (int i = 13; i < 18; i++) {
            if (status[i] != status[12]) {
                return false;
            }
        }
        for (int i = 22; i < 27; i++) {
            if (status[i] != status[21]) {
                return false;
            }
        }
        for (int i = 40; i < 45; i++) {
            if (status[i] != status[39]) {
                return false;
            }
        }
        for (int i = 49; i < 54; i++) {
            if (status[i] != status[48]) {
                return false;
            }
        }
        return true;
    }

    bool hasTop(string status) {
        for (int i = 1; i < 9; i++) {
            if (status[i] != status[0]) {
                return false;
            }
        }
        return true;
    }

    public string findCurrentStage(string status) {
        if (cubeStatus.isFinished(status)) {
            return "Finished";
        } else {
            if (hasCross(status)) {
                if (hasF1L(status)) {
                    if (hasF2L(status)) {
                        if (hasTop(status)) {
                            return "PLL";
                        }
                        return "OLL";
                    }
                    return "F2L";
                }
                return "F1L";
            }
            return "Cross";
        }
    }
}
