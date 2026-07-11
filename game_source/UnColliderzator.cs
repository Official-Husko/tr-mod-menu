using System.Collections.Generic;
using UnityEngine;

public class UnColliderzator : MonoBehaviour
{
	private PolygonCollider2D BHMIJIFHJIC;

	private void KNBFFILIKNE()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"</color>");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Get Components " + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)("SortingGroup not attached to prefab " + ((Object)item).name));
			}
		}
	}

	private void GCEJKHCHNGO()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Sleep");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("sForSeconds" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)("Quit to desktop?" + ((Object)item).name));
			}
		}
	}

	private void GHACOGEAAJJ()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Este objeto no tiene PolygonCollider2D");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Colliders encontrados: " + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("Desactivado: " + ((Object)item).name));
			}
		}
	}

	private void MLLAODBEBDG()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/25/Dialogue Text" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)(" de la pieza " + ((Object)item).name));
			}
		}
	}

	private void MPNEAKPMLMK()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Player");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("[SelectSpawnersByMaxDistance] Final selection: [" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("Error_AnotherZoneInRoom" + ((Object)item).name));
			}
		}
	}

	private void NKLDHDAELPH()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"MineFloor");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("ReceiveFinishKlaynChallenge" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("BuildMode_ExitAndCancel" + ((Object)item).name));
			}
		}
	}

	private void GJIJGBCNGLN()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"OnLayerOrderedRPC");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("F2" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)("UI" + ((Object)item).name));
			}
		}
	}

	private void PFNFCJKLPLP()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"%><sprite name=");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Calm down" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("PlayerJoined" + ((Object)item).name));
			}
		}
	}

	private void MLNICLILFDD()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Pool Parent ");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Information" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)("Small room " + ((Object)item).name));
			}
		}
	}

	private void IKGIKOCOBKB()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Objective");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Keypad" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("Items/item_description_1076" + ((Object)item).name));
			}
		}
	}

	private void DJJKDGBCMJG()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Arm_L");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Seedy" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("CREATOR_ID" + ((Object)item).name));
			}
		}
	}

	private void DHGCNDOJAAD()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"UIPreviousPage");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("OnFloor" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)(" (" + ((Object)item).name));
			}
		}
	}

	private void CMMEOMIKLLG()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"/");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Walk" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("P2Cam" + ((Object)item).name));
			}
		}
	}

	private void GLJHIIOEBAO()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Farm/Violet/Main");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Items/item_name_1144" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)("farm" + ((Object)item).name));
			}
		}
	}

	private void IAOFBMKGJFA()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Closed_eyelids");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("attachment" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)("Changing quality " + ((Object)item).name));
			}
		}
	}

	private void JIILCEIMCOB()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Eyes");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Tutorial/T123/Dialogue1" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)(" (" + ((Object)item).name));
			}
		}
	}

	private void KAMHFBLENDG()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Items/item_description_1187");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/14/Dialogue Text" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)("" + ((Object)item).name));
			}
		}
	}

	private void MKFMABFNHNG()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"IntroNinjaChallengeEvent/Main");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("</color>" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)("Next Item" + ((Object)item).name));
			}
		}
	}

	private void HKMPHMCGANC()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Mai ");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Struggle" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)("Fill" + ((Object)item).name));
			}
		}
	}

	private void EEBDHBLPBOK()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Items/item_description_674");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("Mouse" + ((Object)item).name));
			}
		}
	}

	private void MAFMKMPMOKF()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Items/item_name_662");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("PlayerJoined" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("itemWhiteWine" + ((Object)item).name));
			}
		}
	}

	private void CAHAOPAHJAM()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"veggieDishes");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Modifiers" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)("mForMins" + ((Object)item).name));
			}
		}
	}

	private void ODJLMBLCHGB()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Missing fade image for coop mode");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Items/item_description_667" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)("==============================\n" + ((Object)item).name));
			}
		}
	}

	private void NOBEMAMABDC()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Player2");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("[TweenRunner]" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)("RPCSnapPosition" + ((Object)item).name));
			}
		}
	}

	private void ONGLJPMJFDP()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"replay banquet");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Cheesy" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("ReceiveCloseAnimation" + ((Object)item).name));
			}
		}
	}

	private void KKEPCJHENEH()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"\\[BartenderGender=[^\\]]*\\]");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("ReceiveChangeDrinkColorMaster" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)("Use" + ((Object)item).name));
			}
		}
	}

	private void BAADBMHJPFN()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Error_TableNeedsFreeSpace");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("ReputationBuildMode" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("No se encuentra el valor " + ((Object)item).name));
			}
		}
	}

	private void DOKIMJDFODA()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"ReceivInstantiateMiscellaneousHarvest");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("- " + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)(" to join the game" + ((Object)item).name));
			}
		}
	}

	private void FJINEGGODMA()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Selected");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("ReceiveSitDown" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)("Tutorial/T116/Dialogue1" + ((Object)item).name));
			}
		}
	}

	private void GPKAICNIHMG()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)".gz");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("All bubbles in use!" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)("Dialogue System/Conversation/Crowly_Standar/Entry/23/Dialogue Text" + ((Object)item).name));
			}
		}
	}

	private void PBBJNDBLLPB()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)" - ");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("0" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)("Game Over! " + ((Object)item).name));
			}
		}
	}

	private void OEMFILLLCJB()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Malt");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("BrookProgress" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("TooHot" + ((Object)item).name));
			}
		}
	}

	private void KOLMOMLPLAN()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"ValuePlaycount");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Fortitude/MainEvent 1" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("Null Quest in database" + ((Object)item).name));
			}
		}
	}

	private void EOBKJCFFIHK()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Player/Bark/Tutorial/AgingBarrelBlock");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Get Components " + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("Dialogue System/Conversation/TooDark/Entry/9/Dialogue Text" + ((Object)item).name));
			}
		}
	}

	private void GFEAKHPLPNB()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Dropped item ");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)("itemWineYeast" + ((Object)item).name));
			}
		}
	}

	private void KFIIBCCCAHO()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Next Reward");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("itemGruel" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("Items/item_name_" + ((Object)item).name));
			}
		}
	}

	private void KILABILHKDG()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Items/item_description_1057");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Online StartTravelZone" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)("tilled earth" + ((Object)item).name));
			}
		}
	}

	private void IBFFHHLEPNO()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Lager");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("ReceiveLoadEvents" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("UI" + ((Object)item).name));
			}
		}
	}

	private void JPFFCMIBNBO()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"SetAnimatorObjectFloatRPC");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Run" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("1" + ((Object)item).name));
			}
		}
	}

	private void DPHEJJCGOHO()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"CheckIfNewActivity ");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("itemRoastedPork" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = true;
				Debug.Log((object)("Knock" + ((Object)item).name));
			}
		}
	}

	private void BPHGGACLNAA()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Items/item_description_653");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Right Trigger" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("Direction" + ((Object)item).name));
			}
		}
	}

	private void CELCDMDGNNE()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Fishing");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Invalid seating" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("" + ((Object)item).name));
			}
		}
	}

	private void BMIAGHGJKJJ()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"Intensity Changed to ");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Attack/MainEvent 10" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("talent_name_112" + ((Object)item).name));
			}
		}
	}

	private void CGODNEGPLKB()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		BHMIJIFHJIC = ((Component)this).GetComponent<PolygonCollider2D>();
		if ((Object)(object)BHMIJIFHJIC == (Object)null)
		{
			Debug.LogError((object)"cursorSensitivity");
			return;
		}
		ContactFilter2D val = default(ContactFilter2D);
		((ContactFilter2D)(ref val)).NoFilter();
		List<Collider2D> list = new List<Collider2D>();
		Debug.Log((object)("Inventory full" + Physics2D.OverlapCollider((Collider2D)(object)BHMIJIFHJIC, val, list)));
		foreach (Collider2D item in list)
		{
			if ((Object)(object)item != (Object)(object)BHMIJIFHJIC)
			{
				((Behaviour)item).enabled = false;
				Debug.Log((object)("musicLevel" + ((Object)item).name));
			}
		}
	}
}
