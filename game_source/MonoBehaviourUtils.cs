using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MonoBehaviourUtils : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class FIIOLAMLFLP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int playerNum;

		public ItemInstance itemInstance;

		public bool drop;

		public int quantity;

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
		public FIIOLAMLFLP(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
			{
				_003C_003E1__state = -1;
				for (int i = 0; i < quantity; i++)
				{
					CraftingInventory.AddItemInstance(playerNum, itemInstance, GLBECJCBBHF: false, null, drop);
				}
				return false;
			}
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
	private sealed class IHIMGAJNCCC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SaveData saveData;

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
		public IHIMGAJNCCC(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				saveData.OGIDPPPNLBI();
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
	private sealed class JMONACAKBNO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform transformTo;

		public Transform parent;

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
		public JMONACAKBNO(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if ((Object)(object)transformTo != (Object)null)
				{
					transformTo.SetParent(parent);
				}
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

	public static MonoBehaviourUtils instance;

	private IEnumerator ALAEHJPDDEP(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD)
	{
		return new FIIOLAMLFLP(1)
		{
			playerNum = JIIGOACEIKL,
			itemInstance = DNLMCHDOMOK,
			quantity = FFDIEOBBFKL,
			drop = HMPDLIPFBGD
		};
	}

	private IEnumerator KPGJJNNLDJP(SaveData MPCLMINGHOC)
	{
		yield return null;
		MPCLMINGHOC.OGIDPPPNLBI();
	}

	private void GHOKECKAICE()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void COKBJNMAMDI()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public static void EKACLIAMLLJ(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.EFIKHHNCKNC(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	private IEnumerator EGFMKJNBNHJ(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		return new JMONACAKBNO(1)
		{
			transformTo = OLOKLKLPLIC,
			parent = DMBHHLKMHOH
		};
	}

	private IEnumerator PLPPHJBKCBN(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		yield return null;
		if ((Object)(object)OLOKLKLPLIC != (Object)null)
		{
			OLOKLKLPLIC.SetParent(DMBHHLKMHOH);
		}
	}

	public static void PMPNNIPLOBI(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.ALAEHJPDDEP(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	public static void EJAMJCJHGKI(SaveData MPCLMINGHOC)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.KGOHNMKNMEK(MPCLMINGHOC));
		}
	}

	private IEnumerator NEKALIKENCD(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD)
	{
		return new FIIOLAMLFLP(1)
		{
			playerNum = JIIGOACEIKL,
			itemInstance = DNLMCHDOMOK,
			quantity = FFDIEOBBFKL,
			drop = HMPDLIPFBGD
		};
	}

	public static void JIGKEDHOBNP(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.CGINPCGCLLF(OLOKLKLPLIC, DMBHHLKMHOH));
		}
	}

	private void OCJOAHDNDIJ()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public static void ECFBBIGFLFG(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.NEKALIKENCD(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	private IEnumerator PMKCJEAIJJP(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD)
	{
		yield return null;
		for (int i = 0; i < FFDIEOBBFKL; i++)
		{
			CraftingInventory.AddItemInstance(JIIGOACEIKL, DNLMCHDOMOK, GLBECJCBBHF: false, null, HMPDLIPFBGD);
		}
	}

	private IEnumerator LHJIDFEKJEG(SaveData MPCLMINGHOC)
	{
		return new IHIMGAJNCCC(1)
		{
			saveData = MPCLMINGHOC
		};
	}

	public static void MLOCNDDCBPM(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.ACJGJMPDEKH(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	private void LHOIJEKIGCG()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public static void NGNLFFLAMKM(SaveData MPCLMINGHOC)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.KPGJJNNLDJP(MPCLMINGHOC));
		}
	}

	public static void JEKOHKMBMAM(SaveData MPCLMINGHOC)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.POOCICLBDCA(MPCLMINGHOC));
		}
	}

	private void PBDNKBPBCHM()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private IEnumerator GKHHDGFFNGF(SaveData MPCLMINGHOC)
	{
		yield return null;
		MPCLMINGHOC.OGIDPPPNLBI();
	}

	public static void PKKNELMAKBL(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.BIIIADDOAME(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	public static void AKCMAICEBJF(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.EOBKCCBBGHJ(OLOKLKLPLIC, DMBHHLKMHOH));
		}
	}

	private void IGNEGEOPLOP()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private IEnumerator NNKBCCLIOGG(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		return new JMONACAKBNO(1)
		{
			transformTo = OLOKLKLPLIC,
			parent = DMBHHLKMHOH
		};
	}

	private void NODKJHJFMCO()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void JDMMNLKLMAA()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void JDHHJKBOJML()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private IEnumerator NBIFDANONNJ(SaveData MPCLMINGHOC)
	{
		yield return null;
		MPCLMINGHOC.OGIDPPPNLBI();
	}

	public static void BAHGBNKHOBJ(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.LBFBIHCJPCP(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	private void PGPPIHJJGDB()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public static void MMHONGFCOBC(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.ADIAICKBOGJ(OLOKLKLPLIC, DMBHHLKMHOH));
		}
	}

	public static void EFADPMPBMBD(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.EFIKHHNCKNC(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	public static void JHPPNLAEOJO(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.EJINJEKNMMH(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	private void CLGBFOIBANN()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public static void ANENABLPIAO(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.PMKCJEAIJJP(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	public static void BJLJKLBAEFE(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.LNIDDMFGBLA(OLOKLKLPLIC, DMBHHLKMHOH));
		}
	}

	public static void KNOOBBIKPLJ(SaveData MPCLMINGHOC)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.KGOHNMKNMEK(MPCLMINGHOC));
		}
	}

	private IEnumerator EOBKCCBBGHJ(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		yield return null;
		if ((Object)(object)OLOKLKLPLIC != (Object)null)
		{
			OLOKLKLPLIC.SetParent(DMBHHLKMHOH);
		}
	}

	private void GNOBDKFFPOL()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public static void KBJMDJMIJBK(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.ADIAICKBOGJ(OLOKLKLPLIC, DMBHHLKMHOH));
		}
	}

	private void KJPECNGCOKK()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void JPFDPIAFACG()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public static void JJDLFGPOMHC(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.EFOPDAIHNNB(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	public static void ANGAJFNANBE(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.LDBLKKFIDOM(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	private IEnumerator AKHMCGEBAEB(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		yield return null;
		if ((Object)(object)OLOKLKLPLIC != (Object)null)
		{
			OLOKLKLPLIC.SetParent(DMBHHLKMHOH);
		}
	}

	public static void NFGCIJINMHH(SaveData MPCLMINGHOC)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.HHOCBMEABAJ(MPCLMINGHOC));
		}
	}

	private void NLNOFEBEBDE()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public static void JHCIPBINCLO(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.EFIKHHNCKNC(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	private IEnumerator PENALNGNKBN(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD)
	{
		yield return null;
		for (int i = 0; i < FFDIEOBBFKL; i++)
		{
			CraftingInventory.AddItemInstance(JIIGOACEIKL, DNLMCHDOMOK, GLBECJCBBHF: false, null, HMPDLIPFBGD);
		}
	}

	public static void LEHLPGAMHLJ(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.NEKALIKENCD(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	private IEnumerator LKKLFIBIHOD(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		yield return null;
		if ((Object)(object)OLOKLKLPLIC != (Object)null)
		{
			OLOKLKLPLIC.SetParent(DMBHHLKMHOH);
		}
	}

	private IEnumerator LNIDDMFGBLA(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		yield return null;
		if ((Object)(object)OLOKLKLPLIC != (Object)null)
		{
			OLOKLKLPLIC.SetParent(DMBHHLKMHOH);
		}
	}

	public static void BMCJJAAJJAH(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.LNIDDMFGBLA(OLOKLKLPLIC, DMBHHLKMHOH));
		}
	}

	public static void GGICFDMHACP(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.PBEPEECGBON(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	private IEnumerator EFIKHHNCKNC(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD)
	{
		yield return null;
		for (int i = 0; i < FFDIEOBBFKL; i++)
		{
			CraftingInventory.AddItemInstance(JIIGOACEIKL, DNLMCHDOMOK, GLBECJCBBHF: false, null, HMPDLIPFBGD);
		}
	}

	public static void KDNCMNCJCOJ(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.OKLGFFAPMKC(OLOKLKLPLIC, DMBHHLKMHOH));
		}
	}

	private IEnumerator EODMFKKNJIK(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD)
	{
		yield return null;
		for (int i = 0; i < FFDIEOBBFKL; i++)
		{
			CraftingInventory.AddItemInstance(JIIGOACEIKL, DNLMCHDOMOK, GLBECJCBBHF: false, null, HMPDLIPFBGD);
		}
	}

	private IEnumerator CJGPNIPHJIM(SaveData MPCLMINGHOC)
	{
		yield return null;
		MPCLMINGHOC.OGIDPPPNLBI();
	}

	public static void OKDMOKHMBJB(SaveData MPCLMINGHOC)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.KKCNNHICBBM(MPCLMINGHOC));
		}
	}

	private IEnumerator EABDBELNFMH(SaveData MPCLMINGHOC)
	{
		yield return null;
		MPCLMINGHOC.OGIDPPPNLBI();
	}

	private void DKNNLPFIBIK()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private IEnumerator POOOFHABCPN(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		return new JMONACAKBNO(1)
		{
			transformTo = OLOKLKLPLIC,
			parent = DMBHHLKMHOH
		};
	}

	private IEnumerator LBFBIHCJPCP(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD)
	{
		return new FIIOLAMLFLP(1)
		{
			playerNum = JIIGOACEIKL,
			itemInstance = DNLMCHDOMOK,
			quantity = FFDIEOBBFKL,
			drop = HMPDLIPFBGD
		};
	}

	public static void CKPBFJGNIKP(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.EFIKHHNCKNC(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	private IEnumerator EJINJEKNMMH(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD)
	{
		return new FIIOLAMLFLP(1)
		{
			playerNum = JIIGOACEIKL,
			itemInstance = DNLMCHDOMOK,
			quantity = FFDIEOBBFKL,
			drop = HMPDLIPFBGD
		};
	}

	private IEnumerator CJAILNDKDGE(SaveData MPCLMINGHOC)
	{
		return new IHIMGAJNCCC(1)
		{
			saveData = MPCLMINGHOC
		};
	}

	public static void ICFCGFGIGNC(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.EFOPDAIHNNB(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	private IEnumerator LDBLKKFIDOM(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD)
	{
		return new FIIOLAMLFLP(1)
		{
			playerNum = JIIGOACEIKL,
			itemInstance = DNLMCHDOMOK,
			quantity = FFDIEOBBFKL,
			drop = HMPDLIPFBGD
		};
	}

	private IEnumerator KDCFOJJOMGG(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD)
	{
		return new FIIOLAMLFLP(1)
		{
			playerNum = JIIGOACEIKL,
			itemInstance = DNLMCHDOMOK,
			quantity = FFDIEOBBFKL,
			drop = HMPDLIPFBGD
		};
	}

	public static void HIJALFFKAJE(SaveData MPCLMINGHOC)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.NBIFDANONNJ(MPCLMINGHOC));
		}
	}

	private IEnumerator ONGOHKJJPAM(SaveData MPCLMINGHOC)
	{
		yield return null;
		MPCLMINGHOC.OGIDPPPNLBI();
	}

	private IEnumerator ADMCKOMGOGN(SaveData MPCLMINGHOC)
	{
		yield return null;
		MPCLMINGHOC.OGIDPPPNLBI();
	}

	private IEnumerator HHOCBMEABAJ(SaveData MPCLMINGHOC)
	{
		yield return null;
		MPCLMINGHOC.OGIDPPPNLBI();
	}

	private IEnumerator JEBIMECKCEH(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD)
	{
		return new FIIOLAMLFLP(1)
		{
			playerNum = JIIGOACEIKL,
			itemInstance = DNLMCHDOMOK,
			quantity = FFDIEOBBFKL,
			drop = HMPDLIPFBGD
		};
	}

	public static void KMLPNCIOPJD(SaveData MPCLMINGHOC)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.CJGPNIPHJIM(MPCLMINGHOC));
		}
	}

	public static void OFKOGGKPGFO(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.OKLGFFAPMKC(OLOKLKLPLIC, DMBHHLKMHOH));
		}
	}

	public static void ICHOHLMPJKK(SaveData MPCLMINGHOC)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.KPGJJNNLDJP(MPCLMINGHOC));
		}
	}

	public static void NNOLJADJHPK(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.OKLGFFAPMKC(OLOKLKLPLIC, DMBHHLKMHOH));
		}
	}

	private IEnumerator HFJAPOCGDFH(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		return new JMONACAKBNO(1)
		{
			transformTo = OLOKLKLPLIC,
			parent = DMBHHLKMHOH
		};
	}

	private void HFPDNCBLNDE()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void OIOLGAOPECC()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public static void FPIBCCMNOMI(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.LONJMALBIEA(OLOKLKLPLIC, DMBHHLKMHOH));
		}
	}

	public static void ODEIDPDLAEB(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.PBEPEECGBON(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	private IEnumerator ELIABDHGGGN(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		yield return null;
		if ((Object)(object)OLOKLKLPLIC != (Object)null)
		{
			OLOKLKLPLIC.SetParent(DMBHHLKMHOH);
		}
	}

	public static void BFFHHMCJLIL(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.AKHMCGEBAEB(OLOKLKLPLIC, DMBHHLKMHOH));
		}
	}

	private void KMBEOPAHKGB()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public static void KPFPPFNNPID(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.LONJMALBIEA(OLOKLKLPLIC, DMBHHLKMHOH));
		}
	}

	public static void LoadTapsNextFrame(SaveData MPCLMINGHOC)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.INCLNOBMCDB(MPCLMINGHOC));
		}
	}

	private IEnumerator PDFEGGGGFLM(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD)
	{
		return new FIIOLAMLFLP(1)
		{
			playerNum = JIIGOACEIKL,
			itemInstance = DNLMCHDOMOK,
			quantity = FFDIEOBBFKL,
			drop = HMPDLIPFBGD
		};
	}

	private IEnumerator KPHMCEHHEOM(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD)
	{
		yield return null;
		for (int i = 0; i < FFDIEOBBFKL; i++)
		{
			CraftingInventory.AddItemInstance(JIIGOACEIKL, DNLMCHDOMOK, GLBECJCBBHF: false, null, HMPDLIPFBGD);
		}
	}

	public static void CPOBHBENFKA(SaveData MPCLMINGHOC)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.HHOCBMEABAJ(MPCLMINGHOC));
		}
	}

	public static void EGJAELCKKLO(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.KDCFOJJOMGG(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	private void HMHCLIBLKLN()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private IEnumerator BACJIONPGCC(SaveData MPCLMINGHOC)
	{
		return new IHIMGAJNCCC(1)
		{
			saveData = MPCLMINGHOC
		};
	}

	private void HEMAHKJEONA()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private IEnumerator CDALEJELIJE(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		yield return null;
		if ((Object)(object)OLOKLKLPLIC != (Object)null)
		{
			OLOKLKLPLIC.SetParent(DMBHHLKMHOH);
		}
	}

	private IEnumerator CDDBGLDOBPO(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD)
	{
		yield return null;
		for (int i = 0; i < FFDIEOBBFKL; i++)
		{
			CraftingInventory.AddItemInstance(JIIGOACEIKL, DNLMCHDOMOK, GLBECJCBBHF: false, null, HMPDLIPFBGD);
		}
	}

	private IEnumerator KKCNNHICBBM(SaveData MPCLMINGHOC)
	{
		return new IHIMGAJNCCC(1)
		{
			saveData = MPCLMINGHOC
		};
	}

	public static void LILFGJPBKIF(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.ADIAICKBOGJ(OLOKLKLPLIC, DMBHHLKMHOH));
		}
	}

	private IEnumerator EDFCHDHHHJA(SaveData MPCLMINGHOC)
	{
		yield return null;
		MPCLMINGHOC.OGIDPPPNLBI();
	}

	private IEnumerator BIIIADDOAME(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD)
	{
		yield return null;
		for (int i = 0; i < FFDIEOBBFKL; i++)
		{
			CraftingInventory.AddItemInstance(JIIGOACEIKL, DNLMCHDOMOK, GLBECJCBBHF: false, null, HMPDLIPFBGD);
		}
	}

	private IEnumerator ADIAICKBOGJ(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		yield return null;
		if ((Object)(object)OLOKLKLPLIC != (Object)null)
		{
			OLOKLKLPLIC.SetParent(DMBHHLKMHOH);
		}
	}

	public static void AddItemNextFrame(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.CDDBGLDOBPO(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	private IEnumerator KGOHNMKNMEK(SaveData MPCLMINGHOC)
	{
		return new IHIMGAJNCCC(1)
		{
			saveData = MPCLMINGHOC
		};
	}

	private void Awake()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public static void HBNILEPPMDL(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.EFOPDAIHNNB(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	private IEnumerator LJLCHKHOMNC(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		yield return null;
		if ((Object)(object)OLOKLKLPLIC != (Object)null)
		{
			OLOKLKLPLIC.SetParent(DMBHHLKMHOH);
		}
	}

	private void HDHPOAPLEJC()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public static void PMBECBAOJNA(SaveData MPCLMINGHOC)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.LHJIDFEKJEG(MPCLMINGHOC));
		}
	}

	private void EIHMDMMOPCM()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public static void NPMLAHEFEHI(SaveData MPCLMINGHOC)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.ADMCKOMGOGN(MPCLMINGHOC));
		}
	}

	private IEnumerator FAHBOPEEFBE(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		return new JMONACAKBNO(1)
		{
			transformTo = OLOKLKLPLIC,
			parent = DMBHHLKMHOH
		};
	}

	public static void KBGEIHAGKDK(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.NJOAGPCBCKO(OLOKLKLPLIC, DMBHHLKMHOH));
		}
	}

	public static void GGNCPCBPLDC(SaveData MPCLMINGHOC)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.ONGOHKJJPAM(MPCLMINGHOC));
		}
	}

	private IEnumerator AOJLGCOCKFP(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		yield return null;
		if ((Object)(object)OLOKLKLPLIC != (Object)null)
		{
			OLOKLKLPLIC.SetParent(DMBHHLKMHOH);
		}
	}

	public static void KGPGNEMLIKG(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.NEKALIKENCD(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	public static void KBPLELLPMGI(SaveData MPCLMINGHOC)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.NBIFDANONNJ(MPCLMINGHOC));
		}
	}

	private IEnumerator PBEPEECGBON(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD)
	{
		yield return null;
		for (int i = 0; i < FFDIEOBBFKL; i++)
		{
			CraftingInventory.AddItemInstance(JIIGOACEIKL, DNLMCHDOMOK, GLBECJCBBHF: false, null, HMPDLIPFBGD);
		}
	}

	public static void MKCCMENJJOP(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.PMKCJEAIJJP(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	private IEnumerator JPJNEDEHPPD(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		yield return null;
		if ((Object)(object)OLOKLKLPLIC != (Object)null)
		{
			OLOKLKLPLIC.SetParent(DMBHHLKMHOH);
		}
	}

	private void IKFNMBJLDGG()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void EFJFJJDGGGI()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public static void KIFNNLCOANL(SaveData MPCLMINGHOC)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.JDOICNPNGAB(MPCLMINGHOC));
		}
	}

	public static void DOPEPLDINBC(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.MNDNENFBIGK(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	public static void JNMPHDIDJHB(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.PLPPHJBKCBN(OLOKLKLPLIC, DMBHHLKMHOH));
		}
	}

	private IEnumerator DPEMJGNEBNO(SaveData MPCLMINGHOC)
	{
		yield return null;
		MPCLMINGHOC.OGIDPPPNLBI();
	}

	private IEnumerator PDJDNMJJLCK(SaveData MPCLMINGHOC)
	{
		return new IHIMGAJNCCC(1)
		{
			saveData = MPCLMINGHOC
		};
	}

	private IEnumerator POOCICLBDCA(SaveData MPCLMINGHOC)
	{
		yield return null;
		MPCLMINGHOC.OGIDPPPNLBI();
	}

	private IEnumerator LDBJMOOMGIC(SaveData MPCLMINGHOC)
	{
		yield return null;
		MPCLMINGHOC.OGIDPPPNLBI();
	}

	public static void CLHHOBOBOJL(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.EOBKCCBBGHJ(OLOKLKLPLIC, DMBHHLKMHOH));
		}
	}

	public static void FEFOKDBKAFH(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.EFIKHHNCKNC(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	private IEnumerator CGINPCGCLLF(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		return new JMONACAKBNO(1)
		{
			transformTo = OLOKLKLPLIC,
			parent = DMBHHLKMHOH
		};
	}

	public static void KGNPICHGLNG(SaveData MPCLMINGHOC)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.JDOICNPNGAB(MPCLMINGHOC));
		}
	}

	private IEnumerator LONJMALBIEA(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		yield return null;
		if ((Object)(object)OLOKLKLPLIC != (Object)null)
		{
			OLOKLKLPLIC.SetParent(DMBHHLKMHOH);
		}
	}

	private void KJHKBGDJNDC()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private IEnumerator INCLNOBMCDB(SaveData MPCLMINGHOC)
	{
		yield return null;
		MPCLMINGHOC.OGIDPPPNLBI();
	}

	private IEnumerator JDOICNPNGAB(SaveData MPCLMINGHOC)
	{
		return new IHIMGAJNCCC(1)
		{
			saveData = MPCLMINGHOC
		};
	}

	public static void HEEEPBPFNCL(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD = false)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.KPHMCEHHEOM(JIIGOACEIKL, DNLMCHDOMOK, FFDIEOBBFKL, HMPDLIPFBGD));
		}
	}

	private IEnumerator EFOPDAIHNNB(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD)
	{
		yield return null;
		for (int i = 0; i < FFDIEOBBFKL; i++)
		{
			CraftingInventory.AddItemInstance(JIIGOACEIKL, DNLMCHDOMOK, GLBECJCBBHF: false, null, HMPDLIPFBGD);
		}
	}

	private IEnumerator OKLGFFAPMKC(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		return new JMONACAKBNO(1)
		{
			transformTo = OLOKLKLPLIC,
			parent = DMBHHLKMHOH
		};
	}

	private IEnumerator MNDNENFBIGK(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD)
	{
		yield return null;
		for (int i = 0; i < FFDIEOBBFKL; i++)
		{
			CraftingInventory.AddItemInstance(JIIGOACEIKL, DNLMCHDOMOK, GLBECJCBBHF: false, null, HMPDLIPFBGD);
		}
	}

	public static void SetParentNextFrame(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.LNIDDMFGBLA(OLOKLKLPLIC, DMBHHLKMHOH));
		}
	}

	private IEnumerator NJOAGPCBCKO(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		yield return null;
		if ((Object)(object)OLOKLKLPLIC != (Object)null)
		{
			OLOKLKLPLIC.SetParent(DMBHHLKMHOH);
		}
	}

	private IEnumerator ACJGJMPDEKH(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HMPDLIPFBGD)
	{
		return new FIIOLAMLFLP(1)
		{
			playerNum = JIIGOACEIKL,
			itemInstance = DNLMCHDOMOK,
			quantity = FFDIEOBBFKL,
			drop = HMPDLIPFBGD
		};
	}

	public static void HIPFNPCHDOK(Transform OLOKLKLPLIC, Transform DMBHHLKMHOH)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.ADIAICKBOGJ(OLOKLKLPLIC, DMBHHLKMHOH));
		}
	}

	private void GONDLJKGLGO()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public static void NGDPNNFAIMI(SaveData MPCLMINGHOC)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			((MonoBehaviour)instance).StartCoroutine(instance.CJAILNDKDGE(MPCLMINGHOC));
		}
	}
}
