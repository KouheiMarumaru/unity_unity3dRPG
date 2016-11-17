using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	//GameManager型のinstanceという変数を定義
	//GameManager自身のインスタンスを代入する為、GameManager型で定義

	//staticで定義された物はクラス自体に属するようになります。


	public Inventory inventory;

	// Use this for initialization
	void Start () {
		if (instance == null) {
			instance = this;
			//instanceの中身が空っぽの時、
			//GameManagerクラスのインスタンスを代入する」
		}

		DontDestroyOnLoad (this);
		//DontDestroyOnLoadの引数に渡したオブジェクトは、
		//シーンが変わってもオブジェクトが破棄されません。

		//this そのクラスのインスタンスの事
	}
}