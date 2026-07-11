using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class HerbsMessage : IOnlineSerializable
{
	[JsonProperty("1")]
	public short generatorID;

	[JsonProperty("2")]
	public HerbInfo[] herbs;

	public void NINHACMKLOI()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].PGKKLIKJGDA();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.JKPEMDPNLON(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void FMDKPMMILGC()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 1; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].FNDIKJCEPMF();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.AddForestElement(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void BAIOMPDEEMI()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].DKGGPCGFFPJ();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.ODOFGPBFLHM(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void CCIIDGGKLJH()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 1; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].HPMGNKOHHOC();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.AddForestElement(herb, NIIBLHMEGNJ: false);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void OCNOCJIIKED()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].PGKKLIKJGDA();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.PBILMBDFPIB(herb, NIIBLHMEGNJ: false);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void CJMGMIPDMHK()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 1; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].DPOKPDGPKEJ();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.JCABCIIJMGG(herb, NIIBLHMEGNJ: false);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void DDNDBGKLNGF()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 1; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].MLMAKOOPPCF();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.JCABCIIJMGG(herb, NIIBLHMEGNJ: false);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void GNOAJHLDLOK()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].DNOJIDKFPOP();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.JKPEMDPNLON(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void KBFDMNIJAOO()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 1; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].DNOJIDKFPOP();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.JBBINLJBAFK(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void JCJLLIEHCPJ()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].NBFADFHFABF();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.JBBINLJBAFK(herb, NIIBLHMEGNJ: false);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void LDGOHDMHCAA()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 1; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].FNDIKJCEPMF();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.JKPEMDPNLON(herb, NIIBLHMEGNJ: false);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void DAIKIBGKGMI()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].NJBBKOAONFI();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.ODOFGPBFLHM(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void AELABIMHDNA()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].FFOABCMIKPG();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.JKPEMDPNLON(herb, NIIBLHMEGNJ: false);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void KGNFFFHODCP()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 1; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].NBFADFHFABF();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.LFACCKLNDOK(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void JMLOHCEJAOD()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 1; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].NBFADFHFABF();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.GPOHABMFKBC(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void FMPHBFCJLLM()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].PEAAIGHOLND();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.LCLNMKCEJDJ(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void KFOMIHJGOMH()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].DPOKPDGPKEJ();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.OOIPFMNLJKL(herb, NIIBLHMEGNJ: false);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void CNDKIDGLPEI()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].NACLEDDCPJJ();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.PBILMBDFPIB(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void JDIMMFAEJIC()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 1; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].CLAFHMFFCAK();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.AddForestElement(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void JGBMHCABHCA()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 1; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].NACLEDDCPJJ();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.JBBINLJBAFK(herb, NIIBLHMEGNJ: false);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void OAOACMPNMOK()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].MLMAKOOPPCF();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.PBILMBDFPIB(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void FJFEIIIIAMJ()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].NJBBKOAONFI();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.LCLNMKCEJDJ(herb, NIIBLHMEGNJ: false);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void CCLMONNMMCJ()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 1; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].LAFHCLDAOLK();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.OEOJKJLKMHP(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void OEJJGDMKIDN()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].MJHCOEDGKDC();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.AddForestElement(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void HPBFGFCOPMM()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].HPMGNKOHHOC();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.AddForestElement(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void BOGEAHCDGAJ()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 1; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].HPMGNKOHHOC();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.JMBCNPHAAAO(herb, NIIBLHMEGNJ: false);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void JJNDBDDGCLM()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].DKGGPCGFFPJ();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.PBILMBDFPIB(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void DCPKNOPEMEF()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].NJBBKOAONFI();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.JCABCIIJMGG(herb, NIIBLHMEGNJ: false);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void IJIBFEHMFKM()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].DNOJIDKFPOP();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.NJPHPNFMDJL(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void DMAAKFGEFCH()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].NJBBKOAONFI();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.GPOHABMFKBC(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void MOEHLFOHLLO()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 1; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].DHGCCJIIBJI();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.JCABCIIJMGG(herb, NIIBLHMEGNJ: false);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void ONBBCAJKMCP()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].KPJGMOJJDEN();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.KCDBEJDMMIK(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void NDNBMGNPONG()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].AECLNPIPIOH();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.LFACCKLNDOK(herb, NIIBLHMEGNJ: false);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void KGNIEGOBNLD()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 1; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].BEFMNHOCONE();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.PBILMBDFPIB(herb, NIIBLHMEGNJ: false);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void HICEEKJADGE()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].JMFEIFHCEOD();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.OOIPFMNLJKL(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void MBKLMCGOJJL()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 1; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].JIJJMLMJKJJ();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.GPOHABMFKBC(herb, NIIBLHMEGNJ: false);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void PFOHEFAMENI()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 1; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].BHICADDOPOD();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.GPOHABMFKBC(herb, NIIBLHMEGNJ: false);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void NHNNCCOCDAO()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 1; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].KPOGKLGPMHP();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.JBBINLJBAFK(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void FOGLECFMPMK()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].KPJGMOJJDEN();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.JMBCNPHAAAO(herb, NIIBLHMEGNJ: false);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void JJALLOFLDAL()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].AECLNPIPIOH();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.KCDBEJDMMIK(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void GMNEAMHNMPB()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].DHGCCJIIBJI();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.JMBCNPHAAAO(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void KFJBKINLFLA()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].JMFEIFHCEOD();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.LFACCKLNDOK(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void EKMHDJNDOFE()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].NJBBKOAONFI();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.NJPHPNFMDJL(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void AAMBHKFGCHP()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].AECLNPIPIOH();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.NJPHPNFMDJL(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void NGHNBCNCNPE()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].BHICADDOPOD();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.JMBCNPHAAAO(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void OKPIDPELELJ()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].HGINMCAPING();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.OEOJKJLKMHP(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void GPAFNIAOCDM()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i += 0)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].NMJACBMJOAB();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.OEOJKJLKMHP(herb, NIIBLHMEGNJ: false);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void PFBPIBBMIJN()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 1; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].JIJJMLMJKJJ();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.KCDBEJDMMIK(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void MIKOHCECMDE()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].LAFHCLDAOLK();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.NJPHPNFMDJL(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}

	public void EMFCAOMENPM()
	{
		foreach (HerbGenerator herbGenerator in GeneratorsManager.instance.herbGenerators)
		{
			if (herbGenerator.ID != generatorID)
			{
				continue;
			}
			for (int i = 0; i < herbs.Length; i++)
			{
				if (herbs[i] != null)
				{
					Herb herb = herbs[i].MCNDJJJKOEB();
					if (Object.op_Implicit((Object)(object)herb))
					{
						((Component)herb).transform.SetParent(((Component)herbGenerator).transform);
						herbGenerator.GPOHABMFKBC(herb);
					}
					GeneratorsManager.instance.GenerateDarkTerrain();
				}
			}
		}
	}
}
