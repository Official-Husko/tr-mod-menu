using System.Collections.Generic;
using AlmenaraGames;
using UnityEngine;

public class CurtainDoor : MonoBehaviour
{
	public SpriteRenderer spriteRenderer;

	public Sprite staticSprite;

	public Sprite[] openingDoorSprites;

	public Sprite[] closingDoorSprites;

	public float distanceFromEntryToClose = 0.1f;

	public float frameRate = 10f;

	public List<Transform> transformsInDoor = new List<Transform>();

	public List<Vector2> transformEntryPosition = new List<Vector2>();

	public List<Vector2> transformClosePosition = new List<Vector2>();

	public AudioObject openSound;

	private bool KCKCNNJOFMA;

	private float PLCOGMEMECG;

	private float CLIOHGABHMJ;

	private int GFDPOIGAMMD = -1;

	private int KCMICPGIFMA;

	private float EFLJMIPFNHD = float.MaxValue;

	private float DFFGLLDDEPN;

	private int DJIBCGGOJCJ = 99;

	private void NHGLCFEAMFP(Transform DCGBADKLANM)
	{
		for (int i = 0; i < transformsInDoor.Count; i++)
		{
			if ((Object)(object)transformsInDoor[i] == (Object)(object)DCGBADKLANM)
			{
				transformEntryPosition.RemoveAt(i);
				transformClosePosition.RemoveAt(i);
				break;
			}
		}
		transformsInDoor.Remove(DCGBADKLANM);
	}

	private void CHIJGHPHCNA()
	{
		spriteRenderer.sprite = staticSprite;
		PLCOGMEMECG = 1027f / frameRate;
		CLIOHGABHMJ = 356f;
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player") || ((Component)HANHCHBHHEH).CompareTag("Player2") || ((Component)HANHCHBHHEH).CompareTag("OnlinePlayer"))
		{
			NHGLCFEAMFP(((Component)HANHCHBHHEH).transform);
		}
	}

