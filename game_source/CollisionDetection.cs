using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class OAFCPMCHCGO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CollisionDetection _003C_003E4__this;

		public float amplitudeMultiplier;

		public float x;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public OAFCPMCHCGO(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CollisionDetection collisionDetection = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				collisionDetection.currentAmplitude = collisionDetection.amplitude;
				if ((Object)(object)collisionDetection.herb != (Object)null && collisionDetection.herb.frozen && collisionDetection.herb.IsFrozen())
				{
					collisionDetection.herb.ChangeToUnfrozenSprites();
					Object.Instantiate<GameObject>(collisionDetection.snowParticlesPrefab, ((Component)collisionDetection).transform.position + Vector3.up * 0.25f, Quaternion.identity, ((Component)collisionDetection).transform.parent);
				}
				if ((Object)(object)collisionDetection.snowHerb != (Object)null && collisionDetection.snowHerb.herbIsFrozen)
				{
					collisionDetection.snowHerb.UnfrozenHerb();
					Object.Instantiate<GameObject>(collisionDetection.snowParticlesPrefab, ((Component)collisionDetection).transform.position + Vector3.up * 0.25f, Quaternion.identity, ((Component)collisionDetection).transform.parent);
				}
				if (SeasonManager.EECEKHKAAIH == Season.Winter && collisionDetection.spriteRenderers != null)
				{
					for (int i = 0; i < collisionDetection.spriteRenderers.Length; i++)
					{
						if (Object.op_Implicit((Object)(object)collisionDetection.spriteRenderers[i]))
						{
							((Renderer)collisionDetection.spriteRenderers[i]).material.SetFloat(ShaderReferences.noiseMultiplier, 0.05f);
						}
					}
				}
				goto IL_043e;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0191;
			case 2:
				{
					_003C_003E1__state = -1;
					goto IL_043e;
				}
				IL_043e:
				if (collisionDetection.currentAmplitude > 0.01f)
				{
					if (Object.op_Implicit((Object)(object)collisionDetection.HKIODKOAHPE))
					{
						if ((Object)(object)WorldTime.GetInstance() == (Object)null)
						{
							_003C_003E2__current = null;
							_003C_003E1__state = 1;
							return true;
						}
						goto IL_0191;
					}
					goto IL_0427;
				}
				if (SeasonManager.EECEKHKAAIH == Season.Winter && collisionDetection.spriteRenderers != null)
				{
					for (int j = 0; j < collisionDetection.spriteRenderers.Length; j++)
					{
						if (Object.op_Implicit((Object)(object)collisionDetection.spriteRenderers[j]))
						{
							((Renderer)collisionDetection.spriteRenderers[j]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
						}
					}
				}
				collisionDetection.LDKHPOBCNFC = null;
				if ((Object)(object)collisionDetection.cropSetter != (Object)null)
				{
					if (collisionDetection.spriteRenderers != null)
					{
						for (int k = 0; k < collisionDetection.spriteRenderers.Length; k++)
						{
							if (Object.op_Implicit((Object)(object)collisionDetection.spriteRenderers[k]))
							{
								((Renderer)collisionDetection.spriteRenderers[k]).sharedMaterial = collisionDetection.cropSetter.GetCurrentMaterial(collisionDetection.cropSetter.materialIndex);
							}
						}
					}
				}
				else if (collisionDetection.spriteRenderers != null)
				{
					for (int l = 0; l < collisionDetection.spriteRenderers.Length; l++)
					{
						if (Object.op_Implicit((Object)(object)collisionDetection.spriteRenderers[l]))
						{
							((Renderer)collisionDetection.spriteRenderers[l]).sharedMaterial = collisionDetection.HKIODKOAHPE;
						}
					}
				}
				return false;
				IL_0191:
				if (SeasonManager.EECEKHKAAIH == Season.Winter && collisionDetection.currentAmplitude < collisionDetection.amplitude / 6f && collisionDetection.spriteRenderers != null)
				{
					for (int m = 0; m < collisionDetection.spriteRenderers.Length; m++)
					{
						if (Object.op_Implicit((Object)(object)collisionDetection.spriteRenderers[m]))
						{
							((Renderer)collisionDetection.spriteRenderers[m]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(0f, 0.05f, collisionDetection.currentAmplitude / (collisionDetection.amplitude / 6f)));
						}
					}
				}
				collisionDetection.theta = (Time.timeSinceLevelLoad - collisionDetection.startTime) / (collisionDetection.period * amplitudeMultiplier);
				collisionDetection.movement = collisionDetection.currentAmplitude * Mathf.Sin(collisionDetection.theta);
				if (x > 0f)
				{
					collisionDetection.movement *= -1f;
				}
				if (collisionDetection.spriteRenderers != null)
				{
					for (int n = 0; n < collisionDetection.spriteRenderers.Length; n++)
					{
						if (Object.op_Implicit((Object)(object)collisionDetection.spriteRenderers[n]))
						{
							((Renderer)collisionDetection.spriteRenderers[n]).material.SetFloat(ShaderReferences.swishEffect, collisionDetection.movement + collisionDetection.HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
						}
					}
				}
				if ((Object)(object)collisionDetection.cropSetter != (Object)null)
				{
					if (Object.op_Implicit((Object)(object)collisionDetection.cropSetter.spriteRenderers[collisionDetection.cropSetter.growable.FKDFFKABPIH]))
					{
						((Renderer)collisionDetection.cropSetter.spriteRenderers[collisionDetection.cropSetter.growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, collisionDetection.movement + collisionDetection.HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
					}
					if (Object.op_Implicit((Object)(object)collisionDetection.cropSetter.spriteRenderersBack[collisionDetection.cropSetter.growable.FKDFFKABPIH]))
					{
						((Renderer)collisionDetection.cropSetter.spriteRenderersBack[collisionDetection.cropSetter.growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, collisionDetection.movement + collisionDetection.HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
					}
					if (Object.op_Implicit((Object)(object)collisionDetection.cropSetter.spriteRenderersDry[collisionDetection.cropSetter.growable.FKDFFKABPIH]))
					{
						((Renderer)collisionDetection.cropSetter.spriteRenderersDry[collisionDetection.cropSetter.growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, collisionDetection.movement + collisionDetection.HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
					}
				}
				collisionDetection.currentAmplitude = Mathf.Lerp(collisionDetection.currentAmplitude, 0f, collisionDetection.amplitudeRegression * Time.deltaTime);
				goto IL_0427;
				IL_0427:
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public SpriteRenderer[] spriteRenderers;

	public Herb herb;

	public SnowHerb snowHerb;

	public CropSetter cropSetter;

	public float amplitude = 10f;

	public float period = 5f;

	public float amplitudeRegression = 2.5f;

	public GameObject snowParticlesPrefab;

	public float startTime;

	public float movement;

	public float theta;

	public float currentAmplitude;

	private Coroutine LDKHPOBCNFC;

	private Material HKIODKOAHPE;

	private void JGBLJPDNLMO(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("SwordActiveRPC") || ((Component)LGGCFCHOOMB).CompareTag("ReceiveSetDrinkColor") || ((Component)LGGCFCHOOMB).CompareTag("Theme: ") || ((Component)LGGCFCHOOMB).CompareTag("Beach") || ((Component)LGGCFCHOOMB).CompareTag("Sleep"))
		{
			HOIOFIPDDNJ(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 948f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("ReceiveRenewCandle Unique id "))
		{
			APFILMLBHAA(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(669f, 611f));
		}
	}

	public void KCHNKLEIGLG(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 1194f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(CPCFCCAEEDM(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	private void JLCFNPBBKEK()
	{
		startTime = 700f;
		movement = 485f;
		theta = 120f;
		currentAmplitude = 509f;
		if ((Object)(object)herb != (Object)null)
		{
			HKIODKOAHPE = herb.defaultMaterial;
		}
		else if ((Object)(object)cropSetter != (Object)null)
		{
			HKIODKOAHPE = cropSetter.BGLJEGKOBHP(cropSetter.materialIndex);
		}
		else if (spriteRenderers != null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
	}

	public void CIODOEBIKNP()
	{
		herb = ((Component)this).GetComponentInParent<Herb>();
	}

	public void NKJKJKNFCKB(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 1678f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(PGNALCJDLOK(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	public void GCOGLJIEJGH(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 604f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(PGNALCJDLOK(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	private void ACLLIGOCDNN(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("mainMenuMultiplayerButton") || ((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/Rowdy/Entry/2/Dialogue Text") || ((Component)LGGCFCHOOMB).CompareTag("/ExtraSettings.sd") || ((Component)LGGCFCHOOMB).CompareTag("ScrollUp") || ((Component)LGGCFCHOOMB).CompareTag("Player Awake error on "))
		{
			NFNPEHKJDMM(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 156f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("Items/item_name_705"))
		{
			PENHJFMOEAA(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(1060f, 1201f));
		}
	}

	public void HFPCFFPINKN(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 396f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(PKAFJLKIOAB(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	private void DMOBCBHMGBP(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag(" (Host)") || ((Component)LGGCFCHOOMB).CompareTag("Red text: ") || ((Component)LGGCFCHOOMB).CompareTag("ReceiveLastOrder") || ((Component)LGGCFCHOOMB).CompareTag("Name...") || ((Component)LGGCFCHOOMB).CompareTag("LE_15"))
		{
			NFNPEHKJDMM(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 1317f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("talentStew"))
		{
			DBEAGEGGKPG(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(584f, 754f));
		}
	}

	private void FILGJJPEIFO(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("Generate All Routes") || ((Component)LGGCFCHOOMB).CompareTag("quest_description_30") || ((Component)LGGCFCHOOMB).CompareTag("City/Lia/Bark/Bye") || ((Component)LGGCFCHOOMB).CompareTag("D-Pad Down") || ((Component)LGGCFCHOOMB).CompareTag("HireWorker?"))
		{
			GCOGLJIEJGH(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 849f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag(" ("))
		{
			APFILMLBHAA(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(1097f, 595f));
		}
	}

	public void KBBPEMECENG()
	{
		herb = ((Component)this).GetComponentInParent<Herb>();
	}

	public void FDGLCGJFKPG(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 1351f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(MFCKAIAOKED(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	private void LIEIDOIDBLJ(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag(" of ") || ((Component)LGGCFCHOOMB).CompareTag("ReceiveActivateVIP") || ((Component)LGGCFCHOOMB).CompareTag("Items/item_name_1034") || ((Component)LGGCFCHOOMB).CompareTag("Start water quality test") || ((Component)LGGCFCHOOMB).CompareTag("immediately"))
		{
			CBLFBEOCLBE(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 189f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("Save"))
		{
			CBLFBEOCLBE(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(581f, 595f));
		}
	}

	public void PHBOGNNMNME()
	{
		herb = ((Component)this).GetComponentInParent<Herb>();
	}

	public void PENHJFMOEAA(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 1159f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(ADMJNIKOMFM(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	public void DBEAGEGGKPG(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 1321f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(PGNALCJDLOK(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	private IEnumerator JHEHFPDDHAI(float NCPGNLOJGAF = 1f, float HDDDOBNHONC = 1f)
	{
		currentAmplitude = amplitude;
		if ((Object)(object)herb != (Object)null && herb.frozen && herb.IsFrozen())
		{
			herb.ChangeToUnfrozenSprites();
			Object.Instantiate<GameObject>(snowParticlesPrefab, ((Component)this).transform.position + Vector3.up * 0.25f, Quaternion.identity, ((Component)this).transform.parent);
		}
		if ((Object)(object)snowHerb != (Object)null && snowHerb.herbIsFrozen)
		{
			snowHerb.UnfrozenHerb();
			Object.Instantiate<GameObject>(snowParticlesPrefab, ((Component)this).transform.position + Vector3.up * 0.25f, Quaternion.identity, ((Component)this).transform.parent);
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter && spriteRenderers != null)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				if (Object.op_Implicit((Object)(object)spriteRenderers[i]))
				{
					((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.noiseMultiplier, 0.05f);
				}
			}
		}
		while (currentAmplitude > 0.01f)
		{
			if (Object.op_Implicit((Object)(object)HKIODKOAHPE))
			{
				if ((Object)(object)WorldTime.GetInstance() == (Object)null)
				{
					yield return null;
				}
				if (SeasonManager.EECEKHKAAIH == Season.Winter && currentAmplitude < amplitude / 6f && spriteRenderers != null)
				{
					for (int j = 0; j < spriteRenderers.Length; j++)
					{
						if (Object.op_Implicit((Object)(object)spriteRenderers[j]))
						{
							((Renderer)spriteRenderers[j]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(0f, 0.05f, currentAmplitude / (amplitude / 6f)));
						}
					}
				}
				theta = (Time.timeSinceLevelLoad - startTime) / (period * HDDDOBNHONC);
				movement = currentAmplitude * Mathf.Sin(theta);
				if (NCPGNLOJGAF > 0f)
				{
					movement *= -1f;
				}
				if (spriteRenderers != null)
				{
					for (int k = 0; k < spriteRenderers.Length; k++)
					{
						if (Object.op_Implicit((Object)(object)spriteRenderers[k]))
						{
							((Renderer)spriteRenderers[k]).material.SetFloat(ShaderReferences.swishEffect, movement + HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
						}
					}
				}
				if ((Object)(object)cropSetter != (Object)null)
				{
					if (Object.op_Implicit((Object)(object)cropSetter.spriteRenderers[cropSetter.growable.FKDFFKABPIH]))
					{
						((Renderer)cropSetter.spriteRenderers[cropSetter.growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, movement + HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
					}
					if (Object.op_Implicit((Object)(object)cropSetter.spriteRenderersBack[cropSetter.growable.FKDFFKABPIH]))
					{
						((Renderer)cropSetter.spriteRenderersBack[cropSetter.growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, movement + HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
					}
					if (Object.op_Implicit((Object)(object)cropSetter.spriteRenderersDry[cropSetter.growable.FKDFFKABPIH]))
					{
						((Renderer)cropSetter.spriteRenderersDry[cropSetter.growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, movement + HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
					}
				}
				currentAmplitude = Mathf.Lerp(currentAmplitude, 0f, amplitudeRegression * Time.deltaTime);
			}
			yield return null;
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter && spriteRenderers != null)
		{
			for (int l = 0; l < spriteRenderers.Length; l++)
			{
				if (Object.op_Implicit((Object)(object)spriteRenderers[l]))
				{
					((Renderer)spriteRenderers[l]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
				}
			}
		}
		LDKHPOBCNFC = null;
		if ((Object)(object)cropSetter != (Object)null)
		{
			if (spriteRenderers == null)
			{
				yield break;
			}
			for (int m = 0; m < spriteRenderers.Length; m++)
			{
				if (Object.op_Implicit((Object)(object)spriteRenderers[m]))
				{
					((Renderer)spriteRenderers[m]).sharedMaterial = cropSetter.GetCurrentMaterial(cropSetter.materialIndex);
				}
			}
		}
		else
		{
			if (spriteRenderers == null)
			{
				yield break;
			}
			for (int n = 0; n < spriteRenderers.Length; n++)
			{
				if (Object.op_Implicit((Object)(object)spriteRenderers[n]))
				{
					((Renderer)spriteRenderers[n]).sharedMaterial = HKIODKOAHPE;
				}
			}
		}
	}

	private void BKKJCJBBACJ(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("SkeletonBird") || ((Component)LGGCFCHOOMB).CompareTag("Items/item_description_1069") || ((Component)LGGCFCHOOMB).CompareTag("Last") || ((Component)LGGCFCHOOMB).CompareTag("Exclamation") || ((Component)LGGCFCHOOMB).CompareTag("Items/item_description_648"))
		{
			GCOGLJIEJGH(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 860f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("BetterDuringTwoMonths"))
		{
			NHICFLMMDKL(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(888f, 751f));
		}
	}

	public void DMIGFCCEDAD(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 1354f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(IEFBNPMKBKC(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	public void ICFCJEEKIJK()
	{
		herb = ((Component)this).GetComponentInParent<Herb>();
	}

	private IEnumerator NNHJCOCONBK(float NCPGNLOJGAF = 1f, float HDDDOBNHONC = 1f)
	{
		currentAmplitude = amplitude;
		if ((Object)(object)herb != (Object)null && herb.frozen && herb.IsFrozen())
		{
			herb.ChangeToUnfrozenSprites();
			Object.Instantiate<GameObject>(snowParticlesPrefab, ((Component)this).transform.position + Vector3.up * 0.25f, Quaternion.identity, ((Component)this).transform.parent);
		}
		if ((Object)(object)snowHerb != (Object)null && snowHerb.herbIsFrozen)
		{
			snowHerb.UnfrozenHerb();
			Object.Instantiate<GameObject>(snowParticlesPrefab, ((Component)this).transform.position + Vector3.up * 0.25f, Quaternion.identity, ((Component)this).transform.parent);
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter && spriteRenderers != null)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				if (Object.op_Implicit((Object)(object)spriteRenderers[i]))
				{
					((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.noiseMultiplier, 0.05f);
				}
			}
		}
		while (currentAmplitude > 0.01f)
		{
			if (Object.op_Implicit((Object)(object)HKIODKOAHPE))
			{
				if ((Object)(object)WorldTime.GetInstance() == (Object)null)
				{
					yield return null;
				}
				if (SeasonManager.EECEKHKAAIH == Season.Winter && currentAmplitude < amplitude / 6f && spriteRenderers != null)
				{
					for (int j = 0; j < spriteRenderers.Length; j++)
					{
						if (Object.op_Implicit((Object)(object)spriteRenderers[j]))
						{
							((Renderer)spriteRenderers[j]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(0f, 0.05f, currentAmplitude / (amplitude / 6f)));
						}
					}
				}
				theta = (Time.timeSinceLevelLoad - startTime) / (period * HDDDOBNHONC);
				movement = currentAmplitude * Mathf.Sin(theta);
				if (NCPGNLOJGAF > 0f)
				{
					movement *= -1f;
				}
				if (spriteRenderers != null)
				{
					for (int k = 0; k < spriteRenderers.Length; k++)
					{
						if (Object.op_Implicit((Object)(object)spriteRenderers[k]))
						{
							((Renderer)spriteRenderers[k]).material.SetFloat(ShaderReferences.swishEffect, movement + HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
						}
					}
				}
				if ((Object)(object)cropSetter != (Object)null)
				{
					if (Object.op_Implicit((Object)(object)cropSetter.spriteRenderers[cropSetter.growable.FKDFFKABPIH]))
					{
						((Renderer)cropSetter.spriteRenderers[cropSetter.growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, movement + HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
					}
					if (Object.op_Implicit((Object)(object)cropSetter.spriteRenderersBack[cropSetter.growable.FKDFFKABPIH]))
					{
						((Renderer)cropSetter.spriteRenderersBack[cropSetter.growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, movement + HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
					}
					if (Object.op_Implicit((Object)(object)cropSetter.spriteRenderersDry[cropSetter.growable.FKDFFKABPIH]))
					{
						((Renderer)cropSetter.spriteRenderersDry[cropSetter.growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, movement + HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
					}
				}
				currentAmplitude = Mathf.Lerp(currentAmplitude, 0f, amplitudeRegression * Time.deltaTime);
			}
			yield return null;
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter && spriteRenderers != null)
		{
			for (int l = 0; l < spriteRenderers.Length; l++)
			{
				if (Object.op_Implicit((Object)(object)spriteRenderers[l]))
				{
					((Renderer)spriteRenderers[l]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
				}
			}
		}
		LDKHPOBCNFC = null;
		if ((Object)(object)cropSetter != (Object)null)
		{
			if (spriteRenderers == null)
			{
				yield break;
			}
			for (int m = 0; m < spriteRenderers.Length; m++)
			{
				if (Object.op_Implicit((Object)(object)spriteRenderers[m]))
				{
					((Renderer)spriteRenderers[m]).sharedMaterial = cropSetter.GetCurrentMaterial(cropSetter.materialIndex);
				}
			}
		}
		else
		{
			if (spriteRenderers == null)
			{
				yield break;
			}
			for (int n = 0; n < spriteRenderers.Length; n++)
			{
				if (Object.op_Implicit((Object)(object)spriteRenderers[n]))
				{
					((Renderer)spriteRenderers[n]).sharedMaterial = HKIODKOAHPE;
				}
			}
		}
	}

	public void ANBILIMDGJH(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 968f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(ADMJNIKOMFM(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	public void CIDKOLKILDB(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 1812f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(PGNALCJDLOK(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	private IEnumerator ICLNIGOAECJ(float NCPGNLOJGAF = 1f, float HDDDOBNHONC = 1f)
	{
		return new OAFCPMCHCGO(1)
		{
			_003C_003E4__this = this,
			x = NCPGNLOJGAF,
			amplitudeMultiplier = HDDDOBNHONC
		};
	}

	private void ELKDCKDCKHL(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("Items/item_description_1051") || ((Component)LGGCFCHOOMB).CompareTag("Duplicate shop id found: ") || ((Component)LGGCFCHOOMB).CompareTag(" ") || ((Component)LGGCFCHOOMB).CompareTag("TurnOffAllWeather") || ((Component)LGGCFCHOOMB).CompareTag("Items/item_name_1177"))
		{
			IFHLKCEHPEG(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 625f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag(" with id "))
		{
			NAKAHOMIDDI(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(1109f, 1001f));
		}
	}

	private void EBICEBJOKBA(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("Intro11") || ((Component)LGGCFCHOOMB).CompareTag("StoneWorkshop") || ((Component)LGGCFCHOOMB).CompareTag("ReceiveBecomeNuisance") || ((Component)LGGCFCHOOMB).CompareTag("Jump") || ((Component)LGGCFCHOOMB).CompareTag(" seconds."))
		{
			EMOEPNGDFAM(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 1514f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("[SelectSpawnersByMaxDistance] Ran out of candidates at step {0}/{1}."))
		{
			EMOEPNGDFAM(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(1210f, 401f));
		}
	}

	private IEnumerator PKAFJLKIOAB(float NCPGNLOJGAF = 1f, float HDDDOBNHONC = 1f)
	{
		return new OAFCPMCHCGO(1)
		{
			_003C_003E4__this = this,
			x = NCPGNLOJGAF,
			amplitudeMultiplier = HDDDOBNHONC
		};
	}

	private void DMENPMHIPDA(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag(" to local storage for reason: ") || ((Component)LGGCFCHOOMB).CompareTag("ReceiveGenerateAvailableOrders") || ((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/NeutralInTavern/Entry/13/Dialogue Text") || ((Component)LGGCFCHOOMB).CompareTag("itemPorter") || ((Component)LGGCFCHOOMB).CompareTag("Sit"))
		{
			FDGLCGJFKPG(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 1980f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("Cancel Crafting"))
		{
			NHICFLMMDKL(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(1762f, 119f));
		}
	}

	public void GLJNMKELJBG(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 268f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(JCEDFPGAPDO(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	private void DEKJGPJMAPC(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("[RestoreNonAltarVariant] - VariantObjects: {0} - ({1}-{2}/{3}) ") || ((Component)LGGCFCHOOMB).CompareTag(": ") || ((Component)LGGCFCHOOMB).CompareTag("Items/item_name_1173") || ((Component)LGGCFCHOOMB).CompareTag("Received pipe tile swap: indexA={0}, indexB={1}, mineLevel={2}") || ((Component)LGGCFCHOOMB).CompareTag("Rest"))
		{
			ANBILIMDGJH(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 1287f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("ErrorWhileSaving"))
		{
			NAKAHOMIDDI(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(1632f, 1114f));
		}
	}

	private IEnumerator MFCKAIAOKED(float NCPGNLOJGAF = 1f, float HDDDOBNHONC = 1f)
	{
		return new OAFCPMCHCGO(1)
		{
			_003C_003E4__this = this,
			x = NCPGNLOJGAF,
			amplitudeMultiplier = HDDDOBNHONC
		};
	}

	private void OOALHOHGANE(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("ReceiveChargeMoney") || ((Component)LGGCFCHOOMB).CompareTag("BathhouseEntrace/Main 2") || ((Component)LGGCFCHOOMB).CompareTag("Attack/MainEvent 3") || ((Component)LGGCFCHOOMB).CompareTag("Walk") || ((Component)LGGCFCHOOMB).CompareTag("ReceiveButtonPressPuzzle"))
		{
			ANBILIMDGJH(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 1554f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("LoadGameplaySceneOnline masterClient"))
		{
			LMHFINPNGOF(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(906f, 1166f));
		}
	}

	public void EMOEPNGDFAM(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 1796f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(ICLNIGOAECJ(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	private IEnumerator CPCFCCAEEDM(float NCPGNLOJGAF = 1f, float HDDDOBNHONC = 1f)
	{
		return new OAFCPMCHCGO(1)
		{
			_003C_003E4__this = this,
			x = NCPGNLOJGAF,
			amplitudeMultiplier = HDDDOBNHONC
		};
	}

	private void MCMKNBIBDFF()
	{
		startTime = 1214f;
		movement = 831f;
		theta = 261f;
		currentAmplitude = 728f;
		if ((Object)(object)herb != (Object)null)
		{
			HKIODKOAHPE = herb.defaultMaterial;
		}
		else if ((Object)(object)cropSetter != (Object)null)
		{
			HKIODKOAHPE = cropSetter.GetCurrentMaterial(cropSetter.materialIndex, CBIPENPIJPC: true);
		}
		else if (spriteRenderers != null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
	}

	public void EPEFFGMNONF()
	{
		herb = ((Component)this).GetComponentInParent<Herb>();
	}

	public void OHBDMDMCMJF()
	{
		herb = ((Component)this).GetComponentInParent<Herb>();
	}

	private void EBNENBFLEKB()
	{
		startTime = 432f;
		movement = 1462f;
		theta = 1462f;
		currentAmplitude = 581f;
		if ((Object)(object)herb != (Object)null)
		{
			HKIODKOAHPE = herb.defaultMaterial;
		}
		else if ((Object)(object)cropSetter != (Object)null)
		{
			HKIODKOAHPE = cropSetter.GetCurrentMaterial(cropSetter.materialIndex);
		}
		else if (spriteRenderers != null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
	}

	private void PFIONHCONDI(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("") || ((Component)LGGCFCHOOMB).CompareTag("SystemInfo.graphicsMemorySize ") || ((Component)LGGCFCHOOMB).CompareTag("Activate Lock") || ((Component)LGGCFCHOOMB).CompareTag("Items/item_description_691") || ((Component)LGGCFCHOOMB).CompareTag("Trying to get friend "))
		{
			NFNPEHKJDMM(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 1388f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("Grass"))
		{
			HIIDKJAMFCD(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(84f, 557f));
		}
	}

	public void StartAnimation(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 2f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(JHEHFPDDHAI(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	private void NKJMIFCPJFA(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag(")") || ((Component)LGGCFCHOOMB).CompareTag("Selected") || ((Component)LGGCFCHOOMB).CompareTag("MapCamp") || ((Component)LGGCFCHOOMB).CompareTag("Focused") || ((Component)LGGCFCHOOMB).CompareTag("Aging Rack"))
		{
			LHMIEMCJHMD(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 292f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("#.##%"))
		{
			JJOLMGPCGAA(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(660f, 8f));
		}
	}

	private void NPIDHDAIPKG(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("Not enough ingredients") || ((Component)LGGCFCHOOMB).CompareTag("Rummage") || ((Component)LGGCFCHOOMB).CompareTag("Error_CloseMenus") || ((Component)LGGCFCHOOMB).CompareTag("RoomDoor") || ((Component)LGGCFCHOOMB).CompareTag("[Variants] Piece {0} ({1}) has {2} variants and ALL are deactivated."))
		{
			DMIGFCCEDAD(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 1331f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("]"))
		{
			ANBILIMDGJH(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(319f, 1882f));
		}
	}

	public void NAKAHOMIDDI(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 1502f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(CPCFCCAEEDM(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	public void JJOLMGPCGAA(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 833f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(CPCFCCAEEDM(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	public void DHILJFOMMIF()
	{
		herb = ((Component)this).GetComponentInParent<Herb>();
	}

	public void AIEIAKHHJKK(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 1367f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(IEFBNPMKBKC(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	private void CHIJGHPHCNA()
	{
		startTime = 181f;
		movement = 739f;
		theta = 1302f;
		currentAmplitude = 1491f;
		if ((Object)(object)herb != (Object)null)
		{
			HKIODKOAHPE = herb.defaultMaterial;
		}
		else if ((Object)(object)cropSetter != (Object)null)
		{
			HKIODKOAHPE = cropSetter.BGLJEGKOBHP(cropSetter.materialIndex);
		}
		else if (spriteRenderers != null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
	}

	public void JKJDMGFFHHB()
	{
		herb = ((Component)this).GetComponentInParent<Herb>();
	}

	private void HFFFFAJFIPB()
	{
		startTime = 691f;
		movement = 540f;
		theta = 1405f;
		currentAmplitude = 1784f;
		if ((Object)(object)herb != (Object)null)
		{
			HKIODKOAHPE = herb.defaultMaterial;
		}
		else if ((Object)(object)cropSetter != (Object)null)
		{
			HKIODKOAHPE = cropSetter.GetCurrentMaterial(cropSetter.materialIndex, CBIPENPIJPC: true);
		}
		else if (spriteRenderers != null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
	}

	public void LMHFINPNGOF(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 756f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(MFCKAIAOKED(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	private void KPFLAOALALM(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("Placed item has no item setup component: ") || ((Component)LGGCFCHOOMB).CompareTag("Close") || ((Component)LGGCFCHOOMB).CompareTag("Error/") || ((Component)LGGCFCHOOMB).CompareTag(" ") || ((Component)LGGCFCHOOMB).CompareTag("F4"))
		{
			StartAnimation(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 12f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("yForYears"))
		{
			CBLFBEOCLBE(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(1533f, 1588f));
		}
	}

	private void LJLKBKEADGI()
	{
		startTime = 214f;
		movement = 826f;
		theta = 900f;
		currentAmplitude = 787f;
		if ((Object)(object)herb != (Object)null)
		{
			HKIODKOAHPE = herb.defaultMaterial;
		}
		else if ((Object)(object)cropSetter != (Object)null)
		{
			HKIODKOAHPE = cropSetter.GetCurrentMaterial(cropSetter.materialIndex, CBIPENPIJPC: true);
		}
		else if (spriteRenderers != null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
	}

	public void KJNNBKLHPDE(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 451f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(JHEHFPDDHAI(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	public void CJFFPKFIOHD()
	{
		herb = ((Component)this).GetComponentInParent<Herb>();
	}

	private IEnumerator IEFBNPMKBKC(float NCPGNLOJGAF = 1f, float HDDDOBNHONC = 1f)
	{
		currentAmplitude = amplitude;
		if ((Object)(object)herb != (Object)null && herb.frozen && herb.IsFrozen())
		{
			herb.ChangeToUnfrozenSprites();
			Object.Instantiate<GameObject>(snowParticlesPrefab, ((Component)this).transform.position + Vector3.up * 0.25f, Quaternion.identity, ((Component)this).transform.parent);
		}
		if ((Object)(object)snowHerb != (Object)null && snowHerb.herbIsFrozen)
		{
			snowHerb.UnfrozenHerb();
			Object.Instantiate<GameObject>(snowParticlesPrefab, ((Component)this).transform.position + Vector3.up * 0.25f, Quaternion.identity, ((Component)this).transform.parent);
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter && spriteRenderers != null)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				if (Object.op_Implicit((Object)(object)spriteRenderers[i]))
				{
					((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.noiseMultiplier, 0.05f);
				}
			}
		}
		while (currentAmplitude > 0.01f)
		{
			if (Object.op_Implicit((Object)(object)HKIODKOAHPE))
			{
				if ((Object)(object)WorldTime.GetInstance() == (Object)null)
				{
					yield return null;
				}
				if (SeasonManager.EECEKHKAAIH == Season.Winter && currentAmplitude < amplitude / 6f && spriteRenderers != null)
				{
					for (int j = 0; j < spriteRenderers.Length; j++)
					{
						if (Object.op_Implicit((Object)(object)spriteRenderers[j]))
						{
							((Renderer)spriteRenderers[j]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(0f, 0.05f, currentAmplitude / (amplitude / 6f)));
						}
					}
				}
				theta = (Time.timeSinceLevelLoad - startTime) / (period * HDDDOBNHONC);
				movement = currentAmplitude * Mathf.Sin(theta);
				if (NCPGNLOJGAF > 0f)
				{
					movement *= -1f;
				}
				if (spriteRenderers != null)
				{
					for (int k = 0; k < spriteRenderers.Length; k++)
					{
						if (Object.op_Implicit((Object)(object)spriteRenderers[k]))
						{
							((Renderer)spriteRenderers[k]).material.SetFloat(ShaderReferences.swishEffect, movement + HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
						}
					}
				}
				if ((Object)(object)cropSetter != (Object)null)
				{
					if (Object.op_Implicit((Object)(object)cropSetter.spriteRenderers[cropSetter.growable.FKDFFKABPIH]))
					{
						((Renderer)cropSetter.spriteRenderers[cropSetter.growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, movement + HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
					}
					if (Object.op_Implicit((Object)(object)cropSetter.spriteRenderersBack[cropSetter.growable.FKDFFKABPIH]))
					{
						((Renderer)cropSetter.spriteRenderersBack[cropSetter.growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, movement + HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
					}
					if (Object.op_Implicit((Object)(object)cropSetter.spriteRenderersDry[cropSetter.growable.FKDFFKABPIH]))
					{
						((Renderer)cropSetter.spriteRenderersDry[cropSetter.growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, movement + HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
					}
				}
				currentAmplitude = Mathf.Lerp(currentAmplitude, 0f, amplitudeRegression * Time.deltaTime);
			}
			yield return null;
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter && spriteRenderers != null)
		{
			for (int l = 0; l < spriteRenderers.Length; l++)
			{
				if (Object.op_Implicit((Object)(object)spriteRenderers[l]))
				{
					((Renderer)spriteRenderers[l]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
				}
			}
		}
		LDKHPOBCNFC = null;
		if ((Object)(object)cropSetter != (Object)null)
		{
			if (spriteRenderers == null)
			{
				yield break;
			}
			for (int m = 0; m < spriteRenderers.Length; m++)
			{
				if (Object.op_Implicit((Object)(object)spriteRenderers[m]))
				{
					((Renderer)spriteRenderers[m]).sharedMaterial = cropSetter.GetCurrentMaterial(cropSetter.materialIndex);
				}
			}
		}
		else
		{
			if (spriteRenderers == null)
			{
				yield break;
			}
			for (int n = 0; n < spriteRenderers.Length; n++)
			{
				if (Object.op_Implicit((Object)(object)spriteRenderers[n]))
				{
					((Renderer)spriteRenderers[n]).sharedMaterial = HKIODKOAHPE;
				}
			}
		}
	}

	public void IFHLKCEHPEG(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 1172f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(JBFMDKKCEML(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	public void HCEODJDHMLE(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 41f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(JCEDFPGAPDO(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	public void EGLMBMJPPAE()
	{
		herb = ((Component)this).GetComponentInParent<Herb>();
	}

	private void GLMENOJADEF(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("ReceiveResetBento") || ((Component)LGGCFCHOOMB).CompareTag(" ") || ((Component)LGGCFCHOOMB).CompareTag("onlinecode") || ((Component)LGGCFCHOOMB).CompareTag("Alpha") || ((Component)LGGCFCHOOMB).CompareTag(" - Activating variant object "))
		{
			AIEIAKHHJKK(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 1777f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("RequiresAging"))
		{
			LMHFINPNGOF(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(468f, 1288f));
		}
	}

	private void NPMLFHDHJBE()
	{
		startTime = 1474f;
		movement = 1762f;
		theta = 1445f;
		currentAmplitude = 300f;
		if ((Object)(object)herb != (Object)null)
		{
			HKIODKOAHPE = herb.defaultMaterial;
		}
		else if ((Object)(object)cropSetter != (Object)null)
		{
			HKIODKOAHPE = cropSetter.BGLJEGKOBHP(cropSetter.materialIndex);
		}
		else if (spriteRenderers != null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
	}

	private void FJEKAKFLJJM(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("UnlockPerkLevel?") || ((Component)LGGCFCHOOMB).CompareTag("Occupied Positions") || ((Component)LGGCFCHOOMB).CompareTag("OneShotVolume") || ((Component)LGGCFCHOOMB).CompareTag(" ") || ((Component)LGGCFCHOOMB).CompareTag("LE_10"))
		{
			NAKAHOMIDDI(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 496f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("BathhouseGameManager: Pool not found."))
		{
			NKJKJKNFCKB(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(688f, 699f));
		}
	}

	private IEnumerator OOEGBOOLDOK(float NCPGNLOJGAF = 1f, float HDDDOBNHONC = 1f)
	{
		return new OAFCPMCHCGO(1)
		{
			_003C_003E4__this = this,
			x = NCPGNLOJGAF,
			amplitudeMultiplier = HDDDOBNHONC
		};
	}

	private void JOAGNMPLDLH(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("Checking current game language") || ((Component)LGGCFCHOOMB).CompareTag("Farm/Event/PiedrasVioletyArthur") || ((Component)LGGCFCHOOMB).CompareTag(" to ") || ((Component)LGGCFCHOOMB).CompareTag("ReceiveRenewCandle") || ((Component)LGGCFCHOOMB).CompareTag("Fill"))
		{
			KJNNBKLHPDE(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 695f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("RochelleProgress"))
		{
			DMIGFCCEDAD(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(913f, 549f));
		}
	}

	private void BJBPHIFNKIF()
	{
		startTime = 1681f;
		movement = 43f;
		theta = 1876f;
		currentAmplitude = 1109f;
		if ((Object)(object)herb != (Object)null)
		{
			HKIODKOAHPE = herb.defaultMaterial;
		}
		else if ((Object)(object)cropSetter != (Object)null)
		{
			HKIODKOAHPE = cropSetter.BGLJEGKOBHP(cropSetter.materialIndex, CBIPENPIJPC: true);
		}
		else if (spriteRenderers != null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
	}

	private IEnumerator PGNALCJDLOK(float NCPGNLOJGAF = 1f, float HDDDOBNHONC = 1f)
	{
		return new OAFCPMCHCGO(1)
		{
			_003C_003E4__this = this,
			x = NCPGNLOJGAF,
			amplitudeMultiplier = HDDDOBNHONC
		};
	}

	public void NFNPEHKJDMM(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 505f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(MFCKAIAOKED(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	private void AIOJHEKNMIC(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("Fruit Ferment") || ((Component)LGGCFCHOOMB).CompareTag("[Red") || ((Component)LGGCFCHOOMB).CompareTag("Fortitude/MainEvent 2") || ((Component)LGGCFCHOOMB).CompareTag("Color") || ((Component)LGGCFCHOOMB).CompareTag("Items/item_description_650"))
		{
			HIIDKJAMFCD(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 1459f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag(" is Writing."))
		{
			DBEAGEGGKPG(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(1961f, 1315f));
		}
	}

	public void LHMIEMCJHMD(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 1653f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(AILBJODKJHL(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	public void AMDIEKBFPGE()
	{
		herb = ((Component)this).GetComponentInParent<Herb>();
	}

	private void IOINOMJHICB()
	{
		startTime = 1998f;
		movement = 1261f;
		theta = 615f;
		currentAmplitude = 1268f;
		if ((Object)(object)herb != (Object)null)
		{
			HKIODKOAHPE = herb.defaultMaterial;
		}
		else if ((Object)(object)cropSetter != (Object)null)
		{
			HKIODKOAHPE = cropSetter.BGLJEGKOBHP(cropSetter.materialIndex);
		}
		else if (spriteRenderers != null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
	}

	private IEnumerator JBFMDKKCEML(float NCPGNLOJGAF = 1f, float HDDDOBNHONC = 1f)
	{
		return new OAFCPMCHCGO(1)
		{
			_003C_003E4__this = this,
			x = NCPGNLOJGAF,
			amplitudeMultiplier = HDDDOBNHONC
		};
	}

	private void OLDDEAJMHNI()
	{
		startTime = 444f;
		movement = 422f;
		theta = 1699f;
		currentAmplitude = 1003f;
		if ((Object)(object)herb != (Object)null)
		{
			HKIODKOAHPE = herb.defaultMaterial;
		}
		else if ((Object)(object)cropSetter != (Object)null)
		{
			HKIODKOAHPE = cropSetter.BGLJEGKOBHP(cropSetter.materialIndex, CBIPENPIJPC: true);
		}
		else if (spriteRenderers != null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
	}

	private IEnumerator NBLAJLKDIBG(float NCPGNLOJGAF = 1f, float HDDDOBNHONC = 1f)
	{
		return new OAFCPMCHCGO(1)
		{
			_003C_003E4__this = this,
			x = NCPGNLOJGAF,
			amplitudeMultiplier = HDDDOBNHONC
		};
	}

	private void Start()
	{
		startTime = 0f;
		movement = 0f;
		theta = 0f;
		currentAmplitude = 0f;
		if ((Object)(object)herb != (Object)null)
		{
			HKIODKOAHPE = herb.defaultMaterial;
		}
		else if ((Object)(object)cropSetter != (Object)null)
		{
			HKIODKOAHPE = cropSetter.GetCurrentMaterial(cropSetter.materialIndex);
		}
		else if (spriteRenderers != null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
	}

	private void BOBJMDGALPM(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("ThemeListView") || ((Component)LGGCFCHOOMB).CompareTag("InfoSectionCanvas/InfoSection") || ((Component)LGGCFCHOOMB).CompareTag("This ingredient is temporarily available") || ((Component)LGGCFCHOOMB).CompareTag("Items/item_description_724") || ((Component)LGGCFCHOOMB).CompareTag("ReceiveRemoveOrderQuest"))
		{
			NKJKJKNFCKB(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 862f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("ERROR: The object "))
		{
			EMOEPNGDFAM(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(302f, 1295f));
		}
	}

	private void JOAIONJPBIO(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("\n") || ((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/UnhappyRentRoom/Entry/2/Dialogue Text") || ((Component)LGGCFCHOOMB).CompareTag("Aromatic") || ((Component)LGGCFCHOOMB).CompareTag("Capacity") || ((Component)LGGCFCHOOMB).CompareTag("questDescPorridge"))
		{
			DMIGFCCEDAD(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 473f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag(" : "))
		{
			NFNPEHKJDMM(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(1319f, 224f));
		}
	}

	public void APFILMLBHAA(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 808f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(NNHJCOCONBK(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	private void IDHCFOCEPMD()
	{
		startTime = 36f;
		movement = 595f;
		theta = 121f;
		currentAmplitude = 24f;
		if ((Object)(object)herb != (Object)null)
		{
			HKIODKOAHPE = herb.defaultMaterial;
		}
		else if ((Object)(object)cropSetter != (Object)null)
		{
			HKIODKOAHPE = cropSetter.GetCurrentMaterial(cropSetter.materialIndex, CBIPENPIJPC: true);
		}
		else if (spriteRenderers != null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
	}

	public void LinkVariables()
	{
		herb = ((Component)this).GetComponentInParent<Herb>();
	}

	private IEnumerator AILBJODKJHL(float NCPGNLOJGAF = 1f, float HDDDOBNHONC = 1f)
	{
		currentAmplitude = amplitude;
		if ((Object)(object)herb != (Object)null && herb.frozen && herb.IsFrozen())
		{
			herb.ChangeToUnfrozenSprites();
			Object.Instantiate<GameObject>(snowParticlesPrefab, ((Component)this).transform.position + Vector3.up * 0.25f, Quaternion.identity, ((Component)this).transform.parent);
		}
		if ((Object)(object)snowHerb != (Object)null && snowHerb.herbIsFrozen)
		{
			snowHerb.UnfrozenHerb();
			Object.Instantiate<GameObject>(snowParticlesPrefab, ((Component)this).transform.position + Vector3.up * 0.25f, Quaternion.identity, ((Component)this).transform.parent);
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter && spriteRenderers != null)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				if (Object.op_Implicit((Object)(object)spriteRenderers[i]))
				{
					((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.noiseMultiplier, 0.05f);
				}
			}
		}
		while (currentAmplitude > 0.01f)
		{
			if (Object.op_Implicit((Object)(object)HKIODKOAHPE))
			{
				if ((Object)(object)WorldTime.GetInstance() == (Object)null)
				{
					yield return null;
				}
				if (SeasonManager.EECEKHKAAIH == Season.Winter && currentAmplitude < amplitude / 6f && spriteRenderers != null)
				{
					for (int j = 0; j < spriteRenderers.Length; j++)
					{
						if (Object.op_Implicit((Object)(object)spriteRenderers[j]))
						{
							((Renderer)spriteRenderers[j]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(0f, 0.05f, currentAmplitude / (amplitude / 6f)));
						}
					}
				}
				theta = (Time.timeSinceLevelLoad - startTime) / (period * HDDDOBNHONC);
				movement = currentAmplitude * Mathf.Sin(theta);
				if (NCPGNLOJGAF > 0f)
				{
					movement *= -1f;
				}
				if (spriteRenderers != null)
				{
					for (int k = 0; k < spriteRenderers.Length; k++)
					{
						if (Object.op_Implicit((Object)(object)spriteRenderers[k]))
						{
							((Renderer)spriteRenderers[k]).material.SetFloat(ShaderReferences.swishEffect, movement + HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
						}
					}
				}
				if ((Object)(object)cropSetter != (Object)null)
				{
					if (Object.op_Implicit((Object)(object)cropSetter.spriteRenderers[cropSetter.growable.FKDFFKABPIH]))
					{
						((Renderer)cropSetter.spriteRenderers[cropSetter.growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, movement + HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
					}
					if (Object.op_Implicit((Object)(object)cropSetter.spriteRenderersBack[cropSetter.growable.FKDFFKABPIH]))
					{
						((Renderer)cropSetter.spriteRenderersBack[cropSetter.growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, movement + HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
					}
					if (Object.op_Implicit((Object)(object)cropSetter.spriteRenderersDry[cropSetter.growable.FKDFFKABPIH]))
					{
						((Renderer)cropSetter.spriteRenderersDry[cropSetter.growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, movement + HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
					}
				}
				currentAmplitude = Mathf.Lerp(currentAmplitude, 0f, amplitudeRegression * Time.deltaTime);
			}
			yield return null;
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter && spriteRenderers != null)
		{
			for (int l = 0; l < spriteRenderers.Length; l++)
			{
				if (Object.op_Implicit((Object)(object)spriteRenderers[l]))
				{
					((Renderer)spriteRenderers[l]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
				}
			}
		}
		LDKHPOBCNFC = null;
		if ((Object)(object)cropSetter != (Object)null)
		{
			if (spriteRenderers == null)
			{
				yield break;
			}
			for (int m = 0; m < spriteRenderers.Length; m++)
			{
				if (Object.op_Implicit((Object)(object)spriteRenderers[m]))
				{
					((Renderer)spriteRenderers[m]).sharedMaterial = cropSetter.GetCurrentMaterial(cropSetter.materialIndex);
				}
			}
		}
		else
		{
			if (spriteRenderers == null)
			{
				yield break;
			}
			for (int n = 0; n < spriteRenderers.Length; n++)
			{
				if (Object.op_Implicit((Object)(object)spriteRenderers[n]))
				{
					((Renderer)spriteRenderers[n]).sharedMaterial = HKIODKOAHPE;
				}
			}
		}
	}

	private void BOIGOJGNNAK()
	{
		startTime = 1061f;
		movement = 1249f;
		theta = 549f;
		currentAmplitude = 167f;
		if ((Object)(object)herb != (Object)null)
		{
			HKIODKOAHPE = herb.defaultMaterial;
		}
		else if ((Object)(object)cropSetter != (Object)null)
		{
			HKIODKOAHPE = cropSetter.BGLJEGKOBHP(cropSetter.materialIndex, CBIPENPIJPC: true);
		}
		else if (spriteRenderers != null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
	}

	public void KOGEJLCJNEM()
	{
		herb = ((Component)this).GetComponentInParent<Herb>();
	}

	private void NDNBDEHFFJF()
	{
		startTime = 1779f;
		movement = 547f;
		theta = 664f;
		currentAmplitude = 352f;
		if ((Object)(object)herb != (Object)null)
		{
			HKIODKOAHPE = herb.defaultMaterial;
		}
		else if ((Object)(object)cropSetter != (Object)null)
		{
			HKIODKOAHPE = cropSetter.GetCurrentMaterial(cropSetter.materialIndex);
		}
		else if (spriteRenderers != null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
	}

	public void KIMLEJCHPMD(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 1082f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(ADMJNIKOMFM(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	public void HLBFEEOGKPE()
	{
		herb = ((Component)this).GetComponentInParent<Herb>();
	}

	private void EMCFHILONOH(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("BathhouseGame/Talk") || ((Component)LGGCFCHOOMB).CompareTag("Could not find shop with id: ") || ((Component)LGGCFCHOOMB).CompareTag("LE_8") || ((Component)LGGCFCHOOMB).CompareTag("enchantedBroomDesc") || ((Component)LGGCFCHOOMB).CompareTag("LE_15"))
		{
			CBLFBEOCLBE(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 912f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("[StuckRecovery] No hay safe points para el player {0}"))
		{
			KCHNKLEIGLG(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(1375f, 1993f));
		}
	}

	public void HOIOFIPDDNJ(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 502f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(CPCFCCAEEDM(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	public void ELIFIGOAILK()
	{
		herb = ((Component)this).GetComponentInParent<Herb>();
	}

	private void HHLBFDBHDMC()
	{
		startTime = 640f;
		movement = 1660f;
		theta = 1825f;
		currentAmplitude = 988f;
		if ((Object)(object)herb != (Object)null)
		{
			HKIODKOAHPE = herb.defaultMaterial;
		}
		else if ((Object)(object)cropSetter != (Object)null)
		{
			HKIODKOAHPE = cropSetter.BGLJEGKOBHP(cropSetter.materialIndex);
		}
		else if (spriteRenderers != null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
	}

	public void HNFCOEHAADN(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 1328f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(JCEDFPGAPDO(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	private void NLFHFPHDNCF()
	{
		startTime = 509f;
		movement = 868f;
		theta = 1443f;
		currentAmplitude = 1548f;
		if ((Object)(object)herb != (Object)null)
		{
			HKIODKOAHPE = herb.defaultMaterial;
		}
		else if ((Object)(object)cropSetter != (Object)null)
		{
			HKIODKOAHPE = cropSetter.GetCurrentMaterial(cropSetter.materialIndex, CBIPENPIJPC: true);
		}
		else if (spriteRenderers != null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
	}

	private void JEMIPCBNPDI(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("Player2") || ((Component)LGGCFCHOOMB).CompareTag(" without doWork attached to OnlineObject") || ((Component)LGGCFCHOOMB).CompareTag("cropsHarvested") || ((Component)LGGCFCHOOMB).CompareTag("Player with playerNum {0} does not exist or has been removed from the dictionary after disconnecting.") || ((Component)LGGCFCHOOMB).CompareTag("BLOCKS NUMBER: {0} Puzzle Needit: {1}"))
		{
			FDGLCGJFKPG(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 1384f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("DestroyWithTime: No object assigned to destroy. Destroying the GameObject this script is attached to instead."))
		{
			GCOGLJIEJGH(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(451f, 336f));
		}
	}

	private void GNGADDPBJDC()
	{
		startTime = 722f;
		movement = 1142f;
		theta = 837f;
		currentAmplitude = 1632f;
		if ((Object)(object)herb != (Object)null)
		{
			HKIODKOAHPE = herb.defaultMaterial;
		}
		else if ((Object)(object)cropSetter != (Object)null)
		{
			HKIODKOAHPE = cropSetter.BGLJEGKOBHP(cropSetter.materialIndex, CBIPENPIJPC: true);
		}
		else if (spriteRenderers != null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
	}

	private IEnumerator JCEDFPGAPDO(float NCPGNLOJGAF = 1f, float HDDDOBNHONC = 1f)
	{
		currentAmplitude = amplitude;
		if ((Object)(object)herb != (Object)null && herb.frozen && herb.IsFrozen())
		{
			herb.ChangeToUnfrozenSprites();
			Object.Instantiate<GameObject>(snowParticlesPrefab, ((Component)this).transform.position + Vector3.up * 0.25f, Quaternion.identity, ((Component)this).transform.parent);
		}
		if ((Object)(object)snowHerb != (Object)null && snowHerb.herbIsFrozen)
		{
			snowHerb.UnfrozenHerb();
			Object.Instantiate<GameObject>(snowParticlesPrefab, ((Component)this).transform.position + Vector3.up * 0.25f, Quaternion.identity, ((Component)this).transform.parent);
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter && spriteRenderers != null)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				if (Object.op_Implicit((Object)(object)spriteRenderers[i]))
				{
					((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.noiseMultiplier, 0.05f);
				}
			}
		}
		while (currentAmplitude > 0.01f)
		{
			if (Object.op_Implicit((Object)(object)HKIODKOAHPE))
			{
				if ((Object)(object)WorldTime.GetInstance() == (Object)null)
				{
					yield return null;
				}
				if (SeasonManager.EECEKHKAAIH == Season.Winter && currentAmplitude < amplitude / 6f && spriteRenderers != null)
				{
					for (int j = 0; j < spriteRenderers.Length; j++)
					{
						if (Object.op_Implicit((Object)(object)spriteRenderers[j]))
						{
							((Renderer)spriteRenderers[j]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(0f, 0.05f, currentAmplitude / (amplitude / 6f)));
						}
					}
				}
				theta = (Time.timeSinceLevelLoad - startTime) / (period * HDDDOBNHONC);
				movement = currentAmplitude * Mathf.Sin(theta);
				if (NCPGNLOJGAF > 0f)
				{
					movement *= -1f;
				}
				if (spriteRenderers != null)
				{
					for (int k = 0; k < spriteRenderers.Length; k++)
					{
						if (Object.op_Implicit((Object)(object)spriteRenderers[k]))
						{
							((Renderer)spriteRenderers[k]).material.SetFloat(ShaderReferences.swishEffect, movement + HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
						}
					}
				}
				if ((Object)(object)cropSetter != (Object)null)
				{
					if (Object.op_Implicit((Object)(object)cropSetter.spriteRenderers[cropSetter.growable.FKDFFKABPIH]))
					{
						((Renderer)cropSetter.spriteRenderers[cropSetter.growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, movement + HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
					}
					if (Object.op_Implicit((Object)(object)cropSetter.spriteRenderersBack[cropSetter.growable.FKDFFKABPIH]))
					{
						((Renderer)cropSetter.spriteRenderersBack[cropSetter.growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, movement + HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
					}
					if (Object.op_Implicit((Object)(object)cropSetter.spriteRenderersDry[cropSetter.growable.FKDFFKABPIH]))
					{
						((Renderer)cropSetter.spriteRenderersDry[cropSetter.growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, movement + HKIODKOAHPE.GetFloat(ShaderReferences.swishEffect));
					}
				}
				currentAmplitude = Mathf.Lerp(currentAmplitude, 0f, amplitudeRegression * Time.deltaTime);
			}
			yield return null;
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter && spriteRenderers != null)
		{
			for (int l = 0; l < spriteRenderers.Length; l++)
			{
				if (Object.op_Implicit((Object)(object)spriteRenderers[l]))
				{
					((Renderer)spriteRenderers[l]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
				}
			}
		}
		LDKHPOBCNFC = null;
		if ((Object)(object)cropSetter != (Object)null)
		{
			if (spriteRenderers == null)
			{
				yield break;
			}
			for (int m = 0; m < spriteRenderers.Length; m++)
			{
				if (Object.op_Implicit((Object)(object)spriteRenderers[m]))
				{
					((Renderer)spriteRenderers[m]).sharedMaterial = cropSetter.GetCurrentMaterial(cropSetter.materialIndex);
				}
			}
		}
		else
		{
			if (spriteRenderers == null)
			{
				yield break;
			}
			for (int n = 0; n < spriteRenderers.Length; n++)
			{
				if (Object.op_Implicit((Object)(object)spriteRenderers[n]))
				{
					((Renderer)spriteRenderers[n]).sharedMaterial = HKIODKOAHPE;
				}
			}
		}
	}

	public void HIIDKJAMFCD(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 1351f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(ICLNIGOAECJ(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	private void FJKKLJHHMLC(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("SetAnimatorObjectFloatRPC") || ((Component)LGGCFCHOOMB).CompareTag("Items/item_description_637") || ((Component)LGGCFCHOOMB).CompareTag("Request begin replay") || ((Component)LGGCFCHOOMB).CompareTag("torchCount=[{0}-{1}], minConnections={2}") || ((Component)LGGCFCHOOMB).CompareTag("F2"))
		{
			DMIGFCCEDAD(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 1007f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("Accept"))
		{
			HOIOFIPDDNJ(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(1639f, 950f));
		}
	}

	private IEnumerator ADMJNIKOMFM(float NCPGNLOJGAF = 1f, float HDDDOBNHONC = 1f)
	{
		return new OAFCPMCHCGO(1)
		{
			_003C_003E4__this = this,
			x = NCPGNLOJGAF,
			amplitudeMultiplier = HDDDOBNHONC
		};
	}

	public void CBLFBEOCLBE(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 1167f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(NBLAJLKDIBG(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	public void NHICFLMMDKL(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 388f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(ADMJNIKOMFM(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	public void HIFAIPEHAGA()
	{
		herb = ((Component)this).GetComponentInParent<Herb>();
	}

	private void DKGKGFAEGBD(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("\n<color=#822F00>") || ((Component)LGGCFCHOOMB).CompareTag(" CloseUI ConstructionUI") || ((Component)LGGCFCHOOMB).CompareTag("Minigame") || ((Component)LGGCFCHOOMB).CompareTag("Items/item_name_1073") || ((Component)LGGCFCHOOMB).CompareTag("Custom lobby data (photon room code): "))
		{
			CIDKOLKILDB(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 1128f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("NewCharacters/"))
		{
			KIMLEJCHPMD(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(1761f, 875f));
		}
	}

	private void OnTriggerEnter2D(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("Player") || ((Component)LGGCFCHOOMB).CompareTag("Player2") || ((Component)LGGCFCHOOMB).CompareTag("Animal") || ((Component)LGGCFCHOOMB).CompareTag("NPC") || ((Component)LGGCFCHOOMB).CompareTag("OnlinePlayer"))
		{
			StartAnimation(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("HitCollider"))
		{
			StartAnimation(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(1f, 2f));
		}
	}

	private IEnumerator ICAFJKNDBDA(float NCPGNLOJGAF = 1f, float HDDDOBNHONC = 1f)
	{
		return new OAFCPMCHCGO(1)
		{
			_003C_003E4__this = this,
			x = NCPGNLOJGAF,
			amplitudeMultiplier = HDDDOBNHONC
		};
	}

	private void CAOKPIIFHBJ()
	{
		startTime = 1874f;
		movement = 1642f;
		theta = 140f;
		currentAmplitude = 1246f;
		if ((Object)(object)herb != (Object)null)
		{
			HKIODKOAHPE = herb.defaultMaterial;
		}
		else if ((Object)(object)cropSetter != (Object)null)
		{
			HKIODKOAHPE = cropSetter.GetCurrentMaterial(cropSetter.materialIndex);
		}
		else if (spriteRenderers != null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
	}

	public void NJNJKDMBNEP(float NCPGNLOJGAF, float HDDDOBNHONC = 1f)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude * HDDDOBNHONC / 1652f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(NNHJCOCONBK(NCPGNLOJGAF, HDDDOBNHONC));
		}
	}

	public void DAOIJCHEIIF()
	{
		herb = ((Component)this).GetComponentInParent<Herb>();
	}

	private IEnumerator AJJACDFIJEO(float NCPGNLOJGAF = 1f, float HDDDOBNHONC = 1f)
	{
		return new OAFCPMCHCGO(1)
		{
			_003C_003E4__this = this,
			x = NCPGNLOJGAF,
			amplitudeMultiplier = HDDDOBNHONC
		};
	}

	private void BGFCHEIOKOG()
	{
		startTime = 1474f;
		movement = 1990f;
		theta = 1255f;
		currentAmplitude = 368f;
		if ((Object)(object)herb != (Object)null)
		{
			HKIODKOAHPE = herb.defaultMaterial;
		}
		else if ((Object)(object)cropSetter != (Object)null)
		{
			HKIODKOAHPE = cropSetter.GetCurrentMaterial(cropSetter.materialIndex, CBIPENPIJPC: true);
		}
		else if (spriteRenderers != null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
	}

	private void FADCNMKMAFI(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("AceT_Quest") || ((Component)LGGCFCHOOMB).CompareTag("ReceiveStopPlayingChallenge") || ((Component)LGGCFCHOOMB).CompareTag("Juicy") || ((Component)LGGCFCHOOMB).CompareTag("Roll") || ((Component)LGGCFCHOOMB).CompareTag("Interact"))
		{
			NKJKJKNFCKB(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 1844f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("Player2"))
		{
			KIMLEJCHPMD(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(128f, 1874f));
		}
	}

	private void JCFDPDLMOME(Collider2D LGGCFCHOOMB)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag(" totalMsgs: ") || ((Component)LGGCFCHOOMB).CompareTag(" destroyed by ") || ((Component)LGGCFCHOOMB).CompareTag("ReceiveCursorMove") || ((Component)LGGCFCHOOMB).CompareTag("Mai/Talk{0}") || ((Component)LGGCFCHOOMB).CompareTag("BarkActor"))
		{
			DMIGFCCEDAD(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, 984f);
		}
		else if (((Component)LGGCFCHOOMB).CompareTag("banquetevent"))
		{
			IFHLKCEHPEG(((Component)LGGCFCHOOMB).transform.position.x - ((Component)this).transform.position.x, Random.Range(274f, 485f));
		}
	}
}
