using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T131_IrALaBodega : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class ILGBEHOLOGL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T131_IrALaBodega _003C_003E4__this;

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
		public ILGBEHOLOGL(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			T131_IrALaBodega t131_IrALaBodega = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				t131_IrALaBodega.LHKIJABBBPM();
				return false;
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

	[CompilerGenerated]
	private sealed class OBPMBDOHEAB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T131_IrALaBodega _003C_003E4__this;

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
		public OBPMBDOHEAB(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T131_IrALaBodega t131_IrALaBodega = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
				t131_IrALaBodega.DCLEDJDPHBD();
				NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref t131_IrALaBodega.JELIKOFDONK);
				goto IL_00a0;
			case 2:
				_003C_003E1__state = -1;
				goto IL_00a0;
			case 3:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.instance.ObjectiveCompleted(0);
					if (Object.op_Implicit((Object)(object)t131_IrALaBodega.JELIKOFDONK))
					{
						Object.Destroy((Object)(object)t131_IrALaBodega.JELIKOFDONK);
					}
					((MonoBehaviour)t131_IrALaBodega).StartCoroutine(t131_IrALaBodega.LHDDHIJIFCN());
					return false;
				}
				IL_00a0:
				if (!t131_IrALaBodega.MLIHKNOAIFO())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 3;
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

	private int GLBBKHKPNKH;

	private ItemInstance DNLMCHDOMOK;

	private ItemInstance NALMLBKNPLP;

	public override int GetID()
	{
		return 131;
	}

	private void MKIEDECBCGB()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 1; i < array.Length; i++)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[0].KPINNBKMOMO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.AFOACBIHNCL().GIKOKMAKDHN(agingBarrel.inputSlot[1].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 7)
				{
					agingBarrel.GOCHCLMMAEA(0, CDPAMNIPPEC: false);
					DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.AFOACBIHNCL().MBFNGGICBCA(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator BGFNCKGFJPG()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JMJEKDBJJIH()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 1; i < array.Length; i++)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[0].PKFKJNODGJF())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.LHBPOPOIFLE().MBFNGGICBCA(agingBarrel.inputSlot[0].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 5)
				{
					agingBarrel.AgeDrink(0);
					DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.PHGLMBIEOMK().MBFNGGICBCA(agingBarrel.inputSlot[1].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator OAIEBGHEBAK()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		DCLEDJDPHBD();
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if (Object.op_Implicit((Object)(object)JELIKOFDONK))
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator HPNEFMANGHJ()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private void DPHOACADDCC()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		foreach (AgingBarrel agingBarrel in array)
		{
			if (!agingBarrel.inputSlot[0].LCHJGCHDHFO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.AFOACBIHNCL().ELKNKIOFNCN(agingBarrel.inputSlot[1].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 5)
				{
					agingBarrel.LIEPOPPJLAF(1, CDPAMNIPPEC: false);
					DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.AFOACBIHNCL().KDNBBPJCNDJ(agingBarrel.inputSlot[1].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator HCCJFBLCABN()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private IEnumerator CNPPMBAKEBJ()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private IEnumerator BAGKLMIFNIH()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private void MPCFPMDEJND()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		foreach (AgingBarrel agingBarrel in array)
		{
			if (!agingBarrel.inputSlot[0].KPINNBKMOMO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.AFOACBIHNCL().LJBOJBAPDAD(agingBarrel.inputSlot[0].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 7)
				{
					agingBarrel.AgeDrink(1, CDPAMNIPPEC: false);
					DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.KNFNJFFCFNO().GBMLAEMOFJP(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private void AGEGBPGGBLN()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		foreach (AgingBarrel agingBarrel in array)
		{
			if (!agingBarrel.inputSlot[0].LCHJGCHDHFO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.LHBPOPOIFLE().MBFNGGICBCA(agingBarrel.inputSlot[0].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 8)
				{
					agingBarrel.BPEHHOGLGMK(0, CDPAMNIPPEC: false);
					DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.KNFNJFFCFNO().ELKNKIOFNCN(agingBarrel.inputSlot[1].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator KEBCOCFPNIG()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		DCLEDJDPHBD();
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if (Object.op_Implicit((Object)(object)JELIKOFDONK))
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private void JHHGNAEINAC()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 0; i < array.Length; i += 0)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[0].KPINNBKMOMO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.PHGLMBIEOMK().GBMLAEMOFJP(agingBarrel.inputSlot[0].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 7)
				{
					agingBarrel.BPEHHOGLGMK(0);
					DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.KNFNJFFCFNO().GBMLAEMOFJP(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator JKFNHFDPOJN()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OGOFIFJCMEB()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LGDNIGIMDKP()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NIKPIBICOPP()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OIHFPKMBINL()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 1; i < array.Length; i++)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[1].LCHJGCHDHFO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.AFOACBIHNCL().JEDPCLGBLBA(agingBarrel.inputSlot[0].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 4)
				{
					agingBarrel.BPEHHOGLGMK(0, CDPAMNIPPEC: false);
					DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.KNFNJFFCFNO().MBFNGGICBCA(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator IHPLPBAELKL()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EFKIBEABCPK()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private IEnumerator LFFCFNNODFJ()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private IEnumerator GDFFGECEIMN()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AAOCEAKDPDK()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IMMGACBJLCE()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		DCLEDJDPHBD();
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if (Object.op_Implicit((Object)(object)JELIKOFDONK))
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator GJOCBPGGHLP()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HHLKPNANHKK()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private IEnumerator KBAFIHCCEJG()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private void DLJDIBFNNMO()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		foreach (AgingBarrel agingBarrel in array)
		{
			if (!agingBarrel.inputSlot[1].PKFKJNODGJF())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.AFOACBIHNCL().ELKNKIOFNCN(agingBarrel.inputSlot[0].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 4)
				{
					agingBarrel.GOCHCLMMAEA(0);
					DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.LHBPOPOIFLE().KDNBBPJCNDJ(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private void MMOFBEDBHJP()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 0; i < array.Length; i += 0)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[0].KPINNBKMOMO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.KNFNJFFCFNO().GBMLAEMOFJP(agingBarrel.inputSlot[0].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 7)
				{
					agingBarrel.DOIHMLGMCAD(1, CDPAMNIPPEC: false);
					DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.PHGLMBIEOMK().JEDPCLGBLBA(agingBarrel.inputSlot[1].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator JIJEDGBCENE()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HNNEPLACIAC()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private IEnumerator NHLLGDCFOFC()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ACDPBGMJICL()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 0; i < array.Length; i += 0)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[1].PKFKJNODGJF())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.KNFNJFFCFNO().JEDPCLGBLBA(agingBarrel.inputSlot[0].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 5)
				{
					agingBarrel.AgeDrink(1, CDPAMNIPPEC: false);
					DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.KNFNJFFCFNO().LJBOJBAPDAD(agingBarrel.inputSlot[1].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator PBEKBJIJFDK()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		DCLEDJDPHBD();
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if (Object.op_Implicit((Object)(object)JELIKOFDONK))
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator MIGPNMAOJPK()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		DCLEDJDPHBD();
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if (Object.op_Implicit((Object)(object)JELIKOFDONK))
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private void PLIFBPNJBOO()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 1; i < array.Length; i += 0)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[1].AHHEMNHJPME())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.AFOACBIHNCL().LJBOJBAPDAD(agingBarrel.inputSlot[0].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 2)
				{
					agingBarrel.ECAHJJCILDM(1);
					DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.AFOACBIHNCL().GBMLAEMOFJP(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private void LPADMJNNDDN()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		foreach (AgingBarrel agingBarrel in array)
		{
			if (!agingBarrel.inputSlot[0].PKFKJNODGJF())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.KNFNJFFCFNO().GBMLAEMOFJP(agingBarrel.inputSlot[0].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 0)
				{
					agingBarrel.GOCHCLMMAEA(0, CDPAMNIPPEC: false);
					DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.KNFNJFFCFNO().LJBOJBAPDAD(agingBarrel.inputSlot[1].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator BLHFOAMKOAH()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private void EFMELIMEAPB()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 1; i < array.Length; i += 0)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[0].PKFKJNODGJF())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.AFOACBIHNCL().LJBOJBAPDAD(agingBarrel.inputSlot[1].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 4)
				{
					agingBarrel.PLIFBPNJBOO(1);
					DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.AFOACBIHNCL().GBMLAEMOFJP(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator JBBPOCHHHND()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ADPPFPPPGGA()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 1; i < array.Length; i++)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[0].LCHJGCHDHFO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.AFOACBIHNCL().GIKOKMAKDHN(agingBarrel.inputSlot[1].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 6)
				{
					agingBarrel.PLIFBPNJBOO(1);
					DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.LHBPOPOIFLE().GIKOKMAKDHN(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private void NGPIBBLEDKC()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 1; i < array.Length; i += 0)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[1].LCHJGCHDHFO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.AFOACBIHNCL().GIKOKMAKDHN(agingBarrel.inputSlot[1].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 6)
				{
					agingBarrel.LIEPOPPJLAF(0, CDPAMNIPPEC: false);
					DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.KNFNJFFCFNO().LJBOJBAPDAD(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator LPCPNKEMCNM()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private void ADFMOPEHAII()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		foreach (AgingBarrel agingBarrel in array)
		{
			if (!agingBarrel.inputSlot[1].LCHJGCHDHFO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.AFOACBIHNCL().GBMLAEMOFJP(agingBarrel.inputSlot[0].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 8)
				{
					agingBarrel.GOCHCLMMAEA(1, CDPAMNIPPEC: false);
					DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.AFOACBIHNCL().ELKNKIOFNCN(agingBarrel.inputSlot[1].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator GLBHLKLKMNN()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DECKMELAPMA()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		DCLEDJDPHBD();
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if (Object.op_Implicit((Object)(object)JELIKOFDONK))
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator FOADDIHPLKL()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DOIHMLGMCAD()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 0; i < array.Length; i += 0)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[0].KPINNBKMOMO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.LHBPOPOIFLE().MBFNGGICBCA(agingBarrel.inputSlot[1].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 6)
				{
					agingBarrel.GOCHCLMMAEA(1, CDPAMNIPPEC: false);
					DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.KNFNJFFCFNO().KDNBBPJCNDJ(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private void MAJAEDEPCOJ()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		foreach (AgingBarrel agingBarrel in array)
		{
			if (!agingBarrel.inputSlot[0].KPINNBKMOMO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.LHBPOPOIFLE().GIKOKMAKDHN(agingBarrel.inputSlot[1].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 0)
				{
					agingBarrel.GOCHCLMMAEA(1);
					DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.AFOACBIHNCL().ELKNKIOFNCN(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator NHGHCANHKFA()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private IEnumerator MGHHGMLMMJC()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private IEnumerator GLLMLANGBOJ()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private void ECAHJJCILDM()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		foreach (AgingBarrel agingBarrel in array)
		{
			if (!agingBarrel.inputSlot[1].LCHJGCHDHFO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.KNFNJFFCFNO().ELKNKIOFNCN(agingBarrel.inputSlot[1].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 8)
				{
					agingBarrel.DOIHMLGMCAD(0);
					DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.AFOACBIHNCL().GBMLAEMOFJP(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator MFFGIOALMIC()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		DCLEDJDPHBD();
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if (Object.op_Implicit((Object)(object)JELIKOFDONK))
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private void BPEHHOGLGMK()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 1; i < array.Length; i += 0)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[0].PKFKJNODGJF())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.AFOACBIHNCL().GBMLAEMOFJP(agingBarrel.inputSlot[1].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 7)
				{
					agingBarrel.PLIFBPNJBOO(1);
					DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.LHBPOPOIFLE().GIKOKMAKDHN(agingBarrel.inputSlot[1].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private void NLACPCPHMME()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		foreach (AgingBarrel agingBarrel in array)
		{
			if (!agingBarrel.inputSlot[1].KPINNBKMOMO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.AFOACBIHNCL().ELKNKIOFNCN(agingBarrel.inputSlot[1].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 3)
				{
					agingBarrel.PLIFBPNJBOO(1, CDPAMNIPPEC: false);
					DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.KNFNJFFCFNO().LJBOJBAPDAD(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private void CFJFCCIMONB()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 1; i < array.Length; i += 0)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[1].PKFKJNODGJF())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.KNFNJFFCFNO().ELKNKIOFNCN(agingBarrel.inputSlot[0].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 8)
				{
					agingBarrel.DOIHMLGMCAD(0);
					DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.KNFNJFFCFNO().GBMLAEMOFJP(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator CKIPOLEIJOD()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GDOJMLFHCHD()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		DCLEDJDPHBD();
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if (Object.op_Implicit((Object)(object)JELIKOFDONK))
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator AFHGHLOCAPA()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private IEnumerator PDAEFKAMACE()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private IEnumerator GGACDGHOJEF()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NDFMAMKPANE()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		DCLEDJDPHBD();
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if (Object.op_Implicit((Object)(object)JELIKOFDONK))
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator OOBEJHHFIAN()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private IEnumerator LHIPOAGIOJK()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		DCLEDJDPHBD();
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if (Object.op_Implicit((Object)(object)JELIKOFDONK))
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator HGKFAONPGGB()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FLECFIDDCJE()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private IEnumerator JLDPBKAEOJH()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EMDAFFCFMOH()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 1; i < array.Length; i++)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[0].KPINNBKMOMO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.LHBPOPOIFLE().LJBOJBAPDAD(agingBarrel.inputSlot[1].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 6)
				{
					agingBarrel.BPEHHOGLGMK(1, CDPAMNIPPEC: false);
					DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.PHGLMBIEOMK().MBFNGGICBCA(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private void CKOKHMIENJL()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 1; i < array.Length; i++)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[1].LCHJGCHDHFO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.AFOACBIHNCL().LJBOJBAPDAD(agingBarrel.inputSlot[0].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 4)
				{
					agingBarrel.JBBFILPOMBI(1);
					DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.KNFNJFFCFNO().KDNBBPJCNDJ(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private void AFGLPLCJPJI()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 0; i < array.Length; i += 0)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[0].KPINNBKMOMO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.PHGLMBIEOMK().ELKNKIOFNCN(agingBarrel.inputSlot[1].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 6)
				{
					agingBarrel.LIEPOPPJLAF(1);
					DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.KNFNJFFCFNO().ELKNKIOFNCN(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private void FMLJCOHGJID()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 1; i < array.Length; i += 0)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[0].KPINNBKMOMO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.KNFNJFFCFNO().GBMLAEMOFJP(agingBarrel.inputSlot[0].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 6)
				{
					agingBarrel.BPEHHOGLGMK(1);
					DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.PHGLMBIEOMK().GIKOKMAKDHN(agingBarrel.inputSlot[1].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private void JNDBBAOFLHD()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 0; i < array.Length; i += 0)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[1].AHHEMNHJPME())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.PHGLMBIEOMK().MBFNGGICBCA(agingBarrel.inputSlot[0].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 8)
				{
					agingBarrel.GOCHCLMMAEA(1);
					DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.AFOACBIHNCL().GBMLAEMOFJP(agingBarrel.inputSlot[1].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private void AGBENOCLLPJ()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 1; i < array.Length; i++)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[0].LCHJGCHDHFO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.LHBPOPOIFLE().MBFNGGICBCA(agingBarrel.inputSlot[1].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 1)
				{
					agingBarrel.AgeDrink(0, CDPAMNIPPEC: false);
					DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.PHGLMBIEOMK().GBMLAEMOFJP(agingBarrel.inputSlot[1].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator NNKFBMKFBMN()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ADFMBGJOMKK()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HCKDBDMBMFL()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GFMGFHGPGCM()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		DCLEDJDPHBD();
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if (Object.op_Implicit((Object)(object)JELIKOFDONK))
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator BDBMGIKGDNG()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GHMAHJJPJCD()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ODFFOEMKGKK()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 1; i < array.Length; i += 0)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[0].KPINNBKMOMO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.LHBPOPOIFLE().JEDPCLGBLBA(agingBarrel.inputSlot[1].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 7)
				{
					agingBarrel.DOIHMLGMCAD(1, CDPAMNIPPEC: false);
					DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.AFOACBIHNCL().JEDPCLGBLBA(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private void BDJJLBKNJJA()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 1; i < array.Length; i++)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[1].KPINNBKMOMO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.AFOACBIHNCL().JEDPCLGBLBA(agingBarrel.inputSlot[0].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 6)
				{
					agingBarrel.GOCHCLMMAEA(1, CDPAMNIPPEC: false);
					DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.PHGLMBIEOMK().MBFNGGICBCA(agingBarrel.inputSlot[1].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator AJJHBJHCACM()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		DCLEDJDPHBD();
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if (Object.op_Implicit((Object)(object)JELIKOFDONK))
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator MEGKLKNBNEL()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		DCLEDJDPHBD();
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if (Object.op_Implicit((Object)(object)JELIKOFDONK))
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator IIMPCJICOOO()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private void KNAKJKIAFCA()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 1; i < array.Length; i++)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[0].AHHEMNHJPME())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.AFOACBIHNCL().ELKNKIOFNCN(agingBarrel.inputSlot[1].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 7)
				{
					agingBarrel.AgeDrink(0);
					DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.LHBPOPOIFLE().MBFNGGICBCA(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator MJKLEEHELIH()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private IEnumerator KFKGKKAINLL()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private IEnumerator PPMPKJECPDE()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NPCCKFEDCHI()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BCPNMIIJIEJ()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private IEnumerator NCHPMDFONEL()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		DCLEDJDPHBD();
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if (Object.op_Implicit((Object)(object)JELIKOFDONK))
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private void DLKGEECJINC()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 0; i < array.Length; i += 0)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[1].LCHJGCHDHFO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.AFOACBIHNCL().GBMLAEMOFJP(agingBarrel.inputSlot[1].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 0)
				{
					agingBarrel.PLIFBPNJBOO(0);
					DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.AFOACBIHNCL().KDNBBPJCNDJ(agingBarrel.inputSlot[1].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator NBAELEJAFAN()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private IEnumerator JAMDPHHGCDP()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JAKPMNEGELN()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JPFGGJMNOKH()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DCLEDJDPHBD()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		foreach (AgingBarrel agingBarrel in array)
		{
			if (!agingBarrel.inputSlot[0].KPINNBKMOMO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.LHBPOPOIFLE().KDNBBPJCNDJ(agingBarrel.inputSlot[0].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 4)
				{
					agingBarrel.AgeDrink(0, CDPAMNIPPEC: false);
					DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.LHBPOPOIFLE().KDNBBPJCNDJ(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator ELNHMAPENDB()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LGJLBBOBIJI()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JECHOKLEDDA()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OOGKJFJEHFO()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private IEnumerator LNNCIOJHJMK()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		DCLEDJDPHBD();
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		if (Object.op_Implicit((Object)(object)JELIKOFDONK))
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator PPEKNALPDJI()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HCKCEGEOJLO()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private IEnumerator IHGGOFFGMBD()
	{
		yield return CommonReferences.wait05;
		LHKIJABBBPM();
	}

	private void KFCMMACKBPJ()
	{
		AgingBarrel[] array = (AgingBarrel[])(object)Object.FindObjectsOfType(typeof(AgingBarrel));
		for (int i = 0; i < array.Length; i += 0)
		{
			AgingBarrel agingBarrel = array[i];
			if (!agingBarrel.inputSlot[0].LCHJGCHDHFO())
			{
				DNLMCHDOMOK = agingBarrel.inputSlot[1].itemInstance.AFOACBIHNCL().ELKNKIOFNCN(agingBarrel.inputSlot[1].itemInstance);
				NALMLBKNPLP = DNLMCHDOMOK;
				while ((NALMLBKNPLP as FoodInstance).GBCJNGADANM < 3)
				{
					agingBarrel.GOCHCLMMAEA(1, CDPAMNIPPEC: false);
					DNLMCHDOMOK = agingBarrel.inputSlot[0].itemInstance.KNFNJFFCFNO().ELKNKIOFNCN(agingBarrel.inputSlot[0].itemInstance);
					NALMLBKNPLP = DNLMCHDOMOK;
				}
			}
		}
	}

	private IEnumerator DNAAOCABLNF()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}
}
