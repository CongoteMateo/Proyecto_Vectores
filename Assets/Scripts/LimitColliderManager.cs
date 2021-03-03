using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitColliderManager : MonoBehaviour
{
    Rigidbody rb = null;
    [SerializeField] ScoreManager scoremanager = null;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Ground")
        {
        Destroy(other.gameObject);
        scoremanager.CalculateScore();
        }
    }


}
