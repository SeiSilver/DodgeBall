using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

    public GameObject CreditUI;

    public void openCredit () {
        CreditUI.SetActive (true);
    }

    public void closeCredit () {
        CreditUI.SetActive (false);
    }
}