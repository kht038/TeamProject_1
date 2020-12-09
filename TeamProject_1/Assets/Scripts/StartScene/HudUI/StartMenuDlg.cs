using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenuDlg : MonoBehaviour
{
    public Button m_BtnStart;
    public Button m_BtnOption;
    public Button m_BtnExit;

    [SerializeField] Image m_FadePannel;

    void Start()
    {
        m_BtnStart.onClick.AddListener(OnClickBtnStart);
        m_BtnExit.onClick.AddListener(OnClickBtnExit);
    }

    public void OnClickBtnStart()
    {
        if(!m_FadePannel.gameObject.activeSelf)
            StartCoroutine(Enum_ChangeScene_Game_FadeIn());
    }

    public void OnClickBtnExit()
    {
        ExitGame();
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit() // 어플리케이션 종료
#endif
    }
    IEnumerator Enum_ChangeScene_Game_FadeIn()
    {
        m_FadePannel.gameObject.SetActive(true);

        Color kColor = m_FadePannel.color;
        kColor.a = 0;

        while (kColor.a < 1)
        {
            m_FadePannel.color = kColor;
            yield return new WaitForSeconds(Time.deltaTime);
            kColor.a += Time.deltaTime;
        }

        SceneManager.LoadScene("GameScene");
        yield return null;
    }
}
