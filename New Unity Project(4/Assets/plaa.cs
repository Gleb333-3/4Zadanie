using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class plaa : MonoBehaviour
{
    private NavMeshAgent _NavMe;

    // Update is called once per frame
    private void Awake()
    {
        _NavMe = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out var hit, 100))
            {
                _NavMe.destination = hit.point;
            }
        }
    }
}