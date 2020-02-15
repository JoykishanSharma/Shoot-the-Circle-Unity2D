using System;
using UnityEngine;

namespace Script
{
	public class Pin : MonoBehaviour
	{
		// Start is called before the first frame update
		private bool _isPinned = false;

		public float speed = 20f;
		public Rigidbody2D rb;

		// Update is called once per frame
		void Update()
		{
			if (!_isPinned)
				rb.MovePosition(rb.position + Vector2.up * (speed * Time.deltaTime));
		}

		void OnTriggerEnter2D(Collider2D col)
		{
			if (col.tag == "TBlock" && col.gameObject.layer == LayerMask.NameToLayer("Shootable"))
			{
				transform.SetPositionAndRotation(transform.position, transform.rotation);
				Score.PinCount++;
				_isPinned = true;
				Debug.Log("Pinned in Block");
			}
			else if (col.tag == "Pin")
			{
				FindObjectOfType<GameManager>().EndGame();
			}
			else if (col.tag == "Rotator")
			{
				//transform.SetParent(col.transform);
				
				//_isPinned = true;
			}
		}
	}
}
