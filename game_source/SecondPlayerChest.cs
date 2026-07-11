using System.Collections;
using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class SecondPlayerChest : MonoBehaviour, IInteractable, ISelectable, IProximity, IHoverable
{
	private static SecondPlayerChest IADEMLIIDPC;

	[SerializeField]
	private Placeable placeable;

	private float PPMHCOBKMCN;

	private float LINBLNKCFBB;

	[SerializeField]
	private OpenSound openSound;

	public bool hasAnimation;

	public float frameRate = 0.125f;

	public SpriteRenderer doorSpriteRenderer;

	public Sprite[] animationSprites;

	private bool KCLDPDNCNOA;

	private bool NKEMALMMOBL;

	private string MFHACMAHGHC = "Output is not ready";

	public static SecondPlayerChest GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<SecondPlayerChest>();
			}
			return IADEMLIIDPC;
		}
	}

	public void FFFAMACMKLI(int JIIGOACEIKL)
	{
	}

	public bool CMOBHHGFDNP(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.HHDBMDMFEMP())
			{
				if (Time.time > PPMHCOBKMCN + 1023f)
				{
					PPMHCOBKMCN = Time.time;
					CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("Tavern Zone by id not found ", JIIGOACEIKL, ECPEFDHOFHN: false);
				}
				return false;
			}
			if (GameManager.LocalCoop())
			{
				float num = ((JIIGOACEIKL == 4) ? LINBLNKCFBB : PPMHCOBKMCN);
				if (Time.time > num + 71f)
				{
					if (JIIGOACEIKL == 0)
					{
						LINBLNKCFBB = Time.time;
					}
					else
					{
						PPMHCOBKMCN = Time.time;
					}
					if (JIIGOACEIKL == 1)
					{
						DialogueManager.Bark("<sprite name=white_arrow_right> ", ((Component)PlayerController.OPHDCMJLLEC(1)).transform);
					}
					else
					{
						DialogueManager.Bark("itemIronIngot", ((Component)PlayerController.OPHDCMJLLEC(8)).transform);
					}
				}
				return false;
			}
			if (!KCLDPDNCNOA)
			{
				KCLDPDNCNOA = true;
				((MonoBehaviour)this).StartCoroutine(NMIHFFICLPB(JIIGOACEIKL));
			}
			return true;
		}
		return false;
	}

	public void LJOLGDBKLGH(int JIIGOACEIKL)
	{
	}

	public bool MLCJBAEKGOC(int JIIGOACEIKL)
	{
		return false;
	}

	public IEnumerator NILPHMOMOAF()
	{
		if (hasAnimation)
		{
			NKEMALMMOBL = true;
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.closeDoor, ((Component)this).transform);
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.OBCEOGNEFPD(animationSprites, doorSpriteRenderer, frameRate));
			NKEMALMMOBL = false;
		}
		KCLDPDNCNOA = false;
		if (Object.op_Implicit((Object)(object)placeable))
		{
			placeable.selectBlockers.Remove(MFHACMAHGHC);
		}
	}

	public bool HAPLPIMJGGN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	private void IKAJNCECNJG(int JIIGOACEIKL)
	{
		BigContainerUI.EPLOMIBMKFC(JIIGOACEIKL).GFENGKOBKDE((MonoBehaviour)(object)this);
		BigContainerUI.OHPNDOJNCBK(JIIGOACEIKL).JGMNPLDFOPP(IFMNAFDGKKK: false);
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		BigContainerUI.AANKLOIDPOA(JIIGOACEIKL).IDLAGJNLPJL();
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		BigContainerUI.Get(JIIGOACEIKL).CloseUI();
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		if (!NKEMALMMOBL)
		{
			((MonoBehaviour)this).StartCoroutine(CloseContainer());
		}
		return true;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	protected void KHONOODGLBI()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			if ((Object)(object)placeable == (Object)null)
			{
				placeable = ((Component)this).GetComponent<Placeable>();
			}
		}
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool LCDFJODPNGJ(int JIIGOACEIKL)
	{
		return true;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public IEnumerator AMKKOPFDILJ(int JIIGOACEIKL)
	{
		Sound.GGFJGHHHEJC.PlayOpenSound(OpenSound.Wood, ((Component)this).transform);
		if (hasAnimation)
		{
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.KAHHFCFDJIK(JIIGOACEIKL, frameRate, animationSprites, doorSpriteRenderer, (MonoBehaviour)(object)this));
		}
		if (!NKEMALMMOBL)
		{
			if (Object.op_Implicit((Object)(object)placeable) && !placeable.selectBlockers.Contains(MFHACMAHGHC))
			{
				placeable.selectBlockers.Add(MFHACMAHGHC);
			}
			if (!SmallContainerUI.Get(JIIGOACEIKL).IsOpen())
			{
				InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
				BigContainerUI.Get(JIIGOACEIKL).SetContainer(Inventory.GetPlayer(2, LAGHIOKLJGH: true));
				BigContainerUI.Get(JIIGOACEIKL).FillSlots(PlayerInventory.GetPlayer(2, LAGHIOKLJGH: true).GetAllSlots(), null, IFMNAFDGKKK: true, OGCAKIGELBJ: false, 5);
				MCMCNOOHKPE(JIIGOACEIKL);
			}
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)placeable) && placeable.FHEMHCEAICB)
		{
			return false;
		}
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	public bool AENDGJJDOLL(int JIIGOACEIKL)
	{
		BigContainerUI.OHPNDOJNCBK(JIIGOACEIKL).CloseUI();
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		if (!NKEMALMMOBL)
		{
			((MonoBehaviour)this).StartCoroutine(CloseContainer());
		}
		return false;
	}

	public void KECJNJANCEK(int JIIGOACEIKL)
	{
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.ClientOnline())
			{
				if (Time.time > PPMHCOBKMCN + 8f)
				{
					PPMHCOBKMCN = Time.time;
					CommonReferences.GGFJGHHHEJC.PlayerBark("NotMyChest", JIIGOACEIKL);
				}
				return false;
			}
			if (GameManager.LocalCoop())
			{
				float num = ((JIIGOACEIKL == 2) ? LINBLNKCFBB : PPMHCOBKMCN);
				if (Time.time > num + 8f)
				{
					if (JIIGOACEIKL == 2)
					{
						LINBLNKCFBB = Time.time;
					}
					else
					{
						PPMHCOBKMCN = Time.time;
					}
					if (JIIGOACEIKL == 1)
					{
						DialogueManager.Bark("Player_Bark_2PlayersChest", ((Component)PlayerController.GetPlayer(1)).transform);
					}
					else
					{
						DialogueManager.Bark("Player2_Bark_2PlayersChest", ((Component)PlayerController.GetPlayer(2)).transform);
					}
				}
				return false;
			}
			if (!KCLDPDNCNOA)
			{
				KCLDPDNCNOA = true;
				((MonoBehaviour)this).StartCoroutine(OpenContainer(JIIGOACEIKL));
			}
			return true;
		}
		return false;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Open"));
			return true;
		}
		return false;
	}

	protected void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			if ((Object)(object)placeable == (Object)null)
			{
				placeable = ((Component)this).GetComponent<Placeable>();
			}
		}
	}

	public IEnumerator CloseContainer()
	{
		if (hasAnimation)
		{
			NKEMALMMOBL = true;
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.closeDoor, ((Component)this).transform);
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.OBCEOGNEFPD(animationSprites, doorSpriteRenderer, frameRate));
			NKEMALMMOBL = false;
		}
		KCLDPDNCNOA = false;
		if (Object.op_Implicit((Object)(object)placeable))
		{
			placeable.selectBlockers.Remove(MFHACMAHGHC);
		}
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool Select(int JIIGOACEIKL)
	{
		return false;
	}

	public bool GGFLHCNGPDK(int JIIGOACEIKL)
	{
		return false;
	}

	private void MCMCNOOHKPE(int JIIGOACEIKL)
	{
		BigContainerUI.Get(JIIGOACEIKL).NBKOCCODEKN = (MonoBehaviour)(object)this;
		BigContainerUI.Get(JIIGOACEIKL).SetDeliveryOnly(IFMNAFDGKKK: true);
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		BigContainerUI.Get(JIIGOACEIKL).OpenUI();
	}

	public IEnumerator OpenContainer(int JIIGOACEIKL)
	{
		Sound.GGFJGHHHEJC.PlayOpenSound(OpenSound.Wood, ((Component)this).transform);
		if (hasAnimation)
		{
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.KAHHFCFDJIK(JIIGOACEIKL, frameRate, animationSprites, doorSpriteRenderer, (MonoBehaviour)(object)this));
		}
		if (!NKEMALMMOBL)
		{
			if (Object.op_Implicit((Object)(object)placeable) && !placeable.selectBlockers.Contains(MFHACMAHGHC))
			{
				placeable.selectBlockers.Add(MFHACMAHGHC);
			}
			if (!SmallContainerUI.Get(JIIGOACEIKL).IsOpen())
			{
				InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
				BigContainerUI.Get(JIIGOACEIKL).SetContainer(Inventory.GetPlayer(2, LAGHIOKLJGH: true));
				BigContainerUI.Get(JIIGOACEIKL).FillSlots(PlayerInventory.GetPlayer(2, LAGHIOKLJGH: true).GetAllSlots(), null, IFMNAFDGKKK: true, OGCAKIGELBJ: false, 5);
				MCMCNOOHKPE(JIIGOACEIKL);
			}
		}
	}

	public void FOGLDLKAEBK(int JIIGOACEIKL)
	{
	}

	public IEnumerator NMIHFFICLPB(int JIIGOACEIKL)
	{
		Sound.GGFJGHHHEJC.PlayOpenSound(OpenSound.Wood, ((Component)this).transform);
		if (hasAnimation)
		{
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.KAHHFCFDJIK(JIIGOACEIKL, frameRate, animationSprites, doorSpriteRenderer, (MonoBehaviour)(object)this));
		}
		if (!NKEMALMMOBL)
		{
			if (Object.op_Implicit((Object)(object)placeable) && !placeable.selectBlockers.Contains(MFHACMAHGHC))
			{
				placeable.selectBlockers.Add(MFHACMAHGHC);
			}
			if (!SmallContainerUI.Get(JIIGOACEIKL).IsOpen())
			{
				InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
				BigContainerUI.Get(JIIGOACEIKL).SetContainer(Inventory.GetPlayer(2, LAGHIOKLJGH: true));
				BigContainerUI.Get(JIIGOACEIKL).FillSlots(PlayerInventory.GetPlayer(2, LAGHIOKLJGH: true).GetAllSlots(), null, IFMNAFDGKKK: true, OGCAKIGELBJ: false, 5);
				MCMCNOOHKPE(JIIGOACEIKL);
			}
		}
	}

	public bool MKLHOPOEFIH(int JIIGOACEIKL)
	{
		return false;
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public void FMOLFKKGDDM(int JIIGOACEIKL)
	{
	}
}
