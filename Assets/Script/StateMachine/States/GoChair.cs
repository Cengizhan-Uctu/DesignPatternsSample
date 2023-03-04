using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoChair : BaseState
{
    private NavMeshAgent agent;
    private Transform thisTrasform;
    public GoChair(CustomerAISM stateMachine) : base("GoChair", stateMachine) { agent = stateMachine.navmashAgent; thisTrasform = stateMachine.transform; }
    public override void UpdateLogic()
    {
        base.UpdateLogic();
       
        if (agent && ((CustomerAISM)stateMachine).target)
        {
            agent.SetDestination(((CustomerAISM)stateMachine).target.position);
            if (Vector3.Distance(((CustomerAISM)stateMachine).hand.position, ((CustomerAISM)stateMachine).target.position) < 2)
            {
               
                agent.speed = 0;
                stateMachine.ChangeState(((CustomerAISM)stateMachine).listener);// dinleme yanigelen rakamları kontrol etme statesi ekle
            }
        }
    }


}
