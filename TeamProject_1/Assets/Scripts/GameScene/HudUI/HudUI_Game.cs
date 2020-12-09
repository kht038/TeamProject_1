using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudUI_Game : MonoBehaviour
{
    [SerializeField] Image m_FadePannel;

    void Start()
    {
        coFadeOut();
    }

    void Update()
    {
        
    }

    public void coFadeOut()
    {
        StartCoroutine(Enum_Game_FadeOut());
    }

    IEnumerator Enum_Game_FadeOut()
    {
        m_FadePannel.gameObject.SetActive(true);

        Color kColor = m_FadePannel.color;
        kColor.a = 1;

        while (kColor.a > 0)
        {
            m_FadePannel.color = kColor;
            yield return new WaitForSeconds(Time.deltaTime);
            kColor.a -= Time.deltaTime;
        }
        m_FadePannel.gameObject.SetActive(false);
    }
}
