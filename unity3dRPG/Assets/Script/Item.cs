using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
	//アイテムそのものの情報

	public enum ItemType {
		KeyBronze = 0,
		KeySilver = 1,
		KeyGold = 2
	}

	//文法
	//	enum 型名 {
	//		メンバ名1 = 値1,
	//		メンバ名2 = 値2,
	//		メンバ名3 = 値3
	//	}
	//複数のアイテムや敵をID番号で管理します。
	//しかし、IDだけで管理をすると0番が何色の鍵で1番が何色の鍵なのか、分からなくなってしまいます。
	//その為、列挙型のEnumを用いて、それぞれの鍵に分かりやすい名前を付けてあげます。
}