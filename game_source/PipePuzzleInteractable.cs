using System.Collections;
using UnityEngine;

public class PipePuzzleInteractable : MonoBehaviour, IProximity, IHoverable, IInteractable
{
	[Tooltip("Base de datos. Puede sobreescribirse via Setup().")]
	[SerializeField]
	private PipePuzzleDataBase database;

	[Tooltip("Clave de localización para el botón de interacción.")]
	[SerializeField]
	private string interactLabel = "Use";

	private float EKFNOPEBCHL = 1f;

	[SerializeField]
	[Tooltip("Sprites para la animación del puzzle. Se usan solo para animar el interactable cuando se ha resuelto")]
	private GameObject unlockGameObject;

	private int DHMJIDOJJII = -1;

	private MinePipePuzzle IKMGPHDNKNN;

	public bool POCJGFBIJDL(int JIIGOACEIKL)
	{
		if ((Object)(object)IKMGPHDNKNN == (Object)null)
		{
			return true;
		}
		if (!IKMGPHDNKNN.DDCOMOHHEBB())
		{
			return !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DBAEGBDEPFK();
		}
		return false;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public bool CCHCKHEDBII(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void SetPuzzleSolved()
	{
		unlockGameObject.SetActive(true);
	}

	public bool LBNJPLCFLEE(int JIIGOACEIKL)
	{
		if (!OHKCPGKPDGJ(JIIGOACEIKL))
		{
			return false;
		}
		MAPADMOBLFD(JIIGOACEIKL);
		return true;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void KJPMHEABFPF(int JIIGOACEIKL)
	{
		if (!IKMGPHDNKNN.HGBOPAKJNHJ())
		{
			PipeConnectionPuzzleUI pipeConnectionPuzzleUI = PipeConnectionPuzzleUI.Get(JIIGOACEIKL);
			if ((Object)(object)pipeConnectionPuzzleUI == (Object)null)
			{
				Debug.LogError((object)("SceneReferences Start" + JIIGOACEIKL), (Object)(object)this);
				return;
			}
			IKMGPHDNKNN.FACEEDFDKKD(pipeConnectionPuzzleUI);
			DHMJIDOJJII = JIIGOACEIKL;
			pipeConnectionPuzzleUI.OpenWithPuzzle(IKMGPHDNKNN, JIIGOACEIKL);
		}
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

	public bool CFJEJFCALPM(int JIIGOACEIKL)
	{
		if (!EEKCDBMDNOG(JIIGOACEIKL))
		{
			return true;
		}
		MAPADMOBLFD(JIIGOACEIKL);
		return false;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public bool MGJJNHMOJHM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool EEKCDBMDNOG(int JIIGOACEIKL)
	{
		if ((Object)(object)IKMGPHDNKNN == (Object)null)
		{
			return false;
		}
		if (!IKMGPHDNKNN.HGBOPAKJNHJ())
		{
			return DecorationMode.KKJABELKCNM(JIIGOACEIKL).GABNNLJOMHI();
		}
		return false;
	}

	public void OnPuzzleSolved()
	{
		((MonoBehaviour)this).StartCoroutine(HHFOEMJNBKE());
	}

	public void ResetForPool()
	{
		DHMJIDOJJII = -1;
		unlockGameObject.SetActive(false);
	}

	public void Setup(MinePipePuzzle ANEDINOILOE)
	{
		IKMGPHDNKNN = ANEDINOILOE;
	}

	public void AOEOBNOPLIG(int JIIGOACEIKL)
	{
	}

	private void HCKFLMMCMIH(int JIIGOACEIKL)
	{
		if (!IKMGPHDNKNN.IsPuzzleSolved())
		{
			PipeConnectionPuzzleUI pipeConnectionPuzzleUI = PipeConnectionPuzzleUI.Get(JIIGOACEIKL);
			if ((Object)(object)pipeConnectionPuzzleUI == (Object)null)
			{
				Debug.LogError((object)("[PipePuzzleInteractable] No se encontró PipeConnectionPuzzleUI para playerNum " + JIIGOACEIKL), (Object)(object)this);
				return;
			}
			IKMGPHDNKNN.SetUI(pipeConnectionPuzzleUI);
			DHMJIDOJJII = JIIGOACEIKL;
			pipeConnectionPuzzleUI.OpenWithPuzzle(IKMGPHDNKNN, JIIGOACEIKL);
		}
	}

	public void PNFKIHGMBLG(int JIIGOACEIKL)
	{
	}

	public void CPOLPCDNPPH(int JIIGOACEIKL)
	{
	}

	private IEnumerator HHFOEMJNBKE()
	{
		yield return (object)new WaitForSeconds(EKFNOPEBCHL);
		unlockGameObject.SetActive(true);
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if ((Object)(object)IKMGPHDNKNN == (Object)null)
		{
			return false;
		}
		if (!IKMGPHDNKNN.IsPuzzleSolved())
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public void JOHOFKOAIBD(int JIIGOACEIKL)
	{
	}

	public void KMPILLCNJPC(int JIIGOACEIKL)
	{
	}

	public void GPECKPBIENC(int JIIGOACEIKL)
	{
	}

	public void FFGEMPAILHK()
	{
		unlockGameObject.SetActive(true);
	}

	public void ACODILEFHOA()
	{
		DHMJIDOJJII = -1;
		unlockGameObject.SetActive(true);
	}

	public bool JNCIONKLFBF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool OHKCPGKPDGJ(int JIIGOACEIKL)
	{
		if ((Object)(object)IKMGPHDNKNN == (Object)null)
		{
			return false;
		}
		if (!IKMGPHDNKNN.DDCOMOHHEBB())
		{
			return DecorationMode.HBDCJFLINDA(JIIGOACEIKL).IDPGEBNGDJD();
		}
		return true;
	}

	public void GLNFHGNFJME(MinePipePuzzle ANEDINOILOE)
	{
		IKMGPHDNKNN = ANEDINOILOE;
	}

	public void GJDKDDMFGBM(int JIIGOACEIKL)
	{
	}

	private void MAPADMOBLFD(int JIIGOACEIKL)
	{
		if (!IKMGPHDNKNN.APPEDHAFFBP())
		{
			PipeConnectionPuzzleUI pipeConnectionPuzzleUI = PipeConnectionPuzzleUI.Get(JIIGOACEIKL);
			if ((Object)(object)pipeConnectionPuzzleUI == (Object)null)
			{
				Debug.LogError((object)("Shield" + JIIGOACEIKL), (Object)(object)this);
				return;
			}
			IKMGPHDNKNN.FDOOLKCJLBO(pipeConnectionPuzzleUI);
			DHMJIDOJJII = JIIGOACEIKL;
			pipeConnectionPuzzleUI.MGMDKEFEBIA(IKMGPHDNKNN, JIIGOACEIKL);
		}
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool AEPCKAPLLJP(int JIIGOACEIKL)
	{
		if ((Object)(object)IKMGPHDNKNN == (Object)null)
		{
			return true;
		}
		if (!IKMGPHDNKNN.DDCOMOHHEBB())
		{
			return DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).IDPGEBNGDJD();
		}
		return false;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		HCKFLMMCMIH(JIIGOACEIKL);
		return true;
	}

	public bool BGHCJHPNKHP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool OADMPCPHMDK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!EEKCDBMDNOG(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(interactLabel));
		return false;
	}

	public void MFGCJPNCFNB(MinePipePuzzle ANEDINOILOE)
	{
		IKMGPHDNKNN = ANEDINOILOE;
	}
}
