using System.Collections;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public void TakeCoin()
    {
        StartCoroutine(CoinPick());
    }

    public IEnumerator CoinPick()
    {
        yield return new WaitForEndOfFrame();
    }
}
