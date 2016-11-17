using UnityEngine;
using System.Collections;

public class ItemController : MonoBehaviour {

	//その瞬間だけ必要な情報

	public Item.ItemType itemType;
	     //ItemクラスのItemTypeを型として宣言

//	Inventory inventory = new Inventory();
	//Inventory型のinventoryという変数を定義
	//その変数にnew Inventory();としてInventoryクラスのインスタンスを代入
	//inventory変数を呼び出せば、Inventoryクラスのメソッドが使えるようになります。

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other) {
		if(other.name == "Player") {
			GameManager.instance.inventory.AddItem (itemType);
			//InventoryクラスのAddItemメソッドを呼び出しています。

			Destroy (gameObject);
			GameObject effectObj = gameObject.transform.parent.Find ("ItemEffect(Clone)").gameObject; 
								 //↑gameObject アタッチされているオブジェクト自身の事なので、今回の場合ItemPivotを指します
			//FindメソッドはHierarchy上のオブジェクトを名前で検索する事ができます。

			Destroy (effectObj);
		}
	}
}