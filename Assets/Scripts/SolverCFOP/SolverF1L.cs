using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolverF1L
{
    List<string> formula_1_L;
    List<string> formula_1_R;
    List<string> formula_1_top;
    List<string> formula_1_FL;
    List<string> formula_1_FR;
    List<string> formula_1_BL;
    List<string> formula_1_BR;

    public SolverF1L() {
        formula_1_L = new List<string>() { "R_B", "U_R", "R_F" };
        formula_1_R = new List<string>() { "F_L", "U_L", "F_R" };
        formula_1_top = new List<string>() { "R_B", "U_L", "R_F" };
        formula_1_FL = new List<string>() { "L_B", "U_L", "L_F" };
        formula_1_FR = new List<string>() { "R_B", "U_L", "R_F" };
        formula_1_BL = new List<string>() { "L_F", "U_L", "L_B" };
        formula_1_BR = new List<string>() { "R_F", "U_R", "R_B" };
    }

    public List<string> Solve(string status) {
        List<string> result = new List<string>();
        if (isCorrect(status)) {
            result = new List<string>() { "A_UL" };
        } else if (is_formula_1_L(status)) {
            result = formula_1_L;
        } else if (is_formula_1_R(status)) {
            result = formula_1_R;
        } else if (is_formula_1_top(status)) {
            result = formula_1_top;
        } else if (is_formula_1_FL(status)) {
            result = formula_1_FL;
        } else if (is_formula_1_FR(status)) {
            result = formula_1_FR;
        } else if (is_formula_1_BL(status)) {
            result = formula_1_BL;
        } else if (is_formula_1_BR(status)) {
            result = formula_1_BR;
        } else {
            result = new List<string>() { "U_L" };
        }
        return result;
    }

    bool isCorrect(string status) {
        if (status[FKey.F5] == status[FKey.F9] &&
            status[FKey.R5] == status[FKey.R7] &&
            status[FKey.D5] == status[FKey.D3]) {
            return true;
        }
        return false;
    }

    bool is_formula_1_L(string status) {
        if (status[FKey.F5] == status[FKey.U7] &&
            status[FKey.R5] == status[FKey.F1] &&
            status[FKey.D5] == status[FKey.L3]) {
            return true;
        }
        return false;
    }

    bool is_formula_1_R(string status) {
        if (status[FKey.F5] == status[FKey.R3] &&
            status[FKey.R5] == status[FKey.U3] &&
            status[FKey.D5] == status[FKey.B1]) {
            return true;
        }
        return false;
    }

    bool is_formula_1_top(string status) {
        if (status[FKey.F5] == status[FKey.L1] &&
            status[FKey.R5] == status[FKey.B3] &&
            status[FKey.D5] == status[FKey.U1]) {
            return true;
        }
        return false;
    }

    bool is_formula_1_FL(string status) {
        HashSet<string> centers = new HashSet<string> {
            status[FKey.F5].ToString(), status[FKey.R5].ToString(), status[FKey.D5].ToString()
        };
        if (centers.Contains(status[FKey.F7].ToString()) &&
            centers.Contains(status[FKey.L9].ToString()) &&
            centers.Contains(status[FKey.D1].ToString())) {
            return true;
        }
        return false;
    }

    bool is_formula_1_FR(string status) {
        HashSet<string> centers = new HashSet<string> {
            status[FKey.F5].ToString(), status[FKey.R5].ToString(), status[FKey.D5].ToString()
        };
        if (centers.Contains(status[FKey.F9].ToString()) &&
            centers.Contains(status[FKey.R7].ToString()) &&
            centers.Contains(status[FKey.D3].ToString())) {
            return true;
        }
        return false;
    }

    bool is_formula_1_BL(string status) {
        HashSet<string> centers = new HashSet<string> {
            status[FKey.F5].ToString(), status[FKey.R5].ToString(), status[FKey.D5].ToString()
        };
        if (centers.Contains(status[FKey.B9].ToString()) &&
            centers.Contains(status[FKey.L7].ToString()) &&
            centers.Contains(status[FKey.D7].ToString())) {
            return true;
        }
        return false;
    }

    bool is_formula_1_BR(string status) {
        HashSet<string> centers = new HashSet<string> {
            status[FKey.F5].ToString(), status[FKey.R5].ToString(), status[FKey.D5].ToString()
        };
        if (centers.Contains(status[FKey.D9].ToString()) &&
            centers.Contains(status[FKey.B7].ToString()) &&
            centers.Contains(status[FKey.R9].ToString())) {
            return true;
        }
        return false;
    }
}
