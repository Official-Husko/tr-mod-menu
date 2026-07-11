using AlmenaraGames;
using UnityEngine;

public class FountainInteractable : MonoBehaviour, IProximity, IHoverable, IInteractable
{
	[Tooltip("Clave de localización para el botón de interacción.")]
	[SerializeField]
	private string interactLabel = "Fill";

	[SerializeField]
	private GameObject fillGameObject;

	[SerializeField]
	private AudioObject waterSound;

	public int fountainIndex;

	private FountainsPuzzle JKIBJFBMELP;

	public bool IsFilled()
	{
		return fillGameObject.activeSelf;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void JPHBFFJEEEO()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		fillGameObject.SetActive(true);
		if ((Object)(object)waterSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(waterSound, ((Component)this).transform.position);
		}
	}

	public void BCIBHJIDPCJ(FountainsPuzzle HEBHJOEGHON, int BBFADKOAPPI)
	{
		JKIBJFBMELP = HEBHJOEGHON;
		fountainIndex = BBFADKOAPPI;
		fillGameObject.SetActive(true);
	}

	public void FPPLEDOHKNB(int JIIGOACEIKL)
	{
	}

	public bool CFJEJFCALPM(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		MDCEOMJGNKN(JIIGOACEIKL, CDPAMNIPPEC: false);
		return true;
	}

	public void EBMLHKMPGHL(int JIIGOACEIKL)
	{
	}

	public bool IPPODLIPDPJ(int JIIGOACEIKL)
	{
		return true;
	}

	public void LAEDMIPNGPJ(int JIIGOACEIKL)
	{
	}

