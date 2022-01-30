using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CollideCheck
{
	/**
	 * CollideCheck
	 */
	[RequireComponent(typeof(Rigidbody))]

	public class CollideCheck : MonoBehaviour
	{

		private Transform playerTrans;
		private float DIFF = 0.2f;
		private Rigidbody rd;


		// Use this for initialization
		void Start()
		{
			playerTrans = this.transform;
			rd = this.GetComponent<Rigidbody>();
			rd.useGravity = false;
		}

		// FixedUpdate is called once per frame
		void FixedUpdate() {
			move();
		}

		/**
		 * 矢印キーで動かす関数(テスト用)
		 * Function to move with arrow keys(for test)
		 */
		private void move()
		{
			if (Input.GetKey(KeyCode.UpArrow))
			{
				playerTrans.Translate(Vector3.forward * DIFF);
			}
			else if (Input.GetKey(KeyCode.RightArrow))
			{
				playerTrans.Translate(Vector3.right * DIFF);
			}
			else if (Input.GetKey(KeyCode.LeftArrow))
			{
				playerTrans.Translate(Vector3.left * DIFF);
			}
			else if (Input.GetKey(KeyCode.DownArrow))
			{
				playerTrans.Translate(Vector3.back * DIFF);
			}
		}



		/* オブジェクト同士の衝突判定 */
		/* Collision detection between objects */

		// オブジェクトが衝突したとき
		// When objects collide
		void OnCollisionEnter(Collision collision)
		{
			Debug.Log("Collision Enter: " + collision.gameObject.name);
		}

		// オブジェクトが離れた時
		// When the object leaves
		void OnCollisionExit(Collision collision)
		{
			Debug.Log("Collision Exit: " + collision.gameObject.name);
		}

		// オブジェクトが触れている間
		// While the object is touching
		void OnCollisionStay(Collision collision)
		{
			Debug.Log("Collision Stay: " + collision.gameObject.name);
		}

	}
}
