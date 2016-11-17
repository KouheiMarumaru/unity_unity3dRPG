using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	Animator anim;
	//Animator型のanimという変数を定義しています。
	//これは、後にPlayerControlllerに設定されているAnimatorコンポーネントを取得する為

	GameObject sword;
	SphereCollider swordCollider;
	//剣のSphere Colliderコンポーネントを入れる為に、
	//Sphere Collider型でswordColliderという変数を定義しています。


	void Start () {
		anim = GetComponent<Animator> ();
		//GetComponent<Animator>();でアタッチされているオブジェクト、
		//つまり「Player」のAnimatorコンポーネントを取得して、animという変数に代入

		sword = GameObject.Find ("cutter01");
		print (sword.transform.tag);
		//Findメソッドで「cutter01」つまり剣のオブジェクトを取得して、7行目で定義したsword変数に入れています。

		swordCollider = sword.GetComponent<SphereCollider> ();
							//剣についているSphereColliderコンポーネントを取得

//		swordCollider.enabled = false;
		//enabledプロパティ コンポーネントに対して使えるメソッド
		//enabledをfalseにする事でそのコンポーネントを非アクティブにする事ができます。

		IsAttackingToFalse ();
		//「IsAttackingToFalse」というメソッドを呼び出しています。
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {

			Invoke ("IsAttackingToTrue", 0.5f);

			anim.SetTrigger ("Attack");
				//SetTriggerメソッドは、以下のように記述することで
				//Animatorに設定されているTriggerをONにする事ができます
				//Animator.SetTrigger("パラメーター名");

			Invoke ("IsAttackingToFalse", 0.8f);
			//第一引数で指定したメソッドを、第二引数で指定した秒数後に実行させるメソッドです。
			//Invoke("実行したいメソッド名", 何秒後に実行するか);
			//IsAttackingToFalseメソッドを0.8秒後に呼び出す
		}
	}

	void IsAttackingToFalse() {
		swordCollider.enabled = false;
	}

	void IsAttackingToTrue() {
		swordCollider.enabled = true;
	}
}