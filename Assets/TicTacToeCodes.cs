using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TicTacToeCodes : MonoBehaviour
{
    public Boolean checker;
    int plusone;

    public Boolean btnWritten1;
    public Boolean btnWritten2;
    public Boolean btnWritten3;
    public Boolean btnWritten4;
    public Boolean btnWritten5;
    public Boolean btnWritten6;
    public Boolean btnWritten7;
    public Boolean btnWritten8;
    public Boolean btnWritten9;

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
    public Text msgTurn = null;

    public Text txtPlayerX;
    public Text txtPlayerO;


    public void Draw()
    {
        msgFeedback.text = "It's a draw!";
        msgTurn.text = "";
    }

    public void WinnerX(Text btnTextA, Text btnTextB, Text btnTextC)
    {
        btnTextA.color = Color.red;
        btnTextB.color = Color.red;
        btnTextC.color = Color.red;
        msgFeedback.text = "The winner is Player X";
        plusone = int.Parse(txtPlayerX.text); //viene preso il testo contenuto nella variabile txtPlayerX.text e viene convertito in un numero intero (int) utilizzando il metodo int.Parse()
        txtPlayerX.text = Convert.ToString(plusone + 1); //viene preso il valore attuale di plusone, viene sommato 1 e il risultato viene convertito in una stringa utilizzando il metodo Convert.ToString(). Questa stringa risultante viene quindi assegnata di nuovo alla variabile txtPlayerX.text
        msgTurn.text = "";
        AllBtnToTrue();
    }

    public void WinnerO(Text btnTextA, Text btnTextB, Text btnTextC)
    {
        btnTextA.color = Color.red;
        btnTextB.color = Color.red;
        btnTextC.color = Color.red;
        msgFeedback.text = "The winner is Player O";
        plusone = int.Parse(txtPlayerO.text);
        txtPlayerO.text = Convert.ToString(plusone + 1); 
        msgTurn.text = "";
        AllBtnToTrue();
    }

    public void AllBtnToTrue()
    {
        btnWritten1 = true;
        btnWritten2 = true;
        btnWritten3 = true;
        btnWritten4 = true;
        btnWritten5 = true;
        btnWritten6 = true;
        btnWritten7 = true;
        btnWritten8 = true;
        btnWritten9 = true;
    }

    public void score()
    {
        //========================== Draw =========================================
        if (btnWritten1 && btnWritten2 && btnWritten3 && btnWritten4 && btnWritten5 && btnWritten6 && btnWritten7 && btnWritten8 && btnWritten9)
        {
            Draw();
        }
        //========================== Players =========================================
        //Case 1: 1-2-3
        if (btnText1 != null && btnText1.text == btnText2.text && btnText2.text == btnText3.text)
        {
            if (btnText1.text == "X")
            {
                WinnerX(btnText1, btnText2, btnText3);
            }
            else if (btnText1.text == "O")
            {
                WinnerO(btnText1, btnText2, btnText3);
            }

        }
        //Case 2: 1-4-7
        if (btnText1 != null && btnText1.text == btnText4.text && btnText4.text == btnText7.text)
        {
            if (btnText1.text == "X")
            {
                WinnerX(btnText1, btnText4, btnText7);
            }
            else if (btnText1.text == "O")
            {
                WinnerO(btnText1, btnText4, btnText7);
            }
        }
        //Case 3: 1-5-9
        if (btnText1 != null && btnText1.text == btnText5.text && btnText5.text == btnText9.text)
        {
            if (btnText1.text == "X" && btnText5.text == "X" && btnText9.text == "X")
            {
                WinnerX(btnText1, btnText5, btnText9);
            }
            else if (btnText1.text == "O")
            {
                WinnerO(btnText1, btnText5, btnText9);
            }
        }
        //Case 4: 3-5-7
        if (btnText3 != null && btnText3.text == btnText5.text && btnText5.text == btnText7.text)
        {
            if (btnText3.text == "X")
            {
                WinnerX(btnText3, btnText5, btnText7);
            }
            else if (btnText3.text == "O")
            {
                WinnerO(btnText3, btnText5, btnText7);
            }
        }
        //Case 5: 2-5-8
        if (btnText2 != null && btnText2.text == btnText5.text && btnText5.text == btnText8.text)
        {
            if (btnText2.text == "X")
            {
                WinnerX(btnText2, btnText5, btnText8);
            }
            else if (btnText2.text == "O")
            {
                WinnerO(btnText2, btnText5, btnText8);
            }
        }
        //Case 6: 3-6-9
        if (btnText3 != null && btnText3.text == btnText6.text && btnText6.text == btnText9.text)
        {
            if (btnText3.text == "X")
            {
                WinnerX(btnText3, btnText6, btnText9);
            }
            else if (btnText3.text == "O")
            {
                WinnerO(btnText3, btnText6, btnText9);
            }
        }
        //Case 7: 4-5-6
        if (btnText4 != null && btnText4.text == btnText5.text && btnText5.text == btnText6.text)
        {
            if (btnText4.text == "X")
            {
                WinnerX(btnText4, btnText5, btnText6);
            }
            else if (btnText4.text == "O")
            {
                WinnerO(btnText4, btnText5, btnText6);
            }
        }
        //Case 8: 7-8-9
        if (btnText7 != null && btnText7.text == btnText8.text && btnText8.text == btnText9.text)
        {
            if (btnText7.text == "X")
            {
                WinnerX(btnText7, btnText8, btnText9);
            }
            else if (btnText7.text == "O")
            {
                WinnerO(btnText7, btnText8, btnText9);
            }
        }

    }



    public void btnText1_Click()
    {
        if (btnWritten1 == false)
        {
            if (checker == false)
            {
                btnText1.text = "X";
                checker = true;
                msgTurn.text = "O TURN";
            }
            else
            {
                btnText1.text = "O";
                checker = false;
                msgTurn.text = "X TURN";
            }
            btnWritten1 = true;
            score();
        }

    }
    public void btnText2_Click()
    {
        if (btnWritten2 == false)
        {
            if (checker == false)
            {
                btnText2.text = "X";
                checker = true;
                msgTurn.text = "O TURN";
            }
            else
            {
                btnText2.text = "O";
                checker = false;
                msgTurn.text = "X TURN";
            }
            btnWritten2 = true;
            score();
        }
    }
    public void btnText3_Click()
    {
        if (btnWritten3 == false)
        {
            if (checker == false)
            {
                btnText3.text = "X";
                checker = true;
                msgTurn.text = "O TURN";
            }
            else
            {
                btnText3.text = "O";
                checker = false;
                msgTurn.text = "X TURN";
            }
            btnWritten3 = true;
            score();
        }
    }
    public void btnText4_Click()
    {
        if (btnWritten4 == false)
        {
            if (checker == false)
            {
                btnText4.text = "X";
                checker = true;
                msgTurn.text = "O TURN";
            }
            else
            {
                btnText4.text = "O";
                checker = false;
                msgTurn.text = "X TURN";
            }
            btnWritten4 = true;
            score();
        }
    }
    public void btnText5_Click()
    {
        if (btnWritten5 == false)
        {
            if (checker == false)
            {
                btnText5.text = "X";
                checker = true;
                msgTurn.text = "O TURN";
            }
            else
            {
                btnText5.text = "O";
                checker = false;
                msgTurn.text = "X TURN";
            }
            btnWritten5 = true;
            score();
        }
    }
    public void btnText6_Click()
    {
        if (btnWritten6 == false)
        {
            if (checker == false)
            {
                btnText6.text = "X";
                checker = true;
                msgTurn.text = "O TURN";
            }
            else
            {
                btnText6.text = "O";
                checker = false;
                msgTurn.text = "X TURN";
            }
            btnWritten6 = true;
            score();
        }
    }
    public void btnText7_Click()
    {
        if (btnWritten7 == false)
        {
            if (checker == false)
            {
                btnText7.text = "X";
                checker = true;
                msgTurn.text = "O TURN";
            }
            else
            {
                btnText7.text = "O";
                checker = false;
                msgTurn.text = "X TURN";
            }
            btnWritten7 = true;
            score();
        }
    }
    public void btnText8_Click()
    {
        if (btnWritten8 == false)
        {
            if (checker == false)
            {
                btnText8.text = "X";
                checker = true;
                msgTurn.text = "O TURN";
            }
            else
            {
                btnText8.text = "O";
                checker = false;
                msgTurn.text = "X TURN";
            }
            btnWritten8 = true;
            score();
        }
    }
    public void btnText9_Click()
    {
        if (btnWritten9 == false)
        {
            if (checker == false)
            {
                btnText9.text = "X";
                checker = true;
                msgTurn.text = "O TURN";
            }
            else
            {
                btnText9.text = "O";
                checker = false;
                msgTurn.text = "X TURN";
            }
            btnWritten9 = true;
            score();
        }
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
        msgTurn.text = "X TURN";
        checker = false;
        btnWritten1 = false;
        btnWritten2 = false;
        btnWritten3 = false;
        btnWritten4 = false;
        btnWritten5 = false;
        btnWritten6 = false;
        btnWritten7 = false;
        btnWritten8 = false;
        btnWritten9 = false;
        

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
