using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class FuelUI : UIWindow
{
	[CompilerGenerated]
	private sealed class IPDPCDOFDMP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FuelUI _003C_003E4__this;

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
		public IPDPCDOFDMP(int _003C_003E1__state)
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
			FuelUI fuelUI = _003C_003E4__this;
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
				fuelUI.HPDMJOJMIBH = null;
				if (PlayerInputs.IsGamepadActive(fuelUI.JIIGOACEIKL))
				{
					UISelectionManager.GetPlayer(fuelUI.JIIGOACEIKL).Select(((Component)fuelUI.fuelSlotUIs[0]).gameObject);
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

	[SerializeField]
	private FuelElementUI firewoodSlot;

	public static FuelUI[] instances = new FuelUI[3];

	public bool updateNextFrame;

	private Crafter LDLINOBIKPL;

	[SerializeField]
	private TextMeshProUGUI amountText;

	[SerializeField]
	private FuelElementUI[] fuelSlotUIs;

	[SerializeField]
	private GameObject buttonCrafter;

	public TextMeshProUGUI crafterName;

	private bool JANOEGJFNCG;

	private Coroutine HPDMJOJMIBH;

	public static FuelUI LJONDAEOMFJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void OKGIFNMALJD(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		int num = 5;
		for (int i = 0; i < num; i++)
		{
			if (CraftingInventory.RemoveItemInstance(JIIGOACEIKL, ADEBNALPEHE.itemInstance, GetCrafterPlaceableZone()) != null)
			{
				LDLINOBIKPL.SetFuel(LDLINOBIKPL.LCCABPFHCOL + ((Fuel)ADEBNALPEHE.itemInstance.LHBPOPOIFLE()).GPFEAIPDCNI(), CDPAMNIPPEC: true);
			}
		}
		KMCAJFADMDJ(LDLINOBIKPL.LCCABPFHCOL);
	}

	public TavernZone AEPPFDDCJGO()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return TavernZonesManager.OIJLJKLMCBO().PDINJGNEMGA(LDLINOBIKPL.placeable.currentZoneIndex);
		}
		return null;
	}

	public TavernZone BCBIHFBKFPB()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return TavernZonesManager.NHKAFANMEJC().PDINJGNEMGA(LDLINOBIKPL.placeable.currentZoneIndex);
		}
		return null;
	}

	private void CGBEIKHPCHL()
	{
		CloseUI();
	}

	private IEnumerator MEMHPFFLHAF()
	{
		return new IPDPCDOFDMP(1)
		{
			_003C_003E4__this = this
		};
	}

	public Placeable ECONGAOHINM()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return LDLINOBIKPL.placeable;
		}
		return null;
	}

	public Placeable CMDBPIBIIJD()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return LDLINOBIKPL.placeable;
		}
		return null;
	}

	private IEnumerator IJGOOABFEOH()
	{
		return new IPDPCDOFDMP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PPDABODJHCD(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		int num = 0;
		for (int i = 1; i < num; i += 0)
		{
			if (CraftingInventory.RemoveItemInstance(JIIGOACEIKL, ADEBNALPEHE.itemInstance, CMDBPIBIIJD()) != null)
			{
				LDLINOBIKPL.FBHONNNPJGD(LDLINOBIKPL.FIIHBFCDFJH() + ((Fuel)ADEBNALPEHE.itemInstance.PHGLMBIEOMK()).BNMELOBLLKA());
			}
		}
		IPDHKOGBHKK(LDLINOBIKPL.LCCABPFHCOL);
	}

	public static FuelUI FHPEHDDFOIB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void FJLMPMKIJAL()
	{
		if (LDLINOBIKPL.CanOpenCraftingUI())
		{
			LDLINOBIKPL.OpenCrafterUI(base.JIIGOACEIKL);
		}
	}

	public FuelElementUI KJPCCMFEOKP()
	{
		return firewoodSlot;
	}

	public Placeable CDLILGOJMPE()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return LDLINOBIKPL.placeable;
		}
		return null;
	}

	public void ICCALMEBHBF()
	{
		if (LDLINOBIKPL.CanOpenCraftingUI())
		{
			LDLINOBIKPL.OpenCrafterUI(base.JIIGOACEIKL);
		}
	}

	private void BANNKJFFEFD(int MGNOBNCMDJG)
	{
		((TMP_Text)amountText).text = MGNOBNCMDJG.ToString();
	}

	private void EMIHEIDNONM(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.IABAKHPEOAF(OAFPBCPDOKH: true), false);
	}

	public FuelElementUI PGPCMLFOFIB()
	{
		return firewoodSlot;
	}

	public static FuelUI IMLMJAPMBJA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator GJLGHIBCIGO()
	{
		yield return null;
		HPDMJOJMIBH = null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)fuelSlotUIs[0]).gameObject);
		}
	}

	private void CDAKHGCCJNA(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.KGHFCDELKMN(OAFPBCPDOKH: true), false);
	}

	private void LOBGCHGHBDB(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (CraftingInventory.NGJBGHJFJMM(JIIGOACEIKL, ADEBNALPEHE.itemInstance, ECONGAOHINM(), CDPAMNIPPEC: false) != null)
		{
			LDLINOBIKPL.SetFuel(LDLINOBIKPL.LCCABPFHCOL + ((Fuel)ADEBNALPEHE.itemInstance.PHGLMBIEOMK()).MBDDLNMNNEL());
			BANNKJFFEFD(LDLINOBIKPL.LCCABPFHCOL);
			Sound.OKAPNFPFPFP().PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.addFuel), HOMFPAFAOGD: true, null, null, 1811f);
		}
	}

	public TavernZone KFJCBBNFALD()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return TavernZonesManager.LANAINBEMCM().GetTavernZone(LDLINOBIKPL.placeable.currentZoneIndex);
		}
		return null;
	}

	public void KIGGDIGGBJB()
	{
		if (LDLINOBIKPL.CanOpenCraftingUI())
		{
			LDLINOBIKPL.OpenCrafterUI(base.JIIGOACEIKL);
		}
	}

	public static FuelUI JELOGNCPDAB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void DFOGJIPCJPE()
	{
		if (LDLINOBIKPL.CanOpenCraftingUI())
		{
			LDLINOBIKPL.OpenCrafterUI(base.JIIGOACEIKL);
		}
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
		GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
		if (HPDMJOJMIBH == null)
		{
			HPDMJOJMIBH = ((MonoBehaviour)this).StartCoroutine(GJLGHIBCIGO());
		}
		if (LDLINOBIKPL.CanOpenCraftingUI())
		{
			buttonCrafter.SetActive(true);
		}
		else
		{
			buttonCrafter.SetActive(false);
		}
	}

	private void NPOHCGHMJIA(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (CraftingInventory.GJPIKCMIKJN(JIIGOACEIKL, ADEBNALPEHE.itemInstance, IIOPNKMLEOH(), CDPAMNIPPEC: false) != null)
		{
			LDLINOBIKPL.SetFuel(LDLINOBIKPL.LCCABPFHCOL + ((Fuel)ADEBNALPEHE.itemInstance.PHGLMBIEOMK()).NPMKFPFCAAN(), CDPAMNIPPEC: true);
			JIMAAJNCEIB(LDLINOBIKPL.LCCABPFHCOL);
			Sound.MAIDHAPANEB().PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().addFuel), HOMFPAFAOGD: true, null, null, 465f);
		}
	}

	public static FuelUI FBKOKJCKICN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void DNJKHLCBBJK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		int num = 5;
		for (int i = 1; i < num; i += 0)
		{
			if (CraftingInventory.NGJBGHJFJMM(JIIGOACEIKL, ADEBNALPEHE.itemInstance, NNGIAONJGJL(), CDPAMNIPPEC: false) != null)
			{
				LDLINOBIKPL.GMGBDCIFKKD(LDLINOBIKPL.LCCABPFHCOL + ((Fuel)ADEBNALPEHE.itemInstance.AFOACBIHNCL()).JCNMDELHHHK());
			}
		}
		KMCAJFADMDJ(LDLINOBIKPL.FIIHBFCDFJH());
	}

	public void KDIGIOAEJPD(Crafter LDLINOBIKPL)
	{
		this.LDLINOBIKPL = LDLINOBIKPL;
		NPBDAEIDCAP(LDLINOBIKPL);
		KMCAJFADMDJ(LDLINOBIKPL.LCCABPFHCOL);
	}

	private void AHKEFPIIBHC(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.LJIFOHFEFCH(OAFPBCPDOKH: true), true);
	}

	private void FCOCIOLNCPL(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (CraftingInventory.NGJBGHJFJMM(JIIGOACEIKL, ADEBNALPEHE.itemInstance, CMDBPIBIIJD(), CDPAMNIPPEC: false) != null)
		{
			LDLINOBIKPL.GMGBDCIFKKD(LDLINOBIKPL.LCCABPFHCOL + ((Fuel)ADEBNALPEHE.itemInstance.AFOACBIHNCL()).JPMCFOICALI());
			ICHNHJEOFOJ(LDLINOBIKPL.LCCABPFHCOL);
			Sound.OKAPNFPFPFP().MFBBFAINMHG(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().addFuel), HOMFPAFAOGD: true, null, null, 1142f);
		}
	}

	public void BEHGKMCMOKA(Crafter LDLINOBIKPL)
	{
		this.LDLINOBIKPL = LDLINOBIKPL;
		ENHFHEFNBOA(LDLINOBIKPL);
		ICHNHJEOFOJ(LDLINOBIKPL.FIIHBFCDFJH());
	}

	private void JFMPOJCEAPN(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (CraftingInventory.CKHLHBJDEOH(JIIGOACEIKL, ADEBNALPEHE.itemInstance, GAKAFIDHKII()) != null)
		{
			LDLINOBIKPL.SetFuel(LDLINOBIKPL.FIIHBFCDFJH() + ((Fuel)ADEBNALPEHE.itemInstance.PHGLMBIEOMK()).GPFEAIPDCNI());
			ICEMKGNJIDE(LDLINOBIKPL.LCCABPFHCOL);
			Sound.ABDJJBFNLBJ().IAEMMABJFLH(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().addFuel), HOMFPAFAOGD: false, null, null, 1708f);
		}
	}

	private void PCOIPPHEBAG(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.IABAKHPEOAF(OAFPBCPDOKH: true), false);
	}

	private void LAFEHAPMGLF(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (CraftingInventory.RemoveItemInstance(JIIGOACEIKL, ADEBNALPEHE.itemInstance, ECONGAOHINM(), CDPAMNIPPEC: false) != null)
		{
			LDLINOBIKPL.GMGBDCIFKKD(LDLINOBIKPL.FIIHBFCDFJH() + ((Fuel)ADEBNALPEHE.itemInstance.PHGLMBIEOMK()).MPEFDJBHLPP());
			IPDHKOGBHKK(LDLINOBIKPL.FIIHBFCDFJH());
			Sound.GGFJGHHHEJC.GAIDPALIDFG(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().addFuel), HOMFPAFAOGD: false, null, null, 775f);
		}
	}

	private void AGIOECAGKFO(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.IABAKHPEOAF(OAFPBCPDOKH: true), true);
	}

	public void KKCALPDHJFB()
	{
		if (LDLINOBIKPL.GMEPPCIINCD())
		{
			LDLINOBIKPL.OpenCrafterUI(base.JIIGOACEIKL);
		}
	}

	private void KMCAJFADMDJ(int MGNOBNCMDJG)
	{
		((TMP_Text)amountText).text = MGNOBNCMDJG.ToString();
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	public TavernZone DEBAKMHHICA()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return TavernZonesManager.NHKAFANMEJC().MDPHAHIFJFB(LDLINOBIKPL.placeable.currentZoneIndex);
		}
		return null;
	}

	public void GLFOMIANEPA(Crafter LDLINOBIKPL)
	{
		this.LDLINOBIKPL = LDLINOBIKPL;
		PCOIPPHEBAG(LDLINOBIKPL);
		IPDHKOGBHKK(LDLINOBIKPL.FIIHBFCDFJH());
	}

	public Placeable OFLIGINIPEF()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return LDLINOBIKPL.placeable;
		}
		return null;
	}

	public Placeable MIPJEDHHBGA()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return LDLINOBIKPL.placeable;
		}
		return null;
	}

	public TavernZone GetCrafterZone()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return TavernZonesManager.GGFJGHHHEJC.GetTavernZone(LDLINOBIKPL.placeable.currentZoneIndex);
		}
		return null;
	}

	private IEnumerator HICPGLCNKOD()
	{
		return new IPDPCDOFDMP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FCKBBHKCHMJ(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (CraftingInventory.GJPIKCMIKJN(JIIGOACEIKL, ADEBNALPEHE.itemInstance, AKLCDEFOKMI(), CDPAMNIPPEC: false) != null)
		{
			LDLINOBIKPL.FBHONNNPJGD(LDLINOBIKPL.LCCABPFHCOL + ((Fuel)ADEBNALPEHE.itemInstance.KNFNJFFCFNO()).GPFEAIPDCNI(), CDPAMNIPPEC: true);
			ICEMKGNJIDE(LDLINOBIKPL.FIIHBFCDFJH());
			Sound.GGFJGHHHEJC.NFGPNLLFDCE(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.addFuel), HOMFPAFAOGD: false, null, null, 1397f);
		}
	}

	private void EIGPMOIAAKD(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.LJIFOHFEFCH(), false);
	}

	public TavernZone HJOCFANGDID()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return TavernZonesManager.LANAINBEMCM().GetTavernZone(LDLINOBIKPL.placeable.currentZoneIndex);
		}
		return null;
	}

	private IEnumerator KCOOBNGKEFM()
	{
		return new IPDPCDOFDMP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JIMAAJNCEIB(int MGNOBNCMDJG)
	{
		((TMP_Text)amountText).text = MGNOBNCMDJG.ToString();
	}

	private void FHINBKEMCPH(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		int num = 8;
		for (int i = 0; i < num; i++)
		{
			if (CraftingInventory.GJPIKCMIKJN(JIIGOACEIKL, ADEBNALPEHE.itemInstance, IIOPNKMLEOH()) != null)
			{
				LDLINOBIKPL.FBHONNNPJGD(LDLINOBIKPL.LCCABPFHCOL + ((Fuel)ADEBNALPEHE.itemInstance.AFOACBIHNCL()).GPFEAIPDCNI());
			}
		}
		KPCMFPFGJJK(LDLINOBIKPL.FIIHBFCDFJH());
	}

	public void JNOGDGGFCJB(Crafter LDLINOBIKPL)
	{
		this.LDLINOBIKPL = LDLINOBIKPL;
		EMIHEIDNONM(LDLINOBIKPL);
		LCLMEOBKIMA(LDLINOBIKPL.FIIHBFCDFJH());
	}

	public static FuelUI IOFMOGAPGID(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void NFMGKKGMCDF(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (CraftingInventory.CKHLHBJDEOH(JIIGOACEIKL, ADEBNALPEHE.itemInstance, HEIMJKMMNEO(), CDPAMNIPPEC: false) != null)
		{
			LDLINOBIKPL.PDACOPGDDKH(LDLINOBIKPL.FIIHBFCDFJH() + ((Fuel)ADEBNALPEHE.itemInstance.AFOACBIHNCL()).KECGIKOHKIM());
			ICEMKGNJIDE(LDLINOBIKPL.FIIHBFCDFJH());
			Sound.ABDJJBFNLBJ().PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().addFuel), HOMFPAFAOGD: true, null, null, 1468f);
		}
	}

	private void LIBEEILHPOE(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (CraftingInventory.NGJBGHJFJMM(JIIGOACEIKL, ADEBNALPEHE.itemInstance, IJGDLDJLKMM()) != null)
		{
			LDLINOBIKPL.PDACOPGDDKH(LDLINOBIKPL.FIIHBFCDFJH() + ((Fuel)ADEBNALPEHE.itemInstance.AFOACBIHNCL()).PCMNMAFMIBG());
			IPDHKOGBHKK(LDLINOBIKPL.FIIHBFCDFJH());
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().addFuel), HOMFPAFAOGD: false, null, null, 1017f);
		}
	}

	protected override void Start()
	{
		base.Start();
		if (!JANOEGJFNCG)
		{
			JANOEGJFNCG = true;
			FuelElementUI[] array = fuelSlotUIs;
			foreach (FuelElementUI obj in array)
			{
				obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(KFCLFBNIAEO));
				obj.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotRightClick, new Action<int, Slot>(OKGIFNMALJD));
			}
			if ((Object)(object)firewoodSlot != (Object)null)
			{
				FuelElementUI fuelElementUI = firewoodSlot;
				fuelElementUI.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(fuelElementUI.OnSlotLeftClick, new Action<int, Slot>(KFCLFBNIAEO));
				FuelElementUI fuelElementUI2 = firewoodSlot;
				fuelElementUI2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(fuelElementUI2.OnSlotRightClick, new Action<int, Slot>(OKGIFNMALJD));
			}
		}
	}

	private IEnumerator HEOICBPFINA()
	{
		yield return null;
		HPDMJOJMIBH = null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)fuelSlotUIs[0]).gameObject);
		}
	}

	private void IILBOMNENLJ(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.IABAKHPEOAF(), true);
	}

	public void APJEKABAKPJ()
	{
		if (LDLINOBIKPL.CanOpenCraftingUI())
		{
			LDLINOBIKPL.OpenCrafterUI(base.JIIGOACEIKL);
		}
	}

	private IEnumerator AEDOIANNCEF()
	{
		yield return null;
		HPDMJOJMIBH = null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)fuelSlotUIs[0]).gameObject);
		}
	}

	public static FuelUI OHPNDOJNCBK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FuelUI FHOGLBPBGMI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public TavernZone BGACACKHKNL()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return TavernZonesManager.NHKAFANMEJC().MDPHAHIFJFB(LDLINOBIKPL.placeable.currentZoneIndex);
		}
		return null;
	}

	private void OFLJEIDDGDD(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (CraftingInventory.GJPIKCMIKJN(JIIGOACEIKL, ADEBNALPEHE.itemInstance, GAKAFIDHKII()) != null)
		{
			LDLINOBIKPL.FBHONNNPJGD(LDLINOBIKPL.FIIHBFCDFJH() + ((Fuel)ADEBNALPEHE.itemInstance.AFOACBIHNCL()).NFNOKAGGGGM(), CDPAMNIPPEC: true);
			KPCMFPFGJJK(LDLINOBIKPL.LCCABPFHCOL);
			Sound.MAIDHAPANEB().MFBBFAINMHG(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().addFuel), HOMFPAFAOGD: true, null, null, 1257f);
		}
	}

	public void GLHGCILOJJD(Crafter LDLINOBIKPL)
	{
		this.LDLINOBIKPL = LDLINOBIKPL;
		EMIHEIDNONM(LDLINOBIKPL);
		HFPBJAEAIHB(LDLINOBIKPL.LCCABPFHCOL);
	}

	public static FuelUI HDMPJKMLFML(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void DMHMJOGPJAF(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.KGHFCDELKMN(), true);
	}

	public override void CloseUI()
	{
		if (LKOJBFMGMAE)
		{
			MainUI.ResumeGame();
			base.CloseUI();
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
			if (HPDMJOJMIBH != null)
			{
				((MonoBehaviour)this).StopCoroutine(HPDMJOJMIBH);
			}
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CGBEIKHPCHL));
			if (Object.op_Implicit((Object)(object)LDLINOBIKPL) && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRemoveFromInteracting(LDLINOBIKPL.placeable.onlinePlaceable);
			}
			LDLINOBIKPL = null;
			FocusArrowUI.Get(base.JIIGOACEIKL).SetVisible(NKFPJPCFBJI: false);
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	private void LFOFHKAMFBK(int MGNOBNCMDJG)
	{
		((TMP_Text)amountText).text = MGNOBNCMDJG.ToString();
	}

	public TavernZone KAHAPEJDHPC()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return TavernZonesManager.HFHPMKJGMPA().DJNICAOHKNA(LDLINOBIKPL.placeable.currentZoneIndex);
		}
		return null;
	}

	public static FuelUI COIEMAJLHAM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void FHHACKFGKNC(Crafter LDLINOBIKPL)
	{
		this.LDLINOBIKPL = LDLINOBIKPL;
		IILBOMNENLJ(LDLINOBIKPL);
		MOFBBLPAPLH(LDLINOBIKPL.FIIHBFCDFJH());
	}

	private void MGAOLGLFOHM(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (CraftingInventory.RemoveItemInstance(JIIGOACEIKL, ADEBNALPEHE.itemInstance, MIPJEDHHBGA(), CDPAMNIPPEC: false) != null)
		{
			LDLINOBIKPL.PDACOPGDDKH(LDLINOBIKPL.LCCABPFHCOL + ((Fuel)ADEBNALPEHE.itemInstance.LHBPOPOIFLE()).HIEPDDDFCHO(), CDPAMNIPPEC: true);
			IPDHKOGBHKK(LDLINOBIKPL.FIIHBFCDFJH());
			Sound.OKAPNFPFPFP().LNCINHJELIG(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().addFuel), HOMFPAFAOGD: true, null, null, 1737f);
		}
	}

	private void EKPPDDKFCIJ(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (CraftingInventory.NGJBGHJFJMM(JIIGOACEIKL, ADEBNALPEHE.itemInstance, LGDAICBJJNI()) != null)
		{
			LDLINOBIKPL.GMGBDCIFKKD(LDLINOBIKPL.FIIHBFCDFJH() + ((Fuel)ADEBNALPEHE.itemInstance.LHBPOPOIFLE()).MBDDLNMNNEL());
			ICHNHJEOFOJ(LDLINOBIKPL.LCCABPFHCOL);
			Sound.BNBMNOMFFBE().PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().addFuel), HOMFPAFAOGD: true, null, null, 977f);
		}
	}

	private void BKKEJFPHCKG(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.LJIFOHFEFCH(), true);
	}

	protected override void Update()
	{
		if (updateNextFrame)
		{
			updateNextFrame = false;
			return;
		}
		base.Update();
		if (!LKOJBFMGMAE || !((Object)(object)LDLINOBIKPL != (Object)null))
		{
			return;
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp("UIAddRemove"))
			{
				OpenCrafter();
			}
		}
		else if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp("Use"))
		{
			OpenCrafter();
		}
	}

	public void DPGAPLHAOAL()
	{
		if (LDLINOBIKPL.CanOpenCraftingUI())
		{
			LDLINOBIKPL.OpenCrafterUI(base.JIIGOACEIKL);
		}
	}

	private void ICHNHJEOFOJ(int MGNOBNCMDJG)
	{
		((TMP_Text)amountText).text = MGNOBNCMDJG.ToString();
	}

	public FuelElementUI GetLogFuelSlot()
	{
		return firewoodSlot;
	}

	private void BDPLFPGODGD(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		int num = 4;
		for (int i = 1; i < num; i++)
		{
			if (CraftingInventory.GJPIKCMIKJN(JIIGOACEIKL, ADEBNALPEHE.itemInstance, GetCrafterPlaceableZone(), CDPAMNIPPEC: false) != null)
			{
				LDLINOBIKPL.GMGBDCIFKKD(LDLINOBIKPL.LCCABPFHCOL + ((Fuel)ADEBNALPEHE.itemInstance.LHBPOPOIFLE()).KBOFGNCMJKO(), CDPAMNIPPEC: true);
			}
		}
		LFOFHKAMFBK(LDLINOBIKPL.FIIHBFCDFJH());
	}

	private IEnumerator MDJKMEJNJDF()
	{
		yield return null;
		HPDMJOJMIBH = null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)fuelSlotUIs[0]).gameObject);
		}
	}

	private IEnumerator DPODCFBJHFI()
	{
		yield return null;
		HPDMJOJMIBH = null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)fuelSlotUIs[0]).gameObject);
		}
	}

	public override void OpenUI()
	{
		if (LKOJBFMGMAE)
		{
			return;
		}
		if (NewTutorialManager.CrafterBlocked(base.JIIGOACEIKL, LDLINOBIKPL))
		{
			DeassignOpenedWindow(base.JIIGOACEIKL);
			return;
		}
		base.OpenUI();
		PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CGBEIKHPCHL));
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
		for (int i = 0; i < fuelSlotUIs.Length; i++)
		{
			fuelSlotUIs[i].UpdateElement();
		}
		if (Object.op_Implicit((Object)(object)LDLINOBIKPL) && OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendAddToInteracting(LDLINOBIKPL.placeable.onlinePlaceable);
		}
	}

	public TavernZone IOBKEODECBD()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return TavernZonesManager.NHKAFANMEJC().DJNICAOHKNA(LDLINOBIKPL.placeable.currentZoneIndex);
		}
		return null;
	}

	public void NABBBFPCELC()
	{
		if (LDLINOBIKPL.CanOpenCraftingUI())
		{
			LDLINOBIKPL.OpenCrafterUI(base.JIIGOACEIKL);
		}
	}

	private void OIPCCDPOMIG(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		int num = 8;
		for (int i = 1; i < num; i++)
		{
			if (CraftingInventory.NGJBGHJFJMM(JIIGOACEIKL, ADEBNALPEHE.itemInstance, IJGDLDJLKMM()) != null)
			{
				LDLINOBIKPL.PDACOPGDDKH(LDLINOBIKPL.FIIHBFCDFJH() + ((Fuel)ADEBNALPEHE.itemInstance.KNFNJFFCFNO()).ODKOFGLCHHI());
			}
		}
		LCLMEOBKIMA(LDLINOBIKPL.LCCABPFHCOL);
	}

	public void JNGKEJJHBMF(Crafter LDLINOBIKPL)
	{
		this.LDLINOBIKPL = LDLINOBIKPL;
		DMHMJOGPJAF(LDLINOBIKPL);
		KMCAJFADMDJ(LDLINOBIKPL.LCCABPFHCOL);
	}

	public TavernZone BPBKOLLOHPL()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return TavernZonesManager.LANAINBEMCM().PDINJGNEMGA(LDLINOBIKPL.placeable.currentZoneIndex);
		}
		return null;
	}

	private void KPCMFPFGJJK(int MGNOBNCMDJG)
	{
		((TMP_Text)amountText).text = MGNOBNCMDJG.ToString();
	}

	public FuelElementUI IKCBAKCHMMO()
	{
		return firewoodSlot;
	}

	private void FGINMCOIJIE(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.IABAKHPEOAF(OAFPBCPDOKH: true), true);
	}

	private void MIOKELBBIEA(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.IABAKHPEOAF(), false);
	}

	public Placeable MBAEOPCPJLH()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return LDLINOBIKPL.placeable;
		}
		return null;
	}

	public Placeable NNLBHCEMGLB()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return LDLINOBIKPL.placeable;
		}
		return null;
	}

	private void ILOKCEDEGDE()
	{
		BOBCIFEDJED();
	}

	public void FAMPNCCAEIA()
	{
		if (LDLINOBIKPL.GMEPPCIINCD())
		{
			LDLINOBIKPL.OpenCrafterUI(base.JIIGOACEIKL);
		}
	}

	private void ENHFHEFNBOA(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.LJIFOHFEFCH(), true);
	}

	public static FuelUI IPDFCJLOHLC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator AIFMBOJECGG()
	{
		yield return null;
		HPDMJOJMIBH = null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)fuelSlotUIs[0]).gameObject);
		}
	}

	private void HFPBJAEAIHB(int MGNOBNCMDJG)
	{
		((TMP_Text)amountText).text = MGNOBNCMDJG.ToString();
	}

	public void LFELFOEEHPC()
	{
		if (LDLINOBIKPL.GMEPPCIINCD())
		{
			LDLINOBIKPL.OpenCrafterUI(base.JIIGOACEIKL);
		}
	}

	private void DCMNDGLLAGC(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		int num = 4;
		for (int i = 1; i < num; i++)
		{
			if (CraftingInventory.GJPIKCMIKJN(JIIGOACEIKL, ADEBNALPEHE.itemInstance, CMDBPIBIIJD(), CDPAMNIPPEC: false) != null)
			{
				LDLINOBIKPL.SetFuel(LDLINOBIKPL.FIIHBFCDFJH() + ((Fuel)ADEBNALPEHE.itemInstance.PHGLMBIEOMK()).JPMCFOICALI(), CDPAMNIPPEC: true);
			}
		}
		LFOFHKAMFBK(LDLINOBIKPL.FIIHBFCDFJH());
	}

	public void OpenCrafter()
	{
		if (LDLINOBIKPL.CanOpenCraftingUI())
		{
			LDLINOBIKPL.OpenCrafterUI(base.JIIGOACEIKL);
		}
	}

	public Placeable NNGIAONJGJL()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return LDLINOBIKPL.placeable;
		}
		return null;
	}

	public void OJNAMGCIDHG(Crafter LDLINOBIKPL)
	{
		this.LDLINOBIKPL = LDLINOBIKPL;
		PCOIPPHEBAG(LDLINOBIKPL);
		LFOFHKAMFBK(LDLINOBIKPL.LCCABPFHCOL);
	}

	private void OLIHBCHMKAB(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.IABAKHPEOAF(), false);
	}

	private void DNMBDJKELNI(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (CraftingInventory.CKHLHBJDEOH(JIIGOACEIKL, ADEBNALPEHE.itemInstance, CDLILGOJMPE()) != null)
		{
			LDLINOBIKPL.PDACOPGDDKH(LDLINOBIKPL.LCCABPFHCOL + ((Fuel)ADEBNALPEHE.itemInstance.AFOACBIHNCL()).KECGIKOHKIM(), CDPAMNIPPEC: true);
			JIMAAJNCEIB(LDLINOBIKPL.LCCABPFHCOL);
			Sound.BNBMNOMFFBE().BOFJJFJIBHB(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().addFuel), HOMFPAFAOGD: true, null, null, 1133f);
		}
	}

	private void GMIOJPKOFEK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (CraftingInventory.CKHLHBJDEOH(JIIGOACEIKL, ADEBNALPEHE.itemInstance, CDFGGPKNDNJ()) != null)
		{
			LDLINOBIKPL.SetFuel(LDLINOBIKPL.LCCABPFHCOL + ((Fuel)ADEBNALPEHE.itemInstance.PHGLMBIEOMK()).NJCHDFEEBEC(), CDPAMNIPPEC: true);
			KMCAJFADMDJ(LDLINOBIKPL.FIIHBFCDFJH());
			Sound.BNBMNOMFFBE().GAIDPALIDFG(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().addFuel), HOMFPAFAOGD: true, null, null, 1572f);
		}
	}

	private void ICEMKGNJIDE(int MGNOBNCMDJG)
	{
		((TMP_Text)amountText).text = MGNOBNCMDJG.ToString();
	}

	public TavernZone KDBJOFHPDPD()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return TavernZonesManager.EBAIHKJHCCA().GetTavernZone(LDLINOBIKPL.placeable.currentZoneIndex);
		}
		return null;
	}

	public void BKIDGCKKABK(Crafter LDLINOBIKPL)
	{
		this.LDLINOBIKPL = LDLINOBIKPL;
		AGIOECAGKFO(LDLINOBIKPL);
		HFPBJAEAIHB(LDLINOBIKPL.FIIHBFCDFJH());
	}

	private void KNCLPGBOOPO(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.IABAKHPEOAF(OAFPBCPDOKH: true), true);
	}

	private void KFCLFBNIAEO(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (CraftingInventory.RemoveItemInstance(JIIGOACEIKL, ADEBNALPEHE.itemInstance, GetCrafterPlaceableZone()) != null)
		{
			LDLINOBIKPL.SetFuel(LDLINOBIKPL.LCCABPFHCOL + ((Fuel)ADEBNALPEHE.itemInstance.LHBPOPOIFLE()).GPFEAIPDCNI(), CDPAMNIPPEC: true);
			KMCAJFADMDJ(LDLINOBIKPL.LCCABPFHCOL);
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.addFuel), HOMFPAFAOGD: true);
		}
	}

	public TavernZone KFMOPDLBMNL()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return TavernZonesManager.OIJLJKLMCBO().PDINJGNEMGA(LDLINOBIKPL.placeable.currentZoneIndex);
		}
		return null;
	}

	private void AMDGFEPOGFE(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.KGHFCDELKMN(), false);
	}

	private void GECEDCJFJEC(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		int num = 1;
		for (int i = 1; i < num; i++)
		{
			if (CraftingInventory.NGJBGHJFJMM(JIIGOACEIKL, ADEBNALPEHE.itemInstance, ECONGAOHINM()) != null)
			{
				LDLINOBIKPL.FBHONNNPJGD(LDLINOBIKPL.LCCABPFHCOL + ((Fuel)ADEBNALPEHE.itemInstance.KNFNJFFCFNO()).JPMCFOICALI(), CDPAMNIPPEC: true);
			}
		}
		JIMAAJNCEIB(LDLINOBIKPL.FIIHBFCDFJH());
	}

	private void DHEHDDIDJAG(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.LJIFOHFEFCH(OAFPBCPDOKH: true), false);
	}

	private void PFGBBMGCMIG(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.LJIFOHFEFCH(OAFPBCPDOKH: true), false);
	}

	private void IBKNHGJJPGO(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.KGHFCDELKMN(OAFPBCPDOKH: true), true);
	}

	private void EBAGJMLPGJG(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.IABAKHPEOAF(OAFPBCPDOKH: true), false);
	}

	public void FGDEHFJIIFI(Crafter LDLINOBIKPL)
	{
		this.LDLINOBIKPL = LDLINOBIKPL;
		MIOKELBBIEA(LDLINOBIKPL);
		JIMAAJNCEIB(LDLINOBIKPL.LCCABPFHCOL);
	}

	public Placeable GAKAFIDHKII()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return LDLINOBIKPL.placeable;
		}
		return null;
	}

	public static FuelUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void INFAGICKOHO(int MGNOBNCMDJG)
	{
		((TMP_Text)amountText).text = MGNOBNCMDJG.ToString();
	}

	public Placeable IJGDLDJLKMM()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return LDLINOBIKPL.placeable;
		}
		return null;
	}

	private void FIGHMPBNAOM(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (CraftingInventory.GJPIKCMIKJN(JIIGOACEIKL, ADEBNALPEHE.itemInstance, ECONGAOHINM(), CDPAMNIPPEC: false) != null)
		{
			LDLINOBIKPL.GMGBDCIFKKD(LDLINOBIKPL.FIIHBFCDFJH() + ((Fuel)ADEBNALPEHE.itemInstance.AFOACBIHNCL()).BJMDFGNDMNH(), CDPAMNIPPEC: true);
			LCLMEOBKIMA(LDLINOBIKPL.LCCABPFHCOL);
			Sound.OKAPNFPFPFP().GAIDPALIDFG(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.addFuel), HOMFPAFAOGD: false, null, null, 1456f);
		}
	}

	public static FuelUI EAONFFENMCE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void IOKDAODOAAF()
	{
		CloseUI();
	}

	public Placeable LGDAICBJJNI()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return LDLINOBIKPL.placeable;
		}
		return null;
	}

	public static FuelUI BPBMLNJGGII(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void DNMAHEEHHJE()
	{
		BOBCIFEDJED();
	}

	private IEnumerator FDKGMKKODIM()
	{
		yield return null;
		HPDMJOJMIBH = null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)fuelSlotUIs[0]).gameObject);
		}
	}

	public Placeable IIOPNKMLEOH()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return LDLINOBIKPL.placeable;
		}
		return null;
	}

	private IEnumerator ENKLJOFLAOH()
	{
		return new IPDPCDOFDMP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void OJHBBNJPMNP()
	{
		if (LDLINOBIKPL.GMEPPCIINCD())
		{
			LDLINOBIKPL.OpenCrafterUI(base.JIIGOACEIKL);
		}
	}

	private void GFCKBDFMPGM()
	{
		BOBCIFEDJED();
	}

	public Placeable GetCrafterPlaceableZone()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return LDLINOBIKPL.placeable;
		}
		return null;
	}

	public Placeable AKLCDEFOKMI()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return LDLINOBIKPL.placeable;
		}
		return null;
	}

	public Placeable CIHODADDHFB()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return LDLINOBIKPL.placeable;
		}
		return null;
	}

	private void PENKOLIJKFF(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.LJIFOHFEFCH(), false);
	}

	private void JGOMFDNKAIJ()
	{
		CloseUI();
	}

	private void GHMHOHFANDH(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.KGHFCDELKMN(), false);
	}

	public void SetCrafter(Crafter LDLINOBIKPL)
	{
		this.LDLINOBIKPL = LDLINOBIKPL;
		FGINMCOIJIE(LDLINOBIKPL);
		KMCAJFADMDJ(LDLINOBIKPL.LCCABPFHCOL);
	}

	public void FHOFDBKKMKJ(Crafter LDLINOBIKPL)
	{
		this.LDLINOBIKPL = LDLINOBIKPL;
		PFGBBMGCMIG(LDLINOBIKPL);
		HFPBJAEAIHB(LDLINOBIKPL.FIIHBFCDFJH());
	}

	private void IPDHKOGBHKK(int MGNOBNCMDJG)
	{
		((TMP_Text)amountText).text = MGNOBNCMDJG.ToString();
	}

	private void JEKECGLCIHJ()
	{
		CloseUI();
	}

	public FuelElementUI ODFAHIPOIBM()
	{
		return firewoodSlot;
	}

	public static FuelUI FHBIFJNCOAI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void MOFBBLPAPLH(int MGNOBNCMDJG)
	{
		((TMP_Text)amountText).text = MGNOBNCMDJG.ToString();
	}

	public FuelElementUI NLDJPGNHBGO()
	{
		return firewoodSlot;
	}

	private void BFEKCOCNHFL(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		int num = 4;
		for (int i = 0; i < num; i++)
		{
			if (CraftingInventory.CKHLHBJDEOH(JIIGOACEIKL, ADEBNALPEHE.itemInstance, CDLILGOJMPE()) != null)
			{
				LDLINOBIKPL.PDACOPGDDKH(LDLINOBIKPL.LCCABPFHCOL + ((Fuel)ADEBNALPEHE.itemInstance.KNFNJFFCFNO()).OECDJJMJLFF(), CDPAMNIPPEC: true);
			}
		}
		HFPBJAEAIHB(LDLINOBIKPL.FIIHBFCDFJH());
	}

	public Placeable HEIMJKMMNEO()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return LDLINOBIKPL.placeable;
		}
		return null;
	}

	public TavernZone IEMLFIFAHKC()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return TavernZonesManager.EBAIHKJHCCA().GetTavernZone(LDLINOBIKPL.placeable.currentZoneIndex);
		}
		return null;
	}

	public TavernZone DMEGKMBBEMD()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return TavernZonesManager.OIJLJKLMCBO().DJNICAOHKNA(LDLINOBIKPL.placeable.currentZoneIndex);
		}
		return null;
	}

	private void LCLMEOBKIMA(int MGNOBNCMDJG)
	{
		((TMP_Text)amountText).text = MGNOBNCMDJG.ToString();
	}

	private void NPBDAEIDCAP(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.LJIFOHFEFCH(OAFPBCPDOKH: true), false);
	}

	private void BIJJBGJMHEK()
	{
		BOBCIFEDJED();
	}

	public Placeable CDFGGPKNDNJ()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			return LDLINOBIKPL.placeable;
		}
		return null;
	}
}
