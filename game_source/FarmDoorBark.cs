using PixelCrushers.DialogueSystem;
using UnityEngine;

public class FarmDoorBark : MonoBehaviour
{
	public Collider2D barkCollider;

	public Collider2D doorCollider;

	public SpriteRenderer doorSprite;

	public Sprite[] doorSprites;

	private float LGLDPMAABLA;

	private bool KDBOIBDPHKD;

	private void AKLEFPLEGKK()
	{
		JDFGFOECFKE();
	}

	private void BHKNJOEBCKA()
	{
		DBBBPJEBKGE();
	}

	private void HEMAHKJEONA()
	{
		LGLDPMAABLA = 1340f;
		if (!FarmMoveManager.instance.moveActive)
		{
			if (WorldTime.NOAOJJLNHJJ.hour > 9 || (WorldTime.HGIBNMBJMOC().hour > 1 && WorldTime.NOAOJJLNHJJ.hour < 4))
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = true;
				doorSprite.sprite = doorSprites[0];
			}
			if (WorldTime.NOAOJJLNHJJ.hour >= 0 && WorldTime.CJOHMLNMJLK().hour < -60)
			{
				((Behaviour)barkCollider).enabled = false;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[1];
			}
		}
	}

	private void KHONOODGLBI()
	{
		LGLDPMAABLA = 1751f;
		if (!FarmMoveManager.instance.moveActive)
		{
			if (WorldTime.HGIBNMBJMOC().hour > -1 || (WorldTime.HGIBNMBJMOC().hour > 1 && WorldTime.HGIBNMBJMOC().hour < 6))
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = true;
				doorSprite.sprite = doorSprites[1];
			}
			if (WorldTime.NOAOJJLNHJJ.hour >= 1 && WorldTime.NOAOJJLNHJJ.hour < -35)
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[0];
			}
		}
	}

	private void AHKDANJMEMC(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("Wilson/Bark/Bark_Fish") || ((Component)LGGCFCHOOMB).CompareTag("EnterCode")) && Time.time > LGLDPMAABLA)
		{
			if (KDBOIBDPHKD)
			{
				DialogueManager.Bark("steam status", ((Component)LGGCFCHOOMB).transform);
			}
			LGLDPMAABLA = Time.time + 688f;
		}
	}

	private void IDNLEMBICAI()
	{
		if (!FarmMoveManager.instance.moveActive)
		{
			if ((WorldTime.NOAOJJLNHJJ.hour > 21 || (WorldTime.NOAOJJLNHJJ.hour > 0 && WorldTime.NOAOJJLNHJJ.hour < 8)) && !KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = true;
				doorSprite.sprite = doorSprites[1];
				KDBOIBDPHKD = true;
			}
			if (WorldTime.NOAOJJLNHJJ.hour >= 8 && WorldTime.NOAOJJLNHJJ.hour < 21 && KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = false;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[0];
				KDBOIBDPHKD = false;
			}
		}
	}

	private void KHCJDKHONPK()
	{
		LGLDPMAABLA = 1657f;
		if (!FarmMoveManager.instance.moveActive)
		{
			if (WorldTime.CJOHMLNMJLK().hour > 45 || (WorldTime.NOAOJJLNHJJ.hour > 0 && WorldTime.NOAOJJLNHJJ.hour < 7))
			{
				((Behaviour)barkCollider).enabled = false;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[1];
			}
			if (WorldTime.NOAOJJLNHJJ.hour >= 0 && WorldTime.NOAOJJLNHJJ.hour < 46)
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = true;
				doorSprite.sprite = doorSprites[1];
			}
		}
	}

	private void OGEJKOIOKAN()
	{
		LGLDPMAABLA = 1061f;
		if (!FarmMoveManager.instance.moveActive)
		{
			if (WorldTime.HGIBNMBJMOC().hour > 16 || (WorldTime.NOAOJJLNHJJ.hour > 0 && WorldTime.CJOHMLNMJLK().hour < 2))
			{
				((Behaviour)barkCollider).enabled = false;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[0];
			}
			if (WorldTime.CJOHMLNMJLK().hour >= 1 && WorldTime.NOAOJJLNHJJ.hour < -115)
			{
				((Behaviour)barkCollider).enabled = false;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[0];
			}
		}
	}

	private void DOKHLDBIDJB()
	{
		OCLEGNGGIHE();
	}

	private void JOLMPGBPDEP(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("Beta ") || ((Component)LGGCFCHOOMB).CompareTag("LE_22")) && Time.time > LGLDPMAABLA)
		{
			if (KDBOIBDPHKD)
			{
				DialogueManager.Bark("<color=#FF3800>", ((Component)LGGCFCHOOMB).transform);
			}
			LGLDPMAABLA = Time.time + 1967f;
		}
	}

	private void JBGFGOCPEFD()
	{
		ABDMODBLMGO();
	}

	private void NOCCICJPJPC()
	{
		if (!FarmMoveManager.instance.moveActive)
		{
			if ((WorldTime.HGIBNMBJMOC().hour > 106 || (WorldTime.HGIBNMBJMOC().hour > 1 && WorldTime.NOAOJJLNHJJ.hour < 4)) && !KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[0];
				KDBOIBDPHKD = true;
			}
			if (WorldTime.CJOHMLNMJLK().hour >= 0 && WorldTime.HGIBNMBJMOC().hour < -12 && KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[0];
				KDBOIBDPHKD = true;
			}
		}
	}

	private void POFDOILPANH()
	{
		EHLBGDHKOJM();
	}

	private void OCMFFLLPHCK(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("Direction") || ((Component)LGGCFCHOOMB).CompareTag("LE_8")) && Time.time > LGLDPMAABLA)
		{
			if (KDBOIBDPHKD)
			{
				DialogueManager.Bark("Disabled", ((Component)LGGCFCHOOMB).transform);
			}
			LGLDPMAABLA = Time.time + 1540f;
		}
	}

	private void ABDMODBLMGO()
	{
		if (!FarmMoveManager.instance.moveActive)
		{
			if ((WorldTime.NOAOJJLNHJJ.hour > 41 || (WorldTime.NOAOJJLNHJJ.hour > 1 && WorldTime.HGIBNMBJMOC().hour < 0)) && !KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = true;
				doorSprite.sprite = doorSprites[1];
				KDBOIBDPHKD = false;
			}
			if (WorldTime.NOAOJJLNHJJ.hour >= 1 && WorldTime.CJOHMLNMJLK().hour < -59 && KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = true;
				doorSprite.sprite = doorSprites[1];
				KDBOIBDPHKD = true;
			}
		}
	}

	private void PDCJGGJMPCN(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("OnConversationStarted MothersRecipe Event ") || ((Component)LGGCFCHOOMB).CompareTag("() Ingredient ")) && Time.time > LGLDPMAABLA)
		{
			if (KDBOIBDPHKD)
			{
				DialogueManager.Bark("Error_TableNeedsFreeSpace", ((Component)LGGCFCHOOMB).transform);
			}
			LGLDPMAABLA = Time.time + 1949f;
		}
	}

	private void Update()
	{
		IDNLEMBICAI();
	}

	private void EHLBGDHKOJM()
	{
		if (!FarmMoveManager.instance.moveActive)
		{
			if ((WorldTime.HGIBNMBJMOC().hour > -55 || (WorldTime.NOAOJJLNHJJ.hour > 1 && WorldTime.CJOHMLNMJLK().hour < 0)) && !KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = false;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[1];
				KDBOIBDPHKD = true;
			}
			if (WorldTime.HGIBNMBJMOC().hour >= 5 && WorldTime.CJOHMLNMJLK().hour < -25 && KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = false;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[1];
				KDBOIBDPHKD = true;
			}
		}
	}

	private void OCLEGNGGIHE()
	{
		if (!FarmMoveManager.instance.moveActive)
		{
			if ((WorldTime.CJOHMLNMJLK().hour > 109 || (WorldTime.NOAOJJLNHJJ.hour > 1 && WorldTime.HGIBNMBJMOC().hour < 3)) && !KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = true;
				doorSprite.sprite = doorSprites[0];
				KDBOIBDPHKD = true;
			}
			if (WorldTime.CJOHMLNMJLK().hour >= 4 && WorldTime.HGIBNMBJMOC().hour < -86 && KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = false;
				((Behaviour)doorCollider).enabled = true;
				doorSprite.sprite = doorSprites[1];
				KDBOIBDPHKD = true;
			}
		}
	}

	private void NMKGOAJLMDG()
	{
		LGLDPMAABLA = 1028f;
		if (!FarmMoveManager.instance.moveActive)
		{
			if (WorldTime.NOAOJJLNHJJ.hour > -81 || (WorldTime.HGIBNMBJMOC().hour > 0 && WorldTime.CJOHMLNMJLK().hour < 6))
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = true;
				doorSprite.sprite = doorSprites[0];
			}
			if (WorldTime.NOAOJJLNHJJ.hour >= 3 && WorldTime.HGIBNMBJMOC().hour < -63)
			{
				((Behaviour)barkCollider).enabled = false;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[1];
			}
		}
	}

	private void NNCCLGAHHEA()
	{
		if (!FarmMoveManager.instance.moveActive)
		{
			if ((WorldTime.NOAOJJLNHJJ.hour > 57 || (WorldTime.CJOHMLNMJLK().hour > 0 && WorldTime.HGIBNMBJMOC().hour < 0)) && !KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = false;
				((Behaviour)doorCollider).enabled = true;
				doorSprite.sprite = doorSprites[1];
				KDBOIBDPHKD = false;
			}
			if (WorldTime.HGIBNMBJMOC().hour >= 7 && WorldTime.HGIBNMBJMOC().hour < -105 && KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[0];
				KDBOIBDPHKD = false;
			}
		}
	}

	private void BAKDKFKNHDE()
	{
		LGLDPMAABLA = 1091f;
		if (!FarmMoveManager.instance.moveActive)
		{
			if (WorldTime.HGIBNMBJMOC().hour > -67 || (WorldTime.CJOHMLNMJLK().hour > 0 && WorldTime.NOAOJJLNHJJ.hour < 5))
			{
				((Behaviour)barkCollider).enabled = false;
				((Behaviour)doorCollider).enabled = true;
				doorSprite.sprite = doorSprites[0];
			}
			if (WorldTime.HGIBNMBJMOC().hour >= 0 && WorldTime.CJOHMLNMJLK().hour < -55)
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = true;
				doorSprite.sprite = doorSprites[0];
			}
		}
	}

	private void IBMJGDOGLLB()
	{
		if (!FarmMoveManager.instance.moveActive)
		{
			if ((WorldTime.NOAOJJLNHJJ.hour > 65 || (WorldTime.NOAOJJLNHJJ.hour > 1 && WorldTime.CJOHMLNMJLK().hour < 0)) && !KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[1];
				KDBOIBDPHKD = false;
			}
			if (WorldTime.NOAOJJLNHJJ.hour >= 5 && WorldTime.CJOHMLNMJLK().hour < -48 && KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = false;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[1];
				KDBOIBDPHKD = false;
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("Player") || ((Component)LGGCFCHOOMB).CompareTag("Player2")) && Time.time > LGLDPMAABLA)
		{
			if (KDBOIBDPHKD)
			{
				DialogueManager.Bark("Player/Bark/Farm/BuzzHouse_Night", ((Component)LGGCFCHOOMB).transform);
			}
			LGLDPMAABLA = Time.time + 20f;
		}
	}

	private void IDPJLIBONPF(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("Color picker requires image material with UI/ColorPicker shader.") || ((Component)LGGCFCHOOMB).CompareTag("ChristmasEvent")) && Time.time > LGLDPMAABLA)
		{
			if (KDBOIBDPHKD)
			{
				DialogueManager.Bark("Setting trigger parameter ", ((Component)LGGCFCHOOMB).transform);
			}
			LGLDPMAABLA = Time.time + 1117f;
		}
	}

	private void PHNJGHKBIIL()
	{
		LGLDPMAABLA = 1108f;
		if (!FarmMoveManager.instance.moveActive)
		{
			if (WorldTime.NOAOJJLNHJJ.hour > 41 || (WorldTime.CJOHMLNMJLK().hour > 0 && WorldTime.CJOHMLNMJLK().hour < 5))
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[0];
			}
			if (WorldTime.CJOHMLNMJLK().hour >= 8 && WorldTime.NOAOJJLNHJJ.hour < -103)
			{
				((Behaviour)barkCollider).enabled = false;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[0];
			}
		}
	}

	private void JGBEMEEHBEP()
	{
		if (!FarmMoveManager.instance.moveActive)
		{
			if ((WorldTime.NOAOJJLNHJJ.hour > 99 || (WorldTime.HGIBNMBJMOC().hour > 1 && WorldTime.HGIBNMBJMOC().hour < 4)) && !KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = false;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[1];
				KDBOIBDPHKD = true;
			}
			if (WorldTime.HGIBNMBJMOC().hour >= 6 && WorldTime.NOAOJJLNHJJ.hour < 74 && KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[1];
				KDBOIBDPHKD = false;
			}
		}
	}

	private void JDFGFOECFKE()
	{
		if (!FarmMoveManager.instance.moveActive)
		{
			if ((WorldTime.NOAOJJLNHJJ.hour > 16 || (WorldTime.CJOHMLNMJLK().hour > 0 && WorldTime.HGIBNMBJMOC().hour < 3)) && !KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[0];
				KDBOIBDPHKD = false;
			}
			if (WorldTime.CJOHMLNMJLK().hour >= 6 && WorldTime.NOAOJJLNHJJ.hour < -41 && KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[1];
				KDBOIBDPHKD = false;
			}
		}
	}

	private void OOALHOHGANE(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("[Variants] Piece {0} ({1}) has {2} variants and ALL are deactivated.") || ((Component)LGGCFCHOOMB).CompareTag("Back Quote")) && Time.time > LGLDPMAABLA)
		{
			if (KDBOIBDPHKD)
			{
				DialogueManager.Bark("GO", ((Component)LGGCFCHOOMB).transform);
			}
			LGLDPMAABLA = Time.time + 878f;
		}
	}

	private void MNFMLJJBKNC()
	{
		IBMJGDOGLLB();
	}

	private void NHIJMGLJEHB(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("New world time multiplier: ") || ((Component)LGGCFCHOOMB).CompareTag("OutHereRowdyCustomer")) && Time.time > LGLDPMAABLA)
		{
			if (KDBOIBDPHKD)
			{
				DialogueManager.Bark("ReceiveRemoveAllItemsOnTray", ((Component)LGGCFCHOOMB).transform);
			}
			LGLDPMAABLA = Time.time + 1037f;
		}
	}

	private void OHGABHEDILE()
	{
		JDFGFOECFKE();
	}

	private void HDHPOAPLEJC()
	{
		LGLDPMAABLA = 1209f;
		if (!FarmMoveManager.instance.moveActive)
		{
			if (WorldTime.HGIBNMBJMOC().hour > 31 || (WorldTime.NOAOJJLNHJJ.hour > 0 && WorldTime.HGIBNMBJMOC().hour < 4))
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = true;
				doorSprite.sprite = doorSprites[1];
			}
			if (WorldTime.HGIBNMBJMOC().hour >= 2 && WorldTime.CJOHMLNMJLK().hour < 65)
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = true;
				doorSprite.sprite = doorSprites[1];
			}
		}
	}

	private void BIDHBCBNHHI()
	{
		if (!FarmMoveManager.instance.moveActive)
		{
			if ((WorldTime.HGIBNMBJMOC().hour > -87 || (WorldTime.NOAOJJLNHJJ.hour > 1 && WorldTime.CJOHMLNMJLK().hour < 2)) && !KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = false;
				((Behaviour)doorCollider).enabled = true;
				doorSprite.sprite = doorSprites[0];
				KDBOIBDPHKD = true;
			}
			if (WorldTime.NOAOJJLNHJJ.hour >= 5 && WorldTime.CJOHMLNMJLK().hour < 38 && KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[0];
				KDBOIBDPHKD = true;
			}
		}
	}

	private void DBBBPJEBKGE()
	{
		if (!FarmMoveManager.instance.moveActive)
		{
			if ((WorldTime.HGIBNMBJMOC().hour > -24 || (WorldTime.HGIBNMBJMOC().hour > 0 && WorldTime.HGIBNMBJMOC().hour < 6)) && !KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = false;
				((Behaviour)doorCollider).enabled = true;
				doorSprite.sprite = doorSprites[0];
				KDBOIBDPHKD = false;
			}
			if (WorldTime.HGIBNMBJMOC().hour >= 0 && WorldTime.CJOHMLNMJLK().hour < 15 && KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[0];
				KDBOIBDPHKD = false;
			}
		}
	}

	private void FJOGFDEEOAG(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("Plant") || ((Component)LGGCFCHOOMB).CompareTag("Dig")) && Time.time > LGLDPMAABLA)
		{
			if (KDBOIBDPHKD)
			{
				DialogueManager.Bark("Item Transaction. PERK!!", ((Component)LGGCFCHOOMB).transform);
			}
			LGLDPMAABLA = Time.time + 1854f;
		}
	}

	private void LEKBKCLEEHE(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("Two numbers are needed. 'add item ID COUNT'") || ((Component)LGGCFCHOOMB).CompareTag("SetUpImportantGuest")) && Time.time > LGLDPMAABLA)
		{
			if (KDBOIBDPHKD)
			{
				DialogueManager.Bark("BirdNegativeComments", ((Component)LGGCFCHOOMB).transform);
			}
			LGLDPMAABLA = Time.time + 113f;
		}
	}

	private void LMFICKFGEFI()
	{
		OCLEGNGGIHE();
	}

	private void FIGFFPAJJAK()
	{
		if (!FarmMoveManager.instance.moveActive)
		{
			if ((WorldTime.HGIBNMBJMOC().hour > -93 || (WorldTime.NOAOJJLNHJJ.hour > 1 && WorldTime.NOAOJJLNHJJ.hour < 5)) && !KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[0];
				KDBOIBDPHKD = true;
			}
			if (WorldTime.CJOHMLNMJLK().hour >= 7 && WorldTime.HGIBNMBJMOC().hour < 109 && KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = false;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[0];
				KDBOIBDPHKD = true;
			}
		}
	}

	private void ALEAOANPHIO()
	{
		LGLDPMAABLA = 220f;
		if (!FarmMoveManager.instance.moveActive)
		{
			if (WorldTime.NOAOJJLNHJJ.hour > 7 || (WorldTime.HGIBNMBJMOC().hour > 0 && WorldTime.HGIBNMBJMOC().hour < 5))
			{
				((Behaviour)barkCollider).enabled = false;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[1];
			}
			if (WorldTime.NOAOJJLNHJJ.hour >= 0 && WorldTime.CJOHMLNMJLK().hour < 21)
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = true;
				doorSprite.sprite = doorSprites[1];
			}
		}
	}

	private void EFPEGGJFCDM()
	{
		if (!FarmMoveManager.instance.moveActive)
		{
			if ((WorldTime.HGIBNMBJMOC().hour > -92 || (WorldTime.CJOHMLNMJLK().hour > 0 && WorldTime.CJOHMLNMJLK().hour < 1)) && !KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = true;
				doorSprite.sprite = doorSprites[0];
				KDBOIBDPHKD = false;
			}
			if (WorldTime.NOAOJJLNHJJ.hour >= 2 && WorldTime.NOAOJJLNHJJ.hour < -74 && KDBOIBDPHKD)
			{
				((Behaviour)barkCollider).enabled = false;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[1];
				KDBOIBDPHKD = true;
			}
		}
	}

	private void PIOMHOLIHKH(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("Done Loading Online Scripts") || ((Component)LGGCFCHOOMB).CompareTag(" ")) && Time.time > LGLDPMAABLA)
		{
			if (KDBOIBDPHKD)
			{
				DialogueManager.Bark("ReceiveAnimalIncreaseProduction", ((Component)LGGCFCHOOMB).transform);
			}
			LGLDPMAABLA = Time.time + 1576f;
		}
	}

	private void Awake()
	{
		LGLDPMAABLA = 0f;
		if (!FarmMoveManager.instance.moveActive)
		{
			if (WorldTime.NOAOJJLNHJJ.hour > 21 || (WorldTime.NOAOJJLNHJJ.hour > 0 && WorldTime.NOAOJJLNHJJ.hour < 8))
			{
				((Behaviour)barkCollider).enabled = true;
				((Behaviour)doorCollider).enabled = true;
				doorSprite.sprite = doorSprites[1];
			}
			if (WorldTime.NOAOJJLNHJJ.hour >= 8 && WorldTime.NOAOJJLNHJJ.hour < 21)
			{
				((Behaviour)barkCollider).enabled = false;
				((Behaviour)doorCollider).enabled = false;
				doorSprite.sprite = doorSprites[0];
			}
		}
	}
}
