using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundPanelDlg : MonoBehaviour
{
    public Slider m_BGMSlider;
    public Slider m_SFXSlider;

    public Text m_BGMValue;

    public AudioSource m_Audio;
    public float m_Slide;
    void Start()
    {
        SoundSave();
        m_Audio.Play();
    }
    public void Initialize()
    {

    }

    void Update()
    {
        SoundControl();
    }

    public void SoundControl()
    {
        m_Audio.volume = m_BGMSlider.value;
        m_Slide = m_BGMSlider.value;
        PlayerPrefs.SetFloat("m_Slide", m_Slide);

        m_BGMValue.text = string.Format("배경음악 : {0}", (int)(m_BGMSlider.value * 100));
    }

    public void SoundSave()
    {
        m_Slide = PlayerPrefs.GetFloat("m_Slide", 1f) ;
        m_BGMSlider.value = m_Slide;
        m_Audio.volume = m_BGMSlider.value;
    }
}
