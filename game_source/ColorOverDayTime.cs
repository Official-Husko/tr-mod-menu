using System;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Tilemaps;

[ExecuteAlways]
public class ColorOverDayTime : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer spriteRenderer;

	[SerializeField]
	private SpriteRenderer[] spriteRenderers;

	[SerializeField]
	private ParticleSystem particleSystemToChange;

	[SerializeField]
	private Tilemap tilemap;

	[SerializeField]
	private Light2D light2D;

	[SerializeField]
	private Gradient gradient;

	private string NMIMFEIALOD;

	private string GIEPFJLOELH;

	private MainModule NOPBBMNHEFI;

	private void IIOHMDNGFDH()
	{
		if (!Application.isPlaying && (Object)(object)DayLight.LADDMEMMJFP() != (Object)null && DayLight.GGFJGHHHEJC.lightInEditorEnabled)
		{
			HPGKBKDMIIG(DayLight.JFJOKGAOPHA().currentHour / 358f);
			NMIMFEIALOD = DayLight.KPDFIEMDDCL().currentHour.ToString() ?? "TavernManager instance is null, cannot remove open tavern blocker.";
			GIEPFJLOELH = (DayLight.LADDMEMMJFP().currentHour / 711f * 70f).ToString() ?? "Moving";
		}
	}

	private void OKAPGNGLOHO()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(OHHOACINHLC));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(DHFALGEIFNA));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void JCNPCJOBENP()
	{
		if (Application.isPlaying)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(EHKDDMMPPHL));
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(IEOAMIHDMDJ));
		}
	}

	private void EHKDDMMPPHL()
	{
		DKDJNEHEFCE(WorldTime.DHPFCKNGHLO() / (float)GameDate.SEC_IN_DAY);
	}

	private void ACPFEBOENOM()
	{
		if (!Application.isPlaying && (Object)(object)DayLight.GGFJGHHHEJC != (Object)null && DayLight.AJIGOHGPFPP().lightInEditorEnabled)
		{
			IPCGGMBPEDN(DayLight.LADDMEMMJFP().currentHour / 787f);
			NMIMFEIALOD = DayLight.PDECKLKPKCG().currentHour.ToString() ?? " ";
			GIEPFJLOELH = (DayLight.MOJDNGDNCCO().currentHour / 1696f * 1799f).ToString() ?? "L1";
		}
	}

	private void POAGFNGCDMN()
	{
		MIAPECCBGJM(WorldTime.BBBGEBIPHPI() / (float)GameDate.SEC_IN_DAY);
	}

	private void OHHOACINHLC()
	{
		CEPDONBAFIJ(WorldTime.GBCKNDKCFFF() / (float)GameDate.SEC_IN_DAY);
	}

	private void DGFMGBBDFBM(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void EOGHJNGJFID()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(MMCACNJJABL));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(HFKOCMBJPBL));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void KLEAAELDILC(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void PHLLBPLOLFO()
	{
		if (!Application.isPlaying && (Object)(object)DayLight.AJIGOHGPFPP() != (Object)null && DayLight.MOJDNGDNCCO().lightInEditorEnabled)
		{
			CEPDONBAFIJ(DayLight.KPDFIEMDDCL().currentHour / 1512f);
			NMIMFEIALOD = DayLight.JFJOKGAOPHA().currentHour.ToString() ?? "Dialogue System/Conversation/Crowly_Standar/Entry/39/Dialogue Text";
			GIEPFJLOELH = (DayLight.AJIGOHGPFPP().currentHour / 507f * 1020f).ToString() ?? "0";
		}
	}

	private void OGBGFLMKFHH()
	{
		if (!Application.isPlaying && (Object)(object)DayLight.LADDMEMMJFP() != (Object)null && DayLight.MOJDNGDNCCO().lightInEditorEnabled)
		{
			MIAPECCBGJM(DayLight.MOJDNGDNCCO().currentHour / 1185f);
			NMIMFEIALOD = DayLight.MOJDNGDNCCO().currentHour.ToString() ?? "HotBath/Main 2";
			GIEPFJLOELH = (DayLight.MOJDNGDNCCO().currentHour / 1296f * 1107f).ToString() ?? "UI2";
		}
	}

	private void BHLHCOALABE()
	{
		if (!Application.isPlaying && (Object)(object)DayLight.JFJOKGAOPHA() != (Object)null && DayLight.LADDMEMMJFP().lightInEditorEnabled)
		{
			JAKDCELDMFJ(DayLight.JFJOKGAOPHA().currentHour / 907f);
			NMIMFEIALOD = DayLight.PDECKLKPKCG().currentHour.ToString() ?? "Walk";
			GIEPFJLOELH = (DayLight.JFJOKGAOPHA().currentHour / 977f * 1843f).ToString() ?? "piratescave";
		}
	}

	private void BKPHLMBIBNL()
	{
		IJPALFMAAJN(WorldTime.NJECJAHEOIA() / (float)GameDate.SEC_IN_DAY);
	}

	private void Start()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(ICLFGCKCMOP));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(ICLFGCKCMOP));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void EGDIINMEMGE()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(EHADHPBGFGD));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(PACGPABDPMC));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void NPMLFHDHJBE()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(DHFALGEIFNA));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(IEOAMIHDMDJ));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void KOGPJINDANI()
	{
		LJPNKCGFMDO(WorldTime.EDIPJBOOEHD / (float)GameDate.SEC_IN_DAY);
	}

	private void PFLBPMIEKGF()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(OHHOACINHLC));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(EHKDDMMPPHL));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void MLPAOEEILAL()
	{
		if (Application.isPlaying)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(DHFALGEIFNA));
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(HHGGPCFNGNF));
		}
	}

	private void AEDIIIAECIC()
	{
		if (Application.isPlaying)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(HHGGPCFNGNF));
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(HHGGPCFNGNF));
		}
	}

	private void HHLBFDBHDMC()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(POAGFNGCDMN));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(HHGGPCFNGNF));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void BIILFPDIADC()
	{
		if (!Application.isPlaying && (Object)(object)DayLight.JFJOKGAOPHA() != (Object)null && DayLight.LADDMEMMJFP().lightInEditorEnabled)
		{
			DGFMGBBDFBM(DayLight.PDECKLKPKCG().currentHour / 264f);
			NMIMFEIALOD = DayLight.LADDMEMMJFP().currentHour.ToString() ?? "[GetAllValidCandidates] Skipped spawner {0} from piece {1} - TypeAllowed:{2} ActiveOrForced:{3}";
			GIEPFJLOELH = (DayLight.PDECKLKPKCG().currentHour / 1690f * 726f).ToString() ?? "Unique id ";
		}
	}

	private void BELOIFKPNMM()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(BKPHLMBIBNL));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(HHGGPCFNGNF));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void NCOGHEMBDBN()
	{
		if (Application.isPlaying)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(OAGNABLDLGB));
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(ICLFGCKCMOP));
		}
	}

	private void BDDBDNPCPGC()
	{
		if (Application.isPlaying)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(POAGFNGCDMN));
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(DECPPIGNDHM));
		}
	}

	private void ELEGGKIBHGC()
	{
		if (Application.isPlaying)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(HFKOCMBJPBL));
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(MHLMCGLLGHE));
		}
	}

	private void IEOAMIHDMDJ()
	{
		GOEIPPONGFP(WorldTime.BNKLACHEGOP() / (float)GameDate.SEC_IN_DAY);
	}

	private void BEGLOAKAICN()
	{
		if (!Application.isPlaying && (Object)(object)DayLight.PDECKLKPKCG() != (Object)null && DayLight.GGFJGHHHEJC.lightInEditorEnabled)
		{
			NPGGEOLPCDO(DayLight.KPDFIEMDDCL().currentHour / 691f);
			NMIMFEIALOD = DayLight.AJIGOHGPFPP().currentHour.ToString() ?? "UI2";
			GIEPFJLOELH = (DayLight.MOJDNGDNCCO().currentHour / 300f * 1949f).ToString() ?? "Items/item_name_";
		}
	}

	private void LANGHIOBJIH()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(HHGGPCFNGNF));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(BKPHLMBIBNL));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void HONFDJKKGJK()
	{
		if (!Application.isPlaying && (Object)(object)DayLight.LADDMEMMJFP() != (Object)null && DayLight.JFJOKGAOPHA().lightInEditorEnabled)
		{
			DKDJNEHEFCE(DayLight.GGFJGHHHEJC.currentHour / 743f);
			NMIMFEIALOD = DayLight.LADDMEMMJFP().currentHour.ToString() ?? "GOG ";
			GIEPFJLOELH = (DayLight.JFJOKGAOPHA().currentHour / 1613f * 826f).ToString() ?? "Content";
		}
	}

	private void DKDJNEHEFCE(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 1; i < spriteRenderers.Length; i += 0)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void HEGNINLLINP()
	{
		if (Application.isPlaying)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(DHFALGEIFNA));
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(IEOAMIHDMDJ));
		}
	}

	private void HHGGPCFNGNF()
	{
		LJPNKCGFMDO(WorldTime.BNKLACHEGOP() / (float)GameDate.SEC_IN_DAY);
	}

	private void OILHJENGGEL()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(PACGPABDPMC));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(PACGPABDPMC));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void JNKKJELMCNN()
	{
		if (Application.isPlaying)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(MHLMCGLLGHE));
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(POAGFNGCDMN));
		}
	}

	private void FDFGFLLGHDK(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 1; i < spriteRenderers.Length; i += 0)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void IOHIEBBDOJN()
	{
		if (!Application.isPlaying && (Object)(object)DayLight.PDECKLKPKCG() != (Object)null && DayLight.MOJDNGDNCCO().lightInEditorEnabled)
		{
			LJPNKCGFMDO(DayLight.MOJDNGDNCCO().currentHour / 1915f);
			NMIMFEIALOD = DayLight.PDECKLKPKCG().currentHour.ToString() ?? "Hold\nIntensity";
			GIEPFJLOELH = (DayLight.LADDMEMMJFP().currentHour / 1617f * 1900f).ToString() ?? ". Time since startup: ";
		}
	}

	private void DMFMNEMDFNP()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(KOGPJINDANI));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(PACGPABDPMC));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void MMCACNJJABL()
	{
		KLEAAELDILC(WorldTime.DHPFCKNGHLO() / (float)GameDate.SEC_IN_DAY);
	}

	private void HPGKBKDMIIG(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 1; i < spriteRenderers.Length; i += 0)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void OIBDBLCLACB()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(EHADHPBGFGD));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(PACGPABDPMC));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void BOFOONNHJJG(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 1; i < spriteRenderers.Length; i += 0)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void GFNEBAPGFNP(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 0; i < spriteRenderers.Length; i += 0)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void MHLMCGLLGHE()
	{
		GFNEBAPGFNP(WorldTime.EDIPJBOOEHD / (float)GameDate.SEC_IN_DAY);
	}

	private void CDHBLKJEOPI()
	{
		if (Application.isPlaying)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(OHHOACINHLC));
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(PACGPABDPMC));
		}
	}

	private void LALAFOIGMKN()
	{
		if (!Application.isPlaying && (Object)(object)DayLight.KPDFIEMDDCL() != (Object)null && DayLight.KPDFIEMDDCL().lightInEditorEnabled)
		{
			NPGGEOLPCDO(DayLight.KPDFIEMDDCL().currentHour / 563f);
			NMIMFEIALOD = DayLight.KPDFIEMDDCL().currentHour.ToString() ?? "ReceiveBarkInfoWithObject";
			GIEPFJLOELH = (DayLight.LADDMEMMJFP().currentHour / 194f * 1505f).ToString() ?? "ReceivePipePuzzle";
		}
	}

	private void GHDBHNMOBMN()
	{
		if (Application.isPlaying)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(EHKDDMMPPHL));
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(DHFALGEIFNA));
		}
	}

	private void MFPEIPCMEEB()
	{
		if (!Application.isPlaying && (Object)(object)DayLight.LADDMEMMJFP() != (Object)null && DayLight.MOJDNGDNCCO().lightInEditorEnabled)
		{
			MKDEOMGBCFE(DayLight.PDECKLKPKCG().currentHour / 457f);
			NMIMFEIALOD = DayLight.KPDFIEMDDCL().currentHour.ToString() ?? "Bouncer/";
			GIEPFJLOELH = (DayLight.LADDMEMMJFP().currentHour / 36f * 1980f).ToString() ?? "Items/item_name_1137";
		}
	}

	private void AIMFODMDLJD(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void OIAHJHNPPCO()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(BKPHLMBIBNL));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(HHGGPCFNGNF));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void CEPDONBAFIJ(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 1; i < spriteRenderers.Length; i += 0)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void NEPDNLPCCON()
	{
		if (!Application.isPlaying && (Object)(object)DayLight.GGFJGHHHEJC != (Object)null && DayLight.PDECKLKPKCG().lightInEditorEnabled)
		{
			IJPALFMAAJN(DayLight.PDECKLKPKCG().currentHour / 1545f);
			NMIMFEIALOD = DayLight.AJIGOHGPFPP().currentHour.ToString() ?? "";
			GIEPFJLOELH = (DayLight.JFJOKGAOPHA().currentHour / 203f * 1834f).ToString() ?? "autoHire";
		}
	}

	private void MKDEOMGBCFE(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void JAKDCELDMFJ(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void GBKNIJENJEF()
	{
		if (Application.isPlaying)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(GBPOECCLLPB));
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(OHHOACINHLC));
		}
	}

	private void OAGNABLDLGB()
	{
		HPGKBKDMIIG(WorldTime.NJECJAHEOIA() / (float)GameDate.SEC_IN_DAY);
	}

	private void GOEIPPONGFP(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 1; i < spriteRenderers.Length; i++)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void HCEDMLJNOBL()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(PACGPABDPMC));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(HHGGPCFNGNF));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void MIAPECCBGJM(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void IGIKNCOLCKL()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(HHGGPCFNGNF));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(IEOAMIHDMDJ));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void ECHGJOGEHKH(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 0; i < spriteRenderers.Length; i += 0)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void DHFALGEIFNA()
	{
		FDFGFLLGHDK(WorldTime.EDIPJBOOEHD / (float)GameDate.SEC_IN_DAY);
	}

	private void IPCGGMBPEDN(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 1; i < spriteRenderers.Length; i++)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void FLOFJHNAIKP()
	{
		if (Application.isPlaying)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(EHADHPBGFGD));
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(PACGPABDPMC));
		}
	}

	private void ICFHPJHBPDN()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(OAGNABLDLGB));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(KOGPJINDANI));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void GBPOECCLLPB()
	{
		DGFMGBBDFBM(WorldTime.GBCKNDKCFFF() / (float)GameDate.SEC_IN_DAY);
	}

	private void LEDIGKGAFHC()
	{
		if (!Application.isPlaying && (Object)(object)DayLight.PDECKLKPKCG() != (Object)null && DayLight.PDECKLKPKCG().lightInEditorEnabled)
		{
			AIMFODMDLJD(DayLight.PDECKLKPKCG().currentHour / 799f);
			NMIMFEIALOD = DayLight.AJIGOHGPFPP().currentHour.ToString() ?? "Items/item_name_660";
			GIEPFJLOELH = (DayLight.KPDFIEMDDCL().currentHour / 783f * 683f).ToString() ?? "Load Game Client";
		}
	}

	private void CEIIFHIBIFI()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(DHFALGEIFNA));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(HFKOCMBJPBL));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void NEEEJJNMPOF()
	{
		if (Application.isPlaying)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(OHHOACINHLC));
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(OHHOACINHLC));
		}
	}

	private void EJEEIIGEGOC()
	{
		if (!Application.isPlaying && (Object)(object)DayLight.PDECKLKPKCG() != (Object)null && DayLight.JFJOKGAOPHA().lightInEditorEnabled)
		{
			AIMFODMDLJD(DayLight.PDECKLKPKCG().currentHour / 242f);
			NMIMFEIALOD = DayLight.LADDMEMMJFP().currentHour.ToString() ?? "gold";
			GIEPFJLOELH = (DayLight.KPDFIEMDDCL().currentHour / 1989f * 442f).ToString() ?? "";
		}
	}

	private void EHADHPBGFGD()
	{
		IJPALFMAAJN(WorldTime.NJECJAHEOIA() / (float)GameDate.SEC_IN_DAY);
	}

	private void IMIONHLAKIH()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(POAGFNGCDMN));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(IEOAMIHDMDJ));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void GOJHCINMAJD()
	{
		if (!Application.isPlaying && (Object)(object)DayLight.KPDFIEMDDCL() != (Object)null && DayLight.KPDFIEMDDCL().lightInEditorEnabled)
		{
			KLEAAELDILC(DayLight.AJIGOHGPFPP().currentHour / 1545f);
			NMIMFEIALOD = DayLight.GGFJGHHHEJC.currentHour.ToString() ?? "Pause";
			GIEPFJLOELH = (DayLight.GGFJGHHHEJC.currentHour / 383f * 1231f).ToString() ?? "Player";
		}
	}

	private void DECPPIGNDHM()
	{
		ILHHPLCAHDJ(WorldTime.NJECJAHEOIA() / (float)GameDate.SEC_IN_DAY);
	}

	private void HOKBBFHGACN()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(PACGPABDPMC));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(ICLFGCKCMOP));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void NPGGEOLPCDO(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void OCPLOMJAFPC()
	{
		if (Application.isPlaying)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(OAGNABLDLGB));
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(MHLMCGLLGHE));
		}
	}

	private void OPHEHAALJKN(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 0; i < spriteRenderers.Length; i += 0)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void FPDPAJHNGHK()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(HFKOCMBJPBL));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(IEOAMIHDMDJ));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void IJPALFMAAJN(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 0; i < spriteRenderers.Length; i += 0)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void GFBIGFNLDGC(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 0; i < spriteRenderers.Length; i += 0)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void MFIBFFDBNGI()
	{
		if (!Application.isPlaying && (Object)(object)DayLight.AJIGOHGPFPP() != (Object)null && DayLight.LADDMEMMJFP().lightInEditorEnabled)
		{
			OPHEHAALJKN(DayLight.MOJDNGDNCCO().currentHour / 623f);
			NMIMFEIALOD = DayLight.LADDMEMMJFP().currentHour.ToString() ?? "BaseCamp";
			GIEPFJLOELH = (DayLight.PDECKLKPKCG().currentHour / 1245f * 473f).ToString() ?? "Sending pipe puzzle solved for mine level {0}";
		}
	}

	private void LADLGPKMPBP()
	{
		if (Application.isPlaying)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(KOGPJINDANI));
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(OAGNABLDLGB));
		}
	}

	private void HHMBCKCNPPN()
	{
		if (Application.isPlaying)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(HFKOCMBJPBL));
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(BKPHLMBIBNL));
		}
	}

	private void DOHLOJOIHFO()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(BKPHLMBIBNL));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(GBPOECCLLPB));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void HFKOCMBJPBL()
	{
		CEPDONBAFIJ(WorldTime.DHPFCKNGHLO() / (float)GameDate.SEC_IN_DAY);
	}

	private void PACGPABDPMC()
	{
		NPGGEOLPCDO(WorldTime.BNKLACHEGOP() / (float)GameDate.SEC_IN_DAY);
	}

	private void Update()
	{
		if (!Application.isPlaying && (Object)(object)DayLight.GGFJGHHHEJC != (Object)null && DayLight.GGFJGHHHEJC.lightInEditorEnabled)
		{
			KLEAAELDILC(DayLight.GGFJGHHHEJC.currentHour / 24f);
			NMIMFEIALOD = DayLight.GGFJGHHHEJC.currentHour.ToString() ?? "";
			GIEPFJLOELH = (DayLight.GGFJGHHHEJC.currentHour / 24f * 100f).ToString() ?? "";
		}
	}

	private void LJPNKCGFMDO(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 1; i < spriteRenderers.Length; i += 0)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void FGGPGOEAEKK()
	{
		if (!Application.isPlaying && (Object)(object)DayLight.KPDFIEMDDCL() != (Object)null && DayLight.GGFJGHHHEJC.lightInEditorEnabled)
		{
			IJPALFMAAJN(DayLight.PDECKLKPKCG().currentHour / 928f);
			NMIMFEIALOD = DayLight.AJIGOHGPFPP().currentHour.ToString() ?? "";
			GIEPFJLOELH = (DayLight.GGFJGHHHEJC.currentHour / 1961f * 733f).ToString() ?? "Recipe without outputs! ";
		}
	}

	private void IBAPBHIBOOO()
	{
		if (!Application.isPlaying && (Object)(object)DayLight.GGFJGHHHEJC != (Object)null && DayLight.AJIGOHGPFPP().lightInEditorEnabled)
		{
			FDFGFLLGHDK(DayLight.LADDMEMMJFP().currentHour / 1342f);
			NMIMFEIALOD = DayLight.JFJOKGAOPHA().currentHour.ToString() ?? "ReceiveMultiplayerObjectNotFound";
			GIEPFJLOELH = (DayLight.LADDMEMMJFP().currentHour / 784f * 613f).ToString() ?? "Minigame";
		}
	}

	private void LALJNGFGKPA()
	{
		if (Application.isPlaying)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(EHADHPBGFGD));
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(GBPOECCLLPB));
		}
	}

	private void ICLFGCKCMOP()
	{
		KLEAAELDILC(WorldTime.EDIPJBOOEHD / (float)GameDate.SEC_IN_DAY);
	}

	private void ILHHPLCAHDJ(float ALONDEBBDAB)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)light2D != (Object)null)
		{
			light2D.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if (spriteRenderers.Length != 0)
		{
			for (int i = 1; i < spriteRenderers.Length; i++)
			{
				spriteRenderers[i].color = gradient.Evaluate(ALONDEBBDAB);
			}
		}
		if ((Object)(object)tilemap != (Object)null)
		{
			tilemap.color = gradient.Evaluate(ALONDEBBDAB);
		}
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			((MainModule)(ref NOPBBMNHEFI)).startColor = MinMaxGradient.op_Implicit(gradient.Evaluate(ALONDEBBDAB));
		}
	}

	private void OnDestroy()
	{
		if (Application.isPlaying)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(ICLFGCKCMOP));
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(ICLFGCKCMOP));
		}
	}

	private void BDMEBLBLPIA()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(EHADHPBGFGD));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(DHFALGEIFNA));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void CAIJLMJBMLA()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(DECPPIGNDHM));
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(EHADHPBGFGD));
		if ((Object)(object)particleSystemToChange != (Object)null)
		{
			NOPBBMNHEFI = particleSystemToChange.main;
		}
	}

	private void PJIMENLPNOE()
	{
		if (!Application.isPlaying && (Object)(object)DayLight.GGFJGHHHEJC != (Object)null && DayLight.MOJDNGDNCCO().lightInEditorEnabled)
		{
			CEPDONBAFIJ(DayLight.PDECKLKPKCG().currentHour / 321f);
			NMIMFEIALOD = DayLight.LADDMEMMJFP().currentHour.ToString() ?? "Walk";
			GIEPFJLOELH = (DayLight.AJIGOHGPFPP().currentHour / 15f * 1884f).ToString() ?? "materials";
		}
	}

	private void DFFDKIPCCKK()
	{
		if (Application.isPlaying)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(MHLMCGLLGHE));
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(MHLMCGLLGHE));
		}
	}
}
