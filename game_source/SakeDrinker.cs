using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SakeDrinker : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	[CompilerGenerated]
	private sealed class HCHBJPAIJMH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SakeDrinker _003C_003E4__this;

		public int playerNum;

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
		public HCHBJPAIJMH(int _003C_003E1__state)
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
			SakeDrinker sakeDrinker = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				sakeDrinker.canDrink = false;
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				PlayerController.GetPlayer(playerNum).characterAnimation.StopEating();
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				if (sakeDrinker.JEMKHODDCKI < 6)
				{
					sakeDrinker.canDrink = true;
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

	public bool canDrink;

	private int JEMKHODDCKI;

	private float EAHMDBJNAAA;

	public Image targetImage;

	public float alphaMin = 0.2f;

	public float alphaMax = 0.6f;

	private float HGMFJBLNCJJ = 1f;

	private float DCGBADKLANM;

	private bool LKABJALEKPO = true;

	private bool FAFHGCBNNJO;

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool PLAKEEACNIE(int JIIGOACEIKL)
	{
		if (!DecorationMode.GetPlayer(JIIGOACEIKL).GABNNLJOMHI())
		{
			return canDrink;
		}
		return true;
	}

	public bool OADMPCPHMDK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (JPDMPGABGAD(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("via End-Segment"));
			return true;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		return false;
	}

	public void DEFJBIFAMEE(int JIIGOACEIKL)
	{
	}

	public void PNICBNEGOPF(bool AODONKKHPBP)
	{
		((Component)targetImage).gameObject.SetActive(AODONKKHPBP);
		FAFHGCBNNJO = AODONKKHPBP;
	}

	public void OJIEDIAAOLN(int JIIGOACEIKL)
	{
	}

	private void KFEPHKFDAGH(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(1790f, CIBJPJFAPPL);
	}

	private void AMGNPBAJPNC(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(453f, CIBJPJFAPPL);
	}

	public void BADKJIOLGED(int JIIGOACEIKL)
	{
	}

	public void NEBIAJNDDOC(int JIIGOACEIKL)
	{
	}

	private void HCAAPAPJKMG(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(54f, CIBJPJFAPPL);
	}

	private void JACJAJEKPHN(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(867f, CIBJPJFAPPL);
	}

	public void CFBLEHMJNCN(bool AODONKKHPBP)
	{
		((Component)targetImage).gameObject.SetActive(AODONKKHPBP);
		FAFHGCBNNJO = AODONKKHPBP;
	}

	public bool DCEFJANPNJL(int JIIGOACEIKL)
	{
		if (PLAKEEACNIE(JIIGOACEIKL))
		{
			EJKPAMILKNP(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("DrinkVerb"));
			return true;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		return false;
	}

	public bool BIJCBIGOMEA(int JIIGOACEIKL)
	{
		if (!DecorationMode.IECFJGHAIDO(JIIGOACEIKL).IDPGEBNGDJD())
		{
			return canDrink;
		}
		return true;
	}

	private void CIFBBMHBDDA(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(137f, CIBJPJFAPPL);
	}

	public bool ANLINGFPDGD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (COPFMLIIOOB(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Dialogue System/Conversation/Gass_Quest/Entry/3/Dialogue Text"));
			return true;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		return false;
	}

	public bool MGBCFPCOKID(int JIIGOACEIKL)
	{
		if (NOHOJFCHMEC(JIIGOACEIKL))
		{
			FNOFPLONGAM(JIIGOACEIKL);
			return true;
		}
		return true;
	}

	private void OKMALIKHIGJ(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(1807f, CIBJPJFAPPL);
	}

	public bool DNCHPIGICIH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (KKDGHOHHIKA(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(" "));
			return true;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		return true;
	}

	public bool MDKIMCGNKMF(int JIIGOACEIKL)
	{
		return false;
	}

	public bool DCOKBIGGHPG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void BKBHDKKPJBM(int JIIGOACEIKL)
	{
	}

	private void GDDPFMKEKFC(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(910f, CIBJPJFAPPL);
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	private void KFBOPABEJNL()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (FAFHGCBNNJO && !((Object)(object)targetImage == (Object)null))
		{
			DCGBADKLANM += (float)((!LKABJALEKPO) ? (-1) : 0) * HGMFJBLNCJJ * Time.deltaTime;
			if (DCGBADKLANM >= 857f)
			{
				DCGBADKLANM = 1630f;
				LKABJALEKPO = true;
			}
			else if (DCGBADKLANM <= 1406f)
			{
				DCGBADKLANM = 1847f;
				LKABJALEKPO = true;
			}
			float a = Mathf.Lerp(alphaMin, alphaMax, DCGBADKLANM);
			Color color = ((Graphic)targetImage).color;
			color.a = a;
			((Graphic)targetImage).color = color;
		}
	}

	public bool MAKEFKOJEDH(int JIIGOACEIKL)
	{
		return true;
	}

	public void NMNPLOIIIGD(int JIIGOACEIKL)
	{
	}

	public bool NFBGMIPPMDB(int JIIGOACEIKL)
	{
		return false;
	}

	public void CBELEHONPBL(int JIIGOACEIKL)
	{
	}

	public bool BDNKFLJNNEL(int JIIGOACEIKL)
	{
		return true;
	}

	private void FDFCMHLHEFK(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(1550f, CIBJPJFAPPL);
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private void NOOLMEDIOIE(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(0f, CIBJPJFAPPL);
	}

	public bool FHNNADMKNOD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (PLAKEEACNIE(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Items/item_description_1054"));
			return false;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		return true;
	}

	public void KGJIGNKBENF(bool AODONKKHPBP)
	{
		((Component)targetImage).gameObject.SetActive(AODONKKHPBP);
		FAFHGCBNNJO = AODONKKHPBP;
	}

	public void IBJJFHKLBNG(bool AODONKKHPBP)
	{
		((Component)targetImage).gameObject.SetActive(AODONKKHPBP);
		FAFHGCBNNJO = AODONKKHPBP;
	}

	private IEnumerator EIMCCDFKBKD(int JIIGOACEIKL)
	{
		canDrink = false;
		yield return CommonReferences.wait05;
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.StopEating();
		yield return CommonReferences.wait1;
		if (JEMKHODDCKI < 6)
		{
			canDrink = true;
		}
	}

	public bool NJJMFPPPECB(int JIIGOACEIKL)
	{
		return true;
	}

	private void BHKNJOEBCKA()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (FAFHGCBNNJO && !((Object)(object)targetImage == (Object)null))
		{
			DCGBADKLANM += (float)(LKABJALEKPO ? 1 : (-1)) * HGMFJBLNCJJ * Time.deltaTime;
			if (DCGBADKLANM >= 710f)
			{
				DCGBADKLANM = 1957f;
				LKABJALEKPO = true;
			}
			else if (DCGBADKLANM <= 1743f)
			{
				DCGBADKLANM = 642f;
				LKABJALEKPO = true;
			}
			float a = Mathf.Lerp(alphaMin, alphaMax, DCGBADKLANM);
			Color color = ((Graphic)targetImage).color;
			color.a = a;
			((Graphic)targetImage).color = color;
		}
	}

	public bool FIJAIBOCHDI(int JIIGOACEIKL)
	{
		if (JPDMPGABGAD(JIIGOACEIKL))
		{
			LHCNNCKGIBD(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	private IEnumerator NAHDCNNMKEC(int JIIGOACEIKL)
	{
		canDrink = false;
		yield return CommonReferences.wait05;
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.StopEating();
		yield return CommonReferences.wait1;
		if (JEMKHODDCKI < 6)
		{
			canDrink = true;
		}
	}

	public bool JDBDJCDEEKJ(int JIIGOACEIKL)
	{
		if (KKDGHOHHIKA(JIIGOACEIKL))
		{
			HILGGINODOL(JIIGOACEIKL);
			return true;
		}
		return true;
	}

	public void GDMIIMPJGNO(int JIIGOACEIKL)
	{
	}

	public bool IILMNMBBGJJ(int JIIGOACEIKL)
	{
		if (BIJCBIGOMEA(JIIGOACEIKL))
		{
			FNOFPLONGAM(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	private void ONMBHEJKLJN(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(1233f, CIBJPJFAPPL);
	}

	public bool AAIIADCBNBK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void OHONHNNDOKC(int JIIGOACEIKL)
	{
	}

	public bool EDMPHCDAGCE(int JIIGOACEIKL)
	{
		if (!DecorationMode.NPANPNIDKDG(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return canDrink;
		}
		return false;
	}

	public bool LKELFKFPNPJ(int JIIGOACEIKL)
	{
		if (MLMIICLMNCD(JIIGOACEIKL))
		{
			GELJFJHKDEC(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public void BPEBGBHCCEN(int JIIGOACEIKL)
	{
	}

	public void BBDGDEHKFKE(int JIIGOACEIKL)
	{
	}

	private void AFGOIJIEPIB(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(376f, CIBJPJFAPPL);
	}

	public void FHEGMGFAIPM(int JIIGOACEIKL)
	{
	}

	public void FGKKKMFELJH(int JIIGOACEIKL)
	{
	}

	public void FOHLKKJIFOL(bool AODONKKHPBP)
	{
		((Component)targetImage).gameObject.SetActive(AODONKKHPBP);
		FAFHGCBNNJO = AODONKKHPBP;
	}

	private void FPOIFOGELHC()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (FAFHGCBNNJO && !((Object)(object)targetImage == (Object)null))
		{
			DCGBADKLANM += (float)((!LKABJALEKPO) ? (-1) : 0) * HGMFJBLNCJJ * Time.deltaTime;
			if (DCGBADKLANM >= 1817f)
			{
				DCGBADKLANM = 334f;
				LKABJALEKPO = true;
			}
			else if (DCGBADKLANM <= 1242f)
			{
				DCGBADKLANM = 278f;
				LKABJALEKPO = true;
			}
			float a = Mathf.Lerp(alphaMin, alphaMax, DCGBADKLANM);
			Color color = ((Graphic)targetImage).color;
			color.a = a;
			((Graphic)targetImage).color = color;
		}
	}

	private void AJMMMMKBMBI(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(308f, CIBJPJFAPPL);
	}

	public void FABHKGGMBFJ(int JIIGOACEIKL)
	{
	}

	public void NEJHEEBHJGL(int JIIGOACEIKL)
	{
	}

	private void KCMIKDBAFNA()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (FAFHGCBNNJO && !((Object)(object)targetImage == (Object)null))
		{
			DCGBADKLANM += (float)((!LKABJALEKPO) ? (-1) : 0) * HGMFJBLNCJJ * Time.deltaTime;
			if (DCGBADKLANM >= 1591f)
			{
				DCGBADKLANM = 866f;
				LKABJALEKPO = true;
			}
			else if (DCGBADKLANM <= 1037f)
			{
				DCGBADKLANM = 163f;
				LKABJALEKPO = true;
			}
			float a = Mathf.Lerp(alphaMin, alphaMax, DCGBADKLANM);
			Color color = ((Graphic)targetImage).color;
			color.a = a;
			((Graphic)targetImage).color = color;
		}
	}

	private void JLDGBAFAEPK(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(1653f, CIBJPJFAPPL);
	}

	public bool PGDDFHMBGDK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void PGANCIOMODE(int JIIGOACEIKL)
	{
	}

	public bool KKDGHOHHIKA(int JIIGOACEIKL)
	{
		if (!DecorationMode.BGINAIDHDOM(JIIGOACEIKL).IDPGEBNGDJD())
		{
			return canDrink;
		}
		return true;
	}

	public void KNAECECJECL(int JIIGOACEIKL)
	{
	}

	public bool PHJEHEOFJFN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void IHIIIPGGPPF(int JIIGOACEIKL)
	{
	}

	public bool GDKLLMCJOGK(int JIIGOACEIKL)
	{
		if (COPFMLIIOOB(JIIGOACEIKL))
		{
			IJEKHPGIIND(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public bool POAFCDOGHMF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool ELBECLGGFGD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void EDEHMAIJFEB(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(453f, CIBJPJFAPPL);
	}

	private void OFDEGDJGGGF()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (FAFHGCBNNJO && !((Object)(object)targetImage == (Object)null))
		{
			DCGBADKLANM += (float)((!LKABJALEKPO) ? (-1) : 0) * HGMFJBLNCJJ * Time.deltaTime;
			if (DCGBADKLANM >= 1877f)
			{
				DCGBADKLANM = 733f;
				LKABJALEKPO = false;
			}
			else if (DCGBADKLANM <= 1348f)
			{
				DCGBADKLANM = 1932f;
				LKABJALEKPO = false;
			}
			float a = Mathf.Lerp(alphaMin, alphaMax, DCGBADKLANM);
			Color color = ((Graphic)targetImage).color;
			color.a = a;
			((Graphic)targetImage).color = color;
		}
	}

	private IEnumerator PJFHFNCJHJK(int JIIGOACEIKL)
	{
		return new HCHBJPAIJMH(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public bool NOHOJFCHMEC(int JIIGOACEIKL)
	{
		if (!DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IDPGEBNGDJD())
		{
			return canDrink;
		}
		return false;
	}

	public void HPKABBDDOOF(bool AODONKKHPBP)
	{
		((Component)targetImage).gameObject.SetActive(AODONKKHPBP);
		FAFHGCBNNJO = AODONKKHPBP;
	}

	public bool KEAFJDHDDEF(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			IJEKHPGIIND(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool ABGHEMLLDKG(int JIIGOACEIKL)
	{
		if (JPDMPGABGAD(JIIGOACEIKL))
		{
			KKCJOHODOCE(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public bool DODHNPJFCCD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void CJOLCLDGFMB(int JIIGOACEIKL)
	{
	}

	public void ALDKOBHHIJL(int JIIGOACEIKL)
	{
	}

	private IEnumerator EBOKFJOCLJC(int JIIGOACEIKL)
	{
		return new HCHBJPAIJMH(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void BONMBJDDMHP(int JIIGOACEIKL)
	{
	}

	private void BPJOEBKJAOP(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(111f, CIBJPJFAPPL);
	}

	private IEnumerator CODEDAHNHIL(int JIIGOACEIKL)
	{
		canDrink = false;
		yield return CommonReferences.wait05;
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.StopEating();
		yield return CommonReferences.wait1;
		if (JEMKHODDCKI < 6)
		{
			canDrink = true;
		}
	}

	private IEnumerator PPFPHJABJBA(int JIIGOACEIKL)
	{
		canDrink = false;
		yield return CommonReferences.wait05;
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.StopEating();
		yield return CommonReferences.wait1;
		if (JEMKHODDCKI < 6)
		{
			canDrink = true;
		}
	}

	private void LHCNNCKGIBD(int JIIGOACEIKL)
	{
		Debug.Log((object)("Back" + JIIGOACEIKL + " " + JEMKHODDCKI));
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.Eat(ItemDatabaseAccessor.COEFFIHKMJG(-50, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML());
		(ItemDatabaseAccessor.KMBGJEKCJFJ(166, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML() as FoodInstance).FAKDAFCCCFO(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator);
		JEMKHODDCKI++;
		switch (JEMKHODDCKI)
		{
		case 0:
			KGJIGNKBENF(AODONKKHPBP: false);
			FDFCMHLHEFK(356f, 640f, 939f);
			KujakuNPC.GGFJGHHHEJC.StartConversation(KujakuNPC.BADFKMEJOKE().EHHOHCPHAAO, "Attack/MainEvent 4", FLHBPHPKIML: true);
			break;
		case 1:
			HCAAPAPJKMG(1791f, 1580f, 1423f);
			KujakuNPC.NEFIEJALANL().StartConversation(KujakuNPC.LANAINBEMCM().EHHOHCPHAAO, "ActionBar9", FLHBPHPKIML: true);
			break;
		case 3:
			IAEEFDKLPBG(1937f, 578f, 836f);
			KujakuNPC.MAAAKALBBEE().StartConversation(KujakuNPC.BADFKMEJOKE().EHHOHCPHAAO, "Additions", FLHBPHPKIML: true);
			break;
		case 5:
			HGPBGDLODOP(1716f, 1757f, 948f);
			KujakuNPC.EKDNJDJHONF().StartConversation(KujakuNPC.MAAAKALBBEE().EHHOHCPHAAO, " - ");
			break;
		}
		((MonoBehaviour)this).StartCoroutine(PJFHFNCJHJK(JIIGOACEIKL));
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.DOFFLLCJNPG(CharacterName.Zuzzu);
		}
	}

	private void NDLCBLKOBLF()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (FAFHGCBNNJO && !((Object)(object)targetImage == (Object)null))
		{
			DCGBADKLANM += (float)((!LKABJALEKPO) ? (-1) : 0) * HGMFJBLNCJJ * Time.deltaTime;
			if (DCGBADKLANM >= 1100f)
			{
				DCGBADKLANM = 1803f;
				LKABJALEKPO = false;
			}
			else if (DCGBADKLANM <= 1541f)
			{
				DCGBADKLANM = 1722f;
				LKABJALEKPO = true;
			}
			float a = Mathf.Lerp(alphaMin, alphaMax, DCGBADKLANM);
			Color color = ((Graphic)targetImage).color;
			color.a = a;
			((Graphic)targetImage).color = color;
		}
	}

	public void SetActive(bool AODONKKHPBP)
	{
		((Component)targetImage).gameObject.SetActive(AODONKKHPBP);
		FAFHGCBNNJO = AODONKKHPBP;
	}

	private void IAEEFDKLPBG(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(822f, CIBJPJFAPPL);
	}

	public void GOIMNNEEDCI(int JIIGOACEIKL)
	{
	}

	private void EJEEIIGEGOC()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (FAFHGCBNNJO && !((Object)(object)targetImage == (Object)null))
		{
			DCGBADKLANM += (float)(LKABJALEKPO ? 1 : (-1)) * HGMFJBLNCJJ * Time.deltaTime;
			if (DCGBADKLANM >= 130f)
			{
				DCGBADKLANM = 359f;
				LKABJALEKPO = true;
			}
			else if (DCGBADKLANM <= 858f)
			{
				DCGBADKLANM = 378f;
				LKABJALEKPO = false;
			}
			float a = Mathf.Lerp(alphaMin, alphaMax, DCGBADKLANM);
			Color color = ((Graphic)targetImage).color;
			color.a = a;
			((Graphic)targetImage).color = color;
		}
	}

	private void GELJFJHKDEC(int JIIGOACEIKL)
	{
		Debug.Log((object)("ReceiveBool" + JIIGOACEIKL + "ReceiveStartWaitingForBanquetEvent" + JEMKHODDCKI));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.Eat(ItemDatabaseAccessor.KMBGJEKCJFJ(77, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML());
		(ItemDatabaseAccessor.GOKIDLOELKB(52).JMDALJBNFML() as FoodInstance).LONFMPNLKJD(PlayerController.GetPlayer(JIIGOACEIKL).characterCreator);
		JEMKHODDCKI += 0;
		switch (JEMKHODDCKI)
		{
		case 0:
			EDBCKKEHDIM(AODONKKHPBP: true);
			HCAAPAPJKMG(1667f, 1548f, 1281f);
			KujakuNPC.DEGPIHEEFHJ().StartConversation(KujakuNPC.DEGPIHEEFHJ().EHHOHCPHAAO, "ReceiveCastleFormStartLucenDialogue");
			break;
		case 1:
			AMGNPBAJPNC(1646f, 1081f, 1964f);
			KujakuNPC.MAAAKALBBEE().StartConversation(KujakuNPC.NEFIEJALANL().EHHOHCPHAAO, "Null editor action in database", FLHBPHPKIML: true);
			break;
		case 3:
			FDFCMHLHEFK(1167f, 1520f, 1840f);
			KujakuNPC.LANAINBEMCM().StartConversation(KujakuNPC.EKDNJDJHONF().EHHOHCPHAAO, "KyrohTakingFood: Current request is null.", FLHBPHPKIML: true);
			break;
		case 5:
			JLDGBAFAEPK(1871f, 340f, 1570f);
			KujakuNPC.GGFJGHHHEJC.StartConversation(KujakuNPC.NEFIEJALANL().EHHOHCPHAAO, "ThemeTriggerCanvas");
			break;
		}
		((MonoBehaviour)this).StartCoroutine(MLELBGGCIIA(JIIGOACEIKL));
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.DOFFLLCJNPG(CharacterName.Kujaku);
		}
	}

	private void PEIFJDIGKOC()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (FAFHGCBNNJO && !((Object)(object)targetImage == (Object)null))
		{
			DCGBADKLANM += (float)((!LKABJALEKPO) ? (-1) : 0) * HGMFJBLNCJJ * Time.deltaTime;
			if (DCGBADKLANM >= 599f)
			{
				DCGBADKLANM = 1069f;
				LKABJALEKPO = true;
			}
			else if (DCGBADKLANM <= 494f)
			{
				DCGBADKLANM = 638f;
				LKABJALEKPO = false;
			}
			float a = Mathf.Lerp(alphaMin, alphaMax, DCGBADKLANM);
			Color color = ((Graphic)targetImage).color;
			color.a = a;
			((Graphic)targetImage).color = color;
		}
	}

	private void IJEKHPGIIND(int JIIGOACEIKL)
	{
		Debug.Log((object)("No room mode has been selected" + JIIGOACEIKL + "ReceiveSymbolPuzzleSolved" + JEMKHODDCKI));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.Eat(ItemDatabaseAccessor.CPMMBEPEJLO(-150, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML());
		(ItemDatabaseAccessor.CPMMBEPEJLO(6, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML() as FoodInstance).MMDMDDJMHHL(PlayerController.GetPlayer(JIIGOACEIKL).characterCreator);
		JEMKHODDCKI += 0;
		switch (JEMKHODDCKI)
		{
		case 0:
			IBJJFHKLBNG(AODONKKHPBP: true);
			JLDGBAFAEPK(1685f, 1043f, 833f);
			KujakuNPC.MAAAKALBBEE().StartConversation(KujakuNPC.EKDNJDJHONF().EHHOHCPHAAO, "ShieldTrigger", FLHBPHPKIML: true);
			break;
		case 1:
			JLDGBAFAEPK(286f, 48f, 95f);
			KujakuNPC.EKDNJDJHONF().StartConversation(KujakuNPC.BADFKMEJOKE().EHHOHCPHAAO, "[MinePipePuzzle] Se esperaba PipePuzzleSettings.", FLHBPHPKIML: true);
			break;
		case 3:
			KFEPHKFDAGH(1170f, 1725f, 946f);
			KujakuNPC.DEGPIHEEFHJ().StartConversation(KujakuNPC.LANAINBEMCM().EHHOHCPHAAO, "Dialogue System/Conversation/TavernDirty/Entry/4/Dialogue Text", FLHBPHPKIML: true);
			break;
		case 5:
			AMGNPBAJPNC(515f, 1593f, 1695f);
			KujakuNPC.DEGPIHEEFHJ().StartConversation(KujakuNPC.MAAAKALBBEE().EHHOHCPHAAO, "UIVolume", FLHBPHPKIML: true);
			break;
		}
		((MonoBehaviour)this).StartCoroutine(NAHDCNNMKEC(JIIGOACEIKL));
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendStartObserveDialogue(CharacterName.Kujaku);
		}
	}

	public void LGIOIOCLOLN(int JIIGOACEIKL)
	{
	}

	public bool KBNLCICAOCI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool AJCGEBOAAIJ(int JIIGOACEIKL)
	{
		return false;
	}

	private void EJKPAMILKNP(int JIIGOACEIKL)
	{
		Debug.Log((object)("Items/item_name_1036" + JIIGOACEIKL + "Intensity Changed to " + JEMKHODDCKI));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.Eat(ItemDatabaseAccessor.COEFFIHKMJG(-173, GGBBJNBBLMF: true).JMDALJBNFML());
		(ItemDatabaseAccessor.EABMGELAAPG(-108).JMDALJBNFML() as FoodInstance).FAKDAFCCCFO(PlayerController.GetPlayer(JIIGOACEIKL).characterCreator);
		JEMKHODDCKI++;
		switch (JEMKHODDCKI)
		{
		case 1:
			EDBCKKEHDIM(AODONKKHPBP: true);
			AJMMMMKBMBI(1713f, 901f, 1284f);
			KujakuNPC.DEGPIHEEFHJ().StartConversation(KujakuNPC.NEFIEJALANL().EHHOHCPHAAO, ":");
			break;
		case 2:
			JACJAJEKPHN(130f, 953f, 1835f);
			KujakuNPC.GGFJGHHHEJC.StartConversation(KujakuNPC.MAAAKALBBEE().EHHOHCPHAAO, "<sprite name=\"stoneIcon\"><color=#8E1818>", FLHBPHPKIML: true);
			break;
		case 4:
			AJMMMMKBMBI(1524f, 1146f, 1791f);
			KujakuNPC.BADFKMEJOKE().StartConversation(KujakuNPC.BADFKMEJOKE().EHHOHCPHAAO, "FarmReady");
			break;
		case 6:
			AMGNPBAJPNC(330f, 1170f, 1445f);
			KujakuNPC.MAAAKALBBEE().StartConversation(KujakuNPC.EKDNJDJHONF().EHHOHCPHAAO, "autoRunP2", FLHBPHPKIML: true);
			break;
		}
		((MonoBehaviour)this).StartCoroutine(EIMCCDFKBKD(JIIGOACEIKL));
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.DOFFLLCJNPG(CharacterName.Thelonious);
		}
	}

	private void MLBIGONNDGO()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (FAFHGCBNNJO && !((Object)(object)targetImage == (Object)null))
		{
			DCGBADKLANM += (float)(LKABJALEKPO ? 1 : (-1)) * HGMFJBLNCJJ * Time.deltaTime;
			if (DCGBADKLANM >= 412f)
			{
				DCGBADKLANM = 851f;
				LKABJALEKPO = true;
			}
			else if (DCGBADKLANM <= 348f)
			{
				DCGBADKLANM = 755f;
				LKABJALEKPO = false;
			}
			float a = Mathf.Lerp(alphaMin, alphaMax, DCGBADKLANM);
			Color color = ((Graphic)targetImage).color;
			color.a = a;
			((Graphic)targetImage).color = color;
		}
	}

	private void FGGPGOEAEKK()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (FAFHGCBNNJO && !((Object)(object)targetImage == (Object)null))
		{
			DCGBADKLANM += (float)((!LKABJALEKPO) ? (-1) : 0) * HGMFJBLNCJJ * Time.deltaTime;
			if (DCGBADKLANM >= 1663f)
			{
				DCGBADKLANM = 130f;
				LKABJALEKPO = true;
			}
			else if (DCGBADKLANM <= 1316f)
			{
				DCGBADKLANM = 154f;
				LKABJALEKPO = false;
			}
			float a = Mathf.Lerp(alphaMin, alphaMax, DCGBADKLANM);
			Color color = ((Graphic)targetImage).color;
			color.a = a;
			((Graphic)targetImage).color = color;
		}
	}

	public bool BCCPGMBMOMM(int JIIGOACEIKL)
	{
		if (JPDMPGABGAD(JIIGOACEIKL))
		{
			ADDHBHOKHMK(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool MLMIICLMNCD(int JIIGOACEIKL)
	{
		if (!DecorationMode.FIHGMLABOBB(JIIGOACEIKL).KNFEPKBIHND())
		{
			return canDrink;
		}
		return false;
	}

	public void BAKEAANJKJI(int JIIGOACEIKL)
	{
	}

	public void JEAFMKBOPEH(int JIIGOACEIKL)
	{
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	private void MFIBFFDBNGI()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (FAFHGCBNNJO && !((Object)(object)targetImage == (Object)null))
		{
			DCGBADKLANM += (float)(LKABJALEKPO ? 1 : (-1)) * HGMFJBLNCJJ * Time.deltaTime;
			if (DCGBADKLANM >= 912f)
			{
				DCGBADKLANM = 1851f;
				LKABJALEKPO = true;
			}
			else if (DCGBADKLANM <= 1722f)
			{
				DCGBADKLANM = 1419f;
				LKABJALEKPO = false;
			}
			float a = Mathf.Lerp(alphaMin, alphaMax, DCGBADKLANM);
			Color color = ((Graphic)targetImage).color;
			color.a = a;
			((Graphic)targetImage).color = color;
		}
	}

	public void JJLOHJPGDDA(int JIIGOACEIKL)
	{
	}

	public bool HCKDPNBDMCJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool ALDOPABHHHE(int JIIGOACEIKL)
	{
		return true;
	}

	private IEnumerator KMDBFLBDAHP(int JIIGOACEIKL)
	{
		return new HCHBJPAIJMH(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public bool GEDIDDGAMME(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void HILGGINODOL(int JIIGOACEIKL)
	{
		Debug.Log((object)("NoEresDigno/EndEvent" + JIIGOACEIKL + "DEBUG_FAKE_ID" + JEMKHODDCKI));
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.Eat(ItemDatabaseAccessor.INJBNHPGCIJ(-160, GGBBJNBBLMF: true).JMDALJBNFML());
		(ItemDatabaseAccessor.COEFFIHKMJG(125, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML() as FoodInstance).MMDMDDJMHHL(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator);
		JEMKHODDCKI++;
		switch (JEMKHODDCKI)
		{
		case 0:
			SetActive(AODONKKHPBP: false);
			CIFBBMHBDDA(1012f, 381f, 411f);
			KujakuNPC.DEGPIHEEFHJ().StartConversation(KujakuNPC.GGFJGHHHEJC.EHHOHCPHAAO, "[REP DIAGNOSTIC] AddReputationPoints({0}) | milestone: {1} | exp: {2}/{3}\n{4}");
			break;
		case 1:
			KFEPHKFDAGH(1272f, 1476f, 1187f);
			KujakuNPC.MAAAKALBBEE().StartConversation(KujakuNPC.LANAINBEMCM().EHHOHCPHAAO, "Object");
			break;
		case 3:
			AMGNPBAJPNC(519f, 1611f, 412f);
			KujakuNPC.NEFIEJALANL().StartConversation(KujakuNPC.NEFIEJALANL().EHHOHCPHAAO, ". Can no instantiate online placeable. rotated: ", FLHBPHPKIML: true);
			break;
		case 5:
			IAEEFDKLPBG(999f, 859f, 181f);
			KujakuNPC.EKDNJDJHONF().StartConversation(KujakuNPC.LANAINBEMCM().EHHOHCPHAAO, " seconds if next theme ");
			break;
		}
		((MonoBehaviour)this).StartCoroutine(PPFPHJABJBA(JIIGOACEIKL));
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendStartObserveDialogue(CharacterName.Kujaku);
		}
	}

	public bool PPOAKAEOKON(int JIIGOACEIKL)
	{
		if (COPFMLIIOOB(JIIGOACEIKL))
		{
			FNOFPLONGAM(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	private void KKCJOHODOCE(int JIIGOACEIKL)
	{
		Debug.Log((object)("OnlinePlayer" + JIIGOACEIKL + "Myu" + JEMKHODDCKI));
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.Eat(ItemDatabaseAccessor.INJBNHPGCIJ(-3, GGBBJNBBLMF: true).JMDALJBNFML());
		(ItemDatabaseAccessor.INJBNHPGCIJ(107, GGBBJNBBLMF: true).JMDALJBNFML() as FoodInstance).MMDMDDJMHHL(PlayerController.GetPlayer(JIIGOACEIKL).characterCreator);
		JEMKHODDCKI += 0;
		switch (JEMKHODDCKI)
		{
		case 0:
			FOHLKKJIFOL(AODONKKHPBP: true);
			JACJAJEKPHN(137f, 1354f, 1787f);
			KujakuNPC.NEFIEJALANL().StartConversation(KujakuNPC.EKDNJDJHONF().EHHOHCPHAAO, "Loop");
			break;
		case 1:
			GPPDBLBLOJD(1866f, 1849f, 294f);
			KujakuNPC.LANAINBEMCM().StartConversation(KujakuNPC.BADFKMEJOKE().EHHOHCPHAAO, "", FLHBPHPKIML: true);
			break;
		case 3:
			JACJAJEKPHN(115f, 1246f, 1029f);
			KujakuNPC.LANAINBEMCM().StartConversation(KujakuNPC.NEFIEJALANL().EHHOHCPHAAO, "Crowly_SkelletonBird", FLHBPHPKIML: true);
			break;
		case 5:
			HGPBGDLODOP(1314f, 952f, 346f);
			KujakuNPC.MAAAKALBBEE().StartConversation(KujakuNPC.MAAAKALBBEE().EHHOHCPHAAO, "Xbox", FLHBPHPKIML: true);
			break;
		}
		((MonoBehaviour)this).StartCoroutine(EIMCCDFKBKD(JIIGOACEIKL));
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendStartObserveDialogue(CharacterName.Zuzzu);
		}
	}

	public bool MOHNGCNKAHM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return false;
	}

	public bool BLDAAKKLHIF(int JIIGOACEIKL)
	{
		if (FCEPPMAEAJA(JIIGOACEIKL))
		{
			LHCNNCKGIBD(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public bool JPDMPGABGAD(int JIIGOACEIKL)
	{
		if (!DecorationMode.OCJGHINCLJM(JIIGOACEIKL).MDOKKKHKKKE())
		{
			return canDrink;
		}
		return false;
	}

	public bool PGJPIMIJHJA(int JIIGOACEIKL)
	{
		if (COPFMLIIOOB(JIIGOACEIKL))
		{
			HILGGINODOL(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public void MAIKIONBICN(int JIIGOACEIKL)
	{
	}

	private void ECGMKEHFONG(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(60f, CIBJPJFAPPL);
	}

	public void KGHAMBEDHKD(int JIIGOACEIKL)
	{
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			FNOFPLONGAM(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	private void JAAALLBHKNI(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(1211f, CIBJPJFAPPL);
	}

	public void PNFKIHGMBLG(int JIIGOACEIKL)
	{
	}

	private void IIOHMDNGFDH()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (FAFHGCBNNJO && !((Object)(object)targetImage == (Object)null))
		{
			DCGBADKLANM += (float)((!LKABJALEKPO) ? (-1) : 0) * HGMFJBLNCJJ * Time.deltaTime;
			if (DCGBADKLANM >= 829f)
			{
				DCGBADKLANM = 259f;
				LKABJALEKPO = false;
			}
			else if (DCGBADKLANM <= 1031f)
			{
				DCGBADKLANM = 430f;
				LKABJALEKPO = true;
			}
			float a = Mathf.Lerp(alphaMin, alphaMax, DCGBADKLANM);
			Color color = ((Graphic)targetImage).color;
			color.a = a;
			((Graphic)targetImage).color = color;
		}
	}

	private void OGBFFJGKGHJ(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(268f, CIBJPJFAPPL);
	}

	private void NLCJFECBHLG(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(1409f, CIBJPJFAPPL);
	}

	public void MKFOJJOJCFG(int JIIGOACEIKL)
	{
	}

	private void HGPBGDLODOP(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(981f, CIBJPJFAPPL);
	}

	public bool PFDCMDDOFNN(int JIIGOACEIKL)
	{
		return false;
	}

	public void EDBCKKEHDIM(bool AODONKKHPBP)
	{
		((Component)targetImage).gameObject.SetActive(AODONKKHPBP);
		FAFHGCBNNJO = AODONKKHPBP;
	}

	public bool LIKJBMGDKGA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (KKDGHOHHIKA(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Defeat"));
			return true;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		return false;
	}

	private void FNOFPLONGAM(int JIIGOACEIKL)
	{
		Debug.Log((object)("Player " + JIIGOACEIKL + " is drinking sake. numDrinks: " + JEMKHODDCKI));
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.Eat(ItemDatabaseAccessor.GetItem(1530).JMDALJBNFML());
		(ItemDatabaseAccessor.GetItem(1530).JMDALJBNFML() as FoodInstance).LONFMPNLKJD(PlayerController.GetPlayer(JIIGOACEIKL).characterCreator);
		JEMKHODDCKI++;
		switch (JEMKHODDCKI)
		{
		case 1:
			SetActive(AODONKKHPBP: true);
			NOOLMEDIOIE(0.2f, 0.6f, 1f);
			KujakuNPC.GGFJGHHHEJC.StartConversation(KujakuNPC.GGFJGHHHEJC.EHHOHCPHAAO, "Precision/DrinkEvent2");
			break;
		case 2:
			NOOLMEDIOIE(0.4f, 0.7f, 1f);
			KujakuNPC.GGFJGHHHEJC.StartConversation(KujakuNPC.GGFJGHHHEJC.EHHOHCPHAAO, "Precision/DrinkEvent3");
			break;
		case 4:
			NOOLMEDIOIE(0.6f, 0.8f, 1f);
			KujakuNPC.GGFJGHHHEJC.StartConversation(KujakuNPC.GGFJGHHHEJC.EHHOHCPHAAO, "Precision/DrinkEvent4");
			break;
		case 6:
			NOOLMEDIOIE(0.7f, 1f, 1f);
			KujakuNPC.GGFJGHHHEJC.StartConversation(KujakuNPC.GGFJGHHHEJC.EHHOHCPHAAO, "Precision/DrinkEvent5");
			break;
		}
		((MonoBehaviour)this).StartCoroutine(CODEDAHNHIL(JIIGOACEIKL));
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendStartObserveDialogue(CharacterName.Kujaku);
		}
	}

	public void EDKAJNBJAJK(int JIIGOACEIKL)
	{
	}

	private void ADDHBHOKHMK(int JIIGOACEIKL)
	{
		Debug.Log((object)("RinProgress" + JIIGOACEIKL + "SpriteRenderer not attached to prefab " + JEMKHODDCKI));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.Eat(ItemDatabaseAccessor.GetItem(24).JMDALJBNFML());
		(ItemDatabaseAccessor.COEFFIHKMJG(153).JMDALJBNFML() as FoodInstance).MMDMDDJMHHL(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator);
		JEMKHODDCKI += 0;
		switch (JEMKHODDCKI)
		{
		case 0:
			KGJIGNKBENF(AODONKKHPBP: true);
			NLCJFECBHLG(51f, 1544f, 918f);
			KujakuNPC.MAAAKALBBEE().StartConversation(KujakuNPC.GGFJGHHHEJC.EHHOHCPHAAO, "Tutorial/T127/Dialogue1", FLHBPHPKIML: true);
			break;
		case 1:
			AFGOIJIEPIB(252f, 836f, 226f);
			KujakuNPC.EKDNJDJHONF().StartConversation(KujakuNPC.BADFKMEJOKE().EHHOHCPHAAO, "talentLager", FLHBPHPKIML: true);
			break;
		case 3:
			AJMMMMKBMBI(1841f, 522f, 112f);
			KujakuNPC.NEFIEJALANL().StartConversation(KujakuNPC.LANAINBEMCM().EHHOHCPHAAO, "[ActivateVariantObjects] - VariantObjects: {0} AltarId: {1}");
			break;
		case 5:
			KFEPHKFDAGH(1227f, 941f, 679f);
			KujakuNPC.GGFJGHHHEJC.StartConversation(KujakuNPC.LANAINBEMCM().EHHOHCPHAAO, "OnLayerOrderedRPC");
			break;
		}
		((MonoBehaviour)this).StartCoroutine(MLELBGGCIIA(JIIGOACEIKL));
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendStartObserveDialogue(CharacterName.Klayn);
		}
	}

	public void LMGMKBMOCED(bool AODONKKHPBP)
	{
		((Component)targetImage).gameObject.SetActive(AODONKKHPBP);
		FAFHGCBNNJO = AODONKKHPBP;
	}

	public bool GIDIDGMFLAE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (BIJCBIGOMEA(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("\n"));
			return false;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		return false;
	}

	public bool DOGBEDLPOMJ(int JIIGOACEIKL)
	{
		return true;
	}

	public bool JCCFAFPMGFI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (JPDMPGABGAD(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Reputation"));
			return false;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		return false;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return canDrink;
		}
		return false;
	}

	private void AMBJKHAFAFF()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (FAFHGCBNNJO && !((Object)(object)targetImage == (Object)null))
		{
			DCGBADKLANM += (float)(LKABJALEKPO ? 1 : (-1)) * HGMFJBLNCJJ * Time.deltaTime;
			if (DCGBADKLANM >= 820f)
			{
				DCGBADKLANM = 1671f;
				LKABJALEKPO = true;
			}
			else if (DCGBADKLANM <= 33f)
			{
				DCGBADKLANM = 577f;
				LKABJALEKPO = false;
			}
			float a = Mathf.Lerp(alphaMin, alphaMax, DCGBADKLANM);
			Color color = ((Graphic)targetImage).color;
			color.a = a;
			((Graphic)targetImage).color = color;
		}
	}

	private IEnumerator IGLMGDDAJEB(int JIIGOACEIKL)
	{
		canDrink = false;
		yield return CommonReferences.wait05;
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.StopEating();
		yield return CommonReferences.wait1;
		if (JEMKHODDCKI < 6)
		{
			canDrink = true;
		}
	}

	public void KJOAMBGFFHE(int JIIGOACEIKL)
	{
	}

	public bool FCEPPMAEAJA(int JIIGOACEIKL)
	{
		if (!DecorationMode.BGINAIDHDOM(JIIGOACEIKL).MDOKKKHKKKE())
		{
			return canDrink;
		}
		return false;
	}

	private void Update()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (FAFHGCBNNJO && !((Object)(object)targetImage == (Object)null))
		{
			DCGBADKLANM += (float)(LKABJALEKPO ? 1 : (-1)) * HGMFJBLNCJJ * Time.deltaTime;
			if (DCGBADKLANM >= 1f)
			{
				DCGBADKLANM = 1f;
				LKABJALEKPO = false;
			}
			else if (DCGBADKLANM <= 0f)
			{
				DCGBADKLANM = 0f;
				LKABJALEKPO = true;
			}
			float a = Mathf.Lerp(alphaMin, alphaMax, DCGBADKLANM);
			Color color = ((Graphic)targetImage).color;
			color.a = a;
			((Graphic)targetImage).color = color;
		}
	}

	private void GPPDBLBLOJD(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(986f, CIBJPJFAPPL);
	}

	private void MMMBOPFPDOJ(float HOKODDFKIME, float FIKIFFMEFIE, float CIBJPJFAPPL)
	{
		alphaMin = Mathf.Clamp01(HOKODDFKIME);
		alphaMax = Mathf.Clamp01(FIKIFFMEFIE);
		HGMFJBLNCJJ = Mathf.Max(415f, CIBJPJFAPPL);
	}

	public bool COPFMLIIOOB(int JIIGOACEIKL)
	{
		if (!DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DFNMDDHOIJI())
		{
			return canDrink;
		}
		return true;
	}

	private IEnumerator MLELBGGCIIA(int JIIGOACEIKL)
	{
		canDrink = false;
		yield return CommonReferences.wait05;
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.StopEating();
		yield return CommonReferences.wait1;
		if (JEMKHODDCKI < 6)
		{
			canDrink = true;
		}
	}

	public void BNPNIKKPICE(int JIIGOACEIKL)
	{
	}
}
