using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointPatrol : MonoBehaviour
{
    [SerializeField]
    private Transform _Ghos;

    [SerializeField]
    private Transform _A1;

    private void Update()
    {
        _Ghos.position = Vector3.MoveTowards(_Ghos.position, _A1.position, 1 * Time.deltaTime);
    }
}