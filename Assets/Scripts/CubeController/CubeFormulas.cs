using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFormulas : MonoBehaviour
{
    public int stepsLeft;
    public CubeMover cubemover;

    string[] formula_2_L;
    string[] formula_2_R;
    string[] formula_3_cross_L;
    string[] formula_3_fish_L;
    string[] formula_3_fish_R;
    string[] formula_3_corner;
    string[] formula_3_triple_L;
    string[] formula_3_triple_R;
    string[] formula_3_quadruple;

    string[] current_formula;
    // Start is called before the first frame update
    void Start()
    {
        formula_2_L = new string[] { "U_L", "R_B", "U_R", "R_F", "U_R", "F_L", "U_L", "F_R" };
        formula_2_R = new string[] { "U_R", "F_L", "U_L", "F_R", "U_L", "R_B", "U_R", "R_F" };
        formula_3_cross_L = new string[] { "F_R", "U_L", "R_B", "U_R", "R_F", "F_L" };
        formula_3_fish_L = new string[] { "F_R", "U_L", "F_L", "U_L", "F_R", "U_L", "U_L", "F_L" };
        formula_3_fish_R = new string[] { "R_F", "U_R", "R_B", "U_R", "R_F", "U_R", "U_R", "R_B" };
        formula_3_corner = new string[] {
            "A_UR", "A_FL", "U_L", "U_L", "R_B", "U_R", "U_R", "R_F", "F_R",
            "F_R", "U_L", "U_L", "L_B", "U_L", "U_L", "L_F", "F_L", "F_L", "A_FR",
        };
        formula_3_triple_L = new string[] {
            "A_UL", "A_UL", "R_F", "U_R", "R_B", "U_R", "R_F", "U_R", "U_R", "R_B",
            "A_UL", "A_UL", "F_R", "U_L", "F_L", "U_L", "F_R", "U_L", "U_L", "F_L",
        };
        formula_3_triple_R = new string[] {
            "A_UL", "F_R", "U_L", "F_L", "U_L", "F_R", "U_L", "U_L", "F_L", "A_UR",
            "A_UR", "R_F", "U_R", "R_B", "U_R", "R_F", "U_R", "U_R", "R_B", "A_UL",
        };
        formula_3_quadruple = new string[] {
            "Rm_F", "Rm_F", "U_R", "Rm_F", "Rm_F", "U_R",
            "U_R", "Rm_F", "Rm_F", "U_R", "Rm_F", "Rm_F" 
        };
        current_formula = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (stepsLeft > 0) {
            if (cubemover.isAvailable()) {
                string code = current_formula[current_formula.Length-stepsLeft];
                stepsLeft -= 1;
                if (stepsLeft == 0) current_formula = null;
                cubemover.move(code);
            }
        }
    }

    public void runFormula_2_L() {
        if (stepsLeft<=0) {
            current_formula = formula_2_L;
            stepsLeft = current_formula.Length;
        }
    }

    public void runFormula_2_R() {
        if (stepsLeft <= 0) {
            current_formula = formula_2_R;
            stepsLeft = current_formula.Length;
        }
    }

    public void runFormula_3_cross_L() {
        if (stepsLeft <= 0) {
            current_formula = formula_3_cross_L;
            stepsLeft = current_formula.Length;
        }
    }

    public void runFormula_3_fish_L() {
        if (stepsLeft <= 0) {
            current_formula = formula_3_fish_L;
            stepsLeft = current_formula.Length;
        }
    }

    public void runFormula_3_fish_R() {
        if (stepsLeft <= 0) {
            current_formula = formula_3_fish_R;
            stepsLeft = current_formula.Length;
        }
    }

    public void runFormula_3_corner() {
        if (stepsLeft <= 0) {
            current_formula = formula_3_corner;
            stepsLeft = current_formula.Length;
        }
    }

    public void runFormula_3_triple_L() {
        if (stepsLeft <= 0) {
            current_formula = formula_3_triple_L;
            stepsLeft = current_formula.Length;
        }
    }

    public void runFormula_3_triple_R() {
        if (stepsLeft <= 0) {
            current_formula = formula_3_triple_R;
            stepsLeft = current_formula.Length;
        }
    }

    public void runFormula_3_quadruple() {
        if (stepsLeft <= 0) {
            current_formula = formula_3_quadruple;
            stepsLeft = current_formula.Length;
        }
    }
}
