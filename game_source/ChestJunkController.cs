using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class ChestJunkController : MonoBehaviour, IInteractable, IProximity, IHoverable
{
	[CompilerGenerated]
	private sealed class OLKDPIBEOOM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChestJunkController _003C_003E4__this;

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
		public OLKDPIBEOOM(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Expected O, but got Unknown
			int num = _003C_003E1__state;
			ChestJunkController chestJunkController = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				chestJunkController.OIMLDANHLPO = 0;
				List<Slot> list = new List<Slot>();
				for (int i = 0; i < chestJunkController.EHFJNOHOAOL.Length; i++)
				{
					int num2 = PlayerInventory.GetPlayer(playerNum).NumberOfItems(ItemDatabaseAccessor.GetItem(chestJunkController.EHFJNOHOAOL[i]));
					chestJunkController.OIMLDANHLPO += num2;
					for (int j = 0; j < num2; j++)
					{
						Slot slot = PlayerInventory.GetPlayer(playerNum).RemoveItem(ItemDatabaseAccessor.GetItem(chestJunkController.EHFJNOHOAOL[i]), CDPAMNIPPEC: false);
						if (slot != null && !list.Contains(slot))
						{
							list.Add(slot);
						}
					}
				}
				if (OnlineManager.PlayingOnline() && list.Count > 0)
				{
					OnlineSlotsManager.instance.SendSlots(list.ToArray());
				}
				if (chestJunkController.OIMLDANHLPO > 0)
				{
					MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.chestJunk, ((Component)chestJunkController).gameObject.transform);
					_003C_003E2__current = (object)new WaitForSeconds(1.6f);
					_003C_003E1__state = 1;
					return true;
				}
				break;
			}
			case 1:
				_003C_003E1__state = -1;
				PlayerInventory.GetPlayer(playerNum).AddItems(ItemDatabaseAccessor.GetItem(1500).JMDALJBNFML(), chestJunkController.OIMLDANHLPO, HMPDLIPFBGD: true);
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(playerNum)).transform);
				break;
			}
			chestJunkController.BEGCPKOAJCP = null;
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

	public GameObject bark;

	private int[] EHFJNOHOAOL = new int[4] { 3462, 3463, 3464, 3465 };

	private int OIMLDANHLPO;

	private Coroutine BEGCPKOAJCP;

	public bool ALHICNPINHB(int JIIGOACEIKL)
	{
		return DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool ELFMBJDBHBD(int JIIGOACEIKL)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (BKPEBOBAIJI(JIIGOACEIKL) && BEGCPKOAJCP == null)
		{
			Result variable = DialogueLua.GetVariable("Top");
			if (((Result)(ref variable)).asInt >= 4)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(HJBDOOJDHFA(JIIGOACEIKL));
				return true;
			}
		}
		return false;
	}

	private IEnumerator NODEFNIDGEE(int JIIGOACEIKL)
	{
		return new OLKDPIBEOOM(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private void GNGADDPBJDC()
	{
	}

	public bool POLADKOEIOM(int JIIGOACEIKL)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (BKPEBOBAIJI(JIIGOACEIKL) && BEGCPKOAJCP == null)
		{
			Result variable = DialogueLua.GetVariable("RochelleProgress");
			if (((Result)(ref variable)).asInt >= 8)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(JNOMNHNIFEF(JIIGOACEIKL));
				return true;
			}
		}
		return false;
	}

	public bool EIKPGOMHKOH(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool NNNKIBGDAJP(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public virtual bool INHDHCOFLJI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (NOJJKKFGJEJ(JIIGOACEIKL))
		{
			Result variable = DialogueLua.GetVariable("ReceiveNextGameDate");
			if (((Result)(ref variable)).asInt >= 6)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Items/item_description_1033"));
				return false;
			}
		}
		return false;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public virtual bool DAGCKCKKKCJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (HOCCIDFOPHN(JIIGOACEIKL))
		{
			Result variable = DialogueLua.GetVariable("Christmas/Ace/Intro");
			if (((Result)(ref variable)).asInt >= 1)
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("P1Cam"));
				return true;
			}
		}
		return false;
	}

	private IEnumerator OFPGJEDNFPH(int JIIGOACEIKL)
	{
		return new OLKDPIBEOOM(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public bool FPMFDKMLCML(int JIIGOACEIKL)
	{
		return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).IDPGEBNGDJD();
	}

	private void LANGHIOBJIH()
	{
	}

	public bool CLFKOPEMJGH(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void NELBHAMPBPL()
	{
	}

	public bool IDMKOACGEHF(int JIIGOACEIKL)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (EIKPGOMHKOH(JIIGOACEIKL) && BEGCPKOAJCP == null)
		{
			Result variable = DialogueLua.GetVariable("City/Carpenters/Ash/Stand");
			if (((Result)(ref variable)).asInt >= 3)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(HNKONPNPECO(JIIGOACEIKL));
				return true;
			}
		}
		return false;
	}

	private void MFMMHDPGCBO()
	{
	}

	public bool JENFOIFJOPF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void Update()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_11");
		if (((Result)(ref variable)).asInt >= 2 && !bark.activeSelf)
		{
			bark.SetActive(true);
		}
	}

	public void AOFPMOPONPH(int JIIGOACEIKL)
	{
	}

	private void GOJFGHKOFMF()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/NeutralInTavern/Entry/16/Dialogue Text");
		if (((Result)(ref variable)).asInt >= 5 && !bark.activeSelf)
		{
			bark.SetActive(false);
		}
	}

	public void LHNEACOGPFP(int JIIGOACEIKL)
	{
	}

	private void ELHCBGCEJDH()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("BrookProgress");
		if (((Result)(ref variable)).asInt >= 8 && !bark.activeSelf)
		{
			bark.SetActive(true);
		}
	}

	public virtual bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			Result variable = DialogueLua.GetVariable("LE_11");
			if (((Result)(ref variable)).asInt >= 2)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Use"));
				return true;
			}
		}
		return false;
	}

	public bool FCLFHOFIJAK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool DHGKDOGEJPF(int JIIGOACEIKL)
	{
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public bool BHMMBNIFKHD(int JIIGOACEIKL)
	{
		return DecorationMode.FIHGMLABOBB(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public void MJNNGIAAGFH(int JIIGOACEIKL)
	{
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void IHIIIPGGPPF(int JIIGOACEIKL)
	{
	}

	private IEnumerator AAMPKIIANHB(int JIIGOACEIKL)
	{
		return new OLKDPIBEOOM(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public bool BKPEBOBAIJI(int JIIGOACEIKL)
	{
		return DecorationMode.BGINAIDHDOM(JIIGOACEIKL).GABNNLJOMHI();
	}

	public void HLNEGJCBPOA(int JIIGOACEIKL)
	{
	}

	public bool DFHNFGMFGLH(int JIIGOACEIKL)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (BKPEBOBAIJI(JIIGOACEIKL) && BEGCPKOAJCP == null)
		{
			Result variable = DialogueLua.GetVariable("Cannot place mine block piece at ");
			if (((Result)(ref variable)).asInt >= 3)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(NODEFNIDGEE(JIIGOACEIKL));
				return true;
			}
		}
		return true;
	}

	public bool FBODGFKDBCD(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool HINGCLJLHJF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private IEnumerator JNOMNHNIFEF(int JIIGOACEIKL)
	{
		return new OLKDPIBEOOM(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public bool NOJJKKFGJEJ(int JIIGOACEIKL)
	{
		return DecorationMode.NPANPNIDKDG(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public void MOBFEFJFGBE(int JIIGOACEIKL)
	{
	}

	public virtual bool DLEDGMKGACB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (BKPEBOBAIJI(JIIGOACEIKL))
		{
			Result variable = DialogueLua.GetVariable("Path Found");
			if (((Result)(ref variable)).asInt >= 2)
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("MineFloor"));
				return false;
			}
		}
		return true;
	}

	private void AAOMCHHNKKM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("before pos ");
		if (((Result)(ref variable)).asInt >= 1 && !bark.activeSelf)
		{
			bark.SetActive(true);
		}
	}

	public bool LCDFJODPNGJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void NLLBFJIFBLP(int JIIGOACEIKL)
	{
	}

	public bool FAJKNOLOCBC(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool PHGADHENHDF(int JIIGOACEIKL)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (BKPEBOBAIJI(JIIGOACEIKL) && BEGCPKOAJCP == null)
		{
			Result variable = DialogueLua.GetVariable("talent_name_105");
			if (((Result)(ref variable)).asInt >= 2)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(NODEFNIDGEE(JIIGOACEIKL));
				return true;
			}
		}
		return false;
	}

	public bool HAPLPIMJGGN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool PEBMANKLJNN(int JIIGOACEIKL)
	{
		return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (IsAvailableByProximity(JIIGOACEIKL) && BEGCPKOAJCP == null)
		{
			Result variable = DialogueLua.GetVariable("LE_11");
			if (((Result)(ref variable)).asInt >= 2)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(HNKONPNPECO(JIIGOACEIKL));
				return true;
			}
		}
		return true;
	}

	public bool EBIDPMLPLIA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void NOAIKDADPBD(int JIIGOACEIKL)
	{
	}

	private void Start()
	{
	}

	public bool BEHJINBIFDO(int JIIGOACEIKL)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (BHMMBNIFKHD(JIIGOACEIKL) && BEGCPKOAJCP == null)
		{
			Result variable = DialogueLua.GetVariable("Falta el tile de entrada/salida con salida hacia '{0}'. La database necesita uno por cada dirección cardinal.");
			if (((Result)(ref variable)).asInt >= 5)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(NODEFNIDGEE(JIIGOACEIKL));
				return true;
			}
		}
		return false;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	private void CHIJGHPHCNA()
	{
	}

	public virtual bool OPEOJMLFPMK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (EIKPGOMHKOH(JIIGOACEIKL))
		{
			Result variable = DialogueLua.GetVariable("Unaged Parmesan");
			if (((Result)(ref variable)).asInt >= 4)
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Disabled"));
				return true;
			}
		}
		return true;
	}

	public void LFDBCGGIPOM(int JIIGOACEIKL)
	{
	}

	public bool JJANBHCGKOJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void NPPALHNMMEN(int JIIGOACEIKL)
	{
	}

	private IEnumerator APGBAPMAAHF(int JIIGOACEIKL)
	{
		OIMLDANHLPO = 0;
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < EHFJNOHOAOL.Length; i++)
		{
			int num = PlayerInventory.GetPlayer(JIIGOACEIKL).NumberOfItems(ItemDatabaseAccessor.GetItem(EHFJNOHOAOL[i]));
			OIMLDANHLPO += num;
			for (int j = 0; j < num; j++)
			{
				Slot slot = PlayerInventory.GetPlayer(JIIGOACEIKL).RemoveItem(ItemDatabaseAccessor.GetItem(EHFJNOHOAOL[i]), CDPAMNIPPEC: false);
				if (slot != null && !list.Contains(slot))
				{
					list.Add(slot);
				}
			}
		}
		if (OnlineManager.PlayingOnline() && list.Count > 0)
		{
			OnlineSlotsManager.instance.SendSlots(list.ToArray());
		}
		if (OIMLDANHLPO > 0)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.chestJunk, ((Component)this).gameObject.transform);
			yield return (object)new WaitForSeconds(1.6f);
			PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(ItemDatabaseAccessor.GetItem(1500).JMDALJBNFML(), OIMLDANHLPO, HMPDLIPFBGD: true);
			yield return CommonReferences.wait02;
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		}
		BEGCPKOAJCP = null;
	}

	public bool FCLHFAJMLBO(int JIIGOACEIKL)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (PEBMANKLJNN(JIIGOACEIKL) && BEGCPKOAJCP == null)
		{
			Result variable = DialogueLua.GetVariable("BrookProgress");
			if (((Result)(ref variable)).asInt >= 7)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(JNOMNHNIFEF(JIIGOACEIKL));
				return false;
			}
		}
		return true;
	}

	private IEnumerator HNKONPNPECO(int JIIGOACEIKL)
	{
		OIMLDANHLPO = 0;
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < EHFJNOHOAOL.Length; i++)
		{
			int num = PlayerInventory.GetPlayer(JIIGOACEIKL).NumberOfItems(ItemDatabaseAccessor.GetItem(EHFJNOHOAOL[i]));
			OIMLDANHLPO += num;
			for (int j = 0; j < num; j++)
			{
				Slot slot = PlayerInventory.GetPlayer(JIIGOACEIKL).RemoveItem(ItemDatabaseAccessor.GetItem(EHFJNOHOAOL[i]), CDPAMNIPPEC: false);
				if (slot != null && !list.Contains(slot))
				{
					list.Add(slot);
				}
			}
		}
		if (OnlineManager.PlayingOnline() && list.Count > 0)
		{
			OnlineSlotsManager.instance.SendSlots(list.ToArray());
		}
		if (OIMLDANHLPO > 0)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.chestJunk, ((Component)this).gameObject.transform);
			yield return (object)new WaitForSeconds(1.6f);
			PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(ItemDatabaseAccessor.GetItem(1500).JMDALJBNFML(), OIMLDANHLPO, HMPDLIPFBGD: true);
			yield return CommonReferences.wait02;
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		}
		BEGCPKOAJCP = null;
	}

	public void MMDJIDCALJB(int JIIGOACEIKL)
	{
	}

	private void MFIBFFDBNGI()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("position");
		if (((Result)(ref variable)).asInt >= 5 && !bark.activeSelf)
		{
			bark.SetActive(false);
		}
	}

	public bool LOCIBONDBGF(int JIIGOACEIKL)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (DHGKDOGEJPF(JIIGOACEIKL) && BEGCPKOAJCP == null)
		{
			Result variable = DialogueLua.GetVariable(", ");
			if (((Result)(ref variable)).asInt >= 1)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(OFPGJEDNFPH(JIIGOACEIKL));
				return true;
			}
		}
		return false;
	}

	private void OHGABHEDILE()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("\n\n");
		if (((Result)(ref variable)).asInt >= 2 && !bark.activeSelf)
		{
			bark.SetActive(true);
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	private void HIPNEFOEJPL()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Error_SmallRoom");
		if (((Result)(ref variable)).asInt >= 4 && !bark.activeSelf)
		{
			bark.SetActive(true);
		}
	}

	private IEnumerator HJBDOOJDHFA(int JIIGOACEIKL)
	{
		return new OLKDPIBEOOM(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public bool HOCCIDFOPHN(int JIIGOACEIKL)
	{
		return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).IBEFDKHFBFM();
	}
}
