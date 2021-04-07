using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translator
{
    public static List<string> translate(string std_moves) {
        return translate(std_moves.Split(' '));
    }

    public static List<string> translate(string[] std_moves) {
        return translate(new List<string>(std_moves));
    }

    public static List<string> translate(List<string> std_moves) {
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
