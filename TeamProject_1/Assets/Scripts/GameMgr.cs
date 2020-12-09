using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : Singleton<GameMgr>
{
    public GameScene m_GameScene;
    public void SetGameScene(GameScene Scene)    {
        m_GameScene = Scene;
    }

    public bool IsInstalled { get; set; }

    public void Initialize()
    {
        IsInstalled = true;
    }
}
