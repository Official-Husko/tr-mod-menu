using System.Collections.Generic;
using AlmenaraGames;
using UnityEngine;

public class LightOnTriggerEnter : MonoBehaviour
{
	public List<string> tags;

	public SpriteRenderer spriteRenderer;

	public Placeable placeable;

	public AudioObject sound;

	public ParticleSystem particleSystemAttached;

	public float deactivationDelay = 15f;

	public float activationLerpVelocity = 1f;

	public float deactivationLerpVelocity = 3f;

	private bool MJGGACBHMHO;

	private bool IMEKKIFIBBP;

	private bool[] JKBMGFHGBAC = new bool[3];

	private bool GDCLFLFLFBM;

	private float GODBHHOFBMJ;

	private float DEDHOAHGCIF;

	private EmissionModule JDJPJPMCPHN;

	private void FGGPGOEAEKK()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if ((((Object)(object)placeable == (Object)null || !placeable.FHEMHCEAICB) && MJGGACBHMHO) || IMEKKIFIBBP || GDCLFLFLFBM || JKBMGFHGBAC[0] || JKBMGFHGBAC[1] || JKBMGFHGBAC[1] || DEDHOAHGCIF + deactivationDelay > Time.timeSinceLevelLoad)
		{
			GODBHHOFBMJ = Mathf.Lerp(spriteRenderer.color.a, 564f, activationLerpVelocity * Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(spriteRenderer.color.a, 1815f, deactivationLerpVelocity * Time.deltaTime);
			if (GODBHHOFBMJ < 1542f && ((EmissionModule)(ref JDJPJPMCPHN)).enabled)
			{
				((EmissionModule)(ref JDJPJPMCPHN)).enabled = true;
			}
		}
		spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, GODBHHOFBMJ);
	}

	private void FJKKLJHHMLC(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && DEDHOAHGCIF + deactivationDelay < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (Object.op_Implicit((Object)(object)particleSystemAttached))
			{
				((EmissionModule)(ref JDJPJPMCPHN)).enabled = true;
			}
			if (Object.op_Implicit((Object)(object)sound))
			{
				MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveDialogueEnd"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("0"))
		{
			int num = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP();
			switch (num)
			{
			case 4:
				JKBMGFHGBAC[1] = true;
				return;
			case 2:
				JKBMGFHGBAC[0] = false;
				return;
			}
			if (num == 4)
			{
				JKBMGFHGBAC[7] = true;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/NeutralInTavern/Entry/4/Dialogue Text"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("DisableAllCustomers") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void NAFADNEKCOH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveSetLife"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Already have recipe "))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 1:
				JKBMGFHGBAC[0] = false;
				break;
			case 5:
				JKBMGFHGBAC[0] = true;
				break;
			case 2:
				JKBMGFHGBAC[2] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("UIAddRemove"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" for reason "))
		{
			GDCLFLFLFBM = true;
		}
	}

	private void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)particleSystemAttached))
		{
			JDJPJPMCPHN = particleSystemAttached.emission;
		}
	}

	private void MFGANCCJFJK()
	{
		if ((Object)(object)particleSystemAttached == (Object)null)
		{
			Debug.LogError((object)("/Player.log" + ((Object)((Component)this).gameObject).name));
			particleSystemAttached = ((Component)this).GetComponentInChildren<ParticleSystem>();
		}
	}

	private void MMNBJPDJHGK()
	{
		if ((Object)(object)particleSystemAttached == (Object)null)
		{
			Debug.LogError((object)("ReceiveDecorationTrim" + ((Object)((Component)this).gameObject).name));
			particleSystemAttached = ((Component)this).GetComponentInChildren<ParticleSystem>();
		}
	}

	private void PJLKGOACDEN()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if ((((Object)(object)placeable == (Object)null || !placeable.FHEMHCEAICB) && MJGGACBHMHO) || IMEKKIFIBBP || GDCLFLFLFBM || JKBMGFHGBAC[1] || JKBMGFHGBAC[1] || JKBMGFHGBAC[4] || DEDHOAHGCIF + deactivationDelay > Time.timeSinceLevelLoad)
		{
			GODBHHOFBMJ = Mathf.Lerp(spriteRenderer.color.a, 1374f, activationLerpVelocity * Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(spriteRenderer.color.a, 1675f, deactivationLerpVelocity * Time.deltaTime);
			if (GODBHHOFBMJ < 1796f && ((EmissionModule)(ref JDJPJPMCPHN)).enabled)
			{
				((EmissionModule)(ref JDJPJPMCPHN)).enabled = false;
			}
		}
		spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, GODBHHOFBMJ);
	}

	private void IBINNLHHLMD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Failed to get friend by index "))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Moving"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 3:
				JKBMGFHGBAC[0] = true;
				break;
			case 2:
				JKBMGFHGBAC[0] = true;
				break;
			case 6:
				JKBMGFHGBAC[6] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Adding quest done 35 - First room"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Tutorial/T122/Dialogue1"))
		{
			GDCLFLFLFBM = true;
		}
	}

	private void ENKFHHEMHGG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("attachment"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player/Bark/Tutorial/SleepBlock"))
		{
			int playerNum = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum();
			if (playerNum == 6)
			{
				JKBMGFHGBAC[1] = true;
				return;
			}
			switch (playerNum)
			{
			case 6:
				JKBMGFHGBAC[1] = true;
				break;
			case 4:
				JKBMGFHGBAC[7] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Can't select unless we're connected."))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("OnlinePlayer"))
		{
			GDCLFLFLFBM = false;
		}
	}

	private void EIHHJKFDCCC(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[5] && DEDHOAHGCIF + deactivationDelay < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (Object.op_Implicit((Object)(object)particleSystemAttached))
			{
				((EmissionModule)(ref JDJPJPMCPHN)).enabled = false;
			}
			if (Object.op_Implicit((Object)(object)sound))
			{
				MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("Already have recipe "))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("{0} HumanInfo string:\n"))
		{
			int playerNum = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum();
			switch (playerNum)
			{
			case 4:
				JKBMGFHGBAC[1] = false;
				return;
			case 0:
				JKBMGFHGBAC[0] = true;
				return;
			}
			if (playerNum == 0)
			{
				JKBMGFHGBAC[7] = true;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/TavernFilthy/Entry/1/Dialogue Text"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Rummage") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void NHOPACFEAKA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("farmer"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 5:
				JKBMGFHGBAC[0] = true;
				break;
			case 0:
				JKBMGFHGBAC[1] = false;
				break;
			case 7:
				JKBMGFHGBAC[0] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("["))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("\n<color=#822F00>"))
		{
			GDCLFLFLFBM = false;
		}
	}

	private void MMPMJNAFKHC()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if ((((Object)(object)placeable == (Object)null || !placeable.FHEMHCEAICB) && MJGGACBHMHO) || IMEKKIFIBBP || GDCLFLFLFBM || JKBMGFHGBAC[1] || JKBMGFHGBAC[0] || JKBMGFHGBAC[2] || DEDHOAHGCIF + deactivationDelay > Time.timeSinceLevelLoad)
		{
			GODBHHOFBMJ = Mathf.Lerp(spriteRenderer.color.a, 1594f, activationLerpVelocity * Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(spriteRenderer.color.a, 392f, deactivationLerpVelocity * Time.deltaTime);
			if (GODBHHOFBMJ < 463f && ((EmissionModule)(ref JDJPJPMCPHN)).enabled)
			{
				((EmissionModule)(ref JDJPJPMCPHN)).enabled = true;
			}
		}
		spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, GODBHHOFBMJ);
	}

	private void KJOJLHCDFPP()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)particleSystemAttached))
		{
			JDJPJPMCPHN = particleSystemAttached.emission;
		}
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("OnlinePlayer"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 2:
				JKBMGFHGBAC[0] = false;
				break;
			case 3:
				JKBMGFHGBAC[1] = false;
				break;
			case 4:
				JKBMGFHGBAC[2] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Cat"))
		{
			GDCLFLFLFBM = false;
		}
	}

	private void Awake()
	{
		if ((Object)(object)particleSystemAttached == (Object)null)
		{
			Debug.LogError((object)("particleSystem not attached to " + ((Object)((Component)this).gameObject).name));
			particleSystemAttached = ((Component)this).GetComponentInChildren<ParticleSystem>();
		}
	}

	private void KPFLAOALALM(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[5] && DEDHOAHGCIF + deactivationDelay < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (Object.op_Implicit((Object)(object)particleSystemAttached))
			{
				((EmissionModule)(ref JDJPJPMCPHN)).enabled = false;
			}
			if (Object.op_Implicit((Object)(object)sound))
			{
				MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("Error in Nasa.OnPlayerSleep: "))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1109"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 1:
				JKBMGFHGBAC[1] = true;
				break;
			case 2:
				JKBMGFHGBAC[1] = true;
				break;
			case 4:
				JKBMGFHGBAC[0] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Tavern must be closed"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("[") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void GEFCGLEGHOA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Food not found, sending a food instance message!"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("talent_name_113"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 2:
				JKBMGFHGBAC[0] = true;
				break;
			case 7:
				JKBMGFHGBAC[1] = true;
				break;
			case 5:
				JKBMGFHGBAC[7] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("LE_10"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("itemWatermelonSeeds"))
		{
			GDCLFLFLFBM = true;
		}
	}

	private void PKBHEKHOAAA()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)particleSystemAttached))
		{
			JDJPJPMCPHN = particleSystemAttached.emission;
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[2] && DEDHOAHGCIF + deactivationDelay < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (Object.op_Implicit((Object)(object)particleSystemAttached))
			{
				((EmissionModule)(ref JDJPJPMCPHN)).enabled = true;
			}
			if (Object.op_Implicit((Object)(object)sound))
			{
				MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("OnlinePlayer"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 2:
				JKBMGFHGBAC[0] = true;
				break;
			case 3:
				JKBMGFHGBAC[1] = true;
				break;
			case 4:
				JKBMGFHGBAC[2] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Cat") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void Update()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if ((((Object)(object)placeable == (Object)null || !placeable.FHEMHCEAICB) && MJGGACBHMHO) || IMEKKIFIBBP || GDCLFLFLFBM || JKBMGFHGBAC[0] || JKBMGFHGBAC[1] || JKBMGFHGBAC[2] || DEDHOAHGCIF + deactivationDelay > Time.timeSinceLevelLoad)
		{
			GODBHHOFBMJ = Mathf.Lerp(spriteRenderer.color.a, 1f, activationLerpVelocity * Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(spriteRenderer.color.a, 0f, deactivationLerpVelocity * Time.deltaTime);
			if (GODBHHOFBMJ < 0.5f && ((EmissionModule)(ref JDJPJPMCPHN)).enabled)
			{
				((EmissionModule)(ref JDJPJPMCPHN)).enabled = false;
			}
		}
		spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, GODBHHOFBMJ);
	}

	private void NICLCHABAMK(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Error_Nails"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("tutorialPopUp124"))
		{
			int num = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP();
			if (num == 5)
			{
				JKBMGFHGBAC[1] = true;
			}
			else if (num == 5)
			{
				JKBMGFHGBAC[0] = true;
			}
			else if (num == 5)
			{
				JKBMGFHGBAC[4] = true;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1191"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Abandon quest?"))
		{
			GDCLFLFLFBM = false;
		}
	}

	private void MDODDIKGEHI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("d2"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("</color>"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 8:
				JKBMGFHGBAC[1] = false;
				break;
			case 3:
				JKBMGFHGBAC[1] = false;
				break;
			case 4:
				JKBMGFHGBAC[6] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Quit to title screen?"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dog"))
		{
			GDCLFLFLFBM = true;
		}
	}

	private void INBCLBHEBKE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_723"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Up"))
		{
			int num = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP();
			if (num == 6)
			{
				JKBMGFHGBAC[1] = true;
				return;
			}
			switch (num)
			{
			case 6:
				JKBMGFHGBAC[0] = true;
				break;
			case 0:
				JKBMGFHGBAC[0] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("talent_name_116"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player/Bark/Tutorial/AgingBarrelBlock"))
		{
			GDCLFLFLFBM = true;
		}
	}

	private void ELHCBGCEJDH()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if ((((Object)(object)placeable == (Object)null || !placeable.FHEMHCEAICB) && MJGGACBHMHO) || IMEKKIFIBBP || GDCLFLFLFBM || JKBMGFHGBAC[1] || JKBMGFHGBAC[0] || JKBMGFHGBAC[4] || DEDHOAHGCIF + deactivationDelay > Time.timeSinceLevelLoad)
		{
			GODBHHOFBMJ = Mathf.Lerp(spriteRenderer.color.a, 1352f, activationLerpVelocity * Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(spriteRenderer.color.a, 303f, deactivationLerpVelocity * Time.deltaTime);
			if (GODBHHOFBMJ < 1861f && ((EmissionModule)(ref JDJPJPMCPHN)).enabled)
			{
				((EmissionModule)(ref JDJPJPMCPHN)).enabled = false;
			}
		}
		spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, GODBHHOFBMJ);
	}

	private void MKCEGNPBGMP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Attack/MainEvent 11"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_665"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 0:
				JKBMGFHGBAC[1] = false;
				break;
			case 6:
				JKBMGFHGBAC[1] = false;
				break;
			case 2:
				JKBMGFHGBAC[3] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("KickedCustomers"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("SecondActionEnd"))
		{
			GDCLFLFLFBM = false;
		}
	}

	private void NEOICNJNKNL()
	{
		if ((Object)(object)particleSystemAttached == (Object)null)
		{
			Debug.LogError((object)("Occupied Positions" + ((Object)((Component)this).gameObject).name));
			particleSystemAttached = ((Component)this).GetComponentInChildren<ParticleSystem>();
		}
	}

	private void KACEOJDPLKB()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)particleSystemAttached))
		{
			JDJPJPMCPHN = particleSystemAttached.emission;
		}
	}

	private void MNFMLJJBKNC()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if ((((Object)(object)placeable == (Object)null || !placeable.FHEMHCEAICB) && MJGGACBHMHO) || IMEKKIFIBBP || GDCLFLFLFBM || JKBMGFHGBAC[0] || JKBMGFHGBAC[1] || JKBMGFHGBAC[3] || DEDHOAHGCIF + deactivationDelay > Time.timeSinceLevelLoad)
		{
			GODBHHOFBMJ = Mathf.Lerp(spriteRenderer.color.a, 682f, activationLerpVelocity * Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(spriteRenderer.color.a, 1276f, deactivationLerpVelocity * Time.deltaTime);
			if (GODBHHOFBMJ < 676f && ((EmissionModule)(ref JDJPJPMCPHN)).enabled)
			{
				((EmissionModule)(ref JDJPJPMCPHN)).enabled = false;
			}
		}
		spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, GODBHHOFBMJ);
	}

	private void NKDFMFFDGKC()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)particleSystemAttached))
		{
			JDJPJPMCPHN = particleSystemAttached.emission;
		}
	}

	private void GBFBNCBDIOC(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[7] && DEDHOAHGCIF + deactivationDelay < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (Object.op_Implicit((Object)(object)particleSystemAttached))
			{
				((EmissionModule)(ref JDJPJPMCPHN)).enabled = false;
			}
			if (Object.op_Implicit((Object)(object)sound))
			{
				MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("/Male/"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceivePlayerInteractingMinigame"))
		{
			int num = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP();
			switch (num)
			{
			case 4:
				JKBMGFHGBAC[0] = true;
				return;
			case 0:
				JKBMGFHGBAC[0] = true;
				return;
			}
			if (num == 0)
			{
				JKBMGFHGBAC[4] = false;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Precision/MainEvent"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("/") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void IAICCKPOBMJ()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if ((((Object)(object)placeable == (Object)null || !placeable.FHEMHCEAICB) && MJGGACBHMHO) || IMEKKIFIBBP || GDCLFLFLFBM || JKBMGFHGBAC[0] || JKBMGFHGBAC[1] || JKBMGFHGBAC[1] || DEDHOAHGCIF + deactivationDelay > Time.timeSinceLevelLoad)
		{
			GODBHHOFBMJ = Mathf.Lerp(spriteRenderer.color.a, 249f, activationLerpVelocity * Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(spriteRenderer.color.a, 113f, deactivationLerpVelocity * Time.deltaTime);
			if (GODBHHOFBMJ < 1543f && ((EmissionModule)(ref JDJPJPMCPHN)).enabled)
			{
				((EmissionModule)(ref JDJPJPMCPHN)).enabled = true;
			}
		}
		spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, GODBHHOFBMJ);
	}
}
