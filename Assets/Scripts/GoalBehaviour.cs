using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoalBehaviour : MonoBehaviour
{
    private IEnumerator OnTriggerEnter(Collider other)
    {
        other.GetComponent<Rigidbody>().AddForce(0,1000,0);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
}