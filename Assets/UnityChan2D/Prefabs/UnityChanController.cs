﻿using UnityEngine;
using System.Collections;

public class UnityChanController : MonoBehaviour {
	//アニメーションするためのコンポーネントを入れる
	Animator animator;
	// 地面の位置
	private float groundLevel = -3.0f;

	// Use this for initialization
	void Start () {
		// アニメータのコンポーネントを取得する
		this.animator = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		// 走るアニメーションを再生するために、Animatorのパラメータを調節する
		this.animator.SetFloat("Horizontal", 1);

		// 着地しているかどうかを調べる
		bool isGround = (transform.position.y > this.groundLevel) ? false : true;
		this.animator.SetBool ("isGround", isGround);
	}
}