using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SolverF2L
{
    List<string> formula_2_L;
    List<string> formula_2_R;

    public SolverF2L() {
        formula_2_L = new List<string>() { "U_L", "R_B", "U_R", "R_F", "U_R", "F_L", "U_L", "F_R" };
        formula_2_R = new List<string>() { "U_R", "F_L", "U_L", "F_R", "U_L", "R_B", "U_R", "R_F" };
    }

    public List<string> Solve(string status) {
        List<string> result = new List<string>();
        if (isCorrect(status)) {
            result = new List<string>() { "A_UL" };
        } else if (isCorrectInverse(status)) {
            result = formula_2_L;
        } else if (isFormula2L(status)) {
            result = formula_2_L;
        } else if (isFormula2R(status)) {
            result = formula_2_R;
        } else if (isRB(status)) {
            result = new List<string>() { "A_UL" };
            result = result.Concat(formula_2_L).ToList();
        } else if (isBL(status)) {
            result = new List<string>() { "A_UL", "A_UL" };
            result = result.Concat(formula_2_L).ToList();
        } else if (isLF(status)) {
            result = new List<string>() { "A_UR" };
            result = result.Concat(formula_2_L).ToList();
        } else {
            result = new List<string>() { "U_L" };
        }
        return result;
    }

    bool isCorrect(string status) {
        if (status[FKey.F5] == status[FKey.F6] && status[FKey.R5] == status[FKey.R4]) {
            return true;
        }
        return false;
    }

    bool isCorrectInverse(string status) {
        if (status[FKey.F5] == status[FKey.R4] && status[FKey.R5] == status[FKey.F6]) {
            return true;
        }
        return false;
    }

    bool isFormula2L(string status) {
        if (status[FKey.F5] == status[FKey.F2] && status[FKey.R5] == status[FKey.U8]) {
            return true;
        }
        return false;
    }

    bool isFormula2R(string status) {
        if (status[FKey.F5] == status[FKey.U6] && status[FKey.R5] == status[FKey.R2]) {
            return true;
        }
        return false;
    }

    bool isRB(string status) {
        if ((status[FKey.F5] == status[FKey.R6] && status[FKey.R5] == status[FKey.B4]) ||
            (status[FKey.F5] == status[FKey.B4] && status[FKey.R5] == status[FKey.R6])) {
            return true;
        }
        return false;
    }

    bool isBL(string status) {
        if ((status[FKey.F5] == status[FKey.B6] && status[FKey.R5] == status[FKey.L4]) ||
            (status[FKey.F5] == status[FKey.L4] && status[FKey.R5] == status[FKey.B6])) {
            return true;
        }
        return false;
    }

    bool isLF(string status) {
        if ((status[FKey.F5] == status[FKey.L6] && status[FKey.R5] == status[FKey.F4]) ||
            (status[FKey.F5] == status[FKey.F4] && status[FKey.R5] == status[FKey.L6])) {
            return true;
        }
        return false;
    }
}
