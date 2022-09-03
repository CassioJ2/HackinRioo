using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefinePlayer : MonoBehaviour
{
    public SpawnPlayer spawn;
    public int playerType;



    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);

    }

    public void getType(int typePlayer)
    {
        playerType = typePlayer;
    }


}

