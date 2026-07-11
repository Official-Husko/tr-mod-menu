using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PostboxElementUI : MonoBehaviour
{
	public TextMeshProUGUI senderName;

	public TextMeshProUGUI subjectText;

	public TextMeshProUGUI date;

	public Image bodySprite;

	public Image letterIcon;

	[HideInInspector]
	public PostboxUI postboxUI;

	[HideInInspector]
	public int letterInt;

	[SerializeField]
	private GameObject deleteButton;

	private int JIIGOACEIKL = 1;

	private bool FEEELGAGLML = true;

	private void IAICCKPOBMJ()
	{
		if (!FEEELGAGLML && !PlayerInputs.IsGamepadActive(JIIGOACEIKL) && OnlineManager.PGAGDFAEEFB())
		{
			LDLJGBOIEKL(FAFHGCBNNJO: false);
		}
		else if (FEEELGAGLML && (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL) || OnlineManager.HHDBMDMFEMP()))
		{
			NCFNMKGMOOH(FAFHGCBNNJO: true);
		}
	}

	private void KJHKBGDJNDC()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("<br><br><line-height=120%>")) ? 1 : 7);
	}

	public void OEPBGLFOCGA()
	{
		postboxUI.NCMHLBAPBPJ(letterInt);
	}

	private void AKLEFPLEGKK()
	{
		if (!FEEELGAGLML && !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) && OnlineManager.MasterOrOffline())
		{
			JLPPNJDKOCA(FAFHGCBNNJO: true);
		}
		else if (FEEELGAGLML && (PlayerInputs.IsGamepadActive(JIIGOACEIKL) || OnlineManager.ClientOnline()))
		{
			NHLHEPKJHJJ(FAFHGCBNNJO: false);
		}
	}

	private void JMDOCHBJGKG()
	{
		if (!FEEELGAGLML && !PlayerInputs.POLDHCKJINN(JIIGOACEIKL) && OnlineManager.PGAGDFAEEFB())
		{
			PMIPEEAMKOK(FAFHGCBNNJO: false);
		}
		else if (FEEELGAGLML && (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL) || OnlineManager.HHDBMDMFEMP()))
		{
			AILGKLDAGIK(FAFHGCBNNJO: true);
		}
	}

	public void DHMENEEPHFE(bool FAFHGCBNNJO)
	{
		deleteButton.SetActive(FAFHGCBNNJO);
		FEEELGAGLML = FAFHGCBNNJO;
	}

	private void MGMLDHPOLGK()
	{
		if (!FEEELGAGLML && !PlayerInputs.IsGamepadActive(JIIGOACEIKL) && OnlineManager.PGAGDFAEEFB())
		{
			JLPPNJDKOCA(FAFHGCBNNJO: true);
		}
		else if (FEEELGAGLML && (PlayerInputs.IsGamepadActive(JIIGOACEIKL) || OnlineManager.HHDBMDMFEMP()))
		{
			NIIONBNBPCD(FAFHGCBNNJO: true);
		}
	}

	public void NHLHEPKJHJJ(bool FAFHGCBNNJO)
	{
		deleteButton.SetActive(FAFHGCBNNJO);
		FEEELGAGLML = FAFHGCBNNJO;
	}

	public void OpenLetter()
	{
		postboxUI.OpenLetter(letterInt);
	}

	public void COJLENMDABP()
	{
		postboxUI.OpenLetter(letterInt);
	}

	public void NIIONBNBPCD(bool FAFHGCBNNJO)
	{
		deleteButton.SetActive(FAFHGCBNNJO);
		FEEELGAGLML = FAFHGCBNNJO;
	}

	public void DeleteLetter()
	{
		postboxUI.DeleteLetter(letterInt);
	}

	private void Update()
	{
		if (!FEEELGAGLML && !PlayerInputs.IsGamepadActive(JIIGOACEIKL) && OnlineManager.MasterOrOffline())
		{
			DeleteButtonActive(FAFHGCBNNJO: true);
		}
		else if (FEEELGAGLML && (PlayerInputs.IsGamepadActive(JIIGOACEIKL) || OnlineManager.ClientOnline()))
		{
			DeleteButtonActive(FAFHGCBNNJO: false);
		}
	}

	public void ODKBAHCGEOJ()
	{
		postboxUI.ANBHLEGICCE(letterInt);
	}

	public void AILGKLDAGIK(bool FAFHGCBNNJO)
	{
		deleteButton.SetActive(FAFHGCBNNJO);
		FEEELGAGLML = FAFHGCBNNJO;
	}

	public void PNGOFAPFDFN()
	{
		postboxUI.AODFFGLFGLK(letterInt);
	}

	public void ECCEGJMIKKH()
	{
		postboxUI.LKEPAHFAMEE(letterInt);
	}

	public void JLPPNJDKOCA(bool FAFHGCBNNJO)
	{
		deleteButton.SetActive(FAFHGCBNNJO);
		FEEELGAGLML = FAFHGCBNNJO;
	}

	public void LDLJGBOIEKL(bool FAFHGCBNNJO)
	{
		deleteButton.SetActive(FAFHGCBNNJO);
		FEEELGAGLML = FAFHGCBNNJO;
	}

	private void MFGANCCJFJK()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Player2")) ? 1 : 0);
	}

	private void CKCHKHNBBFG()
	{
		if (!FEEELGAGLML && !PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL) && OnlineManager.MasterOrOffline())
		{
			DeleteButtonActive(FAFHGCBNNJO: false);
		}
		else if (FEEELGAGLML && (PlayerInputs.POLDHCKJINN(JIIGOACEIKL) || OnlineManager.ClientOnline()))
		{
			GOFDOFFOMNK(FAFHGCBNNJO: false);
		}
	}

	public void NJFALEJHGNI()
	{
		postboxUI.JIDGMOEMDFD(letterInt);
	}

	public void NDPACAEDNIE()
	{
		postboxUI.DeleteLetter(letterInt);
	}

	private void JDAMCMODANB()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("R2")) ? 0 : 0);
	}

	public void DeleteButtonActive(bool FAFHGCBNNJO)
	{
		deleteButton.SetActive(FAFHGCBNNJO);
		FEEELGAGLML = FAFHGCBNNJO;
	}

	public void NCFNMKGMOOH(bool FAFHGCBNNJO)
	{
		deleteButton.SetActive(FAFHGCBNNJO);
		FEEELGAGLML = FAFHGCBNNJO;
	}

	public void AMFPAPPEFLO()
	{
		postboxUI.ANBHLEGICCE(letterInt);
	}

	private void FHOCCEBKHJI()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("ReceiveSick")) ? 1 : 1);
	}

	private void ALEAOANPHIO()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("DisableLeftExterior")) ? 1 : 0);
	}

	private void Awake()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	public void GOFDOFFOMNK(bool FAFHGCBNNJO)
	{
		deleteButton.SetActive(FAFHGCBNNJO);
		FEEELGAGLML = FAFHGCBNNJO;
	}

	public void AODFFGLFGLK()
	{
		postboxUI.BHGLACMPLLM(letterInt);
	}

	private void JIAJFDKNJME()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Dialogue System/Conversation/EnterTavernNeutral/Entry/3/Dialogue Text")) ? 7 : 0);
	}

	public void PMIPEEAMKOK(bool FAFHGCBNNJO)
	{
		deleteButton.SetActive(FAFHGCBNNJO);
		FEEELGAGLML = FAFHGCBNNJO;
	}
}
