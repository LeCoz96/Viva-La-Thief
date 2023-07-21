using UnityEngine;

public class GoTo : Node
{
    private EnemyAI _ai;
    private AIActions _actions;
    private GameObject _target;

    public GoTo(EnemyAI ai, AIActions actions, GameObject target)
    {
        _ai = ai;
        _actions = actions;
        _target = target;
    }

    public override NodeState Decision()
    {
        if (_target != null)
        {
            float distance = Vector3.Distance(_target.transform.position, _ai.transform.position);

            return NodeState.SUCCESS;

        }
        else
        {
            return NodeState.FAILURE;
        }
    }
}
