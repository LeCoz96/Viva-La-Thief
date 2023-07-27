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

    public bool MoveTo(GameObject target)
    {
        if (target == null)
        {
            Vector2 location;
            if (TestLocation(target.transform.position, out location))
            {
                _navAgent.destination = location;
                return true;
            }
        }
        return false;
    }

    private bool TestLocation(Vector2 testLocation, out Vector2 location)
    {
        if (NavMesh.SamplePosition(testLocation, out _navHit, Vector2.Distance(transform.position, testLocation), _data.GetAILayerMask()))
        {
            location = _navHit.position;
            return true;
        }

        location = Vector2.zero;
        return false;
    }
}
