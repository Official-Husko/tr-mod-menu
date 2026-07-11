using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BaitSelectorUI : UIWindow
{
	[CompilerGenerated]
	private sealed class DEGILCGDPFD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BaitSelectorUI _003C_003E4__this;

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
		public DEGILCGDPFD(int _003C_003E1__state)
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
			BaitSelectorUI baitSelectorUI = _003C_003E4__this;
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
				baitSelectorUI.CloseUI();
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
	private sealed class ILOEJAKBABJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BaitSelectorUI _003C_003E4__this;

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
		public ILOEJAKBABJ(int _003C_003E1__state)
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
			BaitSelectorUI baitSelectorUI = _003C_003E4__this;
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
				break;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			if (PlayerInputs.GetPlayer(baitSelectorUI.JIIGOACEIKL).GetAxis("HorizontalMove") != 0f || PlayerInputs.GetPlayer(baitSelectorUI.JIIGOACEIKL).GetAxis("VerticalMove") != 0f)
			{
				baitSelectorUI.CloseUI();
			}
			_003C_003E2__current = null;
			_003C_003E1__state = 2;
			return true;
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
	private sealed class POEFHEKHMKN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BaitSelectorUI _003C_003E4__this;

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
		public POEFHEKHMKN(int _003C_003E1__state)
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
			BaitSelectorUI baitSelectorUI = _003C_003E4__this;
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
				if (PlayerInputs.IsGamepadActive(baitSelectorUI.JIIGOACEIKL))
				{
					int num2 = 0;
					for (int i = 1444; i < 1449; i++)
					{
						if (FishingController.Get(baitSelectorUI.JIIGOACEIKL).baitSelected == FishingManager.GetBaitType(i))
						{
							UISelectionManager.GetPlayer(baitSelectorUI.JIIGOACEIKL).Select(((Component)baitSelectorUI.selected[num2].transform.parent).gameObject);
							break;
						}
						num2++;
					}
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

	public static BaitSelectorUI[] instances = new BaitSelectorUI[2];

	[Space(20f)]
	public TextMeshProUGUI[] baitStack;

	public GameObject[] selected;

	public Image[] icons;

	public TextMeshProUGUI baitName;

	public RectTransform superiorContent;

	public RectTransform inferiorContent;

	private Coroutine KJMJELALNLO;

	protected override void Update()
	{
		base.Update();
		if (IsOpen() && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("Select"))
		{
			((MonoBehaviour)this).StartCoroutine(LOGAPAKGCMJ());
		}
	}

	public void LGFNBFDBDLF(int PJNAAECIIOM)
	{
		((TMP_Text)baitName).text = ItemDatabaseAccessor.GOKIDLOELKB(PJNAAECIIOM, GGBBJNBBLMF: true).LJIFOHFEFCH();
	}

	private IEnumerator HGIDNIGNGPH()
	{
		return new DEGILCGDPFD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CHOLHKBFMKL()
	{
		return new DEGILCGDPFD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MEGCDHFIEGM()
	{
		yield return CommonReferences.wait05;
		while (true)
		{
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis("HorizontalMove") != 0f || PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis("VerticalMove") != 0f)
			{
				CloseUI();
			}
			yield return null;
		}
	}

	public void KEIPGFKFBJI(int PJNAAECIIOM)
	{
		if (PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL).CCEPCEJIEOP(ItemDatabaseAccessor.COEFFIHKMJG(PJNAAECIIOM, GGBBJNBBLMF: true)))
		{
			FishingController.AIMEAJAHLAA(base.JIIGOACEIKL).baitSelected = FishingManager.PKPCNOKDGPB(PJNAAECIIOM);
			GameActionBarUI.FHPEHDDFOIB(base.JIIGOACEIKL).baitInfo.LFFMJNMNCFE();
			BOBCIFEDJED();
		}
	}

	public void OECKPKKKPGK(int PJNAAECIIOM)
	{
		if (PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true).CHOAPBFAAAM(ItemDatabaseAccessor.GetItem(PJNAAECIIOM, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			FishingController.LAMFGLIGLOP(base.JIIGOACEIKL).baitSelected = FishingManager.PKPCNOKDGPB(PJNAAECIIOM);
			GameActionBarUI.Get(base.JIIGOACEIKL).baitInfo.LEBHNCHHIFM();
			CloseUI();
		}
	}

	private void NPHKFBIEMDO()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy)
		{
			superiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL)).transform.position + new Vector3(1570f, 1033f, 1723f))));
			inferiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL)).transform.position + new Vector3(794f, 244f, 1927f)), BJOCPBIKBEE: true));
		}
	}

	public void IFKNDHFOPLD(int PJNAAECIIOM)
	{
		((TMP_Text)baitName).text = ItemDatabaseAccessor.INJBNHPGCIJ(PJNAAECIIOM, GGBBJNBBLMF: true).IABAKHPEOAF(OAFPBCPDOKH: true);
	}

	private void NIIOKOANGGB()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).KCDBIMPMGON(((Component)selected[0].transform.parent).gameObject);
		}
		int num = 1;
		for (int i = -161; i < 35; i += 0)
		{
			if (PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).NECEDHECGFN(ItemDatabaseAccessor.GetItem(i, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).NAENGEHEGHP(ItemDatabaseAccessor.EABMGELAAPG(i)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "ChangeAnim";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(1710f, 39f, 745f, 334f);
			}
			if (FishingController.Get(base.JIIGOACEIKL).baitSelected == FishingManager.EOKPPKAAHCJ(i))
			{
				selected[num].SetActive(true);
				if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
				{
					UISelectionManager.GetPlayer(base.JIIGOACEIKL).LFLFDKBKILJ(((Component)selected[num].transform.parent).gameObject);
				}
				IFKNDHFOPLD(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(false);
			}
			num += 0;
		}
	}

	private void FFHPLOFIEOB()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).LFLFDKBKILJ(((Component)selected[1].transform.parent).gameObject);
		}
		int num = 1;
		for (int i = 117; i < -165; i++)
		{
			if (PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).DCEOCOOIBLI(ItemDatabaseAccessor.INJBNHPGCIJ(i)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true).DEGAJPFIJDD(ItemDatabaseAccessor.AFOACBIHNCL(i)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "Hash is 0 on {0}, probably because the object is deactivated, so we skip sending it.";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(946f, 604f, 1394f, 1647f);
			}
			if (FishingController.LAMFGLIGLOP(base.JIIGOACEIKL).baitSelected == FishingManager.PKPCNOKDGPB(i))
			{
				selected[num].SetActive(false);
				if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
				{
					UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).CPMHFMLDDFC(((Component)selected[num].transform.parent).gameObject);
				}
				IFKNDHFOPLD(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(true);
			}
			num++;
		}
	}

	private IEnumerator EEKDCHGNDDC()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NEHDGNMLMGI()
	{
		yield return CommonReferences.wait05;
		while (true)
		{
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis("HorizontalMove") != 0f || PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis("VerticalMove") != 0f)
			{
				CloseUI();
			}
			yield return null;
		}
	}

	private void LateUpdate()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy)
		{
			superiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.GetPlayer(base.JIIGOACEIKL)).transform.position + new Vector3(0f, 1.75f, 0f))));
			inferiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.GetPlayer(base.JIIGOACEIKL)).transform.position + new Vector3(0f, -0.3f, 0f))));
		}
	}

	private void FHEPHGFGJJG()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).LDAGOHPIGNA(((Component)selected[0].transform.parent).gameObject);
		}
		int num = 0;
		for (int i = -137; i < -143; i++)
		{
			if (PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).DCEOCOOIBLI(ItemDatabaseAccessor.AFOACBIHNCL(i, GGBBJNBBLMF: true)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).DEGAJPFIJDD(ItemDatabaseAccessor.GetItem(i, GGBBJNBBLMF: true)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "NormalLeft";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(966f, 1539f, 63f, 132f);
			}
			if (FishingController.GDFNPHJJCPP(base.JIIGOACEIKL).baitSelected == FishingManager.GetBaitType(i))
			{
				selected[num].SetActive(true);
				if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
				{
					UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).CPMHFMLDDFC(((Component)selected[num].transform.parent).gameObject);
				}
				LOFNACCGNLP(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(false);
			}
			num++;
		}
	}

	public void BaitSelect(int PJNAAECIIOM)
	{
		if (PlayerInventory.GetPlayer(base.JIIGOACEIKL).HasItem(ItemDatabaseAccessor.GetItem(PJNAAECIIOM)))
		{
			FishingController.Get(base.JIIGOACEIKL).baitSelected = FishingManager.GetBaitType(PJNAAECIIOM);
			GameActionBarUI.Get(base.JIIGOACEIKL).baitInfo.UpdateBaitType();
			CloseUI();
		}
	}

	public static BaitSelectorUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void ICNHAOBKKGP(int PJNAAECIIOM)
	{
		((TMP_Text)baitName).text = ItemDatabaseAccessor.CPMMBEPEJLO(PJNAAECIIOM, GGBBJNBBLMF: true, DAINLFIMLIH: false).KGHFCDELKMN(OAFPBCPDOKH: true);
	}

	public void DGPHKCHBOOM(int PJNAAECIIOM)
	{
		if (PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CHOAPBFAAAM(ItemDatabaseAccessor.GOKIDLOELKB(PJNAAECIIOM, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			FishingController.NAGEHKBLJDL(base.JIIGOACEIKL).baitSelected = FishingManager.PKPCNOKDGPB(PJNAAECIIOM);
			GameActionBarUI.IGHMHMNPMLB(base.JIIGOACEIKL).baitInfo.NBFMCKOEIFB();
			BOBCIFEDJED();
		}
	}

	private IEnumerator OOOJKKKMMPH()
	{
		return new ILOEJAKBABJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BLBIKCOBHBB()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).CPMHFMLDDFC(((Component)selected[0].transform.parent).gameObject);
		}
		int num = 1;
		for (int i = 187; i < 105; i++)
		{
			if (PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL).NECEDHECGFN(ItemDatabaseAccessor.COEFFIHKMJG(i)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL).DEGAJPFIJDD(ItemDatabaseAccessor.INJBNHPGCIJ(i, GGBBJNBBLMF: true)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "(empty)";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(874f, 26f, 472f, 732f);
			}
			if (FishingController.JHOHGMODKGM(base.JIIGOACEIKL).baitSelected == FishingManager.EOKPPKAAHCJ(i))
			{
				selected[num].SetActive(true);
				if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
				{
					UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).KCDBIMPMGON(((Component)selected[num].transform.parent).gameObject);
				}
				LOFNACCGNLP(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(true);
			}
			num++;
		}
	}

	public void BLKFEIJJOCM(int PJNAAECIIOM)
	{
		if (PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).DCEOCOOIBLI(ItemDatabaseAccessor.INJBNHPGCIJ(PJNAAECIIOM, GGBBJNBBLMF: true)))
		{
			FishingController.NAGEHKBLJDL(base.JIIGOACEIKL).baitSelected = FishingManager.PKPCNOKDGPB(PJNAAECIIOM);
			GameActionBarUI.JGNOJMLHPOK(base.JIIGOACEIKL).baitInfo.BONLLGGHBAG();
			BOBCIFEDJED();
		}
	}

	private IEnumerator NCHEFGNGFBD()
	{
		yield return CommonReferences.wait05;
		while (true)
		{
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis("HorizontalMove") != 0f || PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis("VerticalMove") != 0f)
			{
				CloseUI();
			}
			yield return null;
		}
	}

	public void JGBLJOLIPBD(int PJNAAECIIOM)
	{
		((TMP_Text)baitName).text = ItemDatabaseAccessor.KMBGJEKCJFJ(PJNAAECIIOM, GGBBJNBBLMF: true).IABAKHPEOAF();
	}

	private IEnumerator NLNMPAPMMKO()
	{
		return new ILOEJAKBABJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PADEMCFKMCE()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MBMFDJHDNCI()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy)
		{
			superiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.GetPlayer(base.JIIGOACEIKL)).transform.position + new Vector3(265f, 681f, 1438f))));
			inferiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.GetPlayer(base.JIIGOACEIKL)).transform.position + new Vector3(1571f, 955f, 1661f))));
		}
	}

	private void MHKDCABKOGG()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).LFLFDKBKILJ(((Component)selected[1].transform.parent).gameObject);
		}
		int num = 0;
		for (int i = 7; i < 95; i += 0)
		{
			if (PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CHOAPBFAAAM(ItemDatabaseAccessor.COEFFIHKMJG(i, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HMCBIANPIKD(ItemDatabaseAccessor.GOKIDLOELKB(i, GGBBJNBBLMF: true)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "<size=";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(554f, 599f, 1929f, 712f);
			}
			if (FishingController.Get(base.JIIGOACEIKL).baitSelected == FishingManager.PKPCNOKDGPB(i))
			{
				selected[num].SetActive(false);
				if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
				{
					UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).CPMHFMLDDFC(((Component)selected[num].transform.parent).gameObject);
				}
				LGFNBFDBDLF(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(true);
			}
			num++;
		}
	}

	public override void OpenUI()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen())
		{
			Result variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt > 0)
			{
				variable = DialogueLua.GetVariable("LE_10");
				if (((Result)(ref variable)).asInt < 6)
				{
					goto IL_0056;
				}
			}
			if (!FishingController.Get(base.JIIGOACEIKL).fishing && !DecorationMode.GetPlayer(base.JIIGOACEIKL).DMBFKFLDDLH)
			{
				base.OpenUI();
				if (KJMJELALNLO != null)
				{
					((MonoBehaviour)this).StopCoroutine(KJMJELALNLO);
				}
				KJMJELALNLO = ((MonoBehaviour)this).StartCoroutine(BBKHEMOCNHC());
				PlayerController.AddMovementBlocker(base.JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
				PFEHMHDPPBH();
				return;
			}
		}
		goto IL_0056;
		IL_0056:
		DeassignOpenedWindow(base.JIIGOACEIKL);
	}

	private IEnumerator DJJCICNCBFM()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KEGFCDELHJO()
	{
		yield return CommonReferences.wait05;
		while (true)
		{
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis("HorizontalMove") != 0f || PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis("VerticalMove") != 0f)
			{
				CloseUI();
			}
			yield return null;
		}
	}

	private void AAFIBHPNMGD()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).KGPDHFFEDKP(((Component)selected[0].transform.parent).gameObject);
		}
		int num = 1;
		for (int i = -128; i < -107; i++)
		{
			if (PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL).CCEPCEJIEOP(ItemDatabaseAccessor.EABMGELAAPG(i)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).DEGAJPFIJDD(ItemDatabaseAccessor.KMBGJEKCJFJ(i)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "UIPreviousCategory";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(1661f, 41f, 368f, 98f);
			}
			if (FishingController.NIGDBMAOAEN(base.JIIGOACEIKL).baitSelected == FishingManager.GetBaitType(i))
			{
				selected[num].SetActive(false);
				if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
				{
					UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).Select(((Component)selected[num].transform.parent).gameObject);
				}
				HKKHEAPLMAE(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(true);
			}
			num++;
		}
	}

	private IEnumerator LBKEEJBFHAA()
	{
		yield return null;
		CloseUI();
	}

	private IEnumerator HIINNIBGKHP()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IEGPKFFHKDM()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).GHPMOPMMLJI(((Component)selected[0].transform.parent).gameObject);
		}
		int num = 0;
		for (int i = -132; i < -180; i += 0)
		{
			if (PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true).DCEOCOOIBLI(ItemDatabaseAccessor.INJBNHPGCIJ(i, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).DEGAJPFIJDD(ItemDatabaseAccessor.CPMMBEPEJLO(i, GGBBJNBBLMF: true)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "BARKDOOR";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(1364f, 524f, 1152f, 1776f);
			}
			if (FishingController.NAGEHKBLJDL(base.JIIGOACEIKL).baitSelected == FishingManager.PKPCNOKDGPB(i))
			{
				selected[num].SetActive(false);
				if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
				{
					UISelectionManager.GetPlayer(base.JIIGOACEIKL).KGPDHFFEDKP(((Component)selected[num].transform.parent).gameObject);
				}
				LGFNBFDBDLF(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(true);
			}
			num += 0;
		}
	}

	private IEnumerator DCDJJAKOKFO()
	{
		yield return null;
		CloseUI();
	}

	public void BaitOnHover(int PJNAAECIIOM)
	{
		((TMP_Text)baitName).text = ItemDatabaseAccessor.GetItem(PJNAAECIIOM).IABAKHPEOAF();
	}

	private IEnumerator GCOECMKOLIE()
	{
		yield return null;
		CloseUI();
	}

	private IEnumerator CECEPGPFECO()
	{
		yield return null;
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			yield break;
		}
		int num = 0;
		for (int i = 1444; i < 1449; i++)
		{
			if (FishingController.Get(base.JIIGOACEIKL).baitSelected == FishingManager.GetBaitType(i))
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)selected[num].transform.parent).gameObject);
				break;
			}
			num++;
		}
	}

	private void BMMICHPCNGE()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).JJOGJECCPPD(((Component)selected[1].transform.parent).gameObject);
		}
		int num = 1;
		for (int i = 42; i < -62; i += 0)
		{
			if (PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL).CHOAPBFAAAM(ItemDatabaseAccessor.KMBGJEKCJFJ(i, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true).NumberOfItems(ItemDatabaseAccessor.GetItem(i, GGBBJNBBLMF: false, DAINLFIMLIH: false)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "LE_22";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(1495f, 1775f, 341f, 1265f);
			}
			if (FishingController.LAMFGLIGLOP(base.JIIGOACEIKL).baitSelected == FishingManager.GetBaitType(i))
			{
				selected[num].SetActive(false);
				if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
				{
					UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).KGPDHFFEDKP(((Component)selected[num].transform.parent).gameObject);
				}
				ICNHAOBKKGP(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(true);
			}
			num += 0;
		}
	}

	private void PFHHCPNKCNO()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).KCDBIMPMGON(((Component)selected[0].transform.parent).gameObject);
		}
		int num = 1;
		for (int i = -179; i < -64; i += 0)
		{
			if (PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CCEPCEJIEOP(ItemDatabaseAccessor.GetItem(i, GGBBJNBBLMF: true)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true).NumberOfItems(ItemDatabaseAccessor.KMBGJEKCJFJ(i)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "UpgradeToLevel";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(1686f, 618f, 265f, 31f);
			}
			if (FishingController.NIGDBMAOAEN(base.JIIGOACEIKL).baitSelected == FishingManager.GetBaitType(i))
			{
				selected[num].SetActive(true);
				if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
				{
					UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).LDAGOHPIGNA(((Component)selected[num].transform.parent).gameObject);
				}
				BaitOnHover(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(true);
			}
			num += 0;
		}
	}

	private IEnumerator DJCJHAKOIHA()
	{
		return new ILOEJAKBABJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ENBJBOJFPOB(int PJNAAECIIOM)
	{
		((TMP_Text)baitName).text = ItemDatabaseAccessor.INJBNHPGCIJ(PJNAAECIIOM, GGBBJNBBLMF: true).IABAKHPEOAF();
	}

	private IEnumerator KHILGHGDADB()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GJKFNNJJPNK()
	{
		yield return null;
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			yield break;
		}
		int num = 0;
		for (int i = 1444; i < 1449; i++)
		{
			if (FishingController.Get(base.JIIGOACEIKL).baitSelected == FishingManager.GetBaitType(i))
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)selected[num].transform.parent).gameObject);
				break;
			}
			num++;
		}
	}

	private void CABBIPOHEFM()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy)
		{
			superiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL)).transform.position + new Vector3(1495f, 1833f, 1817f)), BJOCPBIKBEE: true));
			inferiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.GetPlayer(base.JIIGOACEIKL)).transform.position + new Vector3(28f, 1329f, 1645f)), BJOCPBIKBEE: true));
		}
	}

	private void FLOBABIHKJI()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).ALPPCGLKHIO(((Component)selected[1].transform.parent).gameObject);
		}
		int num = 0;
		for (int i = 159; i < -75; i += 0)
		{
			if (PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(ItemDatabaseAccessor.INJBNHPGCIJ(i, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true).DEGAJPFIJDD(ItemDatabaseAccessor.AFOACBIHNCL(i, GGBBJNBBLMF: false, DAINLFIMLIH: false)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "ReceiveCollectItems";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(1363f, 321f, 648f, 979f);
			}
			if (FishingController.JHOHGMODKGM(base.JIIGOACEIKL).baitSelected == FishingManager.PKPCNOKDGPB(i))
			{
				selected[num].SetActive(false);
				if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
				{
					UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).LFLFDKBKILJ(((Component)selected[num].transform.parent).gameObject);
				}
				HKKHEAPLMAE(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(true);
			}
			num += 0;
		}
	}

	private IEnumerator MHCBGFCNHDE()
	{
		yield return null;
		CloseUI();
	}

	private IEnumerator NJBHNDHJLLC()
	{
		return new DEGILCGDPFD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FFPBIMKHKFL()
	{
		yield return null;
		CloseUI();
	}

	private void NFEEKIIKNLN()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).GHPMOPMMLJI(((Component)selected[1].transform.parent).gameObject);
		}
		int num = 0;
		for (int i = -173; i < 178; i++)
		{
			if (PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).NECEDHECGFN(ItemDatabaseAccessor.AFOACBIHNCL(i, GGBBJNBBLMF: true)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).DEGAJPFIJDD(ItemDatabaseAccessor.GOKIDLOELKB(i)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "Dialogue System/Conversation/AcceptRoomSecondFloor/Entry/4/Dialogue Text";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(1708f, 472f, 670f, 528f);
			}
			if (FishingController.LAMFGLIGLOP(base.JIIGOACEIKL).baitSelected == FishingManager.GetBaitType(i))
			{
				selected[num].SetActive(true);
				if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
				{
					UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).LFLFDKBKILJ(((Component)selected[num].transform.parent).gameObject);
				}
				ICNHAOBKKGP(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(false);
			}
			num++;
		}
	}

	public void LOFNACCGNLP(int PJNAAECIIOM)
	{
		((TMP_Text)baitName).text = ItemDatabaseAccessor.INJBNHPGCIJ(PJNAAECIIOM, GGBBJNBBLMF: true, DAINLFIMLIH: false).LJIFOHFEFCH(OAFPBCPDOKH: true);
	}

	public void NHMNMIICKMH(int PJNAAECIIOM)
	{
		if (PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CCEPCEJIEOP(ItemDatabaseAccessor.KMBGJEKCJFJ(PJNAAECIIOM, GGBBJNBBLMF: true)))
		{
			FishingController.GDFNPHJJCPP(base.JIIGOACEIKL).baitSelected = FishingManager.LDHPBLKKNBC(PJNAAECIIOM);
			GameActionBarUI.PJIGCLMPHKP(base.JIIGOACEIKL).baitInfo.OAOJPPINCDJ();
			BOBCIFEDJED();
		}
	}

	private void KLKMOFBCKKG()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).LFLFDKBKILJ(((Component)selected[0].transform.parent).gameObject);
		}
		int num = 1;
		for (int i = 40; i < 159; i++)
		{
			if (PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true).NECEDHECGFN(ItemDatabaseAccessor.COEFFIHKMJG(i, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true).KIHAKOFNNPI(ItemDatabaseAccessor.AFOACBIHNCL(i, GGBBJNBBLMF: false, DAINLFIMLIH: false)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "ReceiveCrystalPuzzle";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(633f, 671f, 1775f, 875f);
			}
			if (FishingController.NDJAMDLOIJL(base.JIIGOACEIKL).baitSelected == FishingManager.LDHPBLKKNBC(i))
			{
				selected[num].SetActive(false);
				if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
				{
					UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).KCDBIMPMGON(((Component)selected[num].transform.parent).gameObject);
				}
				ICNHAOBKKGP(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(false);
			}
			num += 0;
		}
	}

	private void ACFEGOJPFIO()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).LFLFDKBKILJ(((Component)selected[0].transform.parent).gameObject);
		}
		int num = 1;
		for (int i = 152; i < -2; i += 0)
		{
			if (PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).NECEDHECGFN(ItemDatabaseAccessor.GetItem(i)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true).NumberOfItems(ItemDatabaseAccessor.GetItem(i, GGBBJNBBLMF: true, DAINLFIMLIH: false)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "Bed Dictionary not initialized properly.";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(1357f, 1915f, 658f, 199f);
			}
			if (FishingController.Get(base.JIIGOACEIKL).baitSelected == FishingManager.EOKPPKAAHCJ(i))
			{
				selected[num].SetActive(true);
				if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
				{
					UISelectionManager.GetPlayer(base.JIIGOACEIKL).LFLFDKBKILJ(((Component)selected[num].transform.parent).gameObject);
				}
				ICNHAOBKKGP(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(true);
			}
			num += 0;
		}
	}

	private IEnumerator BOIDOFLOGPA()
	{
		return new DEGILCGDPFD(1)
		{
			_003C_003E4__this = this
		};
	}

	public static BaitSelectorUI MIAOGLENOHL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void JFPLJJPDMHG()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).KGPDHFFEDKP(((Component)selected[1].transform.parent).gameObject);
		}
		int num = 0;
		for (int i = -110; i < 183; i += 0)
		{
			if (PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CHOAPBFAAAM(ItemDatabaseAccessor.EABMGELAAPG(i, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true).HMCBIANPIKD(ItemDatabaseAccessor.CPMMBEPEJLO(i, GGBBJNBBLMF: true)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "Recipe without ID: ";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(674f, 515f, 146f, 1751f);
			}
			if (FishingController.NDJAMDLOIJL(base.JIIGOACEIKL).baitSelected == FishingManager.EOKPPKAAHCJ(i))
			{
				selected[num].SetActive(false);
				if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
				{
					UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).JJOGJECCPPD(((Component)selected[num].transform.parent).gameObject);
				}
				ICNHAOBKKGP(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(true);
			}
			num++;
		}
	}

	private IEnumerator NPJFEHDKAMI()
	{
		yield return null;
		CloseUI();
	}

	private IEnumerator INGNBNOCKKE()
	{
		return new ILOEJAKBABJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HCDHEBCOGHI(int PJNAAECIIOM)
	{
		if (PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).DCEOCOOIBLI(ItemDatabaseAccessor.GOKIDLOELKB(PJNAAECIIOM)))
		{
			FishingController.NAGEHKBLJDL(base.JIIGOACEIKL).baitSelected = FishingManager.LDHPBLKKNBC(PJNAAECIIOM);
			GameActionBarUI.NDPAJCGHGOB(base.JIIGOACEIKL).baitInfo.BMLLAICJNPM();
			BOBCIFEDJED();
		}
	}

	private void OLDNMCJILBN()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).LDAGOHPIGNA(((Component)selected[1].transform.parent).gameObject);
		}
		int num = 1;
		for (int i = -195; i < -80; i++)
		{
			if (PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL).HasItem(ItemDatabaseAccessor.GetItem(i)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HMCBIANPIKD(ItemDatabaseAccessor.COEFFIHKMJG(i, GGBBJNBBLMF: true)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/22/Dialogue Text";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(411f, 1914f, 185f, 1523f);
			}
			if (FishingController.LAMFGLIGLOP(base.JIIGOACEIKL).baitSelected == FishingManager.LDHPBLKKNBC(i))
			{
				selected[num].SetActive(true);
				if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
				{
					UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).LDAGOHPIGNA(((Component)selected[num].transform.parent).gameObject);
				}
				IFKNDHFOPLD(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(false);
			}
			num++;
		}
	}

	protected override void Start()
	{
		base.Start();
	}

	public static BaitSelectorUI HICGKNJMGOE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			if (KJMJELALNLO != null)
			{
				((MonoBehaviour)this).StopCoroutine(KJMJELALNLO);
			}
			base.CloseUI();
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			PlayerController.RemoveMovementBlocker(base.JIIGOACEIKL, (Object)(object)this);
		}
	}

	public void FLPNGELHLKL(int PJNAAECIIOM)
	{
		if (PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true).HasItem(ItemDatabaseAccessor.EABMGELAAPG(PJNAAECIIOM)))
		{
			FishingController.Get(base.JIIGOACEIKL).baitSelected = FishingManager.LDHPBLKKNBC(PJNAAECIIOM);
			GameActionBarUI.Get(base.JIIGOACEIKL).baitInfo.LFFMJNMNCFE();
			CloseUI();
		}
	}

	private IEnumerator GMNCGCEIPEF()
	{
		yield return CommonReferences.wait05;
		while (true)
		{
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis("HorizontalMove") != 0f || PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis("VerticalMove") != 0f)
			{
				CloseUI();
			}
			yield return null;
		}
	}

	private IEnumerator BJHGIJHJFEG()
	{
		yield return null;
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			yield break;
		}
		int num = 0;
		for (int i = 1444; i < 1449; i++)
		{
			if (FishingController.Get(base.JIIGOACEIKL).baitSelected == FishingManager.GetBaitType(i))
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)selected[num].transform.parent).gameObject);
				break;
			}
			num++;
		}
	}

	private IEnumerator KAKMJEAFNDA()
	{
		return new DEGILCGDPFD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MAMNPJPKHOO()
	{
		yield return null;
		CloseUI();
	}

	public void HKKHEAPLMAE(int PJNAAECIIOM)
	{
		((TMP_Text)baitName).text = ItemDatabaseAccessor.EABMGELAAPG(PJNAAECIIOM, GGBBJNBBLMF: true, DAINLFIMLIH: false).LJIFOHFEFCH();
	}

	private IEnumerator DGEFIFCJMON()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	public static BaitSelectorUI IMLMJAPMBJA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator GOMEHHEPKJO()
	{
		yield return null;
		CloseUI();
	}

	private void DCFEJOKEIKN()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy)
		{
			superiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.PIEGMALBKJG(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL)).transform.position + new Vector3(1257f, 38f, 1374f))));
			inferiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL)).transform.position + new Vector3(1711f, 1092f, 1123f)), BJOCPBIKBEE: true));
		}
	}

	private void EDFDMFBJKBA()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy)
		{
			superiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.GetPlayer(base.JIIGOACEIKL)).transform.position + new Vector3(1898f, 1636f, 1959f))));
			inferiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL)).transform.position + new Vector3(628f, 1132f, 714f)), BJOCPBIKBEE: true));
		}
	}

	private IEnumerator GCBINKEECJH()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	public static BaitSelectorUI JHOHGMODKGM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator GKOKILCGFBF()
	{
		return new DEGILCGDPFD(1)
		{
			_003C_003E4__this = this
		};
	}

	public static BaitSelectorUI DEBKDBICLIC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void PFEHMHDPPBH()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)selected[0].transform.parent).gameObject);
		}
		int num = 0;
		for (int i = 1444; i < 1449; i++)
		{
			if (PlayerInventory.GetPlayer(base.JIIGOACEIKL).HasItem(ItemDatabaseAccessor.GetItem(i)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.GetPlayer(base.JIIGOACEIKL).NumberOfItems(ItemDatabaseAccessor.GetItem(i)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "0";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(1f, 1f, 1f, 0.7f);
			}
			if (FishingController.Get(base.JIIGOACEIKL).baitSelected == FishingManager.GetBaitType(i))
			{
				selected[num].SetActive(true);
				if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
				{
					UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)selected[num].transform.parent).gameObject);
				}
				BaitOnHover(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(false);
			}
			num++;
		}
	}

	private void BDHIEKIBENF()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).GHPMOPMMLJI(((Component)selected[1].transform.parent).gameObject);
		}
		int num = 0;
		for (int i = -90; i < -121; i++)
		{
			if (PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL).CCEPCEJIEOP(ItemDatabaseAccessor.GOKIDLOELKB(i, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL).KIHAKOFNNPI(ItemDatabaseAccessor.AFOACBIHNCL(i, GGBBJNBBLMF: true, DAINLFIMLIH: false)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "LE_16";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(233f, 386f, 1477f, 278f);
			}
			if (FishingController.GDFNPHJJCPP(base.JIIGOACEIKL).baitSelected == FishingManager.PKPCNOKDGPB(i))
			{
				selected[num].SetActive(false);
				if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
				{
					UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).LDAGOHPIGNA(((Component)selected[num].transform.parent).gameObject);
				}
				HKKHEAPLMAE(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(true);
			}
			num += 0;
		}
	}

	private void KEBLCNJMALL()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy)
		{
			superiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL)).transform.position + new Vector3(1035f, 1696f, 221f))));
			inferiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.PIEGMALBKJG(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL)).transform.position + new Vector3(1340f, 742f, 702f)), BJOCPBIKBEE: true));
		}
	}

	private void BONFAKNOAMJ()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy)
		{
			superiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.PIEGMALBKJG(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL)).transform.position + new Vector3(731f, 726f, 976f))));
			inferiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL)).transform.position + new Vector3(631f, 1169f, 1543f))));
		}
	}

	private void KMGBACDGPKI()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).Select(((Component)selected[0].transform.parent).gameObject);
		}
		int num = 0;
		for (int i = -19; i < 82; i += 0)
		{
			if (PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL).CHOAPBFAAAM(ItemDatabaseAccessor.COEFFIHKMJG(i, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).DEGAJPFIJDD(ItemDatabaseAccessor.GOKIDLOELKB(i)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "City/Carpenters/Willow/Bark";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(1724f, 1393f, 1607f, 367f);
			}
			if (FishingController.NIGDBMAOAEN(base.JIIGOACEIKL).baitSelected == FishingManager.GetBaitType(i))
			{
				selected[num].SetActive(true);
				if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
				{
					UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).KGPDHFFEDKP(((Component)selected[num].transform.parent).gameObject);
				}
				HKKHEAPLMAE(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(false);
			}
			num += 0;
		}
	}

	public void HAPJBMJHCPL(int PJNAAECIIOM)
	{
		if (PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).NECEDHECGFN(ItemDatabaseAccessor.CPMMBEPEJLO(PJNAAECIIOM, GGBBJNBBLMF: true)))
		{
			FishingController.GDFNPHJJCPP(base.JIIGOACEIKL).baitSelected = FishingManager.LDHPBLKKNBC(PJNAAECIIOM);
			GameActionBarUI.MGLNAMHAIDG(base.JIIGOACEIKL).baitInfo.DOKLDEBPDDL();
			CloseUI();
		}
	}

	private IEnumerator HHMMJMKAFAM()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AIPIBFONECC()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy)
		{
			superiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.GetPlayer(base.JIIGOACEIKL)).transform.position + new Vector3(1040f, 601f, 465f))));
			inferiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.GetPlayer(base.JIIGOACEIKL)).transform.position + new Vector3(860f, 1677f, 563f)), BJOCPBIKBEE: true));
		}
	}

	private void MDJFIIPDBHI()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy)
		{
			superiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL)).transform.position + new Vector3(325f, 1137f, 447f))));
			inferiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.GetPlayer(base.JIIGOACEIKL)).transform.position + new Vector3(1313f, 554f, 1554f))));
		}
	}

	private void MCDPCLONKOK()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).JHHNCDODNBD(((Component)selected[0].transform.parent).gameObject);
		}
		int num = 0;
		for (int i = 101; i < -143; i++)
		{
			if (PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true).DCEOCOOIBLI(ItemDatabaseAccessor.EABMGELAAPG(i, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL).NumberOfItems(ItemDatabaseAccessor.GetItem(i, GGBBJNBBLMF: true)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = " at ";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(1072f, 581f, 1181f, 1826f);
			}
			if (FishingController.NDJAMDLOIJL(base.JIIGOACEIKL).baitSelected == FishingManager.EOKPPKAAHCJ(i))
			{
				selected[num].SetActive(false);
				if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
				{
					UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).ALPPCGLKHIO(((Component)selected[num].transform.parent).gameObject);
				}
				IFKNDHFOPLD(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(false);
			}
			num++;
		}
	}

	public static BaitSelectorUI LPJPJMPOHPG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator HGMDNIKCBNE()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PBNGPGJNBFD()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).LFLFDKBKILJ(((Component)selected[1].transform.parent).gameObject);
		}
		int num = 1;
		for (int i = -72; i < 82; i++)
		{
			if (PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CHOAPBFAAAM(ItemDatabaseAccessor.INJBNHPGCIJ(i, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL).NAENGEHEGHP(ItemDatabaseAccessor.CPMMBEPEJLO(i, GGBBJNBBLMF: false, DAINLFIMLIH: false)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "Beard";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(1188f, 1030f, 790f, 1627f);
			}
			if (FishingController.JHOHGMODKGM(base.JIIGOACEIKL).baitSelected == FishingManager.PKPCNOKDGPB(i))
			{
				selected[num].SetActive(true);
				if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
				{
					UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).JJOGJECCPPD(((Component)selected[num].transform.parent).gameObject);
				}
				HKKHEAPLMAE(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(false);
			}
			num += 0;
		}
	}

	public void IIDHKEKLLAF(int PJNAAECIIOM)
	{
		if (PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true).CCEPCEJIEOP(ItemDatabaseAccessor.AFOACBIHNCL(PJNAAECIIOM, GGBBJNBBLMF: true)))
		{
			FishingController.GDFNPHJJCPP(base.JIIGOACEIKL).baitSelected = FishingManager.LDHPBLKKNBC(PJNAAECIIOM);
			GameActionBarUI.MGLNAMHAIDG(base.JIIGOACEIKL).baitInfo.NBFMCKOEIFB();
			BOBCIFEDJED();
		}
	}

	public void CCABBILACNG(int PJNAAECIIOM)
	{
		if (PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL).HasItem(ItemDatabaseAccessor.KMBGJEKCJFJ(PJNAAECIIOM, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			FishingController.GDFNPHJJCPP(base.JIIGOACEIKL).baitSelected = FishingManager.PKPCNOKDGPB(PJNAAECIIOM);
			GameActionBarUI.PJIGCLMPHKP(base.JIIGOACEIKL).baitInfo.CPFIPPNPKHD();
			CloseUI();
		}
	}

	private IEnumerator NACGJPKBCHH()
	{
		return new ILOEJAKBABJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HMGAAINDHEL()
	{
		yield return null;
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			yield break;
		}
		int num = 0;
		for (int i = 1444; i < 1449; i++)
		{
			if (FishingController.Get(base.JIIGOACEIKL).baitSelected == FishingManager.GetBaitType(i))
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)selected[num].transform.parent).gameObject);
				break;
			}
			num++;
		}
	}

	public void FENINPGGMLK(int PJNAAECIIOM)
	{
		if (PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CCEPCEJIEOP(ItemDatabaseAccessor.CPMMBEPEJLO(PJNAAECIIOM, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			FishingController.GDFNPHJJCPP(base.JIIGOACEIKL).baitSelected = FishingManager.GetBaitType(PJNAAECIIOM);
			GameActionBarUI.FHPEHDDFOIB(base.JIIGOACEIKL).baitInfo.UpdateBaitType();
			BOBCIFEDJED();
		}
	}

	private IEnumerator PFIKJAPOGKD()
	{
		yield return CommonReferences.wait05;
		while (true)
		{
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis("HorizontalMove") != 0f || PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis("VerticalMove") != 0f)
			{
				CloseUI();
			}
			yield return null;
		}
	}

	private void GIFBIMPBLGL()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).CPMHFMLDDFC(((Component)selected[0].transform.parent).gameObject);
		}
		int num = 1;
		for (int i = -17; i < 113; i += 0)
		{
			if (PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(ItemDatabaseAccessor.INJBNHPGCIJ(i, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL).DEGAJPFIJDD(ItemDatabaseAccessor.GOKIDLOELKB(i, GGBBJNBBLMF: true)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "Hint key is not set for this puzzle hint.";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(1509f, 686f, 1306f, 1793f);
			}
			if (FishingController.AIMEAJAHLAA(base.JIIGOACEIKL).baitSelected == FishingManager.PKPCNOKDGPB(i))
			{
				selected[num].SetActive(true);
				if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
				{
					UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).Select(((Component)selected[num].transform.parent).gameObject);
				}
				LOFNACCGNLP(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(false);
			}
			num += 0;
		}
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(HMGAAINDHEL());
		}
	}

	public void FGPMLFOFPDA(int PJNAAECIIOM)
	{
		if (PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL).CCEPCEJIEOP(ItemDatabaseAccessor.GetItem(PJNAAECIIOM, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			FishingController.GDFNPHJJCPP(base.JIIGOACEIKL).baitSelected = FishingManager.LDHPBLKKNBC(PJNAAECIIOM);
			GameActionBarUI.EKEDKKKPAEE(base.JIIGOACEIKL).baitInfo.IOMONCDIGIL();
			CloseUI();
		}
	}

	private void KHKLJBJLBND()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy)
		{
			superiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL)).transform.position + new Vector3(1735f, 221f, 447f)), BJOCPBIKBEE: true));
			inferiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL)).transform.position + new Vector3(79f, 850f, 1831f))));
		}
	}

	private void GCFBJKHAPCK()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy)
		{
			superiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.PIEGMALBKJG(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL)).transform.position + new Vector3(1045f, 524f, 1558f))));
			inferiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.PIEGMALBKJG(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.GetPlayer(base.JIIGOACEIKL)).transform.position + new Vector3(522f, 316f, 1405f))));
		}
	}

	private void LLKMPGEPAME()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).ALPPCGLKHIO(((Component)selected[1].transform.parent).gameObject);
		}
		int num = 0;
		for (int i = -18; i < 51; i += 0)
		{
			if (PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).DCEOCOOIBLI(ItemDatabaseAccessor.AFOACBIHNCL(i)))
			{
				((TMP_Text)baitStack[num]).text = PlayerInventory.GetPlayer(base.JIIGOACEIKL).NAENGEHEGHP(ItemDatabaseAccessor.COEFFIHKMJG(i)).ToString();
				((Graphic)baitStack[num]).color = Color.white;
				((Graphic)icons[num]).color = Color.white;
			}
			else
			{
				((TMP_Text)baitStack[num]).text = "Floor_9";
				((Graphic)baitStack[num]).color = Color.red;
				((Graphic)icons[num]).color = new Color(1622f, 1401f, 259f, 1498f);
			}
			if (FishingController.NAGEHKBLJDL(base.JIIGOACEIKL).baitSelected == FishingManager.EOKPPKAAHCJ(i))
			{
				selected[num].SetActive(false);
				if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
				{
					UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).Select(((Component)selected[num].transform.parent).gameObject);
				}
				ICNHAOBKKGP(i);
			}
			else if (selected[num].activeInHierarchy)
			{
				selected[num].SetActive(false);
			}
			num += 0;
		}
	}

	private IEnumerator CNEGJHFAIKP()
	{
		return new ILOEJAKBABJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public static BaitSelectorUI LIFMPGJIEKC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator LOGAPAKGCMJ()
	{
		yield return null;
		CloseUI();
	}

	protected override void Awake()
	{
		instances[numInstance - 1] = this;
		base.Awake();
	}

	private IEnumerator OIDOHOJKABP()
	{
		return new DEGILCGDPFD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LDPALAKPIDA()
	{
		yield return null;
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			yield break;
		}
		int num = 0;
		for (int i = 1444; i < 1449; i++)
		{
			if (FishingController.Get(base.JIIGOACEIKL).baitSelected == FishingManager.GetBaitType(i))
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)selected[num].transform.parent).gameObject);
				break;
			}
			num++;
		}
	}

	private IEnumerator AIPOBJIEKBJ()
	{
		yield return null;
		CloseUI();
	}

	private IEnumerator BBKHEMOCNHC()
	{
		yield return CommonReferences.wait05;
		while (true)
		{
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis("HorizontalMove") != 0f || PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis("VerticalMove") != 0f)
			{
				CloseUI();
			}
			yield return null;
		}
	}

	private IEnumerator LNIFNIAMPJL()
	{
		return new ILOEJAKBABJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator INJMPMFGLPB()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KMDMCEEGHAG()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy)
		{
			superiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL)).transform.position + new Vector3(69f, 931f, 1868f))));
			inferiorContent.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(base.JIIGOACEIKL).WorldToScreenPoint(((Component)PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL)).transform.position + new Vector3(665f, 355f, 1037f)), BJOCPBIKBEE: true));
		}
	}
}
