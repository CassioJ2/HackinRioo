using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Photon.Pun;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Camera playerCam;
    public LayerMask layer;

    PhotonView view;

    public Animator anim;
    
    public NavMeshAgent player;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        playerCam = Camera.main;
        player = GetComponent<NavMeshAgent>();
        view = GetComponent<PhotonView>();

    }

    // Update is called once per frame
    void Update()
    {
        CheckWorldPosition();
        AnimPlayer();

    }

    public void AnimPlayer()
    {
        if(player.hasPath) {
            {
                anim.SetBool("isMoving", true);
            }
        }
        else
        {
            anim.SetBool("isMoving", false);
        }
    }

    private void CheckWorldPosition()
    {
        if (view.IsMine)
        {
            Ray ray = playerCam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit raycastHit, 20f, layerMask: layer))
            {
                if (Input.GetMouseButton(0))
                {
                    player.SetDestination(raycastHit.point);
                }
            }
        }
        

    }

}
