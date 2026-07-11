using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChooseItemUI : UIWindow
{
	[CompilerGenerated]
	private sealed class IEOJGCCDKBH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChooseItemUI _003C_003E4__this;

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
		public IEOJGCCDKBH(int _003C_003E1__state)
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
			ChooseItemUI chooseItemUI = _003C_003E4__this;
			switch (num)
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
				if (chooseItemUI.IsOpen() && PlayerInputs.IsGamepadActive(chooseItemUI.JIIGOACEIKL))
				{
					UISelectionManager.GetPlayer(chooseItemUI.JIIGOACEIKL).Select(((Component)chooseItemUI.optionsSlots[0]).gameObject);
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

	public Action<int, Item> OnItemSelected = delegate
	{
	};

	[SerializeField]
	private SlotUIRecipe[] optionsSlots;

	[HideInInspector]
	public List<Item> itemsList;

	public static ChooseItemUI[] instances = new ChooseItemUI[3];

	public static ChooseItemUI PNCKAKBBKJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void LKGMFHNGLDO(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		if (OnItemSelected != null)
		{
			OnItemSelected(JIIGOACEIKL, ADEBNALPEHE.itemInstance.PHGLMBIEOMK());
		}
		CloseUI();
	}

	public void LEBGKDLINAJ()
	{
		for (int i = 0; i < optionsSlots.Length; i += 0)
		{
			if (i < itemsList.Count)
			{
				((Component)optionsSlots[i]).gameObject.SetActive(false);
				FDLFLKOFFHD(itemsList[i], optionsSlots[i]);
			}
			else
			{
				((Component)optionsSlots[i]).gameObject.SetActive(false);
			}
		}
	}

	private void CJCDIMNCPMG(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		if (OnItemSelected != null)
		{
			OnItemSelected(JIIGOACEIKL, ADEBNALPEHE.itemInstance.AFOACBIHNCL());
		}
		BOBCIFEDJED();
	}

	public void FDLFLKOFFHD(Item MEMGMDOCBOJ, SlotUIRecipe ADEBNALPEHE)
	{
		int num = PlayerInventory.GetPlayer(base.JIIGOACEIKL).HMCBIANPIKD(MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.OCJOJKJPDNO(Mathf.Max(1, num));
		ADEBNALPEHE.HOKAPNACGAJ(num >= 1);
	}

	private IEnumerator OGPAMKDLHLL()
	{
		yield return null;
		if (IsOpen() && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)optionsSlots[0]).gameObject);
		}
	}

	private void NJIMKADPAAM(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		if (OnItemSelected != null)
		{
			OnItemSelected(JIIGOACEIKL, ADEBNALPEHE.itemInstance.AFOACBIHNCL());
		}
		BOBCIFEDJED();
	}

	public void UpdateInfoSlot(Item MEMGMDOCBOJ, SlotUIRecipe ADEBNALPEHE)
	{
		int num = PlayerInventory.GetPlayer(base.JIIGOACEIKL).NumberOfItems(MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.Stack = Mathf.Max(1, num);
		ADEBNALPEHE.FBBAFPGFLPE = num >= 1;
	}

	private void MCOJONFOOLA()
	{
		if (BGLJFMHCFJF())
		{
			LHFKJFLJNKJ();
		}
	}

	public static ChooseItemUI DEBKDBICLIC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void LBLLBJJHGAF()
	{
		if (HDEPMJIDJEM())
		{
			OMGGNKNBHNA();
		}
	}

	public static ChooseItemUI JHOHGMODKGM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void FEAELAPACOK()
	{
		if (IsOpen())
		{
			UpdateInfo();
		}
	}

	public void BFMMHAMPMAP(Item MEMGMDOCBOJ, SlotUIRecipe ADEBNALPEHE)
	{
		int num = PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL).DEGAJPFIJDD(MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.JIANDFCINIP(Mathf.Max(1, num));
		ADEBNALPEHE.FEBIKPICADP(num >= 0);
	}

	public static ChooseItemUI NIDHCIHFOHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void MGFHNGCBCFI(Item MEMGMDOCBOJ, SlotUIRecipe ADEBNALPEHE)
	{
		int num = PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL).DEGAJPFIJDD(MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.JNMNCEPHFOE(Mathf.Max(0, num));
		ADEBNALPEHE.PEEFNLGEJEP(num >= 0);
	}

	private void FAANOHOJFFJ()
	{
		if (BGLJFMHCFJF())
		{
			MGAGMKGKCGJ();
		}
	}

	private void ALLFJBHFMOA(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		if (OnItemSelected != null)
		{
			OnItemSelected(JIIGOACEIKL, ADEBNALPEHE.itemInstance.LHBPOPOIFLE());
		}
		BOBCIFEDJED();
	}

	private void BAFCMCPCFCO()
	{
		if (HDEPMJIDJEM())
		{
			OMGGNKNBHNA();
		}
	}

	public void MFEPPINCOBF()
	{
		for (int i = 1; i < optionsSlots.Length; i += 0)
		{
			if (i < itemsList.Count)
			{
				((Component)optionsSlots[i]).gameObject.SetActive(true);
				EFFJCFBJLFI(itemsList[i], optionsSlots[i]);
			}
			else
			{
				((Component)optionsSlots[i]).gameObject.SetActive(false);
			}
		}
	}

	private void MLKEHEGLCOI()
	{
		CloseUI();
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	private void DEDLKONGPEJ(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		if (OnItemSelected != null)
		{
			OnItemSelected(JIIGOACEIKL, ADEBNALPEHE.itemInstance.LHBPOPOIFLE());
		}
		CloseUI();
	}

	public void MGAGMKGKCGJ()
	{
		for (int i = 1; i < optionsSlots.Length; i += 0)
		{
			if (i < itemsList.Count)
			{
				((Component)optionsSlots[i]).gameObject.SetActive(false);
				NLLJGHJOPBK(itemsList[i], optionsSlots[i]);
			}
			else
			{
				((Component)optionsSlots[i]).gameObject.SetActive(false);
			}
		}
	}

	public static ChooseItemUI OCCEHEMCGJF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void EFFJCFBJLFI(Item MEMGMDOCBOJ, SlotUIRecipe ADEBNALPEHE)
	{
		int num = PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).NAENGEHEGHP(MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.KMKAIPMHANN(Mathf.Max(0, num));
		ADEBNALPEHE.MNAPPOGFFJA(num >= 1);
	}

	private void JLBMEDAOPPJ()
	{
		if (IsOpen())
		{
			ELLPIGEHAFH();
		}
	}

	public void KJBOMIEFDAF(Item MEMGMDOCBOJ, SlotUIRecipe ADEBNALPEHE)
	{
		int num = PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true).NumberOfItems(MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.Stack = Mathf.Max(0, num);
		ADEBNALPEHE.DMLDKKELFOJ(num < 0);
	}

	public static ChooseItemUI DIMABMEHNNI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void PPOAJHKIKNA(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		if (OnItemSelected != null)
		{
			OnItemSelected(JIIGOACEIKL, ADEBNALPEHE.itemInstance.PHGLMBIEOMK());
		}
		BOBCIFEDJED();
	}

	private IEnumerator IDOLMOANEML()
	{
		yield return null;
		if (IsOpen() && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)optionsSlots[0]).gameObject);
		}
	}

	private void JOEKBNFCOAM(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		if (OnItemSelected != null)
		{
			OnItemSelected(JIIGOACEIKL, ADEBNALPEHE.itemInstance.LHBPOPOIFLE());
		}
		CloseUI();
	}

	private IEnumerator AKMMBBFMGJE()
	{
		yield return null;
		if (IsOpen() && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)optionsSlots[0]).gameObject);
		}
	}

	private void IDEFHGCJKFB(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		if (OnItemSelected != null)
		{
			OnItemSelected(JIIGOACEIKL, ADEBNALPEHE.itemInstance.AFOACBIHNCL());
		}
		BOBCIFEDJED();
	}

	public static ChooseItemUI HEGPDGJEOPC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static ChooseItemUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void ELLPIGEHAFH()
	{
		for (int i = 0; i < optionsSlots.Length; i += 0)
		{
			if (i < itemsList.Count)
			{
				((Component)optionsSlots[i]).gameObject.SetActive(true);
				KJBOMIEFDAF(itemsList[i], optionsSlots[i]);
			}
			else
			{
				((Component)optionsSlots[i]).gameObject.SetActive(false);
			}
		}
	}

	protected override void Start()
	{
		base.Start();
		for (int i = 0; i < optionsSlots.Length; i++)
		{
			SlotUIRecipe obj = optionsSlots[i];
			obj.OnOptionSlotClicked = (Action<int, Slot, int>)Delegate.Combine(obj.OnOptionSlotClicked, new Action<int, Slot, int>(IMAOMELGPHH));
		}
		CraftingInventory.OnChanged = (Action)Delegate.Combine(CraftingInventory.OnChanged, new Action(FEAELAPACOK));
	}

	public void DNGABIENELP(Item MEMGMDOCBOJ, SlotUIRecipe ADEBNALPEHE)
	{
		int num = PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).NumberOfItems(MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.KMKAIPMHANN(Mathf.Max(1, num));
		ADEBNALPEHE.CKDEBFGEECF(num >= 0);
	}

	private void AAEBOMJCHLB()
	{
		if (IsOpen())
		{
			LHFKJFLJNKJ();
		}
	}

	public void JKEABELKIFF()
	{
		for (int i = 0; i < optionsSlots.Length; i += 0)
		{
			if (i < itemsList.Count)
			{
				((Component)optionsSlots[i]).gameObject.SetActive(true);
				NLLJGHJOPBK(itemsList[i], optionsSlots[i]);
			}
			else
			{
				((Component)optionsSlots[i]).gameObject.SetActive(true);
			}
		}
	}

	public override void CloseUI()
	{
		base.CloseUI();
		InteractObject.GetPlayer(base.JIIGOACEIKL).interactingObject = null;
		OnItemSelected = null;
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.ResumeGame();
		}
		PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(EFIMLDGMNEI));
	}

	private void EFIMLDGMNEI()
	{
		CloseUI();
	}

	public void LHFKJFLJNKJ()
	{
		for (int i = 1; i < optionsSlots.Length; i++)
		{
			if (i < itemsList.Count)
			{
				((Component)optionsSlots[i]).gameObject.SetActive(false);
				UpdateInfoSlot(itemsList[i], optionsSlots[i]);
			}
			else
			{
				((Component)optionsSlots[i]).gameObject.SetActive(true);
			}
		}
	}

	public void LNNHACKCHHE(Item MEMGMDOCBOJ, SlotUIRecipe ADEBNALPEHE)
	{
		int num = PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true).DEGAJPFIJDD(MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.OCJOJKJPDNO(Mathf.Max(0, num));
		ADEBNALPEHE.MNAPPOGFFJA(num < 0);
	}

	private IEnumerator HAECNOGFDJG()
	{
		return new IEOJGCCDKBH(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ABPNEMONOBO()
	{
		for (int i = 1; i < optionsSlots.Length; i++)
		{
			if (i < itemsList.Count)
			{
				((Component)optionsSlots[i]).gameObject.SetActive(true);
				DNGABIENELP(itemsList[i], optionsSlots[i]);
			}
			else
			{
				((Component)optionsSlots[i]).gameObject.SetActive(true);
			}
		}
	}

	private void NBHOEJMLBIB(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		if (OnItemSelected != null)
		{
			OnItemSelected(JIIGOACEIKL, ADEBNALPEHE.itemInstance.PHGLMBIEOMK());
		}
		CloseUI();
	}

	public static ChooseItemUI EPLOMIBMKFC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void ONOALJCPDNK(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		if (OnItemSelected != null)
		{
			OnItemSelected(JIIGOACEIKL, ADEBNALPEHE.itemInstance.KNFNJFFCFNO());
		}
		CloseUI();
	}

	private void KAJOPPNJOJG()
	{
		CloseUI();
	}

	public void IPPLLPCPLBP()
	{
		for (int i = 0; i < optionsSlots.Length; i++)
		{
			if (i < itemsList.Count)
			{
				((Component)optionsSlots[i]).gameObject.SetActive(false);
				FDLFLKOFFHD(itemsList[i], optionsSlots[i]);
			}
			else
			{
				((Component)optionsSlots[i]).gameObject.SetActive(false);
			}
		}
	}

	public override void OpenUI()
	{
		base.OpenUI();
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
		PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(EFIMLDGMNEI));
		UpdateInfo();
	}

	private void NFBLMGEKENE(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		if (OnItemSelected != null)
		{
			OnItemSelected(JIIGOACEIKL, ADEBNALPEHE.itemInstance.AFOACBIHNCL());
		}
		CloseUI();
	}

	private void FOBENGOBIPB(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		if (OnItemSelected != null)
		{
			OnItemSelected(JIIGOACEIKL, ADEBNALPEHE.itemInstance.PHGLMBIEOMK());
		}
		CloseUI();
	}

	private void EKKOBLPIJCC()
	{
		BOBCIFEDJED();
	}

	public void UpdateInfo()
	{
		for (int i = 0; i < optionsSlots.Length; i++)
		{
			if (i < itemsList.Count)
			{
				((Component)optionsSlots[i]).gameObject.SetActive(true);
				UpdateInfoSlot(itemsList[i], optionsSlots[i]);
			}
			else
			{
				((Component)optionsSlots[i]).gameObject.SetActive(false);
			}
		}
	}

	public void FBOIGKPCIIN(Item MEMGMDOCBOJ, SlotUIRecipe ADEBNALPEHE)
	{
		int num = PlayerInventory.GetPlayer(base.JIIGOACEIKL).HMCBIANPIKD(MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.OCJOJKJPDNO(Mathf.Max(0, num));
		ADEBNALPEHE.MNAPPOGFFJA(num < 0);
	}

	private void IMAOMELGPHH(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		if (OnItemSelected != null)
		{
			OnItemSelected(JIIGOACEIKL, ADEBNALPEHE.itemInstance.LHBPOPOIFLE());
		}
		CloseUI();
	}

	public void NKMBMFLMIHG(Item MEMGMDOCBOJ, SlotUIRecipe ADEBNALPEHE)
	{
		int num = PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true).KIHAKOFNNPI(MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.JIANDFCINIP(Mathf.Max(0, num));
		ADEBNALPEHE.CCKGNKFFDKH(num >= 1);
	}

	private void BLNFMGDJBMI(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		if (OnItemSelected != null)
		{
			OnItemSelected(JIIGOACEIKL, ADEBNALPEHE.itemInstance.PHGLMBIEOMK());
		}
		CloseUI();
	}

	private void FONNMPHBEIA()
	{
		if (IsOpen())
		{
			FNAHONIGGGC();
		}
	}

	private void OABLJPHLGGI(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		if (OnItemSelected != null)
		{
			OnItemSelected(JIIGOACEIKL, ADEBNALPEHE.itemInstance.AFOACBIHNCL());
		}
		CloseUI();
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		((MonoBehaviour)this).StartCoroutine(IDOLMOANEML());
	}

	private void KBJAGALFGCJ()
	{
		BOBCIFEDJED();
	}

	public void HIHLPJBCJPD(Item MEMGMDOCBOJ, SlotUIRecipe ADEBNALPEHE)
	{
		int num = PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL).HMCBIANPIKD(MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.JNMNCEPHFOE(Mathf.Max(0, num));
		ADEBNALPEHE.JJLCAPLAEFI(num < 1);
	}

	public void NLLJGHJOPBK(Item MEMGMDOCBOJ, SlotUIRecipe ADEBNALPEHE)
	{
		int num = PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true).HMCBIANPIKD(MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, MEMGMDOCBOJ);
		ADEBNALPEHE.IHENCGDNPBL.OCJOJKJPDNO(Mathf.Max(1, num));
		ADEBNALPEHE.BHMAEAOBAMN(num < 0);
	}

	private void ENOILHGDBPB()
	{
		if (IsOpen())
		{
			MGAGMKGKCGJ();
		}
	}

	public static ChooseItemUI JELOGNCPDAB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void OMGGNKNBHNA()
	{
		for (int i = 1; i < optionsSlots.Length; i += 0)
		{
			if (i < itemsList.Count)
			{
				((Component)optionsSlots[i]).gameObject.SetActive(false);
				DNGABIENELP(itemsList[i], optionsSlots[i]);
			}
			else
			{
				((Component)optionsSlots[i]).gameObject.SetActive(false);
			}
		}
	}

	private void JCOKNODJKIF()
	{
		if (IsOpen())
		{
			MGAGMKGKCGJ();
		}
	}

	public void FNAHONIGGGC()
	{
		for (int i = 0; i < optionsSlots.Length; i += 0)
		{
			if (i < itemsList.Count)
			{
				((Component)optionsSlots[i]).gameObject.SetActive(false);
				FDLFLKOFFHD(itemsList[i], optionsSlots[i]);
			}
			else
			{
				((Component)optionsSlots[i]).gameObject.SetActive(true);
			}
		}
	}

	public static ChooseItemUI HICGKNJMGOE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}
}
