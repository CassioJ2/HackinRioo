using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefinePlayer : MonoBehaviour
{
    public SpawnPlayer spawn;
    public int playerType;

    public InputField nameInput;

    public string playerName;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void getType(int typePlayer)
    {
        playerType = typePlayer;
    }

    public void getName()
    {
        playerName = nameInput.text;
    }


}

