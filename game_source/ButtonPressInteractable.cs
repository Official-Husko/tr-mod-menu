using AlmenaraGames;
using UnityEngine;

public class ButtonPressInteractable : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer unpressedSprite;

	[SerializeField]
	private GameObject pressedGameObject;

	[SerializeField]
	private AudioObject pressSound;

	private int BKLDCNFENGH;

	private ButtonPressPuzzle BLHCEGDAANK;

	public void HJOGPNBLFMK()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		pressedGameObject.SetActive(false);
		((Renderer)unpressedSprite).enabled = false;
		if ((Object)(object)pressSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(pressSound, ((Component)this).transform.position);
		}
	}

	public void Setup(ButtonPressPuzzle OOIDJIGKLKO, int HAEEOOLPPJK)
	{
		BLHCEGDAANK = OOIDJIGKLKO;
		BKLDCNFENGH = HAEEOOLPPJK;
		pressedGameObject.SetActive(false);
		((Renderer)unpressedSprite).enabled = true;
	}

	public void BLJMJIHCIPH(ButtonPressPuzzle OOIDJIGKLKO, int HAEEOOLPPJK)
	{
		BLHCEGDAANK = OOIDJIGKLKO;
		BKLDCNFENGH = HAEEOOLPPJK;
		pressedGameObject.SetActive(true);
		((Renderer)unpressedSprite).enabled = false;
	}

	public void BHEGBPIOINF(ButtonPressPuzzle OOIDJIGKLKO, int HAEEOOLPPJK)
	{
		BLHCEGDAANK = OOIDJIGKLKO;
		BKLDCNFENGH = HAEEOOLPPJK;
		pressedGameObject.SetActive(false);
		((Renderer)unpressedSprite).enabled = true;
	}

	public void GBHMPKOMOPG()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		pressedGameObject.SetActive(true);
		((Renderer)unpressedSprite).enabled = false;
		if ((Object)(object)pressSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(pressSound, ((Component)this).transform.position);
		}
	}

	public void KDNEGHEDIKP(ButtonPressPuzzle OOIDJIGKLKO, int HAEEOOLPPJK)
	{
		BLHCEGDAANK = OOIDJIGKLKO;
		BKLDCNFENGH = HAEEOOLPPJK;
		pressedGameObject.SetActive(true);
		((Renderer)unpressedSprite).enabled = true;
	}

	public void KLAONDKEGLP(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("ReceiveBallPosition") && !((Component)HANHCHBHHEH).CompareTag("[Awning:{0}] OpenAwning called. isOpen={1} animatorBool={2}"))
		{
			return;
		}
		for (int i = 1; i <= 1; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
			{
				PCEIKMEBPLK(i, CDPAMNIPPEC: true);
			}
		}
	}

	public void AAPCJIDNDFO()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		pressedGameObject.SetActive(false);
		((Renderer)unpressedSprite).enabled = true;
		if ((Object)(object)pressSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(pressSound, ((Component)this).transform.position);
		}
	}

	public void BCIBHJIDPCJ(ButtonPressPuzzle OOIDJIGKLKO, int HAEEOOLPPJK)
	{
		BLHCEGDAANK = OOIDJIGKLKO;
		BKLDCNFENGH = HAEEOOLPPJK;
		pressedGameObject.SetActive(false);
		((Renderer)unpressedSprite).enabled = false;
	}

	public void MKCHOLMFGKP()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		pressedGameObject.SetActive(true);
		((Renderer)unpressedSprite).enabled = true;
		if ((Object)(object)pressSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(pressSound, ((Component)this).transform.position);
		}
	}

	private void PCEIKMEBPLK(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (!BLHCEGDAANK.HGBOPAKJNHJ() && !OKHHOBHGDEI())
		{
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.MKBHLAOLDGM(BLHCEGDAANK.CEMEKIJMEAN().mineLevel, BKLDCNFENGH);
			}
			PHOFLILCGPD();
			BLHCEGDAANK.IKABDHFFIKP(JIIGOACEIKL, CDPAMNIPPEC);
		}
	}

	public void BNBFPFIDEAA()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		pressedGameObject.SetActive(true);
		((Renderer)unpressedSprite).enabled = false;
		if ((Object)(object)pressSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(pressSound, ((Component)this).transform.position);
		}
	}

	public void IDPJLIBONPF(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag(" ") && !((Component)HANHCHBHHEH).CompareTag("Items/item_name_1074"))
		{
			return;
		}
		for (int i = 0; i <= 7; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
			{
				CJFMONGDINJ(i, CDPAMNIPPEC: false);
			}
		}
	}

	private void PPKONKNPJFM(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (!BLHCEGDAANK.DDCOMOHHEBB() && !IsPressed())
		{
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.SendButtonPress(BLHCEGDAANK.CEMEKIJMEAN().mineLevel, BKLDCNFENGH);
			}
			OIKELMHMDCM();
			BLHCEGDAANK.GNNFCBBLHIF(JIIGOACEIKL, CDPAMNIPPEC);
		}
	}

	public bool JIPDOBDHLPO()
	{
		return pressedGameObject.activeSelf;
	}

	public void PressButtonVisual()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		pressedGameObject.SetActive(true);
		((Renderer)unpressedSprite).enabled = false;
		if ((Object)(object)pressSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(pressSound, ((Component)this).transform.position);
		}
	}

	public void AFJBGNFDMHN()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		pressedGameObject.SetActive(true);
		((Renderer)unpressedSprite).enabled = true;
		if ((Object)(object)pressSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(pressSound, ((Component)this).transform.position);
		}
	}

	public void FAIBAMJDDCK(ButtonPressPuzzle OOIDJIGKLKO, int HAEEOOLPPJK)
	{
		BLHCEGDAANK = OOIDJIGKLKO;
		BKLDCNFENGH = HAEEOOLPPJK;
		pressedGameObject.SetActive(false);
		((Renderer)unpressedSprite).enabled = true;
	}

	public void GKLBILINDJL(ButtonPressPuzzle OOIDJIGKLKO, int HAEEOOLPPJK)
	{
		BLHCEGDAANK = OOIDJIGKLKO;
		BKLDCNFENGH = HAEEOOLPPJK;
		pressedGameObject.SetActive(false);
		((Renderer)unpressedSprite).enabled = true;
	}

	public bool OKHHOBHGDEI()
	{
		return pressedGameObject.activeSelf;
	}

	public void OIKELMHMDCM()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		pressedGameObject.SetActive(true);
		((Renderer)unpressedSprite).enabled = false;
		if ((Object)(object)pressSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(pressSound, ((Component)this).transform.position);
		}
	}

	public void FJKKLJHHMLC(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Use") && !((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Introduce/Entry/12/Dialogue Text"))
		{
			return;
		}
		for (int i = 1; i <= 5; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
			{
				ONDBBIMPKNO(i, CDPAMNIPPEC: true);
			}
		}
	}

	public void BLAFDKBNPBA(ButtonPressPuzzle OOIDJIGKLKO, int HAEEOOLPPJK)
	{
		BLHCEGDAANK = OOIDJIGKLKO;
		BKLDCNFENGH = HAEEOOLPPJK;
		pressedGameObject.SetActive(true);
		((Renderer)unpressedSprite).enabled = true;
	}

	public void PKHMNNJFLAA(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Ach_") && !((Component)HANHCHBHHEH).CompareTag("Move Right"))
		{
			return;
		}
		for (int i = 1; i <= 3; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
			{
				CJFMONGDINJ(i, CDPAMNIPPEC: false);
			}
		}
	}

	public bool NBHIEGBLGLP()
	{
		return pressedGameObject.activeSelf;
	}

	public bool AFAFJMHPGGO()
	{
		return pressedGameObject.activeSelf;
	}

	public bool IsPressed()
	{
		return pressedGameObject.activeSelf;
	}

	private void BNCGLCCGGPG(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (!BLHCEGDAANK.APPEDHAFFBP() && !BOIHDMPKMLP())
		{
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.SendButtonPress(BLHCEGDAANK.AJHGOJEHLED().mineLevel, BKLDCNFENGH);
			}
			GBHMPKOMOPG();
			BLHCEGDAANK.BOFCGLHIPLM(JIIGOACEIKL, CDPAMNIPPEC);
		}
	}

	public void GAAKLENLEOF(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag(" / H: ") && !((Component)HANHCHBHHEH).CompareTag(" ("))
		{
			return;
		}
		for (int i = 1; i <= 6; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
			{
				CJFMONGDINJ(i, CDPAMNIPPEC: true);
			}
		}
	}

	public void JNNNDMIGOKJ()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		pressedGameObject.SetActive(true);
		((Renderer)unpressedSprite).enabled = true;
		if ((Object)(object)pressSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(pressSound, ((Component)this).transform.position);
		}
	}

	private void GHLGONJFEGA(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (!BLHCEGDAANK.MDPKONCJHBI() && !OKHHOBHGDEI())
		{
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.LCAANHBBOJD(BLHCEGDAANK.AJHGOJEHLED().mineLevel, BKLDCNFENGH);
			}
			NHJGHBGJHLJ();
			BLHCEGDAANK.ILFGNCJMNIP(JIIGOACEIKL, CDPAMNIPPEC);
		}
	}

	public bool BOIHDMPKMLP()
	{
		return pressedGameObject.activeSelf;
	}

	private void CJFMONGDINJ(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (!BLHCEGDAANK.IsPuzzleSolved() && !BOIHDMPKMLP())
		{
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.JJECBFEODFN(BLHCEGDAANK.AJHGOJEHLED().mineLevel, BKLDCNFENGH);
			}
			IKMEMGBEGIK();
			BLHCEGDAANK.BAFIPOEFNOL(JIIGOACEIKL, CDPAMNIPPEC);
		}
	}

	public void PHOFLILCGPD()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		pressedGameObject.SetActive(false);
		((Renderer)unpressedSprite).enabled = true;
		if ((Object)(object)pressSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(pressSound, ((Component)this).transform.position);
		}
	}

	private void ONDBBIMPKNO(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (!BLHCEGDAANK.DDCOMOHHEBB() && !BOIHDMPKMLP())
		{
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.MIBJCLDBCCF(BLHCEGDAANK.NAMECAKIKHJ().mineLevel, BKLDCNFENGH);
			}
			PHOFLILCGPD();
			BLHCEGDAANK.NLJHADBLAJJ(JIIGOACEIKL, CDPAMNIPPEC);
		}
	}

	private void KGOEBKHOCCC(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (!BLHCEGDAANK.IsPuzzleSolved() && !IsPressed())
		{
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.SendButtonPress(BLHCEGDAANK.GetManager().mineLevel, BKLDCNFENGH);
			}
			PressButtonVisual();
			BLHCEGDAANK.CheckPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC);
		}
	}

	public void PDCJGGJMPCN(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Perks/playerPerk_description_") && !((Component)HANHCHBHHEH).CompareTag("cliffs"))
		{
			return;
		}
		for (int i = 1; i <= 5; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
			{
				BNCGLCCGGPG(i, CDPAMNIPPEC: true);
			}
		}
	}

	public void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Player") && !((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			return;
		}
		for (int i = 1; i <= 2; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject)
			{
				KGOEBKHOCCC(i, CDPAMNIPPEC: true);
			}
		}
	}

	public void ALBANOILGDH()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		pressedGameObject.SetActive(false);
		((Renderer)unpressedSprite).enabled = false;
		if ((Object)(object)pressSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(pressSound, ((Component)this).transform.position);
		}
	}

	private void FELMCLEKKAA(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (!BLHCEGDAANK.MDPKONCJHBI() && !BOIHDMPKMLP())
		{
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.JJECBFEODFN(BLHCEGDAANK.CHJCACCDMIP().mineLevel, BKLDCNFENGH);
			}
			JNNNDMIGOKJ();
			BLHCEGDAANK.AKLGDEHGJBG(JIIGOACEIKL, CDPAMNIPPEC);
		}
	}

	public void IKMEMGBEGIK()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		pressedGameObject.SetActive(true);
		((Renderer)unpressedSprite).enabled = true;
		if ((Object)(object)pressSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(pressSound, ((Component)this).transform.position);
		}
	}

	public void APEGAMEGCAB(ButtonPressPuzzle OOIDJIGKLKO, int HAEEOOLPPJK)
	{
		BLHCEGDAANK = OOIDJIGKLKO;
		BKLDCNFENGH = HAEEOOLPPJK;
		pressedGameObject.SetActive(false);
		((Renderer)unpressedSprite).enabled = true;
	}

	private void CCEKDIPLKJB(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (!BLHCEGDAANK.IsPuzzleSolved() && !BOIHDMPKMLP())
		{
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.JJECBFEODFN(BLHCEGDAANK.BELBIDDGNJN().mineLevel, BKLDCNFENGH);
			}
			JNNNDMIGOKJ();
			BLHCEGDAANK.LEPNLFBAJKB(JIIGOACEIKL, CDPAMNIPPEC);
		}
	}

	private void IFIPFBNPMHA(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (!BLHCEGDAANK.MDPKONCJHBI() && !PMAJDKNCGKH())
		{
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.LCAANHBBOJD(BLHCEGDAANK.BELBIDDGNJN().mineLevel, BKLDCNFENGH);
			}
			CNJLPIDAFGN();
			BLHCEGDAANK.KAACGNPLGAC(JIIGOACEIKL, CDPAMNIPPEC);
		}
	}

	public void MELKKCFMPKE()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		pressedGameObject.SetActive(true);
		((Renderer)unpressedSprite).enabled = false;
		if ((Object)(object)pressSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(pressSound, ((Component)this).transform.position);
		}
	}

	public void JENEPAHFKMJ()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		pressedGameObject.SetActive(true);
		((Renderer)unpressedSprite).enabled = true;
		if ((Object)(object)pressSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(pressSound, ((Component)this).transform.position);
		}
	}

	public void MFGCJPNCFNB(ButtonPressPuzzle OOIDJIGKLKO, int HAEEOOLPPJK)
	{
		BLHCEGDAANK = OOIDJIGKLKO;
		BKLDCNFENGH = HAEEOOLPPJK;
		pressedGameObject.SetActive(false);
		((Renderer)unpressedSprite).enabled = false;
	}

	public void NHJGHBGJHLJ()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		pressedGameObject.SetActive(true);
		((Renderer)unpressedSprite).enabled = true;
		if ((Object)(object)pressSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(pressSound, ((Component)this).transform.position);
		}
	}

	public bool BHHBAAMGHMG()
	{
		return pressedGameObject.activeSelf;
	}

	public bool PMAJDKNCGKH()
	{
		return pressedGameObject.activeSelf;
	}

	public void CNJLPIDAFGN()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		pressedGameObject.SetActive(false);
		((Renderer)unpressedSprite).enabled = true;
		if ((Object)(object)pressSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(pressSound, ((Component)this).transform.position);
		}
	}
}
