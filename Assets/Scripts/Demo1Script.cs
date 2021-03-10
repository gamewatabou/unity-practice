using UnityEngine;
using System.Collections;

public class Demo1Script : MonoBehaviour
{
	// 生成したいPrefab
	public GameObject Prefab;

	// クリックした位置座標
	private Vector3 clickPosition;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			clickPosition = Input.mousePosition;
			clickPosition.z = 10f;
			Instantiate(Prefab, Camera.main.ScreenToWorldPoint(clickPosition), Prefab.transform.rotation);
		}
	}
}