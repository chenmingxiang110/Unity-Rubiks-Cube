using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolverCross
{
    public SolverCross() {
        return;
    }

    public List<string> Solve(string status) {
        List<string> result = new List<string>();
        if (isCorrect(status)) {
            result = new List<string>() { "A_UL" };
        } else if (isMLF(status)) {
            result = new List<string>() { "F_L" };
        } else if (isMRF(status)) {
            result = new List<string>() { "F_R" };
        } else if (isMLL(status)) {
            result = new List<string>() { "F_R" };
        } else if (isMRR(status)) {
            result = new List<string>() { "F_L" };
        } else if (isMLB(status)) {
            result = new List<string>() { "Um_R", "F_R", "Um_L" };
        } else if (isMRB(status)) {
            result = new List<string>() { "Um_L", "F_L", "Um_R" };
        } else if (isTF(status)) {
            result = new List<string>() { "F_L", "F_L" };
        } else if (isTT(status)) {
            result = new List<string>() { "U_L", "Rm_B", "U_R", "Rm_F" };
        } else if (isF(status)) {
            result = new List<string>() { "F_L", "F_L" };
        } else if (isR(status)) {
            result = new List<string>() { "R_B", "R_B" };
        } else if (isB(status)) {
            result = new List<string>() { "B_R", "B_R" };
        } else if (isL(status)) {
            result = new List<string>() { "L_F", "L_F" };
        } else {
            result = new List<string>() { "U_L" };
        }
        return result;
    }

    bool isCorrect(string status) {
        if (status[FKey.F5] == status[FKey.F8] &&
            status[FKey.D5] == status[FKey.D2]) {
            return true;
        }
        return false;
    }

    bool isMLF(string status) {
        if (status[FKey.F5] == status[FKey.F4] &&
            status[FKey.D5] == status[FKey.L6]) {
            return true;
        }
        return false;
    }

    bool isMRF(string status) {
        if (status[FKey.F5] == status[FKey.F6] &&
            status[FKey.D5] == status[FKey.R4]) {
            return true;
        }
        return false;
    }

    bool isMLL(string status) {
        if (status[FKey.F5] == status[FKey.L6] &&
            status[FKey.D5] == status[FKey.F4]) {
            return true;
        }
        return false;
    }

    bool isMRR(string status) {
        if (status[FKey.F5] == status[FKey.R4] &&
            status[FKey.D5] == status[FKey.F6]) {
            return true;
        }
        return false;
    }

    bool isMLB(string status) {
        char c0 = status[FKey.L4];
        char c1 = status[FKey.B6];
        if ((status[FKey.F5] == c0 && status[FKey.D5] == c1) ||
            (status[FKey.F5] == c1 && status[FKey.D5] == c0)) {
            return true;
        }
        return false;
    }

    bool isMRB(string status) {
        char c0 = status[FKey.R6];
        char c1 = status[FKey.B4];
        if ((status[FKey.F5] == c0 && status[FKey.D5] == c1) ||
            (status[FKey.F5] == c1 && status[FKey.D5] == c0)) {
            return true;
        }
        return false;
    }

    bool isTF(string status) {
        if (status[FKey.F5] == status[FKey.F2] &&
            status[FKey.D5] == status[FKey.U8]) {
            return true;
        }
        return false;
    }

    bool isTT(string status) {
        if (status[FKey.F5] == status[FKey.U8] &&
            status[FKey.D5] == status[FKey.F2]) {
            return true;
        }
        return false;
    }

    bool isF(string status) {
        if (status[FKey.F5] == status[FKey.D2] &&
            status[FKey.D5] == status[FKey.F8]) {
            return true;
        }
        return false;
    }

    bool isR(string status) {
        char c0 = status[FKey.R8];
        char c1 = status[FKey.D6];
        if ((status[FKey.F5] == c0 && status[FKey.D5] == c1) ||
            (status[FKey.F5] == c1 && status[FKey.D5] == c0)) {
            return true;
        }
        return false;
    }

    bool isB(string status) {
        char c0 = status[FKey.B8];
        char c1 = status[FKey.D8];
        if ((status[FKey.F5] == c0 && status[FKey.D5] == c1) ||
            (status[FKey.F5] == c1 && status[FKey.D5] == c0)) {
            return true;
        }
        return false;
    }

    bool isL(string status) {
        char c0 = status[FKey.L8];
        char c1 = status[FKey.D4];
        if ((status[FKey.F5] == c0 && status[FKey.D5] == c1) ||
            (status[FKey.F5] == c1 && status[FKey.D5] == c0)) {
            return true;
        }
        return false;
    }
}
