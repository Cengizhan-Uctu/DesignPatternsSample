using System.Collections;
using UnityEngine;
using ObjectPooling;

public class CustomerSpawner : MonoBehaviour
{
    [SerializeField] Transform customerTarget;
    private int counter; 
    private void Start()
    {
        StartCoroutine(Spawner());
    }
    IEnumerator  Spawner()
    {
        while (counter<5)
        {
            yield return new WaitForSeconds(1);
            var customer = ObjectPooler.instance.SpawnFromPool("Customer", Vector3.zero, Quaternion.identity);
            customer.GetComponent<CustomerAISM>().target = customerTarget;
            counter++;
        }
        yield break;
    }
}