	public bool DECOJGDAFNH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!NKHLGGKOKKA(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(interactLabel));
		return true;
	}

	public void Setup(FountainsPuzzle HEBHJOEGHON, int BBFADKOAPPI)
	{
		JKIBJFBMELP = HEBHJOEGHON;
		fountainIndex = BBFADKOAPPI;
		fillGameObject.SetActive(false);
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool NLEEDPBKDPB()
	{
		return fillGameObject.activeSelf;
	}

	private void BKCDBBNMKNI(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (JKIBJFBMELP.IsPuzzleSolved() || IsFilled())
		{
			return;
		}
		ItemInstance item = PlayerInventory.GetPlayer(JIIGOACEIKL).GetItem(722);
		if (item != null)
		{
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.SendFillFountain(JKIBJFBMELP.GetManager().mineLevel, fountainIndex);
			}
			FillFountainVisual();
			PlayerInventory.GetPlayer(JIIGOACEIKL).RemoveItemInstance(item, CDPAMNIPPEC: true);
			PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(721, HMPDLIPFBGD: true);
			JKIBJFBMELP.CheckPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC);
		}
		else
		{
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBarkWithI2("INeedWater");
		}
	}

	public bool APFAKKDDFIK(int JIIGOACEIKL)
	{
		return true;
	}

	public bool NKHLGGKOKKA(int JIIGOACEIKL)
	{
		if ((Object)(object)JKIBJFBMELP == (Object)null)
		{
			return false;
		}
		if (NLEEDPBKDPB())
		{
			return true;
		}
		if (!JKIBJFBMELP.PIJKBBCAJON())
		{
			return DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).IDPGEBNGDJD();
		}
		return true;
	}

	public void KECJNJANCEK(int JIIGOACEIKL)
	{
	}

	public void KMPILLCNJPC(int JIIGOACEIKL)
	{
	}

	private void HEDPHOFENBI(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (JKIBJFBMELP.DDCOMOHHEBB() || IsFilled())
		{
			return;
		}
		ItemInstance item = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).GetItem(-102);
		if (item != null)
		{
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.SendFillFountain(JKIBJFBMELP.NAMECAKIKHJ().mineLevel, fountainIndex);
			}
			FillFountainVisual();
			PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).RemoveItemInstance(item, CDPAMNIPPEC: false);
			PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HFJGDBENPGM(101, HMPDLIPFBGD: true);
			JKIBJFBMELP.LEPNLFBAJKB(JIIGOACEIKL, CDPAMNIPPEC);
		}
		else
		{
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBarkWithI2("Tavern Vision");
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if ((Object)(object)JKIBJFBMELP == (Object)null)
		{
			return false;
		}
		if (IsFilled())
		{
			return false;
		}
		if (!JKIBJFBMELP.IsPuzzleSolved())
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public bool JDPLMJFBBED(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!NKHLGGKOKKA(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(interactLabel));
		return true;
	}

	public bool CMOBHHGFDNP(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return true;
		}
		NNPPKOIMEMH(JIIGOACEIKL, CDPAMNIPPEC: false);
		return true;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(interactLabel));
		return true;
	}

	public bool IFBJHCHDHCI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(interactLabel));
		return false;
	}

	public void KJOAMBGFFHE(int JIIGOACEIKL)
	{
	}

	public bool HNMOLFHKBGE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!NKHLGGKOKKA(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(interactLabel));
		return false;
	}

	private void PKIMDNBKBAG(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (JKIBJFBMELP.APPEDHAFFBP() || IsFilled())
		{
			return;
		}
		ItemInstance itemInstance = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KGHFAHKGIGK(13);
		if (itemInstance != null)
		{
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.SendFillFountain(JKIBJFBMELP.AJHGOJEHLED().mineLevel, fountainIndex);
			}
			FillFountainVisual();
			PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JCBCAAMBINH(itemInstance, CDPAMNIPPEC: true);
			PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).AddItem(125);
			JKIBJFBMELP.APOLLMEIDLE(JIIGOACEIKL, CDPAMNIPPEC);
		}
		else
		{
			PlayerController.GetPlayer(JIIGOACEIKL).BIBLHGFCINF("Statue0={0} | ");
		}
	}

	public bool LFDFCDLFNGN(int JIIGOACEIKL)
	{
		return false;
	}

	private void BLIBEOPAFCC(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (JKIBJFBMELP.PIJKBBCAJON() || NLEEDPBKDPB())
		{
			return;
		}
		ItemInstance itemInstance = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KGHFAHKGIGK(82);
		if (itemInstance != null)
		{
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.BCHIAGPDIEI(JKIBJFBMELP.BELBIDDGNJN().mineLevel, fountainIndex);
			}
			PEDLDBAHCCG();
			PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).JCBCAAMBINH(itemInstance, CDPAMNIPPEC: true);
			PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).HFJGDBENPGM(75, HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			JKIBJFBMELP.GEAFHEGMDLO(JIIGOACEIKL, CDPAMNIPPEC);
		}
		else
		{
			PlayerController.GetPlayer(JIIGOACEIKL).BIBLHGFCINF("F2");
		}
	}

	public bool BCGBODLPDEB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!NKHLGGKOKKA(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(interactLabel));
		return false;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public void PEDLDBAHCCG()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		fillGameObject.SetActive(true);
		if ((Object)(object)waterSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(waterSound, ((Component)this).transform.position);
		}
	}

	public bool IDBKMGKPBFP()
	{
		return fillGameObject.activeSelf;
	}

	public void FillFountainVisual()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		fillGameObject.SetActive(true);
		if ((Object)(object)waterSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(waterSound, ((Component)this).transform.position);
		}
	}

	private void MDCEOMJGNKN(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (JKIBJFBMELP.MDPKONCJHBI() || NLEEDPBKDPB())
		{
			return;
		}
		ItemInstance itemInstance = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(-70);
		if (itemInstance != null)
		{
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.SendFillFountain(JKIBJFBMELP.GetManager().mineLevel, fountainIndex);
			}
			PEDLDBAHCCG();
			PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).DEAFNEAFKBM(itemInstance, CDPAMNIPPEC: false);
			PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(-35, HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			JKIBJFBMELP.CheckPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC);
		}
		else
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBarkWithI2("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/29/Dialogue Text");
		}
	}

	public bool HFAILPNNNBB(int JIIGOACEIKL)
	{
		return false;
	}

	public bool LKELFKFPNPJ(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		PKIMDNBKBAG(JIIGOACEIKL, CDPAMNIPPEC: false);
		return false;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		BKCDBBNMKNI(JIIGOACEIKL, CDPAMNIPPEC: true);
		return true;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	private void NNPPKOIMEMH(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (JKIBJFBMELP.APPEDHAFFBP() || IDBKMGKPBFP())
		{
			return;
		}
		ItemInstance itemInstance = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KGHFAHKGIGK(-141);
		if (itemInstance != null)
		{
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.SendFillFountain(JKIBJFBMELP.AJHGOJEHLED().mineLevel, fountainIndex);
			}
			JPHBFFJEEEO();
			PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).RemoveItemInstance(itemInstance, CDPAMNIPPEC: false);
			PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).FICBIPNGLHJ(53, HMPDLIPFBGD: true);
			JKIBJFBMELP.APOLLMEIDLE(JIIGOACEIKL, CDPAMNIPPEC);
		}
		else
		{
			PlayerController.GetPlayer(JIIGOACEIKL).BIBLHGFCINF("ChatDefaultName");
		}
	}
}
