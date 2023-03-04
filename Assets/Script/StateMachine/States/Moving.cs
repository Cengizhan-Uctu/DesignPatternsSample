using UnityEngine.AI;
using UnityEngine;
public class Moving : BaseState
{
    private NavMeshAgent agent;
 
    private Transform thisTrasform;
    public Moving(CustomerAISM stateMachine) : base("Moving", stateMachine)
    {
        agent = stateMachine.navmashAgent;
      
        thisTrasform = stateMachine.transform;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        if (agent && ((CustomerAISM)stateMachine).target)
        {
            agent.SetDestination(((CustomerAISM)stateMachine).target.position);
            if (Vector3.Distance(thisTrasform.position, ((CustomerAISM)stateMachine).target.position) < 3)
            {
               
                agent.speed = 0;
                stateMachine.ChangeState(((CustomerAISM)stateMachine).takeCard);
            }
        }

    }
}
