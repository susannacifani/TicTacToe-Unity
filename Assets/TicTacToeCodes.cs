using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TicTacToeCodes : MonoBehaviour
{
    Boolean checker;
    int plusone;

    public Text btnText1 = null;
    public Text btnText2 = null;
    public Text btnText3 = null;
    public Text btnText4 = null;
    public Text btnText5 = null;
    public Text btnText6 = null;
    public Text btnText7 = null;
    public Text btnText8 = null;
    public Text btnText9 = null;

    public Text btnResetGame = null;
    public Text btnNewGame = null;
    public Text msgFeedback = null;

    public Text txtPlayerX;
    public Text txtPlayerO;

    public void score()
    {
        if (btnText1.text == "X" && btnText2.text == "X" && btnText3.text == "X")
        {
            btnText1.color = Color.red;
            btnText2.color = Color.red;
            btnText3.color = Color.red;
            msgFeedback.text = "The winner is Player X";
            plusone = int.Parse(txtPlayerX.text); //viene preso il testo contenuto nella variabile txtPlayerX.text e viene convertito in un numero intero (int) utilizzando il metodo int.Parse()
            txtPlayerX.text = Convert.ToString(plusone + 1); //viene preso il valore attuale di plusone, viene sommato 1 e il risultato viene convertito in una stringa utilizzando il metodo Convert.ToString(). Questa stringa risultante viene quindi assegnata di nuovo alla variabile txtPlayerX.text
        }
        if (btnText1.text == "X" && btnText4.text == "X" && btnText7.text == "X")
        {
            btnText1.color = Color.red;
            btnText4.color = Color.red;
            btnText7.color = Color.red;
            msgFeedback.text = "The winner is Player X";
            plusone = int.Parse(txtPlayerX.text); //viene preso il testo contenuto nella variabile txtPlayerX.text e viene convertito in un numero intero (int) utilizzando il metodo int.Parse()
            txtPlayerX.text = Convert.ToString(plusone + 1); //viene preso il valore attuale di plusone, viene sommato 1 e il risultato viene convertito in una stringa utilizzando il metodo Convert.ToString(). Questa stringa risultante viene quindi assegnata di nuovo alla variabile txtPlayerX.text
        }
        if (btnText1.text == "X" && btnText5.text == "X" && btnText9.text == "X")
        {
            btnText1.color = Color.red;
            btnText5.color = Color.red;
            btnText9.color = Color.red;
            msgFeedback.text = "The winner is Player X";
            plusone = int.Parse(txtPlayerX.text); //viene preso il testo contenuto nella variabile txtPlayerX.text e viene convertito in un numero intero (int) utilizzando il metodo int.Parse()
            txtPlayerX.text = Convert.ToString(plusone + 1); //viene preso il valore attuale di plusone, viene sommato 1 e il risultato viene convertito in una stringa utilizzando il metodo Convert.ToString(). Questa stringa risultante viene quindi assegnata di nuovo alla variabile txtPlayerX.text
        }
        if (btnText3.text == "X" && btnText5.text == "X" && btnText7.text == "X")
        {
            btnText3.color = Color.red;
            btnText5.color = Color.red;
            btnText7.color = Color.red;
            msgFeedback.text = "The winner is Player X";
            plusone = int.Parse(txtPlayerX.text); //viene preso il testo contenuto nella variabile txtPlayerX.text e viene convertito in un numero intero (int) utilizzando il metodo int.Parse()
            txtPlayerX.text = Convert.ToString(plusone + 1); //viene preso il valore attuale di plusone, viene sommato 1 e il risultato viene convertito in una stringa utilizzando il metodo Convert.ToString(). Questa stringa risultante viene quindi assegnata di nuovo alla variabile txtPlayerX.text
        }
        if (btnText2.text == "X" && btnText5.text == "X" && btnText8.text == "X")
        {
            btnText2.color = Color.red;
            btnText5.color = Color.red;
            btnText8.color = Color.red;
            msgFeedback.text = "The winner is Player X";
            plusone = int.Parse(txtPlayerX.text); //viene preso il testo contenuto nella variabile txtPlayerX.text e viene convertito in un numero intero (int) utilizzando il metodo int.Parse()
            txtPlayerX.text = Convert.ToString(plusone + 1); //viene preso il valore attuale di plusone, viene sommato 1 e il risultato viene convertito in una stringa utilizzando il metodo Convert.ToString(). Questa stringa risultante viene quindi assegnata di nuovo alla variabile txtPlayerX.text
        }
        if (btnText3.text == "X" && btnText6.text == "X" && btnText9.text == "X")
        {
            btnText3.color = Color.red;
            btnText6.color = Color.red;
            btnText9.color = Color.red;
            msgFeedback.text = "The winner is Player X";
            plusone = int.Parse(txtPlayerX.text); //viene preso il testo contenuto nella variabile txtPlayerX.text e viene convertito in un numero intero (int) utilizzando il metodo int.Parse()
            txtPlayerX.text = Convert.ToString(plusone + 1); //viene preso il valore attuale di plusone, viene sommato 1 e il risultato viene convertito in una stringa utilizzando il metodo Convert.ToString(). Questa stringa risultante viene quindi assegnata di nuovo alla variabile txtPlayerX.text
        }
        if (btnText4.text == "X" && btnText5.text == "X" && btnText6.text == "X")
        {
            btnText4.color = Color.red;
            btnText5.color = Color.red;
            btnText6.color = Color.red;
            msgFeedback.text = "The winner is Player X";
            plusone = int.Parse(txtPlayerX.text); //viene preso il testo contenuto nella variabile txtPlayerX.text e viene convertito in un numero intero (int) utilizzando il metodo int.Parse()
            txtPlayerX.text = Convert.ToString(plusone + 1); //viene preso il valore attuale di plusone, viene sommato 1 e il risultato viene convertito in una stringa utilizzando il metodo Convert.ToString(). Questa stringa risultante viene quindi assegnata di nuovo alla variabile txtPlayerX.text
        }
        if (btnText7.text == "X" && btnText8.text == "X" && btnText9.text == "X")
        {
            btnText7.color = Color.red;
            btnText8.color = Color.red;
            btnText9.color = Color.red;
            msgFeedback.text = "The winner is Player X";
            plusone = int.Parse(txtPlayerX.text); //viene preso il testo contenuto nella variabile txtPlayerX.text e viene convertito in un numero intero (int) utilizzando il metodo int.Parse()
            txtPlayerX.text = Convert.ToString(plusone + 1); //viene preso il valore attuale di plusone, viene sommato 1 e il risultato viene convertito in una stringa utilizzando il metodo Convert.ToString(). Questa stringa risultante viene quindi assegnata di nuovo alla variabile txtPlayerX.text
        }
        //============================Player O================================
        if (btnText1.text == "O" && btnText2.text == "O" && btnText3.text == "O")
        {
            btnText1.color = Color.red;
            btnText2.color = Color.red;
            btnText3.color = Color.red;
            msgFeedback.text = "The winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        if (btnText1.text == "O" && btnText4.text == "O" && btnText7.text == "O")
        {
            btnText1.color = Color.red;
            btnText4.color = Color.red;
            btnText7.color = Color.red;
            msgFeedback.text = "The winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        if (btnText1.text == "O" && btnText5.text == "O" && btnText9.text == "O")
        {
            btnText1.color = Color.red;
            btnText5.color = Color.red;
            btnText9.color = Color.red;
            msgFeedback.text = "The winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        if (btnText3.text == "O" && btnText5.text == "O" && btnText7.text == "O")
        {
            btnText3.color = Color.red;
            btnText5.color = Color.red;
            btnText7.color = Color.red;
            msgFeedback.text = "The winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        if (btnText2.text == "O" && btnText5.text == "O" && btnText8.text == "O")
        {
            btnText2.color = Color.red;
            btnText5.color = Color.red;
            btnText8.color = Color.red;
            msgFeedback.text = "The winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        if (btnText3.text == "O" && btnText6.text == "O" && btnText9.text == "O")
        {
            btnText3.color = Color.red;
            btnText6.color = Color.red;
            btnText9.color = Color.red;
            msgFeedback.text = "The winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        if (btnText4.text == "O" && btnText5.text == "O" && btnText6.text == "O")
        {
            btnText4.color = Color.red;
            btnText5.color = Color.red;
            btnText6.color = Color.red;
            msgFeedback.text = "The winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        if (btnText7.text == "O" && btnText8.text == "O" && btnText9.text == "O")
        {
            btnText7.color = Color.red;
            btnText8.color = Color.red;
            btnText9.color = Color.red;
            msgFeedback.text = "The winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
    }

    public void btnText1_Click()
    {
        if (checker == false)
        {
            btnText1.text = "X";
            checker = true;
        }
        else
        {
            btnText1.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText2_Click()
    {
        if (checker == false)
        {
            btnText2.text = "X";
            checker = true;
        }
        else
        {
            btnText2.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText3_Click()
    {
        if (checker == false)
        {
            btnText3.text = "X";
            checker = true;
        }
        else
        {
            btnText3.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText4_Click()
    {
        if (checker == false)
        {
            btnText4.text = "X";
            checker = true;
        }
        else
        {
            btnText4.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText5_Click()
    {
        if (checker == false)
        {
            btnText5.text = "X";
            checker = true;
        }
        else
        {
            btnText5.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText6_Click()
    {
        if (checker == false)
        {
            btnText6.text = "X";
            checker = true;
        }
        else
        {
            btnText6.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText7_Click()
    {
        if (checker == false)
        {
            btnText7.text = "X";
            checker = true;
        }
        else
        {
            btnText7.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText8_Click()
    {
        if (checker == false)
        {
            btnText8.text = "X";
            checker = true;
        }
        else
        {
            btnText8.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText9_Click()
    {
        if (checker == false)
        {
            btnText9.text = "X";
            checker = true;
        }
        else
        {
            btnText9.text = "O";
            checker = false;
        }
        score();
    }

    public void btnResetGame_Click()
    {
        btnText1.text = "";
        btnText2.text = "";
        btnText3.text = "";
        btnText4.text = "";
        btnText5.text = "";
        btnText6.text = "";
        btnText7.text = "";
        btnText8.text = "";
        btnText9.text = "";
        msgFeedback.text = "";

        btnText1.color = Color.black; 
        btnText2.color = Color.black;
        btnText3.color = Color.black;
        btnText4.color = Color.black;
        btnText5.color = Color.black;
        btnText6.color = Color.black;
        btnText7.color = Color.black;
        btnText8.color = Color.black;
        btnText9.color = Color.black;
    }

    public void btnNewGame_Click()
    {
        btnResetGame_Click();
        txtPlayerX.text = "0";
        txtPlayerO.text = "0";

    }




}
