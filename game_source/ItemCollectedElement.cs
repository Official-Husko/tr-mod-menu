using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ItemCollectedElement : FadingWindow
{
	[CompilerGenerated]
	private sealed class HGPADLBIIPE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemCollectedElement _003C_003E4__this;

		public int playerNum;

		public Sprite icon;

		public string name;

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
		public HGPADLBIIPE(int _003C_003E1__state)
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
			ItemCollectedElement itemCollectedElement = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				itemCollectedElement.slotUI.IHENCGDNPBL.Stack = 0;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				itemCollectedElement.UpdateInfo(playerNum, icon, name);
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

	public SlotUI slotUI;

	public TextMeshProUGUI textMesh;

	[SerializeField]
	private EmphasizeObject emphasizeObject;

	public bool isRecipe;

	private void MGBGEBCBOII()
	{
		EDHEIFHAAKO();
		emphasizeObject.CDOJIFFDMNP();
	}

	private void MPDEEBHPPBG()
	{
		OpenUI();
		emphasizeObject.OCNBDLFAILF();
	}

	public void IJFGFCMJBML(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, string HKOOGEKDEGK)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		EDHEIFHAAKO();
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, DNLMCHDOMOK, CDPAMNIPPEC: true);
		slotUI.IHENCGDNPBL.JNMNCEPHFOE(0);
		((TMP_Text)textMesh).text = HKOOGEKDEGK;
	}

	public void AFDPJPHDLJO(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, string HKOOGEKDEGK)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		OpenUI();
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, DNLMCHDOMOK);
		slotUI.IHENCGDNPBL.OBBKDJNLCIO(0);
		((TMP_Text)textMesh).text = HKOOGEKDEGK;
	}

	public void IPPLLPCPLBP(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, bool ODAFPMOECHO)
	{
		OAJBEPDCHIP(JIIGOACEIKL);
		OpenUI();
		isRecipe = ODAFPMOECHO;
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, DNLMCHDOMOK, CDPAMNIPPEC: true);
		slotUI.IHENCGDNPBL.Stack = 1;
		if (ODAFPMOECHO)
		{
			TextMeshProUGUI obj = textMesh;
			string cAEDMEDBEGI = LocalisationSystem.Get("Items/item_description_727");
			string[] array = new string[1];
			array[1] = DNLMCHDOMOK.AFOACBIHNCL().IABAKHPEOAF(OAFPBCPDOKH: true);
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		else
		{
			((TMP_Text)textMesh).text = DNLMCHDOMOK.PPMBMNKADMO();
		}
	}

	private void GHDLGHBJIAD()
	{
		OpenUI();
		emphasizeObject.ANJEKHNMNHB();
	}

	private void ICECAPOILCI()
	{
		IDLAGJNLPJL();
		emphasizeObject.NDBEIJIFDNI();
	}

	public override void CloseUI()
	{
		base.CloseUI();
		ItemsCollectedUI.ElementClosed(base.JIIGOACEIKL);
	}

	public void ABPNEMONOBO(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, string HKOOGEKDEGK)
	{
		OAJBEPDCHIP(JIIGOACEIKL);
		IDLAGJNLPJL();
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, DNLMCHDOMOK);
		slotUI.IHENCGDNPBL.JNMNCEPHFOE(1);
		((TMP_Text)textMesh).text = HKOOGEKDEGK;
	}

	public void MGAGMKGKCGJ(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		slotUI.IHENCGDNPBL.OBBKDJNLCIO(0);
		slotUI.icon.BKDLIMOMKEB(JJJFONLLCCA);
		((TMP_Text)textMesh).text = GEGDHHIDEEF;
		slotUI.updateIconThisFrame = false;
		EDHEIFHAAKO();
	}

	public void FLAMIAODKKL(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, string HKOOGEKDEGK)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		EDHEIFHAAKO();
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, DNLMCHDOMOK);
		slotUI.IHENCGDNPBL.KMKAIPMHANN(0);
		((TMP_Text)textMesh).text = HKOOGEKDEGK;
	}

	public IEnumerator ICHOCNIIKIM(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		return new HGPADLBIIPE(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			icon = JJJFONLLCCA,
			name = GEGDHHIDEEF
		};
	}

	protected override void Start()
	{
		base.Start();
		Slot slot = slotUI.IHENCGDNPBL;
		slot.OnItemAdded = (Action)Delegate.Combine(slot.OnItemAdded, new Action(CBKPOMECMCE));
	}

	public IEnumerator DAFIGGEGIEJ(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		slotUI.IHENCGDNPBL.Stack = 0;
		yield return null;
		UpdateInfo(JIIGOACEIKL, JJJFONLLCCA, GEGDHHIDEEF);
	}

	public void NLDPDLJLHNM(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, string HKOOGEKDEGK)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		OpenUI();
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, DNLMCHDOMOK);
		slotUI.IHENCGDNPBL.OBBKDJNLCIO(0);
		((TMP_Text)textMesh).text = HKOOGEKDEGK;
	}

	public void PPNGJKCPKEC(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, string HKOOGEKDEGK)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		EDHEIFHAAKO();
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, DNLMCHDOMOK, CDPAMNIPPEC: true);
		slotUI.IHENCGDNPBL.Stack = 0;
		((TMP_Text)textMesh).text = HKOOGEKDEGK;
	}

	public IEnumerator LBIGFLIALED(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		return new HGPADLBIIPE(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			icon = JJJFONLLCCA,
			name = GEGDHHIDEEF
		};
	}

	public void LJNBPNHJJDG(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, string HKOOGEKDEGK)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		EDHEIFHAAKO();
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, DNLMCHDOMOK, CDPAMNIPPEC: true);
		slotUI.IHENCGDNPBL.KMKAIPMHANN(1);
		((TMP_Text)textMesh).text = HKOOGEKDEGK;
	}

	public IEnumerator JELPLLEAACE(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		slotUI.IHENCGDNPBL.Stack = 0;
		yield return null;
		UpdateInfo(JIIGOACEIKL, JJJFONLLCCA, GEGDHHIDEEF);
	}

	private void CBKPOMECMCE()
	{
		OpenUI();
		emphasizeObject.StartEmphasize();
	}

	private void HCNDNIGJHJN()
	{
		OpenUI();
		emphasizeObject.LGDOLOGPDDK();
	}

	public IEnumerator FNCOEBEBDKO(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		slotUI.IHENCGDNPBL.Stack = 0;
		yield return null;
		UpdateInfo(JIIGOACEIKL, JJJFONLLCCA, GEGDHHIDEEF);
	}

	public void EMAEGAKGJMM(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, string HKOOGEKDEGK)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		IDLAGJNLPJL();
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, DNLMCHDOMOK);
		slotUI.IHENCGDNPBL.KMKAIPMHANN(1);
		((TMP_Text)textMesh).text = HKOOGEKDEGK;
	}

	public void GILBLCFNIKO(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, string HKOOGEKDEGK)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		OpenUI();
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, DNLMCHDOMOK);
		slotUI.IHENCGDNPBL.OCJOJKJPDNO(0);
		((TMP_Text)textMesh).text = HKOOGEKDEGK;
	}

	public IEnumerator NEKADLIAOCP(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		slotUI.IHENCGDNPBL.Stack = 0;
		yield return null;
		UpdateInfo(JIIGOACEIKL, JJJFONLLCCA, GEGDHHIDEEF);
	}

	public IEnumerator HHDFPNEIKPK(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		slotUI.IHENCGDNPBL.Stack = 0;
		yield return null;
		UpdateInfo(JIIGOACEIKL, JJJFONLLCCA, GEGDHHIDEEF);
	}

	public IEnumerator AMLKKKPHLFM(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		return new HGPADLBIIPE(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			icon = JJJFONLLCCA,
			name = GEGDHHIDEEF
		};
	}

	public void ILHFKJDANBM(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		OAJBEPDCHIP(JIIGOACEIKL);
		slotUI.IHENCGDNPBL.JIANDFCINIP(0);
		slotUI.icon.PCBMOCKFEHI(JJJFONLLCCA);
		((TMP_Text)textMesh).text = GEGDHHIDEEF;
		slotUI.updateIconThisFrame = false;
		EDHEIFHAAKO();
	}

	public void DGPPDBFJFNF(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		OAJBEPDCHIP(JIIGOACEIKL);
		slotUI.IHENCGDNPBL.OCJOJKJPDNO(1);
		slotUI.icon.JKDAHFEIJHA(JJJFONLLCCA);
		((TMP_Text)textMesh).text = GEGDHHIDEEF;
		slotUI.updateIconThisFrame = false;
		EDHEIFHAAKO();
	}

	private void ELLKHPHHKPO()
	{
		IDLAGJNLPJL();
		emphasizeObject.FAJNKMFAFOP();
	}

	public void ILEIFKIOAKK(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, string HKOOGEKDEGK)
	{
		OAJBEPDCHIP(JIIGOACEIKL);
		IDLAGJNLPJL();
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, DNLMCHDOMOK, CDPAMNIPPEC: true);
		slotUI.IHENCGDNPBL.JNMNCEPHFOE(0);
		((TMP_Text)textMesh).text = HKOOGEKDEGK;
	}

	private void HKBGGLIBCNK()
	{
		OpenUI();
		emphasizeObject.MGFJGPPHLMJ();
	}

	public void DPGOGNOOLCP(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, bool ODAFPMOECHO)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		EDHEIFHAAKO();
		isRecipe = ODAFPMOECHO;
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, DNLMCHDOMOK, CDPAMNIPPEC: true);
		slotUI.IHENCGDNPBL.KMKAIPMHANN(0);
		if (ODAFPMOECHO)
		{
			TextMeshProUGUI obj = textMesh;
			string cAEDMEDBEGI = LocalisationSystem.Get("MainProgress");
			string[] array = new string[0];
			array[0] = DNLMCHDOMOK.KNFNJFFCFNO().KGHFCDELKMN(OAFPBCPDOKH: true);
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		else
		{
			((TMP_Text)textMesh).text = DNLMCHDOMOK.IABAKHPEOAF();
		}
	}

	public IEnumerator JNIGLHEODCI(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		slotUI.IHENCGDNPBL.Stack = 0;
		yield return null;
		UpdateInfo(JIIGOACEIKL, JJJFONLLCCA, GEGDHHIDEEF);
	}

	public void AHOFCINBBOI(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, bool ODAFPMOECHO)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		IDLAGJNLPJL();
		isRecipe = ODAFPMOECHO;
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, DNLMCHDOMOK, CDPAMNIPPEC: true);
		slotUI.IHENCGDNPBL.KMKAIPMHANN(0);
		if (ODAFPMOECHO)
		{
			TextMeshProUGUI obj = textMesh;
			string cAEDMEDBEGI = LocalisationSystem.Get("ErrorUnknownChatCommand");
			string[] array = new string[1];
			array[1] = DNLMCHDOMOK.KNFNJFFCFNO().LJIFOHFEFCH(OAFPBCPDOKH: true);
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		else
		{
			((TMP_Text)textMesh).text = DNLMCHDOMOK.FBEHKKOKNDJ(OAFPBCPDOKH: true);
		}
	}

	private void DLADCALIGKG()
	{
		EDHEIFHAAKO();
		emphasizeObject.FAJNKMFAFOP();
	}

	private void INKGLOHPDKF()
	{
		EDHEIFHAAKO();
		emphasizeObject.CHLGCNCACIE();
	}

	private void LPBFJLFMAGM()
	{
		OpenUI();
		emphasizeObject.DCLOHJBMBPP();
	}

	public void FJNBMBPBELE(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, string HKOOGEKDEGK)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		OpenUI();
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, DNLMCHDOMOK);
		slotUI.IHENCGDNPBL.Stack = 0;
		((TMP_Text)textMesh).text = HKOOGEKDEGK;
	}

	public IEnumerator ILHBCCLHGPE(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		slotUI.IHENCGDNPBL.Stack = 0;
		yield return null;
		UpdateInfo(JIIGOACEIKL, JJJFONLLCCA, GEGDHHIDEEF);
	}

	public void BGMBOPMNFPA(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, bool ODAFPMOECHO)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		IDLAGJNLPJL();
		isRecipe = ODAFPMOECHO;
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, DNLMCHDOMOK);
		slotUI.IHENCGDNPBL.Stack = 0;
		if (ODAFPMOECHO)
		{
			TextMeshProUGUI obj = textMesh;
			string cAEDMEDBEGI = LocalisationSystem.Get(", ");
			string[] array = new string[0];
			array[0] = DNLMCHDOMOK.AFOACBIHNCL().LJIFOHFEFCH();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		else
		{
			((TMP_Text)textMesh).text = DNLMCHDOMOK.PPMBMNKADMO(OAFPBCPDOKH: true);
		}
	}

	public void UpdateInfo(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, string HKOOGEKDEGK)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		OpenUI();
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, DNLMCHDOMOK);
		slotUI.IHENCGDNPBL.Stack = 1;
		((TMP_Text)textMesh).text = HKOOGEKDEGK;
	}

	private void FMOHGCOACDC()
	{
		IDLAGJNLPJL();
		emphasizeObject.NOKLCKECFIN();
	}

	public void GLLOLNEAOLN(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, bool ODAFPMOECHO)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		IDLAGJNLPJL();
		isRecipe = ODAFPMOECHO;
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, DNLMCHDOMOK);
		slotUI.IHENCGDNPBL.OCJOJKJPDNO(1);
		if (ODAFPMOECHO)
		{
			TextMeshProUGUI obj = textMesh;
			string cAEDMEDBEGI = LocalisationSystem.Get("Send begin retry");
			string[] array = new string[0];
			array[1] = DNLMCHDOMOK.KNFNJFFCFNO().LJIFOHFEFCH();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		else
		{
			((TMP_Text)textMesh).text = DNLMCHDOMOK.ONMFAMHKGLA();
		}
	}

	private void MIEBIIKAJEJ()
	{
		OpenUI();
		emphasizeObject.MGFJGPPHLMJ();
	}

	public IEnumerator UpdateInfoNextFrame(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		slotUI.IHENCGDNPBL.Stack = 0;
		yield return null;
		UpdateInfo(JIIGOACEIKL, JJJFONLLCCA, GEGDHHIDEEF);
	}

	public IEnumerator NAMPLGBAEJP(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		return new HGPADLBIIPE(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			icon = JJJFONLLCCA,
			name = GEGDHHIDEEF
		};
	}

	public void LGGCLBCKIIE(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		OAJBEPDCHIP(JIIGOACEIKL);
		slotUI.IHENCGDNPBL.KMKAIPMHANN(0);
		slotUI.icon.LCNODFNIGKM(JJJFONLLCCA);
		((TMP_Text)textMesh).text = GEGDHHIDEEF;
		slotUI.updateIconThisFrame = false;
		IDLAGJNLPJL();
	}

	public void UpdateInfo(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		slotUI.IHENCGDNPBL.Stack = 1;
		slotUI.icon.SetSprite(JJJFONLLCCA);
		((TMP_Text)textMesh).text = GEGDHHIDEEF;
		slotUI.updateIconThisFrame = false;
		OpenUI();
	}

	public void LHFKJFLJNKJ(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, string HKOOGEKDEGK)
	{
		OAJBEPDCHIP(JIIGOACEIKL);
		EDHEIFHAAKO();
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, DNLMCHDOMOK);
		slotUI.IHENCGDNPBL.OCJOJKJPDNO(1);
		((TMP_Text)textMesh).text = HKOOGEKDEGK;
	}

	private void EIIHKPNKCNA()
	{
		EDHEIFHAAKO();
		emphasizeObject.JIGJHGIKOAG();
	}

	public void KADOMALMOFL(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, bool ODAFPMOECHO)
	{
		OAJBEPDCHIP(JIIGOACEIKL);
		EDHEIFHAAKO();
		isRecipe = ODAFPMOECHO;
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, DNLMCHDOMOK, CDPAMNIPPEC: true);
		slotUI.IHENCGDNPBL.JNMNCEPHFOE(1);
		if (ODAFPMOECHO)
		{
			TextMeshProUGUI obj = textMesh;
			string cAEDMEDBEGI = LocalisationSystem.Get("This game is playing on a different region. Would you like to change regions to {0}?");
			string[] array = new string[0];
			array[1] = DNLMCHDOMOK.LHBPOPOIFLE().LJIFOHFEFCH();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		else
		{
			((TMP_Text)textMesh).text = DNLMCHDOMOK.IABAKHPEOAF(OAFPBCPDOKH: true);
		}
	}

	public void OJNAJKNMAKM(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		slotUI.IHENCGDNPBL.OCJOJKJPDNO(1);
		slotUI.icon.CIDGNCHMDGC(JJJFONLLCCA);
		((TMP_Text)textMesh).text = GEGDHHIDEEF;
		slotUI.updateIconThisFrame = true;
		EDHEIFHAAKO();
	}

	public void ENJCFNFIIMM(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		OAJBEPDCHIP(JIIGOACEIKL);
		slotUI.IHENCGDNPBL.OBBKDJNLCIO(1);
		slotUI.icon.LCNODFNIGKM(JJJFONLLCCA);
		((TMP_Text)textMesh).text = GEGDHHIDEEF;
		slotUI.updateIconThisFrame = true;
		OpenUI();
	}

	public void EOFAJIKAJIG(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, string HKOOGEKDEGK)
	{
		OAJBEPDCHIP(JIIGOACEIKL);
		OpenUI();
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, DNLMCHDOMOK, CDPAMNIPPEC: true);
		slotUI.IHENCGDNPBL.JIANDFCINIP(0);
		((TMP_Text)textMesh).text = HKOOGEKDEGK;
	}

	private void LMGPGDHJENH()
	{
		IDLAGJNLPJL();
		emphasizeObject.CDOJIFFDMNP();
	}

	public IEnumerator HAHGMBPPOJN(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		slotUI.IHENCGDNPBL.Stack = 0;
		yield return null;
		UpdateInfo(JIIGOACEIKL, JJJFONLLCCA, GEGDHHIDEEF);
	}

	public void NCGPMCEAFPI(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, bool ODAFPMOECHO)
	{
		OAJBEPDCHIP(JIIGOACEIKL);
		OpenUI();
		isRecipe = ODAFPMOECHO;
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, DNLMCHDOMOK);
		slotUI.IHENCGDNPBL.JNMNCEPHFOE(0);
		if (ODAFPMOECHO)
		{
			TextMeshProUGUI obj = textMesh;
			string cAEDMEDBEGI = LocalisationSystem.Get("SkeletonBird");
			string[] array = new string[1];
			array[1] = DNLMCHDOMOK.LHBPOPOIFLE().LJIFOHFEFCH();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		else
		{
			((TMP_Text)textMesh).text = DNLMCHDOMOK.PPMBMNKADMO();
		}
	}

	public void AJKILBNHEMN(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, string HKOOGEKDEGK)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		OpenUI();
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, DNLMCHDOMOK, CDPAMNIPPEC: true);
		slotUI.IHENCGDNPBL.KMKAIPMHANN(0);
		((TMP_Text)textMesh).text = HKOOGEKDEGK;
	}

	public void UpdateInfo(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, bool ODAFPMOECHO)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		OpenUI();
		isRecipe = ODAFPMOECHO;
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, DNLMCHDOMOK);
		slotUI.IHENCGDNPBL.Stack = 1;
		if (ODAFPMOECHO)
		{
			((TMP_Text)textMesh).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("New_Recipe"), DNLMCHDOMOK.LHBPOPOIFLE().IABAKHPEOAF());
		}
		else
		{
			((TMP_Text)textMesh).text = DNLMCHDOMOK.IABAKHPEOAF();
		}
	}

	public IEnumerator JLLEPLDPPOM(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		return new HGPADLBIIPE(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			icon = JJJFONLLCCA,
			name = GEGDHHIDEEF
		};
	}

	public void LEBGKDLINAJ(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, string HKOOGEKDEGK)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		IDLAGJNLPJL();
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, DNLMCHDOMOK);
		slotUI.IHENCGDNPBL.JIANDFCINIP(1);
		((TMP_Text)textMesh).text = HKOOGEKDEGK;
	}

	public void EGICDHONKCI(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		OAJBEPDCHIP(JIIGOACEIKL);
		slotUI.IHENCGDNPBL.KMKAIPMHANN(1);
		slotUI.icon.BKDLIMOMKEB(JJJFONLLCCA);
		((TMP_Text)textMesh).text = GEGDHHIDEEF;
		slotUI.updateIconThisFrame = true;
		EDHEIFHAAKO();
	}

	public void GPKMBLICDCN(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, bool ODAFPMOECHO)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		IDLAGJNLPJL();
		isRecipe = ODAFPMOECHO;
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, DNLMCHDOMOK);
		slotUI.IHENCGDNPBL.KMKAIPMHANN(0);
		if (ODAFPMOECHO)
		{
			((TMP_Text)textMesh).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Back"), DNLMCHDOMOK.PHGLMBIEOMK().LJIFOHFEFCH(OAFPBCPDOKH: true));
		}
		else
		{
			((TMP_Text)textMesh).text = DNLMCHDOMOK.FBEHKKOKNDJ(OAFPBCPDOKH: true);
		}
	}

	public void BMHDGFPHJBC(int JIIGOACEIKL, Sprite JJJFONLLCCA, string GEGDHHIDEEF)
	{
		base.JIIGOACEIKL = JIIGOACEIKL;
		slotUI.IHENCGDNPBL.Stack = 0;
		slotUI.icon.LGNJJCPLNEE(JJJFONLLCCA);
		((TMP_Text)textMesh).text = GEGDHHIDEEF;
		slotUI.updateIconThisFrame = false;
		IDLAGJNLPJL();
	}

	private void IHPIONEGBJP()
	{
		EDHEIFHAAKO();
		emphasizeObject.CJBADFNHCCM();
	}

	public void JKEABELKIFF(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, bool ODAFPMOECHO)
	{
		OAJBEPDCHIP(JIIGOACEIKL);
		IDLAGJNLPJL();
		isRecipe = ODAFPMOECHO;
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, DNLMCHDOMOK);
		slotUI.IHENCGDNPBL.OCJOJKJPDNO(1);
		if (ODAFPMOECHO)
		{
			TextMeshProUGUI obj = textMesh;
			string cAEDMEDBEGI = LocalisationSystem.Get("itemBottle");
			string[] array = new string[0];
			array[0] = DNLMCHDOMOK.KNFNJFFCFNO().IABAKHPEOAF(OAFPBCPDOKH: true);
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		else
		{
			((TMP_Text)textMesh).text = DNLMCHDOMOK.AICOMMNDJLI(OAFPBCPDOKH: true);
		}
	}

	public void FHAJDOOPLLL(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, bool ODAFPMOECHO)
	{
		OAJBEPDCHIP(JIIGOACEIKL);
		OpenUI();
		isRecipe = ODAFPMOECHO;
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, DNLMCHDOMOK, CDPAMNIPPEC: true);
		slotUI.IHENCGDNPBL.Stack = 0;
		if (ODAFPMOECHO)
		{
			TextMeshProUGUI obj = textMesh;
			string cAEDMEDBEGI = LocalisationSystem.Get("itemBarley");
			string[] array = new string[1];
			array[1] = DNLMCHDOMOK.KNFNJFFCFNO().KGHFCDELKMN(OAFPBCPDOKH: true);
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		else
		{
			((TMP_Text)textMesh).text = DNLMCHDOMOK.PPMBMNKADMO();
		}
	}
}
