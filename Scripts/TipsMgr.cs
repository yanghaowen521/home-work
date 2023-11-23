using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipsMgr : MonoBehaviour
{
    public static TipsMgr Instance;
    public Text tipsText;
    public GameObject tipsObj;

    void Awake()
    {
        Instance = this;
    }

    public void SetTipsText(string str)
    {
        tipsObj.SetActive(true);
        tipsText.text = str;
    }
}
