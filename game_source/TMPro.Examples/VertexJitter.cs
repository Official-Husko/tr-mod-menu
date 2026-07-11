using System;
using System.Collections;
using UnityEngine;

namespace TMPro.Examples;

public class VertexJitter : MonoBehaviour
{
	private struct VertexAnim
	{
		public float angleRange;

		public float angle;

		public float speed;
	}

	public float AngleMultiplier = 1f;

	public float SpeedMultiplier = 1f;

	public float CurveScale = 1f;

	private TMP_Text m_TextComponent;

	private bool hasTextChanged;

	private void Awake()
	{
		m_TextComponent = ((Component)this).GetComponent<TMP_Text>();
	}

	private void OnEnable()
	{
		TMPro_EventManager.TEXT_CHANGED_EVENT.Add((Action<Object>)ON_TEXT_CHANGED);
	}

	private void OnDisable()
	{
		TMPro_EventManager.TEXT_CHANGED_EVENT.Remove((Action<Object>)ON_TEXT_CHANGED);
	}

	private void Start()
	{
		((MonoBehaviour)this).StartCoroutine(AnimateVertexColors());
	}

	private void ON_TEXT_CHANGED(Object obj)
	{
		if (obj == (Object)(object)m_TextComponent)
		{
			hasTextChanged = true;
		}
	}

	private IEnumerator AnimateVertexColors()
	{
		m_TextComponent.ForceMeshUpdate(false, false);
		TMP_TextInfo textInfo = m_TextComponent.textInfo;
		int loopCount = 0;
		hasTextChanged = true;
		VertexAnim[] vertexAnim = new VertexAnim[1024];
		for (int i = 0; i < 1024; i++)
		{
			vertexAnim[i].angleRange = Random.Range(10f, 25f);
			vertexAnim[i].speed = Random.Range(1f, 3f);
		}
		TMP_MeshInfo[] cachedMeshInfo = textInfo.CopyMeshInfoVertexData();
		while (true)
		{
			if (hasTextChanged)
			{
				cachedMeshInfo = textInfo.CopyMeshInfoVertexData();
				hasTextChanged = false;
			}
			int characterCount = textInfo.characterCount;
			if (characterCount == 0)
			{
				yield return CommonReferences.wait025;
				continue;
			}
			Matrix4x4 val = Matrix4x4.TRS(new Vector3(Random.Range(-0.05f, 0.05f), Random.Range(-0.15f, 0.15f), 0f) * CurveScale, Quaternion.Euler(0f, 0f, 0f * AngleMultiplier), Vector3.one);
			for (int j = 0; j < characterCount - 4; j++)
			{
				if (textInfo.characterInfo[j].isVisible)
				{
					VertexAnim vertexAnim2 = vertexAnim[j];
					int materialReferenceIndex = textInfo.characterInfo[j].materialReferenceIndex;
					int vertexIndex = textInfo.characterInfo[j].vertexIndex;
					Vector3[] vertices = cachedMeshInfo[materialReferenceIndex].vertices;
					Vector3 val2 = Vector2.op_Implicit(Vector2.op_Implicit((vertices[vertexIndex] + vertices[vertexIndex + 2]) / 2f));
					Vector3[] vertices2 = textInfo.meshInfo[materialReferenceIndex].vertices;
					vertices2[vertexIndex] = vertices[vertexIndex] - val2;
					vertices2[vertexIndex + 1] = vertices[vertexIndex + 1] - val2;
					vertices2[vertexIndex + 2] = vertices[vertexIndex + 2] - val2;
					vertices2[vertexIndex + 3] = vertices[vertexIndex + 3] - val2;
					vertices2[vertexIndex] = ((Matrix4x4)(ref val)).MultiplyPoint3x4(vertices2[vertexIndex]);
					vertices2[vertexIndex + 1] = ((Matrix4x4)(ref val)).MultiplyPoint3x4(vertices2[vertexIndex + 1]);
					vertices2[vertexIndex + 2] = ((Matrix4x4)(ref val)).MultiplyPoint3x4(vertices2[vertexIndex + 2]);
					vertices2[vertexIndex + 3] = ((Matrix4x4)(ref val)).MultiplyPoint3x4(vertices2[vertexIndex + 3]);
					ref Vector3 reference = ref vertices2[vertexIndex];
					reference += val2;
					ref Vector3 reference2 = ref vertices2[vertexIndex + 1];
					reference2 += val2;
					ref Vector3 reference3 = ref vertices2[vertexIndex + 2];
					reference3 += val2;
					ref Vector3 reference4 = ref vertices2[vertexIndex + 3];
					reference4 += val2;
					vertexAnim[j] = vertexAnim2;
				}
			}
			for (int k = 0; k < textInfo.meshInfo.Length; k++)
			{
				textInfo.meshInfo[k].mesh.vertices = textInfo.meshInfo[k].vertices;
				m_TextComponent.UpdateGeometry(textInfo.meshInfo[k].mesh, k);
			}
			loopCount++;
			yield return CommonReferences.wait01;
		}
	}
}
