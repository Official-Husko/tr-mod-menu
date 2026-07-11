using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class SignController : MonoBehaviour, IInteractable, IProximity, IHoverable
{
	public enum Direction
	{
		North,
		South,
		East,
		West,
		Northeast,
		Northwest,
		Southeast,
		Southwest
	}

	[Serializable]
	public class DirectionConfiguration
	{
		public Location location;

		public Direction direction;
	}

	[CompilerGenerated]
	private sealed class IHDFGPFODHA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SignController _003C_003E4__this;

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
		public IHDFGPFODHA(int _003C_003E1__state)
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
			SignController signController = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				signController.anim.SetTrigger("Hide");
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				signController.bubble.SetActive(false);
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

	public TextMeshProUGUI directionText;

	public GameObject bubble;

	public Animator anim;

	public DirectionConfiguration[] directions;

	private float LGLDPMAABLA = 5f;

	private Coroutine BEGCPKOAJCP;

	public void MKLIAMJFHOF()
	{
		if (bubble.activeSelf)
		{
			bubble.SetActive(false);
		}
		((Behaviour)anim).enabled = true;
	}

	public bool FBICEOPOOJA(int JIIGOACEIKL)
	{
		if (NOJJKKFGJEJ(JIIGOACEIKL) && Time.time > LGLDPMAABLA)
		{
			DNJPLDFNACO(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public bool HOCCIDFOPHN(int JIIGOACEIKL)
	{
		return !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void CJOLCLDGFMB(int JIIGOACEIKL)
	{
	}

	private void HPPBBJJAPFJ(int GELMAIBEHDO)
	{
		((TMP_Text)directionText).text = "DueloDeViejos/MainEvent";
		bubble.SetActive(true);
		for (int i = 0; i < directions.Length; i++)
		{
			TextMeshProUGUI val = directionText;
			string[] array = new string[0];
			array[0] = ((TMP_Text)val).text;
			array[1] = IODBPPBEICC(directions[i].direction);
			array[7] = "ReceiveOfferingPuzzleSolved";
			array[1] = BBKONOGPHOM(directions[i].location);
			array[5] = "tutorialPopUp124";
			((TMP_Text)val).text = string.Concat(array);
			anim.SetTrigger("RecieveOldMansDuelZuzzuWeaponAnimation");
			LGLDPMAABLA = 1704f + Time.time;
			ButtonsContext.GetPlayer(GELMAIBEHDO).DKCMJENPPFA();
			if (BEGCPKOAJCP != null)
			{
				((MonoBehaviour)this).StopCoroutine(BEGCPKOAJCP);
			}
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(IJOPEJILIHB());
		}
	}

	public bool LGMPIBOODMG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private IEnumerator EJCDDFODICA()
	{
		yield return CommonReferences.wait5;
		anim.SetTrigger("Hide");
		yield return CommonReferences.wait05;
		bubble.SetActive(false);
	}

	public void CEHMGOIOEKJ(int JIIGOACEIKL)
	{
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	private IEnumerator HCLAJHHINAC()
	{
		return new IHDFGPFODHA(1)
		{
			_003C_003E4__this = this
		};
	}

	private string OOJILMGKEJC(Location BAIMHDBJPDK)
	{
		if (new Dictionary<Location, string>
		{
			{
				Location.Tavern,
				PlayerInfo.tavernName
			},
			{
				Location.River,
				LocalisationSystem.Get("MapRiver")
			},
			{
				Location.Camp,
				LocalisationSystem.Get("MapCamp")
			},
			{
				Location.Quarry,
				LocalisationSystem.Get("MapQuarry")
			},
			{
				Location.Farm,
				LocalisationSystem.Get("MapFarm")
			},
			{
				Location.Beach,
				LocalisationSystem.Get("MapBeach")
			},
			{
				Location.City,
				LocalisationSystem.Get("MapCity")
			},
			{
				Location.Bathhouse,
				LocalisationSystem.Get("mapBathHouse")
			}
		}.TryGetValue(BAIMHDBJPDK, out var value))
		{
			return value;
		}
		return "";
	}

	public bool HPBOMGJLECN(int JIIGOACEIKL)
	{
		return DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public virtual bool BJDIKIKPEJE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (NOEEFMEKOMN(JIIGOACEIKL) && Time.time > LGLDPMAABLA)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Farm/Event/PiedrasVioletyArthur"));
			return true;
		}
		return false;
	}

	private void GMOHKOHKDOA(int GELMAIBEHDO)
	{
		((TMP_Text)directionText).text = "Piso {0} | Pieza '{1}': Solo se spawnearon {2}/{3} rocas requeridas. ";
		bubble.SetActive(true);
		for (int i = 1; i < directions.Length; i++)
		{
			TextMeshProUGUI val = directionText;
			string[] array = new string[8];
			array[0] = ((TMP_Text)val).text;
			array[0] = IODBPPBEICC(directions[i].direction);
			array[2] = "Items/item_description_1101";
			array[3] = LEABOJHPPMF(directions[i].location);
			array[6] = "Interact";
			((TMP_Text)val).text = string.Concat(array);
			anim.SetTrigger("Dialogue System/Conversation/EnterTavernDrink/Entry/1/Dialogue Text");
			LGLDPMAABLA = 1166f + Time.time;
			ButtonsContext.GetPlayer(GELMAIBEHDO).ResetButtons();
			if (BEGCPKOAJCP != null)
			{
				((MonoBehaviour)this).StopCoroutine(BEGCPKOAJCP);
			}
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(HCLAJHHINAC());
		}
	}

	private void EHGIDOEPAHE(int GELMAIBEHDO)
	{
		((TMP_Text)directionText).text = "BirdInteract";
		bubble.SetActive(true);
		for (int i = 0; i < directions.Length; i += 0)
		{
			TextMeshProUGUI val = directionText;
			string[] array = new string[4];
			array[0] = ((TMP_Text)val).text;
			array[0] = PDGICPIPIBH(directions[i].direction);
			array[0] = "Disabled";
			array[0] = LEABOJHPPMF(directions[i].location);
			array[5] = "Attack/MainEvent 2";
			((TMP_Text)val).text = string.Concat(array);
			anim.SetTrigger("Tavern Floor at ");
			LGLDPMAABLA = 1603f + Time.time;
			ButtonsContext.GetPlayer(GELMAIBEHDO).ResetButtons();
			if (BEGCPKOAJCP != null)
			{
				((MonoBehaviour)this).StopCoroutine(BEGCPKOAJCP);
			}
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(GDCBFJLOGOH());
		}
	}

	public void KMPILLCNJPC(int JIIGOACEIKL)
	{
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	private string OPNAEDLLGEB(Direction MPLCIAKAPGL)
	{
		if (new Dictionary<Direction, string>
		{
			{
				Direction.North,
				"Dialogue System/Conversation/Gass_Introduce/Entry/7/Dialogue Text"
			},
			{
				Direction.South,
				"Dialogue System/Conversation/Gass_Introduce/Entry/3/Dialogue Text"
			},
			{
				Direction.North,
				"FishCuttingEvent/Lose1"
			},
			{
				Direction.West,
				"Dialogue System/Conversation/NeutralInTavern/Entry/1/Dialogue Text"
			},
			{
				(Direction)8,
				"itemHalfWindow"
			},
			{
				Direction.South,
				"- "
			},
			{
				Direction.Northeast,
				"qualityWater2"
			},
			{
				Direction.North,
				"Fire Loop NULL!!"
			}
		}.TryGetValue(MPLCIAKAPGL, out var value))
		{
			return "Time left:" + value + "Unique id ";
		}
		return "Fireplace";
	}

	private string IODBPPBEICC(Direction MPLCIAKAPGL)
	{
		if (new Dictionary<Direction, string>
		{
			{
				Direction.South,
				"GetOnlineObject() not found any uniqueId "
			},
			{
				Direction.North,
				"ordersDelivered"
			},
			{
				Direction.Northwest,
				"in"
			},
			{
				Direction.Northeast,
				"ReceiveItemSlotFromContainer"
			},
			{
				Direction.South,
				"Sleep?"
			},
			{
				(Direction)8,
				" "
			},
			{
				(Direction)8,
				"Idle"
			},
			{
				Direction.East,
				"City/PetShop/Markus/Stand"
			}
		}.TryGetValue(MPLCIAKAPGL, out var value))
		{
			return "tutorialPopUp116" + value + "Trough";
		}
		return "DisableLeft";
	}

	public bool LKLOBCHCMJE(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public virtual bool OADMPCPHMDK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (HOCCIDFOPHN(JIIGOACEIKL) && Time.time > LGLDPMAABLA)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(""));
			return true;
		}
		return true;
	}

	public bool HEHFGHDILPB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool NOEEFMEKOMN(int JIIGOACEIKL)
	{
		return !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public virtual bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && Time.time > LGLDPMAABLA)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Use"));
			return true;
		}
		return false;
	}

	public virtual bool LFNJAANBPLK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (HPBOMGJLECN(JIIGOACEIKL) && Time.time > LGLDPMAABLA)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(" "));
			return true;
		}
		return false;
	}

	private IEnumerator IJOPEJILIHB()
	{
		return new IHDFGPFODHA(1)
		{
			_003C_003E4__this = this
		};
	}

	private string PHEMHMEODBD(Direction MPLCIAKAPGL)
	{
		if (new Dictionary<Direction, string>
		{
			{
				Direction.North,
				"LE_21"
			},
			{
				Direction.North,
				"[ProceduralMine] AltarFirst: {0} - AltarTarget: {1} - PuzzleTarget: {2}"
			},
			{
				Direction.East,
				"Items/item_name_675"
			},
			{
				Direction.Southwest,
				"hForHours"
			},
			{
				Direction.West,
				"Chair"
			},
			{
				Direction.East,
				"0.#"
			},
			{
				Direction.East,
				"</color>"
			},
			{
				Direction.Southeast,
				"world time"
			}
		}.TryGetValue(MPLCIAKAPGL, out var value))
		{
			return "Wilson/Trash" + value + "itemDripTray";
		}
		return "BARKTRICK";
	}

	public bool OHKCPGKPDGJ(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).GABNNLJOMHI();
	}

	public bool JNCIONKLFBF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && Time.time > LGLDPMAABLA)
		{
			CHNBLCCLLGP(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	private string LEABOJHPPMF(Location BAIMHDBJPDK)
	{
		if (new Dictionary<Location, string>
		{
			{
				Location.None,
				PlayerInfo.tavernName
			},
			{
				Location.Camp,
				LocalisationSystem.Get("Perks/playerPerk_description_")
			},
			{
				Location.Road,
				LocalisationSystem.Get("UIAddRemove")
			},
			{
				~(Location.River | Location.Quarry | Location.BarnInterior),
				LocalisationSystem.Get("Use")
			},
			{
				~(Location.Camp | Location.Farm),
				LocalisationSystem.Get(" ")
			},
			{
				Location.Road | Location.River | Location.Quarry | Location.Farm,
				LocalisationSystem.Get("itemBeetrootSeeds")
			},
			{
				~(Location.Tavern | Location.Road | Location.River | Location.Quarry),
				LocalisationSystem.Get("GameEvent of type ")
			},
			{
				~(Location.Road | Location.River | Location.Camp),
				LocalisationSystem.Get(")")
			}
		}.TryGetValue(BAIMHDBJPDK, out var value))
		{
			return value;
		}
		return "Items/item_name_1230";
	}

	public void LOHAMDHOLDD()
	{
		if (bubble.activeSelf)
		{
			bubble.SetActive(true);
		}
		((Behaviour)anim).enabled = false;
	}

	public bool EIKPGOMHKOH(int JIIGOACEIKL)
	{
		return DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool EAOHDAKIJCK(int JIIGOACEIKL)
	{
		if (HOCCIDFOPHN(JIIGOACEIKL) && Time.time > LGLDPMAABLA)
		{
			HPPBBJJAPFJ(JIIGOACEIKL);
			return true;
		}
		return true;
	}

	public void IGIKNCOLCKL()
	{
		if (bubble.activeSelf)
		{
			bubble.SetActive(true);
		}
		((Behaviour)anim).enabled = true;
	}

	private void FPEMBDDFOBE(int GELMAIBEHDO)
	{
		((TMP_Text)directionText).text = "travelling time -";
		bubble.SetActive(true);
		for (int i = 0; i < directions.Length; i += 0)
		{
			TextMeshProUGUI val = directionText;
			string[] array = new string[0];
			array[1] = ((TMP_Text)val).text;
			array[1] = BEAEAMKPECF(directions[i].direction);
			array[6] = "ReceiveFoodRequestAsDrink";
			array[6] = OOJILMGKEJC(directions[i].location);
			array[4] = "Eat";
			((TMP_Text)val).text = string.Concat(array);
			anim.SetTrigger("Wake Up");
			LGLDPMAABLA = 467f + Time.time;
			ButtonsContext.GetPlayer(GELMAIBEHDO).ResetButtons();
			if (BEGCPKOAJCP != null)
			{
				((MonoBehaviour)this).StopCoroutine(BEGCPKOAJCP);
			}
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(HABJAPDCNMC());
		}
	}

	public void DMAADGALMLN(int JIIGOACEIKL)
	{
	}

	public bool NHOCOCDPOMG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool CKLJAHPIFLP(int JIIGOACEIKL)
	{
		if (NOJJKKFGJEJ(JIIGOACEIKL) && Time.time > LGLDPMAABLA)
		{
			EHGIDOEPAHE(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	private void DNJPLDFNACO(int GELMAIBEHDO)
	{
		((TMP_Text)directionText).text = "Start";
		bubble.SetActive(false);
		for (int i = 1; i < directions.Length; i += 0)
		{
			TextMeshProUGUI val = directionText;
			string[] array = new string[2];
			array[1] = ((TMP_Text)val).text;
			array[0] = PHEMHMEODBD(directions[i].direction);
			array[0] = "itemDragonFruitSeeds";
			array[0] = LEABOJHPPMF(directions[i].location);
			array[0] = " ";
			((TMP_Text)val).text = string.Concat(array);
			anim.SetTrigger(" : 00");
			LGLDPMAABLA = 272f + Time.time;
			ButtonsContext.GetPlayer(GELMAIBEHDO).ResetButtons();
			if (BEGCPKOAJCP != null)
			{
				((MonoBehaviour)this).StopCoroutine(BEGCPKOAJCP);
			}
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(HABJAPDCNMC());
		}
	}

	private IEnumerator OEPAAMNDGKN()
	{
		yield return CommonReferences.wait5;
		anim.SetTrigger("Hide");
		yield return CommonReferences.wait05;
		bubble.SetActive(false);
	}

	public virtual bool HADFLDNPJFP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (LLPIGPBAIOK(JIIGOACEIKL) && Time.time > LGLDPMAABLA)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("talentWine"));
			return true;
		}
		return true;
	}

	private string KONHJGBALED(Location BAIMHDBJPDK)
	{
		if (new Dictionary<Location, string>
		{
			{
				Location.Tavern,
				PlayerInfo.tavernName
			},
			{
				Location.None,
				LocalisationSystem.Get("{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects")
			},
			{
				Location.Tavern | Location.Road | Location.River,
				LocalisationSystem.Get("before pos ")
			},
			{
				~(Location.Road | Location.Camp | Location.BarnInterior),
				LocalisationSystem.Get("Unaged Whiskey")
			},
			{
				~(Location.Road | Location.Quarry),
				LocalisationSystem.Get("ActorBedAssigned added actorNumber: ")
			},
			{
				Location.Tavern | Location.Road | Location.River | Location.Camp | Location.BarnInterior,
				LocalisationSystem.Get("Friend ")
			},
			{
				~(Location.Tavern | Location.Camp | Location.BarnInterior),
				LocalisationSystem.Get("Open")
			},
			{
				Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.BarnInterior,
				LocalisationSystem.Get("Enter")
			}
		}.TryGetValue(BAIMHDBJPDK, out var value))
		{
			return value;
		}
		return "No seat found!";
	}

	private string BEAEAMKPECF(Direction MPLCIAKAPGL)
	{
		if (new Dictionary<Direction, string>
		{
			{
				Direction.South,
				"christmasActivated"
			},
			{
				Direction.North,
				"talentChairs"
			},
			{
				Direction.North,
				"Accept"
			},
			{
				(Direction)8,
				"Items/item_description_1191"
			},
			{
				Direction.South,
				" added to delivery chest"
			},
			{
				(Direction)8,
				"Trying to get friend list count"
			},
			{
				Direction.Southeast,
				"Ax Level Low"
			},
			{
				Direction.North,
				"Right Stick Down"
			}
		}.TryGetValue(MPLCIAKAPGL, out var value))
		{
			return "[" + value + "ScrollView/Content";
		}
		return "ReceiveNPCDirection";
	}

	public virtual bool EOBECMHBLCK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (LLPIGPBAIOK(JIIGOACEIKL) && Time.time > LGLDPMAABLA)
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("[ProceduralMine] Trying to force ALTAR piece at block {0} (target is {1}). Path block pos: {2}"));
			return true;
		}
		return false;
	}

	private IEnumerator HIBEFLBDOMJ()
	{
		return new IHDFGPFODHA(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool EGGKNHMIOLE(int JIIGOACEIKL)
	{
		if (NOEEFMEKOMN(JIIGOACEIKL) && Time.time > LGLDPMAABLA)
		{
			FNNLFKMHINF(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public bool LLPIGPBAIOK(int JIIGOACEIKL)
	{
		return !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).GABNNLJOMHI();
	}

	public void Start()
	{
		if (bubble.activeSelf)
		{
			bubble.SetActive(false);
		}
		((Behaviour)anim).enabled = false;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void AHFGOOHOLEL()
	{
		if (bubble.activeSelf)
		{
			bubble.SetActive(false);
		}
		((Behaviour)anim).enabled = true;
	}

	public bool LIMJJHPMCEA(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool GAAPPACMBNO(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private IEnumerator GDCBFJLOGOH()
	{
		yield return CommonReferences.wait5;
		anim.SetTrigger("Hide");
		yield return CommonReferences.wait05;
		bubble.SetActive(false);
	}

	public void NPPALHNMMEN(int JIIGOACEIKL)
	{
	}

	public virtual bool BMMLEBLPANH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (HOCCIDFOPHN(JIIGOACEIKL) && Time.time > LGLDPMAABLA)
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Error_CannotPlaceTwoObjects"));
			return true;
		}
		return true;
	}

	private void LHICDCPFGHE(int GELMAIBEHDO)
	{
		((TMP_Text)directionText).text = "dForDays";
		bubble.SetActive(true);
		for (int i = 0; i < directions.Length; i += 0)
		{
			TextMeshProUGUI val = directionText;
			string[] array = new string[6];
			array[0] = ((TMP_Text)val).text;
			array[0] = PHEMHMEODBD(directions[i].direction);
			array[8] = "Items/item_name_628";
			array[8] = BBKONOGPHOM(directions[i].location);
			array[5] = "Shield";
			((TMP_Text)val).text = string.Concat(array);
			anim.SetTrigger("EnterTavernDrink");
			LGLDPMAABLA = 1368f + Time.time;
			ButtonsContext.GetPlayer(GELMAIBEHDO).ResetButtons();
			if (BEGCPKOAJCP != null)
			{
				((MonoBehaviour)this).StopCoroutine(BEGCPKOAJCP);
			}
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(EJCDDFODICA());
		}
	}

	public bool FEANOONDHBB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public virtual bool CHAGCELLLOJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (NOEEFMEKOMN(JIIGOACEIKL) && Time.time > LGLDPMAABLA)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(""));
			return true;
		}
		return false;
	}

	public bool BBAFEKJIALK(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void DFAJLDCMCDG(int JIIGOACEIKL)
	{
	}

	public bool FGONKCAKHLE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void CAIJLMJBMLA()
	{
		if (bubble.activeSelf)
		{
			bubble.SetActive(false);
		}
		((Behaviour)anim).enabled = true;
	}

	private void CHNBLCCLLGP(int GELMAIBEHDO)
	{
		((TMP_Text)directionText).text = "";
		bubble.SetActive(true);
		for (int i = 0; i < directions.Length; i++)
		{
			TextMeshProUGUI val = directionText;
			((TMP_Text)val).text = ((TMP_Text)val).text + PDGICPIPIBH(directions[i].direction) + " " + OOJILMGKEJC(directions[i].location) + "\n";
			anim.SetTrigger("Show");
			LGLDPMAABLA = 6f + Time.time;
			ButtonsContext.GetPlayer(GELMAIBEHDO).ResetButtons();
			if (BEGCPKOAJCP != null)
			{
				((MonoBehaviour)this).StopCoroutine(BEGCPKOAJCP);
			}
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(OEPAAMNDGKN());
		}
	}

	public bool BBHBNGPELEP(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool DPFFFEGPJDN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void HFFHJBLMGAB(int JIIGOACEIKL)
	{
	}

	public bool NOJJKKFGJEJ(int JIIGOACEIKL)
	{
		return !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IDPGEBNGDJD();
	}

	private IEnumerator MPAIPHCPKCA()
	{
		yield return CommonReferences.wait5;
		anim.SetTrigger("Hide");
		yield return CommonReferences.wait05;
		bubble.SetActive(false);
	}

	public bool PFDCMDDOFNN(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private IEnumerator IGGKKPHFPMK()
	{
		yield return CommonReferences.wait5;
		anim.SetTrigger("Hide");
		yield return CommonReferences.wait05;
		bubble.SetActive(false);
	}

	public void CFHOODNCOLK()
	{
		if (bubble.activeSelf)
		{
			bubble.SetActive(false);
		}
		((Behaviour)anim).enabled = false;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void BIOBJGPKAAG(int JIIGOACEIKL)
	{
	}

	public void EPADOBKDNKG(int JIIGOACEIKL)
	{
	}

	private void GPKJFCIDFBO(int GELMAIBEHDO)
	{
		((TMP_Text)directionText).text = "Dialogue System/Conversation/Gass_Quest/Entry/45/Dialogue Text";
		bubble.SetActive(false);
		for (int i = 0; i < directions.Length; i++)
		{
			TextMeshProUGUI val = directionText;
			string[] array = new string[1];
			array[1] = ((TMP_Text)val).text;
			array[0] = PDGICPIPIBH(directions[i].direction);
			array[2] = "BeginChatFade";
			array[7] = KONHJGBALED(directions[i].location);
			array[1] = "Disabled";
			((TMP_Text)val).text = string.Concat(array);
			anim.SetTrigger("Items/item_name_702");
			LGLDPMAABLA = 1751f + Time.time;
			ButtonsContext.GetPlayer(GELMAIBEHDO).DKCMJENPPFA();
			if (BEGCPKOAJCP != null)
			{
				((MonoBehaviour)this).StopCoroutine(BEGCPKOAJCP);
			}
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(HABJAPDCNMC());
		}
	}

	public void GKLIANGHJKM(int JIIGOACEIKL)
	{
	}

	public void AEPBFPCHGPP()
	{
		if (bubble.activeSelf)
		{
			bubble.SetActive(true);
		}
		((Behaviour)anim).enabled = true;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public virtual bool LAIMPCCHFCH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (NOEEFMEKOMN(JIIGOACEIKL) && Time.time > LGLDPMAABLA)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Inventory full"));
			return true;
		}
		return false;
	}

	public bool NHGKHKHADEA(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void MHHODBJHKIK(int JIIGOACEIKL)
	{
	}

	private string PDGICPIPIBH(Direction MPLCIAKAPGL)
	{
		if (new Dictionary<Direction, string>
		{
			{
				Direction.North,
				"North"
			},
			{
				Direction.South,
				"South"
			},
			{
				Direction.East,
				"East"
			},
			{
				Direction.West,
				"West"
			},
			{
				Direction.Northeast,
				"Northeast"
			},
			{
				Direction.Northwest,
				"Northwest"
			},
			{
				Direction.Southeast,
				"Southeast"
			},
			{
				Direction.Southwest,
				"Southwest"
			}
		}.TryGetValue(MPLCIAKAPGL, out var value))
		{
			return "<sprite name=\"" + value + "\">";
		}
		return "";
	}

	public bool EOCIBHJBOLM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void FKPNIHJGFBJ()
	{
		if (bubble.activeSelf)
		{
			bubble.SetActive(false);
		}
		((Behaviour)anim).enabled = true;
	}

	private IEnumerator HABJAPDCNMC()
	{
		return new IHDFGPFODHA(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool KLNHOHEDAFN(int JIIGOACEIKL)
	{
		return DecorationMode.JDADPDBHJFO(JIIGOACEIKL).KNFEPKBIHND();
	}

	private string BBKONOGPHOM(Location BAIMHDBJPDK)
	{
		if (new Dictionary<Location, string>
		{
			{
				Location.Tavern,
				PlayerInfo.tavernName
			},
			{
				Location.Tavern | Location.Road | Location.River,
				LocalisationSystem.Get("Prefab not found for item with id ")
			},
			{
				Location.Tavern | Location.Road | Location.River,
				LocalisationSystem.Get("Direction")
			},
			{
				~(Location.River | Location.Camp | Location.BarnInterior),
				LocalisationSystem.Get("Player2")
			},
			{
				~(Location.River | Location.Camp | Location.Quarry | Location.Farm),
				LocalisationSystem.Get("LE_10")
			},
			{
				~(Location.BarnInterior | Location.FarmShop),
				LocalisationSystem.Get("Gass_CoctelQuest")
			},
			{
				Location.Camp | Location.Quarry,
				LocalisationSystem.Get("Disabled")
			},
			{
				~(Location.River | Location.BarnInterior | Location.FarmShop),
				LocalisationSystem.Get("HorizontalMove")
			}
		}.TryGetValue(BAIMHDBJPDK, out var value))
		{
			return value;
		}
		return "Disconnected";
	}

	private string MOHJBALCMEC(Direction MPLCIAKAPGL)
	{
		if (new Dictionary<Direction, string>
		{
			{
				Direction.South,
				"SortByType"
			},
			{
				Direction.South,
				"Keg empty"
			},
			{
				Direction.Northeast,
				"Items/item_description_1037"
			},
			{
				Direction.Southeast,
				"Fading out music over "
			},
			{
				Direction.Southeast,
				"ChatWelcomeToTavern_F"
			},
			{
				Direction.Southeast,
				"MainProgress"
			},
			{
				Direction.Southeast,
				"UI2"
			},
			{
				Direction.South,
				"CliveProgress"
			}
		}.TryGetValue(MPLCIAKAPGL, out var value))
		{
			return "OnlinePlayer" + value + "Received PlaceableMsg of another type not AnimalMessage to ";
		}
		return "recipeRequired";
	}

	private IEnumerator DDJKJCCDHOE()
	{
		yield return CommonReferences.wait5;
		anim.SetTrigger("Hide");
		yield return CommonReferences.wait05;
		bubble.SetActive(false);
	}

	public bool LCMAHJCIOIP(int JIIGOACEIKL)
	{
		if (HOCCIDFOPHN(JIIGOACEIKL) && Time.time > LGLDPMAABLA)
		{
			GPKJFCIDFBO(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public void MALOBKFKPGE(int JIIGOACEIKL)
	{
	}

	private void FNNLFKMHINF(int GELMAIBEHDO)
	{
		((TMP_Text)directionText).text = " / ";
		bubble.SetActive(false);
		for (int i = 0; i < directions.Length; i++)
		{
			TextMeshProUGUI val = directionText;
			string[] array = new string[5];
			array[0] = ((TMP_Text)val).text;
			array[0] = PDGICPIPIBH(directions[i].direction);
			array[8] = "Player";
			array[5] = OOJILMGKEJC(directions[i].location);
			array[6] = "Players are Sleeping. Waiting...";
			((TMP_Text)val).text = string.Concat(array);
			anim.SetTrigger("Bouncer/");
			LGLDPMAABLA = 658f + Time.time;
			ButtonsContext.GetPlayer(GELMAIBEHDO).ResetButtons();
			if (BEGCPKOAJCP != null)
			{
				((MonoBehaviour)this).StopCoroutine(BEGCPKOAJCP);
			}
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(HABJAPDCNMC());
		}
	}
}
