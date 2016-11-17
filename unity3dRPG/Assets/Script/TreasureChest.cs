using UnityEngine;
using System.Collections;

public class TreasureChest : MonoBehaviour {

	Animator anim;
	bool isOpen = false;
	//Animator型でanimという変数を定義しています。
	//あとで、「Door」のAnimationコンポーネントを入れる為、Animation型で定義をしています
	//tureかfalseを入れる為の変数isOpenをbool型で定義

	void Start () {
		anim = GetComponent<Animator> ();
		//先程定義した変数animに、GetComponentメソッドで取得したAnimatorコンポーネントを代入。
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		if(other.name == "Player" && isOpen == false) {
			anim.SetBool ("IsOpen", true);
			//SetBoolはAnimatorクラスのメソッドで、Bool型の条件を操作する事ができました。
			//引数は2つあり、第一引数に条件名、第二引数に真偽（true or false）を取ります。
			GameObject effectObj = Resources.Load<GameObject> ("Effects/ItemEffect");
			//ItemEffectプレハブを呼び出しています。
			//呼び出したプレハブをGameObject型の変数effectObjに代入

			//Resources.Loadメソッド
			//Projectビューにある「Resources」フォルダ内にあるプレハブを呼び出す事ができる
			//Resources.Load<呼び出すオブジェクトの型>("オブジェクトまでのパス");

			GameObject effect = (GameObject)Instantiate(effectObj, gameObject.transform.position, effectObj.transform.rotation);
			//(effectObj, gameObject.transform.position, effectObj.transform.rotation)の型がGameObject型ではないため設定する必要がある。
			//じゃないと変数に入らない
			GameObject effect2 = Instantiate(effectObj);


			effect.transform.parent = gameObject.transform; 
			//ヒエラルキー内部での位置を示す

			//Instantiate(effectObj, gameObject.transform.position, effectObj.transform.rotation);
			//instatiate(複製したいオブジェクト, 位置, 回転);
			//instatiate...オブジェクトを複製
			//ここで言うgameObjectとは、アタッチされているオブジェクト自身を意味
			//第二引数には「TreasureChest」自身の位置の情報を付与しているという意味

			//Instantiateで生成されたオブジェクトの型をGameObject型に変換する
			//手動での簡略化するため

			isOpen = true;
		}
	}

}