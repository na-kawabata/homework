using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupController : MonoBehaviour {

	public void TapClose()
    {
        Destroy(this.gameObject);
    }
}
