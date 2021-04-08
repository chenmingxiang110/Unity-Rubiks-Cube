using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolverPLL
{
    List<string> formulaAa;
    List<string> formulaAb;
    List<string> formulaE;
    List<string> formulaF;
    List<string> formulaGa;
    List<string> formulaGb;
    List<string> formulaGc;
    List<string> formulaGd;
    List<string> formulaH;
    List<string> formulaJa;
    List<string> formulaJb;
    List<string> formulaNa;
    List<string> formulaNb;
    List<string> formulaRa;
    List<string> formulaRb;
    List<string> formulaT;
    List<string> formulaUa;
    List<string> formulaUb;
    List<string> formulaV;
    List<string> formulaY;
    List<string> formulaZ;

    public SolverPLL() {
        formulaAa = Translator.translate("D_ x L2 D2 L_ U_ L D2 L_ U L_ F");
        formulaAb = Translator.translate("x_ L2 D2 L U L_ D2 L U_ L F2");
        formulaE = Translator.translate("x_ L_ U L D_ L_ U_ L D L_ U_ L D_ L_ U L D");
        formulaF = Translator.translate("R_ U_ F_ R U R_ U_ R_ F R2 U_ R_ U_ R U R_ U R");
        formulaGa = Translator.translate("R2 U R_ U R_ U_ R U_ R2 U_ D R_ U R D_");
        formulaGb = Translator.translate("R_ U_ R U D_ R2 U R_ U R U_ R U_ R2 D");
        formulaGc = Translator.translate("R2 U_ R U_ R U R_ U R2 U D_ R U_ R_ D");
        formulaGd = Translator.translate("R U R_ U_ D R2 U_ R U_ R_ U R_ U R2 D_");
        formulaH = Translator.translate("M2 U M2 U2 M2 U M2");
        formulaJa = Translator.translate("x R2 F R F_ R U2 r_ U r U2");
        formulaJb = Translator.translate("R U R_ F_ R U R_ U_ R_ F R2 U_ R_ U_");
        formulaNa = Translator.translate("R U R_ U R U R_ F_ R U R_ U_ R_ F R2 U_ R_ U2 R U_ R_");
        formulaNb = Translator.translate("R_ U R U_ R_ F_ U_ F R U R_ F R_ F_ R U_ R");
        formulaRa = Translator.translate("R U_ R_ U_ R U R D R_ U_ R D_ R_ U2 R_");
        formulaRb = Translator.translate("R2 F R U R U_ R_ F_ R U2 R_ U2 R");
        formulaT = Translator.translate("R U R_ U_ R_ F R2 U_ R_ U_ R U R_ F_");
        formulaUa = Translator.translate("M2 U M U2 M_ U M2");
        formulaUb = Translator.translate("M2 U_ M U2 M_ U_ M2");
        formulaV = Translator.translate("R_ U R_ U_ y R_ F_ R2 U_ R_ U R_ F R F");
        formulaY = Translator.translate("F R U_ R_ U_ R U R_ F_ R U R_ U_ R_ F R F_");
        formulaZ = Translator.translate("M_ U M2 U M2 U M_ U2 M2 U_");
    }

    public List<string> Solve(string status) {
        List<string> result = new List<string>();
        if (isAa(status)) {
            result = formulaAa;
        } else if (isAb(status)) {
            result = formulaAb;
        } else if (isE(status)) {
            result = formulaE;
        } else if (isF(status)) {
            result = formulaF;
        } else if (isGa(status)) {
            result = formulaGa;
        } else if (isGb(status)) {
            result = formulaGb;
        } else if (isGc(status)) {
            result = formulaGc;
        } else if (isGd(status)) {
            result = formulaGd;
        } else if (isH(status)) {
            result = formulaH;
        } else if (isJa(status)) {
            result = formulaJa;
        } else if (isJb(status)) {
            result = formulaJb;
        } else if (isNa(status)) {
            result = formulaNa;
        } else if (isNb(status)) {
            result = formulaNb;
        } else if (isRa(status)) {
            result = formulaRa;
        } else if (isRb(status)) {
            result = formulaRb;
        } else if (isT(status)) {
            result = formulaT;
        } else if (isUa(status)) {
            result = formulaUa;
        } else if (isUb(status)) {
            result = formulaUb;
        } else if (isV(status)) {
            result = formulaV;
        } else if (isY(status)) {
            result = formulaY;
        } else if (isZ(status)) {
            result = formulaZ;
        } else {
            result = new List<string>() { "U_L" };
        }
        return result;
    }

    bool isAa(string status) {
        if (status[FKey.L1] == status[FKey.L3] &&
            status[FKey.L1] == status[FKey.B2] &&
            status[FKey.L2] == status[FKey.R3] &&
            status[FKey.L2] == status[FKey.F1] &&
            status[FKey.F2] == status[FKey.F3] &&
            status[FKey.F2] == status[FKey.B1]) {
            return true;
        }
        return false;
    }

    bool isAb(string status) {
        if (status[FKey.L1] == status[FKey.L3] &&
            status[FKey.L1] == status[FKey.F2] &&
            status[FKey.L2] == status[FKey.B3] &&
            status[FKey.L2] == status[FKey.R1] &&
            status[FKey.F1] == status[FKey.R2] &&
            status[FKey.F1] == status[FKey.R3]) {
            return true;
        }
        return false;
    }

    bool isE(string status) {
        if (status[FKey.L1] == status[FKey.F2] &&
            status[FKey.L1] == status[FKey.R3] &&
            status[FKey.L2] == status[FKey.B3] &&
            status[FKey.L2] == status[FKey.F1] &&
            status[FKey.L3] == status[FKey.R1] &&
            status[FKey.L3] == status[FKey.B2]) {
            return true;
        }
        return false;
    }

    bool isF(string status) {
        if (status[FKey.L1] == status[FKey.L3] &&
            status[FKey.L1] == status[FKey.L2] &&
            status[FKey.F1] == status[FKey.B2] &&
            status[FKey.F1] == status[FKey.R3] &&
            status[FKey.F2] == status[FKey.B3] &&
            status[FKey.F2] == status[FKey.R1]) {
            return true;
        }
        return false;
    }

    bool isGa(string status) {
        if (status[FKey.L1] == status[FKey.L3] &&
            status[FKey.L1] == status[FKey.R2] &&
            status[FKey.L2] == status[FKey.B3] &&
            status[FKey.L2] == status[FKey.R1] &&
            status[FKey.F1] == status[FKey.R3] &&
            status[FKey.F1] == status[FKey.B2]) {
            return true;
        }
        return false;
    }

    bool isGb(string status) {
        if (status[FKey.L1] == status[FKey.L3] &&
            status[FKey.L1] == status[FKey.B2] &&
            status[FKey.L2] == status[FKey.B1] &&
            status[FKey.L2] == status[FKey.F3] &&
            status[FKey.F1] == status[FKey.R2] &&
            status[FKey.F1] == status[FKey.R3]) {
            return true;
        }
        return false;
    }

    bool isGc(string status) {
        if (status[FKey.L1] == status[FKey.L3] &&
            status[FKey.L1] == status[FKey.R2] &&
            status[FKey.L2] == status[FKey.R3] &&
            status[FKey.L2] == status[FKey.F1] &&
            status[FKey.F2] == status[FKey.B3] &&
            status[FKey.F2] == status[FKey.R1]) {
            return true;
        }
        return false;
    }

    bool isGd(string status) {
        if (status[FKey.L1] == status[FKey.L3] &&
            status[FKey.L1] == status[FKey.F2] &&
            status[FKey.L2] == status[FKey.F3] &&
            status[FKey.L2] == status[FKey.B1] &&
            status[FKey.F1] == status[FKey.R3] &&
            status[FKey.F1] == status[FKey.B2]) {
            return true;
        }
        return false;
    }

    bool isH(string status) {
        if (status[FKey.L1] == status[FKey.L3] &&
            status[FKey.L1] == status[FKey.R2] &&
            status[FKey.L2] == status[FKey.R3] &&
            status[FKey.L2] == status[FKey.R1] &&
            status[FKey.F2] == status[FKey.B3] &&
            status[FKey.F2] == status[FKey.B1]) {
            return true;
        }
        return false;
    }

    bool isJa(string status) {
        if (status[FKey.L1] == status[FKey.L3] &&
            status[FKey.L1] == status[FKey.L2] &&
            status[FKey.F3] == status[FKey.B1] &&
            status[FKey.F3] == status[FKey.B2] &&
            status[FKey.F1] == status[FKey.F2] &&
            status[FKey.F1] == status[FKey.R3]) {
            return true;
        }
        return false;
    }

    bool isJb(string status) {
        if (status[FKey.L1] == status[FKey.L3] &&
            status[FKey.L1] == status[FKey.L2] &&
            status[FKey.F2] == status[FKey.B1] &&
            status[FKey.F2] == status[FKey.F3] &&
            status[FKey.F1] == status[FKey.R3] &&
            status[FKey.F1] == status[FKey.R2]) {
            return true;
        }
        return false;
    }

    bool isNa(string status) {
        if (status[FKey.L1] == status[FKey.R3] &&
            status[FKey.L1] == status[FKey.R2] &&
            status[FKey.L2] == status[FKey.L3] &&
            status[FKey.L2] == status[FKey.R1] &&
            status[FKey.F2] == status[FKey.F3] &&
            status[FKey.F2] == status[FKey.B1]) {
            return true;
        }
        return false;
    }

    bool isNb(string status) {
        if (status[FKey.L1] == status[FKey.L2] &&
            status[FKey.L1] == status[FKey.R3] &&
            status[FKey.L3] == status[FKey.R2] &&
            status[FKey.L3] == status[FKey.R1] &&
            status[FKey.F2] == status[FKey.F1] &&
            status[FKey.F2] == status[FKey.B3]) {
            return true;
        }
        return false;
    }

    bool isRa(string status) {
        if (status[FKey.L1] == status[FKey.L3] &&
            status[FKey.L1] == status[FKey.B2] &&
            status[FKey.L2] == status[FKey.B3] &&
            status[FKey.L2] == status[FKey.R1] &&
            status[FKey.F2] == status[FKey.F1] &&
            status[FKey.F2] == status[FKey.R3]) {
            return true;
        }
        return false;
    }

    bool isRb(string status) {
        if (status[FKey.L1] == status[FKey.L3] &&
            status[FKey.L1] == status[FKey.F2] &&
            status[FKey.L2] == status[FKey.R3] &&
            status[FKey.L2] == status[FKey.F1] &&
            status[FKey.F3] == status[FKey.R2] &&
            status[FKey.F3] == status[FKey.B1]) {
            return true;
        }
        return false;
    }

    bool isT(string status) {
        if (status[FKey.L1] == status[FKey.L3] &&
            status[FKey.L1] == status[FKey.R2] &&
            status[FKey.L2] == status[FKey.B1] &&
            status[FKey.L2] == status[FKey.F3] &&
            status[FKey.F2] == status[FKey.F1] &&
            status[FKey.F2] == status[FKey.R3]) {
            return true;
        }
        return false;
    }

    bool isUa(string status) {
        if (status[FKey.L1] == status[FKey.L3] &&
            status[FKey.L1] == status[FKey.R2] &&
            status[FKey.L2] == status[FKey.F3] &&
            status[FKey.L2] == status[FKey.F1] &&
            status[FKey.F2] == status[FKey.R3] &&
            status[FKey.F2] == status[FKey.R1]) {
            return true;
        }
        return false;
    }

    bool isUb(string status) {
        if (status[FKey.L1] == status[FKey.L3] &&
            status[FKey.L1] == status[FKey.F2] &&
            status[FKey.L2] == status[FKey.R3] &&
            status[FKey.L2] == status[FKey.R1] &&
            status[FKey.R2] == status[FKey.F3] &&
            status[FKey.R2] == status[FKey.F1]) {
            return true;
        }
        return false;
    }

    bool isV(string status) {
        if (status[FKey.L1] == status[FKey.R3] &&
            status[FKey.L1] == status[FKey.B2] &&
            status[FKey.L2] == status[FKey.L3] &&
            status[FKey.L2] == status[FKey.R1] &&
            status[FKey.F2] == status[FKey.F1] &&
            status[FKey.F2] == status[FKey.B3]) {
            return true;
        }
        return false;
    }

    bool isY(string status) {
        if (status[FKey.L1] == status[FKey.R3] &&
            status[FKey.L1] == status[FKey.R2] &&
            status[FKey.L2] == status[FKey.F3] &&
            status[FKey.L2] == status[FKey.B1] &&
            status[FKey.F2] == status[FKey.F1] &&
            status[FKey.F2] == status[FKey.B3]) {
            return true;
        }
        return false;
    }

    bool isZ(string status) {
        if (status[FKey.L1] == status[FKey.L3] &&
            status[FKey.L1] == status[FKey.F2] &&
            status[FKey.L2] == status[FKey.F3] &&
            status[FKey.L2] == status[FKey.F1] &&
            status[FKey.R2] == status[FKey.B3] &&
            status[FKey.R2] == status[FKey.B1]) {
            return true;
        }
        return false;
    }
}
