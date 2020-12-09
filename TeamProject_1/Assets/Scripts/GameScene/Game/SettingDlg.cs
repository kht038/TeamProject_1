using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingDlg : MonoBehaviour
{
    public Button m_BtnSet;
    public Button m_BtnBack;

    [SerializeField] GameObject m_SettingPannel;
    [SerializeField] Image m_FadePanel;

    void Start()
    {
        m_BtnSet.onClick.AddListener(OnClickedSet);
        m_BtnBack.onClick.AddListener(OnClickedBack);
        m_SettingPannel.SetActive(false);
    }

    void Update()
    {
        
    }

    public void OnClickedSet()
    {
        m_BtnSet.gameObject.SetActive(false);
        m_BtnBack.interactable = true;
        m_SettingPannel.SetActive(true);
        if (m_FadePanel.gameObject.activeSelf)
            StartCoroutine(FadeInPlay());
    }
    public void OnClickedBack()
    {
        m_BtnBack.interactable = false;
        m_BtnSet.gameObject.SetActive(true);
        //if (m_FadePanel.gameObject.activeSelf)
        //    StartCoroutine(FadeOutPlay());
        m_SettingPannel.gameObject.SetActive(false);
    }


    // 아 ㅋㅋ setActive 활성화 안된얘들은 코루틴 작동 안한다니깐
    IEnumerator FadeInPlay()
    {
        Color FadeColor = m_FadePanel.color;
        FadeColor.a = 0;

        while (FadeColor.a < 1)
        {
            m_FadePanel.material.SetFloat("_Blur", FadeColor.a * 10);
            yield return new WaitForSeconds(Time.deltaTime);
            FadeColor.a += Time.deltaTime * 4;
        }
    }

    IEnumerator FadeOutPlay()
    {
        Color FadeColor = m_FadePanel.color;
        FadeColor.a = 1;

        while (FadeColor.a > 0)
        {
            m_FadePanel.material.SetFloat("_Blur", FadeColor.a * 10);
            yield return new WaitForSeconds(Time.deltaTime);
            FadeColor.a -= Time.deltaTime * 4;
        }

        m_SettingPannel.SetActive(false);
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
    }
    public void Close()
    {
        this.gameObject.SetActive(false);
    }
}
