using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScene : MonoBehaviour
{
    public int sceneNumber;
    public void LoadScene(int sceneNumber)
    {
        Indestructable.instance.prevScene = Application.loadedLevel;

        Application.LoadLevel(sceneNumber);
    }
}
