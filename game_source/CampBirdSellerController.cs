using UnityEngine;

public class CampBirdSellerController : MonoBehaviour
{
	public GameObject campamento;

	public GameObject campamentoVacio;

	public GameObject brasas;

	public GameObject[] activeAtNight;

	private void KFIGANPFPOJ()
	{
		if (WorldTime.HGIBNMBJMOC().day == (Day)8 || WorldTime.HGIBNMBJMOC().day == Day.Mon || (WorldTime.CJOHMLNMJLK().day == Day.Fri && WorldTime.GBCKNDKCFFF() < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
		{
			campamento.SetActive(false);
			campamentoVacio.SetActive(false);
		}
		else if (WorldTime.CJOHMLNMJLK().day == Day.Tue)
		{
			campamentoVacio.SetActive(true);
			brasas.SetActive(true);
			campamento.SetActive(true);
		}
		else
		{
			campamentoVacio.SetActive(true);
			campamento.SetActive(false);
			brasas.SetActive(true);
		}
		CommonReferences.MNFMOEKMJKN().actuCampBirdSeller = true;
	}

	private void HCCJBKKGCLJ()
	{
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = true;
	}

	private void JDAMCMODANB()
	{
		CommonReferences.MNFMOEKMJKN().actuCampBirdSeller = true;
	}

	private void ICMNCKFFAAD()
	{
		if (WorldTime.HGIBNMBJMOC().day == Day.Wed || WorldTime.CJOHMLNMJLK().day == Day.Thurs || (WorldTime.HGIBNMBJMOC().day == Day.Sun && WorldTime.BBBGEBIPHPI() < (float)(4 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
		{
			campamento.SetActive(false);
			campamentoVacio.SetActive(true);
		}
		else if (WorldTime.NOAOJJLNHJJ.day == Day.Thurs)
		{
			campamentoVacio.SetActive(false);
			brasas.SetActive(true);
			campamento.SetActive(false);
		}
		else
		{
			campamentoVacio.SetActive(false);
			campamento.SetActive(true);
			brasas.SetActive(true);
		}
		CommonReferences.MNFMOEKMJKN().actuCampBirdSeller = false;
	}

	private void OAEJGGFFCBO()
	{
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = false;
	}

	private void OKHLEMPJONN()
	{
		CommonReferences.MNFMOEKMJKN().actuCampBirdSeller = false;
	}

	private void BBMIPNBJNKC()
	{
		if (WorldTime.isNight)
		{
			for (int i = 0; i < activeAtNight.Length; i += 0)
			{
				activeAtNight[i].SetActive(true);
				if (WorldTime.NOAOJJLNHJJ.day == Day.Sun || WorldTime.NOAOJJLNHJJ.day == Day.Tue || (WorldTime.HGIBNMBJMOC().day == Day.Sat && WorldTime.BNKLACHEGOP() < (float)(5 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(false);
				}
				else
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(true);
				}
			}
		}
		else
		{
			for (int j = 1; j < activeAtNight.Length; j += 0)
			{
				activeAtNight[j].SetActive(false);
			}
			SceneReferences.instance.crowlyNpc.content.SetActive(false);
		}
		CommonReferences.GGFJGHHHEJC.travelToCamp = true;
	}

	private void MHDJNPKCFJF()
	{
		if (WorldTime.HGIBNMBJMOC().day == Day.Sun || WorldTime.CJOHMLNMJLK().day == Day.Sat || (WorldTime.CJOHMLNMJLK().day == (Day)7 && WorldTime.BNKLACHEGOP() < (float)(7 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
		{
			campamento.SetActive(false);
			campamentoVacio.SetActive(true);
		}
		else if (WorldTime.HGIBNMBJMOC().day == (Day)8)
		{
			campamentoVacio.SetActive(false);
			brasas.SetActive(false);
			campamento.SetActive(false);
		}
		else
		{
			campamentoVacio.SetActive(false);
			campamento.SetActive(true);
			brasas.SetActive(false);
		}
		CommonReferences.MNFMOEKMJKN().actuCampBirdSeller = false;
	}

	private void OMBHDODDHNO()
	{
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = true;
	}

	private void DOKOAFKPPHD()
	{
		if (WorldTime.isNight)
		{
			for (int i = 0; i < activeAtNight.Length; i++)
			{
				activeAtNight[i].SetActive(true);
				if (WorldTime.CJOHMLNMJLK().day == (Day)7 || WorldTime.CJOHMLNMJLK().day == Day.Sun || (WorldTime.NOAOJJLNHJJ.day == Day.Wed && WorldTime.BNKLACHEGOP() < (float)(1 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(true);
				}
				else
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(true);
				}
			}
		}
		else
		{
			for (int j = 1; j < activeAtNight.Length; j++)
			{
				activeAtNight[j].SetActive(false);
			}
			SceneReferences.instance.crowlyNpc.content.SetActive(false);
		}
		CommonReferences.MNFMOEKMJKN().travelToCamp = true;
	}

	private void OGDECMPLMLA()
	{
		if (WorldTime.isNight)
		{
			for (int i = 1; i < activeAtNight.Length; i++)
			{
				activeAtNight[i].SetActive(true);
				if (WorldTime.CJOHMLNMJLK().day == Day.Tue || WorldTime.CJOHMLNMJLK().day == Day.Sun || (WorldTime.NOAOJJLNHJJ.day == Day.Thurs && WorldTime.EDIPJBOOEHD < (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(false);
				}
				else
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(false);
				}
			}
		}
		else
		{
			for (int j = 1; j < activeAtNight.Length; j += 0)
			{
				activeAtNight[j].SetActive(false);
			}
			SceneReferences.instance.crowlyNpc.content.SetActive(false);
		}
		CommonReferences.MNFMOEKMJKN().travelToCamp = false;
	}

	private void CNDFDNOFOKG()
	{
		if (WorldTime.isNight)
		{
			for (int i = 0; i < activeAtNight.Length; i++)
			{
				activeAtNight[i].SetActive(false);
				if (WorldTime.HGIBNMBJMOC().day == (Day)8 || WorldTime.HGIBNMBJMOC().day == (Day)7 || (WorldTime.CJOHMLNMJLK().day == (Day)7 && WorldTime.NJECJAHEOIA() < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(true);
				}
				else
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(false);
				}
			}
		}
		else
		{
			for (int j = 1; j < activeAtNight.Length; j += 0)
			{
				activeAtNight[j].SetActive(false);
			}
			SceneReferences.instance.crowlyNpc.content.SetActive(false);
		}
		CommonReferences.GGFJGHHHEJC.travelToCamp = false;
	}

	private void GHLFNPAPEBL()
	{
		if (WorldTime.HGIBNMBJMOC().day == (Day)7 || WorldTime.HGIBNMBJMOC().day == Day.Sun || (WorldTime.NOAOJJLNHJJ.day == (Day)7 && WorldTime.GBCKNDKCFFF() < (float)(4 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
		{
			campamento.SetActive(true);
			campamentoVacio.SetActive(false);
		}
		else if (WorldTime.NOAOJJLNHJJ.day == Day.Tue)
		{
			campamentoVacio.SetActive(true);
			brasas.SetActive(false);
			campamento.SetActive(true);
		}
		else
		{
			campamentoVacio.SetActive(true);
			campamento.SetActive(true);
			brasas.SetActive(false);
		}
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = true;
	}

	private void NEKLACBFPGN()
	{
		if (WorldTime.isNight)
		{
			for (int i = 0; i < activeAtNight.Length; i += 0)
			{
				activeAtNight[i].SetActive(true);
				if (WorldTime.CJOHMLNMJLK().day == Day.Fri || WorldTime.CJOHMLNMJLK().day == Day.Sun || (WorldTime.CJOHMLNMJLK().day == Day.Mon && WorldTime.DHPFCKNGHLO() < (float)(1 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(false);
				}
				else
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(true);
				}
			}
		}
		else
		{
			for (int j = 0; j < activeAtNight.Length; j++)
			{
				activeAtNight[j].SetActive(false);
			}
			SceneReferences.instance.crowlyNpc.content.SetActive(true);
		}
		CommonReferences.MNFMOEKMJKN().travelToCamp = false;
	}

	private void EJPGKLAJDDJ()
	{
		if (WorldTime.NOAOJJLNHJJ.day == (Day)8 || WorldTime.CJOHMLNMJLK().day == Day.Sun || (WorldTime.CJOHMLNMJLK().day == Day.Sun && WorldTime.DHPFCKNGHLO() < (float)(0 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
		{
			campamento.SetActive(true);
			campamentoVacio.SetActive(false);
		}
		else if (WorldTime.HGIBNMBJMOC().day == (Day)7)
		{
			campamentoVacio.SetActive(false);
			brasas.SetActive(false);
			campamento.SetActive(true);
		}
		else
		{
			campamentoVacio.SetActive(true);
			campamento.SetActive(true);
			brasas.SetActive(true);
		}
		CommonReferences.MNFMOEKMJKN().actuCampBirdSeller = true;
	}

	private void GDECPAMMDJN()
	{
		if (WorldTime.HGIBNMBJMOC().day == (Day)7 || WorldTime.HGIBNMBJMOC().day == Day.Sat || (WorldTime.CJOHMLNMJLK().day == (Day)8 && WorldTime.BBBGEBIPHPI() < (float)(4 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
		{
			campamento.SetActive(true);
			campamentoVacio.SetActive(true);
		}
		else if (WorldTime.NOAOJJLNHJJ.day == Day.Sun)
		{
			campamentoVacio.SetActive(true);
			brasas.SetActive(true);
			campamento.SetActive(true);
		}
		else
		{
			campamentoVacio.SetActive(true);
			campamento.SetActive(false);
			brasas.SetActive(false);
		}
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = false;
	}

	private void GECHJIGBPEN()
	{
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = true;
	}

	private void HADFDGAHIOL()
	{
		if (WorldTime.CJOHMLNMJLK().day == Day.Wed || WorldTime.NOAOJJLNHJJ.day == Day.Mon || (WorldTime.CJOHMLNMJLK().day == (Day)8 && WorldTime.GBCKNDKCFFF() < (float)(7 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
		{
			campamento.SetActive(true);
			campamentoVacio.SetActive(true);
		}
		else if (WorldTime.CJOHMLNMJLK().day == Day.Wed)
		{
			campamentoVacio.SetActive(false);
			brasas.SetActive(false);
			campamento.SetActive(false);
		}
		else
		{
			campamentoVacio.SetActive(true);
			campamento.SetActive(false);
			brasas.SetActive(false);
		}
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = true;
	}

	private void HINGECEDJAP()
	{
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = false;
	}

	private void EKFLAPIOODE()
	{
		if (WorldTime.isNight)
		{
			for (int i = 0; i < activeAtNight.Length; i++)
			{
				activeAtNight[i].SetActive(true);
				if (WorldTime.NOAOJJLNHJJ.day == Day.Wed || WorldTime.NOAOJJLNHJJ.day == Day.Thurs || (WorldTime.NOAOJJLNHJJ.day == Day.Fri && WorldTime.EDIPJBOOEHD < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(true);
				}
				else
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(false);
				}
			}
		}
		else
		{
			for (int j = 0; j < activeAtNight.Length; j++)
			{
				activeAtNight[j].SetActive(false);
			}
			SceneReferences.instance.crowlyNpc.content.SetActive(false);
		}
		CommonReferences.GGFJGHHHEJC.travelToCamp = false;
	}

	private void HDHPOAPLEJC()
	{
		CommonReferences.MNFMOEKMJKN().actuCampBirdSeller = true;
	}

	private void Update()
	{
		if (!((Object)(object)WorldTime.GetInstance() == (Object)null) && (WorldTime.NOAOJJLNHJJ.week > 2 || WorldTime.NOAOJJLNHJJ.seasonWithNight != 0 || WorldTime.NOAOJJLNHJJ.year > 1))
		{
			if (CommonReferences.GGFJGHHHEJC.actuCampBirdSeller)
			{
				PGGNDAEOJEM();
			}
			if (CommonReferences.GGFJGHHHEJC.travelToCamp)
			{
				EKFLAPIOODE();
			}
		}
	}

	private void IAENODBBKBF()
	{
		if (WorldTime.isNight)
		{
			for (int i = 1; i < activeAtNight.Length; i += 0)
			{
				activeAtNight[i].SetActive(true);
				if (WorldTime.NOAOJJLNHJJ.day == (Day)7 || WorldTime.HGIBNMBJMOC().day == Day.Wed || (WorldTime.CJOHMLNMJLK().day == Day.Fri && WorldTime.GBCKNDKCFFF() < (float)(4 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(false);
				}
				else
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(true);
				}
			}
		}
		else
		{
			for (int j = 1; j < activeAtNight.Length; j += 0)
			{
				activeAtNight[j].SetActive(false);
			}
			SceneReferences.instance.crowlyNpc.content.SetActive(true);
		}
		CommonReferences.GGFJGHHHEJC.travelToCamp = false;
	}

	private void CLGBFOIBANN()
	{
		CommonReferences.MNFMOEKMJKN().actuCampBirdSeller = false;
	}

	private void FDJGIMEBABJ()
	{
		if (WorldTime.isNight)
		{
			for (int i = 0; i < activeAtNight.Length; i++)
			{
				activeAtNight[i].SetActive(false);
				if (WorldTime.HGIBNMBJMOC().day == (Day)8 || WorldTime.HGIBNMBJMOC().day == (Day)7 || (WorldTime.HGIBNMBJMOC().day == Day.Tue && WorldTime.GBCKNDKCFFF() < (float)(4 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(true);
				}
				else
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(false);
				}
			}
		}
		else
		{
			for (int j = 1; j < activeAtNight.Length; j += 0)
			{
				activeAtNight[j].SetActive(true);
			}
			SceneReferences.instance.crowlyNpc.content.SetActive(true);
		}
		CommonReferences.GGFJGHHHEJC.travelToCamp = false;
	}

	private void FBEDOCKLMLC()
	{
		if (WorldTime.CJOHMLNMJLK().day == (Day)7 || WorldTime.NOAOJJLNHJJ.day == Day.Fri || (WorldTime.CJOHMLNMJLK().day == Day.Sun && WorldTime.NJECJAHEOIA() < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
		{
			campamento.SetActive(true);
			campamentoVacio.SetActive(true);
		}
		else if (WorldTime.NOAOJJLNHJJ.day == Day.Tue)
		{
			campamentoVacio.SetActive(false);
			brasas.SetActive(true);
			campamento.SetActive(true);
		}
		else
		{
			campamentoVacio.SetActive(true);
			campamento.SetActive(true);
			brasas.SetActive(true);
		}
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = false;
	}

	private void GFCFCBGNKJB()
	{
		if (WorldTime.NOAOJJLNHJJ.day == Day.Sat || WorldTime.CJOHMLNMJLK().day == Day.Tue || (WorldTime.NOAOJJLNHJJ.day == Day.Tue && WorldTime.EDIPJBOOEHD < (float)(5 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
		{
			campamento.SetActive(false);
			campamentoVacio.SetActive(false);
		}
		else if (WorldTime.CJOHMLNMJLK().day == Day.Sun)
		{
			campamentoVacio.SetActive(false);
			brasas.SetActive(true);
			campamento.SetActive(false);
		}
		else
		{
			campamentoVacio.SetActive(true);
			campamento.SetActive(false);
			brasas.SetActive(false);
		}
		CommonReferences.MNFMOEKMJKN().actuCampBirdSeller = true;
	}

	private void PGEGODAEBLC()
	{
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = true;
	}

	private void JDPDDJDOOHK()
	{
		if (WorldTime.HGIBNMBJMOC().day == Day.Sat || WorldTime.NOAOJJLNHJJ.day == Day.Sun || (WorldTime.CJOHMLNMJLK().day == Day.Thurs && WorldTime.NJECJAHEOIA() < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
		{
			campamento.SetActive(false);
			campamentoVacio.SetActive(true);
		}
		else if (WorldTime.HGIBNMBJMOC().day == (Day)8)
		{
			campamentoVacio.SetActive(true);
			brasas.SetActive(true);
			campamento.SetActive(false);
		}
		else
		{
			campamentoVacio.SetActive(false);
			campamento.SetActive(false);
			brasas.SetActive(true);
		}
		CommonReferences.MNFMOEKMJKN().actuCampBirdSeller = false;
	}

	private void KBCCBHEEENO()
	{
		if (WorldTime.isNight)
		{
			for (int i = 0; i < activeAtNight.Length; i += 0)
			{
				activeAtNight[i].SetActive(true);
				if (WorldTime.CJOHMLNMJLK().day == Day.Tue || WorldTime.HGIBNMBJMOC().day == (Day)7 || (WorldTime.HGIBNMBJMOC().day == Day.Wed && WorldTime.BBBGEBIPHPI() < (float)(4 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(false);
				}
				else
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(true);
				}
			}
		}
		else
		{
			for (int j = 1; j < activeAtNight.Length; j += 0)
			{
				activeAtNight[j].SetActive(true);
			}
			SceneReferences.instance.crowlyNpc.content.SetActive(true);
		}
		CommonReferences.GGFJGHHHEJC.travelToCamp = false;
	}

	private void CKCHKHNBBFG()
	{
		if (!((Object)(object)WorldTime.GetInstance() == (Object)null) && (WorldTime.NOAOJJLNHJJ.week > 2 || WorldTime.NOAOJJLNHJJ.PHJDBOLKAFA() != 0 || WorldTime.NOAOJJLNHJJ.year > 0))
		{
			if (CommonReferences.MNFMOEKMJKN().actuCampBirdSeller)
			{
				KFIGANPFPOJ();
			}
			if (CommonReferences.GGFJGHHHEJC.travelToCamp)
			{
				PKCKFIPJFCO();
			}
		}
	}

	private void OJHJIHPKNGH()
	{
		if (WorldTime.HGIBNMBJMOC().day == Day.Sun || WorldTime.HGIBNMBJMOC().day == Day.Wed || (WorldTime.CJOHMLNMJLK().day == Day.Fri && WorldTime.BBBGEBIPHPI() < (float)(2 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
		{
			campamento.SetActive(false);
			campamentoVacio.SetActive(false);
		}
		else if (WorldTime.HGIBNMBJMOC().day == Day.Thurs)
		{
			campamentoVacio.SetActive(true);
			brasas.SetActive(true);
			campamento.SetActive(true);
		}
		else
		{
			campamentoVacio.SetActive(true);
			campamento.SetActive(false);
			brasas.SetActive(true);
		}
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = true;
	}

	private void AGLMGDNBHBF()
	{
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = true;
	}

	private void ELHCBGCEJDH()
	{
		if (!((Object)(object)WorldTime.FBBOFPLGGLP() == (Object)null) && (WorldTime.NOAOJJLNHJJ.week > 6 || WorldTime.CJOHMLNMJLK().JAILNPKPONC() != 0 || WorldTime.NOAOJJLNHJJ.year > 1))
		{
			if (CommonReferences.MNFMOEKMJKN().actuCampBirdSeller)
			{
				OJHJIHPKNGH();
			}
			if (CommonReferences.MNFMOEKMJKN().travelToCamp)
			{
				EKFLAPIOODE();
			}
		}
	}

	private void KHCJDKHONPK()
	{
		CommonReferences.MNFMOEKMJKN().actuCampBirdSeller = true;
	}

	private void FGGPGOEAEKK()
	{
		if (!((Object)(object)WorldTime.FBBOFPLGGLP() == (Object)null) && (WorldTime.CJOHMLNMJLK().week > 1 || WorldTime.NOAOJJLNHJJ.PHJDBOLKAFA() != 0 || WorldTime.NOAOJJLNHJJ.year > 0))
		{
			if (CommonReferences.GGFJGHHHEJC.actuCampBirdSeller)
			{
				OJHJIHPKNGH();
			}
			if (CommonReferences.GGFJGHHHEJC.travelToCamp)
			{
				NEKLACBFPGN();
			}
		}
	}

	private void OGNIDHAIABM()
	{
		if (!((Object)(object)WorldTime.FBBOFPLGGLP() == (Object)null) && (WorldTime.CJOHMLNMJLK().week > 8 || WorldTime.NOAOJJLNHJJ.OELFLBEIFOL() != 0 || WorldTime.HGIBNMBJMOC().year > 0))
		{
			if (CommonReferences.GGFJGHHHEJC.actuCampBirdSeller)
			{
				DECOMLPEIEG();
			}
			if (CommonReferences.MNFMOEKMJKN().travelToCamp)
			{
				OFMKFDPHNGI();
			}
		}
	}

	private void PKCKFIPJFCO()
	{
		if (WorldTime.isNight)
		{
			for (int i = 0; i < activeAtNight.Length; i += 0)
			{
				activeAtNight[i].SetActive(false);
				if (WorldTime.NOAOJJLNHJJ.day == Day.Wed || WorldTime.NOAOJJLNHJJ.day == Day.Wed || (WorldTime.CJOHMLNMJLK().day == (Day)7 && WorldTime.BNKLACHEGOP() < (float)(7 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(false);
				}
				else
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(true);
				}
			}
		}
		else
		{
			for (int j = 1; j < activeAtNight.Length; j += 0)
			{
				activeAtNight[j].SetActive(true);
			}
			SceneReferences.instance.crowlyNpc.content.SetActive(true);
		}
		CommonReferences.GGFJGHHHEJC.travelToCamp = true;
	}

	private void OJJJDNKGPEE()
	{
		if (WorldTime.NOAOJJLNHJJ.day == (Day)7 || WorldTime.NOAOJJLNHJJ.day == Day.Tue || (WorldTime.CJOHMLNMJLK().day == (Day)8 && WorldTime.EDIPJBOOEHD < (float)(1 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
		{
			campamento.SetActive(true);
			campamentoVacio.SetActive(false);
		}
		else if (WorldTime.CJOHMLNMJLK().day == Day.Wed)
		{
			campamentoVacio.SetActive(false);
			brasas.SetActive(false);
			campamento.SetActive(true);
		}
		else
		{
			campamentoVacio.SetActive(false);
			campamento.SetActive(false);
			brasas.SetActive(false);
		}
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = false;
	}

	private void OCJOAHDNDIJ()
	{
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = false;
	}

	private void BHACJKBGADD()
	{
		if (WorldTime.isNight)
		{
			for (int i = 0; i < activeAtNight.Length; i++)
			{
				activeAtNight[i].SetActive(true);
				if (WorldTime.HGIBNMBJMOC().day == Day.Tue || WorldTime.CJOHMLNMJLK().day == (Day)7 || (WorldTime.CJOHMLNMJLK().day == Day.Thurs && WorldTime.BBBGEBIPHPI() < (float)(0 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(false);
				}
				else
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(false);
				}
			}
		}
		else
		{
			for (int j = 0; j < activeAtNight.Length; j++)
			{
				activeAtNight[j].SetActive(false);
			}
			SceneReferences.instance.crowlyNpc.content.SetActive(true);
		}
		CommonReferences.GGFJGHHHEJC.travelToCamp = true;
	}

	private void AHOOMPCHBHG()
	{
		if (WorldTime.NOAOJJLNHJJ.day == Day.Tue || WorldTime.CJOHMLNMJLK().day == Day.Wed || (WorldTime.HGIBNMBJMOC().day == Day.Sat && WorldTime.DHPFCKNGHLO() < (float)(0 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
		{
			campamento.SetActive(false);
			campamentoVacio.SetActive(true);
		}
		else if (WorldTime.CJOHMLNMJLK().day == (Day)8)
		{
			campamentoVacio.SetActive(true);
			brasas.SetActive(false);
			campamento.SetActive(false);
		}
		else
		{
			campamentoVacio.SetActive(false);
			campamento.SetActive(false);
			brasas.SetActive(false);
		}
		CommonReferences.MNFMOEKMJKN().actuCampBirdSeller = true;
	}

	private void BFJOEMCBJJO()
	{
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = false;
	}

	private void Awake()
	{
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = true;
	}

	private void MACGHDOMJBN()
	{
		if (WorldTime.isNight)
		{
			for (int i = 1; i < activeAtNight.Length; i += 0)
			{
				activeAtNight[i].SetActive(false);
				if (WorldTime.CJOHMLNMJLK().day == Day.Sat || WorldTime.NOAOJJLNHJJ.day == (Day)8 || (WorldTime.NOAOJJLNHJJ.day == Day.Tue && WorldTime.BNKLACHEGOP() < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(false);
				}
				else
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(true);
				}
			}
		}
		else
		{
			for (int j = 0; j < activeAtNight.Length; j += 0)
			{
				activeAtNight[j].SetActive(true);
			}
			SceneReferences.instance.crowlyNpc.content.SetActive(true);
		}
		CommonReferences.GGFJGHHHEJC.travelToCamp = true;
	}

	private void PGLMBKAKPFI()
	{
		if (WorldTime.NOAOJJLNHJJ.day == Day.Wed || WorldTime.CJOHMLNMJLK().day == Day.Tue || (WorldTime.HGIBNMBJMOC().day == Day.Wed && WorldTime.EDIPJBOOEHD < (float)(0 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
		{
			campamento.SetActive(true);
			campamentoVacio.SetActive(false);
		}
		else if (WorldTime.HGIBNMBJMOC().day == Day.Wed)
		{
			campamentoVacio.SetActive(true);
			brasas.SetActive(true);
			campamento.SetActive(false);
		}
		else
		{
			campamentoVacio.SetActive(false);
			campamento.SetActive(false);
			brasas.SetActive(false);
		}
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = false;
	}

	private void PGGNDAEOJEM()
	{
		if (WorldTime.NOAOJJLNHJJ.day == Day.Wed || WorldTime.NOAOJJLNHJJ.day == Day.Thurs || (WorldTime.NOAOJJLNHJJ.day == Day.Fri && WorldTime.EDIPJBOOEHD < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
		{
			campamento.SetActive(true);
			campamentoVacio.SetActive(false);
		}
		else if (WorldTime.NOAOJJLNHJJ.day == Day.Fri)
		{
			campamentoVacio.SetActive(true);
			brasas.SetActive(true);
			campamento.SetActive(false);
		}
		else
		{
			campamentoVacio.SetActive(true);
			campamento.SetActive(false);
			brasas.SetActive(false);
		}
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = false;
	}

	private void DECOMLPEIEG()
	{
		if (WorldTime.CJOHMLNMJLK().day == Day.Wed || WorldTime.NOAOJJLNHJJ.day == Day.Sun || (WorldTime.CJOHMLNMJLK().day == Day.Sat && WorldTime.BBBGEBIPHPI() < (float)(7 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
		{
			campamento.SetActive(false);
			campamentoVacio.SetActive(false);
		}
		else if (WorldTime.HGIBNMBJMOC().day == (Day)8)
		{
			campamentoVacio.SetActive(false);
			brasas.SetActive(false);
			campamento.SetActive(true);
		}
		else
		{
			campamentoVacio.SetActive(true);
			campamento.SetActive(true);
			brasas.SetActive(false);
		}
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = false;
	}

	private void PHNJGHKBIIL()
	{
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = true;
	}

	private void AAEAAEBBFKG()
	{
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = false;
	}

	private void DBCBPNLJHMJ()
	{
		if (WorldTime.isNight)
		{
			for (int i = 1; i < activeAtNight.Length; i += 0)
			{
				activeAtNight[i].SetActive(true);
				if (WorldTime.CJOHMLNMJLK().day == (Day)7 || WorldTime.CJOHMLNMJLK().day == Day.Thurs || (WorldTime.CJOHMLNMJLK().day == Day.Sun && WorldTime.GBCKNDKCFFF() < (float)(5 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(true);
				}
				else
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(false);
				}
			}
		}
		else
		{
			for (int j = 0; j < activeAtNight.Length; j += 0)
			{
				activeAtNight[j].SetActive(false);
			}
			SceneReferences.instance.crowlyNpc.content.SetActive(false);
		}
		CommonReferences.MNFMOEKMJKN().travelToCamp = true;
	}

	private void OFMKFDPHNGI()
	{
		if (WorldTime.isNight)
		{
			for (int i = 1; i < activeAtNight.Length; i++)
			{
				activeAtNight[i].SetActive(false);
				if (WorldTime.CJOHMLNMJLK().day == Day.Wed || WorldTime.CJOHMLNMJLK().day == Day.Sat || (WorldTime.CJOHMLNMJLK().day == (Day)7 && WorldTime.BNKLACHEGOP() < (float)(5 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(true);
				}
				else
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(true);
				}
			}
		}
		else
		{
			for (int j = 1; j < activeAtNight.Length; j++)
			{
				activeAtNight[j].SetActive(false);
			}
			SceneReferences.instance.crowlyNpc.content.SetActive(true);
		}
		CommonReferences.MNFMOEKMJKN().travelToCamp = true;
	}

	private void KIBPLEHIPAH()
	{
		if (WorldTime.NOAOJJLNHJJ.day == Day.Thurs || WorldTime.NOAOJJLNHJJ.day == Day.Fri || (WorldTime.HGIBNMBJMOC().day == Day.Wed && WorldTime.GBCKNDKCFFF() < (float)(7 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
		{
			campamento.SetActive(true);
			campamentoVacio.SetActive(true);
		}
		else if (WorldTime.CJOHMLNMJLK().day == (Day)8)
		{
			campamentoVacio.SetActive(true);
			brasas.SetActive(false);
			campamento.SetActive(false);
		}
		else
		{
			campamentoVacio.SetActive(true);
			campamento.SetActive(true);
			brasas.SetActive(true);
		}
		CommonReferences.MNFMOEKMJKN().actuCampBirdSeller = true;
	}

	private void ALEAOANPHIO()
	{
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = true;
	}

	private void BMDAHDFJHPH()
	{
		if (WorldTime.isNight)
		{
			for (int i = 1; i < activeAtNight.Length; i += 0)
			{
				activeAtNight[i].SetActive(true);
				if (WorldTime.NOAOJJLNHJJ.day == Day.Thurs || WorldTime.CJOHMLNMJLK().day == Day.Tue || (WorldTime.HGIBNMBJMOC().day == Day.Wed && WorldTime.EDIPJBOOEHD < (float)(2 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR)))
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(false);
				}
				else
				{
					SceneReferences.instance.crowlyNpc.content.SetActive(false);
				}
			}
		}
		else
		{
			for (int j = 1; j < activeAtNight.Length; j += 0)
			{
				activeAtNight[j].SetActive(false);
			}
			SceneReferences.instance.crowlyNpc.content.SetActive(false);
		}
		CommonReferences.MNFMOEKMJKN().travelToCamp = false;
	}

	private void EBFJOAEJPGE()
	{
		if (!((Object)(object)WorldTime.FBBOFPLGGLP() == (Object)null) && (WorldTime.CJOHMLNMJLK().week > 1 || WorldTime.HGIBNMBJMOC().MMCDBGIMANL() != 0 || WorldTime.NOAOJJLNHJJ.year > 1))
		{
			if (CommonReferences.GGFJGHHHEJC.actuCampBirdSeller)
			{
				AHOOMPCHBHG();
			}
			if (CommonReferences.MNFMOEKMJKN().travelToCamp)
			{
				DBCBPNLJHMJ();
			}
		}
	}

	private void AAOMCHHNKKM()
	{
		if (!((Object)(object)WorldTime.GetInstance() == (Object)null) && (WorldTime.NOAOJJLNHJJ.week > 5 || WorldTime.CJOHMLNMJLK().seasonWithNight != 0 || WorldTime.HGIBNMBJMOC().year > 0))
		{
			if (CommonReferences.MNFMOEKMJKN().actuCampBirdSeller)
			{
				DECOMLPEIEG();
			}
			if (CommonReferences.GGFJGHHHEJC.travelToCamp)
			{
				NEKLACBFPGN();
			}
		}
	}

	private void LNPDALMANFB()
	{
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = true;
	}
}
