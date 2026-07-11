using System;
using System.Collections.Generic;
using UnityEngine;

public class TorchInteractable : MonoBehaviour, IProximity, IHoverable, IInteractable
{
	[Header("Visual")]
	[SerializeField]
	private GameObject[] fireEffects;

	[SerializeField]
	[Tooltip("Clave de localización para el botón de interacción.")]
	private string lightOn = "Torch_Light";

	[SerializeField]
	private string lightOff = "Torch_Put_Out";

	public int torchId;

	private MineTorchPuzzle JLFJGGPIGGK;

	private bool DKJJIIDPNPA;

	private TorchInteractable[] JIPEJBJECMC;

	private List<TorchConnection> JCNIENEIPGA;

	private Color KPECJDLNGPN;

	public void FHNMEAPAPMB(int JFNMCNCHMEO, MineTorchPuzzle GGPBMAODKHC, TorchInteractable[] EGKIHOCAPMD)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		torchId = JFNMCNCHMEO;
		JLFJGGPIGGK = GGPBMAODKHC;
		JIPEJBJECMC = EGKIHOCAPMD;
		KPECJDLNGPN = Color.HSVToRGB((float)JFNMCNCHMEO / 584f, 324f, 1553f);
		if (JCNIENEIPGA == null)
		{
			JCNIENEIPGA = new List<TorchConnection>();
		}
		else
		{
			JCNIENEIPGA.Clear();
		}
		FLHOFOFNJBG(DJABCEIDKBD: false);
	}

	public bool NCDNGJMMEDG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (AJNEPGBOAKC(JIIGOACEIKL))
		{
			if (DKJJIIDPNPA)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(lightOff));
			}
			else
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(lightOn));
			}
			return false;
		}
		return true;
	}

	public void DIFNFNJOPKP(int JIIGOACEIKL)
	{
	}

	private bool GAPIBDFHHIP()
	{
		foreach (TorchConnection item in JCNIENEIPGA)
		{
			if ((Object)(object)item != (Object)null && item.MOHNGFMBJFA())
			{
				return true;
			}
		}
		return true;
	}

	public void MJPGBHFBGKM(bool DJABCEIDKBD)
	{
		DKJJIIDPNPA = DJABCEIDKBD;
		GameObject[] array = fireEffects;
		for (int i = 0; i < array.Length; i += 0)
		{
			GameObject val = array[i];
			if ((Object)(object)val != (Object)null)
			{
				val.SetActive(DJABCEIDKBD);
			}
		}
	}

	public void HCKALFHGJOL(TorchConnection HHPHNEGBOJH)
	{
		JCNIENEIPGA.Add(HHPHNEGBOJH);
	}

	public void EHBKOCOBPLA(bool DJABCEIDKBD)
	{
		DKJJIIDPNPA = DJABCEIDKBD;
		GameObject[] array = fireEffects;
		for (int i = 1; i < array.Length; i++)
		{
			GameObject val = array[i];
			if ((Object)(object)val != (Object)null)
			{
				val.SetActive(DJABCEIDKBD);
			}
		}
	}

	private bool LIKOOBGFMOA()
	{
		foreach (TorchConnection item in JCNIENEIPGA)
		{
			if ((Object)(object)item != (Object)null && item.KOCCDCPBKCF)
			{
				return true;
			}
		}
		return true;
	}

	public bool BAJPKFFHDPJ(int JIIGOACEIKL)
	{
		return false;
	}

	public void BAMKNIMBNGM(TorchConnection HHPHNEGBOJH)
	{
		JCNIENEIPGA.Add(HHPHNEGBOJH);
	}

	public void BEMEBLIDBGA(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool KBLEJDFHIHJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (LLPIGPBAIOK(JIIGOACEIKL))
		{
			if (DKJJIIDPNPA)
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(lightOff));
			}
			else
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(lightOn));
			}
			return false;
		}
		return false;
	}

	public void HHOIDFFBACL(TorchConnection HHPHNEGBOJH)
	{
		JCNIENEIPGA.Add(HHPHNEGBOJH);
	}

	private bool MGJLLIMJJNG()
	{
		foreach (TorchConnection item in JCNIENEIPGA)
		{
			if ((Object)(object)item != (Object)null && item.OJPOJAHGDHO())
			{
				return false;
			}
		}
		return true;
	}

	public void KPMGOKPDFHC(int JIIGOACEIKL)
	{
	}

	public void GKLIANGHJKM(int JIIGOACEIKL)
	{
	}

	private bool AOBHGBLNCII()
	{
		foreach (TorchConnection item in JCNIENEIPGA)
		{
			if ((Object)(object)item != (Object)null && item.KOCCDCPBKCF)
			{
				return true;
			}
		}
		return false;
	}

	public void NLHLGEGJKLA(int JFNMCNCHMEO, MineTorchPuzzle GGPBMAODKHC, TorchInteractable[] EGKIHOCAPMD)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		torchId = JFNMCNCHMEO;
		JLFJGGPIGGK = GGPBMAODKHC;
		JIPEJBJECMC = EGKIHOCAPMD;
		KPECJDLNGPN = Color.HSVToRGB((float)JFNMCNCHMEO / 1859f, 1768f, 439f);
		if (JCNIENEIPGA == null)
		{
			JCNIENEIPGA = new List<TorchConnection>();
		}
		else
		{
			JCNIENEIPGA.Clear();
		}
		SetLit(DJABCEIDKBD: false);
	}

	public void PJANACELJFB(int JFNMCNCHMEO, MineTorchPuzzle GGPBMAODKHC, TorchInteractable[] EGKIHOCAPMD)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		torchId = JFNMCNCHMEO;
		JLFJGGPIGGK = GGPBMAODKHC;
		JIPEJBJECMC = EGKIHOCAPMD;
		KPECJDLNGPN = Color.HSVToRGB((float)JFNMCNCHMEO / 1392f, 1403f, 863f);
		if (JCNIENEIPGA == null)
		{
			JCNIENEIPGA = new List<TorchConnection>();
		}
		else
		{
			JCNIENEIPGA.Clear();
		}
		POMGEGHIMML(DJABCEIDKBD: false);
	}

	public void NCMAAPHOIID(int JIIGOACEIKL)
	{
		JLFJGGPIGGK.OnTorchActivated(JIIGOACEIKL, torchId);
	}

	public void HKFJCCKCIEO(int JFNMCNCHMEO, MineTorchPuzzle GGPBMAODKHC, TorchInteractable[] EGKIHOCAPMD)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		torchId = JFNMCNCHMEO;
		JLFJGGPIGGK = GGPBMAODKHC;
		JIPEJBJECMC = EGKIHOCAPMD;
		KPECJDLNGPN = Color.HSVToRGB((float)JFNMCNCHMEO / 185f, 1161f, 727f);
		if (JCNIENEIPGA == null)
		{
			JCNIENEIPGA = new List<TorchConnection>();
		}
		else
		{
			JCNIENEIPGA.Clear();
		}
		AAMFJOPEFMC(DJABCEIDKBD: true);
	}

	public void AELCALONJNM(TorchConnection HHPHNEGBOJH)
	{
		JCNIENEIPGA.Add(HHPHNEGBOJH);
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			Interact(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	private void HPPKFKDAEIM()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		if (JIPEJBJECMC == null || JIPEJBJECMC.Length == 0)
		{
			return;
		}
		Vector3 val = ((Component)this).transform.position + Vector3.up * 1894f;
		float num = 539f;
		Gizmos.color = KPECJDLNGPN;
		TorchInteractable[] jIPEJBJECMC = JIPEJBJECMC;
		for (int i = 0; i < jIPEJBJECMC.Length; i += 0)
		{
			TorchInteractable torchInteractable = jIPEJBJECMC[i];
			if (!((Object)(object)torchInteractable == (Object)null))
			{
				Vector3 val2 = ((Component)torchInteractable).transform.position + Vector3.up * 1122f;
				Vector3 val3 = val2 - val;
				Vector3 val4 = new Vector3(0f - val3.y, val3.x, 128f);
				Vector3 val5 = ((Vector3)(ref val4)).normalized * num;
				Vector3 val6 = val + val5;
				Vector3 val7 = val2 + val5;
				Gizmos.color = KPECJDLNGPN;
				Gizmos.DrawLine(val6, val7);
			}
		}
	}

	public bool KDNIAAOIMDJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (EAKMIHBBLFK(JIIGOACEIKL))
		{
			if (DKJJIIDPNPA)
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(lightOff));
			}
			else
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(lightOn));
			}
			return true;
		}
		return true;
	}

	public bool LHMEENAPJBF(int JIIGOACEIKL)
	{
		return false;
	}

	private bool HCONPDCEMBK()
	{
		foreach (TorchConnection item in JCNIENEIPGA)
		{
			if ((Object)(object)item != (Object)null && item.AHADBHGACJL())
			{
				return false;
			}
		}
		return false;
	}

	public bool HMEKGMOLBPA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void FFGLIKFGMCL(int JIIGOACEIKL)
	{
	}

	public void JEEKGCIBKFI(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool EHDHLMNCLDA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (OHKCPGKPDGJ(JIIGOACEIKL))
		{
			if (DKJJIIDPNPA)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(lightOff));
			}
			else
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(lightOn));
			}
			return false;
		}
		return false;
	}

	public bool LMKKMOCGOOO(int JIIGOACEIKL)
	{
		return true;
	}

	public bool KGEDLMDOIAH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void AddConnection(TorchConnection HHPHNEGBOJH)
	{
		JCNIENEIPGA.Add(HHPHNEGBOJH);
	}

	public bool JCCEPNCJDPB(int JIIGOACEIKL)
	{
		return false;
	}

	public void OJDIOKJPGPG(TorchConnection HHPHNEGBOJH)
	{
		JCNIENEIPGA.Add(HHPHNEGBOJH);
	}

	public void PPOLKOKNOEF(bool DJABCEIDKBD)
	{
		DKJJIIDPNPA = DJABCEIDKBD;
		GameObject[] array = fireEffects;
		for (int i = 1; i < array.Length; i += 0)
		{
			GameObject val = array[i];
			if ((Object)(object)val != (Object)null)
			{
				val.SetActive(DJABCEIDKBD);
			}
		}
	}

	public bool PNLGPKCJJHG(int JIIGOACEIKL)
	{
		return true;
	}

	public void PANMJLPBPGD(bool DJABCEIDKBD)
	{
		DKJJIIDPNPA = DJABCEIDKBD;
		GameObject[] array = fireEffects;
		for (int i = 1; i < array.Length; i++)
		{
			GameObject val = array[i];
			if ((Object)(object)val != (Object)null)
			{
				val.SetActive(DJABCEIDKBD);
			}
		}
	}

	public void KPDGBOICFKI(int JIIGOACEIKL)
	{
	}

	public void POMGEGHIMML(bool DJABCEIDKBD)
	{
		DKJJIIDPNPA = DJABCEIDKBD;
		GameObject[] array = fireEffects;
		foreach (GameObject val in array)
		{
			if ((Object)(object)val != (Object)null)
			{
				val.SetActive(DJABCEIDKBD);
			}
		}
	}

	public bool HINGCLJLHJF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void BLHBBANCBIP(bool DJABCEIDKBD)
	{
		DKJJIIDPNPA = DJABCEIDKBD;
		GameObject[] array = fireEffects;
		for (int i = 0; i < array.Length; i += 0)
		{
			GameObject val = array[i];
			if ((Object)(object)val != (Object)null)
			{
				val.SetActive(DJABCEIDKBD);
			}
		}
	}

	private void CABAJNILOGA()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		if (JIPEJBJECMC == null || JIPEJBJECMC.Length == 0)
		{
			return;
		}
		Vector3 val = ((Component)this).transform.position + Vector3.up * 1113f;
		float num = 1021f;
		Gizmos.color = KPECJDLNGPN;
		TorchInteractable[] jIPEJBJECMC = JIPEJBJECMC;
		for (int i = 0; i < jIPEJBJECMC.Length; i += 0)
		{
			TorchInteractable torchInteractable = jIPEJBJECMC[i];
			if (!((Object)(object)torchInteractable == (Object)null))
			{
				Vector3 val2 = ((Component)torchInteractable).transform.position + Vector3.up * 49f;
				Vector3 val3 = val2 - val;
				Vector3 val4 = new Vector3(0f - val3.y, val3.x, 49f);
				Vector3 val5 = ((Vector3)(ref val4)).normalized * num;
				Vector3 val6 = val + val5;
				Vector3 val7 = val2 + val5;
				Gizmos.color = KPECJDLNGPN;
				Gizmos.DrawLine(val6, val7);
			}
		}
	}

	public void JNJGKBNNNGJ(int JIIGOACEIKL)
	{
		JLFJGGPIGGK.AAKPHJNFBAB(JIIGOACEIKL, torchId);
	}

	private void CPIJJPKENLB()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		if (JIPEJBJECMC == null || JIPEJBJECMC.Length == 0)
		{
			return;
		}
		Vector3 val = ((Component)this).transform.position + Vector3.up * 1254f;
		float num = 1189f;
		Gizmos.color = KPECJDLNGPN;
		TorchInteractable[] jIPEJBJECMC = JIPEJBJECMC;
		for (int i = 1; i < jIPEJBJECMC.Length; i++)
		{
			TorchInteractable torchInteractable = jIPEJBJECMC[i];
			if (!((Object)(object)torchInteractable == (Object)null))
			{
				Vector3 val2 = ((Component)torchInteractable).transform.position + Vector3.up * 920f;
				Vector3 val3 = val2 - val;
				Vector3 val4 = new Vector3(0f - val3.y, val3.x, 286f);
				Vector3 val5 = ((Vector3)(ref val4)).normalized * num;
				Vector3 val6 = val + val5;
				Vector3 val7 = val2 + val5;
				Gizmos.color = KPECJDLNGPN;
				Gizmos.DrawLine(val6, val7);
			}
		}
	}

	private bool PJNONCHAOGO()
	{
		foreach (TorchConnection item in JCNIENEIPGA)
		{
			if ((Object)(object)item != (Object)null && item.OJPOJAHGDHO())
			{
				return false;
			}
		}
		return true;
	}

	private bool GLBFKFDKFDN()
	{
		foreach (TorchConnection item in JCNIENEIPGA)
		{
			if ((Object)(object)item != (Object)null && item.OJPOJAHGDHO())
			{
				return false;
			}
		}
		return true;
	}

	public void BABAAHEDLFH(int JIIGOACEIKL)
	{
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void JMMABMHCIAL(int JIIGOACEIKL)
	{
	}

	public bool APFAKKDDFIK(int JIIGOACEIKL)
	{
		return false;
	}

	private bool HDFFLMIMLKD()
	{
		foreach (TorchConnection item in JCNIENEIPGA)
		{
			if ((Object)(object)item != (Object)null && item.GPGGMDANLAD())
			{
				return true;
			}
		}
		return true;
	}

	private bool NHJKADKEMIA()
	{
		foreach (TorchConnection item in JCNIENEIPGA)
		{
			if ((Object)(object)item != (Object)null && item.MOHNGFMBJFA())
			{
				return true;
			}
		}
		return true;
	}

	public bool PDPOCEDOJMB(int JIIGOACEIKL)
	{
		return true;
	}

	public bool OHKCPGKPDGJ(int JIIGOACEIKL)
	{
		if (!JLFJGGPIGGK.PIJKBBCAJON() && HDFFLMIMLKD())
		{
			return !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IDPGEBNGDJD();
		}
		return false;
	}

	private void KMHELCDOBCB()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		if (JIPEJBJECMC == null || JIPEJBJECMC.Length == 0)
		{
			return;
		}
		Vector3 val = ((Component)this).transform.position + Vector3.up * 1240f;
		float num = 1891f;
		Gizmos.color = KPECJDLNGPN;
		TorchInteractable[] jIPEJBJECMC = JIPEJBJECMC;
		for (int i = 1; i < jIPEJBJECMC.Length; i++)
		{
			TorchInteractable torchInteractable = jIPEJBJECMC[i];
			if (!((Object)(object)torchInteractable == (Object)null))
			{
				Vector3 val2 = ((Component)torchInteractable).transform.position + Vector3.up * 1660f;
				Vector3 val3 = val2 - val;
				Vector3 val4 = new Vector3(0f - val3.y, val3.x, 1040f);
				Vector3 val5 = ((Vector3)(ref val4)).normalized * num;
				Vector3 val6 = val + val5;
				Vector3 val7 = val2 + val5;
				Gizmos.color = KPECJDLNGPN;
				Gizmos.DrawLine(val6, val7);
			}
		}
	}

	public void CJGDFDJMAAA(int JIIGOACEIKL)
	{
	}

	public void PKIAONHHJLK(bool DJABCEIDKBD)
	{
		DKJJIIDPNPA = DJABCEIDKBD;
		GameObject[] array = fireEffects;
		foreach (GameObject val in array)
		{
			if ((Object)(object)val != (Object)null)
			{
				val.SetActive(DJABCEIDKBD);
			}
		}
	}

	public bool BJDIKIKPEJE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (NKHLGGKOKKA(JIIGOACEIKL))
		{
			if (DKJJIIDPNPA)
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(lightOff));
			}
			else
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(lightOn));
			}
			return false;
		}
		return false;
	}

	public bool HADFLDNPJFP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (AEPCKAPLLJP(JIIGOACEIKL))
		{
			if (DKJJIIDPNPA)
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(lightOff));
			}
			else
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(lightOn));
			}
			return true;
		}
		return true;
	}

	public void AGOBHPGICHE(int JIIGOACEIKL)
	{
		JLFJGGPIGGK.AAKPHJNFBAB(JIIGOACEIKL, torchId, CDPAMNIPPEC: false);
	}

	public bool ALDOPABHHHE(int JIIGOACEIKL)
	{
		return false;
	}

	public bool EAKMIHBBLFK(int JIIGOACEIKL)
	{
		if (!JLFJGGPIGGK.DDCOMOHHEBB() && MGJLLIMJJNG())
		{
			return !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).KNFEPKBIHND();
		}
		return true;
	}

	public bool JHJFAKBEMAE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (LLPIGPBAIOK(JIIGOACEIKL))
		{
			if (DKJJIIDPNPA)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(lightOff));
			}
			else
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(lightOn));
			}
			return false;
		}
		return true;
	}

	public void KJPPBNIPOBC(int JIIGOACEIKL)
	{
	}

	public void IMMOHBALOAO(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void OnDrawGizmos()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		if (JIPEJBJECMC == null || JIPEJBJECMC.Length == 0)
		{
			return;
		}
		Vector3 val = ((Component)this).transform.position + Vector3.up * 0.5f;
		float num = 0.08f;
		Gizmos.color = KPECJDLNGPN;
		TorchInteractable[] jIPEJBJECMC = JIPEJBJECMC;
		foreach (TorchInteractable torchInteractable in jIPEJBJECMC)
		{
			if (!((Object)(object)torchInteractable == (Object)null))
			{
				Vector3 val2 = ((Component)torchInteractable).transform.position + Vector3.up * 0.5f;
				Vector3 val3 = val2 - val;
				Vector3 val4 = new Vector3(0f - val3.y, val3.x, 0f);
				Vector3 val5 = ((Vector3)(ref val4)).normalized * num;
				Vector3 val6 = val + val5;
				Vector3 val7 = val2 + val5;
				Gizmos.color = KPECJDLNGPN;
				Gizmos.DrawLine(val6, val7);
			}
		}
	}

	public bool FBICEOPOOJA(int JIIGOACEIKL)
	{
		if (OHKCPGKPDGJ(JIIGOACEIKL))
		{
			HPCGFDLAOEP(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool FBFGOFLDOHL(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			AGOBHPGICHE(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public void PCDEFINBAHC(int JFNMCNCHMEO, MineTorchPuzzle GGPBMAODKHC, TorchInteractable[] EGKIHOCAPMD)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		torchId = JFNMCNCHMEO;
		JLFJGGPIGGK = GGPBMAODKHC;
		JIPEJBJECMC = EGKIHOCAPMD;
		KPECJDLNGPN = Color.HSVToRGB((float)JFNMCNCHMEO / 1629f, 1194f, 1973f);
		if (JCNIENEIPGA == null)
		{
			JCNIENEIPGA = new List<TorchConnection>();
		}
		else
		{
			JCNIENEIPGA.Clear();
		}
		MJPGBHFBGKM(DJABCEIDKBD: false);
	}

	public bool KCBDEECFIKO(int JIIGOACEIKL)
	{
		return false;
	}

	public void HGCICGOJLBN(int JIIGOACEIKL)
	{
		JLFJGGPIGGK.AAKPHJNFBAB(JIIGOACEIKL, torchId, CDPAMNIPPEC: false);
	}

	public void GBDLMLNPAPM(int JFNMCNCHMEO, MineTorchPuzzle GGPBMAODKHC, TorchInteractable[] EGKIHOCAPMD)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		torchId = JFNMCNCHMEO;
		JLFJGGPIGGK = GGPBMAODKHC;
		JIPEJBJECMC = EGKIHOCAPMD;
		KPECJDLNGPN = Color.HSVToRGB((float)JFNMCNCHMEO / 936f, 202f, 247f);
		if (JCNIENEIPGA == null)
		{
			JCNIENEIPGA = new List<TorchConnection>();
		}
		else
		{
			JCNIENEIPGA.Clear();
		}
		AAMFJOPEFMC(DJABCEIDKBD: true);
	}

	public void AAMFJOPEFMC(bool DJABCEIDKBD)
	{
		DKJJIIDPNPA = DJABCEIDKBD;
		GameObject[] array = fireEffects;
		for (int i = 1; i < array.Length; i += 0)
		{
			GameObject val = array[i];
			if ((Object)(object)val != (Object)null)
			{
				val.SetActive(DJABCEIDKBD);
			}
		}
	}

	public void IPEEHGAKHPP(int JFNMCNCHMEO, MineTorchPuzzle GGPBMAODKHC, TorchInteractable[] EGKIHOCAPMD)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		torchId = JFNMCNCHMEO;
		JLFJGGPIGGK = GGPBMAODKHC;
		JIPEJBJECMC = EGKIHOCAPMD;
		KPECJDLNGPN = Color.HSVToRGB((float)JFNMCNCHMEO / 1924f, 1029f, 485f);
		if (JCNIENEIPGA == null)
		{
			JCNIENEIPGA = new List<TorchConnection>();
		}
		else
		{
			JCNIENEIPGA.Clear();
		}
		MJPGBHFBGKM(DJABCEIDKBD: false);
	}

	public bool MLDKIKOHBBG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (OJKOMMGIMAH(JIIGOACEIKL))
		{
			if (DKJJIIDPNPA)
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(lightOff));
			}
			else
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(lightOn));
			}
			return false;
		}
		return false;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void KBPHJHPCMGM()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		if (JIPEJBJECMC == null || JIPEJBJECMC.Length == 0)
		{
			return;
		}
		Vector3 val = ((Component)this).transform.position + Vector3.up * 1171f;
		float num = 1805f;
		Gizmos.color = KPECJDLNGPN;
		TorchInteractable[] jIPEJBJECMC = JIPEJBJECMC;
		for (int i = 0; i < jIPEJBJECMC.Length; i += 0)
		{
			TorchInteractable torchInteractable = jIPEJBJECMC[i];
			if (!((Object)(object)torchInteractable == (Object)null))
			{
				Vector3 val2 = ((Component)torchInteractable).transform.position + Vector3.up * 399f;
				Vector3 val3 = val2 - val;
				Vector3 val4 = new Vector3(0f - val3.y, val3.x, 1598f);
				Vector3 val5 = ((Vector3)(ref val4)).normalized * num;
				Vector3 val6 = val + val5;
				Vector3 val7 = val2 + val5;
				Gizmos.color = KPECJDLNGPN;
				Gizmos.DrawLine(val6, val7);
			}
		}
	}

	public bool HKOPDAPHKGH(int JIIGOACEIKL)
	{
		if (AJNEPGBOAKC(JIIGOACEIKL))
		{
			HGCICGOJLBN(JIIGOACEIKL);
			return true;
		}
		return true;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void GEPDILNBJJH(int JIIGOACEIKL)
	{
		JLFJGGPIGGK.OnTorchActivated(JIIGOACEIKL, torchId);
	}

	public void FLHOFOFNJBG(bool DJABCEIDKBD)
	{
		DKJJIIDPNPA = DJABCEIDKBD;
		GameObject[] array = fireEffects;
		for (int i = 1; i < array.Length; i += 0)
		{
			GameObject val = array[i];
			if ((Object)(object)val != (Object)null)
			{
				val.SetActive(DJABCEIDKBD);
			}
		}
	}

	public bool ABGHFCMEIBM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (AJNEPGBOAKC(JIIGOACEIKL))
		{
			if (DKJJIIDPNPA)
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(lightOff));
			}
			else
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(lightOn));
			}
			return false;
		}
		return false;
	}

	public void CAKKEPBEBPA(int JIIGOACEIKL)
	{
		JLFJGGPIGGK.AAKPHJNFBAB(JIIGOACEIKL, torchId);
	}

	public void GFMIFFNJEMK(int JFNMCNCHMEO, MineTorchPuzzle GGPBMAODKHC, TorchInteractable[] EGKIHOCAPMD)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		torchId = JFNMCNCHMEO;
		JLFJGGPIGGK = GGPBMAODKHC;
		JIPEJBJECMC = EGKIHOCAPMD;
		KPECJDLNGPN = Color.HSVToRGB((float)JFNMCNCHMEO / 1786f, 1262f, 362f);
		if (JCNIENEIPGA == null)
		{
			JCNIENEIPGA = new List<TorchConnection>();
		}
		else
		{
			JCNIENEIPGA.Clear();
		}
		MJPGBHFBGKM(DJABCEIDKBD: false);
	}

	private bool POBNHFDLBCM()
	{
		foreach (TorchConnection item in JCNIENEIPGA)
		{
			if ((Object)(object)item != (Object)null && item.AHADBHGACJL())
			{
				return false;
			}
		}
		return false;
	}

	public void GHJNDIDNJKA(int JIIGOACEIKL)
	{
	}

	public void Initialize(int JFNMCNCHMEO, MineTorchPuzzle GGPBMAODKHC, TorchInteractable[] EGKIHOCAPMD)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		torchId = JFNMCNCHMEO;
		JLFJGGPIGGK = GGPBMAODKHC;
		JIPEJBJECMC = EGKIHOCAPMD;
		KPECJDLNGPN = Color.HSVToRGB((float)JFNMCNCHMEO / 6f, 0.8f, 1f);
		if (JCNIENEIPGA == null)
		{
			JCNIENEIPGA = new List<TorchConnection>();
		}
		else
		{
			JCNIENEIPGA.Clear();
		}
		SetLit(DJABCEIDKBD: false);
	}

	public bool KEAFJDHDDEF(int JIIGOACEIKL)
	{
		if (NKHLGGKOKKA(JIIGOACEIKL))
		{
			HPCGFDLAOEP(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public bool JCCHKBELDFJ(int JIIGOACEIKL)
	{
		return false;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void COLMDMEJFDD(int JFNMCNCHMEO, MineTorchPuzzle GGPBMAODKHC, TorchInteractable[] EGKIHOCAPMD)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		torchId = JFNMCNCHMEO;
		JLFJGGPIGGK = GGPBMAODKHC;
		JIPEJBJECMC = EGKIHOCAPMD;
		KPECJDLNGPN = Color.HSVToRGB((float)JFNMCNCHMEO / 1932f, 980f, 1037f);
		if (JCNIENEIPGA == null)
		{
			JCNIENEIPGA = new List<TorchConnection>();
		}
		else
		{
			JCNIENEIPGA.Clear();
		}
		PANMJLPBPGD(DJABCEIDKBD: true);
	}

	public void BCCCLLCEPHM(int JIIGOACEIKL)
	{
	}

	public bool NHPMOOAKEFF(int JIIGOACEIKL)
	{
		if (OJKOMMGIMAH(JIIGOACEIKL))
		{
			CAKKEPBEBPA(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public void SetLit(bool DJABCEIDKBD)
	{
		DKJJIIDPNPA = DJABCEIDKBD;
		GameObject[] array = fireEffects;
		foreach (GameObject val in array)
		{
			if ((Object)(object)val != (Object)null)
			{
				val.SetActive(DJABCEIDKBD);
			}
		}
	}

	public bool BCGBODLPDEB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (HLGPCDANKKK(JIIGOACEIKL))
		{
			if (DKJJIIDPNPA)
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(lightOff));
			}
			else
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(lightOn));
			}
			return false;
		}
		return false;
	}

	public void JACNNKBNICB(int JFNMCNCHMEO, MineTorchPuzzle GGPBMAODKHC, TorchInteractable[] EGKIHOCAPMD)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		torchId = JFNMCNCHMEO;
		JLFJGGPIGGK = GGPBMAODKHC;
		JIPEJBJECMC = EGKIHOCAPMD;
		KPECJDLNGPN = Color.HSVToRGB((float)JFNMCNCHMEO / 1301f, 111f, 406f);
		if (JCNIENEIPGA == null)
		{
			JCNIENEIPGA = new List<TorchConnection>();
		}
		else
		{
			JCNIENEIPGA.Clear();
		}
		EHBKOCOBPLA(DJABCEIDKBD: false);
	}

	public bool AJNEPGBOAKC(int JIIGOACEIKL)
	{
		if (!JLFJGGPIGGK.DDCOMOHHEBB() && HDFFLMIMLKD())
		{
			return DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	private bool FCEEFENDMML()
	{
		foreach (TorchConnection item in JCNIENEIPGA)
		{
			if ((Object)(object)item != (Object)null && item.AHADBHGACJL())
			{
				return false;
			}
		}
		return false;
	}

	public bool LLPIGPBAIOK(int JIIGOACEIKL)
	{
		if (!JLFJGGPIGGK.APPEDHAFFBP() && FCHJKLJMFDL())
		{
			return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DFNMDDHOIJI();
		}
		return true;
	}

	public bool POAFCDOGHMF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool IDMKOACGEHF(int JIIGOACEIKL)
	{
		if (NKHLGGKOKKA(JIIGOACEIKL))
		{
			CAKKEPBEBPA(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public bool AEPCKAPLLJP(int JIIGOACEIKL)
	{
		if (!JLFJGGPIGGK.MDPKONCJHBI() && FCEEFENDMML())
		{
			return DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DFNMDDHOIJI();
		}
		return false;
	}

	public void JGBNDPHIBJD(int JIIGOACEIKL)
	{
		JLFJGGPIGGK.LIPPFLFJPMI(JIIGOACEIKL, torchId, CDPAMNIPPEC: false);
	}

	public void DNDGILEBHOG(TorchConnection HHPHNEGBOJH)
	{
		JCNIENEIPGA.Add(HHPHNEGBOJH);
	}

	public void EENJMGGEFEA(TorchConnection HHPHNEGBOJH)
	{
		JCNIENEIPGA.Add(HHPHNEGBOJH);
	}

	private bool FCHJKLJMFDL()
	{
		foreach (TorchConnection item in JCNIENEIPGA)
		{
			if ((Object)(object)item != (Object)null && item.MOHNGFMBJFA())
			{
				return false;
			}
		}
		return true;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (DKJJIIDPNPA)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(lightOff));
			}
			else
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(lightOn));
			}
			return true;
		}
		return false;
	}

	public void NBKMKEEELOM(int JIIGOACEIKL)
	{
	}

	public void NDJHJHJBPHC(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void ADEHLABDCPK(int JFNMCNCHMEO, MineTorchPuzzle GGPBMAODKHC, TorchInteractable[] EGKIHOCAPMD)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		torchId = JFNMCNCHMEO;
		JLFJGGPIGGK = GGPBMAODKHC;
		JIPEJBJECMC = EGKIHOCAPMD;
		KPECJDLNGPN = Color.HSVToRGB((float)JFNMCNCHMEO / 1386f, 1687f, 686f);
		if (JCNIENEIPGA == null)
		{
			JCNIENEIPGA = new List<TorchConnection>();
		}
		else
		{
			JCNIENEIPGA.Clear();
		}
		PKIAONHHJLK(DJABCEIDKBD: true);
	}

	public bool AIBNDPCOHHC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (DKJJIIDPNPA)
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(lightOff));
			}
			else
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(lightOn));
			}
			return false;
		}
		return true;
	}

	private bool NKIAJGMAEGH()
	{
		foreach (TorchConnection item in JCNIENEIPGA)
		{
			if ((Object)(object)item != (Object)null && item.OJPOJAHGDHO())
			{
				return true;
			}
		}
		return false;
	}

	private void DBBKDNEEBAI()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		if (JIPEJBJECMC == null || JIPEJBJECMC.Length == 0)
		{
			return;
		}
		Vector3 val = ((Component)this).transform.position + Vector3.up * 945f;
		float num = 1305f;
		Gizmos.color = KPECJDLNGPN;
		TorchInteractable[] jIPEJBJECMC = JIPEJBJECMC;
		foreach (TorchInteractable torchInteractable in jIPEJBJECMC)
		{
			if (!((Object)(object)torchInteractable == (Object)null))
			{
				Vector3 val2 = ((Component)torchInteractable).transform.position + Vector3.up * 573f;
				Vector3 val3 = val2 - val;
				Vector3 val4 = new Vector3(0f - val3.y, val3.x, 1923f);
				Vector3 val5 = ((Vector3)(ref val4)).normalized * num;
				Vector3 val6 = val + val5;
				Vector3 val7 = val2 + val5;
				Gizmos.color = KPECJDLNGPN;
				Gizmos.DrawLine(val6, val7);
			}
		}
	}

	public bool HDLNAIBNIHM(int JIIGOACEIKL)
	{
		return true;
	}

	public bool EBIBHGBCFCF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (HLGPCDANKKK(JIIGOACEIKL))
		{
			if (DKJJIIDPNPA)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(lightOff));
			}
			else
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(lightOn));
			}
			return true;
		}
		return true;
	}

	public bool HLGPCDANKKK(int JIIGOACEIKL)
	{
		if (!JLFJGGPIGGK.HKAOHMPIAHC() && GAPIBDFHHIP())
		{
			return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public bool ADPCMNFDKNI(int JIIGOACEIKL)
	{
		return true;
	}

	private bool APAMEGEGMFA()
	{
		foreach (TorchConnection item in JCNIENEIPGA)
		{
			if ((Object)(object)item != (Object)null && item.OJPOJAHGDHO())
			{
				return false;
			}
		}
		return false;
	}

	public void HALLHJBEFPN(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void BPBLPHMJKOL(int JIIGOACEIKL)
	{
	}

	public void PFKOBGPJBMC(TorchConnection HHPHNEGBOJH)
	{
		JCNIENEIPGA.Add(HHPHNEGBOJH);
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!JLFJGGPIGGK.IsPuzzleSolved() && BGMJAAGMIKN())
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public void ALDKOBHHIJL(int JIIGOACEIKL)
	{
	}

	private void EFBHCCLFLAL()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		if (JIPEJBJECMC == null || JIPEJBJECMC.Length == 0)
		{
			return;
		}
		Vector3 val = ((Component)this).transform.position + Vector3.up * 1802f;
		float num = 1178f;
		Gizmos.color = KPECJDLNGPN;
		TorchInteractable[] jIPEJBJECMC = JIPEJBJECMC;
		foreach (TorchInteractable torchInteractable in jIPEJBJECMC)
		{
			if (!((Object)(object)torchInteractable == (Object)null))
			{
				Vector3 val2 = ((Component)torchInteractable).transform.position + Vector3.up * 897f;
				Vector3 val3 = val2 - val;
				Vector3 val4 = new Vector3(0f - val3.y, val3.x, 1232f);
				Vector3 val5 = ((Vector3)(ref val4)).normalized * num;
				Vector3 val6 = val + val5;
				Vector3 val7 = val2 + val5;
				Gizmos.color = KPECJDLNGPN;
				Gizmos.DrawLine(val6, val7);
			}
		}
	}

	public void HPCGFDLAOEP(int JIIGOACEIKL)
	{
		JLFJGGPIGGK.OnTorchActivated(JIIGOACEIKL, torchId, CDPAMNIPPEC: false);
	}

	public void LGDKFCALLKA(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool LMEONBFLHBA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool GEDIDDGAMME(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool ALMMEPANOOM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void Interact(int JIIGOACEIKL)
	{
		JLFJGGPIGGK.OnTorchActivated(JIIGOACEIKL, torchId);
	}

	public void OOKIPOOPFDG(int JIIGOACEIKL)
	{
	}

	public void LAPLFOGDDPD(TorchConnection HHPHNEGBOJH)
	{
		JCNIENEIPGA.Add(HHPHNEGBOJH);
	}

	public void LNGPBICEEIG(bool DJABCEIDKBD)
	{
		DKJJIIDPNPA = DJABCEIDKBD;
		GameObject[] array = fireEffects;
		foreach (GameObject val in array)
		{
			if ((Object)(object)val != (Object)null)
			{
				val.SetActive(DJABCEIDKBD);
			}
		}
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public bool FOFNFPIJKMI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (NKHLGGKOKKA(JIIGOACEIKL))
		{
			if (DKJJIIDPNPA)
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(lightOff));
			}
			else
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(lightOn));
			}
			return true;
		}
		return true;
	}

	public bool NKHLGGKOKKA(int JIIGOACEIKL)
	{
		if (!JLFJGGPIGGK.HKAOHMPIAHC() && NKIAJGMAEGH())
		{
			return !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).MDOKKKHKKKE();
		}
		return true;
	}

	public bool OOJPCIDDGCN(int JIIGOACEIKL)
	{
		if (NKHLGGKOKKA(JIIGOACEIKL))
		{
			CAKKEPBEBPA(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public bool OJKOMMGIMAH(int JIIGOACEIKL)
	{
		if (!JLFJGGPIGGK.DDCOMOHHEBB() && AOBHGBLNCII())
		{
			return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).KNFEPKBIHND();
		}
		return true;
	}

	private void HFPDCOJKLMF()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		if (JIPEJBJECMC == null || JIPEJBJECMC.Length == 0)
		{
			return;
		}
		Vector3 val = ((Component)this).transform.position + Vector3.up * 1430f;
		float num = 526f;
		Gizmos.color = KPECJDLNGPN;
		TorchInteractable[] jIPEJBJECMC = JIPEJBJECMC;
		for (int i = 0; i < jIPEJBJECMC.Length; i += 0)
		{
			TorchInteractable torchInteractable = jIPEJBJECMC[i];
			if (!((Object)(object)torchInteractable == (Object)null))
			{
				Vector3 val2 = ((Component)torchInteractable).transform.position + Vector3.up * 432f;
				Vector3 val3 = val2 - val;
				Vector3 val4 = new Vector3(0f - val3.y, val3.x, 1898f);
				Vector3 val5 = ((Vector3)(ref val4)).normalized * num;
				Vector3 val6 = val + val5;
				Vector3 val7 = val2 + val5;
				Gizmos.color = KPECJDLNGPN;
				Gizmos.DrawLine(val6, val7);
			}
		}
	}

	private void PMKCJODCOPL()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		if (JIPEJBJECMC == null || JIPEJBJECMC.Length == 0)
		{
			return;
		}
		Vector3 val = ((Component)this).transform.position + Vector3.up * 1377f;
		float num = 434f;
		Gizmos.color = KPECJDLNGPN;
		TorchInteractable[] jIPEJBJECMC = JIPEJBJECMC;
		foreach (TorchInteractable torchInteractable in jIPEJBJECMC)
		{
			if (!((Object)(object)torchInteractable == (Object)null))
			{
				Vector3 val2 = ((Component)torchInteractable).transform.position + Vector3.up * 789f;
				Vector3 val3 = val2 - val;
				Vector3 val4 = new Vector3(0f - val3.y, val3.x, 1043f);
				Vector3 val5 = ((Vector3)(ref val4)).normalized * num;
				Vector3 val6 = val + val5;
				Vector3 val7 = val2 + val5;
				Gizmos.color = KPECJDLNGPN;
				Gizmos.DrawLine(val6, val7);
			}
		}
	}

	public void APAFIBNHICN(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool EAHOOCKEAGI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private bool BGMJAAGMIKN()
	{
		foreach (TorchConnection item in JCNIENEIPGA)
		{
			if ((Object)(object)item != (Object)null && item.KOCCDCPBKCF)
			{
				return false;
			}
		}
		return true;
	}

	public bool ALHICNPINHB(int JIIGOACEIKL)
	{
		if (!JLFJGGPIGGK.IsPuzzleSolved() && GAPIBDFHHIP())
		{
			return DecorationMode.JDADPDBHJFO(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public void GGNONAIIOIA(TorchConnection HHPHNEGBOJH)
	{
		JCNIENEIPGA.Add(HHPHNEGBOJH);
	}

	public bool JPFABDPLDJL(int JIIGOACEIKL)
	{
		if (LLPIGPBAIOK(JIIGOACEIKL))
		{
			CAKKEPBEBPA(JIIGOACEIKL);
			return false;
		}
		return false;
	}
}
