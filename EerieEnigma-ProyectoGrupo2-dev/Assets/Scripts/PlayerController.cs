using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	HealthController _healthController;

	[SerializeField]
	int _danio;

	private void Start()
	{
		_healthController = GetComponent<HealthController>();
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Enemy") 
		{
			_healthController.TakeDamage(_danio);
		}
	}



}
