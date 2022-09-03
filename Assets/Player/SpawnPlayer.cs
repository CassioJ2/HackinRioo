using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{

    public DefinePlayer define;

    public GameObject playerPrefab;
    public GameObject jessPrefab;
    public GameObject rosePrefab;

    public int typeOfPlayer;

    public float minX, maxX;
    public float uniqueY;
    public float minZ, maxZ;
    // Start is called before the first frame update


    void Start()
    {
        define = GameObject.Find("DefinePlayer").GetComponent<DefinePlayer>();

        if(define.playerType == 1)
        {
            playerPrefab = jessPrefab;
        } else if(define.playerType == 2)
        {
            playerPrefab = rosePrefab;
        }

        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), uniqueY, Random.Range(minZ, maxZ));
        PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);

    }

}
