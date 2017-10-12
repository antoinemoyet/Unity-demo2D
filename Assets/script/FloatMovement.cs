using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatMovement : MonoBehaviour {

		public float amplitude = 1f;
		public float speed = 1f;

		private float startPosY;
		private Vector3 newPos;

		// Use this for initialization
		void Start () {
			startPosY = transform.position.y;
		}

		// Update is called once per frame
		void Update () {
			newPos.y = startPosY + amplitude * Mathf.Sin (speed * Time.time);
			newPos.x = transform.position.x;

			transform.position = newPos;
		}
	}
