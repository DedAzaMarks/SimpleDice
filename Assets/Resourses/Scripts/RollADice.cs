using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RollADice : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject dice;
	Rigidbody rb;

    private void Start()
    {
		rb = dice.GetComponent<Rigidbody>();
    }

    public void Click()
    {
		ResetScript.Reset();
		float dirX = Random.Range(-500, 500);
		float dirY = Random.Range(-500, 500);
		float dirZ = Random.Range(-500, 500);
		dice.transform.position = new Vector3(0, 5, 0);
		dice.transform.rotation = Quaternion.identity;
		rb.AddForce(new Vector3(dirX, dirY, dirZ));
		rb.AddTorque(dirX, dirY, dirZ);
	}
}
