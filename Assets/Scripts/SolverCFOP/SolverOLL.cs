using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolverOLL
{
    List<string> formula1;
    List<string> formula2;
    List<string> formula3;
    List<string> formula4;
    List<string> formula5;
    List<string> formula6;
    List<string> formula7;
    List<string> formula8;
    List<string> formula9;
    List<string> formula10;
    List<string> formula11;
    List<string> formula12;
    List<string> formula13;
    List<string> formula14;
    List<string> formula15;
    List<string> formula16;
    List<string> formula17;
    List<string> formula18;
    List<string> formula19;
    List<string> formula20;
    List<string> formula21;
    List<string> formula22;
    List<string> formula23;
    List<string> formula24;
    List<string> formula25;
    List<string> formula26;
    List<string> formula27;
    List<string> formula28;
    List<string> formula29;
    List<string> formula30;
    List<string> formula31;
    List<string> formula32;
    List<string> formula33;
    List<string> formula34;
    List<string> formula35;
    List<string> formula36;
    List<string> formula37;
    List<string> formula38;
    List<string> formula39;
    List<string> formula40;
    List<string> formula41;
    List<string> formula42;
    List<string> formula43;
    List<string> formula44;
    List<string> formula45;
    List<string> formula46;
    List<string> formula47;
    List<string> formula48;
    List<string> formula49;
    List<string> formula50;
    List<string> formula51;
    List<string> formula52;
    List<string> formula53;
    List<string> formula54;
    List<string> formula55;
    List<string> formula56;
    List<string> formula57;

    int[] f1;
    int[] f2;
    int[] f3;
    int[] f4;
    int[] f5;
    int[] f6;
    int[] f7;
    int[] f8;
    int[] f9;
    int[] f10;
    int[] f11;
    int[] f12;
    int[] f13;
    int[] f14;
    int[] f15;
    int[] f16;
    int[] f17;
    int[] f18;
    int[] f19;
    int[] f20;
    int[] f21;
    int[] f22;
    int[] f23;
    int[] f24;
    int[] f25;
    int[] f26;
    int[] f27;
    int[] f28;
    int[] f29;
    int[] f30;
    int[] f31;
    int[] f32;
    int[] f33;
    int[] f34;
    int[] f35;
    int[] f36;
    int[] f37;
    int[] f38;
    int[] f39;
    int[] f40;
    int[] f41;
    int[] f42;
    int[] f43;
    int[] f44;
    int[] f45;
    int[] f46;
    int[] f47;
    int[] f48;
    int[] f49;
    int[] f50;
    int[] f51;
    int[] f52;
    int[] f53;
    int[] f54;
    int[] f55;
    int[] f56;
    int[] f57;

    public SolverOLL() {
        formula1 = Translator.translate("R U2 R2 F R F_ U2 R_ F R F_");
        formula2 = Translator.translate("r U r_ U2 r U2 R_ U2 R U_ r_");
        formula3 = Translator.translate("r_ R2 U R_ U r U2 r_ U M_");
        formula4 = Translator.translate("M U_ r U2 r_ U_ R U_ R_ M_");
        formula5 = Translator.translate("l_ U2 L U L_ U l");
        formula6 = Translator.translate("r U2 R_ U_ R U_ r_");
        formula7 = Translator.translate("r U R_ U R U2 r_");
        formula8 = Translator.translate("l_ U_ L U_ L_ U2 l");
        formula9 = Translator.translate("R U R_ U_ R_ F R2 U R_ U_ F_");
        formula10 = Translator.translate("R U R_ U R_ F R F_ R U2 R_");
        formula11 = Translator.translate("r U R_ U R_ F R F_ R U2 r_");
        formula12 = Translator.translate("M_ R_ U_ R U_ R_ U2 R U_ R r_");
        formula13 = Translator.translate("F U R U_ R2 F_ R U R U_ R_");
        formula14 = Translator.translate("R_ F R U R_ F_ R F U_ F_");
        formula15 = Translator.translate("l_ U_ l L_ U_ L U l_ U l");
        formula16 = Translator.translate("r U r_ R U R_ U_ r U_ r_");
        formula17 = Translator.translate("F R_ F_ R2 r_ U R U_ R_ U_ M_");
        formula18 = Translator.translate("r U R_ U R U2 r2 U_ R U_ R_ U2 r");
        formula19 = Translator.translate("r_ R U R U R_ U_ M_ R_ F R F_");
        formula20 = Translator.translate("r U R_ U_ M2 U R U_ R_ U_ M_");
        formula21 = Translator.translate("R U2 R_ U_ R U R_ U_ R U_ R_");
        formula22 = Translator.translate("R U2 R2 U_ R2 U_ R2 U2 R");
        formula23 = Translator.translate("R2 D_ R U2 R_ D R U2 R");
        formula24 = Translator.translate("r U R_ U_ r_ F R F_");
        formula25 = Translator.translate("F_ r U R_ U_ r_ F R");
        formula26 = Translator.translate("R U2 R_ U_ R U_ R_");
        formula27 = Translator.translate("R U R_ U R U2 R_");
        formula28 = Translator.translate("r U R_ U_ r_ R U R U_ R_");
        formula29 = Translator.translate("R U R_ U_ R U_ R_ F_ U_ F R U R_");
        formula30 = Translator.translate("F R_ F R2 U_ R_ U_ R U R_ F2");
        formula31 = Translator.translate("R_ U_ F U R U_ R_ F_ R");
        formula32 = Translator.translate("L U F_ U_ L_ U L F L_");
        formula33 = Translator.translate("R U R_ U_ R_ F R F_");
        formula34 = Translator.translate("R U R2 U_ R_ F R U R U_ F_");
        formula35 = Translator.translate("R U2 R2 F R F_ R U2 R_");
        formula36 = Translator.translate("L_ U_ L U_ L_ U L U L F_ L_ F");
        formula37 = Translator.translate("F R_ F_ R U R U_ R_");
        formula38 = Translator.translate("R U R_ U R U_ R_ U_ R_ F R F_");
        formula39 = Translator.translate("L F_ L_ U_ L U F U_ L_");
        formula40 = Translator.translate("R_ F R U R_ U_ F_ U R");
        formula41 = Translator.translate("R U R_ U R U2 R_ F R U R_ U_ F_");
        formula42 = Translator.translate("R_ U_ R U_ R_ U2 R F R U R_ U_ F_");
        formula43 = Translator.translate("F_ U_ L_ U L F");
        formula44 = Translator.translate("F U R U_ R_ F_");
        formula45 = Translator.translate("F R U R_ U_ F_");
        formula46 = Translator.translate("R_ U_ R_ F R F_ U R");
        formula47 = Translator.translate("R_ U_ R_ F R F_ R_ F R F_ U R");
        formula48 = Translator.translate("F R U R_ U_ R U R_ U_ F_");
        formula49 = Translator.translate("r U_ r2 U r2 U r2 U_ r");
        formula50 = Translator.translate("r_ U r2 U_ r2 U_ r2 U r_");
        formula51 = Translator.translate("F U R U_ R_ U R U_ R_ F_");
        formula52 = Translator.translate("R U R_ U R U_ B U_ B_ R_");
        formula53 = Translator.translate("l_ U2 L U L_ U_ L U L_ U l");
        formula54 = Translator.translate("r U2 R_ U_ R U R_ U_ R U_ r_");
        formula55 = Translator.translate("R_ F R U R U_ R2 F_ R2 U_ R_ U R U R_");
        formula56 = Translator.translate("r_ U_ r U_ R_ U R U_ R_ U R r_ U r");
        formula57 = Translator.translate("R U R_ U_ M_ U R U_ r_");

        f1 = new int[] { FKey.L1, FKey.L2, FKey.L3, FKey.R1, FKey.R2, FKey.R3, FKey.F2, FKey.B2 };
        f2 = new int[] { FKey.B1, FKey.L2, FKey.L3, FKey.R1, FKey.R2, FKey.B3, FKey.F2, FKey.B2 };
        f3 = new int[] { FKey.U7, FKey.L2, FKey.F2, FKey.F3, FKey.R2, FKey.R3, FKey.B2, FKey.B3 };
        f4 = new int[] { FKey.U9, FKey.L2, FKey.L1, FKey.F1, FKey.F2, FKey.R2, FKey.B1, FKey.B2 };
        f5 = new int[] { FKey.U1, FKey.U2, FKey.U4, FKey.L3, FKey.R2, FKey.R3, FKey.F2, FKey.F3 };
        f6 = new int[] { FKey.U2, FKey.U3, FKey.U6, FKey.L1, FKey.L2, FKey.F1, FKey.F2, FKey.R1 };
        f7 = new int[] { FKey.U2, FKey.U4, FKey.U7, FKey.F2, FKey.R2, FKey.R3, FKey.F3, FKey.B3 };
        f8 = new int[] { FKey.U2, FKey.U6, FKey.U9, FKey.L1, FKey.L2, FKey.F1, FKey.F2, FKey.B1 };
        f9 = new int[] { FKey.U2, FKey.U4, FKey.U9, FKey.L1, FKey.F1, FKey.F2, FKey.R2, FKey.B1 };
        f10 = new int[] { FKey.U3, FKey.U4, FKey.U8, FKey.L3, FKey.F3, FKey.R2, FKey.B2, FKey.B3 };
        f11 = new int[] { FKey.U2, FKey.U3, FKey.U4, FKey.L3, FKey.F2, FKey.F3, FKey.R2, FKey.B3 };
        f12 = new int[] { FKey.U1, FKey.U2, FKey.U5, FKey.L2, FKey.F1, FKey.F2, FKey.R1, FKey.B1 };
        f13 = new int[] { FKey.U6, FKey.U4, FKey.U7, FKey.F2, FKey.F3, FKey.R3, FKey.B2, FKey.B3 };
        f14 = new int[] { FKey.U6, FKey.U4, FKey.U9, FKey.L1, FKey.F1, FKey.F2, FKey.B1, FKey.B2 };
        f15 = new int[] { FKey.U6, FKey.U4, FKey.U1, FKey.L3, FKey.F2, FKey.F3, FKey.R3, FKey.B2 };
        f16 = new int[] { FKey.U6, FKey.U4, FKey.U3, FKey.L1, FKey.F1, FKey.F2, FKey.R1, FKey.B2 };
        f17 = new int[] { FKey.U1, FKey.U9, FKey.L2, FKey.F1, FKey.F2, FKey.R2, FKey.R3, FKey.B2 };
        f18 = new int[] { FKey.U1, FKey.U3, FKey.L2, FKey.F1, FKey.F2, FKey.F3, FKey.R2, FKey.B2 };
        f19 = new int[] { FKey.U1, FKey.U3, FKey.L2, FKey.L3, FKey.F2, FKey.R1, FKey.R2, FKey.B2 };
        f20 = new int[] { FKey.U1, FKey.U3, FKey.U7, FKey.U9, FKey.L2, FKey.F2, FKey.R2, FKey.B2 };
        f21 = new int[] { FKey.U2, FKey.U4, FKey.U6, FKey.U8, FKey.F1, FKey.F3, FKey.B1, FKey.B3 };
        f22 = new int[] { FKey.U2, FKey.U4, FKey.U6, FKey.U8, FKey.L1, FKey.L3, FKey.F3, FKey.B1 };
        f23 = new int[] { FKey.U2, FKey.U4, FKey.U6, FKey.U8, FKey.U7, FKey.U9, FKey.B1, FKey.B3 };
        f24 = new int[] { FKey.U2, FKey.U4, FKey.U6, FKey.U8, FKey.F1, FKey.U9, FKey.U3, FKey.B3 };
        f25 = new int[] { FKey.U2, FKey.U4, FKey.U6, FKey.U8, FKey.U3, FKey.U7, FKey.L1, FKey.F3 };
        f26 = new int[] { FKey.U2, FKey.U4, FKey.U6, FKey.U8, FKey.U3, FKey.L1, FKey.F1, FKey.R1 };
        f27 = new int[] { FKey.U2, FKey.U4, FKey.U6, FKey.U8, FKey.U7, FKey.F3, FKey.R3, FKey.B3 };
        f28 = new int[] { FKey.U2, FKey.U4, FKey.U1, FKey.U3, FKey.U7, FKey.U9, FKey.F2, FKey.R2 };
        f29 = new int[] { FKey.U2, FKey.U4, FKey.U3, FKey.U9, FKey.F1, FKey.F2, FKey.R2, FKey.B3 };
        f30 = new int[] { FKey.U2, FKey.U4, FKey.U7, FKey.U9, FKey.L1, FKey.F2, FKey.R2, FKey.R3 };
        f31 = new int[] { FKey.U2, FKey.U3, FKey.U6, FKey.U9, FKey.L2, FKey.F1, FKey.F2, FKey.B3 };
        f32 = new int[] { FKey.U2, FKey.U4, FKey.U1, FKey.U7, FKey.F2, FKey.F3, FKey.R2, FKey.B1 };
        f33 = new int[] { FKey.U3, FKey.U4, FKey.U6, FKey.U9, FKey.F1, FKey.F2, FKey.B2, FKey.B3 };
        f34 = new int[] { FKey.U4, FKey.U6, FKey.U7, FKey.U9, FKey.L1, FKey.F2, FKey.R3, FKey.B2 };
        f35 = new int[] { FKey.U1, FKey.U6, FKey.U8, FKey.U9, FKey.L2, FKey.F1, FKey.R3, FKey.B2 };
        f36 = new int[] { FKey.U1, FKey.U2, FKey.U6, FKey.U9, FKey.L2, FKey.L3, FKey.F2, FKey.B1 };
        f37 = new int[] { FKey.U1, FKey.U2, FKey.U4, FKey.U9, FKey.F1, FKey.F2, FKey.R2, FKey.R3 };
        f38 = new int[] { FKey.U2, FKey.U3, FKey.U4, FKey.U7, FKey.F2, FKey.R1, FKey.R2, FKey.B3 };
        f39 = new int[] { FKey.U3, FKey.U4, FKey.U6, FKey.U7, FKey.F2, FKey.R1, FKey.B2, FKey.B3 };
        f40 = new int[] { FKey.U1, FKey.U4, FKey.U6, FKey.U9, FKey.L3, FKey.F2, FKey.B1, FKey.B2 };
        f41 = new int[] { FKey.U2, FKey.U4, FKey.U7, FKey.U9, FKey.F2, FKey.R2, FKey.B1, FKey.B3 };
        f42 = new int[] { FKey.U1, FKey.U3, FKey.U4, FKey.U8, FKey.F1, FKey.F3, FKey.R2, FKey.B2 };
        f43 = new int[] { FKey.U2, FKey.U3, FKey.U6, FKey.U9, FKey.L1, FKey.L2, FKey.L3, FKey.F2 };
        f44 = new int[] { FKey.U1, FKey.U2, FKey.U4, FKey.U7, FKey.R1, FKey.R2, FKey.R3, FKey.F2 };
        f45 = new int[] { FKey.U3, FKey.U4, FKey.U6, FKey.U9, FKey.L1, FKey.L3, FKey.F2, FKey.B2 };
        f46 = new int[] { FKey.U1, FKey.U2, FKey.U7, FKey.U8, FKey.L2, FKey.R1, FKey.R2, FKey.R3 };
        f47 = new int[] { FKey.U2, FKey.U6, FKey.L2, FKey.F1, FKey.F2, FKey.R1, FKey.R3, FKey.B3 };
        f48 = new int[] { FKey.U2, FKey.U4, FKey.L1, FKey.L3, FKey.F2, FKey.F3, FKey.B1, FKey.R2 };
        f49 = new int[] { FKey.U2, FKey.U6, FKey.L1, FKey.L2, FKey.L3, FKey.F2, FKey.F3, FKey.B1 };
        f50 = new int[] { FKey.U6, FKey.U8, FKey.L1, FKey.L2, FKey.L3, FKey.F3, FKey.B1, FKey.B2 };
        f51 = new int[] { FKey.U4, FKey.U6, FKey.F1, FKey.F2, FKey.R3, FKey.R1, FKey.B2, FKey.B3 };
        f52 = new int[] { FKey.U2, FKey.U8, FKey.L2, FKey.F1, FKey.R1, FKey.R2, FKey.R3, FKey.B3 };
        f53 = new int[] { FKey.U2, FKey.U6, FKey.F1, FKey.F2, FKey.F3, FKey.B1, FKey.L2, FKey.B3 };
        f54 = new int[] { FKey.U2, FKey.U4, FKey.F1, FKey.F2, FKey.F3, FKey.B1, FKey.R2, FKey.B3 };
        f55 = new int[] { FKey.U4, FKey.U6, FKey.F1, FKey.F2, FKey.F3, FKey.B1, FKey.B2, FKey.B3 };
        f56 = new int[] { FKey.U4, FKey.U6, FKey.F2, FKey.B2, FKey.L1, FKey.L3, FKey.R1, FKey.R3 };
        f57 = new int[] { FKey.U1, FKey.U3, FKey.U4, FKey.U6, FKey.U7, FKey.U9, FKey.F2, FKey.B2 };
    }

    public List<string> Solve(string status) {
        List<string> result = new List<string>();
        if (valid(status, f1)) {
            result = formula1;
        } else if (valid(status, f2)) {
            result = formula2;
        } else if (valid(status, f3)) {
            result = formula3;
        } else if (valid(status, f4)) {
            result = formula4;
        } else if (valid(status, f5)) {
            result = formula5;
        } else if (valid(status, f6)) {
            result = formula6;
        } else if (valid(status, f7)) {
            result = formula7;
        } else if (valid(status, f8)) {
            result = formula8;
        } else if (valid(status, f9)) {
            result = formula9;
        } else if (valid(status, f10)) {
            result = formula10;
        } else if (valid(status, f11)) {
            result = formula11;
        } else if (valid(status, f12)) {
            result = formula12;
        } else if (valid(status, f13)) {
            result = formula13;
        } else if (valid(status, f14)) {
            result = formula14;
        } else if (valid(status, f15)) {
            result = formula15;
        } else if (valid(status, f16)) {
            result = formula16;
        } else if (valid(status, f17)) {
            result = formula17;
        } else if (valid(status, f18)) {
            result = formula18;
        } else if (valid(status, f19)) {
            result = formula19;
        } else if (valid(status, f20)) {
            result = formula20;
        } else if (valid(status, f21)) {
            result = formula21;
        } else if (valid(status, f22)) {
            result = formula22;
        } else if (valid(status, f23)) {
            result = formula23;
        } else if (valid(status, f24)) {
            result = formula24;
        } else if (valid(status, f25)) {
            result = formula25;
        } else if (valid(status, f26)) {
            result = formula26;
        } else if (valid(status, f27)) {
            result = formula27;
        } else if (valid(status, f28)) {
            result = formula28;
        } else if (valid(status, f29)) {
            result = formula29;
        } else if (valid(status, f30)) {
            result = formula30;
        } else if (valid(status, f31)) {
            result = formula31;
        } else if (valid(status, f32)) {
            result = formula32;
        } else if (valid(status, f33)) {
            result = formula33;
        } else if (valid(status, f34)) {
            result = formula34;
        } else if (valid(status, f35)) {
            result = formula35;
        } else if (valid(status, f36)) {
            result = formula36;
        } else if (valid(status, f37)) {
            result = formula37;
        } else if (valid(status, f38)) {
            result = formula38;
        } else if (valid(status, f39)) {
            result = formula39;
        } else if (valid(status, f40)) {
            result = formula40;
        } else if (valid(status, f41)) {
            result = formula41;
        } else if (valid(status, f42)) {
            result = formula42;
        } else if (valid(status, f43)) {
            result = formula43;
        } else if (valid(status, f44)) {
            result = formula44;
        } else if (valid(status, f45)) {
            result = formula45;
        } else if (valid(status, f46)) {
            result = formula46;
        } else if (valid(status, f47)) {
            result = formula47;
        } else if (valid(status, f48)) {
            result = formula48;
        } else if (valid(status, f49)) {
            result = formula49;
        } else if (valid(status, f50)) {
            result = formula50;
        } else if (valid(status, f51)) {
            result = formula51;
        } else if (valid(status, f52)) {
            result = formula52;
        } else if (valid(status, f53)) {
            result = formula53;
        } else if (valid(status, f54)) {
            result = formula54;
        } else if (valid(status, f55)) {
            result = formula55;
        } else if (valid(status, f56)) {
            result = formula56;
        } else if (valid(status, f57)) {
            result = formula57;
        } else {
            result = new List<string>() { "U_L" };
        }
        return result;
    }

    bool valid(string status, int[] upfaces) {
        foreach (int i in upfaces) {
            if (status[FKey.U5] != status[i]) {
                return false;
            }
        }
        return true;
    }
}
