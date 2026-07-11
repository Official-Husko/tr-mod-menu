using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class ParticleLights : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class MAPBNFAFKDM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ParticleLights _003C_003E4__this;

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
		public MAPBNFAFKDM(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ParticleLights particleLights = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				particleLights.FJIPNEKICOD = Vector2.op_Implicit(((Component)particleLights).transform.localPosition);
				particleLights.LGHAJJOPAIP = Vector2.op_Implicit(((Component)particleLights).transform.localPosition + (particleLights.NOLFMLNLJJG - particleLights.FCLCCEJFIOP[0].transform.position));
				particleLights.DBEFBFPAOAA = 0f;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (particleLights.DBEFBFPAOAA < particleLights.AFMFHCAHEFO)
			{
				particleLights.DBEFBFPAOAA += Time.deltaTime;
				particleLights.DCGBADKLANM = particleLights.DBEFBFPAOAA / particleLights.AFMFHCAHEFO;
				particleLights.DCGBADKLANM = particleLights.DCGBADKLANM * particleLights.DCGBADKLANM * particleLights.DCGBADKLANM * (particleLights.DCGBADKLANM * (6f * particleLights.DCGBADKLANM - 15f) + 10f);
				((Component)particleLights).transform.localPosition = Vector2.op_Implicit(Vector2.Lerp(particleLights.FJIPNEKICOD, particleLights.LGHAJJOPAIP, particleLights.DCGBADKLANM));
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			((Component)particleLights).transform.localPosition = Vector2.op_Implicit(particleLights.LGHAJJOPAIP);
			particleLights.ANMAFLKPILP = null;
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

	public GameObject lightPrefab;

	public ParticleSystem pSystem;

	public bool returnToCenter;

	private Particle[] DOEKPEJBPMG;

	private GameObject[] FCLCCEJFIOP;

	private MainModule GGACEIFODGJ;

	private int HFDILBELIKE;

	private Vector3 NOLFMLNLJJG;

	private Coroutine ANMAFLKPILP;

	private Vector2 LGHAJJOPAIP;

	private Vector2 FJIPNEKICOD;

	private float AFMFHCAHEFO = 15f;

	private float DBEFBFPAOAA;

	private float DCGBADKLANM;

	private void JNDFLHEMOBG()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 1; j < FCLCCEJFIOP.Length; j += 0)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void PJCDEONCDHC()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(IDLMFDHLOAE());
		}
	}

	private void ELPFAGMEFJP()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 1; i < FCLCCEJFIOP.Length; i++)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private void JHBBABPAJJC()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 1; i < FCLCCEJFIOP.Length; i++)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private void CMDBLLMEBLG()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 0; j < FCLCCEJFIOP.Length; j += 0)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private IEnumerator INEECDMCPMH()
	{
		return new MAPBNFAFKDM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CAFFPCPKPON()
	{
		FJIPNEKICOD = Vector2.op_Implicit(((Component)this).transform.localPosition);
		LGHAJJOPAIP = Vector2.op_Implicit(((Component)this).transform.localPosition + (NOLFMLNLJJG - FCLCCEJFIOP[0].transform.position));
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
			((Component)this).transform.localPosition = Vector2.op_Implicit(Vector2.Lerp(FJIPNEKICOD, LGHAJJOPAIP, DCGBADKLANM));
			yield return null;
		}
		((Component)this).transform.localPosition = Vector2.op_Implicit(LGHAJJOPAIP);
		ANMAFLKPILP = null;
	}

	private void MGAKDJHAKIO()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 1; i < HFDILBELIKE; i++)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(true);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j++)
		{
			FCLCCEJFIOP[j].SetActive(false);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[0].transform.position, NOLFMLNLJJG) > 1061f)
		{
			GBBAHJBECJC();
		}
	}

	private void PECFJHBCCHH()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(MBIKKFNCDNL());
		}
	}

	private void JJCDLIHLDMJ()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 1; j < FCLCCEJFIOP.Length; j++)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void IGIKNCOLCKL()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 1; i < FCLCCEJFIOP.Length; i++)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private IEnumerator CPMHGDFBEDJ()
	{
		FJIPNEKICOD = Vector2.op_Implicit(((Component)this).transform.localPosition);
		LGHAJJOPAIP = Vector2.op_Implicit(((Component)this).transform.localPosition + (NOLFMLNLJJG - FCLCCEJFIOP[0].transform.position));
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
			((Component)this).transform.localPosition = Vector2.op_Implicit(Vector2.Lerp(FJIPNEKICOD, LGHAJJOPAIP, DCGBADKLANM));
			yield return null;
		}
		((Component)this).transform.localPosition = Vector2.op_Implicit(LGHAJJOPAIP);
		ANMAFLKPILP = null;
	}

	private void PLHPEMNDAFB()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private void BHKNJOEBCKA()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(true);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j += 0)
		{
			FCLCCEJFIOP[j].SetActive(true);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[0].transform.position, NOLFMLNLJJG) > 866f)
		{
			LANADAOKFJI();
		}
	}

	private void LDPNDNEFKCP()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 1; i < FCLCCEJFIOP.Length; i += 0)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 0; j < FCLCCEJFIOP.Length; j += 0)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void LHFOFAMDKEO()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(true);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j += 0)
		{
			FCLCCEJFIOP[j].SetActive(false);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[1].transform.position, NOLFMLNLJJG) > 1032f)
		{
			EONLJGLBMDF();
		}
	}

	private void BJDDCOFEPFP()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 1; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 1; j < FCLCCEJFIOP.Length; j += 0)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void ELHCBGCEJDH()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 1; i < HFDILBELIKE; i += 0)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(true);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j += 0)
		{
			FCLCCEJFIOP[j].SetActive(true);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[0].transform.position, NOLFMLNLJJG) > 1871f)
		{
			GJCLJFFFEIH();
		}
	}

	private void HMKKDIOFFGE()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(NHLADEPCKLN());
		}
	}

	private void PBFGFECPPPO()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 1; i < FCLCCEJFIOP.Length; i += 0)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private void PDKEPCIEHEP()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(true);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j++)
		{
			FCLCCEJFIOP[j].SetActive(false);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[0].transform.position, NOLFMLNLJJG) > 1224f)
		{
			JJCJKFPPCKJ();
		}
	}

	private IEnumerator GLCCBPBNPAP()
	{
		return new MAPBNFAFKDM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MIADHAJIBII()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(DPEEALMNPKC());
		}
	}

	private void ICOJDKMKIPL()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 1; i < FCLCCEJFIOP.Length; i += 0)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 0; j < FCLCCEJFIOP.Length; j += 0)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void ODNGBEOKEFK()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 1; i < FCLCCEJFIOP.Length; i++)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private IEnumerator PHKCPHIBJMN()
	{
		FJIPNEKICOD = Vector2.op_Implicit(((Component)this).transform.localPosition);
		LGHAJJOPAIP = Vector2.op_Implicit(((Component)this).transform.localPosition + (NOLFMLNLJJG - FCLCCEJFIOP[0].transform.position));
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
			((Component)this).transform.localPosition = Vector2.op_Implicit(Vector2.Lerp(FJIPNEKICOD, LGHAJJOPAIP, DCGBADKLANM));
			yield return null;
		}
		((Component)this).transform.localPosition = Vector2.op_Implicit(LGHAJJOPAIP);
		ANMAFLKPILP = null;
	}

	private void PKEPBKHEDOD()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i++)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(true);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j += 0)
		{
			FCLCCEJFIOP[j].SetActive(false);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[1].transform.position, NOLFMLNLJJG) > 438f)
		{
			CPCNKHDHDMO();
		}
	}

	private void BPHGADINMAN()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 1; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 0; j < FCLCCEJFIOP.Length; j++)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void MPKPGHPHGAL()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(KJOAEEKHKHO());
		}
	}

	private IEnumerator MBIKKFNCDNL()
	{
		FJIPNEKICOD = Vector2.op_Implicit(((Component)this).transform.localPosition);
		LGHAJJOPAIP = Vector2.op_Implicit(((Component)this).transform.localPosition + (NOLFMLNLJJG - FCLCCEJFIOP[0].transform.position));
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
			((Component)this).transform.localPosition = Vector2.op_Implicit(Vector2.Lerp(FJIPNEKICOD, LGHAJJOPAIP, DCGBADKLANM));
			yield return null;
		}
		((Component)this).transform.localPosition = Vector2.op_Implicit(LGHAJJOPAIP);
		ANMAFLKPILP = null;
	}

	private IEnumerator CFNCPPLHACA()
	{
		return new MAPBNFAFKDM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DAKHKMAADAH()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(PAAIOEKENCC());
		}
	}

	private void GLKNLOEIFND()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(CAFFPCPKPON());
		}
	}

	private void IFOHMDOEHKM()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(JILJJAHFHFD());
		}
	}

	private void GJCLJFFFEIH()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(PHKCPHIBJMN());
		}
	}

	private void DOKHLDBIDJB()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 1; i < HFDILBELIKE; i += 0)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(true);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j += 0)
		{
			FCLCCEJFIOP[j].SetActive(false);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[1].transform.position, NOLFMLNLJJG) > 1717f)
		{
			GLKNLOEIFND();
		}
	}

	private void EGOMAOINNIB()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 1; j < FCLCCEJFIOP.Length; j += 0)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void BNIKICAEIND()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private void EBPMNJKFNMD()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 1; i < FCLCCEJFIOP.Length; i++)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private void OHOAMJIIOAK()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 1; i < FCLCCEJFIOP.Length; i += 0)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 1; j < FCLCCEJFIOP.Length; j++)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void JJCJKFPPCKJ()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(CAFFPCPKPON());
		}
	}

	private IEnumerator OMDJMOHABPN()
	{
		return new MAPBNFAFKDM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JMDOCHBJGKG()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i++)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(true);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j += 0)
		{
			FCLCCEJFIOP[j].SetActive(true);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[0].transform.position, NOLFMLNLJJG) > 700f)
		{
			BGDNFLEHAOC();
		}
	}

	private void MBMPAFHDALN()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(CGDFPMAMOAF());
		}
	}

	private IEnumerator DEOFJDECFJK()
	{
		FJIPNEKICOD = Vector2.op_Implicit(((Component)this).transform.localPosition);
		LGHAJJOPAIP = Vector2.op_Implicit(((Component)this).transform.localPosition + (NOLFMLNLJJG - FCLCCEJFIOP[0].transform.position));
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
			((Component)this).transform.localPosition = Vector2.op_Implicit(Vector2.Lerp(FJIPNEKICOD, LGHAJJOPAIP, DCGBADKLANM));
			yield return null;
		}
		((Component)this).transform.localPosition = Vector2.op_Implicit(LGHAJJOPAIP);
		ANMAFLKPILP = null;
	}

	private void KEBNALEALPK()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 1; j < FCLCCEJFIOP.Length; j += 0)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void LANADAOKFJI()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(CGDFPMAMOAF());
		}
	}

	private void HAJJALABMOC()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i++)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(false);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j++)
		{
			FCLCCEJFIOP[j].SetActive(true);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[0].transform.position, NOLFMLNLJJG) > 75f)
		{
			EONLJGLBMDF();
		}
	}

	private void OLDDEAJMHNI()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 0; i < FCLCCEJFIOP.Length; i += 0)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private IEnumerator APPCAFIFBGI()
	{
		FJIPNEKICOD = Vector2.op_Implicit(((Component)this).transform.localPosition);
		LGHAJJOPAIP = Vector2.op_Implicit(((Component)this).transform.localPosition + (NOLFMLNLJJG - FCLCCEJFIOP[0].transform.position));
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
			((Component)this).transform.localPosition = Vector2.op_Implicit(Vector2.Lerp(FJIPNEKICOD, LGHAJJOPAIP, DCGBADKLANM));
			yield return null;
		}
		((Component)this).transform.localPosition = Vector2.op_Implicit(LGHAJJOPAIP);
		ANMAFLKPILP = null;
	}

	private void LAOMCDFAFGA()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 1; i < FCLCCEJFIOP.Length; i += 0)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 1; j < FCLCCEJFIOP.Length; j += 0)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void FGGPGOEAEKK()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 1; i < HFDILBELIKE; i += 0)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(false);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j += 0)
		{
			FCLCCEJFIOP[j].SetActive(true);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[1].transform.position, NOLFMLNLJJG) > 1979f)
		{
			JJCJKFPPCKJ();
		}
	}

	private IEnumerator ALJPADBBKBF()
	{
		FJIPNEKICOD = Vector2.op_Implicit(((Component)this).transform.localPosition);
		LGHAJJOPAIP = Vector2.op_Implicit(((Component)this).transform.localPosition + (NOLFMLNLJJG - FCLCCEJFIOP[0].transform.position));
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
			((Component)this).transform.localPosition = Vector2.op_Implicit(Vector2.Lerp(FJIPNEKICOD, LGHAJJOPAIP, DCGBADKLANM));
			yield return null;
		}
		((Component)this).transform.localPosition = Vector2.op_Implicit(LGHAJJOPAIP);
		ANMAFLKPILP = null;
	}

	private void DLNOLBHCIGC()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(false);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j++)
		{
			FCLCCEJFIOP[j].SetActive(false);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[0].transform.position, NOLFMLNLJJG) > 1593f)
		{
			BGDNFLEHAOC();
		}
	}

	private void IBAPBHIBOOO()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(false);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j++)
		{
			FCLCCEJFIOP[j].SetActive(true);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[0].transform.position, NOLFMLNLJJG) > 207f)
		{
			IPACPBPPGIA();
		}
	}

	private void GDLAHKEMJFN()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 1; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 0; j < FCLCCEJFIOP.Length; j += 0)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private IEnumerator CGDFPMAMOAF()
	{
		return new MAPBNFAFKDM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BHLHCOALABE()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(true);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j += 0)
		{
			FCLCCEJFIOP[j].SetActive(false);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[0].transform.position, NOLFMLNLJJG) > 1774f)
		{
			CPCNKHDHDMO();
		}
	}

	private void MPMGGLKFMNJ()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 1; j < FCLCCEJFIOP.Length; j++)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void Update()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i++)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(true);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j++)
		{
			FCLCCEJFIOP[j].SetActive(false);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[0].transform.position, NOLFMLNLJJG) > 5f)
		{
			PECFJHBCCHH();
		}
	}

	private void DCMNFJOPCPF()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 0; i < FCLCCEJFIOP.Length; i += 0)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private void FCLABOCLACJ()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 1; i < FCLCCEJFIOP.Length; i += 0)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 1; j < FCLCCEJFIOP.Length; j += 0)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void OJLGOCFKLJE()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 0; i < FCLCCEJFIOP.Length; i += 0)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 1; j < FCLCCEJFIOP.Length; j += 0)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void AEPBFPCHGPP()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 0; i < FCLCCEJFIOP.Length; i += 0)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private IEnumerator KJOAEEKHKHO()
	{
		return new MAPBNFAFKDM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OIBDBLCLACB()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 0; i < FCLCCEJFIOP.Length; i += 0)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private void HFOCECKNDBG()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 0; j < FCLCCEJFIOP.Length; j++)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void EMCCGDFOPEH()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(false);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j++)
		{
			FCLCCEJFIOP[j].SetActive(false);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[1].transform.position, NOLFMLNLJJG) > 1796f)
		{
			IFOHMDOEHKM();
		}
	}

	private void KILDJCPLOPP()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private void NLHALEAEDMM()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 0; j < FCLCCEJFIOP.Length; j += 0)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void GBBAHJBECJC()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(DEOGMFOAPLO());
		}
	}

	private void NNBIAIMPNGL()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 0; i < FCLCCEJFIOP.Length; i += 0)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private void KDBJHCAEGCM()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private void HONFDJKKGJK()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 1; i < HFDILBELIKE; i += 0)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(false);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j++)
		{
			FCLCCEJFIOP[j].SetActive(false);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[0].transform.position, NOLFMLNLJJG) > 272f)
		{
			GBBAHJBECJC();
		}
	}

	private void HCEDMLJNOBL()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 0; i < FCLCCEJFIOP.Length; i += 0)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private void HJDLNCOAKIK()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private void FOHGHCPODBJ()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 1; i < FCLCCEJFIOP.Length; i++)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private void GOKBDDFNDFH()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(true);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j++)
		{
			FCLCCEJFIOP[j].SetActive(false);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[1].transform.position, NOLFMLNLJJG) > 1020f)
		{
			MOGAEEEILKK();
		}
	}

	private IEnumerator JILJJAHFHFD()
	{
		return new MAPBNFAFKDM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LJHOPNPHKMP()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(GLCCBPBNPAP());
		}
	}

	private void MKHMCIFFOFJ()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 1; i < FCLCCEJFIOP.Length; i += 0)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 1; j < FCLCCEJFIOP.Length; j += 0)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void IPACPBPPGIA()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(CFNCPPLHACA());
		}
	}

	private void BFMBEDNIGAB()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 1; i < FCLCCEJFIOP.Length; i += 0)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private IEnumerator FGDCHCACCBF()
	{
		return new MAPBNFAFKDM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CFHOODNCOLK()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private void HOKBBFHGACN()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 1; i < FCLCCEJFIOP.Length; i += 0)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private void LMFICKFGEFI()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 1; i < HFDILBELIKE; i += 0)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(false);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j += 0)
		{
			FCLCCEJFIOP[j].SetActive(true);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[1].transform.position, NOLFMLNLJJG) > 1691f)
		{
			NMKGNOLGDPF();
		}
	}

	private void HHLBFDBHDMC()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 1; i < FCLCCEJFIOP.Length; i += 0)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private void LGNKOHDIMGO()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(MBIKKFNCDNL());
		}
	}

	private void LDPGPIHCBCH()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 1; i < FCLCCEJFIOP.Length; i += 0)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private void DEEIEACLPEF()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(true);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j++)
		{
			FCLCCEJFIOP[j].SetActive(false);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[0].transform.position, NOLFMLNLJJG) > 1079f)
		{
			CHICHCGGHKK();
		}
	}

	private void CPCNKHDHDMO()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(CPMHGDFBEDJ());
		}
	}

	private void EJMAJFGPGEC()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 1; i < HFDILBELIKE; i += 0)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(false);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j++)
		{
			FCLCCEJFIOP[j].SetActive(true);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[0].transform.position, NOLFMLNLJJG) > 103f)
		{
			MIADHAJIBII();
		}
	}

	private IEnumerator JLNOPJKACKA()
	{
		FJIPNEKICOD = Vector2.op_Implicit(((Component)this).transform.localPosition);
		LGHAJJOPAIP = Vector2.op_Implicit(((Component)this).transform.localPosition + (NOLFMLNLJJG - FCLCCEJFIOP[0].transform.position));
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
			((Component)this).transform.localPosition = Vector2.op_Implicit(Vector2.Lerp(FJIPNEKICOD, LGHAJJOPAIP, DCGBADKLANM));
			yield return null;
		}
		((Component)this).transform.localPosition = Vector2.op_Implicit(LGHAJJOPAIP);
		ANMAFLKPILP = null;
	}

	private IEnumerator EPAODIGPIFG()
	{
		return new MAPBNFAFKDM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PNNKENLNKMO()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(PHKCPHIBJMN());
		}
	}

	private void GHEOLMMHFJC()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 1; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 0; j < FCLCCEJFIOP.Length; j++)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void HCPKBJDHLAC()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(true);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j++)
		{
			FCLCCEJFIOP[j].SetActive(true);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[1].transform.position, NOLFMLNLJJG) > 1964f)
		{
			LLKKMJGPIKF();
		}
	}

	private void PBKGBPCKOGB()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i++)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(true);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j++)
		{
			FCLCCEJFIOP[j].SetActive(true);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[1].transform.position, NOLFMLNLJJG) > 1206f)
		{
			CPCNKHDHDMO();
		}
	}

	private IEnumerator GOBJDHFCKPE()
	{
		return new MAPBNFAFKDM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GBFPCABGAII()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private IEnumerator MDLCKELPJLK()
	{
		FJIPNEKICOD = Vector2.op_Implicit(((Component)this).transform.localPosition);
		LGHAJJOPAIP = Vector2.op_Implicit(((Component)this).transform.localPosition + (NOLFMLNLJJG - FCLCCEJFIOP[0].transform.position));
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
			((Component)this).transform.localPosition = Vector2.op_Implicit(Vector2.Lerp(FJIPNEKICOD, LGHAJJOPAIP, DCGBADKLANM));
			yield return null;
		}
		((Component)this).transform.localPosition = Vector2.op_Implicit(LGHAJJOPAIP);
		ANMAFLKPILP = null;
	}

	private void KHNGJFBMMCP()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 1; i < HFDILBELIKE; i++)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(false);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j += 0)
		{
			FCLCCEJFIOP[j].SetActive(false);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[1].transform.position, NOLFMLNLJJG) > 409f)
		{
			EONLJGLBMDF();
		}
	}

	private void GKCKLIAANHA()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 0; j < FCLCCEJFIOP.Length; j += 0)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void GIIDLBOACHK()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(ALJPADBBKBF());
		}
	}

	private IEnumerator ANAEIDABEDA()
	{
		FJIPNEKICOD = Vector2.op_Implicit(((Component)this).transform.localPosition);
		LGHAJJOPAIP = Vector2.op_Implicit(((Component)this).transform.localPosition + (NOLFMLNLJJG - FCLCCEJFIOP[0].transform.position));
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
			((Component)this).transform.localPosition = Vector2.op_Implicit(Vector2.Lerp(FJIPNEKICOD, LGHAJJOPAIP, DCGBADKLANM));
			yield return null;
		}
		((Component)this).transform.localPosition = Vector2.op_Implicit(LGHAJJOPAIP);
		ANMAFLKPILP = null;
	}

	private void NEDEBHEIGGJ()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(ALJPADBBKBF());
		}
	}

	private void NJNCKELODLF()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 1; i < HFDILBELIKE; i++)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(true);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j += 0)
		{
			FCLCCEJFIOP[j].SetActive(true);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[0].transform.position, NOLFMLNLJJG) > 1499f)
		{
			JJCJKFPPCKJ();
		}
	}

	private IEnumerator IDLMFDHLOAE()
	{
		FJIPNEKICOD = Vector2.op_Implicit(((Component)this).transform.localPosition);
		LGHAJJOPAIP = Vector2.op_Implicit(((Component)this).transform.localPosition + (NOLFMLNLJJG - FCLCCEJFIOP[0].transform.position));
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
			((Component)this).transform.localPosition = Vector2.op_Implicit(Vector2.Lerp(FJIPNEKICOD, LGHAJJOPAIP, DCGBADKLANM));
			yield return null;
		}
		((Component)this).transform.localPosition = Vector2.op_Implicit(LGHAJJOPAIP);
		ANMAFLKPILP = null;
	}

	private void EKILFCLPAFM()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(CGDFPMAMOAF());
		}
	}

	private IEnumerator DEOGMFOAPLO()
	{
		return new MAPBNFAFKDM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PAAIOEKENCC()
	{
		FJIPNEKICOD = Vector2.op_Implicit(((Component)this).transform.localPosition);
		LGHAJJOPAIP = Vector2.op_Implicit(((Component)this).transform.localPosition + (NOLFMLNLJJG - FCLCCEJFIOP[0].transform.position));
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
			((Component)this).transform.localPosition = Vector2.op_Implicit(Vector2.Lerp(FJIPNEKICOD, LGHAJJOPAIP, DCGBADKLANM));
			yield return null;
		}
		((Component)this).transform.localPosition = Vector2.op_Implicit(LGHAJJOPAIP);
		ANMAFLKPILP = null;
	}

	private void INKOKIGFJBG()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 1; i < HFDILBELIKE; i += 0)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(false);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j += 0)
		{
			FCLCCEJFIOP[j].SetActive(true);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[1].transform.position, NOLFMLNLJJG) > 1170f)
		{
			PJCDEONCDHC();
		}
	}

	private void OnEnable()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 0; j < FCLCCEJFIOP.Length; j++)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private IEnumerator NHLADEPCKLN()
	{
		FJIPNEKICOD = Vector2.op_Implicit(((Component)this).transform.localPosition);
		LGHAJJOPAIP = Vector2.op_Implicit(((Component)this).transform.localPosition + (NOLFMLNLJJG - FCLCCEJFIOP[0].transform.position));
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
			((Component)this).transform.localPosition = Vector2.op_Implicit(Vector2.Lerp(FJIPNEKICOD, LGHAJJOPAIP, DCGBADKLANM));
			yield return null;
		}
		((Component)this).transform.localPosition = Vector2.op_Implicit(LGHAJJOPAIP);
		ANMAFLKPILP = null;
	}

	private void BGDNFLEHAOC()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(PAAIOEKENCC());
		}
	}

	private void ANMOAFFGEOE()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 1; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 0; j < FCLCCEJFIOP.Length; j++)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void MOGAEEEILKK()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(JILJJAHFHFD());
		}
	}

	private void LAABMDDEGCG()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(true);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j++)
		{
			FCLCCEJFIOP[j].SetActive(true);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[1].transform.position, NOLFMLNLJJG) > 77f)
		{
			MPKPGHPHGAL();
		}
	}

	private void AJOAKOCODOC()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 1; j < FCLCCEJFIOP.Length; j++)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void ELPCMDCKLGN()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 1; j < FCLCCEJFIOP.Length; j += 0)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void MHCOLHEDNGN()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i++)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(false);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j++)
		{
			FCLCCEJFIOP[j].SetActive(false);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[1].transform.position, NOLFMLNLJJG) > 514f)
		{
			IFOHMDOEHKM();
		}
	}

	private void ALNPAFIBJGN()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(false);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j += 0)
		{
			FCLCCEJFIOP[j].SetActive(false);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[0].transform.position, NOLFMLNLJJG) > 383f)
		{
			MPKPGHPHGAL();
		}
	}

	private IEnumerator DPEEALMNPKC()
	{
		FJIPNEKICOD = Vector2.op_Implicit(((Component)this).transform.localPosition);
		LGHAJJOPAIP = Vector2.op_Implicit(((Component)this).transform.localPosition + (NOLFMLNLJJG - FCLCCEJFIOP[0].transform.position));
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
			((Component)this).transform.localPosition = Vector2.op_Implicit(Vector2.Lerp(FJIPNEKICOD, LGHAJJOPAIP, DCGBADKLANM));
			yield return null;
		}
		((Component)this).transform.localPosition = Vector2.op_Implicit(LGHAJJOPAIP);
		ANMAFLKPILP = null;
	}

	private void LANGHIOBJIH()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 1; i < FCLCCEJFIOP.Length; i += 0)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private IEnumerator KBHKCBLIDJB()
	{
		FJIPNEKICOD = Vector2.op_Implicit(((Component)this).transform.localPosition);
		LGHAJJOPAIP = Vector2.op_Implicit(((Component)this).transform.localPosition + (NOLFMLNLJJG - FCLCCEJFIOP[0].transform.position));
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
			((Component)this).transform.localPosition = Vector2.op_Implicit(Vector2.Lerp(FJIPNEKICOD, LGHAJJOPAIP, DCGBADKLANM));
			yield return null;
		}
		((Component)this).transform.localPosition = Vector2.op_Implicit(LGHAJJOPAIP);
		ANMAFLKPILP = null;
	}

	private void NMKGNOLGDPF()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(PAAIOEKENCC());
		}
	}

	private void KAANJGEDPIN()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 1; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 1; j < FCLCCEJFIOP.Length; j++)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void OOGDJNMJCNA()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 0; i < FCLCCEJFIOP.Length; i += 0)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 0; j < FCLCCEJFIOP.Length; j++)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void EONLJGLBMDF()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(APPCAFIFBGI());
		}
	}

	private void MJOPALCAKCO()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(GOBJDHFCKPE());
		}
	}

	private void FPJABCNDEEJ()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 1; i < FCLCCEJFIOP.Length; i += 0)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 1; j < FCLCCEJFIOP.Length; j++)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void IEPJAFLDBJJ()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 0; j < FCLCCEJFIOP.Length; j += 0)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void EKCBGJJCDHB()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 1; j < FCLCCEJFIOP.Length; j++)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void NKGGBLECLIB()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 0; i < FCLCCEJFIOP.Length; i += 0)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 1; j < FCLCCEJFIOP.Length; j++)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void CLOKMCONOMN()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 1; i < HFDILBELIKE; i++)
		{
			FCLCCEJFIOP[i].gameObject.SetActive(false);
			FCLCCEJFIOP[i].transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j++)
		{
			FCLCCEJFIOP[j].SetActive(false);
		}
		if (returnToCenter && FCLCCEJFIOP.Length != 0 && Vector3.Distance(FCLCCEJFIOP[1].transform.position, NOLFMLNLJJG) > 1185f)
		{
			MOGAEEEILKK();
		}
	}

	private void LLKKMJGPIKF()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(PAAIOEKENCC());
		}
	}

	private void Start()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				FCLCCEJFIOP[i] = Object.Instantiate<GameObject>(lightPrefab);
				FCLCCEJFIOP[i].transform.parent = ((Component)this).transform;
			}
		}
		NOLFMLNLJJG = ((Component)this).transform.position;
	}

	private void MKJDKGNPJGI()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(GOBJDHFCKPE());
		}
	}

	private void OHIMJBJOGHI()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 0; j < FCLCCEJFIOP.Length; j += 0)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void CHICHCGGHKK()
	{
		if (ANMAFLKPILP == null)
		{
			ANMAFLKPILP = ((MonoBehaviour)this).StartCoroutine(PILCLBJGFJC());
		}
	}

	private IEnumerator PILCLBJGFJC()
	{
		return new MAPBNFAFKDM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NCFCFOKDGAB()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 0; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 0; j < FCLCCEJFIOP.Length; j++)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void OJLGPAJPCHG()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 0; i < FCLCCEJFIOP.Length; i += 0)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 1; j < FCLCCEJFIOP.Length; j += 0)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}

	private void PGDBFGFMGKI()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (FCLCCEJFIOP != null)
		{
			for (int i = 1; i < FCLCCEJFIOP.Length; i++)
			{
				Utils.BLPDAEHPOBA(FCLCCEJFIOP[i]);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		FCLCCEJFIOP = (GameObject[])(object)new GameObject[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 0; j < FCLCCEJFIOP.Length; j++)
		{
			FCLCCEJFIOP[j] = Object.Instantiate<GameObject>(lightPrefab);
			FCLCCEJFIOP[j].transform.parent = ((Component)this).transform;
		}
	}
}
