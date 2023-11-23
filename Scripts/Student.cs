using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Student : MonoBehaviour
{
    public Sprite[] sprites;
    public Image icon;
    public Text studentName;

    // Start is called before the first frame update
    void Start()
    {
        icon.sprite = sprites[Random.Range(0, sprites.Length)];
        studentName.text = LoginMgr.StudentName;
    }

}
