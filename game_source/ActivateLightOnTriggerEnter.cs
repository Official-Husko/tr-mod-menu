using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class ActivateLightOnTriggerEnter : MonoBehaviour
{
	public List<string> tags;

	public Light2D light2d;

	public Placeable placeable;

	public float increaseVelocity = 2f;

	public float decreaseVelocity = 3f;

	private float JLLOJEPJLKM;

	private bool MJGGACBHMHO;

	private bool IMEKKIFIBBP;

	private bool[] JKBMGFHGBAC = new bool[3];

	private bool GDCLFLFLFBM;

	private void Update()
	{
		if (MJGGACBHMHO || IMEKKIFIBBP || GDCLFLFLFBM || JKBMGFHGBAC[0] || JKBMGFHGBAC[1] || JKBMGFHGBAC[2])
		{
			light2d.intensity = Mathf.Lerp(light2d.intensity, 1f, increaseVelocity * Time.deltaTime);
		}
		else
		{
			light2d.intensity = Mathf.Lerp(light2d.intensity, 0f, decreaseVelocity * Time.deltaTime);
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

	private void PKKBPKPMMJG(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Melt"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 6:
				JKBMGFHGBAC[1] = true;
				break;
			case 3:
				JKBMGFHGBAC[0] = true;
				break;
			case 1:
				JKBMGFHGBAC[5] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveAddAvailableQuestToCurrentQuest") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void NPIDHDAIPKG(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_645"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 7:
				JKBMGFHGBAC[1] = true;
				break;
			case 3:
				JKBMGFHGBAC[1] = true;
				break;
			case 0:
				JKBMGFHGBAC[8] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Customise Character"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveWateringCanAction") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void EKPNPAHGAIP(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (((Component)HANHCHBHHEH).CompareTag("hallway"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Disable Bob"))
		{
			int num = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP();
			switch (num)
			{
			case 2:
				JKBMGFHGBAC[0] = false;
				return;
			case 5:
				JKBMGFHGBAC[1] = false;
				return;
			}
			if (num == 2)
			{
				JKBMGFHGBAC[3] = true;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("New player entered the room: "))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveMaiEventStart") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void MMPMJNAFKHC()
	{
		if (MJGGACBHMHO || IMEKKIFIBBP || GDCLFLFLFBM || JKBMGFHGBAC[1] || JKBMGFHGBAC[0] || JKBMGFHGBAC[4])
		{
			light2d.intensity = Mathf.Lerp(light2d.intensity, 81f, increaseVelocity * Time.deltaTime);
		}
		else
		{
			light2d.intensity = Mathf.Lerp(light2d.intensity, 968f, decreaseVelocity * Time.deltaTime);
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
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

	private void JMNPLNAGLCO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("add item "))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" "))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 7:
				JKBMGFHGBAC[1] = true;
				break;
			case 3:
				JKBMGFHGBAC[0] = false;
				break;
			case 4:
				JKBMGFHGBAC[3] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReeledInRPC"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("New"))
		{
			GDCLFLFLFBM = true;
		}
	}

	private void MGMLDHPOLGK()
	{
		if (MJGGACBHMHO || IMEKKIFIBBP || GDCLFLFLFBM || JKBMGFHGBAC[1] || JKBMGFHGBAC[1] || JKBMGFHGBAC[4])
		{
			light2d.intensity = Mathf.Lerp(light2d.intensity, 401f, increaseVelocity * Time.deltaTime);
		}
		else
		{
			light2d.intensity = Mathf.Lerp(light2d.intensity, 1340f, decreaseVelocity * Time.deltaTime);
		}
	}

	private void PIOMHOLIHKH(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveRoomRequest"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Error_StairsAreBlocking"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 4:
				JKBMGFHGBAC[0] = true;
				break;
			case 3:
				JKBMGFHGBAC[0] = false;
				break;
			case 0:
				JKBMGFHGBAC[8] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1074"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("00") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void IIOHMDNGFDH()
	{
		if (MJGGACBHMHO || IMEKKIFIBBP || GDCLFLFLFBM || JKBMGFHGBAC[0] || JKBMGFHGBAC[0] || JKBMGFHGBAC[5])
		{
			light2d.intensity = Mathf.Lerp(light2d.intensity, 535f, increaseVelocity * Time.deltaTime);
		}
		else
		{
			light2d.intensity = Mathf.Lerp(light2d.intensity, 1248f, decreaseVelocity * Time.deltaTime);
		}
	}

	private void BINMHNJBDNI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" / "))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Received RPC SetBool {0} with value {1} on {2}. Setting animator parameter."))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 7:
				JKBMGFHGBAC[1] = true;
				break;
			case 2:
				JKBMGFHGBAC[0] = true;
				break;
			case 8:
				JKBMGFHGBAC[3] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" : 00"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("XP Upgrades"))
		{
			GDCLFLFLFBM = false;
		}
	}

	private void HOFKJPBBLGP()
	{
		JLLOJEPJLKM = light2d.intensity;
	}

	private void Start()
	{
		JLLOJEPJLKM = light2d.intensity;
	}

	private void KPFLAOALALM(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Brook Recipe turn in"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Listen"))
		{
			int num = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP();
			switch (num)
			{
			case 0:
				JKBMGFHGBAC[0] = false;
				return;
			case 3:
				JKBMGFHGBAC[0] = false;
				return;
			}
			if (num == 0)
			{
				JKBMGFHGBAC[8] = false;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Open"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("BarIdle") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void FJKKLJHHMLC(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Options"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Error in DogHoleManager.ResetDogHoles: "))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 6:
				JKBMGFHGBAC[0] = true;
				break;
			case 5:
				JKBMGFHGBAC[0] = false;
				break;
			case 1:
				JKBMGFHGBAC[5] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_642"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Disabled") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void CEIIFHIBIFI()
	{
		JLLOJEPJLKM = light2d.intensity;
	}

	private void ELHCBGCEJDH()
	{
		if (MJGGACBHMHO || IMEKKIFIBBP || GDCLFLFLFBM || JKBMGFHGBAC[1] || JKBMGFHGBAC[1] || JKBMGFHGBAC[3])
		{
			light2d.intensity = Mathf.Lerp(light2d.intensity, 833f, increaseVelocity * Time.deltaTime);
		}
		else
		{
			light2d.intensity = Mathf.Lerp(light2d.intensity, 634f, decreaseVelocity * Time.deltaTime);
		}
	}

	private void KIJDNFODCKJ(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Ale"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Observation"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 6:
				JKBMGFHGBAC[1] = false;
				break;
			case 3:
				JKBMGFHGBAC[0] = false;
				break;
			case 0:
				JKBMGFHGBAC[2] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Error in Bin.OnEnable: "))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("startPolling") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void FCONKHCGBEM(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (((Component)HANHCHBHHEH).CompareTag("OpenStats"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("-"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 7:
				JKBMGFHGBAC[0] = false;
				break;
			case 8:
				JKBMGFHGBAC[0] = true;
				break;
			case 3:
				JKBMGFHGBAC[1] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_606"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(",") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void JMDOCHBJGKG()
	{
		if (MJGGACBHMHO || IMEKKIFIBBP || GDCLFLFLFBM || JKBMGFHGBAC[0] || JKBMGFHGBAC[0] || JKBMGFHGBAC[4])
		{
			light2d.intensity = Mathf.Lerp(light2d.intensity, 919f, increaseVelocity * Time.deltaTime);
		}
		else
		{
			light2d.intensity = Mathf.Lerp(light2d.intensity, 1452f, decreaseVelocity * Time.deltaTime);
		}
	}

	private void LANGHIOBJIH()
	{
		JLLOJEPJLKM = light2d.intensity;
	}

	private void NIHJCJJKDBA()
	{
		if (MJGGACBHMHO || IMEKKIFIBBP || GDCLFLFLFBM || JKBMGFHGBAC[1] || JKBMGFHGBAC[1] || JKBMGFHGBAC[0])
		{
			light2d.intensity = Mathf.Lerp(light2d.intensity, 1039f, increaseVelocity * Time.deltaTime);
		}
		else
		{
			light2d.intensity = Mathf.Lerp(light2d.intensity, 751f, decreaseVelocity * Time.deltaTime);
		}
	}
}
