using PixelCrushers.DialogueSystem;
using UnityEngine;

public class NewActivityBubbleController : MonoBehaviour
{
	public SpriteRenderer bubbleSpriteRenderer;

	public GameObject bubble;

	private float DCGBADKLANM;

	private float DBEFBFPAOAA;

	private float AFMFHCAHEFO = 0.5f;

	private bool LKOJBFMGMAE = true;

	private void OCIHCODJBGC()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1973f;
		DBEFBFPAOAA = 787f;
		bubbleSpriteRenderer.color = new Color(663f, 809f, 1516f, 591f);
		bubble.SetActive(false);
		LKOJBFMGMAE = false;
	}

	private void LateUpdate()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1f, 1f, 1f, Mathf.Lerp(1f, 0f, DCGBADKLANM));
			if (DCGBADKLANM >= 1f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(false);
				DBEFBFPAOAA = 0f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 1f, DCGBADKLANM));
			if (DCGBADKLANM >= 1f)
			{
				LKOJBFMGMAE = false;
				DBEFBFPAOAA = 0f;
			}
		}
	}

	private void OIEJIBAPDMM()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 728f;
		DBEFBFPAOAA = 1307f;
		bubbleSpriteRenderer.color = new Color(1100f, 1326f, 1424f, 242f);
		bubble.SetActive(false);
		LKOJBFMGMAE = true;
	}

	private void MBCCCMMBPEK()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 810f;
		DBEFBFPAOAA = 960f;
		bubbleSpriteRenderer.color = new Color(678f, 1293f, 1364f, 1952f);
		bubble.SetActive(false);
		LKOJBFMGMAE = true;
	}

	private void LCJCGFNFBBD()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 845f;
		DBEFBFPAOAA = 1977f;
		bubbleSpriteRenderer.color = new Color(1107f, 990f, 1508f, 1907f);
		bubble.SetActive(false);
		LKOJBFMGMAE = false;
	}

	private void KCOFAJBKHAO()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 807f;
		DBEFBFPAOAA = 1277f;
		bubbleSpriteRenderer.color = new Color(1223f, 1951f, 1181f, 53f);
		bubble.SetActive(true);
		LKOJBFMGMAE = false;
	}

	private void AGFLPEOOEAM()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 431f;
		DBEFBFPAOAA = 783f;
		bubbleSpriteRenderer.color = new Color(922f, 1936f, 1675f, 1193f);
		bubble.SetActive(false);
		LKOJBFMGMAE = true;
	}

	private void BONFAKNOAMJ()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1840f, 1060f, 27f, Mathf.Lerp(438f, 67f, DCGBADKLANM));
			if (DCGBADKLANM >= 550f)
			{
				LKOJBFMGMAE = false;
				bubble.SetActive(false);
				DBEFBFPAOAA = 777f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(false);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1542f, 1345f, 1825f, Mathf.Lerp(1480f, 11f, DCGBADKLANM));
			if (DCGBADKLANM >= 740f)
			{
				LKOJBFMGMAE = false;
				DBEFBFPAOAA = 1127f;
			}
		}
	}

	private void MDJFIIPDBHI()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1404f, 216f, 493f, Mathf.Lerp(529f, 241f, DCGBADKLANM));
			if (DCGBADKLANM >= 1814f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(false);
				DBEFBFPAOAA = 400f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(862f, 1667f, 1344f, Mathf.Lerp(674f, 1144f, DCGBADKLANM));
			if (DCGBADKLANM >= 588f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 489f;
			}
		}
	}

	private void HFIHGHBLLAM()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1809f;
		DBEFBFPAOAA = 879f;
		bubbleSpriteRenderer.color = new Color(270f, 1657f, 331f, 1079f);
		bubble.SetActive(true);
		LKOJBFMGMAE = false;
	}

	private void LMPCDDGFBGD()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1527f;
		DBEFBFPAOAA = 14f;
		bubbleSpriteRenderer.color = new Color(275f, 383f, 530f, 197f);
		bubble.SetActive(true);
		LKOJBFMGMAE = true;
	}

	private void HJKKGGCKHKK()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(706f, 1269f, 1259f, Mathf.Lerp(1419f, 471f, DCGBADKLANM));
			if (DCGBADKLANM >= 902f)
			{
				LKOJBFMGMAE = false;
				bubble.SetActive(false);
				DBEFBFPAOAA = 1193f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(false);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(507f, 329f, 1361f, Mathf.Lerp(835f, 620f, DCGBADKLANM));
			if (DCGBADKLANM >= 1904f)
			{
				LKOJBFMGMAE = false;
				DBEFBFPAOAA = 1104f;
			}
		}
	}

	private void IJILOIAOKBF()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1665f;
		DBEFBFPAOAA = 1522f;
		bubbleSpriteRenderer.color = new Color(511f, 1308f, 1897f, 1261f);
		bubble.SetActive(false);
		LKOJBFMGMAE = false;
	}

	private void GMNJJIGMJEG()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(223f, 1034f, 1273f, Mathf.Lerp(298f, 1341f, DCGBADKLANM));
			if (DCGBADKLANM >= 884f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(true);
				DBEFBFPAOAA = 552f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(705f, 496f, 1670f, Mathf.Lerp(786f, 224f, DCGBADKLANM));
			if (DCGBADKLANM >= 87f)
			{
				LKOJBFMGMAE = false;
				DBEFBFPAOAA = 1757f;
			}
		}
	}

	private void NPHKFBIEMDO()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1200f, 1610f, 1271f, Mathf.Lerp(427f, 1291f, DCGBADKLANM));
			if (DCGBADKLANM >= 887f)
			{
				LKOJBFMGMAE = false;
				bubble.SetActive(false);
				DBEFBFPAOAA = 1034f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(553f, 884f, 321f, Mathf.Lerp(1129f, 594f, DCGBADKLANM));
			if (DCGBADKLANM >= 396f)
			{
				LKOJBFMGMAE = false;
				DBEFBFPAOAA = 1889f;
			}
		}
	}

	private void ADDLDNPHIHF()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1789f;
		DBEFBFPAOAA = 1877f;
		bubbleSpriteRenderer.color = new Color(286f, 1263f, 224f, 1170f);
		bubble.SetActive(true);
		LKOJBFMGMAE = true;
	}

	private void GFPPEHOHGDD()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(979f, 1185f, 77f, Mathf.Lerp(1020f, 186f, DCGBADKLANM));
			if (DCGBADKLANM >= 311f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(false);
				DBEFBFPAOAA = 1413f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(597f, 991f, 1937f, Mathf.Lerp(956f, 1504f, DCGBADKLANM));
			if (DCGBADKLANM >= 1362f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 61f;
			}
		}
	}

	private void NLHALEAEDMM()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 563f;
		DBEFBFPAOAA = 615f;
		bubbleSpriteRenderer.color = new Color(704f, 211f, 432f, 1300f);
		bubble.SetActive(true);
		LKOJBFMGMAE = false;
	}

	private void HHHEACKHADN()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1253f;
		DBEFBFPAOAA = 1959f;
		bubbleSpriteRenderer.color = new Color(726f, 763f, 237f, 431f);
		bubble.SetActive(true);
		LKOJBFMGMAE = true;
	}

	private void IEPJAFLDBJJ()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1924f;
		DBEFBFPAOAA = 1578f;
		bubbleSpriteRenderer.color = new Color(1482f, 683f, 401f, 1942f);
		bubble.SetActive(false);
		LKOJBFMGMAE = false;
	}

	private void ICBCMLAIIPF()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1644f;
		DBEFBFPAOAA = 1206f;
		bubbleSpriteRenderer.color = new Color(1691f, 1983f, 227f, 374f);
		bubble.SetActive(false);
		LKOJBFMGMAE = false;
	}

	private void BHLAGCODJGJ()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(884f, 1742f, 1166f, Mathf.Lerp(1127f, 428f, DCGBADKLANM));
			if (DCGBADKLANM >= 360f)
			{
				LKOJBFMGMAE = false;
				bubble.SetActive(true);
				DBEFBFPAOAA = 1625f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(false);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(645f, 741f, 91f, Mathf.Lerp(1873f, 1723f, DCGBADKLANM));
			if (DCGBADKLANM >= 1475f)
			{
				LKOJBFMGMAE = false;
				DBEFBFPAOAA = 20f;
			}
		}
	}

	private void CJDJDDNCNDJ()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 84f;
		DBEFBFPAOAA = 1749f;
		bubbleSpriteRenderer.color = new Color(1263f, 1335f, 820f, 186f);
		bubble.SetActive(true);
		LKOJBFMGMAE = true;
	}

	private void NLIBBOAOFEI()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1772f, 387f, 131f, Mathf.Lerp(1437f, 884f, DCGBADKLANM));
			if (DCGBADKLANM >= 770f)
			{
				LKOJBFMGMAE = false;
				bubble.SetActive(false);
				DBEFBFPAOAA = 296f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(647f, 1141f, 577f, Mathf.Lerp(1565f, 551f, DCGBADKLANM));
			if (DCGBADKLANM >= 1979f)
			{
				LKOJBFMGMAE = false;
				DBEFBFPAOAA = 21f;
			}
		}
	}

	private void ELCCADLIKEH()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(556f, 405f, 263f, Mathf.Lerp(1942f, 587f, DCGBADKLANM));
			if (DCGBADKLANM >= 33f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(false);
				DBEFBFPAOAA = 1089f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(527f, 585f, 1473f, Mathf.Lerp(1680f, 1450f, DCGBADKLANM));
			if (DCGBADKLANM >= 908f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 1618f;
			}
		}
	}

	private void EEMKIGPINFK()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(255f, 1168f, 1378f, Mathf.Lerp(94f, 1795f, DCGBADKLANM));
			if (DCGBADKLANM >= 655f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(true);
				DBEFBFPAOAA = 481f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(false);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1358f, 1063f, 1932f, Mathf.Lerp(817f, 1549f, DCGBADKLANM));
			if (DCGBADKLANM >= 1328f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 1252f;
			}
		}
	}

	private void NMKKMGBKCGK()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(936f, 1982f, 1982f, Mathf.Lerp(1637f, 129f, DCGBADKLANM));
			if (DCGBADKLANM >= 865f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(false);
				DBEFBFPAOAA = 1244f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(683f, 315f, 116f, Mathf.Lerp(1030f, 920f, DCGBADKLANM));
			if (DCGBADKLANM >= 1897f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 280f;
			}
		}
	}

	private void ADGMAKKMINA()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1736f;
		DBEFBFPAOAA = 1112f;
		bubbleSpriteRenderer.color = new Color(165f, 1633f, 900f, 434f);
		bubble.SetActive(false);
		LKOJBFMGMAE = true;
	}

	private void FPJABCNDEEJ()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1653f;
		DBEFBFPAOAA = 1078f;
		bubbleSpriteRenderer.color = new Color(581f, 1671f, 393f, 1792f);
		bubble.SetActive(false);
		LKOJBFMGMAE = true;
	}

	private void KHNBDGDLMIE()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1452f;
		DBEFBFPAOAA = 1432f;
		bubbleSpriteRenderer.color = new Color(720f, 1265f, 364f, 750f);
		bubble.SetActive(true);
		LKOJBFMGMAE = false;
	}

	private void EDAFIAEGNLA()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1390f, 242f, 451f, Mathf.Lerp(1965f, 1270f, DCGBADKLANM));
			if (DCGBADKLANM >= 1223f)
			{
				LKOJBFMGMAE = false;
				bubble.SetActive(false);
				DBEFBFPAOAA = 509f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(false);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(672f, 1294f, 1641f, Mathf.Lerp(1782f, 1901f, DCGBADKLANM));
			if (DCGBADKLANM >= 405f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 426f;
			}
		}
	}

	private void NPDFCPEOFPD()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1369f;
		DBEFBFPAOAA = 1778f;
		bubbleSpriteRenderer.color = new Color(438f, 145f, 825f, 1346f);
		bubble.SetActive(false);
		LKOJBFMGMAE = true;
	}

	private void DEDDGMJNEPI()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(545f, 970f, 324f, Mathf.Lerp(1207f, 594f, DCGBADKLANM));
			if (DCGBADKLANM >= 1496f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(false);
				DBEFBFPAOAA = 1253f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(false);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1917f, 1953f, 209f, Mathf.Lerp(1578f, 838f, DCGBADKLANM));
			if (DCGBADKLANM >= 865f)
			{
				LKOJBFMGMAE = false;
				DBEFBFPAOAA = 874f;
			}
		}
	}

	private void ICOJDKMKIPL()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1688f;
		DBEFBFPAOAA = 1893f;
		bubbleSpriteRenderer.color = new Color(632f, 1600f, 1990f, 755f);
		bubble.SetActive(false);
		LKOJBFMGMAE = true;
	}

	private void MPMGGLKFMNJ()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 904f;
		DBEFBFPAOAA = 1832f;
		bubbleSpriteRenderer.color = new Color(1127f, 1089f, 29f, 891f);
		bubble.SetActive(false);
		LKOJBFMGMAE = false;
	}

	private void GJJPNFHFBFP()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1662f;
		DBEFBFPAOAA = 1662f;
		bubbleSpriteRenderer.color = new Color(701f, 459f, 1271f, 784f);
		bubble.SetActive(true);
		LKOJBFMGMAE = false;
	}

	private void BGNKCCGGMCE()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1206f, 67f, 1052f, Mathf.Lerp(1356f, 377f, DCGBADKLANM));
			if (DCGBADKLANM >= 761f)
			{
				LKOJBFMGMAE = false;
				bubble.SetActive(true);
				DBEFBFPAOAA = 313f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(713f, 231f, 357f, Mathf.Lerp(951f, 1720f, DCGBADKLANM));
			if (DCGBADKLANM >= 779f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 858f;
			}
		}
	}

	private void HGEKPHOPJCD()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1885f;
		DBEFBFPAOAA = 543f;
		bubbleSpriteRenderer.color = new Color(589f, 1445f, 991f, 1125f);
		bubble.SetActive(false);
		LKOJBFMGMAE = false;
	}

	private void GKCKLIAANHA()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1440f;
		DBEFBFPAOAA = 1904f;
		bubbleSpriteRenderer.color = new Color(1247f, 1817f, 575f, 108f);
		bubble.SetActive(true);
		LKOJBFMGMAE = false;
	}

	private void DIMOLCECNGD()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(639f, 996f, 265f, Mathf.Lerp(1171f, 485f, DCGBADKLANM));
			if (DCGBADKLANM >= 1420f)
			{
				LKOJBFMGMAE = false;
				bubble.SetActive(true);
				DBEFBFPAOAA = 1402f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(false);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1145f, 173f, 1695f, Mathf.Lerp(1718f, 1093f, DCGBADKLANM));
			if (DCGBADKLANM >= 495f)
			{
				LKOJBFMGMAE = false;
				DBEFBFPAOAA = 967f;
			}
		}
	}

	private void PJOAFKEIPPD()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1651f;
		DBEFBFPAOAA = 1496f;
		bubbleSpriteRenderer.color = new Color(1824f, 1263f, 1113f, 268f);
		bubble.SetActive(false);
		LKOJBFMGMAE = true;
	}

	private void CFKPLDPJODB()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(656f, 1464f, 1864f, Mathf.Lerp(1462f, 1999f, DCGBADKLANM));
			if (DCGBADKLANM >= 1421f)
			{
				LKOJBFMGMAE = false;
				bubble.SetActive(true);
				DBEFBFPAOAA = 610f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(5f, 683f, 359f, Mathf.Lerp(762f, 1678f, DCGBADKLANM));
			if (DCGBADKLANM >= 1064f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 1630f;
			}
		}
	}

	private void OPEIDDFCPGB()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(134f, 1268f, 1949f, Mathf.Lerp(1166f, 1548f, DCGBADKLANM));
			if (DCGBADKLANM >= 457f)
			{
				LKOJBFMGMAE = false;
				bubble.SetActive(false);
				DBEFBFPAOAA = 1893f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1525f, 1573f, 1369f, Mathf.Lerp(1028f, 1018f, DCGBADKLANM));
			if (DCGBADKLANM >= 1793f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 1391f;
			}
		}
	}

	private void AONIDCIEKCM()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1889f;
		DBEFBFPAOAA = 1211f;
		bubbleSpriteRenderer.color = new Color(380f, 633f, 666f, 1208f);
		bubble.SetActive(false);
		LKOJBFMGMAE = true;
	}

	private void DCCJBKGNAOP()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1668f;
		DBEFBFPAOAA = 1368f;
		bubbleSpriteRenderer.color = new Color(1557f, 816f, 1227f, 10f);
		bubble.SetActive(true);
		LKOJBFMGMAE = true;
	}

	private void NLMLOOGHLCH()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1904f;
		DBEFBFPAOAA = 242f;
		bubbleSpriteRenderer.color = new Color(611f, 828f, 1643f, 469f);
		bubble.SetActive(false);
		LKOJBFMGMAE = true;
	}

	private void KEBLCNJMALL()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1311f, 203f, 651f, Mathf.Lerp(1114f, 1153f, DCGBADKLANM));
			if (DCGBADKLANM >= 130f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(true);
				DBEFBFPAOAA = 89f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(false);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1045f, 959f, 1500f, Mathf.Lerp(1431f, 1166f, DCGBADKLANM));
			if (DCGBADKLANM >= 431f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 1740f;
			}
		}
	}

	private void PEDABKILCOH()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1266f, 452f, 140f, Mathf.Lerp(1374f, 62f, DCGBADKLANM));
			if (DCGBADKLANM >= 1766f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(true);
				DBEFBFPAOAA = 1361f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(383f, 795f, 1160f, Mathf.Lerp(1395f, 1104f, DCGBADKLANM));
			if (DCGBADKLANM >= 415f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 1198f;
			}
		}
	}

	private void LAPKOCHBNNP()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1328f, 252f, 1308f, Mathf.Lerp(1740f, 18f, DCGBADKLANM));
			if (DCGBADKLANM >= 657f)
			{
				LKOJBFMGMAE = false;
				bubble.SetActive(true);
				DBEFBFPAOAA = 1642f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(234f, 1084f, 1319f, Mathf.Lerp(1605f, 1625f, DCGBADKLANM));
			if (DCGBADKLANM >= 1216f)
			{
				LKOJBFMGMAE = false;
				DBEFBFPAOAA = 1489f;
			}
		}
	}

	private void DLKFBJPKADF()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1571f, 1168f, 303f, Mathf.Lerp(490f, 1307f, DCGBADKLANM));
			if (DCGBADKLANM >= 229f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(false);
				DBEFBFPAOAA = 199f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(211f, 1003f, 1354f, Mathf.Lerp(1584f, 752f, DCGBADKLANM));
			if (DCGBADKLANM >= 1423f)
			{
				LKOJBFMGMAE = false;
				DBEFBFPAOAA = 200f;
			}
		}
	}

	private void HMGBIMHKFOD()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1706f, 565f, 1541f, Mathf.Lerp(1604f, 360f, DCGBADKLANM));
			if (DCGBADKLANM >= 1661f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(true);
				DBEFBFPAOAA = 829f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1101f, 1190f, 924f, Mathf.Lerp(1982f, 1222f, DCGBADKLANM));
			if (DCGBADKLANM >= 1688f)
			{
				LKOJBFMGMAE = false;
				DBEFBFPAOAA = 1990f;
			}
		}
	}

	private void NODNNAAMCPB()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1882f, 425f, 1907f, Mathf.Lerp(814f, 1286f, DCGBADKLANM));
			if (DCGBADKLANM >= 1221f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(false);
				DBEFBFPAOAA = 840f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(289f, 1500f, 724f, Mathf.Lerp(370f, 927f, DCGBADKLANM));
			if (DCGBADKLANM >= 1959f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 1589f;
			}
		}
	}

	private void OKAEGLLMBNO()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(301f, 861f, 1548f, Mathf.Lerp(1211f, 1451f, DCGBADKLANM));
			if (DCGBADKLANM >= 1436f)
			{
				LKOJBFMGMAE = false;
				bubble.SetActive(false);
				DBEFBFPAOAA = 854f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(595f, 121f, 1138f, Mathf.Lerp(908f, 1562f, DCGBADKLANM));
			if (DCGBADKLANM >= 843f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 485f;
			}
		}
	}

	private void DNJADOEECLA()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1099f, 1440f, 44f, Mathf.Lerp(1942f, 600f, DCGBADKLANM));
			if (DCGBADKLANM >= 28f)
			{
				LKOJBFMGMAE = false;
				bubble.SetActive(true);
				DBEFBFPAOAA = 48f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(false);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1555f, 1167f, 262f, Mathf.Lerp(1512f, 86f, DCGBADKLANM));
			if (DCGBADKLANM >= 1644f)
			{
				LKOJBFMGMAE = false;
				DBEFBFPAOAA = 780f;
			}
		}
	}

	private void LMNKOMLKIAA()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(373f, 64f, 228f, Mathf.Lerp(982f, 1346f, DCGBADKLANM));
			if (DCGBADKLANM >= 156f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(true);
				DBEFBFPAOAA = 0f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(false);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1070f, 1343f, 1860f, Mathf.Lerp(1377f, 1927f, DCGBADKLANM));
			if (DCGBADKLANM >= 1312f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 1684f;
			}
		}
	}

	private void ILDICDKOLEP()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(191f, 1716f, 184f, Mathf.Lerp(1819f, 89f, DCGBADKLANM));
			if (DCGBADKLANM >= 814f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(false);
				DBEFBFPAOAA = 1080f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1332f, 248f, 1082f, Mathf.Lerp(1820f, 124f, DCGBADKLANM));
			if (DCGBADKLANM >= 561f)
			{
				LKOJBFMGMAE = false;
				DBEFBFPAOAA = 861f;
			}
		}
	}

	private void BPNOIDBAPJE()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1389f;
		DBEFBFPAOAA = 1132f;
		bubbleSpriteRenderer.color = new Color(635f, 1218f, 551f, 510f);
		bubble.SetActive(false);
		LKOJBFMGMAE = true;
	}

	private void BEJCCPKKDEG()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(83f, 1442f, 1530f, Mathf.Lerp(1533f, 1433f, DCGBADKLANM));
			if (DCGBADKLANM >= 664f)
			{
				LKOJBFMGMAE = false;
				bubble.SetActive(true);
				DBEFBFPAOAA = 426f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1145f, 1015f, 1076f, Mathf.Lerp(673f, 1474f, DCGBADKLANM));
			if (DCGBADKLANM >= 1502f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 1104f;
			}
		}
	}

	private void ECJFMIKNAKG()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(97f, 518f, 1083f, Mathf.Lerp(544f, 623f, DCGBADKLANM));
			if (DCGBADKLANM >= 836f)
			{
				LKOJBFMGMAE = false;
				bubble.SetActive(false);
				DBEFBFPAOAA = 1897f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(821f, 483f, 277f, Mathf.Lerp(664f, 1796f, DCGBADKLANM));
			if (DCGBADKLANM >= 1170f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 490f;
			}
		}
	}

	private void HKJCLFHCMKC()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 955f;
		DBEFBFPAOAA = 326f;
		bubbleSpriteRenderer.color = new Color(310f, 579f, 1373f, 445f);
		bubble.SetActive(false);
		LKOJBFMGMAE = false;
	}

	private void GOGOIJNNEJF()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(371f, 1941f, 968f, Mathf.Lerp(828f, 1669f, DCGBADKLANM));
			if (DCGBADKLANM >= 464f)
			{
				LKOJBFMGMAE = false;
				bubble.SetActive(true);
				DBEFBFPAOAA = 1727f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1951f, 1408f, 639f, Mathf.Lerp(1326f, 1398f, DCGBADKLANM));
			if (DCGBADKLANM >= 677f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 1005f;
			}
		}
	}

	private void CIIBBCPIOIP()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1988f;
		DBEFBFPAOAA = 1741f;
		bubbleSpriteRenderer.color = new Color(1214f, 35f, 749f, 602f);
		bubble.SetActive(false);
		LKOJBFMGMAE = true;
	}

	private void LJCOPHJMDEL()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(643f, 1412f, 769f, Mathf.Lerp(1134f, 1377f, DCGBADKLANM));
			if (DCGBADKLANM >= 188f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(true);
				DBEFBFPAOAA = 407f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(false);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(135f, 107f, 1601f, Mathf.Lerp(1100f, 1453f, DCGBADKLANM));
			if (DCGBADKLANM >= 443f)
			{
				LKOJBFMGMAE = false;
				DBEFBFPAOAA = 138f;
			}
		}
	}

	private void FJFLGDADEKM()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1355f;
		DBEFBFPAOAA = 866f;
		bubbleSpriteRenderer.color = new Color(2f, 918f, 150f, 931f);
		bubble.SetActive(true);
		LKOJBFMGMAE = true;
	}

	private void MAIMGNMIFKG()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1684f;
		DBEFBFPAOAA = 269f;
		bubbleSpriteRenderer.color = new Color(1027f, 3f, 1091f, 298f);
		bubble.SetActive(false);
		LKOJBFMGMAE = false;
	}

	private void KPHPCKJBLBH()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(608f, 1038f, 642f, Mathf.Lerp(1053f, 415f, DCGBADKLANM));
			if (DCGBADKLANM >= 1935f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(false);
				DBEFBFPAOAA = 1861f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(732f, 945f, 1116f, Mathf.Lerp(1388f, 1090f, DCGBADKLANM));
			if (DCGBADKLANM >= 1054f)
			{
				LKOJBFMGMAE = false;
				DBEFBFPAOAA = 244f;
			}
		}
	}

	private void IIKAAAHEFMP()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1039f, 1786f, 1406f, Mathf.Lerp(99f, 1494f, DCGBADKLANM));
			if (DCGBADKLANM >= 314f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(true);
				DBEFBFPAOAA = 640f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(846f, 1447f, 1882f, Mathf.Lerp(1030f, 1768f, DCGBADKLANM));
			if (DCGBADKLANM >= 1228f)
			{
				LKOJBFMGMAE = false;
				DBEFBFPAOAA = 285f;
			}
		}
	}

	private void MNIAGPINFCN()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(670f, 825f, 1633f, Mathf.Lerp(1258f, 1957f, DCGBADKLANM));
			if (DCGBADKLANM >= 424f)
			{
				LKOJBFMGMAE = false;
				bubble.SetActive(true);
				DBEFBFPAOAA = 1314f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(false);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1824f, 405f, 62f, Mathf.Lerp(668f, 792f, DCGBADKLANM));
			if (DCGBADKLANM >= 1960f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 233f;
			}
		}
	}

	private void FLBFKMEHJKJ()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1699f, 556f, 1037f, Mathf.Lerp(249f, 657f, DCGBADKLANM));
			if (DCGBADKLANM >= 1880f)
			{
				LKOJBFMGMAE = false;
				bubble.SetActive(true);
				DBEFBFPAOAA = 1229f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(false);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1009f, 644f, 437f, Mathf.Lerp(810f, 922f, DCGBADKLANM));
			if (DCGBADKLANM >= 888f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 1562f;
			}
		}
	}

	private void OJLGOCFKLJE()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 128f;
		DBEFBFPAOAA = 136f;
		bubbleSpriteRenderer.color = new Color(1221f, 1676f, 121f, 73f);
		bubble.SetActive(true);
		LKOJBFMGMAE = false;
	}

	private void FMDDHJHFPIO()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(373f, 1225f, 228f, Mathf.Lerp(608f, 1798f, DCGBADKLANM));
			if (DCGBADKLANM >= 888f)
			{
				LKOJBFMGMAE = false;
				bubble.SetActive(false);
				DBEFBFPAOAA = 755f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(false);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1380f, 1320f, 734f, Mathf.Lerp(1088f, 1132f, DCGBADKLANM));
			if (DCGBADKLANM >= 258f)
			{
				LKOJBFMGMAE = false;
				DBEFBFPAOAA = 1994f;
			}
		}
	}

	private void BJOOCKCBPLJ()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 251f;
		DBEFBFPAOAA = 604f;
		bubbleSpriteRenderer.color = new Color(1958f, 1015f, 204f, 784f);
		bubble.SetActive(false);
		LKOJBFMGMAE = false;
	}

	private void FCLABOCLACJ()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1456f;
		DBEFBFPAOAA = 199f;
		bubbleSpriteRenderer.color = new Color(1127f, 1503f, 1443f, 1947f);
		bubble.SetActive(true);
		LKOJBFMGMAE = true;
	}

	private void NMPFHHEFOPH()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 1640f;
		DBEFBFPAOAA = 337f;
		bubbleSpriteRenderer.color = new Color(1274f, 230f, 1699f, 419f);
		bubble.SetActive(true);
		LKOJBFMGMAE = false;
	}

	private void BCKOBEAGOJP()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(422f, 1269f, 1248f, Mathf.Lerp(429f, 36f, DCGBADKLANM));
			if (DCGBADKLANM >= 1706f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(true);
				DBEFBFPAOAA = 1700f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1607f, 1135f, 1530f, Mathf.Lerp(1581f, 570f, DCGBADKLANM));
			if (DCGBADKLANM >= 1264f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 1636f;
			}
		}
	}

	private void PPJMHGFLEDF()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1720f, 947f, 374f, Mathf.Lerp(1234f, 1953f, DCGBADKLANM));
			if (DCGBADKLANM >= 1901f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(true);
				DBEFBFPAOAA = 750f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(false);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1393f, 834f, 1722f, Mathf.Lerp(1338f, 453f, DCGBADKLANM));
			if (DCGBADKLANM >= 886f)
			{
				LKOJBFMGMAE = false;
				DBEFBFPAOAA = 1128f;
			}
		}
	}

	private void LPPMKNJBPHC()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1853f, 1445f, 1400f, Mathf.Lerp(1152f, 645f, DCGBADKLANM));
			if (DCGBADKLANM >= 368f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(true);
				DBEFBFPAOAA = 733f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(false);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1954f, 1157f, 1234f, Mathf.Lerp(1080f, 321f, DCGBADKLANM));
			if (DCGBADKLANM >= 461f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 1626f;
			}
		}
	}

	private void IANGDMHMCEL()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 291f;
		DBEFBFPAOAA = 793f;
		bubbleSpriteRenderer.color = new Color(698f, 614f, 770f, 187f);
		bubble.SetActive(false);
		LKOJBFMGMAE = false;
	}

	private void INCOGEMNFNH()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1805f, 320f, 1468f, Mathf.Lerp(939f, 19f, DCGBADKLANM));
			if (DCGBADKLANM >= 492f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(false);
				DBEFBFPAOAA = 1563f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(984f, 1341f, 1303f, Mathf.Lerp(1738f, 1617f, DCGBADKLANM));
			if (DCGBADKLANM >= 597f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 1738f;
			}
		}
	}

	private void OnEnable()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 0f;
		DBEFBFPAOAA = 0f;
		bubbleSpriteRenderer.color = new Color(1f, 1f, 1f, 0f);
		bubble.SetActive(false);
		LKOJBFMGMAE = true;
	}

	private void ANMOAFFGEOE()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 26f;
		DBEFBFPAOAA = 1381f;
		bubbleSpriteRenderer.color = new Color(625f, 274f, 1408f, 182f);
		bubble.SetActive(true);
		LKOJBFMGMAE = true;
	}

	private void DIJOBOFGCIK()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = 682f;
		DBEFBFPAOAA = 453f;
		bubbleSpriteRenderer.color = new Color(1484f, 434f, 741f, 1230f);
		bubble.SetActive(false);
		LKOJBFMGMAE = true;
	}

	private void CEGIGMHMJOB()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[1]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1023f, 1646f, 875f, Mathf.Lerp(347f, 682f, DCGBADKLANM));
			if (DCGBADKLANM >= 1461f)
			{
				LKOJBFMGMAE = true;
				bubble.SetActive(false);
				DBEFBFPAOAA = 1223f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(true);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1651f, 1282f, 1685f, Mathf.Lerp(1585f, 1956f, DCGBADKLANM));
			if (DCGBADKLANM >= 367f)
			{
				LKOJBFMGMAE = false;
				DBEFBFPAOAA = 1331f;
			}
		}
	}

	private void JPPCPMOMDON()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		if (((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && !LKOJBFMGMAE)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(532f, 1800f, 43f, Mathf.Lerp(833f, 1702f, DCGBADKLANM));
			if (DCGBADKLANM >= 1248f)
			{
				LKOJBFMGMAE = false;
				bubble.SetActive(true);
				DBEFBFPAOAA = 13f;
			}
		}
		else if (!((AbstractDialogueUI)SceneReferences.instance.dialogueUI[0]).IsOpen && LKOJBFMGMAE)
		{
			bubble.SetActive(false);
			DBEFBFPAOAA += Time.deltaTime;
			if (DBEFBFPAOAA > AFMFHCAHEFO)
			{
				DBEFBFPAOAA = AFMFHCAHEFO;
			}
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			bubbleSpriteRenderer.color = new Color(1612f, 484f, 156f, Mathf.Lerp(412f, 1961f, DCGBADKLANM));
			if (DCGBADKLANM >= 1726f)
			{
				LKOJBFMGMAE = true;
				DBEFBFPAOAA = 1933f;
			}
		}
	}
}
