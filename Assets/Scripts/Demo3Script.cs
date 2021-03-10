using UnityEngine;
using System.Collections;

public class Demo3Script : MonoBehaviour
{
	// 生成したいPrefab
	public GameObject Prefab;

	// クリックした位置座標
	private Vector3 clickPosition;

	// 複製したプレハブ
	private GameObject CopyBall;

	// 複製したプレハブの重力制御用
	private Rigidbody rBody;

	// クリック中かの判断
	private bool buttonDownFlag = false;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (buttonDownFlag)
		{
			clickPosition = Input.mousePosition;
			clickPosition.z = 10f;
			CopyBall.transform.position = Camera.main.ScreenToWorldPoint(clickPosition);
		}

		if (Input.GetMouseButtonDown(0))
		{
			clickPosition = Input.mousePosition;
			clickPosition.z = 10f;
			CopyBall = Instantiate(Prefab, Camera.main.ScreenToWorldPoint(clickPosition), Prefab.transform.rotation);

			buttonDownFlag = true;
		}

		if (Input.GetMouseButtonUp(0))
		{
			rBody = CopyBall.GetComponent<Rigidbody>();
			rBody.useGravity = true;

			buttonDownFlag = false;
		}
	}
}