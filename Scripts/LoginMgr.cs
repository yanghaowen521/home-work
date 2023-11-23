using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginMgr : MonoBehaviour
{
    public InputField studentName;
    public InputField studentID;
    public static string StudentName; 

    public void ConfirmLogin()
    {
        if (studentName.text == "Ñîê»ÎÄ" && studentID.text == "0210442")
        {
            StudentName = studentName.text;
            SceneManager.LoadScene(1);
        }
    }
}
