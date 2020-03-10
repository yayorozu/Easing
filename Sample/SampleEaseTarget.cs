using UnityEngine;
using UniLib;
using UniLib.Easing;

[ExecuteInEditMode]
public class SampleEaseTarget : MonoBehaviour
{
	public EaseType type = EaseType.Linear;

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.blue;
		var vect = Vector3.zero;
		var cache = Vector3.zero;
		var beginX = transform.position.x;
		var beginY = transform.position.y;
		cache.x = beginX;
		cache.y = beginY;
		var height = 0.5f;
		var total = 1f;
		for (var t = 0.01f; t <= 1.01f;)
		{
			var calc = Ease.Eval(type, t, total, beginY, beginY + height);
			vect.x = t + beginX;
			vect.y = calc;
			Gizmos.DrawLine(cache, vect);
			cache = vect;
			t += 0.01f;
		}

		UnityEditor.Handles.Label(transform.position, type.ToString());
		Gizmos.color = Color.black;
		cache = transform.position;
		cache.x += 1f;
		Gizmos.DrawLine(transform.position, cache);
		cache = transform.position;
		cache.y += height;
		Gizmos.DrawLine(transform.position, cache);
		vect = transform.position;
		vect.x += 1f;
		cache = transform.position;
		cache.x += 1f;
		cache.y += height;
		Gizmos.DrawLine(vect, cache);
		vect = transform.position;
		vect.y += height;
		cache = transform.position;
		cache.x += 1f;
		cache.y += height;
		Gizmos.DrawLine(vect, cache);
	}
}