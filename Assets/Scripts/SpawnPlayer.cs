using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class SpawnPlayer : MonoBehaviour
{
    [Header("Loading Player Info")]
    public DefinePlayer define;

    [Header("Player Name")]
    public TextMeshPro playerName;

    [Header("Character Prefabs")]
    public GameObject playerPrefab;
    public GameObject jessPrefab;
    public GameObject rosePrefab;

    [Header("Spawn points")]
    public float minX, maxX;
    public float uniqueY;
    public float minZ, maxZ;
    // Start is called before the first frame update


    void Start()
    {
        define = GameObject.Find("DefinePlayer").GetComponent<DefinePlayer>();


        if (define.playerType == 1)
        {
            playerPrefab = jessPrefab;

        } else if(define.playerType == 2)
        {
            playerPrefab = rosePrefab;
        }

        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), uniqueY, Random.Range(minZ, maxZ));
        PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
        playerName = GameObject.Find("playerName").GetComponent<TextMeshPro>();
        playerName.text = define.playerName;


    }

}
