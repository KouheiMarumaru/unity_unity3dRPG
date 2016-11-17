using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour{
			//・「あるアイテムを取得した時にイベントリに追加する」
			//・「あるアイテムを所持しているかどうか」
			//といった情報を扱います
	//イベント　ずっと持っていたい情報

	List<int> itemList = new List<int>();
	//配列作成　のちに増やせる、減らせる

	public void AddItem(Item.ItemType type) {
    //アイテムを配列に保存
	//今後、アイテムの取得をした時は、
   //InventoryクラスのAddItemメソッドを呼ぶようにします。

		itemList.Add ((int)type);
	}

	public bool HasItem() {
		//Bool型(trueかfalse)を返すメソッドとして定義
		print (itemList.Count);

		if (itemList.Count >= 1) {
			//ListクラスのCountメソッドは、
			//そのリストの数を取得する事ができます。
			return true;
		} else {
			return false;
		}
	}
}