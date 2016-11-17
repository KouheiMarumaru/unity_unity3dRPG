using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//スクリプトでUIを扱う為にはusing UnityEngine.UI;を記述する必要があります。

public class EnemyController : MonoBehaviour {
	Animation anim;
	//Animation型のanimという変数を定義しています。
	//後に、敵のAnimationを取得してanim変数にいれる為

	BoxCollider boxCollider;
	//Box Collider型でboxColliderという変数を定義しています。
	//これは、後に取得するBox Colliderコンポーネントを入れるためです。

	public int hp = 100;
	//Inspectorで値を設定できるようにする為には、publicな変数に。

	public Image hpGauge;
	//publicでImage型のオブジェクトを、Inspectorビューから設定できるようにしています。

	int fullHp;
	//int型でfullHpという変数を定義
	//Inspectorビューで設定しているHPの数値を代入します

	int attackPower;

	GameObject hpObj;
	//Hierarchyビュー上にあるHPゲームオブジェクトを取得します。
	//その為、GameObject型のhpObjという変数を定義しています。


	Rigidbody rigid;

	void Start () {
		anim = GetComponent<Animation> ();
		//アタッチしている敵のAnimationコンポーネントを取得して、anim変数に入れています。

		boxCollider = GetComponent<BoxCollider> ();

		hpObj = transform.Find ("HP").gameObject;
		//Transform.Findが記述されているスクリプトがアタッチされているオブジェクトの子オブジェクトのみを検索対象として、オブジェクトを検索


		fullHp = hp;


	}

	// Update is called once per frame
	void Update () {

	}

	//オブジェクト同士の衝突を判定するメソッド
	void OnTriggerEnter(Collider other) {
		if (other.name == "cutter01") {

//			hp -= 50;
			//hp = hp - 50

			attackPower = other.GetComponent<Weapon> ().power;
						//other.GetComponent<Weapon> ()で、
						//剣に付いている「Weaponコンポーネント」を取得
			//剣についている「Weaponコンポーネント」のpowerの値を取得して、
			//変数attackPowerに入れるという意味です。

			hp -= attackPower;

			hpGauge.fillAmount = (float)hp / fullHp;
			//hpGauge.fillAmount アタッチされた「hp_gauge」の、fillAmountの事を指しています。
			//

			print (hp);
			if (hp <= 0) {
				anim.Play ("Allosaurus_Die");

				Destroy (boxCollider);

				//boxColliderをDestroyメソッドで、削除する

				Destroy (hpObj);
			}
		}
	}
}