using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIActions : MonoBehaviour
{
    private AIData _data;

    private NavMeshAgent _navAgent;
    private NavMeshHit _navHit;

    void Start()
    {
        _data = GetComponent<AIData>();
    }

    void Update()
    {

    }

    public bool MoveTo(GameObject target)
    {
        if (target == null)
        {
            Vector3 location;
            if (TestLocation(target.transform.position, out location))
            {
                _navAgent.destination = location;
                return true;
            }
        }
        return false;
    }

    private bool TestLocation(Vector3 testLocation, out Vector3 location)
    {
        if (NavMesh.SamplePosition(testLocation, out _navHit, Vector3.Distance(transform.position, testLocation), _data.GetAILayerMask()))
        {
            location = _navHit.position;
            return true;
        }

        location = Vector3.zero;
        return false;
    }
}
