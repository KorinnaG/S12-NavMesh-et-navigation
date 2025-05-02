using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentBase : MonoBehaviour
{

    NavMeshAgent _agent;
    [SerializeField] public GameObject _joueur;
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        _agent.SetDestination(_joueur.transform.position);
    }
}