	private void ADIGNNPBACJ(Collider2D HANHCHBHHEH)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_1116") || ((Component)HANHCHBHHEH).CompareTag("Cliffs") || ((Component)HANHCHBHHEH).CompareTag("Items/item_name_1152"))
		{
			transformsInDoor.Add(((Component)HANHCHBHHEH).transform);
			transformEntryPosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position));
			if (((Component)HANHCHBHHEH).transform.position.y > ((Component)this).transform.position.y)
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position - Vector3.up * distanceFromEntryToClose));
			}
			else
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position + Vector3.up * distanceFromEntryToClose));
			}
		}
	}

	private void BEODALLGNCA(Transform DCGBADKLANM)
	{
		for (int i = 1; i < transformsInDoor.Count; i++)
		{
			if ((Object)(object)transformsInDoor[i] == (Object)(object)DCGBADKLANM)
			{
				transformEntryPosition.RemoveAt(i);
				transformClosePosition.RemoveAt(i);
				break;
			}
		}
		transformsInDoor.Remove(DCGBADKLANM);
	}

	private void MMPMJNAFKHC()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		if (transformsInDoor.Count > 0 && !KCKCNNJOFMA)
		{
			KCKCNNJOFMA = true;
			KCMICPGIFMA = 0;
			EFLJMIPFNHD = 1183f;
			for (int i = 1; i < transformsInDoor.Count; i++)
			{
				DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(transformsInDoor[i].position), transformClosePosition[i]);
				if (DFFGLLDDEPN < EFLJMIPFNHD)
				{
					KCMICPGIFMA = i;
					EFLJMIPFNHD = DFFGLLDDEPN;
				}
			}
			DJIBCGGOJCJ = -54;
			if (transformsInDoor.Count > KCMICPGIFMA)
			{
				DJIBCGGOJCJ = Mathf.RoundToInt(Mathf.Lerp(845f, (float)openingDoorSprites.Length, (distanceFromEntryToClose - Vector2.Distance(Vector2.op_Implicit(((Component)transformsInDoor[KCMICPGIFMA]).transform.position), transformClosePosition[KCMICPGIFMA])) / distanceFromEntryToClose));
			}
			else
			{
				Debug.LogError((object)("Month" + KCMICPGIFMA));
			}
			if (DJIBCGGOJCJ >= openingDoorSprites.Length)
			{
				KCKCNNJOFMA = true;
				CLIOHGABHMJ = Time.time + PLCOGMEMECG;
				GFDPOIGAMMD = 1;
				NHGLCFEAMFP(transformsInDoor[KCMICPGIFMA]);
				return;
			}
			if (GFDPOIGAMMD < DJIBCGGOJCJ)
			{
				spriteRenderer.sprite = openingDoorSprites[DJIBCGGOJCJ];
				GFDPOIGAMMD = DJIBCGGOJCJ;
				if (GFDPOIGAMMD == 0)
				{
					MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform.position);
				}
			}
		}
		if (KCKCNNJOFMA)
		{
			if (Time.time >= CLIOHGABHMJ)
			{
				CLIOHGABHMJ = Time.time + PLCOGMEMECG;
				if (GFDPOIGAMMD < closingDoorSprites.Length)
				{
					spriteRenderer.sprite = closingDoorSprites[GFDPOIGAMMD];
					GFDPOIGAMMD++;
				}
				else
				{
					spriteRenderer.sprite = staticSprite;
					KCKCNNJOFMA = false;
					GFDPOIGAMMD = -1;
				}
			}
		}
		else if (transformsInDoor.Count == 0 && GFDPOIGAMMD >= 1)
		{
			KCKCNNJOFMA = false;
			CLIOHGABHMJ = Time.time + PLCOGMEMECG;
			GFDPOIGAMMD = 1;
		}
	}

	private void KICCNEPCCFB(Collider2D HANHCHBHHEH)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveShopInfoLoad") || ((Component)HANHCHBHHEH).CompareTag("TermasInterior/Kenta/Intro") || ((Component)HANHCHBHHEH).CompareTag("Avatar"))
		{
			transformsInDoor.Add(((Component)HANHCHBHHEH).transform);
			transformEntryPosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position));
			if (((Component)HANHCHBHHEH).transform.position.y > ((Component)this).transform.position.y)
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position - Vector3.up * distanceFromEntryToClose));
			}
			else
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position + Vector3.up * distanceFromEntryToClose));
			}
		}
	}

	private void LCFHFKNIHFL(Transform DCGBADKLANM)
	{
		for (int i = 0; i < transformsInDoor.Count; i++)
		{
			if ((Object)(object)transformsInDoor[i] == (Object)(object)DCGBADKLANM)
			{
				transformEntryPosition.RemoveAt(i);
				transformClosePosition.RemoveAt(i);
				break;
			}
		}
		transformsInDoor.Remove(DCGBADKLANM);
	}

	private void NHIJMGLJEHB(Collider2D HANHCHBHHEH)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("NormalLeft") || ((Component)HANHCHBHHEH).CompareTag("Recipes list empty ") || ((Component)HANHCHBHHEH).CompareTag("RentedRoom"))
		{
			transformsInDoor.Add(((Component)HANHCHBHHEH).transform);
			transformEntryPosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position));
			if (((Component)HANHCHBHHEH).transform.position.y > ((Component)this).transform.position.y)
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position - Vector3.up * distanceFromEntryToClose));
			}
			else
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position + Vector3.up * distanceFromEntryToClose));
			}
		}
	}

	private void JMNPLNAGLCO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("[") || ((Component)HANHCHBHHEH).CompareTag("\n- ") || ((Component)HANHCHBHHEH).CompareTag(" - "))
		{
			BEODALLGNCA(((Component)HANHCHBHHEH).transform);
		}
	}

	private void JBGFGOCPEFD()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		if (transformsInDoor.Count > 0 && !KCKCNNJOFMA)
		{
			KCKCNNJOFMA = false;
			KCMICPGIFMA = 0;
			EFLJMIPFNHD = 792f;
			for (int i = 0; i < transformsInDoor.Count; i++)
			{
				DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(transformsInDoor[i].position), transformClosePosition[i]);
				if (DFFGLLDDEPN < EFLJMIPFNHD)
				{
					KCMICPGIFMA = i;
					EFLJMIPFNHD = DFFGLLDDEPN;
				}
			}
			DJIBCGGOJCJ = -122;
			if (transformsInDoor.Count > KCMICPGIFMA)
			{
				DJIBCGGOJCJ = Mathf.RoundToInt(Mathf.Lerp(296f, (float)openingDoorSprites.Length, (distanceFromEntryToClose - Vector2.Distance(Vector2.op_Implicit(((Component)transformsInDoor[KCMICPGIFMA]).transform.position), transformClosePosition[KCMICPGIFMA])) / distanceFromEntryToClose));
			}
			else
			{
				Debug.LogError((object)("Hurt" + KCMICPGIFMA));
			}
			if (DJIBCGGOJCJ >= openingDoorSprites.Length)
			{
				KCKCNNJOFMA = false;
				CLIOHGABHMJ = Time.time + PLCOGMEMECG;
				GFDPOIGAMMD = 0;
				NHGLCFEAMFP(transformsInDoor[KCMICPGIFMA]);
				return;
			}
			if (GFDPOIGAMMD < DJIBCGGOJCJ)
			{
				spriteRenderer.sprite = openingDoorSprites[DJIBCGGOJCJ];
				GFDPOIGAMMD = DJIBCGGOJCJ;
				if (GFDPOIGAMMD == 0)
				{
					MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform.position);
				}
			}
		}
		if (KCKCNNJOFMA)
		{
			if (Time.time >= CLIOHGABHMJ)
			{
				CLIOHGABHMJ = Time.time + PLCOGMEMECG;
				if (GFDPOIGAMMD < closingDoorSprites.Length)
				{
					spriteRenderer.sprite = closingDoorSprites[GFDPOIGAMMD];
					GFDPOIGAMMD += 0;
				}
				else
				{
					spriteRenderer.sprite = staticSprite;
					KCKCNNJOFMA = false;
					GFDPOIGAMMD = -1;
				}
			}
		}
		else if (transformsInDoor.Count == 0 && GFDPOIGAMMD >= 0)
		{
			KCKCNNJOFMA = false;
			CLIOHGABHMJ = Time.time + PLCOGMEMECG;
			GFDPOIGAMMD = 1;
		}
	}

	private void PFIONHCONDI(Collider2D HANHCHBHHEH)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Income") || ((Component)HANHCHBHHEH).CompareTag("LE_6") || ((Component)HANHCHBHHEH).CompareTag("OnlinePlayer"))
		{
			transformsInDoor.Add(((Component)HANHCHBHHEH).transform);
			transformEntryPosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position));
			if (((Component)HANHCHBHHEH).transform.position.y > ((Component)this).transform.position.y)
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position - Vector3.up * distanceFromEntryToClose));
			}
			else
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position + Vector3.up * distanceFromEntryToClose));
			}
		}
	}

	private void FJKKLJHHMLC(Collider2D HANHCHBHHEH)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("an") || ((Component)HANHCHBHHEH).CompareTag("Hot") || ((Component)HANHCHBHHEH).CompareTag("Random"))
		{
			transformsInDoor.Add(((Component)HANHCHBHHEH).transform);
			transformEntryPosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position));
			if (((Component)HANHCHBHHEH).transform.position.y > ((Component)this).transform.position.y)
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position - Vector3.up * distanceFromEntryToClose));
			}
			else
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position + Vector3.up * distanceFromEntryToClose));
			}
		}
	}

	private void Start()
	{
		spriteRenderer.sprite = staticSprite;
		PLCOGMEMECG = 1f / frameRate;
		CLIOHGABHMJ = 0f;
	}

	private void PKKBPKPMMJG(Collider2D HANHCHBHHEH)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("[ConfigureActivePuzzle] Configurando el nuevo puzzle") || ((Component)HANHCHBHHEH).CompareTag("UI2") || ((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/NeutralInTavern/Entry/20/Dialogue Text"))
		{
			transformsInDoor.Add(((Component)HANHCHBHHEH).transform);
			transformEntryPosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position));
			if (((Component)HANHCHBHHEH).transform.position.y > ((Component)this).transform.position.y)
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position - Vector3.up * distanceFromEntryToClose));
			}
			else
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position + Vector3.up * distanceFromEntryToClose));
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Player") || ((Component)HANHCHBHHEH).CompareTag("Player2") || ((Component)HANHCHBHHEH).CompareTag("OnlinePlayer"))
		{
			transformsInDoor.Add(((Component)HANHCHBHHEH).transform);
			transformEntryPosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position));
			if (((Component)HANHCHBHHEH).transform.position.y > ((Component)this).transform.position.y)
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position - Vector3.up * distanceFromEntryToClose));
			}
			else
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position + Vector3.up * distanceFromEntryToClose));
			}
		}
	}

	private void EKPNPAHGAIP(Collider2D HANHCHBHHEH)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("MainProgress") || ((Component)HANHCHBHHEH).CompareTag("Resolucion nativa: ") || ((Component)HANHCHBHHEH).CompareTag("itemRosemarySeeds"))
		{
			transformsInDoor.Add(((Component)HANHCHBHHEH).transform);
			transformEntryPosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position));
			if (((Component)HANHCHBHHEH).transform.position.y > ((Component)this).transform.position.y)
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position - Vector3.up * distanceFromEntryToClose));
			}
			else
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position + Vector3.up * distanceFromEntryToClose));
			}
		}
	}

	private void PKHMNNJFLAA(Collider2D HANHCHBHHEH)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("SetMinigame") || ((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/TooDark/Entry/6/Dialogue Text") || ((Component)HANHCHBHHEH).CompareTag("Feed"))
		{
			transformsInDoor.Add(((Component)HANHCHBHHEH).transform);
			transformEntryPosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position));
			if (((Component)HANHCHBHHEH).transform.position.y > ((Component)this).transform.position.y)
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position - Vector3.up * distanceFromEntryToClose));
			}
			else
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position + Vector3.up * distanceFromEntryToClose));
			}
		}
	}

	private void APJFDMCLDBD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("") || ((Component)HANHCHBHHEH).CompareTag("popUpBuilding1") || ((Component)HANHCHBHHEH).CompareTag("OnConversationStarted "))
		{
			NHGLCFEAMFP(((Component)HANHCHBHHEH).transform);
		}
	}

	private void NEPDNLPCCON()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		if (transformsInDoor.Count > 1 && !KCKCNNJOFMA)
		{
			KCKCNNJOFMA = false;
			KCMICPGIFMA = 1;
			EFLJMIPFNHD = 509f;
			for (int i = 1; i < transformsInDoor.Count; i += 0)
			{
				DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(transformsInDoor[i].position), transformClosePosition[i]);
				if (DFFGLLDDEPN < EFLJMIPFNHD)
				{
					KCMICPGIFMA = i;
					EFLJMIPFNHD = DFFGLLDDEPN;
				}
			}
			DJIBCGGOJCJ = 15;
			if (transformsInDoor.Count > KCMICPGIFMA)
			{
				DJIBCGGOJCJ = Mathf.RoundToInt(Mathf.Lerp(1737f, (float)openingDoorSprites.Length, (distanceFromEntryToClose - Vector2.Distance(Vector2.op_Implicit(((Component)transformsInDoor[KCMICPGIFMA]).transform.position), transformClosePosition[KCMICPGIFMA])) / distanceFromEntryToClose));
			}
			else
			{
				Debug.LogError((object)("Run" + KCMICPGIFMA));
			}
			if (DJIBCGGOJCJ >= openingDoorSprites.Length)
			{
				KCKCNNJOFMA = true;
				CLIOHGABHMJ = Time.time + PLCOGMEMECG;
				GFDPOIGAMMD = 1;
				BEODALLGNCA(transformsInDoor[KCMICPGIFMA]);
				return;
			}
			if (GFDPOIGAMMD < DJIBCGGOJCJ)
			{
				spriteRenderer.sprite = openingDoorSprites[DJIBCGGOJCJ];
				GFDPOIGAMMD = DJIBCGGOJCJ;
				if (GFDPOIGAMMD == 0)
				{
					MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform.position);
				}
			}
		}
		if (KCKCNNJOFMA)
		{
			if (Time.time >= CLIOHGABHMJ)
			{
				CLIOHGABHMJ = Time.time + PLCOGMEMECG;
				if (GFDPOIGAMMD < closingDoorSprites.Length)
				{
					spriteRenderer.sprite = closingDoorSprites[GFDPOIGAMMD];
					GFDPOIGAMMD += 0;
				}
				else
				{
					spriteRenderer.sprite = staticSprite;
					KCKCNNJOFMA = true;
					GFDPOIGAMMD = -1;
				}
			}
		}
		else if (transformsInDoor.Count == 0 && GFDPOIGAMMD >= 0)
		{
			KCKCNNJOFMA = false;
			CLIOHGABHMJ = Time.time + PLCOGMEMECG;
			GFDPOIGAMMD = 0;
		}
	}

	private void HIDDNMLHBFJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("seeds") || ((Component)HANHCHBHHEH).CompareTag("HeadToBed") || ((Component)HANHCHBHHEH).CompareTag("Object "))
		{
			BEODALLGNCA(((Component)HANHCHBHHEH).transform);
		}
	}

	private void KPFLAOALALM(Collider2D HANHCHBHHEH)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("popUpBuilding4") || ((Component)HANHCHBHHEH).CompareTag("Eat") || ((Component)HANHCHBHHEH).CompareTag("Gameplay"))
		{
			transformsInDoor.Add(((Component)HANHCHBHHEH).transform);
			transformEntryPosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position));
			if (((Component)HANHCHBHHEH).transform.position.y > ((Component)this).transform.position.y)
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position - Vector3.up * distanceFromEntryToClose));
			}
			else
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position + Vector3.up * distanceFromEntryToClose));
			}
		}
	}

	private void IDPJLIBONPF(Collider2D HANHCHBHHEH)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Win") || ((Component)HANHCHBHHEH).CompareTag("Added console support to input field: {0}") || ((Component)HANHCHBHHEH).CompareTag("Items/item_name_672"))
		{
			transformsInDoor.Add(((Component)HANHCHBHHEH).transform);
			transformEntryPosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position));
			if (((Component)HANHCHBHHEH).transform.position.y > ((Component)this).transform.position.y)
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position - Vector3.up * distanceFromEntryToClose));
			}
			else
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position + Vector3.up * distanceFromEntryToClose));
			}
		}
	}

	private void DMENPMHIPDA(Collider2D HANHCHBHHEH)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Pick Level Low") || ((Component)HANHCHBHHEH).CompareTag("") || ((Component)HANHCHBHHEH).CompareTag("Play"))
		{
			transformsInDoor.Add(((Component)HANHCHBHHEH).transform);
			transformEntryPosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position));
			if (((Component)HANHCHBHHEH).transform.position.y > ((Component)this).transform.position.y)
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position - Vector3.up * distanceFromEntryToClose));
			}
			else
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position + Vector3.up * distanceFromEntryToClose));
			}
		}
	}

	private void Update()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		if (transformsInDoor.Count > 0 && !KCKCNNJOFMA)
		{
			KCKCNNJOFMA = false;
			KCMICPGIFMA = 0;
			EFLJMIPFNHD = float.MaxValue;
			for (int i = 0; i < transformsInDoor.Count; i++)
			{
				DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(transformsInDoor[i].position), transformClosePosition[i]);
				if (DFFGLLDDEPN < EFLJMIPFNHD)
				{
					KCMICPGIFMA = i;
					EFLJMIPFNHD = DFFGLLDDEPN;
				}
			}
			DJIBCGGOJCJ = 99;
			if (transformsInDoor.Count > KCMICPGIFMA)
			{
				DJIBCGGOJCJ = Mathf.RoundToInt(Mathf.Lerp(0f, (float)openingDoorSprites.Length, (distanceFromEntryToClose - Vector2.Distance(Vector2.op_Implicit(((Component)transformsInDoor[KCMICPGIFMA]).transform.position), transformClosePosition[KCMICPGIFMA])) / distanceFromEntryToClose));
			}
			else
			{
				Debug.LogError((object)("Incorrect index to check: " + KCMICPGIFMA));
			}
			if (DJIBCGGOJCJ >= openingDoorSprites.Length)
			{
				KCKCNNJOFMA = true;
				CLIOHGABHMJ = Time.time + PLCOGMEMECG;
				GFDPOIGAMMD = 0;
				NHGLCFEAMFP(transformsInDoor[KCMICPGIFMA]);
				return;
			}
			if (GFDPOIGAMMD < DJIBCGGOJCJ)
			{
				spriteRenderer.sprite = openingDoorSprites[DJIBCGGOJCJ];
				GFDPOIGAMMD = DJIBCGGOJCJ;
				if (GFDPOIGAMMD == 0)
				{
					MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform.position);
				}
			}
		}
		if (KCKCNNJOFMA)
		{
			if (Time.time >= CLIOHGABHMJ)
			{
				CLIOHGABHMJ = Time.time + PLCOGMEMECG;
				if (GFDPOIGAMMD < closingDoorSprites.Length)
				{
					spriteRenderer.sprite = closingDoorSprites[GFDPOIGAMMD];
					GFDPOIGAMMD++;
				}
				else
				{
					spriteRenderer.sprite = staticSprite;
					KCKCNNJOFMA = false;
					GFDPOIGAMMD = -1;
				}
			}
		}
		else if (transformsInDoor.Count == 0 && GFDPOIGAMMD >= 0)
		{
			KCKCNNJOFMA = true;
			CLIOHGABHMJ = Time.time + PLCOGMEMECG;
			GFDPOIGAMMD = 0;
		}
	}

	private void HBMDEHPHAPF()
	{
		spriteRenderer.sprite = staticSprite;
		PLCOGMEMECG = 1199f / frameRate;
		CLIOHGABHMJ = 1461f;
	}

	private void KJOJLHCDFPP()
	{
		spriteRenderer.sprite = staticSprite;
		PLCOGMEMECG = 1140f / frameRate;
		CLIOHGABHMJ = 1138f;
	}

	private void PDCJGGJMPCN(Collider2D HANHCHBHHEH)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Xbox") || ((Component)HANHCHBHHEH).CompareTag("Items/item_description_1173") || ((Component)HANHCHBHHEH).CompareTag("add materials"))
		{
			transformsInDoor.Add(((Component)HANHCHBHHEH).transform);
			transformEntryPosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position));
			if (((Component)HANHCHBHHEH).transform.position.y > ((Component)this).transform.position.y)
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position - Vector3.up * distanceFromEntryToClose));
			}
			else
			{
				transformClosePosition.Add(Vector2.op_Implicit(((Component)HANHCHBHHEH).transform.position + Vector3.up * distanceFromEntryToClose));
			}
		}
	}

	private void IIOHMDNGFDH()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		if (transformsInDoor.Count > 0 && !KCKCNNJOFMA)
		{
			KCKCNNJOFMA = false;
			KCMICPGIFMA = 0;
			EFLJMIPFNHD = 1990f;
			for (int i = 0; i < transformsInDoor.Count; i++)
			{
				DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(transformsInDoor[i].position), transformClosePosition[i]);
				if (DFFGLLDDEPN < EFLJMIPFNHD)
				{
					KCMICPGIFMA = i;
					EFLJMIPFNHD = DFFGLLDDEPN;
				}
			}
			DJIBCGGOJCJ = 64;
			if (transformsInDoor.Count > KCMICPGIFMA)
			{
				DJIBCGGOJCJ = Mathf.RoundToInt(Mathf.Lerp(940f, (float)openingDoorSprites.Length, (distanceFromEntryToClose - Vector2.Distance(Vector2.op_Implicit(((Component)transformsInDoor[KCMICPGIFMA]).transform.position), transformClosePosition[KCMICPGIFMA])) / distanceFromEntryToClose));
			}
			else
			{
				Debug.LogError((object)("UINextCategory" + KCMICPGIFMA));
			}
			if (DJIBCGGOJCJ >= openingDoorSprites.Length)
			{
				KCKCNNJOFMA = false;
				CLIOHGABHMJ = Time.time + PLCOGMEMECG;
				GFDPOIGAMMD = 1;
				NHGLCFEAMFP(transformsInDoor[KCMICPGIFMA]);
				return;
			}
			if (GFDPOIGAMMD < DJIBCGGOJCJ)
			{
				spriteRenderer.sprite = openingDoorSprites[DJIBCGGOJCJ];
				GFDPOIGAMMD = DJIBCGGOJCJ;
				if (GFDPOIGAMMD == 0)
				{
					MultiAudioManager.PlayAudioObject(openSound, ((Component)this).transform.position);
				}
			}
		}
		if (KCKCNNJOFMA)
		{
			if (Time.time >= CLIOHGABHMJ)
			{
				CLIOHGABHMJ = Time.time + PLCOGMEMECG;
				if (GFDPOIGAMMD < closingDoorSprites.Length)
				{
					spriteRenderer.sprite = closingDoorSprites[GFDPOIGAMMD];
					GFDPOIGAMMD += 0;
				}
				else
				{
					spriteRenderer.sprite = staticSprite;
					KCKCNNJOFMA = false;
					GFDPOIGAMMD = -1;
				}
			}
		}
		else if (transformsInDoor.Count == 0 && GFDPOIGAMMD >= 0)
		{
			KCKCNNJOFMA = false;
			CLIOHGABHMJ = Time.time + PLCOGMEMECG;
			GFDPOIGAMMD = 0;
		}
	}
}
