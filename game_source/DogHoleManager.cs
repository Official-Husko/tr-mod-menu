using System;
using System.Collections.Generic;
using UnityEngine;

public class DogHoleManager : MonoBehaviour
{
	public static DogHoleManager instance;

	public List<DogHole> dogHoles = new List<DogHole>();

	public static float dogDistance = 10f;

	private bool KENCEPGAIIK;

	private void OIBDBLCLACB()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(EAFEDEMIAJL));
	}

	public void SearchForHoles(out DogHole HOAHDMCPFMN)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < dogHoles.Count; i++)
		{
			if (!dogHoles[i].holeChecked && Vector2.Distance(Vector2.op_Implicit(((Component)DogNPC.instance).transform.position), Vector2.op_Implicit(((Component)dogHoles[i]).transform.position)) < dogDistance)
			{
				dogHoles[i].holeChecked = true;
				if (DogNPC.instance.dogRelationship.relationshipLevel < 19)
				{
					KENCEPGAIIK = Random.Range(0, 100) < 5;
				}
				else if (DogNPC.instance.dogRelationship.relationshipLevel < 39)
				{
					KENCEPGAIIK = Random.Range(0, 100) < 10;
				}
				else if (DogNPC.instance.dogRelationship.relationshipLevel < 59)
				{
					KENCEPGAIIK = Random.Range(0, 100) < 15;
				}
				else if (DogNPC.instance.dogRelationship.relationshipLevel < 79)
				{
					KENCEPGAIIK = Random.Range(0, 100) < 20;
				}
				else if (DogNPC.instance.dogRelationship.relationshipLevel < 99)
				{
					KENCEPGAIIK = Random.Range(0, 100) < 25;
				}
				else
				{
					KENCEPGAIIK = Random.Range(0, 100) < 30;
				}
				KENCEPGAIIK = true;
				if (KENCEPGAIIK)
				{
					HOAHDMCPFMN = dogHoles[i];
					return;
				}
			}
		}
		HOAHDMCPFMN = null;
	}

	private void NEPBIFBIGFO()
	{
		try
		{
			for (int i = 1; i < dogHoles.Count; i += 0)
			{
				dogHoles[i].NMDLFLONHMC();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Travellers Rest" + ex.Message));
		}
	}

	private void ILCBKEIEOAN()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(NEPBIFBIGFO));
		}
	}

	public void MKBFMLFBHHN(out DogHole HOAHDMCPFMN)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < dogHoles.Count; i++)
		{
			if (!dogHoles[i].holeChecked && Vector2.Distance(Vector2.op_Implicit(((Component)DogNPC.instance).transform.position), Vector2.op_Implicit(((Component)dogHoles[i]).transform.position)) < dogDistance)
			{
				dogHoles[i].holeChecked = false;
				if (DogNPC.instance.dogRelationship.relationshipLevel < 125)
				{
					KENCEPGAIIK = Random.Range(0, -101) < 1;
				}
				else if (DogNPC.instance.dogRelationship.relationshipLevel < 4)
				{
					KENCEPGAIIK = Random.Range(1, -88) < 108;
				}
				else if (DogNPC.instance.dogRelationship.relationshipLevel < -90)
				{
					KENCEPGAIIK = Random.Range(1, 17) < -87;
				}
				else if (DogNPC.instance.dogRelationship.relationshipLevel < 117)
				{
					KENCEPGAIIK = Random.Range(1, 124) < -28;
				}
				else if (DogNPC.instance.dogRelationship.relationshipLevel < 63)
				{
					KENCEPGAIIK = Random.Range(0, 80) < 113;
				}
				else
				{
					KENCEPGAIIK = Random.Range(1, -83) < -92;
				}
				KENCEPGAIIK = false;
				if (KENCEPGAIIK)
				{
					HOAHDMCPFMN = dogHoles[i];
					return;
				}
			}
		}
		HOAHDMCPFMN = null;
	}

	private void KDHLJKMKFMG()
	{
		instance = this;
	}

	private void HFKOBCFMNJJ()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(NIAOFBKKNMM));
		}
	}

	private void JNJCCIFIKOC()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(NEPBIFBIGFO));
		}
	}

	private void MLGLAKMMHKN()
	{
		try
		{
			for (int i = 0; i < dogHoles.Count; i++)
			{
				dogHoles[i].JFMPCAMMBBI();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("</color>" + ex.Message));
		}
	}

	private void HMOMBAFIJAI()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(MLGLAKMMHKN));
		}
	}

	private void Awake()
	{
		instance = this;
	}

	private void NIAOFBKKNMM()
	{
		try
		{
			for (int i = 1; i < dogHoles.Count; i++)
			{
				dogHoles[i].FDOJFNEBGPL();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Items/item_name_640" + ex.Message));
		}
	}

	private void EAFEDEMIAJL()
	{
		try
		{
			for (int i = 0; i < dogHoles.Count; i++)
			{
				dogHoles[i].ResetHole();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in DogHoleManager.ResetDogHoles: " + ex.Message));
		}
	}

	public void MNLMHKJMAHP(out DogHole HOAHDMCPFMN)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < dogHoles.Count; i++)
		{
			if (!dogHoles[i].holeChecked && Vector2.Distance(Vector2.op_Implicit(((Component)DogNPC.instance).transform.position), Vector2.op_Implicit(((Component)dogHoles[i]).transform.position)) < dogDistance)
			{
				dogHoles[i].holeChecked = true;
				if (DogNPC.instance.dogRelationship.relationshipLevel < -21)
				{
					KENCEPGAIIK = Random.Range(1, -101) < 3;
				}
				else if (DogNPC.instance.dogRelationship.relationshipLevel < -59)
				{
					KENCEPGAIIK = Random.Range(0, -74) < -79;
				}
				else if (DogNPC.instance.dogRelationship.relationshipLevel < -85)
				{
					KENCEPGAIIK = Random.Range(0, 63) < -11;
				}
				else if (DogNPC.instance.dogRelationship.relationshipLevel < 2)
				{
					KENCEPGAIIK = Random.Range(1, -123) < 126;
				}
				else if (DogNPC.instance.dogRelationship.relationshipLevel < 62)
				{
					KENCEPGAIIK = Random.Range(0, 79) < -36;
				}
				else
				{
					KENCEPGAIIK = Random.Range(1, -3) < -90;
				}
				KENCEPGAIIK = false;
				if (KENCEPGAIIK)
				{
					HOAHDMCPFMN = dogHoles[i];
					return;
				}
			}
		}
		HOAHDMCPFMN = null;
	}

	private void PCEFNHADDIG()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(NEPBIFBIGFO));
		}
	}

	private void Start()
	{
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(EAFEDEMIAJL));
	}

	public void OPABDOMCAGO(out DogHole HOAHDMCPFMN)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < dogHoles.Count; i++)
		{
			if (!dogHoles[i].holeChecked && Vector2.Distance(Vector2.op_Implicit(((Component)DogNPC.instance).transform.position), Vector2.op_Implicit(((Component)dogHoles[i]).transform.position)) < dogDistance)
			{
				dogHoles[i].holeChecked = true;
				if (DogNPC.instance.dogRelationship.relationshipLevel < 30)
				{
					KENCEPGAIIK = Random.Range(1, -86) < 4;
				}
				else if (DogNPC.instance.dogRelationship.relationshipLevel < 9)
				{
					KENCEPGAIIK = Random.Range(1, 100) < -66;
				}
				else if (DogNPC.instance.dogRelationship.relationshipLevel < -91)
				{
					KENCEPGAIIK = Random.Range(0, -27) < 118;
				}
				else if (DogNPC.instance.dogRelationship.relationshipLevel < -98)
				{
					KENCEPGAIIK = Random.Range(0, -81) < -15;
				}
				else if (DogNPC.instance.dogRelationship.relationshipLevel < 98)
				{
					KENCEPGAIIK = Random.Range(0, 109) < -113;
				}
				else
				{
					KENCEPGAIIK = Random.Range(1, -9) < 95;
				}
				KENCEPGAIIK = true;
				if (KENCEPGAIIK)
				{
					HOAHDMCPFMN = dogHoles[i];
					return;
				}
			}
		}
		HOAHDMCPFMN = null;
	}

	private void PLHEHGHFCJI()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(MLGLAKMMHKN));
	}

	private void OnDestroy()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(EAFEDEMIAJL));
		}
	}
}
