using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChoppingTreeAnimator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class MCNPLIEDJGE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChoppingTreeAnimator _003C_003E4__this;

		public bool fallRight;

		private int _003Ci_003E5__2;

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
		public MCNPLIEDJGE(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_052a: Unknown result type (might be due to invalid IL or missing references)
			//IL_052f: Unknown result type (might be due to invalid IL or missing references)
			//IL_035f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0568: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ChoppingTreeAnimator choppingTreeAnimator = _003C_003E4__this;
			MinMaxCurve rateOverTime;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003Ci_003E5__2 = 0;
				goto IL_0093;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0070;
			case 2:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_0093:
				if (_003Ci_003E5__2 < choppingTreeAnimator.choppingParticles.Length)
				{
					if (choppingTreeAnimator.choppingParticles[_003Ci_003E5__2].activeSelf)
					{
						choppingTreeAnimator.choppingParticles[_003Ci_003E5__2].SetActive(false);
						_003C_003E2__current = null;
						_003C_003E1__state = 1;
						return true;
					}
					goto IL_0070;
				}
				choppingTreeAnimator.currentAmplitude = choppingTreeAnimator.amplitude;
				if (SeasonManager.EECEKHKAAIH == Season.Winter)
				{
					for (int i = 0; i < choppingTreeAnimator.leavesParticles.Length; i++)
					{
						choppingTreeAnimator.HHMEKONGKCN[i] = choppingTreeAnimator.particleIntensity * 15f;
					}
				}
				else
				{
					for (int j = 0; j < choppingTreeAnimator.leavesParticles.Length; j++)
					{
						choppingTreeAnimator.HHMEKONGKCN[j] = choppingTreeAnimator.particleIntensity;
					}
				}
				rateOverTime = ((EmissionModule)(ref choppingTreeAnimator.INHPFKMEMFB[0])).rateOverTime;
				if (SeasonManager.EECEKHKAAIH == Season.Winter)
				{
					for (int k = 0; k < choppingTreeAnimator.spriteRenderers.Length; k++)
					{
						((Renderer)choppingTreeAnimator.spriteRenderers[k]).material.SetFloat(ShaderReferences.noiseMultiplier, 0.05f);
					}
				}
				break;
				IL_0070:
				choppingTreeAnimator.choppingParticles[_003Ci_003E5__2].SetActive(true);
				_003Ci_003E5__2++;
				goto IL_0093;
			}
			if (choppingTreeAnimator.currentAmplitude > 0.01f)
			{
				if (SeasonManager.EECEKHKAAIH == Season.Winter && choppingTreeAnimator.currentAmplitude < choppingTreeAnimator.amplitude / 6f)
				{
					for (int l = 0; l < choppingTreeAnimator.spriteRenderers.Length; l++)
					{
						((Renderer)choppingTreeAnimator.spriteRenderers[l]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(0f, 0.05f, choppingTreeAnimator.currentAmplitude / (choppingTreeAnimator.amplitude / 6f)));
					}
				}
				choppingTreeAnimator.theta = (Time.timeSinceLevelLoad - choppingTreeAnimator.startTime) / choppingTreeAnimator.period;
				choppingTreeAnimator.movement = choppingTreeAnimator.currentAmplitude * Mathf.Sin(choppingTreeAnimator.theta);
				if (fallRight)
				{
					choppingTreeAnimator.movement *= -1f;
				}
				for (int m = 0; m < choppingTreeAnimator.spriteRenderers.Length; m++)
				{
					if ((Object)(object)choppingTreeAnimator.spriteRenderers[m] != (Object)null)
					{
						((Renderer)choppingTreeAnimator.spriteRenderers[m]).material.SetFloat(ShaderReferences.swishEffect, choppingTreeAnimator.movement + choppingTreeAnimator.tree.defaultMaterial.GetFloat(ShaderReferences.swishEffect));
					}
				}
				choppingTreeAnimator.currentAmplitude = Mathf.Lerp(choppingTreeAnimator.currentAmplitude, 0f, choppingTreeAnimator.amplitudeRegression * Time.deltaTime);
				if (!choppingTreeAnimator.tree.HasBeenChopped())
				{
					for (int n = 0; n < choppingTreeAnimator.leavesParticles.Length; n++)
					{
						if (((Component)choppingTreeAnimator.leavesParticles[n]).gameObject.activeInHierarchy)
						{
							rateOverTime = ((EmissionModule)(ref choppingTreeAnimator.INHPFKMEMFB[n])).rateOverTime;
							if (SeasonManager.EECEKHKAAIH == Season.Winter)
							{
								choppingTreeAnimator.HHMEKONGKCN[n] = Mathf.Lerp(choppingTreeAnimator.HHMEKONGKCN[n], choppingTreeAnimator.AOLGMOHOJMI[n], choppingTreeAnimator.amplitudeRegression * Time.deltaTime * 10f);
							}
							else
							{
								choppingTreeAnimator.HHMEKONGKCN[n] = Mathf.Lerp(choppingTreeAnimator.HHMEKONGKCN[n], choppingTreeAnimator.AOLGMOHOJMI[n], choppingTreeAnimator.amplitudeRegression * Time.deltaTime);
							}
							((MinMaxCurve)(ref rateOverTime)).constant = choppingTreeAnimator.HHMEKONGKCN[n];
							((EmissionModule)(ref choppingTreeAnimator.INHPFKMEMFB[n])).rateOverTime = rateOverTime;
						}
					}
				}
				else if (choppingTreeAnimator.spriteRenderers.Length != 0)
				{
					choppingTreeAnimator.LDBOIIILOIC = ((Renderer)choppingTreeAnimator.spriteRenderers[0]).material.GetFloat(ShaderReferences.noiseMultiplier);
					for (int num2 = 0; num2 < choppingTreeAnimator.spriteRenderers.Length; num2++)
					{
						if ((Object)(object)choppingTreeAnimator.spriteRenderers[num2] != (Object)null)
						{
							((Renderer)choppingTreeAnimator.spriteRenderers[num2]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(choppingTreeAnimator.LDBOIIILOIC, 0f, 2f * Time.deltaTime));
						}
					}
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			if (SeasonManager.EECEKHKAAIH == Season.Winter)
			{
				for (int num3 = 0; num3 < choppingTreeAnimator.spriteRenderers.Length; num3++)
				{
					((Renderer)choppingTreeAnimator.spriteRenderers[num3]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
				}
			}
			for (int num4 = 0; num4 < choppingTreeAnimator.choppingParticles.Length; num4++)
			{
				choppingTreeAnimator.choppingParticles[num4].SetActive(false);
			}
			choppingTreeAnimator.LDKHPOBCNFC = null;
			if (!choppingTreeAnimator.tree.HasBeenChopped())
			{
				for (int num5 = 0; num5 < choppingTreeAnimator.spriteRenderers.Length; num5++)
				{
					((Renderer)choppingTreeAnimator.spriteRenderers[num5]).sharedMaterial = choppingTreeAnimator.tree.defaultMaterial;
				}
			}
			else
			{
				for (int num6 = 0; num6 < choppingTreeAnimator.spriteRenderers.Length; num6++)
				{
					((Renderer)choppingTreeAnimator.spriteRenderers[num6]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
				}
			}
			for (int num7 = 0; num7 < choppingTreeAnimator.leavesParticles.Length; num7++)
			{
				if (((Component)choppingTreeAnimator.leavesParticles[num7]).gameObject.activeInHierarchy)
				{
					rateOverTime = ((EmissionModule)(ref choppingTreeAnimator.INHPFKMEMFB[num7])).rateOverTime;
					if (choppingTreeAnimator.tree.HasBeenChopped())
					{
						((MinMaxCurve)(ref rateOverTime)).constant = 0f;
					}
					else
					{
						((MinMaxCurve)(ref rateOverTime)).constant = choppingTreeAnimator.AOLGMOHOJMI[num7];
					}
					((EmissionModule)(ref choppingTreeAnimator.INHPFKMEMFB[num7])).rateOverTime = rateOverTime;
				}
			}
			return false;
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

	public Tree tree;

	public SpriteRenderer[] spriteRenderers;

	public ParticleSystem[] leavesParticles;

	public GameObject[] choppingParticles;

	[Space(20f)]
	public float particleIntensity = 10f;

	public float amplitude = 10f;

	public float period = 5f;

	public float amplitudeRegression = 2.5f;

	public float startTime;

	public float movement;

	public float theta;

	public float currentAmplitude;

	private Coroutine LDKHPOBCNFC;

	private EmissionModule[] INHPFKMEMFB;

	private float[] HHMEKONGKCN;

	private float[] AOLGMOHOJMI;

	private float LDBOIIILOIC;

	public void EOPABLCKMPK(bool DBGDJFMBJCK)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude / 642f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(EHEBBFJAPGM(DBGDJFMBJCK));
		}
	}

	private void Start()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 0f;
		movement = 0f;
		theta = 0f;
		currentAmplitude = 0f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 0; i < leavesParticles.Length; i++)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	private IEnumerator EHEBBFJAPGM(bool DBGDJFMBJCK)
	{
		return new MCNPLIEDJGE(1)
		{
			_003C_003E4__this = this,
			fallRight = DBGDJFMBJCK
		};
	}

	private void BNIKICAEIND()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 1110f;
		movement = 1402f;
		theta = 279f;
		currentAmplitude = 1973f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 0; i < leavesParticles.Length; i += 0)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	public void CIODOEBIKNP()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	private IEnumerator BCLCIIJHCOM(bool DBGDJFMBJCK)
	{
		return new MCNPLIEDJGE(1)
		{
			_003C_003E4__this = this,
			fallRight = DBGDJFMBJCK
		};
	}

	public void DHILJFOMMIF()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	public void HIIDKJAMFCD(bool DBGDJFMBJCK)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude / 134f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(DAMHPOFCFLO(DBGDJFMBJCK));
		}
	}

	private IEnumerator DAMHPOFCFLO(bool DBGDJFMBJCK)
	{
		return new MCNPLIEDJGE(1)
		{
			_003C_003E4__this = this,
			fallRight = DBGDJFMBJCK
		};
	}

	private IEnumerator EPFBDNLKJKP(bool DBGDJFMBJCK)
	{
		return new MCNPLIEDJGE(1)
		{
			_003C_003E4__this = this,
			fallRight = DBGDJFMBJCK
		};
	}

	private void JECHMEFJABD()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 1047f;
		movement = 904f;
		theta = 416f;
		currentAmplitude = 1517f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 1; i < leavesParticles.Length; i++)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	public void AIALDNIHOKC()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	public void CHCOEFPHJLK()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	private IEnumerator FIGKMLDCLKC(bool DBGDJFMBJCK)
	{
		for (int i = 0; i < choppingParticles.Length; i++)
		{
			if (choppingParticles[i].activeSelf)
			{
				choppingParticles[i].SetActive(false);
				yield return null;
			}
			choppingParticles[i].SetActive(true);
		}
		currentAmplitude = amplitude;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int j = 0; j < leavesParticles.Length; j++)
			{
				HHMEKONGKCN[j] = particleIntensity * 15f;
			}
		}
		else
		{
			for (int k = 0; k < leavesParticles.Length; k++)
			{
				HHMEKONGKCN[k] = particleIntensity;
			}
		}
		MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[0])).rateOverTime;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int l = 0; l < spriteRenderers.Length; l++)
			{
				((Renderer)spriteRenderers[l]).material.SetFloat(ShaderReferences.noiseMultiplier, 0.05f);
			}
		}
		while (currentAmplitude > 0.01f)
		{
			if (SeasonManager.EECEKHKAAIH == Season.Winter && currentAmplitude < amplitude / 6f)
			{
				for (int m = 0; m < spriteRenderers.Length; m++)
				{
					((Renderer)spriteRenderers[m]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(0f, 0.05f, currentAmplitude / (amplitude / 6f)));
				}
			}
			theta = (Time.timeSinceLevelLoad - startTime) / period;
			movement = currentAmplitude * Mathf.Sin(theta);
			if (DBGDJFMBJCK)
			{
				movement *= -1f;
			}
			for (int n = 0; n < spriteRenderers.Length; n++)
			{
				if ((Object)(object)spriteRenderers[n] != (Object)null)
				{
					((Renderer)spriteRenderers[n]).material.SetFloat(ShaderReferences.swishEffect, movement + tree.defaultMaterial.GetFloat(ShaderReferences.swishEffect));
				}
			}
			currentAmplitude = Mathf.Lerp(currentAmplitude, 0f, amplitudeRegression * Time.deltaTime);
			if (!tree.HasBeenChopped())
			{
				for (int num = 0; num < leavesParticles.Length; num++)
				{
					if (((Component)leavesParticles[num]).gameObject.activeInHierarchy)
					{
						rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime;
						if (SeasonManager.EECEKHKAAIH == Season.Winter)
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime * 10f);
						}
						else
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime);
						}
						((MinMaxCurve)(ref rateOverTime)).constant = HHMEKONGKCN[num];
						((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime = rateOverTime;
					}
				}
			}
			else if (spriteRenderers.Length != 0)
			{
				LDBOIIILOIC = ((Renderer)spriteRenderers[0]).material.GetFloat(ShaderReferences.noiseMultiplier);
				for (int num2 = 0; num2 < spriteRenderers.Length; num2++)
				{
					if ((Object)(object)spriteRenderers[num2] != (Object)null)
					{
						((Renderer)spriteRenderers[num2]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(LDBOIIILOIC, 0f, 2f * Time.deltaTime));
					}
				}
			}
			yield return null;
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int num3 = 0; num3 < spriteRenderers.Length; num3++)
			{
				((Renderer)spriteRenderers[num3]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num4 = 0; num4 < choppingParticles.Length; num4++)
		{
			choppingParticles[num4].SetActive(false);
		}
		LDKHPOBCNFC = null;
		if (!tree.HasBeenChopped())
		{
			for (int num5 = 0; num5 < spriteRenderers.Length; num5++)
			{
				((Renderer)spriteRenderers[num5]).sharedMaterial = tree.defaultMaterial;
			}
		}
		else
		{
			for (int num6 = 0; num6 < spriteRenderers.Length; num6++)
			{
				((Renderer)spriteRenderers[num6]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num7 = 0; num7 < leavesParticles.Length; num7++)
		{
			if (((Component)leavesParticles[num7]).gameObject.activeInHierarchy)
			{
				rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime;
				if (tree.HasBeenChopped())
				{
					((MinMaxCurve)(ref rateOverTime)).constant = 0f;
				}
				else
				{
					((MinMaxCurve)(ref rateOverTime)).constant = AOLGMOHOJMI[num7];
				}
				((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime = rateOverTime;
			}
		}
	}

	public void NMMPHLPLJKE()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	public void IFEOFJLEBJI()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	public void LinkVariables()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	private IEnumerator DEFPOCBNLAP(bool DBGDJFMBJCK)
	{
		for (int i = 0; i < choppingParticles.Length; i++)
		{
			if (choppingParticles[i].activeSelf)
			{
				choppingParticles[i].SetActive(false);
				yield return null;
			}
			choppingParticles[i].SetActive(true);
		}
		currentAmplitude = amplitude;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int j = 0; j < leavesParticles.Length; j++)
			{
				HHMEKONGKCN[j] = particleIntensity * 15f;
			}
		}
		else
		{
			for (int k = 0; k < leavesParticles.Length; k++)
			{
				HHMEKONGKCN[k] = particleIntensity;
			}
		}
		MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[0])).rateOverTime;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int l = 0; l < spriteRenderers.Length; l++)
			{
				((Renderer)spriteRenderers[l]).material.SetFloat(ShaderReferences.noiseMultiplier, 0.05f);
			}
		}
		while (currentAmplitude > 0.01f)
		{
			if (SeasonManager.EECEKHKAAIH == Season.Winter && currentAmplitude < amplitude / 6f)
			{
				for (int m = 0; m < spriteRenderers.Length; m++)
				{
					((Renderer)spriteRenderers[m]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(0f, 0.05f, currentAmplitude / (amplitude / 6f)));
				}
			}
			theta = (Time.timeSinceLevelLoad - startTime) / period;
			movement = currentAmplitude * Mathf.Sin(theta);
			if (DBGDJFMBJCK)
			{
				movement *= -1f;
			}
			for (int n = 0; n < spriteRenderers.Length; n++)
			{
				if ((Object)(object)spriteRenderers[n] != (Object)null)
				{
					((Renderer)spriteRenderers[n]).material.SetFloat(ShaderReferences.swishEffect, movement + tree.defaultMaterial.GetFloat(ShaderReferences.swishEffect));
				}
			}
			currentAmplitude = Mathf.Lerp(currentAmplitude, 0f, amplitudeRegression * Time.deltaTime);
			if (!tree.HasBeenChopped())
			{
				for (int num = 0; num < leavesParticles.Length; num++)
				{
					if (((Component)leavesParticles[num]).gameObject.activeInHierarchy)
					{
						rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime;
						if (SeasonManager.EECEKHKAAIH == Season.Winter)
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime * 10f);
						}
						else
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime);
						}
						((MinMaxCurve)(ref rateOverTime)).constant = HHMEKONGKCN[num];
						((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime = rateOverTime;
					}
				}
			}
			else if (spriteRenderers.Length != 0)
			{
				LDBOIIILOIC = ((Renderer)spriteRenderers[0]).material.GetFloat(ShaderReferences.noiseMultiplier);
				for (int num2 = 0; num2 < spriteRenderers.Length; num2++)
				{
					if ((Object)(object)spriteRenderers[num2] != (Object)null)
					{
						((Renderer)spriteRenderers[num2]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(LDBOIIILOIC, 0f, 2f * Time.deltaTime));
					}
				}
			}
			yield return null;
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int num3 = 0; num3 < spriteRenderers.Length; num3++)
			{
				((Renderer)spriteRenderers[num3]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num4 = 0; num4 < choppingParticles.Length; num4++)
		{
			choppingParticles[num4].SetActive(false);
		}
		LDKHPOBCNFC = null;
		if (!tree.HasBeenChopped())
		{
			for (int num5 = 0; num5 < spriteRenderers.Length; num5++)
			{
				((Renderer)spriteRenderers[num5]).sharedMaterial = tree.defaultMaterial;
			}
		}
		else
		{
			for (int num6 = 0; num6 < spriteRenderers.Length; num6++)
			{
				((Renderer)spriteRenderers[num6]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num7 = 0; num7 < leavesParticles.Length; num7++)
		{
			if (((Component)leavesParticles[num7]).gameObject.activeInHierarchy)
			{
				rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime;
				if (tree.HasBeenChopped())
				{
					((MinMaxCurve)(ref rateOverTime)).constant = 0f;
				}
				else
				{
					((MinMaxCurve)(ref rateOverTime)).constant = AOLGMOHOJMI[num7];
				}
				((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime = rateOverTime;
			}
		}
	}

	public void FDGLCGJFKPG(bool DBGDJFMBJCK)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude / 186f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(KPFPGJDOMHI(DBGDJFMBJCK));
		}
	}

	private void HCEDMLJNOBL()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 399f;
		movement = 1987f;
		theta = 998f;
		currentAmplitude = 902f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 0; i < leavesParticles.Length; i++)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	private IEnumerator MEBGJBOEHBB(bool DBGDJFMBJCK)
	{
		for (int i = 0; i < choppingParticles.Length; i++)
		{
			if (choppingParticles[i].activeSelf)
			{
				choppingParticles[i].SetActive(false);
				yield return null;
			}
			choppingParticles[i].SetActive(true);
		}
		currentAmplitude = amplitude;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int j = 0; j < leavesParticles.Length; j++)
			{
				HHMEKONGKCN[j] = particleIntensity * 15f;
			}
		}
		else
		{
			for (int k = 0; k < leavesParticles.Length; k++)
			{
				HHMEKONGKCN[k] = particleIntensity;
			}
		}
		MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[0])).rateOverTime;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int l = 0; l < spriteRenderers.Length; l++)
			{
				((Renderer)spriteRenderers[l]).material.SetFloat(ShaderReferences.noiseMultiplier, 0.05f);
			}
		}
		while (currentAmplitude > 0.01f)
		{
			if (SeasonManager.EECEKHKAAIH == Season.Winter && currentAmplitude < amplitude / 6f)
			{
				for (int m = 0; m < spriteRenderers.Length; m++)
				{
					((Renderer)spriteRenderers[m]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(0f, 0.05f, currentAmplitude / (amplitude / 6f)));
				}
			}
			theta = (Time.timeSinceLevelLoad - startTime) / period;
			movement = currentAmplitude * Mathf.Sin(theta);
			if (DBGDJFMBJCK)
			{
				movement *= -1f;
			}
			for (int n = 0; n < spriteRenderers.Length; n++)
			{
				if ((Object)(object)spriteRenderers[n] != (Object)null)
				{
					((Renderer)spriteRenderers[n]).material.SetFloat(ShaderReferences.swishEffect, movement + tree.defaultMaterial.GetFloat(ShaderReferences.swishEffect));
				}
			}
			currentAmplitude = Mathf.Lerp(currentAmplitude, 0f, amplitudeRegression * Time.deltaTime);
			if (!tree.HasBeenChopped())
			{
				for (int num = 0; num < leavesParticles.Length; num++)
				{
					if (((Component)leavesParticles[num]).gameObject.activeInHierarchy)
					{
						rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime;
						if (SeasonManager.EECEKHKAAIH == Season.Winter)
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime * 10f);
						}
						else
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime);
						}
						((MinMaxCurve)(ref rateOverTime)).constant = HHMEKONGKCN[num];
						((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime = rateOverTime;
					}
				}
			}
			else if (spriteRenderers.Length != 0)
			{
				LDBOIIILOIC = ((Renderer)spriteRenderers[0]).material.GetFloat(ShaderReferences.noiseMultiplier);
				for (int num2 = 0; num2 < spriteRenderers.Length; num2++)
				{
					if ((Object)(object)spriteRenderers[num2] != (Object)null)
					{
						((Renderer)spriteRenderers[num2]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(LDBOIIILOIC, 0f, 2f * Time.deltaTime));
					}
				}
			}
			yield return null;
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int num3 = 0; num3 < spriteRenderers.Length; num3++)
			{
				((Renderer)spriteRenderers[num3]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num4 = 0; num4 < choppingParticles.Length; num4++)
		{
			choppingParticles[num4].SetActive(false);
		}
		LDKHPOBCNFC = null;
		if (!tree.HasBeenChopped())
		{
			for (int num5 = 0; num5 < spriteRenderers.Length; num5++)
			{
				((Renderer)spriteRenderers[num5]).sharedMaterial = tree.defaultMaterial;
			}
		}
		else
		{
			for (int num6 = 0; num6 < spriteRenderers.Length; num6++)
			{
				((Renderer)spriteRenderers[num6]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num7 = 0; num7 < leavesParticles.Length; num7++)
		{
			if (((Component)leavesParticles[num7]).gameObject.activeInHierarchy)
			{
				rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime;
				if (tree.HasBeenChopped())
				{
					((MinMaxCurve)(ref rateOverTime)).constant = 0f;
				}
				else
				{
					((MinMaxCurve)(ref rateOverTime)).constant = AOLGMOHOJMI[num7];
				}
				((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime = rateOverTime;
			}
		}
	}

	private void GHPFCKGMLDA()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 449f;
		movement = 1810f;
		theta = 1387f;
		currentAmplitude = 896f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 1; i < leavesParticles.Length; i++)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	private void BELOIFKPNMM()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 648f;
		movement = 338f;
		theta = 669f;
		currentAmplitude = 762f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 1; i < leavesParticles.Length; i++)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	public void KFPCAJDCMDH()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	public void DNHNNCPMCAL()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	private IEnumerator JKOGIGLEIDI(bool DBGDJFMBJCK)
	{
		return new MCNPLIEDJGE(1)
		{
			_003C_003E4__this = this,
			fallRight = DBGDJFMBJCK
		};
	}

	public void PHBOGNNMNME()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	public void StartAnimation(bool DBGDJFMBJCK)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude / 2f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(JHEHFPDDHAI(DBGDJFMBJCK));
		}
	}

	private void IFHLGOMBACP()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 1525f;
		movement = 1293f;
		theta = 1563f;
		currentAmplitude = 924f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 0; i < leavesParticles.Length; i++)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	private void FKPNIHJGFBJ()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 1008f;
		movement = 507f;
		theta = 1898f;
		currentAmplitude = 1632f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 0; i < leavesParticles.Length; i += 0)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	private void DCKKIDMJKJM()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 1605f;
		movement = 129f;
		theta = 75f;
		currentAmplitude = 1859f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 0; i < leavesParticles.Length; i += 0)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	private IEnumerator JHEHFPDDHAI(bool DBGDJFMBJCK)
	{
		for (int i = 0; i < choppingParticles.Length; i++)
		{
			if (choppingParticles[i].activeSelf)
			{
				choppingParticles[i].SetActive(false);
				yield return null;
			}
			choppingParticles[i].SetActive(true);
		}
		currentAmplitude = amplitude;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int j = 0; j < leavesParticles.Length; j++)
			{
				HHMEKONGKCN[j] = particleIntensity * 15f;
			}
		}
		else
		{
			for (int k = 0; k < leavesParticles.Length; k++)
			{
				HHMEKONGKCN[k] = particleIntensity;
			}
		}
		MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[0])).rateOverTime;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int l = 0; l < spriteRenderers.Length; l++)
			{
				((Renderer)spriteRenderers[l]).material.SetFloat(ShaderReferences.noiseMultiplier, 0.05f);
			}
		}
		while (currentAmplitude > 0.01f)
		{
			if (SeasonManager.EECEKHKAAIH == Season.Winter && currentAmplitude < amplitude / 6f)
			{
				for (int m = 0; m < spriteRenderers.Length; m++)
				{
					((Renderer)spriteRenderers[m]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(0f, 0.05f, currentAmplitude / (amplitude / 6f)));
				}
			}
			theta = (Time.timeSinceLevelLoad - startTime) / period;
			movement = currentAmplitude * Mathf.Sin(theta);
			if (DBGDJFMBJCK)
			{
				movement *= -1f;
			}
			for (int n = 0; n < spriteRenderers.Length; n++)
			{
				if ((Object)(object)spriteRenderers[n] != (Object)null)
				{
					((Renderer)spriteRenderers[n]).material.SetFloat(ShaderReferences.swishEffect, movement + tree.defaultMaterial.GetFloat(ShaderReferences.swishEffect));
				}
			}
			currentAmplitude = Mathf.Lerp(currentAmplitude, 0f, amplitudeRegression * Time.deltaTime);
			if (!tree.HasBeenChopped())
			{
				for (int num = 0; num < leavesParticles.Length; num++)
				{
					if (((Component)leavesParticles[num]).gameObject.activeInHierarchy)
					{
						rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime;
						if (SeasonManager.EECEKHKAAIH == Season.Winter)
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime * 10f);
						}
						else
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime);
						}
						((MinMaxCurve)(ref rateOverTime)).constant = HHMEKONGKCN[num];
						((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime = rateOverTime;
					}
				}
			}
			else if (spriteRenderers.Length != 0)
			{
				LDBOIIILOIC = ((Renderer)spriteRenderers[0]).material.GetFloat(ShaderReferences.noiseMultiplier);
				for (int num2 = 0; num2 < spriteRenderers.Length; num2++)
				{
					if ((Object)(object)spriteRenderers[num2] != (Object)null)
					{
						((Renderer)spriteRenderers[num2]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(LDBOIIILOIC, 0f, 2f * Time.deltaTime));
					}
				}
			}
			yield return null;
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int num3 = 0; num3 < spriteRenderers.Length; num3++)
			{
				((Renderer)spriteRenderers[num3]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num4 = 0; num4 < choppingParticles.Length; num4++)
		{
			choppingParticles[num4].SetActive(false);
		}
		LDKHPOBCNFC = null;
		if (!tree.HasBeenChopped())
		{
			for (int num5 = 0; num5 < spriteRenderers.Length; num5++)
			{
				((Renderer)spriteRenderers[num5]).sharedMaterial = tree.defaultMaterial;
			}
		}
		else
		{
			for (int num6 = 0; num6 < spriteRenderers.Length; num6++)
			{
				((Renderer)spriteRenderers[num6]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num7 = 0; num7 < leavesParticles.Length; num7++)
		{
			if (((Component)leavesParticles[num7]).gameObject.activeInHierarchy)
			{
				rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime;
				if (tree.HasBeenChopped())
				{
					((MinMaxCurve)(ref rateOverTime)).constant = 0f;
				}
				else
				{
					((MinMaxCurve)(ref rateOverTime)).constant = AOLGMOHOJMI[num7];
				}
				((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime = rateOverTime;
			}
		}
	}

	private void GJMLHECPGBP()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 283f;
		movement = 112f;
		theta = 942f;
		currentAmplitude = 1639f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 0; i < leavesParticles.Length; i += 0)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	private IEnumerator GCMJIBPIGNM(bool DBGDJFMBJCK)
	{
		return new MCNPLIEDJGE(1)
		{
			_003C_003E4__this = this,
			fallRight = DBGDJFMBJCK
		};
	}

	private void CMLLBIDFNEB()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 1346f;
		movement = 1868f;
		theta = 969f;
		currentAmplitude = 1636f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 1; i < leavesParticles.Length; i += 0)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	public void MEHOODJODEG()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	private IEnumerator GOBAEKBGNDG(bool DBGDJFMBJCK)
	{
		return new MCNPLIEDJGE(1)
		{
			_003C_003E4__this = this,
			fallRight = DBGDJFMBJCK
		};
	}

	private void OIAHJHNPPCO()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 174f;
		movement = 1994f;
		theta = 1866f;
		currentAmplitude = 920f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 1; i < leavesParticles.Length; i++)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	public void AEOLHEDOGIH(bool DBGDJFMBJCK)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude / 1411f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(FIGKMLDCLKC(DBGDJFMBJCK));
		}
	}

	public void EDKGHDOOPNL()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	public void OMOMGNPCACA(bool DBGDJFMBJCK)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude / 401f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(CNNKJGGJEFJ(DBGDJFMBJCK));
		}
	}

	private IEnumerator NNHJCOCONBK(bool DBGDJFMBJCK)
	{
		for (int i = 0; i < choppingParticles.Length; i++)
		{
			if (choppingParticles[i].activeSelf)
			{
				choppingParticles[i].SetActive(false);
				yield return null;
			}
			choppingParticles[i].SetActive(true);
		}
		currentAmplitude = amplitude;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int j = 0; j < leavesParticles.Length; j++)
			{
				HHMEKONGKCN[j] = particleIntensity * 15f;
			}
		}
		else
		{
			for (int k = 0; k < leavesParticles.Length; k++)
			{
				HHMEKONGKCN[k] = particleIntensity;
			}
		}
		MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[0])).rateOverTime;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int l = 0; l < spriteRenderers.Length; l++)
			{
				((Renderer)spriteRenderers[l]).material.SetFloat(ShaderReferences.noiseMultiplier, 0.05f);
			}
		}
		while (currentAmplitude > 0.01f)
		{
			if (SeasonManager.EECEKHKAAIH == Season.Winter && currentAmplitude < amplitude / 6f)
			{
				for (int m = 0; m < spriteRenderers.Length; m++)
				{
					((Renderer)spriteRenderers[m]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(0f, 0.05f, currentAmplitude / (amplitude / 6f)));
				}
			}
			theta = (Time.timeSinceLevelLoad - startTime) / period;
			movement = currentAmplitude * Mathf.Sin(theta);
			if (DBGDJFMBJCK)
			{
				movement *= -1f;
			}
			for (int n = 0; n < spriteRenderers.Length; n++)
			{
				if ((Object)(object)spriteRenderers[n] != (Object)null)
				{
					((Renderer)spriteRenderers[n]).material.SetFloat(ShaderReferences.swishEffect, movement + tree.defaultMaterial.GetFloat(ShaderReferences.swishEffect));
				}
			}
			currentAmplitude = Mathf.Lerp(currentAmplitude, 0f, amplitudeRegression * Time.deltaTime);
			if (!tree.HasBeenChopped())
			{
				for (int num = 0; num < leavesParticles.Length; num++)
				{
					if (((Component)leavesParticles[num]).gameObject.activeInHierarchy)
					{
						rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime;
						if (SeasonManager.EECEKHKAAIH == Season.Winter)
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime * 10f);
						}
						else
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime);
						}
						((MinMaxCurve)(ref rateOverTime)).constant = HHMEKONGKCN[num];
						((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime = rateOverTime;
					}
				}
			}
			else if (spriteRenderers.Length != 0)
			{
				LDBOIIILOIC = ((Renderer)spriteRenderers[0]).material.GetFloat(ShaderReferences.noiseMultiplier);
				for (int num2 = 0; num2 < spriteRenderers.Length; num2++)
				{
					if ((Object)(object)spriteRenderers[num2] != (Object)null)
					{
						((Renderer)spriteRenderers[num2]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(LDBOIIILOIC, 0f, 2f * Time.deltaTime));
					}
				}
			}
			yield return null;
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int num3 = 0; num3 < spriteRenderers.Length; num3++)
			{
				((Renderer)spriteRenderers[num3]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num4 = 0; num4 < choppingParticles.Length; num4++)
		{
			choppingParticles[num4].SetActive(false);
		}
		LDKHPOBCNFC = null;
		if (!tree.HasBeenChopped())
		{
			for (int num5 = 0; num5 < spriteRenderers.Length; num5++)
			{
				((Renderer)spriteRenderers[num5]).sharedMaterial = tree.defaultMaterial;
			}
		}
		else
		{
			for (int num6 = 0; num6 < spriteRenderers.Length; num6++)
			{
				((Renderer)spriteRenderers[num6]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num7 = 0; num7 < leavesParticles.Length; num7++)
		{
			if (((Component)leavesParticles[num7]).gameObject.activeInHierarchy)
			{
				rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime;
				if (tree.HasBeenChopped())
				{
					((MinMaxCurve)(ref rateOverTime)).constant = 0f;
				}
				else
				{
					((MinMaxCurve)(ref rateOverTime)).constant = AOLGMOHOJMI[num7];
				}
				((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime = rateOverTime;
			}
		}
	}

	public void NEAIDCNNLLN(bool DBGDJFMBJCK)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude / 270f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(JHEHFPDDHAI(DBGDJFMBJCK));
		}
	}

	private void FOHGHCPODBJ()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 1931f;
		movement = 1356f;
		theta = 1666f;
		currentAmplitude = 927f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 1; i < leavesParticles.Length; i += 0)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	private IEnumerator MFCKAIAOKED(bool DBGDJFMBJCK)
	{
		return new MCNPLIEDJGE(1)
		{
			_003C_003E4__this = this,
			fallRight = DBGDJFMBJCK
		};
	}

	private void CHIJGHPHCNA()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 291f;
		movement = 1879f;
		theta = 1154f;
		currentAmplitude = 56f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 1; i < leavesParticles.Length; i += 0)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	public void LMJKCPFOIDA(bool DBGDJFMBJCK)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude / 1212f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(MDBAAAEJJJP(DBGDJFMBJCK));
		}
	}

	public void NLALJJDGHPC()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	private void NFABFPFLNEE()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 308f;
		movement = 76f;
		theta = 960f;
		currentAmplitude = 877f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 0; i < leavesParticles.Length; i += 0)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	private void DMFMNEMDFNP()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 195f;
		movement = 1331f;
		theta = 405f;
		currentAmplitude = 1684f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 0; i < leavesParticles.Length; i += 0)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	private void MFMMHDPGCBO()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 1686f;
		movement = 484f;
		theta = 1751f;
		currentAmplitude = 714f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 1; i < leavesParticles.Length; i++)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	public void GFDNBOHPIIA(bool DBGDJFMBJCK)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude / 103f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(DNDAINCMLPK(DBGDJFMBJCK));
		}
	}

	public void HOKEPLNILAH(bool DBGDJFMBJCK)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude / 329f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(GCMJIBPIGNM(DBGDJFMBJCK));
		}
	}

	public void ELIFIGOAILK()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	private void PFLBPMIEKGF()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 126f;
		movement = 1621f;
		theta = 1629f;
		currentAmplitude = 897f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 1; i < leavesParticles.Length; i++)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	private IEnumerator CNNKJGGJEFJ(bool DBGDJFMBJCK)
	{
		return new MCNPLIEDJGE(1)
		{
			_003C_003E4__this = this,
			fallRight = DBGDJFMBJCK
		};
	}

	public void LEGMJOJIHHD(bool DBGDJFMBJCK)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude / 1565f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(EPFBDNLKJKP(DBGDJFMBJCK));
		}
	}

	private IEnumerator PKAFJLKIOAB(bool DBGDJFMBJCK)
	{
		return new MCNPLIEDJGE(1)
		{
			_003C_003E4__this = this,
			fallRight = DBGDJFMBJCK
		};
	}

	public void HPPGOFMNNPN()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	public void HHBFBMLNJMF(bool DBGDJFMBJCK)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude / 123f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(HFMNMKJDGAK(DBGDJFMBJCK));
		}
	}

	public void LIPJEPDGPPO()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	public void JHPPFAEAFEK()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	private void BDMEBLBLPIA()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 901f;
		movement = 1750f;
		theta = 716f;
		currentAmplitude = 8f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 1; i < leavesParticles.Length; i++)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	public void NGEHFIHPENM(bool DBGDJFMBJCK)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude / 1988f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(PKAFJLKIOAB(DBGDJFMBJCK));
		}
	}

	public void GJKGLAAEHIK()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	public void KIMLEJCHPMD(bool DBGDJFMBJCK)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude / 552f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(OEIFJADCIDG(DBGDJFMBJCK));
		}
	}

	private void NELBHAMPBPL()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 815f;
		movement = 1637f;
		theta = 57f;
		currentAmplitude = 1204f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 1; i < leavesParticles.Length; i++)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	public void JOJKDILBBCL()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	public void FHOBCFNEFOP(bool DBGDJFMBJCK)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude / 264f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(CNNKJGGJEFJ(DBGDJFMBJCK));
		}
	}

	private void IAAGKLPMAMK()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 1295f;
		movement = 1140f;
		theta = 418f;
		currentAmplitude = 29f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 1; i < leavesParticles.Length; i++)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	private IEnumerator DBELFCEEION(bool DBGDJFMBJCK)
	{
		for (int i = 0; i < choppingParticles.Length; i++)
		{
			if (choppingParticles[i].activeSelf)
			{
				choppingParticles[i].SetActive(false);
				yield return null;
			}
			choppingParticles[i].SetActive(true);
		}
		currentAmplitude = amplitude;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int j = 0; j < leavesParticles.Length; j++)
			{
				HHMEKONGKCN[j] = particleIntensity * 15f;
			}
		}
		else
		{
			for (int k = 0; k < leavesParticles.Length; k++)
			{
				HHMEKONGKCN[k] = particleIntensity;
			}
		}
		MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[0])).rateOverTime;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int l = 0; l < spriteRenderers.Length; l++)
			{
				((Renderer)spriteRenderers[l]).material.SetFloat(ShaderReferences.noiseMultiplier, 0.05f);
			}
		}
		while (currentAmplitude > 0.01f)
		{
			if (SeasonManager.EECEKHKAAIH == Season.Winter && currentAmplitude < amplitude / 6f)
			{
				for (int m = 0; m < spriteRenderers.Length; m++)
				{
					((Renderer)spriteRenderers[m]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(0f, 0.05f, currentAmplitude / (amplitude / 6f)));
				}
			}
			theta = (Time.timeSinceLevelLoad - startTime) / period;
			movement = currentAmplitude * Mathf.Sin(theta);
			if (DBGDJFMBJCK)
			{
				movement *= -1f;
			}
			for (int n = 0; n < spriteRenderers.Length; n++)
			{
				if ((Object)(object)spriteRenderers[n] != (Object)null)
				{
					((Renderer)spriteRenderers[n]).material.SetFloat(ShaderReferences.swishEffect, movement + tree.defaultMaterial.GetFloat(ShaderReferences.swishEffect));
				}
			}
			currentAmplitude = Mathf.Lerp(currentAmplitude, 0f, amplitudeRegression * Time.deltaTime);
			if (!tree.HasBeenChopped())
			{
				for (int num = 0; num < leavesParticles.Length; num++)
				{
					if (((Component)leavesParticles[num]).gameObject.activeInHierarchy)
					{
						rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime;
						if (SeasonManager.EECEKHKAAIH == Season.Winter)
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime * 10f);
						}
						else
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime);
						}
						((MinMaxCurve)(ref rateOverTime)).constant = HHMEKONGKCN[num];
						((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime = rateOverTime;
					}
				}
			}
			else if (spriteRenderers.Length != 0)
			{
				LDBOIIILOIC = ((Renderer)spriteRenderers[0]).material.GetFloat(ShaderReferences.noiseMultiplier);
				for (int num2 = 0; num2 < spriteRenderers.Length; num2++)
				{
					if ((Object)(object)spriteRenderers[num2] != (Object)null)
					{
						((Renderer)spriteRenderers[num2]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(LDBOIIILOIC, 0f, 2f * Time.deltaTime));
					}
				}
			}
			yield return null;
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int num3 = 0; num3 < spriteRenderers.Length; num3++)
			{
				((Renderer)spriteRenderers[num3]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num4 = 0; num4 < choppingParticles.Length; num4++)
		{
			choppingParticles[num4].SetActive(false);
		}
		LDKHPOBCNFC = null;
		if (!tree.HasBeenChopped())
		{
			for (int num5 = 0; num5 < spriteRenderers.Length; num5++)
			{
				((Renderer)spriteRenderers[num5]).sharedMaterial = tree.defaultMaterial;
			}
		}
		else
		{
			for (int num6 = 0; num6 < spriteRenderers.Length; num6++)
			{
				((Renderer)spriteRenderers[num6]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num7 = 0; num7 < leavesParticles.Length; num7++)
		{
			if (((Component)leavesParticles[num7]).gameObject.activeInHierarchy)
			{
				rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime;
				if (tree.HasBeenChopped())
				{
					((MinMaxCurve)(ref rateOverTime)).constant = 0f;
				}
				else
				{
					((MinMaxCurve)(ref rateOverTime)).constant = AOLGMOHOJMI[num7];
				}
				((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime = rateOverTime;
			}
		}
	}

	private IEnumerator DNDAINCMLPK(bool DBGDJFMBJCK)
	{
		for (int i = 0; i < choppingParticles.Length; i++)
		{
			if (choppingParticles[i].activeSelf)
			{
				choppingParticles[i].SetActive(false);
				yield return null;
			}
			choppingParticles[i].SetActive(true);
		}
		currentAmplitude = amplitude;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int j = 0; j < leavesParticles.Length; j++)
			{
				HHMEKONGKCN[j] = particleIntensity * 15f;
			}
		}
		else
		{
			for (int k = 0; k < leavesParticles.Length; k++)
			{
				HHMEKONGKCN[k] = particleIntensity;
			}
		}
		MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[0])).rateOverTime;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int l = 0; l < spriteRenderers.Length; l++)
			{
				((Renderer)spriteRenderers[l]).material.SetFloat(ShaderReferences.noiseMultiplier, 0.05f);
			}
		}
		while (currentAmplitude > 0.01f)
		{
			if (SeasonManager.EECEKHKAAIH == Season.Winter && currentAmplitude < amplitude / 6f)
			{
				for (int m = 0; m < spriteRenderers.Length; m++)
				{
					((Renderer)spriteRenderers[m]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(0f, 0.05f, currentAmplitude / (amplitude / 6f)));
				}
			}
			theta = (Time.timeSinceLevelLoad - startTime) / period;
			movement = currentAmplitude * Mathf.Sin(theta);
			if (DBGDJFMBJCK)
			{
				movement *= -1f;
			}
			for (int n = 0; n < spriteRenderers.Length; n++)
			{
				if ((Object)(object)spriteRenderers[n] != (Object)null)
				{
					((Renderer)spriteRenderers[n]).material.SetFloat(ShaderReferences.swishEffect, movement + tree.defaultMaterial.GetFloat(ShaderReferences.swishEffect));
				}
			}
			currentAmplitude = Mathf.Lerp(currentAmplitude, 0f, amplitudeRegression * Time.deltaTime);
			if (!tree.HasBeenChopped())
			{
				for (int num = 0; num < leavesParticles.Length; num++)
				{
					if (((Component)leavesParticles[num]).gameObject.activeInHierarchy)
					{
						rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime;
						if (SeasonManager.EECEKHKAAIH == Season.Winter)
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime * 10f);
						}
						else
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime);
						}
						((MinMaxCurve)(ref rateOverTime)).constant = HHMEKONGKCN[num];
						((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime = rateOverTime;
					}
				}
			}
			else if (spriteRenderers.Length != 0)
			{
				LDBOIIILOIC = ((Renderer)spriteRenderers[0]).material.GetFloat(ShaderReferences.noiseMultiplier);
				for (int num2 = 0; num2 < spriteRenderers.Length; num2++)
				{
					if ((Object)(object)spriteRenderers[num2] != (Object)null)
					{
						((Renderer)spriteRenderers[num2]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(LDBOIIILOIC, 0f, 2f * Time.deltaTime));
					}
				}
			}
			yield return null;
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int num3 = 0; num3 < spriteRenderers.Length; num3++)
			{
				((Renderer)spriteRenderers[num3]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num4 = 0; num4 < choppingParticles.Length; num4++)
		{
			choppingParticles[num4].SetActive(false);
		}
		LDKHPOBCNFC = null;
		if (!tree.HasBeenChopped())
		{
			for (int num5 = 0; num5 < spriteRenderers.Length; num5++)
			{
				((Renderer)spriteRenderers[num5]).sharedMaterial = tree.defaultMaterial;
			}
		}
		else
		{
			for (int num6 = 0; num6 < spriteRenderers.Length; num6++)
			{
				((Renderer)spriteRenderers[num6]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num7 = 0; num7 < leavesParticles.Length; num7++)
		{
			if (((Component)leavesParticles[num7]).gameObject.activeInHierarchy)
			{
				rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime;
				if (tree.HasBeenChopped())
				{
					((MinMaxCurve)(ref rateOverTime)).constant = 0f;
				}
				else
				{
					((MinMaxCurve)(ref rateOverTime)).constant = AOLGMOHOJMI[num7];
				}
				((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime = rateOverTime;
			}
		}
	}

	private IEnumerator HFMNMKJDGAK(bool DBGDJFMBJCK)
	{
		for (int i = 0; i < choppingParticles.Length; i++)
		{
			if (choppingParticles[i].activeSelf)
			{
				choppingParticles[i].SetActive(false);
				yield return null;
			}
			choppingParticles[i].SetActive(true);
		}
		currentAmplitude = amplitude;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int j = 0; j < leavesParticles.Length; j++)
			{
				HHMEKONGKCN[j] = particleIntensity * 15f;
			}
		}
		else
		{
			for (int k = 0; k < leavesParticles.Length; k++)
			{
				HHMEKONGKCN[k] = particleIntensity;
			}
		}
		MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[0])).rateOverTime;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int l = 0; l < spriteRenderers.Length; l++)
			{
				((Renderer)spriteRenderers[l]).material.SetFloat(ShaderReferences.noiseMultiplier, 0.05f);
			}
		}
		while (currentAmplitude > 0.01f)
		{
			if (SeasonManager.EECEKHKAAIH == Season.Winter && currentAmplitude < amplitude / 6f)
			{
				for (int m = 0; m < spriteRenderers.Length; m++)
				{
					((Renderer)spriteRenderers[m]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(0f, 0.05f, currentAmplitude / (amplitude / 6f)));
				}
			}
			theta = (Time.timeSinceLevelLoad - startTime) / period;
			movement = currentAmplitude * Mathf.Sin(theta);
			if (DBGDJFMBJCK)
			{
				movement *= -1f;
			}
			for (int n = 0; n < spriteRenderers.Length; n++)
			{
				if ((Object)(object)spriteRenderers[n] != (Object)null)
				{
					((Renderer)spriteRenderers[n]).material.SetFloat(ShaderReferences.swishEffect, movement + tree.defaultMaterial.GetFloat(ShaderReferences.swishEffect));
				}
			}
			currentAmplitude = Mathf.Lerp(currentAmplitude, 0f, amplitudeRegression * Time.deltaTime);
			if (!tree.HasBeenChopped())
			{
				for (int num = 0; num < leavesParticles.Length; num++)
				{
					if (((Component)leavesParticles[num]).gameObject.activeInHierarchy)
					{
						rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime;
						if (SeasonManager.EECEKHKAAIH == Season.Winter)
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime * 10f);
						}
						else
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime);
						}
						((MinMaxCurve)(ref rateOverTime)).constant = HHMEKONGKCN[num];
						((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime = rateOverTime;
					}
				}
			}
			else if (spriteRenderers.Length != 0)
			{
				LDBOIIILOIC = ((Renderer)spriteRenderers[0]).material.GetFloat(ShaderReferences.noiseMultiplier);
				for (int num2 = 0; num2 < spriteRenderers.Length; num2++)
				{
					if ((Object)(object)spriteRenderers[num2] != (Object)null)
					{
						((Renderer)spriteRenderers[num2]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(LDBOIIILOIC, 0f, 2f * Time.deltaTime));
					}
				}
			}
			yield return null;
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int num3 = 0; num3 < spriteRenderers.Length; num3++)
			{
				((Renderer)spriteRenderers[num3]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num4 = 0; num4 < choppingParticles.Length; num4++)
		{
			choppingParticles[num4].SetActive(false);
		}
		LDKHPOBCNFC = null;
		if (!tree.HasBeenChopped())
		{
			for (int num5 = 0; num5 < spriteRenderers.Length; num5++)
			{
				((Renderer)spriteRenderers[num5]).sharedMaterial = tree.defaultMaterial;
			}
		}
		else
		{
			for (int num6 = 0; num6 < spriteRenderers.Length; num6++)
			{
				((Renderer)spriteRenderers[num6]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num7 = 0; num7 < leavesParticles.Length; num7++)
		{
			if (((Component)leavesParticles[num7]).gameObject.activeInHierarchy)
			{
				rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime;
				if (tree.HasBeenChopped())
				{
					((MinMaxCurve)(ref rateOverTime)).constant = 0f;
				}
				else
				{
					((MinMaxCurve)(ref rateOverTime)).constant = AOLGMOHOJMI[num7];
				}
				((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime = rateOverTime;
			}
		}
	}

	public void NKJKJKNFCKB(bool DBGDJFMBJCK)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude / 1298f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(JKOGIGLEIDI(DBGDJFMBJCK));
		}
	}

	public void JEMPMFMEMGL(bool DBGDJFMBJCK)
	{
		if (LDKHPOBCNFC != null && currentAmplitude < amplitude / 1645f)
		{
			((MonoBehaviour)this).StopCoroutine(LDKHPOBCNFC);
			LDKHPOBCNFC = null;
		}
		if (LDKHPOBCNFC == null)
		{
			startTime = Time.timeSinceLevelLoad;
			LDKHPOBCNFC = ((MonoBehaviour)this).StartCoroutine(MEBGJBOEHBB(DBGDJFMBJCK));
		}
	}

	private void HFFFFAJFIPB()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 968f;
		movement = 1494f;
		theta = 348f;
		currentAmplitude = 797f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 1; i < leavesParticles.Length; i += 0)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	public void GNIBBHOENLP()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	public void LKBPIFKNAMC()
	{
		tree = ((Component)this).GetComponent<Tree>();
		tree.chopAnimation = this;
		spriteRenderers = tree.animatedSpriteRenderers;
	}

	private IEnumerator MDBAAAEJJJP(bool DBGDJFMBJCK)
	{
		for (int i = 0; i < choppingParticles.Length; i++)
		{
			if (choppingParticles[i].activeSelf)
			{
				choppingParticles[i].SetActive(false);
				yield return null;
			}
			choppingParticles[i].SetActive(true);
		}
		currentAmplitude = amplitude;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int j = 0; j < leavesParticles.Length; j++)
			{
				HHMEKONGKCN[j] = particleIntensity * 15f;
			}
		}
		else
		{
			for (int k = 0; k < leavesParticles.Length; k++)
			{
				HHMEKONGKCN[k] = particleIntensity;
			}
		}
		MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[0])).rateOverTime;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int l = 0; l < spriteRenderers.Length; l++)
			{
				((Renderer)spriteRenderers[l]).material.SetFloat(ShaderReferences.noiseMultiplier, 0.05f);
			}
		}
		while (currentAmplitude > 0.01f)
		{
			if (SeasonManager.EECEKHKAAIH == Season.Winter && currentAmplitude < amplitude / 6f)
			{
				for (int m = 0; m < spriteRenderers.Length; m++)
				{
					((Renderer)spriteRenderers[m]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(0f, 0.05f, currentAmplitude / (amplitude / 6f)));
				}
			}
			theta = (Time.timeSinceLevelLoad - startTime) / period;
			movement = currentAmplitude * Mathf.Sin(theta);
			if (DBGDJFMBJCK)
			{
				movement *= -1f;
			}
			for (int n = 0; n < spriteRenderers.Length; n++)
			{
				if ((Object)(object)spriteRenderers[n] != (Object)null)
				{
					((Renderer)spriteRenderers[n]).material.SetFloat(ShaderReferences.swishEffect, movement + tree.defaultMaterial.GetFloat(ShaderReferences.swishEffect));
				}
			}
			currentAmplitude = Mathf.Lerp(currentAmplitude, 0f, amplitudeRegression * Time.deltaTime);
			if (!tree.HasBeenChopped())
			{
				for (int num = 0; num < leavesParticles.Length; num++)
				{
					if (((Component)leavesParticles[num]).gameObject.activeInHierarchy)
					{
						rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime;
						if (SeasonManager.EECEKHKAAIH == Season.Winter)
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime * 10f);
						}
						else
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime);
						}
						((MinMaxCurve)(ref rateOverTime)).constant = HHMEKONGKCN[num];
						((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime = rateOverTime;
					}
				}
			}
			else if (spriteRenderers.Length != 0)
			{
				LDBOIIILOIC = ((Renderer)spriteRenderers[0]).material.GetFloat(ShaderReferences.noiseMultiplier);
				for (int num2 = 0; num2 < spriteRenderers.Length; num2++)
				{
					if ((Object)(object)spriteRenderers[num2] != (Object)null)
					{
						((Renderer)spriteRenderers[num2]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(LDBOIIILOIC, 0f, 2f * Time.deltaTime));
					}
				}
			}
			yield return null;
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int num3 = 0; num3 < spriteRenderers.Length; num3++)
			{
				((Renderer)spriteRenderers[num3]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num4 = 0; num4 < choppingParticles.Length; num4++)
		{
			choppingParticles[num4].SetActive(false);
		}
		LDKHPOBCNFC = null;
		if (!tree.HasBeenChopped())
		{
			for (int num5 = 0; num5 < spriteRenderers.Length; num5++)
			{
				((Renderer)spriteRenderers[num5]).sharedMaterial = tree.defaultMaterial;
			}
		}
		else
		{
			for (int num6 = 0; num6 < spriteRenderers.Length; num6++)
			{
				((Renderer)spriteRenderers[num6]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num7 = 0; num7 < leavesParticles.Length; num7++)
		{
			if (((Component)leavesParticles[num7]).gameObject.activeInHierarchy)
			{
				rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime;
				if (tree.HasBeenChopped())
				{
					((MinMaxCurve)(ref rateOverTime)).constant = 0f;
				}
				else
				{
					((MinMaxCurve)(ref rateOverTime)).constant = AOLGMOHOJMI[num7];
				}
				((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime = rateOverTime;
			}
		}
	}

	private void GNGADDPBJDC()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 25f;
		movement = 93f;
		theta = 977f;
		currentAmplitude = 1563f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 0; i < leavesParticles.Length; i += 0)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	private IEnumerator OEIFJADCIDG(bool DBGDJFMBJCK)
	{
		for (int i = 0; i < choppingParticles.Length; i++)
		{
			if (choppingParticles[i].activeSelf)
			{
				choppingParticles[i].SetActive(false);
				yield return null;
			}
			choppingParticles[i].SetActive(true);
		}
		currentAmplitude = amplitude;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int j = 0; j < leavesParticles.Length; j++)
			{
				HHMEKONGKCN[j] = particleIntensity * 15f;
			}
		}
		else
		{
			for (int k = 0; k < leavesParticles.Length; k++)
			{
				HHMEKONGKCN[k] = particleIntensity;
			}
		}
		MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[0])).rateOverTime;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int l = 0; l < spriteRenderers.Length; l++)
			{
				((Renderer)spriteRenderers[l]).material.SetFloat(ShaderReferences.noiseMultiplier, 0.05f);
			}
		}
		while (currentAmplitude > 0.01f)
		{
			if (SeasonManager.EECEKHKAAIH == Season.Winter && currentAmplitude < amplitude / 6f)
			{
				for (int m = 0; m < spriteRenderers.Length; m++)
				{
					((Renderer)spriteRenderers[m]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(0f, 0.05f, currentAmplitude / (amplitude / 6f)));
				}
			}
			theta = (Time.timeSinceLevelLoad - startTime) / period;
			movement = currentAmplitude * Mathf.Sin(theta);
			if (DBGDJFMBJCK)
			{
				movement *= -1f;
			}
			for (int n = 0; n < spriteRenderers.Length; n++)
			{
				if ((Object)(object)spriteRenderers[n] != (Object)null)
				{
					((Renderer)spriteRenderers[n]).material.SetFloat(ShaderReferences.swishEffect, movement + tree.defaultMaterial.GetFloat(ShaderReferences.swishEffect));
				}
			}
			currentAmplitude = Mathf.Lerp(currentAmplitude, 0f, amplitudeRegression * Time.deltaTime);
			if (!tree.HasBeenChopped())
			{
				for (int num = 0; num < leavesParticles.Length; num++)
				{
					if (((Component)leavesParticles[num]).gameObject.activeInHierarchy)
					{
						rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime;
						if (SeasonManager.EECEKHKAAIH == Season.Winter)
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime * 10f);
						}
						else
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime);
						}
						((MinMaxCurve)(ref rateOverTime)).constant = HHMEKONGKCN[num];
						((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime = rateOverTime;
					}
				}
			}
			else if (spriteRenderers.Length != 0)
			{
				LDBOIIILOIC = ((Renderer)spriteRenderers[0]).material.GetFloat(ShaderReferences.noiseMultiplier);
				for (int num2 = 0; num2 < spriteRenderers.Length; num2++)
				{
					if ((Object)(object)spriteRenderers[num2] != (Object)null)
					{
						((Renderer)spriteRenderers[num2]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(LDBOIIILOIC, 0f, 2f * Time.deltaTime));
					}
				}
			}
			yield return null;
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int num3 = 0; num3 < spriteRenderers.Length; num3++)
			{
				((Renderer)spriteRenderers[num3]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num4 = 0; num4 < choppingParticles.Length; num4++)
		{
			choppingParticles[num4].SetActive(false);
		}
		LDKHPOBCNFC = null;
		if (!tree.HasBeenChopped())
		{
			for (int num5 = 0; num5 < spriteRenderers.Length; num5++)
			{
				((Renderer)spriteRenderers[num5]).sharedMaterial = tree.defaultMaterial;
			}
		}
		else
		{
			for (int num6 = 0; num6 < spriteRenderers.Length; num6++)
			{
				((Renderer)spriteRenderers[num6]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num7 = 0; num7 < leavesParticles.Length; num7++)
		{
			if (((Component)leavesParticles[num7]).gameObject.activeInHierarchy)
			{
				rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime;
				if (tree.HasBeenChopped())
				{
					((MinMaxCurve)(ref rateOverTime)).constant = 0f;
				}
				else
				{
					((MinMaxCurve)(ref rateOverTime)).constant = AOLGMOHOJMI[num7];
				}
				((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime = rateOverTime;
			}
		}
	}

	private void CAOKPIIFHBJ()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 446f;
		movement = 1301f;
		theta = 317f;
		currentAmplitude = 1033f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 1; i < leavesParticles.Length; i++)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	private IEnumerator FGOEFHODLAH(bool DBGDJFMBJCK)
	{
		for (int i = 0; i < choppingParticles.Length; i++)
		{
			if (choppingParticles[i].activeSelf)
			{
				choppingParticles[i].SetActive(false);
				yield return null;
			}
			choppingParticles[i].SetActive(true);
		}
		currentAmplitude = amplitude;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int j = 0; j < leavesParticles.Length; j++)
			{
				HHMEKONGKCN[j] = particleIntensity * 15f;
			}
		}
		else
		{
			for (int k = 0; k < leavesParticles.Length; k++)
			{
				HHMEKONGKCN[k] = particleIntensity;
			}
		}
		MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[0])).rateOverTime;
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int l = 0; l < spriteRenderers.Length; l++)
			{
				((Renderer)spriteRenderers[l]).material.SetFloat(ShaderReferences.noiseMultiplier, 0.05f);
			}
		}
		while (currentAmplitude > 0.01f)
		{
			if (SeasonManager.EECEKHKAAIH == Season.Winter && currentAmplitude < amplitude / 6f)
			{
				for (int m = 0; m < spriteRenderers.Length; m++)
				{
					((Renderer)spriteRenderers[m]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(0f, 0.05f, currentAmplitude / (amplitude / 6f)));
				}
			}
			theta = (Time.timeSinceLevelLoad - startTime) / period;
			movement = currentAmplitude * Mathf.Sin(theta);
			if (DBGDJFMBJCK)
			{
				movement *= -1f;
			}
			for (int n = 0; n < spriteRenderers.Length; n++)
			{
				if ((Object)(object)spriteRenderers[n] != (Object)null)
				{
					((Renderer)spriteRenderers[n]).material.SetFloat(ShaderReferences.swishEffect, movement + tree.defaultMaterial.GetFloat(ShaderReferences.swishEffect));
				}
			}
			currentAmplitude = Mathf.Lerp(currentAmplitude, 0f, amplitudeRegression * Time.deltaTime);
			if (!tree.HasBeenChopped())
			{
				for (int num = 0; num < leavesParticles.Length; num++)
				{
					if (((Component)leavesParticles[num]).gameObject.activeInHierarchy)
					{
						rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime;
						if (SeasonManager.EECEKHKAAIH == Season.Winter)
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime * 10f);
						}
						else
						{
							HHMEKONGKCN[num] = Mathf.Lerp(HHMEKONGKCN[num], AOLGMOHOJMI[num], amplitudeRegression * Time.deltaTime);
						}
						((MinMaxCurve)(ref rateOverTime)).constant = HHMEKONGKCN[num];
						((EmissionModule)(ref INHPFKMEMFB[num])).rateOverTime = rateOverTime;
					}
				}
			}
			else if (spriteRenderers.Length != 0)
			{
				LDBOIIILOIC = ((Renderer)spriteRenderers[0]).material.GetFloat(ShaderReferences.noiseMultiplier);
				for (int num2 = 0; num2 < spriteRenderers.Length; num2++)
				{
					if ((Object)(object)spriteRenderers[num2] != (Object)null)
					{
						((Renderer)spriteRenderers[num2]).material.SetFloat(ShaderReferences.noiseMultiplier, Mathf.Lerp(LDBOIIILOIC, 0f, 2f * Time.deltaTime));
					}
				}
			}
			yield return null;
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			for (int num3 = 0; num3 < spriteRenderers.Length; num3++)
			{
				((Renderer)spriteRenderers[num3]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num4 = 0; num4 < choppingParticles.Length; num4++)
		{
			choppingParticles[num4].SetActive(false);
		}
		LDKHPOBCNFC = null;
		if (!tree.HasBeenChopped())
		{
			for (int num5 = 0; num5 < spriteRenderers.Length; num5++)
			{
				((Renderer)spriteRenderers[num5]).sharedMaterial = tree.defaultMaterial;
			}
		}
		else
		{
			for (int num6 = 0; num6 < spriteRenderers.Length; num6++)
			{
				((Renderer)spriteRenderers[num6]).material.SetFloat(ShaderReferences.noiseMultiplier, 0f);
			}
		}
		for (int num7 = 0; num7 < leavesParticles.Length; num7++)
		{
			if (((Component)leavesParticles[num7]).gameObject.activeInHierarchy)
			{
				rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime;
				if (tree.HasBeenChopped())
				{
					((MinMaxCurve)(ref rateOverTime)).constant = 0f;
				}
				else
				{
					((MinMaxCurve)(ref rateOverTime)).constant = AOLGMOHOJMI[num7];
				}
				((EmissionModule)(ref INHPFKMEMFB[num7])).rateOverTime = rateOverTime;
			}
		}
	}

	private IEnumerator KPFPGJDOMHI(bool DBGDJFMBJCK)
	{
		return new MCNPLIEDJGE(1)
		{
			_003C_003E4__this = this,
			fallRight = DBGDJFMBJCK
		};
	}

	private void LJLKBKEADGI()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 1055f;
		movement = 992f;
		theta = 1740f;
		currentAmplitude = 582f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 0; i < leavesParticles.Length; i++)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	private void CFHOODNCOLK()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		startTime = 1521f;
		movement = 1555f;
		theta = 396f;
		currentAmplitude = 423f;
		INHPFKMEMFB = (EmissionModule[])(object)new EmissionModule[leavesParticles.Length];
		AOLGMOHOJMI = new float[leavesParticles.Length];
		HHMEKONGKCN = new float[leavesParticles.Length];
		for (int i = 1; i < leavesParticles.Length; i++)
		{
			INHPFKMEMFB[i] = leavesParticles[i].emission;
			float[] aOLGMOHOJMI = AOLGMOHOJMI;
			int num = i;
			MinMaxCurve rateOverTime = ((EmissionModule)(ref INHPFKMEMFB[i])).rateOverTime;
			aOLGMOHOJMI[num] = ((MinMaxCurve)(ref rateOverTime)).constant;
		}
	}

	private IEnumerator BBJEDNFIPCM(bool DBGDJFMBJCK)
	{
		return new MCNPLIEDJGE(1)
		{
			_003C_003E4__this = this,
			fallRight = DBGDJFMBJCK
		};
	}
}
