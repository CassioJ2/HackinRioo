using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;


public class CreateAndJoinRooms : MonoBehaviour
{
    public InputField createInput;
    public InputField joinInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createInput.text);
    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");

    }


    // Update is called once per frame
    void Update()
    {
        
    }


}
