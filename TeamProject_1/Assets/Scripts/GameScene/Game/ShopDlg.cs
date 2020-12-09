using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopDlg : MonoBehaviour
{
    public Button m_BtnShop;

    public bool B_Check;

    public Animator m_ani;


    void Start()
    {
        B_Check = false;
        m_ani.SetBool("bSelc", B_Check);

        m_BtnShop.onClick.AddListener(OnClickShop);
    }

    public void OnClickShop()
    {
        if (B_Check)
        {
            B_Check = false;
            m_ani.SetBool("bSelc", B_Check);
        }
        else
        {
            B_Check = true;
            m_ani.SetBool("bSelc", B_Check);
        }
    }
}
