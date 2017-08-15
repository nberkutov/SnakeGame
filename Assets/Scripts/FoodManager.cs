using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour {

    public Vector3 minBorder;
    public Vector3 maxBorder;

    public GameObject foodPrefab;

	public void SpawnFood()
    {
        Vector3 pos = new Vector3(Random.Range(minBorder.x, maxBorder.x), -1f, Random.Range(minBorder.z, maxBorder.z));
        GameObject food = Instantiate(foodPrefab, pos, Quaternion.identity);
        StartCoroutine(Animate(food));
    }

    private IEnumerator Animate(GameObject obj)
    {
        Vector3 pos = obj.transform.position;
        while (pos.y < 0.1f && obj != null)
        {
            pos.y += 2f * Time.deltaTime;
            pos.y = Mathf.Clamp(pos.y, -1f, 0f);
            obj.transform.position = pos;
            yield return new WaitForEndOfFrame();
        }
        yield return null;
    } 
}
