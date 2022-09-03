using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    public LayerMask layer;
    
    public NavMeshAgent player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckWorldPosition();
    }

    private void CheckWorldPosition()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit raycastHit, 20f, layerMask: layer))
        {
            if (Input.GetMouseButton(0))
            {
                player.SetDestination(raycastHit.point);
            }
        }

    }

}
