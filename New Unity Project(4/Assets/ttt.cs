using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ttt : MonoBehaviour
{
    [SerializeField]
    private Transform _Ghos;

    [SerializeField]
    private Transform _A1;

    [SerializeField]
    private Transform _A2;

    [SerializeField]
    private Transform _Ghos2;

    [SerializeField]
    private GameObject _Ghose2;

    private void Update()
    {


        var i = 1;
        while (i < 3)
        {
            if (i % 2 == 0)
            {
                _Ghos.position = Vector3.MoveTowards(_Ghos.position, _A1.position, 5 * Time.deltaTime);
                _Ghos2.position = Vector3.MoveTowards(_Ghos2.position, _A2.position, 5 * Time.deltaTime);
                _Ghose2.SetActive(false);

                i++;
            }
        }
    }
}