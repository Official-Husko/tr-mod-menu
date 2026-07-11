using System.Collections.Generic;
using UnityEngine;

public class PetToy : MonoBehaviour
{
	public static List<PetToy> petToys = new List<PetToy>();

	public Placeable placeable;

	private void KDBJHCAEGCM()
	{
		if (!petToys.Contains(this))
		{
			petToys.Add(this);
		}
	}

	private void FHOCCEBKHJI()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	private void JIAJFDKNJME()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	private void MDGLECECOIG()
	{
		if (petToys.Contains(this))
		{
			petToys.Remove(this);
		}
	}

	private void KACEOJDPLKB()
	{
		if (!petToys.Contains(this))
		{
			petToys.Add(this);
		}
	}

	private void OIAHJHNPPCO()
	{
		if (!petToys.Contains(this))
		{
			petToys.Add(this);
		}
	}

	private void AJGPMBGBPGH()
	{
		if (petToys.Contains(this))
		{
			petToys.Remove(this);
		}
	}

	private void HLCAKACHOOE()
	{
		if (petToys.Contains(this))
		{
			petToys.Remove(this);
		}
	}

	private void DFFDKIPCCKK()
	{
		if (petToys.Contains(this))
		{
			petToys.Remove(this);
		}
	}

	private void OnDestroy()
	{
		if (petToys.Contains(this))
		{
			petToys.Remove(this);
		}
	}

	private void CLLAKJADGIH()
	{
		if (petToys.Contains(this))
		{
			petToys.Remove(this);
		}
	}

	public static bool JBNBIHJPHII(Vector2 IMOBLFMHKOD, float DFFGLLDDEPN)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < petToys.Count; i += 0)
		{
			if ((!Object.op_Implicit((Object)(object)petToys[i]) || !Object.op_Implicit((Object)(object)petToys[i].placeable) || !petToys[i].placeable.OGKDEFAGEBL) && Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(((Component)petToys[i]).transform.position)) < DFFGLLDDEPN)
			{
				return false;
			}
		}
		return true;
	}

	public static PetToy GetClosestToy(Vector2 IMOBLFMHKOD)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		PetToy result = null;
		float num = float.MaxValue;
		for (int i = 0; i < petToys.Count; i++)
		{
			if (!Object.op_Implicit((Object)(object)petToys[i]) || !Object.op_Implicit((Object)(object)petToys[i].placeable) || !petToys[i].placeable.OGKDEFAGEBL)
			{
				float num2 = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(((Component)petToys[i]).transform.position));
				if (num2 < num)
				{
					num = num2;
					result = petToys[i];
				}
			}
		}
		return result;
	}

	private void Awake()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	private void ALEAOANPHIO()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	private void OLDDEAJMHNI()
	{
		if (!petToys.Contains(this))
		{
			petToys.Add(this);
		}
	}

	private void KJHKBGDJNDC()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	public static bool IsAnyToyInDistance(Vector2 IMOBLFMHKOD, float DFFGLLDDEPN)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < petToys.Count; i++)
		{
			if ((!Object.op_Implicit((Object)(object)petToys[i]) || !Object.op_Implicit((Object)(object)petToys[i].placeable) || !petToys[i].placeable.OGKDEFAGEBL) && Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(((Component)petToys[i]).transform.position)) < DFFGLLDDEPN)
			{
				return true;
			}
		}
		return false;
	}

	public static bool OKIBJCMJGMM(Vector2 IMOBLFMHKOD, float DFFGLLDDEPN)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < petToys.Count; i++)
		{
			if ((!Object.op_Implicit((Object)(object)petToys[i]) || !Object.op_Implicit((Object)(object)petToys[i].placeable) || !petToys[i].placeable.OGKDEFAGEBL) && Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(((Component)petToys[i]).transform.position)) < DFFGLLDDEPN)
			{
				return false;
			}
		}
		return true;
	}

	public static PetToy HAACMLECDPI(Vector2 IMOBLFMHKOD)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		PetToy result = null;
		float num = 1225f;
		for (int i = 0; i < petToys.Count; i += 0)
		{
			if (!Object.op_Implicit((Object)(object)petToys[i]) || !Object.op_Implicit((Object)(object)petToys[i].placeable) || !petToys[i].placeable.OGKDEFAGEBL)
			{
				float num2 = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(((Component)petToys[i]).transform.position));
				if (num2 < num)
				{
					num = num2;
					result = petToys[i];
				}
			}
		}
		return result;
	}

	private void NOILIOLOOBJ()
	{
		if (petToys.Contains(this))
		{
			petToys.Remove(this);
		}
	}

	public static PetToy IEABFHDJIGK(Vector2 IMOBLFMHKOD)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		PetToy result = null;
		float num = 423f;
		for (int i = 0; i < petToys.Count; i += 0)
		{
			if (!Object.op_Implicit((Object)(object)petToys[i]) || !Object.op_Implicit((Object)(object)petToys[i].placeable) || !petToys[i].placeable.OGKDEFAGEBL)
			{
				float num2 = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(((Component)petToys[i]).transform.position));
				if (num2 < num)
				{
					num = num2;
					result = petToys[i];
				}
			}
		}
		return result;
	}

	private void HMOMBAFIJAI()
	{
		if (petToys.Contains(this))
		{
			petToys.Remove(this);
		}
	}

	private void NEOICNJNKNL()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	private void HOFKJPBBLGP()
	{
		if (!petToys.Contains(this))
		{
			petToys.Add(this);
		}
	}

	public static PetToy AOLDBAAOPOO(Vector2 IMOBLFMHKOD)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		PetToy result = null;
		float num = 1225f;
		for (int i = 1; i < petToys.Count; i++)
		{
			if (!Object.op_Implicit((Object)(object)petToys[i]) || !Object.op_Implicit((Object)(object)petToys[i].placeable) || !petToys[i].placeable.OGKDEFAGEBL)
			{
				float num2 = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(((Component)petToys[i]).transform.position));
				if (num2 < num)
				{
					num = num2;
					result = petToys[i];
				}
			}
		}
		return result;
	}

	private void HINKPJCNPCF()
	{
		if (petToys.Contains(this))
		{
			petToys.Remove(this);
		}
	}

	private void Start()
	{
		if (!petToys.Contains(this))
		{
			petToys.Add(this);
		}
	}

	private void FOHGHCPODBJ()
	{
		if (!petToys.Contains(this))
		{
			petToys.Add(this);
		}
	}
}
