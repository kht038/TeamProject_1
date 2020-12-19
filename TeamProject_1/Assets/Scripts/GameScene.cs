using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    private BattleFSM m_FSM = new BattleFSM();

    void Start()
    {
        Initialize();
    }

    void Update()
    {
        if (m_FSM != null)
        {
            m_FSM.OnUpdate();
        }
    }
    public void Initialize()
    {
        m_FSM.Initialize(OnEnterBoss, OnEnterWave, OnEnterGame);
        m_FSM.SetCallback_GameStateOnExit(OnExitGame);
        m_FSM.SetGameState();
        GameMgr.Inst.SetGameScene(this);
        GameMgr.Inst.Initialize();
    }

    public void OnEnterWave()
    {
        Debug.Log("OnEnterWave");
    }

    public void OnEnterBoss()
    {
        Debug.Log("OnEnterBoss");
    }
    public void OnEnterGame()
    {
        Debug.Log("OnEnterGame");
    }

    public void OnExitGame()
    {
        Debug.Log("OnExitGame");
    }
}
