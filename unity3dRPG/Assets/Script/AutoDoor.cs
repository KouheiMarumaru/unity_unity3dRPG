using UnityEngine;
using System.Collections;

public class AutoDoor : MonoBehaviour {
	
	//Animator型でanimという変数を定義
	//「Door」のAnimationコンポーネントを入れる為、Animation型で定義
	Animator anim;

	//Inventoryクラスのメソッドを使えるようにする為、
	//Inventoryクラスのインスタンスを生成して
	//inventoryという変数に入れています。

	public bool conditionNeedItem = false;

	void Start () {
		//定義した変数animに、GetComponentメソッドで取得したAnimatorコンポーネントを代入
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider other) {
		if (other.name == "Player") {
			if (conditionNeedItem == false) {
				anim.SetBool ("IsOpen", true);
				//conditionNeedItemがfalseの時は無条件で扉開く
			} else {
				if (GameManager.instance.inventory.HasItem ()) {
					//そうでない時(conditionNeedItemがtrueの時)は、
					//さらにif文でアイテムを持っているかどうかをチェックしています。

					//アイテムを持ってる時だけ実行

					//Inventoryクラスに定義した,
					//Bool型のHasItemメソッドを呼んでいます。
				
					//ぶつかってきたオブジェクトが「Player」だった時の条件式の中に処理を記述しています。
					//DoorのAnimatorコンポーネントが入っている変数animに対して、SetBoolメソッドを使用しています。
					anim.SetBool ("IsOpen", true);
					//SetBool()メソッド
					//Animatorクラスのメソッドで、Bool型の条件を操作する事ができます。
					//SetBool("条件名", 真偽);
				}
			}
		}
	}

	//OnTriggerExit()メソッドとは、オブジェクトがコライダーに触れる事をやめた時に呼ばれるメソッドです。
	void OnTriggerExit(Collider other) {
		if (other.name == "Player") {
			anim.SetBool ("IsOpen", false);
			//「IsOpen」がfalseになると、「Close」アニメーションが呼ばれる設定をしているので、
			//この記述で、「Close」アニメーションが呼ばれるようになりました。
		}
	}
}