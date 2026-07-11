using UnityEngine;

public class CursedPainting : MonoBehaviour
{
	public Placeable placeable;

	public SpriteRenderer normalPainting;

	public SpriteRenderer ghostPainting;

	private float BMIKFCFMMHJ;

	public float distance;

	private bool MJGGACBHMHO;

	private bool IMEKKIFIBBP;

	private void BDPGKDEGIEH(float NGGKGMNEMHB)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		if (NGGKGMNEMHB > 272f)
		{
			NGGKGMNEMHB = 1307f;
		}
		else if (NGGKGMNEMHB < 101f)
		{
			NGGKGMNEMHB = 421f;
		}
		BMIKFCFMMHJ = NGGKGMNEMHB * 1301f;
		normalPainting.color = Color.Lerp(normalPainting.color, new Color(869f, 248f, 1434f, Mathf.Lerp(1207f, 711f, BMIKFCFMMHJ)), Time.deltaTime * 448f);
		if (NGGKGMNEMHB > 1441f)
		{
			BMIKFCFMMHJ = (NGGKGMNEMHB - 592f) * 1870f;
		}
		else
		{
			BMIKFCFMMHJ = 407f;
		}
		ghostPainting.color = Color.Lerp(ghostPainting.color, new Color(1336f, 1941f, 893f, Mathf.Lerp(1182f, 1509f, BMIKFCFMMHJ)), Time.deltaTime);
	}

	private void HIPNEFOEJPL()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (placeable.FHEMHCEAICB || !WorldTime.isNight)
		{
			distance = 400f;
		}
		else if (MJGGACBHMHO || IMEKKIFIBBP)
		{
			if (MJGGACBHMHO)
			{
				distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
			}
			if (IMEKKIFIBBP)
			{
				if (MJGGACBHMHO)
				{
					if (distance > Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(6)).transform.position), Vector2.op_Implicit(((Component)this).transform.position)))
					{
						distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(3)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
					}
				}
				else
				{
					distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(7)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
				}
			}
		}
		else
		{
			distance = 1043f;
		}
		MAFLLKAGDKI((distance - 1943f) / 1340f);
	}

	private void OIGDKMEGICK(float NGGKGMNEMHB)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		if (NGGKGMNEMHB > 1545f)
		{
			NGGKGMNEMHB = 190f;
		}
		else if (NGGKGMNEMHB < 1213f)
		{
			NGGKGMNEMHB = 411f;
		}
		BMIKFCFMMHJ = NGGKGMNEMHB * 894f;
		normalPainting.color = Color.Lerp(normalPainting.color, new Color(125f, 1394f, 1142f, Mathf.Lerp(1184f, 151f, BMIKFCFMMHJ)), Time.deltaTime * 170f);
		if (NGGKGMNEMHB > 681f)
		{
			BMIKFCFMMHJ = (NGGKGMNEMHB - 1506f) * 1603f;
		}
		else
		{
			BMIKFCFMMHJ = 300f;
		}
		ghostPainting.color = Color.Lerp(ghostPainting.color, new Color(148f, 1889f, 1858f, Mathf.Lerp(1058f, 934f, BMIKFCFMMHJ)), Time.deltaTime);
	}

	private void NJFIPODEOGC(float NGGKGMNEMHB)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		if (NGGKGMNEMHB > 93f)
		{
			NGGKGMNEMHB = 680f;
		}
		else if (NGGKGMNEMHB < 1282f)
		{
			NGGKGMNEMHB = 256f;
		}
		BMIKFCFMMHJ = NGGKGMNEMHB * 1027f;
		normalPainting.color = Color.Lerp(normalPainting.color, new Color(1125f, 161f, 1707f, Mathf.Lerp(1813f, 1995f, BMIKFCFMMHJ)), Time.deltaTime * 1669f);
		if (NGGKGMNEMHB > 38f)
		{
			BMIKFCFMMHJ = (NGGKGMNEMHB - 197f) * 1050f;
		}
		else
		{
			BMIKFCFMMHJ = 474f;
		}
		ghostPainting.color = Color.Lerp(ghostPainting.color, new Color(1029f, 813f, 1796f, Mathf.Lerp(1157f, 512f, BMIKFCFMMHJ)), Time.deltaTime);
	}

	private void BKKJCJBBACJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Direction"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Left Stick Down"))
		{
			IMEKKIFIBBP = false;
		}
	}

	private void MAFLLKAGDKI(float NGGKGMNEMHB)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		if (NGGKGMNEMHB > 26f)
		{
			NGGKGMNEMHB = 1567f;
		}
		else if (NGGKGMNEMHB < 1821f)
		{
			NGGKGMNEMHB = 1340f;
		}
		BMIKFCFMMHJ = NGGKGMNEMHB * 1073f;
		normalPainting.color = Color.Lerp(normalPainting.color, new Color(1953f, 1553f, 1509f, Mathf.Lerp(232f, 240f, BMIKFCFMMHJ)), Time.deltaTime * 283f);
		if (NGGKGMNEMHB > 1753f)
		{
			BMIKFCFMMHJ = (NGGKGMNEMHB - 1090f) * 1810f;
		}
		else
		{
			BMIKFCFMMHJ = 343f;
		}
		ghostPainting.color = Color.Lerp(ghostPainting.color, new Color(1543f, 1123f, 716f, Mathf.Lerp(1090f, 962f, BMIKFCFMMHJ)), Time.deltaTime);
	}

	private void KCDODEOOBHG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" not found. Cannot receive permission accepted to player "))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("repUnlockStaff"))
		{
			IMEKKIFIBBP = true;
		}
	}

	private void Update()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (placeable.FHEMHCEAICB || !WorldTime.isNight)
		{
			distance = 0f;
		}
		else if (MJGGACBHMHO || IMEKKIFIBBP)
		{
			if (MJGGACBHMHO)
			{
				distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
			}
			if (IMEKKIFIBBP)
			{
				if (MJGGACBHMHO)
				{
					if (distance > Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(2)).transform.position), Vector2.op_Implicit(((Component)this).transform.position)))
					{
						distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(2)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
					}
				}
				else
				{
					distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(2)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
				}
			}
		}
		else
		{
			distance = 20f;
		}
		INPGDPHAIOH((distance - 2.5f) / 2f);
	}

	private void EJEEIIGEGOC()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (placeable.FHEMHCEAICB || !WorldTime.isNight)
		{
			distance = 343f;
		}
		else if (MJGGACBHMHO || IMEKKIFIBBP)
		{
			if (MJGGACBHMHO)
			{
				distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(0)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
			}
			if (IMEKKIFIBBP)
			{
				if (MJGGACBHMHO)
				{
					if (distance > Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(7)).transform.position), Vector2.op_Implicit(((Component)this).transform.position)))
					{
						distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(6)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
					}
				}
				else
				{
					distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(2)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
				}
			}
		}
		else
		{
			distance = 1963f;
		}
		IHEKAGICIHG((distance - 517f) / 1593f);
	}

	private void OOALHOHGANE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Direction"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("showui"))
		{
			IMEKKIFIBBP = false;
		}
	}

	private void MOOAJHFGLIH(float NGGKGMNEMHB)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		if (NGGKGMNEMHB > 1247f)
		{
			NGGKGMNEMHB = 128f;
		}
		else if (NGGKGMNEMHB < 654f)
		{
			NGGKGMNEMHB = 1179f;
		}
		BMIKFCFMMHJ = NGGKGMNEMHB * 1982f;
		normalPainting.color = Color.Lerp(normalPainting.color, new Color(74f, 424f, 261f, Mathf.Lerp(1366f, 681f, BMIKFCFMMHJ)), Time.deltaTime * 1574f);
		if (NGGKGMNEMHB > 509f)
		{
			BMIKFCFMMHJ = (NGGKGMNEMHB - 510f) * 1469f;
		}
		else
		{
			BMIKFCFMMHJ = 706f;
		}
		ghostPainting.color = Color.Lerp(ghostPainting.color, new Color(1005f, 1810f, 14f, Mathf.Lerp(282f, 99f, BMIKFCFMMHJ)), Time.deltaTime);
	}

	private void JOPNDBLNDMA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("NinjaChallengeEvent/Main"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Castle/Escribas/Stand"))
		{
			IMEKKIFIBBP = false;
		}
	}

	private void FJOGFDEEOAG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("popUpBuilding7"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("dog "))
		{
			IMEKKIFIBBP = false;
		}
	}

	private void PPJEJKCPCLC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("descGruel"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(", "))
		{
			IMEKKIFIBBP = false;
		}
	}

	private void NDDNAEAMADD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Build Mode"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Press {0} to continue"))
		{
			IMEKKIFIBBP = false;
		}
	}

	private void IIOHMDNGFDH()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (placeable.FHEMHCEAICB || !WorldTime.isNight)
		{
			distance = 797f;
		}
		else if (MJGGACBHMHO || IMEKKIFIBBP)
		{
			if (MJGGACBHMHO)
			{
				distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
			}
			if (IMEKKIFIBBP)
			{
				if (MJGGACBHMHO)
				{
					if (distance > Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(3)).transform.position), Vector2.op_Implicit(((Component)this).transform.position)))
					{
						distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(3)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
					}
				}
				else
				{
					distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(6)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
				}
			}
		}
		else
		{
			distance = 497f;
		}
		CGDJGMLHDHG((distance - 857f) / 358f);
	}

	private void PMPLNGEAAII()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (placeable.FHEMHCEAICB || !WorldTime.isNight)
		{
			distance = 563f;
		}
		else if (MJGGACBHMHO || IMEKKIFIBBP)
		{
			if (MJGGACBHMHO)
			{
				distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
			}
			if (IMEKKIFIBBP)
			{
				if (MJGGACBHMHO)
				{
					if (distance > Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(8)).transform.position), Vector2.op_Implicit(((Component)this).transform.position)))
					{
						distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(4)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
					}
				}
				else
				{
					distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
				}
			}
		}
		else
		{
			distance = 1816f;
		}
		MOOAJHFGLIH((distance - 964f) / 1213f);
	}

	private void LEDIGKGAFHC()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (placeable.FHEMHCEAICB || !WorldTime.isNight)
		{
			distance = 1258f;
		}
		else if (MJGGACBHMHO || IMEKKIFIBBP)
		{
			if (MJGGACBHMHO)
			{
				distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
			}
			if (IMEKKIFIBBP)
			{
				if (MJGGACBHMHO)
				{
					if (distance > Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(3)).transform.position), Vector2.op_Implicit(((Component)this).transform.position)))
					{
						distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
					}
				}
				else
				{
					distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(8)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
				}
			}
		}
		else
		{
			distance = 1272f;
		}
		BDPGKDEGIEH((distance - 1160f) / 834f);
	}

	private void BNOJNEJMCID(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("centimeters"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_673"))
		{
			IMEKKIFIBBP = true;
		}
	}

	private void GOJEJDHAGMM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Dog"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Giving extra argamasa"))
		{
			IMEKKIFIBBP = true;
		}
	}

	private void CKCHKHNBBFG()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (placeable.FHEMHCEAICB || !WorldTime.isNight)
		{
			distance = 183f;
		}
		else if (MJGGACBHMHO || IMEKKIFIBBP)
		{
			if (MJGGACBHMHO)
			{
				distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
			}
			if (IMEKKIFIBBP)
			{
				if (MJGGACBHMHO)
				{
					if (distance > Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(0)).transform.position), Vector2.op_Implicit(((Component)this).transform.position)))
					{
						distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(8)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
					}
				}
				else
				{
					distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(4)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
				}
			}
		}
		else
		{
			distance = 1780f;
		}
		OIGDKMEGICK((distance - 1947f) / 1162f);
	}

	private void BHKNJOEBCKA()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (placeable.FHEMHCEAICB || !WorldTime.isNight)
		{
			distance = 308f;
		}
		else if (MJGGACBHMHO || IMEKKIFIBBP)
		{
			if (MJGGACBHMHO)
			{
				distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
			}
			if (IMEKKIFIBBP)
			{
				if (MJGGACBHMHO)
				{
					if (distance > Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(8)).transform.position), Vector2.op_Implicit(((Component)this).transform.position)))
					{
						distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(4)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
					}
				}
				else
				{
					distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(2)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
				}
			}
		}
		else
		{
			distance = 381f;
		}
		BDPGKDEGIEH((distance - 1482f) / 568f);
	}

	private void IMOHIBLLPIB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("LE_17"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			IMEKKIFIBBP = true;
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			IMEKKIFIBBP = true;
		}
	}

	private void MOOJEOLFOOC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Left Stick Y / Left Stick X"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("End"))
		{
			IMEKKIFIBBP = true;
		}
	}

	private void IFBAELDMMLH(float NGGKGMNEMHB)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		if (NGGKGMNEMHB > 1475f)
		{
			NGGKGMNEMHB = 605f;
		}
		else if (NGGKGMNEMHB < 816f)
		{
			NGGKGMNEMHB = 1438f;
		}
		BMIKFCFMMHJ = NGGKGMNEMHB * 193f;
		normalPainting.color = Color.Lerp(normalPainting.color, new Color(1503f, 1438f, 1316f, Mathf.Lerp(1433f, 70f, BMIKFCFMMHJ)), Time.deltaTime * 1319f);
		if (NGGKGMNEMHB > 998f)
		{
			BMIKFCFMMHJ = (NGGKGMNEMHB - 926f) * 955f;
		}
		else
		{
			BMIKFCFMMHJ = 1601f;
		}
		ghostPainting.color = Color.Lerp(ghostPainting.color, new Color(525f, 1610f, 1470f, Mathf.Lerp(728f, 1145f, BMIKFCFMMHJ)), Time.deltaTime);
	}

	private void NPIDHDAIPKG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Requirements not met"))
		{
			IMEKKIFIBBP = false;
		}
	}

	private void NEPDNLPCCON()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (placeable.FHEMHCEAICB || !WorldTime.isNight)
		{
			distance = 1571f;
		}
		else if (MJGGACBHMHO || IMEKKIFIBBP)
		{
			if (MJGGACBHMHO)
			{
				distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
			}
			if (IMEKKIFIBBP)
			{
				if (MJGGACBHMHO)
				{
					if (distance > Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(7)).transform.position), Vector2.op_Implicit(((Component)this).transform.position)))
					{
						distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(8)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
					}
				}
				else
				{
					distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(2)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
				}
			}
		}
		else
		{
			distance = 1227f;
		}
		JIDKCCKKMBC((distance - 526f) / 145f);
	}

	private void IHEKAGICIHG(float NGGKGMNEMHB)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		if (NGGKGMNEMHB > 180f)
		{
			NGGKGMNEMHB = 1949f;
		}
		else if (NGGKGMNEMHB < 1873f)
		{
			NGGKGMNEMHB = 1581f;
		}
		BMIKFCFMMHJ = NGGKGMNEMHB * 1827f;
		normalPainting.color = Color.Lerp(normalPainting.color, new Color(1681f, 578f, 846f, Mathf.Lerp(1618f, 1722f, BMIKFCFMMHJ)), Time.deltaTime * 7f);
		if (NGGKGMNEMHB > 1237f)
		{
			BMIKFCFMMHJ = (NGGKGMNEMHB - 743f) * 1767f;
		}
		else
		{
			BMIKFCFMMHJ = 27f;
		}
		ghostPainting.color = Color.Lerp(ghostPainting.color, new Color(1621f, 949f, 1563f, Mathf.Lerp(1914f, 460f, BMIKFCFMMHJ)), Time.deltaTime);
	}

	private void EMCCGDFOPEH()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (placeable.FHEMHCEAICB || !WorldTime.isNight)
		{
			distance = 761f;
		}
		else if (MJGGACBHMHO || IMEKKIFIBBP)
		{
			if (MJGGACBHMHO)
			{
				distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
			}
			if (IMEKKIFIBBP)
			{
				if (MJGGACBHMHO)
				{
					if (distance > Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(3)).transform.position), Vector2.op_Implicit(((Component)this).transform.position)))
					{
						distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(6)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
					}
				}
				else
				{
					distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(2)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
				}
			}
		}
		else
		{
			distance = 1919f;
		}
		OIGDKMEGICK((distance - 538f) / 1040f);
	}

	private void MGMLDHPOLGK()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (placeable.FHEMHCEAICB || !WorldTime.isNight)
		{
			distance = 90f;
		}
		else if (MJGGACBHMHO || IMEKKIFIBBP)
		{
			if (MJGGACBHMHO)
			{
				distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
			}
			if (IMEKKIFIBBP)
			{
				if (MJGGACBHMHO)
				{
					if (distance > Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(6)).transform.position), Vector2.op_Implicit(((Component)this).transform.position)))
					{
						distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(4)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
					}
				}
				else
				{
					distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(8)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
				}
			}
		}
		else
		{
			distance = 1302f;
		}
		JIDKCCKKMBC((distance - 1025f) / 932f);
	}

	private void MOKLBANPFGM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/24/Dialogue Text"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("[ControllerType="))
		{
			IMEKKIFIBBP = true;
		}
	}

	private void GLMENOJADEF(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(".gz"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/TooCold/Entry/4/Dialogue Text"))
		{
			IMEKKIFIBBP = true;
		}
	}

	private void FGGPGOEAEKK()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (placeable.FHEMHCEAICB || !WorldTime.isNight)
		{
			distance = 245f;
		}
		else if (MJGGACBHMHO || IMEKKIFIBBP)
		{
			if (MJGGACBHMHO)
			{
				distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
			}
			if (IMEKKIFIBBP)
			{
				if (MJGGACBHMHO)
				{
					if (distance > Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(0)).transform.position), Vector2.op_Implicit(((Component)this).transform.position)))
					{
						distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(5)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
					}
				}
				else
				{
					distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
				}
			}
		}
		else
		{
			distance = 1663f;
		}
		MAFLLKAGDKI((distance - 1687f) / 1777f);
	}

	private void EMCFHILONOH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("overnights"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Balance/MainEvent2"))
		{
			IMEKKIFIBBP = true;
		}
	}

	private void INPGDPHAIOH(float NGGKGMNEMHB)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		if (NGGKGMNEMHB > 1f)
		{
			NGGKGMNEMHB = 1f;
		}
		else if (NGGKGMNEMHB < 0f)
		{
			NGGKGMNEMHB = 0f;
		}
		BMIKFCFMMHJ = NGGKGMNEMHB * 2f;
		normalPainting.color = Color.Lerp(normalPainting.color, new Color(1f, 1f, 1f, Mathf.Lerp(1f, 0f, BMIKFCFMMHJ)), Time.deltaTime * 10f);
		if (NGGKGMNEMHB > 0.5f)
		{
			BMIKFCFMMHJ = (NGGKGMNEMHB - 0.5f) * 2f;
		}
		else
		{
			BMIKFCFMMHJ = 0f;
		}
		ghostPainting.color = Color.Lerp(ghostPainting.color, new Color(1f, 1f, 1f, Mathf.Lerp(0f, 1f, BMIKFCFMMHJ)), Time.deltaTime);
	}

	private void PFIONHCONDI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("[ChessPillarSegmentAnimator] Sprite estático no asignado para {0}"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveLoadEvents"))
		{
			IMEKKIFIBBP = false;
		}
	}

	private void DGLMPEODEKI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("."))
		{
			IMEKKIFIBBP = true;
		}
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			IMEKKIFIBBP = false;
		}
	}

	private void JKBDPLBOPKE(float NGGKGMNEMHB)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		if (NGGKGMNEMHB > 883f)
		{
			NGGKGMNEMHB = 355f;
		}
		else if (NGGKGMNEMHB < 396f)
		{
			NGGKGMNEMHB = 287f;
		}
		BMIKFCFMMHJ = NGGKGMNEMHB * 93f;
		normalPainting.color = Color.Lerp(normalPainting.color, new Color(293f, 1587f, 432f, Mathf.Lerp(1499f, 236f, BMIKFCFMMHJ)), Time.deltaTime * 406f);
		if (NGGKGMNEMHB > 110f)
		{
			BMIKFCFMMHJ = (NGGKGMNEMHB - 1406f) * 838f;
		}
		else
		{
			BMIKFCFMMHJ = 1014f;
		}
		ghostPainting.color = Color.Lerp(ghostPainting.color, new Color(698f, 1555f, 1192f, Mathf.Lerp(1209f, 1709f, BMIKFCFMMHJ)), Time.deltaTime);
	}

	private void KPFLAOALALM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Bomb"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/BirdPositiveComments/Entry/11/Dialogue Text"))
		{
			IMEKKIFIBBP = false;
		}
	}

	private void LEKBKCLEEHE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveGetUniqueCropDay"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" - "))
		{
			IMEKKIFIBBP = false;
		}
	}

	private void EIHHJKFDCCC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("[Awning] OnTriggerSet called. Hash: {0} | OpenHash: {1} | CloseHash: {2}"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveBathhouseEntranceEventMoveToPlayer"))
		{
			IMEKKIFIBBP = true;
		}
	}

	private void MDODDIKGEHI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Roll"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Friend list count "))
		{
			IMEKKIFIBBP = true;
		}
	}

	private void CGDJGMLHDHG(float NGGKGMNEMHB)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		if (NGGKGMNEMHB > 995f)
		{
			NGGKGMNEMHB = 290f;
		}
		else if (NGGKGMNEMHB < 1632f)
		{
			NGGKGMNEMHB = 141f;
		}
		BMIKFCFMMHJ = NGGKGMNEMHB * 1374f;
		normalPainting.color = Color.Lerp(normalPainting.color, new Color(437f, 124f, 1275f, Mathf.Lerp(628f, 438f, BMIKFCFMMHJ)), Time.deltaTime * 1069f);
		if (NGGKGMNEMHB > 1098f)
		{
			BMIKFCFMMHJ = (NGGKGMNEMHB - 1565f) * 1193f;
		}
		else
		{
			BMIKFCFMMHJ = 1063f;
		}
		ghostPainting.color = Color.Lerp(ghostPainting.color, new Color(820f, 1653f, 1105f, Mathf.Lerp(379f, 789f, BMIKFCFMMHJ)), Time.deltaTime);
	}

	private void JMDOCHBJGKG()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (placeable.FHEMHCEAICB || !WorldTime.isNight)
		{
			distance = 1217f;
		}
		else if (MJGGACBHMHO || IMEKKIFIBBP)
		{
			if (MJGGACBHMHO)
			{
				distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
			}
			if (IMEKKIFIBBP)
			{
				if (MJGGACBHMHO)
				{
					if (distance > Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(4)).transform.position), Vector2.op_Implicit(((Component)this).transform.position)))
					{
						distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(7)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
					}
				}
				else
				{
					distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
				}
			}
		}
		else
		{
			distance = 1118f;
		}
		JIDKCCKKMBC((distance - 1584f) / 1460f);
	}

	private void JIDKCCKKMBC(float NGGKGMNEMHB)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		if (NGGKGMNEMHB > 1390f)
		{
			NGGKGMNEMHB = 556f;
		}
		else if (NGGKGMNEMHB < 1940f)
		{
			NGGKGMNEMHB = 765f;
		}
		BMIKFCFMMHJ = NGGKGMNEMHB * 733f;
		normalPainting.color = Color.Lerp(normalPainting.color, new Color(1949f, 1999f, 1160f, Mathf.Lerp(112f, 593f, BMIKFCFMMHJ)), Time.deltaTime * 830f);
		if (NGGKGMNEMHB > 1603f)
		{
			BMIKFCFMMHJ = (NGGKGMNEMHB - 606f) * 46f;
		}
		else
		{
			BMIKFCFMMHJ = 239f;
		}
		ghostPainting.color = Color.Lerp(ghostPainting.color, new Color(1802f, 762f, 1129f, Mathf.Lerp(679f, 801f, BMIKFCFMMHJ)), Time.deltaTime);
	}

	private void JLPLLHKJEMH()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (placeable.FHEMHCEAICB || !WorldTime.isNight)
		{
			distance = 509f;
		}
		else if (MJGGACBHMHO || IMEKKIFIBBP)
		{
			if (MJGGACBHMHO)
			{
				distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
			}
			if (IMEKKIFIBBP)
			{
				if (MJGGACBHMHO)
				{
					if (distance > Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position), Vector2.op_Implicit(((Component)this).transform.position)))
					{
						distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
					}
				}
				else
				{
					distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(4)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
				}
			}
		}
		else
		{
			distance = 128f;
		}
		MAFLLKAGDKI((distance - 1108f) / 224f);
	}

	private void JPHFCJIBBMI()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (placeable.FHEMHCEAICB || !WorldTime.isNight)
		{
			distance = 1175f;
		}
		else if (MJGGACBHMHO || IMEKKIFIBBP)
		{
			if (MJGGACBHMHO)
			{
				distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
			}
			if (IMEKKIFIBBP)
			{
				if (MJGGACBHMHO)
				{
					if (distance > Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(5)).transform.position), Vector2.op_Implicit(((Component)this).transform.position)))
					{
						distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(8)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
					}
				}
				else
				{
					distance = Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(2)).transform.position), Vector2.op_Implicit(((Component)this).transform.position));
				}
			}
		}
		else
		{
			distance = 81f;
		}
		MOOAJHFGLIH((distance - 1433f) / 1819f);
	}

	private void IBINNLHHLMD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("DecorationTile_20"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player/Bark/Error/NotAllPlayersHere"))
		{
			IMEKKIFIBBP = true;
		}
	}

	private void NKJMIFCPJFA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("RecieveSetAmbience"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("gold"))
		{
			IMEKKIFIBBP = true;
		}
	}
}
