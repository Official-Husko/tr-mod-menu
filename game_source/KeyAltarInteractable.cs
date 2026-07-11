using System.Collections;
using AlmenaraGames;
using UnityEngine;

public class KeyAltarInteractable : MonoBehaviour, IProximity, IHoverable, IInteractable
{
	[SerializeField]
	[Tooltip("Clave de localización para el botón de interacción.")]
	private string interactLabel = "Use";

	[SerializeField]
	private GameObject leftKey;

	[SerializeField]
	private GameObject rightKey;

	[SerializeField]
	private GameObject fullKey;

	[SerializeField]
	private AudioObject addKeySound;

	[SerializeField]
	private AudioObject completedSound;

	private int DHMJIDOJJII = -1;

	private KeyAltarPuzzle FDKGEJBNGIF;

	public bool JMIDFEGOIGP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
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

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		BGADJJMJICI(JIIGOACEIKL, CDPAMNIPPEC: true);
		return true;
	}

	public void ABBPIPGMGBO()
	{
		((MonoBehaviour)this).StartCoroutine(DEMNJEIGFFJ());
	}

	public bool LCDFJODPNGJ(int JIIGOACEIKL)
	{
		return true;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool KMPJAGHJABK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!BGAFGOLFDGI(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(interactLabel));
		return true;
	}

	public void GLMJJDOMPGH(int JIIGOACEIKL)
	{
	}

	public void KPDGBOICFKI(int JIIGOACEIKL)
	{
	}

	public void CompletedSound()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)completedSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(completedSound, ((Component)this).transform.position);
		}
	}

	public void LFALLFNNINI(int JIIGOACEIKL)
	{
	}

	public bool HADFLDNPJFP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(interactLabel));
		return false;
	}

	public void HGLLJJHELPH()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)completedSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(completedSound, ((Component)this).transform.position);
		}
	}

	public bool KHAFEICJIMJ(int JIIGOACEIKL)
	{
		if (!HEOEEFNLJMO(JIIGOACEIKL))
		{
			return false;
		}
		BGADJJMJICI(JIIGOACEIKL, CDPAMNIPPEC: true);
		return false;
	}

	public void BPEDNABMCEJ()
	{
		leftKey.SetActive(false);
		rightKey.SetActive(false);
		fullKey.SetActive(false);
	}

	public void FCAOPHNHPEG()
	{
		if (!leftKey.activeSelf)
		{
			leftKey.SetActive(false);
		}
		if (!rightKey.activeSelf)
		{
			rightKey.SetActive(false);
		}
	}

	public bool KHMBIHKFPCE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!BGAFGOLFDGI(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(interactLabel));
		return false;
	}

	public void LEGMAPCPFFI()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)completedSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(completedSound, ((Component)this).transform.position);
		}
	}

	private IEnumerator DEMNJEIGFFJ()
	{
		yield return CommonReferences.wait06;
		fullKey.SetActive(true);
		rightKey.SetActive(false);
		leftKey.SetActive(false);
	}

	public void OPGEDAEBKAC(int JIIGOACEIKL)
	{
	}

	private IEnumerator HHFOEMJNBKE()
	{
		yield return CommonReferences.wait06;
		fullKey.SetActive(true);
		rightKey.SetActive(false);
		leftKey.SetActive(false);
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public bool HINGCLJLHJF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void BGADJJMJICI(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (FDKGEJBNGIF.IsPuzzleSolved())
		{
			return;
		}
		ItemInstance item = PlayerInventory.GetPlayer(JIIGOACEIKL).GetItem(2071);
		byte b = 0;
		if (item != null)
		{
			AddVisualKey(1);
			PlayerInventory.GetPlayer(JIIGOACEIKL).RemoveItemInstance(item, CDPAMNIPPEC: true);
			b = 1;
		}
		item = PlayerInventory.GetPlayer(JIIGOACEIKL).GetItem(2072);
		if (item != null)
		{
			AddVisualKey(2);
			PlayerInventory.GetPlayer(JIIGOACEIKL).RemoveItemInstance(item, CDPAMNIPPEC: true);
			b = (byte)((b != 1) ? 2 : 3);
		}
		if (rightKey.activeSelf && leftKey.activeSelf)
		{
			FDKGEJBNGIF.PuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC);
		}
		else if (CDPAMNIPPEC)
		{
			if (b != 0)
			{
				OnlinePuzzleManager.instance.SendAddKey(FDKGEJBNGIF.GetManager().mineLevel, b);
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBarkWithI2("INeedAFragment");
			}
		}
	}

	public void APEGAMEGCAB(KeyAltarPuzzle HMPOEPFIJAM)
	{
		FDKGEJBNGIF = HMPOEPFIJAM;
		leftKey.SetActive(true);
		rightKey.SetActive(false);
		fullKey.SetActive(false);
	}

	public bool HEOEEFNLJMO(int JIIGOACEIKL)
	{
		if ((Object)(object)FDKGEJBNGIF == (Object)null)
		{
			return true;
		}
		if (!FDKGEJBNGIF.APPEDHAFFBP())
		{
			return !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).DBAEGBDEPFK();
		}
		return false;
	}

	public bool BGAFGOLFDGI(int JIIGOACEIKL)
	{
		if ((Object)(object)FDKGEJBNGIF == (Object)null)
		{
			return false;
		}
		if (!FDKGEJBNGIF.IsPuzzleSolved())
		{
			return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).IDPGEBNGDJD();
		}
		return true;
	}

	public void MakeSureBothKeysAreEnabled()
	{
		if (!leftKey.activeSelf)
		{
			leftKey.SetActive(true);
		}
		if (!rightKey.activeSelf)
		{
			rightKey.SetActive(true);
		}
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public void LPDEMMEDAOJ(KeyAltarPuzzle HMPOEPFIJAM)
	{
		FDKGEJBNGIF = HMPOEPFIJAM;
		leftKey.SetActive(true);
		rightKey.SetActive(false);
		fullKey.SetActive(false);
	}

	public void OnPuzzleSolved()
	{
		((MonoBehaviour)this).StartCoroutine(HHFOEMJNBKE());
	}

	public byte LLJPNJEGBJO()
	{
		if (leftKey.activeSelf && rightKey.activeSelf)
		{
			return 3;
		}
		if (leftKey.activeSelf)
		{
			return 1;
		}
		if (rightKey.activeSelf)
		{
			return 1;
		}
		return 1;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if ((Object)(object)FDKGEJBNGIF == (Object)null)
		{
			return false;
		}
		if (!FDKGEJBNGIF.IsPuzzleSolved())
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public void SetPuzzleSolved()
	{
		leftKey.SetActive(false);
		rightKey.SetActive(false);
		fullKey.SetActive(true);
	}

	public void FMOLFKKGDDM(int JIIGOACEIKL)
	{
	}

	public void AddVisualKey(byte BJNAGOKOLOO)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		switch (BJNAGOKOLOO)
		{
		case 1:
			leftKey.SetActive(true);
			break;
		case 2:
			rightKey.SetActive(true);
			break;
		}
		if ((Object)(object)addKeySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(addKeySound, ((Component)this).transform.position);
		}
	}

	public void Setup(KeyAltarPuzzle HMPOEPFIJAM)
	{
		FDKGEJBNGIF = HMPOEPFIJAM;
		leftKey.SetActive(false);
		rightKey.SetActive(false);
		fullKey.SetActive(false);
	}

	public bool AKFCDDOMNBF(int JIIGOACEIKL)
	{
		if (!HEOEEFNLJMO(JIIGOACEIKL))
		{
			return true;
		}
		BGADJJMJICI(JIIGOACEIKL, CDPAMNIPPEC: true);
		return false;
	}

	public bool CMIOKHGJCNB(int JIIGOACEIKL)
	{
		if (!HEOEEFNLJMO(JIIGOACEIKL))
		{
			return true;
		}
		BGADJJMJICI(JIIGOACEIKL, CDPAMNIPPEC: true);
		return false;
	}

	public void FIBJAOFKDPC()
	{
		leftKey.SetActive(false);
		rightKey.SetActive(false);
		fullKey.SetActive(false);
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool ELFMBJDBHBD(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		BGADJJMJICI(JIIGOACEIKL, CDPAMNIPPEC: false);
		return true;
	}

	public byte GetKeysActivated()
	{
		if (leftKey.activeSelf && rightKey.activeSelf)
		{
			return 3;
		}
		if (leftKey.activeSelf)
		{
			return 1;
		}
		if (rightKey.activeSelf)
		{
			return 2;
		}
		return 0;
	}
}
