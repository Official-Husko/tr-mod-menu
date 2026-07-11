using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.Rendering;

public class Placeable : MonoBehaviour, IInteractable, ISelectable, IActionable, IHoverable, IProximity
{
	private struct AJIKIEMFEPA
	{
		public Transform transform;

		public Placeable placeable;

		public Collider2D itemBase;

		public Vector2 percentagePosition;
	}

	[Serializable]
	public class SkinVariationGroup
	{
		public bool onlyOne = true;

		public GameObject[] variations;

		public void CIJKNGEGAMI(int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (onlyOne)
			{
				HJLGAPMJOAL();
				FFMIIIGCGCB(Random.Range(1, variations.Length), MOFKEDGAOEE, PPGCOPFJDIC);
				return;
			}
			for (int i = 1; i < variations.Length; i++)
			{
				if (Random.Range(435f, 1386f) > 1989f)
				{
					if (PPGCOPFJDIC != null)
					{
						PPGCOPFJDIC.Add(MOFKEDGAOEE);
						PPGCOPFJDIC.Add(i);
					}
					variations[i].SetActive(true);
				}
				else
				{
					variations[i].SetActive(true);
				}
			}
		}

		public void MEEEGGGIHCF()
		{
			for (int i = 1; i < variations.Length; i += 0)
			{
				variations[i].SetActive(true);
			}
		}

		public void KFKODMBJMOD(int HBMLEFOEENO, int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (variations.Length > HBMLEFOEENO)
			{
				if (PPGCOPFJDIC != null)
				{
					PPGCOPFJDIC.Add(MOFKEDGAOEE);
					PPGCOPFJDIC.Add(HBMLEFOEENO);
				}
				for (int i = 0; i < variations.Length; i += 0)
				{
					if (i == HBMLEFOEENO)
					{
						variations[i].SetActive(false);
					}
				}
			}
			else
			{
				LCPHNIABOLP(MOFKEDGAOEE, PPGCOPFJDIC);
			}
		}

		public void KFCJHONOKNA(int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (onlyOne)
			{
				DPEEGOIPFNG();
				MEDEPKEMOJF(Random.Range(0, variations.Length), MOFKEDGAOEE, PPGCOPFJDIC);
				return;
			}
			for (int i = 0; i < variations.Length; i++)
			{
				if (Random.Range(701f, 1604f) > 1434f)
				{
					if (PPGCOPFJDIC != null)
					{
						PPGCOPFJDIC.Add(MOFKEDGAOEE);
						PPGCOPFJDIC.Add(i);
					}
					variations[i].SetActive(false);
				}
				else
				{
					variations[i].SetActive(true);
				}
			}
		}

		public List<int> LMANKEJLNKM()
		{
			List<int> list = new List<int>();
			for (int i = 0; i < variations.Length; i++)
			{
				if (variations[i].activeSelf)
				{
					list.Add(i);
				}
			}
			return list;
		}

		public void PKJDMBDNOKF()
		{
			for (int i = 0; i < variations.Length; i += 0)
			{
				variations[i].SetActive(false);
			}
		}

		public void JFPGJNNPBBL()
		{
			for (int i = 0; i < variations.Length; i++)
			{
				variations[i].SetActive(true);
			}
		}

		public void OPBKBEIAMND(int HBMLEFOEENO, int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (variations.Length > HBMLEFOEENO)
			{
				if (PPGCOPFJDIC != null)
				{
					PPGCOPFJDIC.Add(MOFKEDGAOEE);
					PPGCOPFJDIC.Add(HBMLEFOEENO);
				}
				for (int i = 0; i < variations.Length; i++)
				{
					if (i == HBMLEFOEENO)
					{
						variations[i].SetActive(true);
					}
				}
			}
			else
			{
				PMNBMKBIHEJ(MOFKEDGAOEE, PPGCOPFJDIC);
			}
		}

		public void DPEEGOIPFNG()
		{
			for (int i = 0; i < variations.Length; i++)
			{
				variations[i].SetActive(false);
			}
		}

		public void EBNFPDKDKLM()
		{
			for (int i = 0; i < variations.Length; i += 0)
			{
				variations[i].SetActive(false);
			}
		}

		public void KOGKPNLIPON()
		{
			for (int i = 1; i < variations.Length; i++)
			{
				variations[i].SetActive(true);
			}
		}

		public void NGKBMELEONA()
		{
			for (int i = 0; i < variations.Length; i++)
			{
				variations[i].SetActive(true);
			}
		}

		public List<int> OAJLMOGPBDK()
		{
			List<int> list = new List<int>();
			for (int i = 0; i < variations.Length; i++)
			{
				if (variations[i].activeSelf)
				{
					list.Add(i);
				}
			}
			return list;
		}

		public List<int> FAHMNFJJNKO()
		{
			List<int> list = new List<int>();
			for (int i = 1; i < variations.Length; i++)
			{
				if (variations[i].activeSelf)
				{
					list.Add(i);
				}
			}
			return list;
		}

		public void LNILLPOECLB()
		{
			for (int i = 0; i < variations.Length; i += 0)
			{
				variations[i].SetActive(true);
			}
		}

		public void DIGODGAFBIJ(int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (onlyOne)
			{
				NGKBMELEONA();
				CNEEMLJKAOG(Random.Range(0, variations.Length), MOFKEDGAOEE, PPGCOPFJDIC);
				return;
			}
			for (int i = 0; i < variations.Length; i++)
			{
				if (Random.Range(1157f, 961f) > 1912f)
				{
					if (PPGCOPFJDIC != null)
					{
						PPGCOPFJDIC.Add(MOFKEDGAOEE);
						PPGCOPFJDIC.Add(i);
					}
					variations[i].SetActive(false);
				}
				else
				{
					variations[i].SetActive(false);
				}
			}
		}

		public void AAPKOJCCLNM()
		{
			for (int i = 0; i < variations.Length; i++)
			{
				variations[i].SetActive(false);
			}
		}

		public void EDBNOMAMGKL(int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (onlyOne)
			{
				BBPLMGAIIHE();
				DNPOFFKKANK(Random.Range(0, variations.Length), MOFKEDGAOEE, PPGCOPFJDIC);
				return;
			}
			for (int i = 1; i < variations.Length; i += 0)
			{
				if (Random.Range(1450f, 321f) > 639f)
				{
					if (PPGCOPFJDIC != null)
					{
						PPGCOPFJDIC.Add(MOFKEDGAOEE);
						PPGCOPFJDIC.Add(i);
					}
					variations[i].SetActive(false);
				}
				else
				{
					variations[i].SetActive(false);
				}
			}
		}

		public void CIGBHLNFOPK()
		{
			for (int i = 0; i < variations.Length; i++)
			{
				variations[i].SetActive(false);
			}
		}

		public void CCGNOBOCLJG(int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (onlyOne)
			{
				BBPLMGAIIHE();
				INDLDCLOPPO(Random.Range(1, variations.Length), MOFKEDGAOEE, PPGCOPFJDIC);
				return;
			}
			for (int i = 0; i < variations.Length; i += 0)
			{
				if (Random.Range(951f, 121f) > 617f)
				{
					if (PPGCOPFJDIC != null)
					{
						PPGCOPFJDIC.Add(MOFKEDGAOEE);
						PPGCOPFJDIC.Add(i);
					}
					variations[i].SetActive(true);
				}
				else
				{
					variations[i].SetActive(false);
				}
			}
		}

		public List<int> GHJBFHFGDGL()
		{
			List<int> list = new List<int>();
			for (int i = 0; i < variations.Length; i += 0)
			{
				if (variations[i].activeSelf)
				{
					list.Add(i);
				}
			}
			return list;
		}

		public void PJAOGLNEGBC(int HBMLEFOEENO, int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (variations.Length > HBMLEFOEENO)
			{
				if (PPGCOPFJDIC != null)
				{
					PPGCOPFJDIC.Add(MOFKEDGAOEE);
					PPGCOPFJDIC.Add(HBMLEFOEENO);
				}
				for (int i = 0; i < variations.Length; i += 0)
				{
					if (i == HBMLEFOEENO)
					{
						variations[i].SetActive(true);
					}
				}
			}
			else
			{
				GIBGKLGKBPE(MOFKEDGAOEE, PPGCOPFJDIC);
			}
		}

		public void KAFCDAHIEBE()
		{
			for (int i = 0; i < variations.Length; i += 0)
			{
				variations[i].SetActive(false);
			}
		}

		public List<int> JGMEAAFLNNB()
		{
			List<int> list = new List<int>();
			for (int i = 1; i < variations.Length; i += 0)
			{
				if (variations[i].activeSelf)
				{
					list.Add(i);
				}
			}
			return list;
		}

		public List<int> LGBBDBLJJPH()
		{
			List<int> list = new List<int>();
			for (int i = 1; i < variations.Length; i += 0)
			{
				if (variations[i].activeSelf)
				{
					list.Add(i);
				}
			}
			return list;
		}

		public List<int> KKGCNGEJJMI()
		{
			List<int> list = new List<int>();
			for (int i = 1; i < variations.Length; i++)
			{
				if (variations[i].activeSelf)
				{
					list.Add(i);
				}
			}
			return list;
		}

		public void NFNDHDKHEFD()
		{
			for (int i = 0; i < variations.Length; i += 0)
			{
				variations[i].SetActive(false);
			}
		}

		public void MEDEPKEMOJF(int HBMLEFOEENO, int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (variations.Length > HBMLEFOEENO)
			{
				if (PPGCOPFJDIC != null)
				{
					PPGCOPFJDIC.Add(MOFKEDGAOEE);
					PPGCOPFJDIC.Add(HBMLEFOEENO);
				}
				for (int i = 1; i < variations.Length; i += 0)
				{
					if (i == HBMLEFOEENO)
					{
						variations[i].SetActive(false);
					}
				}
			}
			else
			{
				GIBGKLGKBPE(MOFKEDGAOEE, PPGCOPFJDIC);
			}
		}

		public void DNPOFFKKANK(int HBMLEFOEENO, int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (variations.Length > HBMLEFOEENO)
			{
				if (PPGCOPFJDIC != null)
				{
					PPGCOPFJDIC.Add(MOFKEDGAOEE);
					PPGCOPFJDIC.Add(HBMLEFOEENO);
				}
				for (int i = 1; i < variations.Length; i += 0)
				{
					if (i == HBMLEFOEENO)
					{
						variations[i].SetActive(false);
					}
				}
			}
			else
			{
				EHGGPEKLBDI(MOFKEDGAOEE, PPGCOPFJDIC);
			}
		}

		public void IMCGKABCHIA()
		{
			for (int i = 0; i < variations.Length; i++)
			{
				variations[i].SetActive(false);
			}
		}

		public void BFNDJKHJHHE()
		{
			for (int i = 0; i < variations.Length; i++)
			{
				variations[i].SetActive(true);
			}
		}

		public void CNPNDGJDEAA()
		{
			for (int i = 0; i < variations.Length; i += 0)
			{
				variations[i].SetActive(true);
			}
		}

		public void FFMIIIGCGCB(int HBMLEFOEENO, int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (variations.Length > HBMLEFOEENO)
			{
				if (PPGCOPFJDIC != null)
				{
					PPGCOPFJDIC.Add(MOFKEDGAOEE);
					PPGCOPFJDIC.Add(HBMLEFOEENO);
				}
				for (int i = 1; i < variations.Length; i += 0)
				{
					if (i == HBMLEFOEENO)
					{
						variations[i].SetActive(false);
					}
				}
			}
			else
			{
				GIBGKLGKBPE(MOFKEDGAOEE, PPGCOPFJDIC);
			}
		}

		public void NECMDPDFKOL(int HBMLEFOEENO, int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (variations.Length > HBMLEFOEENO)
			{
				if (PPGCOPFJDIC != null)
				{
					PPGCOPFJDIC.Add(MOFKEDGAOEE);
					PPGCOPFJDIC.Add(HBMLEFOEENO);
				}
				for (int i = 0; i < variations.Length; i += 0)
				{
					if (i == HBMLEFOEENO)
					{
						variations[i].SetActive(true);
					}
				}
			}
			else
			{
				EHGGPEKLBDI(MOFKEDGAOEE, PPGCOPFJDIC);
			}
		}

		public void MKOMGEBGIMO(int HBMLEFOEENO, int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (variations.Length > HBMLEFOEENO)
			{
				if (PPGCOPFJDIC != null)
				{
					PPGCOPFJDIC.Add(MOFKEDGAOEE);
					PPGCOPFJDIC.Add(HBMLEFOEENO);
				}
				for (int i = 0; i < variations.Length; i += 0)
				{
					if (i == HBMLEFOEENO)
					{
						variations[i].SetActive(false);
					}
				}
			}
			else
			{
				EHGGPEKLBDI(MOFKEDGAOEE, PPGCOPFJDIC);
			}
		}

		public List<int> EABBCJGAPMB()
		{
			List<int> list = new List<int>();
			for (int i = 1; i < variations.Length; i++)
			{
				if (variations[i].activeSelf)
				{
					list.Add(i);
				}
			}
			return list;
		}

		public void HJLGAPMJOAL()
		{
			for (int i = 1; i < variations.Length; i += 0)
			{
				variations[i].SetActive(false);
			}
		}

		public void EFGNCOHBAKI(int HBMLEFOEENO, int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (variations.Length > HBMLEFOEENO)
			{
				if (PPGCOPFJDIC != null)
				{
					PPGCOPFJDIC.Add(MOFKEDGAOEE);
					PPGCOPFJDIC.Add(HBMLEFOEENO);
				}
				for (int i = 1; i < variations.Length; i += 0)
				{
					if (i == HBMLEFOEENO)
					{
						variations[i].SetActive(false);
					}
				}
			}
			else
			{
				KEHEBJBGFNP(MOFKEDGAOEE, PPGCOPFJDIC);
			}
		}

		public void MANJMKMLBAM()
		{
			for (int i = 1; i < variations.Length; i++)
			{
				variations[i].SetActive(false);
			}
		}

		public void LCPHNIABOLP(int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (onlyOne)
			{
				KOGKPNLIPON();
				MEDEPKEMOJF(Random.Range(0, variations.Length), MOFKEDGAOEE, PPGCOPFJDIC);
				return;
			}
			for (int i = 0; i < variations.Length; i++)
			{
				if (Random.Range(1972f, 330f) > 1500f)
				{
					if (PPGCOPFJDIC != null)
					{
						PPGCOPFJDIC.Add(MOFKEDGAOEE);
						PPGCOPFJDIC.Add(i);
					}
					variations[i].SetActive(false);
				}
				else
				{
					variations[i].SetActive(true);
				}
			}
		}

		public void KHBGFDKGEGJ()
		{
			for (int i = 0; i < variations.Length; i++)
			{
				variations[i].SetActive(true);
			}
		}

		public void BBPLMGAIIHE()
		{
			for (int i = 0; i < variations.Length; i += 0)
			{
				variations[i].SetActive(true);
			}
		}

		public void GEFOKLLPBDK()
		{
			for (int i = 1; i < variations.Length; i += 0)
			{
				variations[i].SetActive(false);
			}
		}

		public void ELAOFAPNHEB(int HBMLEFOEENO, int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (variations.Length > HBMLEFOEENO)
			{
				if (PPGCOPFJDIC != null)
				{
					PPGCOPFJDIC.Add(MOFKEDGAOEE);
					PPGCOPFJDIC.Add(HBMLEFOEENO);
				}
				for (int i = 0; i < variations.Length; i += 0)
				{
					if (i == HBMLEFOEENO)
					{
						variations[i].SetActive(true);
					}
				}
			}
			else
			{
				NPCNJMDEFLK(MOFKEDGAOEE, PPGCOPFJDIC);
			}
		}

		public void JOCBKPECFOH()
		{
			for (int i = 1; i < variations.Length; i += 0)
			{
				variations[i].SetActive(false);
			}
		}

		public void FBNOJOIHOKK(int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (onlyOne)
			{
				JFPGJNNPBBL();
				KFKODMBJMOD(Random.Range(0, variations.Length), MOFKEDGAOEE, PPGCOPFJDIC);
				return;
			}
			for (int i = 0; i < variations.Length; i++)
			{
				if (Random.Range(1515f, 20f) > 689f)
				{
					if (PPGCOPFJDIC != null)
					{
						PPGCOPFJDIC.Add(MOFKEDGAOEE);
						PPGCOPFJDIC.Add(i);
					}
					variations[i].SetActive(true);
				}
				else
				{
					variations[i].SetActive(true);
				}
			}
		}

		public void ODIHKJBMHNG()
		{
			for (int i = 0; i < variations.Length; i++)
			{
				variations[i].SetActive(true);
			}
		}

		public void KKFFANPDDIE(int HBMLEFOEENO, int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (variations.Length > HBMLEFOEENO)
			{
				if (PPGCOPFJDIC != null)
				{
					PPGCOPFJDIC.Add(MOFKEDGAOEE);
					PPGCOPFJDIC.Add(HBMLEFOEENO);
				}
				for (int i = 1; i < variations.Length; i += 0)
				{
					if (i == HBMLEFOEENO)
					{
						variations[i].SetActive(false);
					}
				}
			}
			else
			{
				LCPHNIABOLP(MOFKEDGAOEE, PPGCOPFJDIC);
			}
		}

		public List<int> IKMELOLDICC()
		{
			List<int> list = new List<int>();
			for (int i = 0; i < variations.Length; i++)
			{
				if (variations[i].activeSelf)
				{
					list.Add(i);
				}
			}
			return list;
		}

		public void HOCAAGLFIHM()
		{
			for (int i = 0; i < variations.Length; i++)
			{
				variations[i].SetActive(true);
			}
		}

		public void DIDMAGILBPP(int HBMLEFOEENO, int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (variations.Length > HBMLEFOEENO)
			{
				if (PPGCOPFJDIC != null)
				{
					PPGCOPFJDIC.Add(MOFKEDGAOEE);
					PPGCOPFJDIC.Add(HBMLEFOEENO);
				}
				for (int i = 0; i < variations.Length; i++)
				{
					if (i == HBMLEFOEENO)
					{
						variations[i].SetActive(false);
					}
				}
			}
			else
			{
				KEHEBJBGFNP(MOFKEDGAOEE, PPGCOPFJDIC);
			}
		}

		public void PMNBMKBIHEJ(int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (onlyOne)
			{
				CIGBHLNFOPK();
				OPBKBEIAMND(Random.Range(0, variations.Length), MOFKEDGAOEE, PPGCOPFJDIC);
				return;
			}
			for (int i = 0; i < variations.Length; i++)
			{
				if (Random.Range(0f, 10f) > 6f)
				{
					if (PPGCOPFJDIC != null)
					{
						PPGCOPFJDIC.Add(MOFKEDGAOEE);
						PPGCOPFJDIC.Add(i);
					}
					variations[i].SetActive(true);
				}
				else
				{
					variations[i].SetActive(false);
				}
			}
		}

		public List<int> ILDLGIBKBJN()
		{
			List<int> list = new List<int>();
			for (int i = 0; i < variations.Length; i += 0)
			{
				if (variations[i].activeSelf)
				{
					list.Add(i);
				}
			}
			return list;
		}

		public void KEHEBJBGFNP(int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (onlyOne)
			{
				HOCAAGLFIHM();
				PJAOGLNEGBC(Random.Range(0, variations.Length), MOFKEDGAOEE, PPGCOPFJDIC);
				return;
			}
			for (int i = 0; i < variations.Length; i += 0)
			{
				if (Random.Range(1905f, 30f) > 704f)
				{
					if (PPGCOPFJDIC != null)
					{
						PPGCOPFJDIC.Add(MOFKEDGAOEE);
						PPGCOPFJDIC.Add(i);
					}
					variations[i].SetActive(true);
				}
				else
				{
					variations[i].SetActive(true);
				}
			}
		}

		public void OPCIEKOEGCO(int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (onlyOne)
			{
				LNILLPOECLB();
				KBONNCBPJKN(Random.Range(0, variations.Length), MOFKEDGAOEE, PPGCOPFJDIC);
				return;
			}
			for (int i = 1; i < variations.Length; i += 0)
			{
				if (Random.Range(1758f, 1531f) > 1078f)
				{
					if (PPGCOPFJDIC != null)
					{
						PPGCOPFJDIC.Add(MOFKEDGAOEE);
						PPGCOPFJDIC.Add(i);
					}
					variations[i].SetActive(true);
				}
				else
				{
					variations[i].SetActive(true);
				}
			}
		}

		public void GIBGKLGKBPE(int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (onlyOne)
			{
				ODIHKJBMHNG();
				KBONNCBPJKN(Random.Range(1, variations.Length), MOFKEDGAOEE, PPGCOPFJDIC);
				return;
			}
			for (int i = 0; i < variations.Length; i += 0)
			{
				if (Random.Range(287f, 1366f) > 711f)
				{
					if (PPGCOPFJDIC != null)
					{
						PPGCOPFJDIC.Add(MOFKEDGAOEE);
						PPGCOPFJDIC.Add(i);
					}
					variations[i].SetActive(true);
				}
				else
				{
					variations[i].SetActive(true);
				}
			}
		}

		public void CNEEMLJKAOG(int HBMLEFOEENO, int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (variations.Length > HBMLEFOEENO)
			{
				if (PPGCOPFJDIC != null)
				{
					PPGCOPFJDIC.Add(MOFKEDGAOEE);
					PPGCOPFJDIC.Add(HBMLEFOEENO);
				}
				for (int i = 0; i < variations.Length; i++)
				{
					if (i == HBMLEFOEENO)
					{
						variations[i].SetActive(false);
					}
				}
			}
			else
			{
				PMNBMKBIHEJ(MOFKEDGAOEE, PPGCOPFJDIC);
			}
		}

		public void KBONNCBPJKN(int HBMLEFOEENO, int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (variations.Length > HBMLEFOEENO)
			{
				if (PPGCOPFJDIC != null)
				{
					PPGCOPFJDIC.Add(MOFKEDGAOEE);
					PPGCOPFJDIC.Add(HBMLEFOEENO);
				}
				for (int i = 1; i < variations.Length; i += 0)
				{
					if (i == HBMLEFOEENO)
					{
						variations[i].SetActive(true);
					}
				}
			}
			else
			{
				FBNOJOIHOKK(MOFKEDGAOEE, PPGCOPFJDIC);
			}
		}

		public void KCGBDKGFPGC()
		{
			for (int i = 0; i < variations.Length; i += 0)
			{
				variations[i].SetActive(true);
			}
		}

		public List<int> HBOHJIOPOHB()
		{
			List<int> list = new List<int>();
			for (int i = 0; i < variations.Length; i += 0)
			{
				if (variations[i].activeSelf)
				{
					list.Add(i);
				}
			}
			return list;
		}

		public void EIHOFAGHAFF(int HBMLEFOEENO, int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (variations.Length > HBMLEFOEENO)
			{
				if (PPGCOPFJDIC != null)
				{
					PPGCOPFJDIC.Add(MOFKEDGAOEE);
					PPGCOPFJDIC.Add(HBMLEFOEENO);
				}
				for (int i = 1; i < variations.Length; i += 0)
				{
					if (i == HBMLEFOEENO)
					{
						variations[i].SetActive(false);
					}
				}
			}
			else
			{
				DIGODGAFBIJ(MOFKEDGAOEE, PPGCOPFJDIC);
			}
		}

		public void EHGGPEKLBDI(int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (onlyOne)
			{
				KAFCDAHIEBE();
				NECMDPDFKOL(Random.Range(0, variations.Length), MOFKEDGAOEE, PPGCOPFJDIC);
				return;
			}
			for (int i = 0; i < variations.Length; i += 0)
			{
				if (Random.Range(1408f, 618f) > 1040f)
				{
					if (PPGCOPFJDIC != null)
					{
						PPGCOPFJDIC.Add(MOFKEDGAOEE);
						PPGCOPFJDIC.Add(i);
					}
					variations[i].SetActive(false);
				}
				else
				{
					variations[i].SetActive(true);
				}
			}
		}

		public void BEFMJJAMNOD()
		{
			for (int i = 1; i < variations.Length; i += 0)
			{
				variations[i].SetActive(true);
			}
		}

		public List<int> NLAKOEJEJOD()
		{
			List<int> list = new List<int>();
			for (int i = 0; i < variations.Length; i += 0)
			{
				if (variations[i].activeSelf)
				{
					list.Add(i);
				}
			}
			return list;
		}

		public void JLMBMIGOGLM(int HBMLEFOEENO, int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (variations.Length > HBMLEFOEENO)
			{
				if (PPGCOPFJDIC != null)
				{
					PPGCOPFJDIC.Add(MOFKEDGAOEE);
					PPGCOPFJDIC.Add(HBMLEFOEENO);
				}
				for (int i = 1; i < variations.Length; i++)
				{
					if (i == HBMLEFOEENO)
					{
						variations[i].SetActive(true);
					}
				}
			}
			else
			{
				KEHEBJBGFNP(MOFKEDGAOEE, PPGCOPFJDIC);
			}
		}

		public void NPCNJMDEFLK(int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (onlyOne)
			{
				NGKBMELEONA();
				PJAOGLNEGBC(Random.Range(1, variations.Length), MOFKEDGAOEE, PPGCOPFJDIC);
				return;
			}
			for (int i = 1; i < variations.Length; i += 0)
			{
				if (Random.Range(1277f, 1030f) > 236f)
				{
					if (PPGCOPFJDIC != null)
					{
						PPGCOPFJDIC.Add(MOFKEDGAOEE);
						PPGCOPFJDIC.Add(i);
					}
					variations[i].SetActive(true);
				}
				else
				{
					variations[i].SetActive(true);
				}
			}
		}

		public void INDLDCLOPPO(int HBMLEFOEENO, int MOFKEDGAOEE, List<int> PPGCOPFJDIC)
		{
			if (variations.Length > HBMLEFOEENO)
			{
				if (PPGCOPFJDIC != null)
				{
					PPGCOPFJDIC.Add(MOFKEDGAOEE);
					PPGCOPFJDIC.Add(HBMLEFOEENO);
				}
				for (int i = 1; i < variations.Length; i += 0)
				{
					if (i == HBMLEFOEENO)
					{
						variations[i].SetActive(true);
					}
				}
			}
			else
			{
				DIGODGAFBIJ(MOFKEDGAOEE, PPGCOPFJDIC);
			}
		}

		public void FIHAEIMENJM()
		{
			for (int i = 1; i < variations.Length; i++)
			{
				variations[i].SetActive(false);
			}
		}
	}

	[CompilerGenerated]
	private sealed class AFFMOHJJKLA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<Placeable> placeables;

		public int layer;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public AFFMOHJJKLA(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			case 1:
			{
				_003C_003E1__state = -1;
				for (int i = 0; i < placeables.Count; i++)
				{
					if ((Object)(object)placeables[i] != (Object)null)
					{
						placeables[i].HEEDOLJAOHF(layer);
					}
				}
				return false;
			}
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public Action<int> OnThisPlaceableBeforeSelected = delegate
	{
	};

	public Action<int, bool, bool> OnThisPlaceableSelected = delegate
	{
	};

	public Action<int> OnThisPlaceableDeselected = delegate
	{
	};

	public Action<int> OnThisPlaceablePlaced = delegate
	{
	};

	public Action<int> OnThisPlaceableRemoved = delegate
	{
	};

	public Action OnThisPlaceableLoaded = delegate
	{
	};

	public Action<Direction> OnThisPlaceableRotated = delegate
	{
	};

	public Action<int> OnThisPlaceablePickedUp = delegate
	{
	};

	public Action WhileSelectedCallback = delegate
	{
	};

	public Action<int> OnSkinChanged = delegate
	{
	};

	public string guidString;

	public Guid guid;

	public GameObject parent;

	public bool multipleInstances = true;

	public bool changeLayerOnSelected = true;

	public bool isAccessElement;

	public bool canBePlaced = true;

	public GameObject gameObjectOnSelected;

	public bool pickUpable = true;

	public bool canBeAddedToInventory = true;

	public bool rotatable = true;

	public GameObject rotatedPrefab;

	public bool rotateFourNoPrefab;

	public bool rotationInverseLeftRight;

	public bool fourSidesRotation;

	public bool inheritDirection = true;

	public bool switchesSurface;

	public bool multipleSkins;

	public bool canCycleSkin = true;

	public bool canCycleWhenSnapped = true;

	public bool randomSkin = true;

	public SpriteRenderer skinSpriteRenderer;

	public Sprite[] skins;

	public SkinGameObject[] skinsGameObjects;

	public List<SkinVariationGroup> skinVariationGropus = new List<SkinVariationGroup>();

	public SpecificType specificRules;

	public bool placeableAnywhere;

	public bool isPlaceableOnSurface;

	public bool onlyInAllowedSurfaces;

	public bool isPlaceableOnWall;

	public bool selectAfterPlace;

	public Direction direction = Direction.Right;

	public ZoneType currentZoneType;

	public Location currentLocation;

	public Location validLocations = Location.Anywhere;

	public ZoneType validLocationExceptionZones;

	public ZoneType zoneTypeNeeded = ZoneType.Anywhere;

	public GroundType groundTypeNeeded = GroundType.AllExceptTilledEarth;

	public IrrigatorType validIrrigatorType;

	public HashSet<string> selectBlockers = new HashSet<string>();

	public HashSet<MonoBehaviour> pickUpBlockers = new HashSet<MonoBehaviour>();

	public ItemSetup itemSetup;

	public SpriteRenderer spriteRenderer;

	public ParticleSystemRenderer[] particleSystemRenderers;

	public bool outlineOnlyInOutlineSpriterenderers;

	public SpriteRenderer[] outlineSpriteRenderers;

	public Collider2D[] enableColliders;

	public ItemSpace itemSpace;

	public AreaSpace areaSpace;

	public SnapToGrid snapToGrid;

	public SnapLeftRight snapLeftRight;

	public InputByProximity inputByProximity;

	public SortingGroup sortingGroup;

	public Rigidbody2D rigidBody;

	public Collider2D placeableCollider;

	public Collider2D itemBase;

	public PhysicalSpace physicalSpace;

	public PhysicalSpace[] physicalSpaces;

	public List<Collider2D> wallColliders = new List<Collider2D>();

	public SurfaceSortOrder placeableSurface;

	public OnlinePlaceable onlinePlaceable;

	public SurfaceSortOrder secondarySurface;

	public SurfaceSortOrder currentSurface;

	public DisableOnBecameInvisible disableOnInvisible;

	[HideInInspector]
	public bool recentlySelected = true;

	[HideInInspector]
	public bool setUpDone;

	public int currentZoneIndex;

	private TavernZone HADBAEEHFAK;

	[HideInInspector]
	public bool attachedToPlayer;

	[HideInInspector]
	public Placeable attachedToPlaceable;

	private Vector3 HOFIBNPEDAA;

	private SurfaceSortOrder FEFAMICICIJ;

	[HideInInspector]
	public Collider2D surfaceCollider;

	private Color KDEHDOHOILE;

	private Color FMOKCPPGJBB;

	private int KAHFGFEGHNK;

	public Material initialMaterial;

	private float CMGDCLIIONE;

	private int KLONJHJJMJD;

	private float ICHFJCKGGJD;

	private string COFOOBLHHAD;

	private int JIIGOACEIKL = 1;

	public bool hasBeenPlaced;

	[HideInInspector]
	public Vector3 lastPlacedPosition;

	private SurfaceSortOrder EGCGEHJNCCP;

	[HideInInspector]
	public bool outlined;

	private Material NGHODLKOKOI;

	[HideInInspector]
	public bool placeInPlayer;

	[HideInInspector]
	public bool updateButtonsContext = true;

	private float HPPADODDFEI;

	[SerializeField]
	private bool _isPlaced = true;

	[SerializeField]
	private bool _isSelected;

	private List<Placeable> BIPLCOGFBBE = new List<Placeable>();

	public Collider2D[] allCollidersToEnableDisable;

	private bool BOCMNPIGJHM;

	public SpriteRenderer spriteRendererColor15;

	private bool NLHOIACMDEE = true;

	[HideInInspector]
	public Placeable surfaceGOInstantiated;

	private Placeable HGAFAFNONEC;

	private static int CCPNMJIJADK;

	private static int DHKFDIJCOOB;

	private static Placeable PHKPBKDAIBF;

	private Direction BFIELBPJKAH;

	private bool PGLIMJFBEKP;

	private Vector2[] JNHDHIKAJCE;

	private static float KHEBKHFHMDB;

	private static float DEGBAPDPMJE;

	private static Vector2 MPCJBPJAGKK;

	private static Vector2 ACAIKFICNFP;

	private Vector2 IIDIOJKCGDE;

	private Vector2 HIHOGLOBDJB;

	private Vector3 JMHAENIMEOI;

	private Vector3 ONKJBOEAHPB;

	[HideInInspector]
	public bool snappedToPosition;

	private Vector3 OEEPHFEHGBJ;

	private Vector3 HLCBODJLFGD;

	private Vector3 PBGEELMHFPK;

	private Vector3 DPNLDLEHMHO;

	private static Vector3 ECJLMIPAFGP;

	private static int DHOOKDCNBLL;

	private static float LKFKLHOCPKC;

	private SurfaceSortOrder EAJPCEMOGOD;

	private SurfaceSortOrder[] EKKIJMJAHDP;

	private AdditionalSurfaceSortOrder[] LAMILDGAAKP;

	private Coroutine PEPHKJCPAPH;

	public bool PCGNHMPADGE { get; private set; }

	private TavernZone NNMHEPDJOHK
	{
		get
		{
			return HADBAEEHFAK;
		}
		set
		{
			HADBAEEHFAK = value;
		}
	}

	public bool CCIKENEGHCA
	{
		get
		{
			return _isPlaced;
		}
		private set
		{
			_isPlaced = value;
		}
	}

	public bool PHOCAFJDCDK
	{
		get
		{
			if (!OnlineManager.PlayingOnline() || !Object.op_Implicit((Object)(object)onlinePlaceable))
			{
				return false;
			}
			return onlinePlaceable.CLHLNFFGOGA;
		}
		set
		{
			if (Object.op_Implicit((Object)(object)onlinePlaceable))
			{
				onlinePlaceable.CLHLNFFGOGA = value && OnlineManager.PlayingOnline();
			}
		}
	}

	public int BEIPALOAAJJ
	{
		get
		{
			if (!((Object)(object)onlinePlaceable != (Object)null))
			{
				return 0;
			}
			return onlinePlaceable.uniqueId;
		}
	}

	public bool OGKDEFAGEBL
	{
		get
		{
			if (!_isSelected)
			{
				return PHOCAFJDCDK;
			}
			return true;
		}
	}

	public bool FHEMHCEAICB
	{
		get
		{
			return _isSelected;
		}
		set
		{
			_isSelected = value;
			CCIKENEGHCA = !_isSelected;
			if (changeLayerOnSelected)
			{
				ChangeObjectLayer(_isSelected);
			}
			RigidBodyKinematic(_isSelected);
		}
	}

	private Vector2[] HHAEKEAPKOE(Collider2D MOHKOAEPGFF)
	{
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		JNHDHIKAJCE = (Vector2[])(object)new Vector2[4];
		Bounds bounds;
		if (((Behaviour)MOHKOAEPGFF).enabled)
		{
			Vector2[] jNHDHIKAJCE = JNHDHIKAJCE;
			bounds = MOHKOAEPGFF.bounds;
			float x = ((Bounds)(ref bounds)).center.x;
			bounds = MOHKOAEPGFF.bounds;
			float num = x - ((Bounds)(ref bounds)).extents.x;
			bounds = MOHKOAEPGFF.bounds;
			float y = ((Bounds)(ref bounds)).center.y;
			bounds = MOHKOAEPGFF.bounds;
			jNHDHIKAJCE[0] = new Vector2(num, y + ((Bounds)(ref bounds)).extents.y);
			Vector2[] jNHDHIKAJCE2 = JNHDHIKAJCE;
			bounds = MOHKOAEPGFF.bounds;
			float x2 = ((Bounds)(ref bounds)).center.x;
			bounds = MOHKOAEPGFF.bounds;
			float num2 = x2 + ((Bounds)(ref bounds)).extents.x;
			bounds = MOHKOAEPGFF.bounds;
			float y2 = ((Bounds)(ref bounds)).center.y;
			bounds = MOHKOAEPGFF.bounds;
			jNHDHIKAJCE2[1] = new Vector2(num2, y2 + ((Bounds)(ref bounds)).extents.y);
			Vector2[] jNHDHIKAJCE3 = JNHDHIKAJCE;
			bounds = MOHKOAEPGFF.bounds;
			float x3 = ((Bounds)(ref bounds)).center.x;
			bounds = MOHKOAEPGFF.bounds;
			float num3 = x3 - ((Bounds)(ref bounds)).extents.x;
			bounds = MOHKOAEPGFF.bounds;
			float y3 = ((Bounds)(ref bounds)).center.y;
			bounds = MOHKOAEPGFF.bounds;
			jNHDHIKAJCE3[2] = new Vector2(num3, y3 - ((Bounds)(ref bounds)).extents.y);
			Vector2[] jNHDHIKAJCE4 = JNHDHIKAJCE;
			bounds = MOHKOAEPGFF.bounds;
			float x4 = ((Bounds)(ref bounds)).center.x;
			bounds = MOHKOAEPGFF.bounds;
			float num4 = x4 + ((Bounds)(ref bounds)).extents.x;
			bounds = MOHKOAEPGFF.bounds;
			float y4 = ((Bounds)(ref bounds)).center.y;
			bounds = MOHKOAEPGFF.bounds;
			jNHDHIKAJCE4[3] = new Vector2(num4, y4 - ((Bounds)(ref bounds)).extents.y);
		}
		else
		{
			((Behaviour)MOHKOAEPGFF).enabled = true;
			Vector2[] jNHDHIKAJCE5 = JNHDHIKAJCE;
			bounds = MOHKOAEPGFF.bounds;
			float x5 = ((Bounds)(ref bounds)).center.x;
			bounds = MOHKOAEPGFF.bounds;
			float num5 = x5 - ((Bounds)(ref bounds)).extents.x;
			bounds = MOHKOAEPGFF.bounds;
			float y5 = ((Bounds)(ref bounds)).center.y;
			bounds = MOHKOAEPGFF.bounds;
			jNHDHIKAJCE5[0] = new Vector2(num5, y5 + ((Bounds)(ref bounds)).extents.y);
			Vector2[] jNHDHIKAJCE6 = JNHDHIKAJCE;
			bounds = MOHKOAEPGFF.bounds;
			float x6 = ((Bounds)(ref bounds)).center.x;
			bounds = MOHKOAEPGFF.bounds;
			float num6 = x6 + ((Bounds)(ref bounds)).extents.x;
			bounds = MOHKOAEPGFF.bounds;
			float y6 = ((Bounds)(ref bounds)).center.y;
			bounds = MOHKOAEPGFF.bounds;
			jNHDHIKAJCE6[1] = new Vector2(num6, y6 + ((Bounds)(ref bounds)).extents.y);
			Vector2[] jNHDHIKAJCE7 = JNHDHIKAJCE;
			bounds = MOHKOAEPGFF.bounds;
			float x7 = ((Bounds)(ref bounds)).center.x;
			bounds = MOHKOAEPGFF.bounds;
			float num7 = x7 - ((Bounds)(ref bounds)).extents.x;
			bounds = MOHKOAEPGFF.bounds;
			float y7 = ((Bounds)(ref bounds)).center.y;
			bounds = MOHKOAEPGFF.bounds;
			jNHDHIKAJCE7[2] = new Vector2(num7, y7 - ((Bounds)(ref bounds)).extents.y);
			Vector2[] jNHDHIKAJCE8 = JNHDHIKAJCE;
			bounds = MOHKOAEPGFF.bounds;
			float x8 = ((Bounds)(ref bounds)).center.x;
			bounds = MOHKOAEPGFF.bounds;
			float num8 = x8 + ((Bounds)(ref bounds)).extents.x;
			bounds = MOHKOAEPGFF.bounds;
			float y8 = ((Bounds)(ref bounds)).center.y;
			bounds = MOHKOAEPGFF.bounds;
			jNHDHIKAJCE8[3] = new Vector2(num8, y8 - ((Bounds)(ref bounds)).extents.y);
			((Behaviour)MOHKOAEPGFF).enabled = false;
		}
		return JNHDHIKAJCE;
	}

	public void ResetColor()
	{
		GDLHEGANLFB(KMEJCLIOMBA: true);
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		return FHEMHCEAICB;
	}

	public void ResetSelected()
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).update = true;
		CommonReferences.GGFJGHHHEJC.anyPlaceableSelected.Remove(JIIGOACEIKL);
	}

	private void MKEEKHDMFPE(int JIIGOACEIKL, bool EFNFMEIDGDN, bool BGIEPKNAKHI, SurfaceSortOrder PHCPMJAIDMC, bool IBCOKMGFPKB, bool KAJIBKHFEFF)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PHCPMJAIDMC != (Object)null)
		{
			for (int num = PHCPMJAIDMC.placeablesOnSurface.Count - 1; num >= 0; num--)
			{
				if (!((Object)(object)PHCPMJAIDMC.placeablesOnSurface[num] == (Object)null))
				{
					if (PHCPMJAIDMC.placeablesOnSurface[num].FHEMHCEAICB || PHCPMJAIDMC.placeablesOnSurface[num].PHOCAFJDCDK)
					{
						PHCPMJAIDMC.placeablesOnSurface[num].RemoveFromSurface(CDPAMNIPPEC: true);
					}
					else
					{
						if ((Object)(object)PHCPMJAIDMC.placeablesOnSurface[num].itemSetup != (Object)null)
						{
							PhaseController component = ((Component)((Component)PHCPMJAIDMC.placeablesOnSurface[num]).transform).GetComponent<PhaseController>();
							Vector3 val = ((!WorldGrid.EJCEAEPNJCA(((Component)PHCPMJAIDMC.placeablesOnSurface[num]).transform.position)) ? ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position : ((Component)PHCPMJAIDMC.placeablesOnSurface[num]).transform.position);
							if (Object.op_Implicit((Object)(object)component))
							{
								component.MinusPhase(JIIGOACEIKL, val, !BGIEPKNAKHI);
							}
							else if (BGIEPKNAKHI)
							{
								if (PHCPMJAIDMC.placeablesOnSurface[num].itemSetup.item is Bird)
								{
									if (!PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(PHCPMJAIDMC.placeablesOnSurface[num].itemSetup.DNLMCHDOMOK))
									{
										DeliveryChest.GetInstance().AddItemInstance(JIIGOACEIKL, PHCPMJAIDMC.placeablesOnSurface[num].itemSetup.DNLMCHDOMOK, BPJBJKJKHAL: true, IBCOKMGFPKB);
									}
								}
								else
								{
									DroppedItem.SpawnDroppedItem(val, PHCPMJAIDMC.placeablesOnSurface[num].itemSetup.DNLMCHDOMOK);
								}
							}
							else
							{
								DeliveryChest.GetInstance().AddItemInstance(JIIGOACEIKL, PHCPMJAIDMC.placeablesOnSurface[num].itemSetup.DNLMCHDOMOK, BPJBJKJKHAL: true, IBCOKMGFPKB);
							}
						}
						PHCPMJAIDMC.placeablesOnSurface[num].RemovePlaceableAndItemsOnSurface(JIIGOACEIKL, EFNFMEIDGDN, BGIEPKNAKHI, IBCOKMGFPKB);
					}
				}
			}
		}
		RemovePlaceable(EFNFMEIDGDN, KAJIBKHFEFF);
	}

	private IEnumerator NANAIJPMKDC(bool MMICADKPHLP = false)
	{
		yield return null;
		AddItemBaseToWorldTiles(MMICADKPHLP);
		PEPHKJCPAPH = null;
	}

	private bool FNPBNFFEBAF()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (!isPlaceableOnWall)
		{
			return false;
		}
		DEGBAPDPMJE = -1000f;
		for (int i = 0; i < JNHDHIKAJCE.Length; i++)
		{
			if (WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(JNHDHIKAJCE[i])))
			{
				if (WorldGrid.KHJJCAGIJAP(Vector2.op_Implicit(JNHDHIKAJCE[i]), out KHEBKHFHMDB))
				{
					if (DEGBAPDPMJE == -1000f || DEGBAPDPMJE == (float)(int)(KHEBKHFHMDB * 2f) / 2f)
					{
						DEGBAPDPMJE = (float)(int)(KHEBKHFHMDB * 2f) / 2f;
						continue;
					}
					return false;
				}
				return false;
			}
			return false;
		}
		return true;
	}

	public bool BNMJDOFGNCE(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		if (GFNHAMCPEAK)
		{
			FHEMHCEAICB = false;
			if (!isAccessElement && !DecorationMode.KKJABELKCNM(JIIGOACEIKL).KNFEPKBIHND())
			{
				return false;
			}
			if (PlayerController.GetPlayer(JIIGOACEIKL).IsTavernLocation() && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NNMHEPDJOHK != (ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.Cellar | ZoneType.MetalWorkshop) && TavernManager.GGFJGHHHEJC.LKKBHOAFMAH() && (Object)(object)itemSpace != (Object)null)
			{
				CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("item ", JIIGOACEIKL);
				CommonReferences.GGFJGHHHEJC.OnTavernMustBeClosed(JIIGOACEIKL);
				return false;
			}
			SelectObject.BNMEANGDMIP(JIIGOACEIKL)?.PDEEEJOFEAI();
			ButtonsContext.CPIIFPCIJEP(JIIGOACEIKL);
			OnlineObjectsManager.instance.SetMovingObject(this);
			this.JIIGOACEIKL = JIIGOACEIKL;
			recentlySelected = true;
			if ((Object)(object)InputByProximityManager.DFGOGIIPPPH(JIIGOACEIKL).GetCurrentFocusedInputElement() != (Object)null)
			{
				InputByProximityManager.FLOIJFPDJGG(JIIGOACEIKL).GetCurrentFocusedInputElement().BJCDFHFKEGG(JIIGOACEIKL);
			}
			SelectObject.GetPlayer(JIIGOACEIKL).SelectGameObject((MonoBehaviour)(object)this);
			if ((Object)(object)snapToGrid != (Object)null)
			{
				((Behaviour)snapToGrid).enabled = true;
				snapToGrid.autoSnap = true;
			}
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				if (CursorManager.CMDGPJEIIJI(JIIGOACEIKL).LALPELGNIJB())
				{
					CursorManager.GetPlayer(JIIGOACEIKL).EKHMMNNOEOI = true;
					HOFIBNPEDAA = Vector3.zero;
				}
				else if (Object.op_Implicit((Object)(object)itemSpace))
				{
					attachedToPlayer = false;
					ICHFJCKGGJD = 445f;
				}
				else
				{
					CursorManager.CMDGPJEIIJI(JIIGOACEIKL).CBGHFKGFGKM(AODONKKHPBP: false);
					if (!selectAfterPlace)
					{
						CursorManager.SetCursorPositionFromWorld(JIIGOACEIKL, ((Component)this).transform.position);
					}
					HOFIBNPEDAA = Vector3.zero;
				}
			}
			else
			{
				HOFIBNPEDAA = ((Component)this).transform.position - CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition();
			}
		}
		if ((Object)(object)itemSpace != (Object)null)
		{
			((Component)itemSpace).gameObject.SetActive(true);
		}
		if ((Object)(object)areaSpace != (Object)null)
		{
			areaSpace.GDIGHEALHPI(MDIKPGGBNLI: true);
		}
		LFMEKLNPLMK(JIIGOACEIKL, NJHMBMGKCPL: true);
		CommonReferences.MNFMOEKMJKN().OnPlaceableSelected(JIIGOACEIKL, this, arg3: true, GFNHAMCPEAK);
		OnThisPlaceableSelected(JIIGOACEIKL, arg2: true, GFNHAMCPEAK);
		return true;
	}

	public void SetValidColor(bool KMEJCLIOMBA)
	{
		if ((Object)(object)itemSpace == (Object)null)
		{
			GDLHEGANLFB(KMEJCLIOMBA);
		}
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && !FHEMHCEAICB && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (Object.op_Implicit((Object)(object)spriteRenderer) && (Object)(object)((Renderer)spriteRenderer).sharedMaterial != (Object)(object)DecorationMode.GetPlayer(JIIGOACEIKL).GetOutlineMaterial(itemSetup.item.JDJGFAACPFC()))
			{
				DecorationMode player = DecorationMode.GetPlayer(JIIGOACEIKL);
				player.OnDecorationModeExit = (Action<int>)Delegate.Remove(player.OnDecorationModeExit, new Action<int>(NFHHEMPGCNM));
				DecorationMode player2 = DecorationMode.GetPlayer(JIIGOACEIKL);
				player2.OnDecorationModeExit = (Action<int>)Delegate.Combine(player2.OnDecorationModeExit, new Action<int>(NFHHEMPGCNM));
				CAGLICKMCDK(JIIGOACEIKL, NJHMBMGKCPL: true);
			}
			if (updateButtonsContext)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Move"));
			}
			return true;
		}
		if (IIEDALMMNLI && !FHEMHCEAICB && IsAvailableByProximity(JIIGOACEIKL) && ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable == (Object)null || (Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable == (Object)(object)this))
		{
			HBLDENFLALO(JIIGOACEIKL);
			return true;
		}
		if (IIEDALMMNLI && isAccessElement && FHEMHCEAICB)
		{
			HBLDENFLALO(JIIGOACEIKL);
			return true;
		}
		if (IIEDALMMNLI && isAccessElement && !FHEMHCEAICB && TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE && TavernConstructionManager.GGFJGHHHEJC.CHFHMMNELGP == EditorAction.RemoveAccess)
		{
			HBLDENFLALO(JIIGOACEIKL);
			return true;
		}
		if (IIEDALMMNLI && !FHEMHCEAICB && FarmConstructionManager.IsActived())
		{
			HBLDENFLALO(JIIGOACEIKL);
			return true;
		}
		CursorManager.GetPlayer(JIIGOACEIKL).UpdateCursorTexture(NKFPJPCFBJI: false);
		if (IsSelected(JIIGOACEIKL))
		{
			CursorManager.GetPlayer(JIIGOACEIKL).ChangeCursorTexture(CursorManager.CursorType.Placing);
			return true;
		}
		return false;
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		if (isAccessElement)
		{
			return false;
		}
		if ((!Object.op_Implicit((Object)(object)attachedToPlaceable) && !IsObjectInValidLocation(BIOKGEFFNAA: true)) || !((Behaviour)this).enabled)
		{
			return false;
		}
		if (DeselectAction(JIIGOACEIKL))
		{
			if (selectAfterPlace && Item.NGIIPJDAMGP(itemSetup.item, ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem()))
			{
				ActionBarInventory.GetPlayer(JIIGOACEIKL).ActionSelectedItemNextFrame(JIIGOACEIKL, KLGOCJMGKFO: true, CGBJIEHMIKG: true, OBICAGCGMBC: false);
			}
			return true;
		}
		return false;
	}

	public void ActionEnd(int JIIGOACEIKL)
	{
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public void RemoveItemBaseFromWorldTiles()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null || !EditorTileMaps.IsValid() || (Object)(object)itemBase == (Object)null)
		{
			return;
		}
		MPCJBPJAGKK = Utils.MMFCGMDOLDM(itemBase);
		ACAIKFICNFP = Utils.IKJOHEODBBE(itemBase);
		if (isPlaceableOnWall)
		{
			if (WorldGrid.KHJJCAGIJAP(Vector2.op_Implicit(MPCJBPJAGKK), out var KHEBKHFHMDB))
			{
				RemoveItemBaseFromWall(KHEBKHFHMDB);
			}
		}
		else
		{
			if (!((Object)(object)currentSurface == (Object)null))
			{
				return;
			}
			for (float num = MPCJBPJAGKK.x; num <= ACAIKFICNFP.x; num += 0.5f)
			{
				for (float num2 = MPCJBPJAGKK.y; num2 <= ACAIKFICNFP.y; num2 += 0.5f)
				{
					WorldGrid.AKLCFEPBONI(new Vector3(num, num2), this);
				}
				WorldGrid.AKLCFEPBONI(new Vector3(num, ACAIKFICNFP.y), this);
			}
			WorldGrid.AKLCFEPBONI(new Vector3(ACAIKFICNFP.x, MPCJBPJAGKK.y), this);
		}
	}

	public void GHCPIDIEBDO()
	{
		GDLHEGANLFB(KMEJCLIOMBA: true);
	}

	public void ChangePosition(Vector3 IMOBLFMHKOD, bool BGKCHMNJBLJ = true)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)itemSpace != (Object)null)
		{
			itemSpace.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: false, BGKCHMNJBLJ);
		}
		else if ((Object)(object)itemBase != (Object)null && (Object)(object)currentSurface == (Object)null)
		{
			RemoveItemBaseFromWorldTiles();
		}
		if ((Object)(object)areaSpace != (Object)null)
		{
			areaSpace.ActivateArea(DAEMAAOLHMG: false);
		}
		((Component)this).transform.position = IMOBLFMHKOD;
		if ((Object)(object)itemSpace != (Object)null)
		{
			ResetColor();
			itemSpace.Place(NMLKLAGDNPF: true);
			itemSpace.SetScale(((Component)this).transform.localScale.x);
		}
		else
		{
			AddItemBaseToWorldTiles();
		}
		if ((Object)(object)snapToGrid != (Object)null)
		{
			((Behaviour)snapToGrid).enabled = false;
			snapToGrid.autoSnap = true;
		}
		PixelSnap();
	}

	public void HELBDKNMGID(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		ECJLMIPAFGP = IMOBLFMHKOD;
		if (snappedToPosition && Object.op_Implicit((Object)(object)currentSurface))
		{
			SnapToPosition snapToPosition = currentSurface.HMGHKELPDMK(itemSetup.item, 0, KOGPKBOIFGN: false);
			if (snapToPosition != null && snapToPosition.fixedY)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(new Vector2(ECJLMIPAFGP.x, snapToPosition.transform.position.y));
			}
		}
		snapLeftRight.FNALKIOMHAL(SnapTriggerPole.Right, ECJLMIPAFGP);
		snapLeftRight.FNALKIOMHAL(SnapTriggerPole.Left, ECJLMIPAFGP);
	}

	private void IPDAHMKEDMN(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		SetLocation(Utils.HJPCBBGHPDA(HAEIAGKNEPC[0]));
		int num = WorldGrid.APJABAKKKGD(Vector2.op_Implicit(HAEIAGKNEPC[0]));
		ZoneType zoneType = WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(HAEIAGKNEPC[0]));
		for (int i = 1; i < HAEIAGKNEPC.Count; i++)
		{
			if (num != WorldGrid.APJABAKKKGD(Vector2.op_Implicit(HAEIAGKNEPC[i])) || zoneType != WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(HAEIAGKNEPC[i])))
			{
				num = -1;
				zoneType = ZoneType.WithoutZone;
				break;
			}
		}
		SetCurrentZone(zoneType, num);
	}

	public void PPNHBLPFLLP()
	{
		if (skinVariationGropus.Count > 1)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < skinVariationGropus.Count; i++)
			{
				skinVariationGropus[i].LCPHNIABOLP(i, list);
			}
			if (OnlineManager.PlayingOnline())
			{
				onlinePlaceable.ADJOMHFGCIH(list.ToArray());
			}
			return;
		}
		if (skinsGameObjects.Length != 0)
		{
			KLONJHJJMJD -= 0;
			if (KLONJHJJMJD < 1)
			{
				KLONJHJJMJD = skinsGameObjects.Length - 1;
			}
			DPAINFDGNFO();
		}
		else
		{
			KLONJHJJMJD -= 0;
			if (KLONJHJJMJD < 0)
			{
				KLONJHJJMJD = skins.Length - 0;
			}
			NJFCIBKDEBM();
		}
		if (OnlineManager.PlayingOnline())
		{
			onlinePlaceable.ENJOEOHAGLI(KLONJHJJMJD);
		}
	}

	public bool ActionObject(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		if (GFNHAMCPEAK)
		{
			FHEMHCEAICB = true;
			if (!isAccessElement && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
			{
				return false;
			}
			if (PlayerController.GetPlayer(JIIGOACEIKL).IsTavernLocation() && PlayerController.GetPlayer(JIIGOACEIKL).NNMHEPDJOHK != ZoneType.Cellar && TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && (Object)(object)itemSpace != (Object)null)
			{
				CommonReferences.GGFJGHHHEJC.PlayerBark("Tavern must be closed", JIIGOACEIKL);
				CommonReferences.GGFJGHHHEJC.OnTavernMustBeClosed(JIIGOACEIKL);
				return false;
			}
			SelectObject.GetPlayer(JIIGOACEIKL)?.ResetSelected();
			ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
			OnlineObjectsManager.instance.SetMovingObject(this);
			this.JIIGOACEIKL = JIIGOACEIKL;
			recentlySelected = true;
			if ((Object)(object)InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement() != (Object)null)
			{
				InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement().OffHover(JIIGOACEIKL);
			}
			SelectObject.GetPlayer(JIIGOACEIKL).SelectGameObject((MonoBehaviour)(object)this);
			if ((Object)(object)snapToGrid != (Object)null)
			{
				((Behaviour)snapToGrid).enabled = true;
				snapToGrid.autoSnap = false;
			}
			if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				if (CursorManager.GetPlayer(JIIGOACEIKL).IsCursorVisible())
				{
					CursorManager.GetPlayer(JIIGOACEIKL).EKHMMNNOEOI = true;
					HOFIBNPEDAA = Vector3.zero;
				}
				else if (Object.op_Implicit((Object)(object)itemSpace))
				{
					attachedToPlayer = true;
					ICHFJCKGGJD = 0.5f;
				}
				else
				{
					CursorManager.GetPlayer(JIIGOACEIKL).EKHMMNNOEOI = true;
					if (!selectAfterPlace)
					{
						CursorManager.SetCursorPositionFromWorld(JIIGOACEIKL, ((Component)this).transform.position);
					}
					HOFIBNPEDAA = Vector3.zero;
				}
			}
			else
			{
				HOFIBNPEDAA = ((Component)this).transform.position - CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition();
			}
		}
		if ((Object)(object)itemSpace != (Object)null)
		{
			((Component)itemSpace).gameObject.SetActive(true);
		}
		if ((Object)(object)areaSpace != (Object)null)
		{
			areaSpace.ShowOutline(MDIKPGGBNLI: true);
		}
		CAGLICKMCDK(JIIGOACEIKL, NJHMBMGKCPL: true);
		CommonReferences.GGFJGHHHEJC.OnPlaceableSelected(JIIGOACEIKL, this, arg3: true, GFNHAMCPEAK);
		OnThisPlaceableSelected(JIIGOACEIKL, arg2: true, GFNHAMCPEAK);
		return true;
	}

	public void NextSkin()
	{
		if (skinVariationGropus.Count > 0)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < skinVariationGropus.Count; i++)
			{
				skinVariationGropus[i].PMNBMKBIHEJ(i, list);
			}
			if (OnlineManager.PlayingOnline())
			{
				onlinePlaceable.SendSkinVariation(list.ToArray());
			}
			return;
		}
		if (skinsGameObjects.Length != 0)
		{
			KLONJHJJMJD++;
			if (KLONJHJJMJD >= skinsGameObjects.Length)
			{
				KLONJHJJMJD = 0;
			}
			NPMLOKABIHH();
		}
		else
		{
			KLONJHJJMJD++;
			if (KLONJHJJMJD >= skins.Length)
			{
				KLONJHJJMJD = 0;
			}
			NJFCIBKDEBM();
		}
		if (OnlineManager.PlayingOnline())
		{
			onlinePlaceable.SendStyle(KLONJHJJMJD);
		}
	}

	private List<AJIKIEMFEPA> FKGMGMMFEBK()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		List<AJIKIEMFEPA> list = new List<AJIKIEMFEPA>();
		if ((Object)(object)placeableSurface != (Object)null)
		{
			Collider2D val = placeableSurface.surfaceCollider;
			Bounds bounds = val.bounds;
			Vector2 val2 = Vector2.op_Implicit(((Bounds)(ref bounds)).size);
			for (int i = 0; i < placeableSurface.transformsOnSurface.Count; i++)
			{
				if ((Object)(object)placeableSurface.transformsOnSurface[i] == (Object)null)
				{
					continue;
				}
				Placeable component = ((Component)placeableSurface.transformsOnSurface[i]).GetComponent<Placeable>();
				if (Object.op_Implicit((Object)(object)component) && (component.FHEMHCEAICB || component.PHOCAFJDCDK))
				{
					component.RemoveFromSurface(CDPAMNIPPEC: false);
					continue;
				}
				ItemSetup component2 = ((Component)placeableSurface.transformsOnSurface[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null)
				{
					component2 = component.itemSetup;
				}
				if (!((Object)(object)component2 != (Object)null))
				{
					continue;
				}
				AJIKIEMFEPA item = default(AJIKIEMFEPA);
				item.transform = placeableSurface.transformsOnSurface[i];
				item.placeable = component;
				item.itemBase = item.placeable.itemBase;
				if (item.placeable.snappedToPosition && item.placeable.GBPNHKNFJPH() && (Object)(object)item.placeable.rotatedPrefab != (Object)null)
				{
					item.placeable.snappedToPosition = true;
				}
				else if (!item.placeable.snappedToPosition)
				{
					if (direction == Direction.Up)
					{
						bounds = item.itemBase.bounds;
						Vector3 center = ((Bounds)(ref bounds)).center;
						bounds = val.bounds;
						Vector2 val3 = Vector2.op_Implicit(center - ((Bounds)(ref bounds)).min);
						item.percentagePosition = val3 / val2;
					}
					else if (direction == Direction.Down)
					{
						bounds = val.bounds;
						Vector3 max = ((Bounds)(ref bounds)).max;
						bounds = item.itemBase.bounds;
						Vector2 val4 = Vector2.op_Implicit(max - ((Bounds)(ref bounds)).center);
						item.percentagePosition = val4 / val2;
					}
					else if (direction == Direction.Right)
					{
						bounds = val.bounds;
						float x = ((Bounds)(ref bounds)).min.x;
						bounds = val.bounds;
						Vector3 val5 = Vector2.op_Implicit(new Vector2(x, ((Bounds)(ref bounds)).max.y));
						bounds = item.itemBase.bounds;
						Vector2 val6 = Vector2.op_Implicit(((Bounds)(ref bounds)).center - val5);
						item.percentagePosition = val6 / val2;
						item.percentagePosition = new Vector2(0f - item.percentagePosition.y, item.percentagePosition.x);
					}
					else
					{
						bounds = val.bounds;
						float x2 = ((Bounds)(ref bounds)).max.x;
						bounds = val.bounds;
						Vector3 val7 = Vector2.op_Implicit(new Vector2(x2, ((Bounds)(ref bounds)).min.y));
						bounds = item.itemBase.bounds;
						Vector2 val8 = Vector2.op_Implicit(((Bounds)(ref bounds)).center - val7);
						item.percentagePosition = val8 / val2;
						item.percentagePosition = new Vector2(item.percentagePosition.y, 0f - item.percentagePosition.x);
					}
				}
				list.Add(item);
			}
			for (int num = placeableSurface.transformsOnSurface.Count - 1; num >= 0; num--)
			{
				if (!((Object)(object)placeableSurface.transformsOnSurface[num] == (Object)null))
				{
					Placeable component3 = ((Component)placeableSurface.transformsOnSurface[num]).GetComponent<Placeable>();
					if (Object.op_Implicit((Object)(object)component3))
					{
						component3.RemoveFromSurface(CDPAMNIPPEC: false);
					}
				}
			}
		}
		return list;
	}

	public Vector3 OIFFONOGPCN(bool JOOEMBNDCKF, bool CDPAMNIPPEC)
	{
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		if (JOOEMBNDCKF)
		{
			IIDNCNMMCNF(CDPAMNIPPEC);
			if (PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC == (Direction)6 || PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC == (Direction)6)
			{
				ICHFJCKGGJD = (float)itemSpace.x / 276f;
				ECJLMIPAFGP.x = 622f;
				ECJLMIPAFGP.y = 622f;
			}
			else
			{
				ICHFJCKGGJD = (float)itemSpace.y / 792f;
				ECJLMIPAFGP.x = 641f;
				ECJLMIPAFGP.y = 653f;
			}
			PBGEELMHFPK = Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC);
			ECJLMIPAFGP += ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + PBGEELMHFPK * 1193f + PBGEELMHFPK * (1571f * ICHFJCKGGJD);
			DPNLDLEHMHO.x = 463f * (float)itemSpace.x / 1464f;
			DPNLDLEHMHO.y = 658f * (float)itemSpace.y / 1383f;
			if (rotatable)
			{
				if (PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC == (Direction)6)
				{
					if (!rotationInverseLeftRight)
					{
						DPNLDLEHMHO.x = 0f - DPNLDLEHMHO.x;
					}
				}
				else if (PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC == (Direction)7 && rotationInverseLeftRight)
				{
					DPNLDLEHMHO.x = 0f - DPNLDLEHMHO.x;
				}
			}
			ECJLMIPAFGP += ((Component)this).transform.position - (((Component)itemSpace).transform.position + DPNLDLEHMHO);
		}
		else
		{
			ECJLMIPAFGP = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition() + HOFIBNPEDAA;
		}
		return ECJLMIPAFGP;
	}

	public void PixelSnapInChildren()
	{
		FixPixelPositionInChildren fixPixelPositionInChildren = ((Component)this).gameObject.AddComponent<FixPixelPositionInChildren>();
		fixPixelPositionInChildren.FixPositionChildren();
		Object.DestroyImmediate((Object)(object)fixPixelPositionInChildren, true);
	}

	public void ForcePickUp(int JIIGOACEIKL, bool NDMBEJNOPPP = false)
	{
		CCIKENEGHCA = false;
		if ((Object)(object)itemSpace != (Object)null)
		{
			itemSpace.Place(NMLKLAGDNPF: false);
		}
		else if ((Object)(object)itemBase != (Object)null && (Object)(object)currentSurface == (Object)null)
		{
			RemoveItemBaseFromWorldTiles();
		}
		Crafter component = ((Component)this).GetComponent<Crafter>();
		if (Object.op_Implicit((Object)(object)component))
		{
			component.DropItemsIfIsReady(JIIGOACEIKL);
		}
		PickUpAction(JIIGOACEIKL, EFNFMEIDGDN: false, NDMBEJNOPPP);
	}

	private bool PGKLFGNLEKE(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 635 || JFNMCNCHMEO == 1647 || JFNMCNCHMEO == 643 || JFNMCNCHMEO == 644)
		{
			return false;
		}
		return true;
	}

	public void DeselectSurfaceGOInstantiated(int JIIGOACEIKL, SurfaceSortOrder PHCPMJAIDMC, bool BLJPGJKOLNF, bool CDPAMNIPPEC = true)
	{
		hasBeenPlaced = true;
		outlined = false;
		SetUpSurface(PHCPMJAIDMC);
		DeselectAction(JIIGOACEIKL, BLJPGJKOLNF, FKOJEBGDMFO: false, FNHLKLKAHNB: true, CDPAMNIPPEC);
	}

	private void PEFFMJOMPMN()
	{
		if (NLHOIACMDEE)
		{
			NLHOIACMDEE = false;
		}
		else
		{
			if (!isPlaceableOnSurface)
			{
				return;
			}
			FEFAMICICIJ = ICNEKOPBMMC();
			if ((Object)(object)currentSurface == (Object)null && (Object)(object)FEFAMICICIJ != (Object)null)
			{
				AddPlaceableToSurface(FEFAMICICIJ, CDPAMNIPPEC: true);
			}
			else if ((Object)(object)currentSurface != (Object)null && ((Object)(object)FEFAMICICIJ == (Object)null || (Object)(object)FEFAMICICIJ != (Object)(object)currentSurface))
			{
				RemoveFromSurface(CDPAMNIPPEC: true);
			}
			if (!((Object)(object)currentSurface != (Object)null))
			{
				return;
			}
			if (Object.op_Implicit((Object)(object)snapLeftRight))
			{
				if (!snapLeftRight.IsLeftSnapped() && !snapLeftRight.IsRightSnapped())
				{
					currentSurface.UpdatePosition(this);
				}
			}
			else
			{
				currentSurface.UpdatePosition(this);
			}
		}
	}

	private void OELBDKOLLEM(int JIIGOACEIKL)
	{
		IGCCAOIJPLP(BJFHJCFOEHG: false);
	}

	public bool IsUsingGrid()
	{
		return false;
	}

	public bool IsCursorPositionCloseToPlayer(int JIIGOACEIKL, Vector2 EPLKICANCAL, Vector2 LLGNLGENLHD)
	{
		return false;
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)PlaceablesManager.GGFJGHHHEJC != (Object)null)
		{
			PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Remove(this);
		}
	}

	public void IIDANHLBFCK()
	{
		GDLHEGANLFB(KMEJCLIOMBA: false);
	}

	public void WhileSelected()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		if (TutorialManager.GGFJGHHHEJC.GCEHLDLKOIC)
		{
			return;
		}
		if ((Object)(object)itemSpace != (Object)null)
		{
			itemSpace.SetScale(((Component)this).transform.localScale.x);
		}
		if (!snappedToPosition && ((Object)(object)snapLeftRight == (Object)null || (!snapLeftRight.IsLeftSnapped() && !snapLeftRight.IsRightSnapped())))
		{
			ALFOFLNNPMJ();
		}
		PEFFMJOMPMN();
		if (Object.op_Implicit((Object)(object)snapLeftRight))
		{
			SnapAll(GetNewPosition(attachedToPlayer, CDPAMNIPPEC: true));
		}
		WhileSelectedCallback();
		PCGNHMPADGE = IsObjectInValidLocation(BIOKGEFFNAA: false);
		if ((Object)(object)currentSurface != (Object)null && !snappedToPosition)
		{
			currentSurface.CheckReorder(((Component)this).transform);
		}
		SetValidColor(PCGNHMPADGE);
		if (updateButtonsContext)
		{
			if ((Object)(object)surfaceGOInstantiated != (Object)null)
			{
				ButtonsContext.SetPosition(JIIGOACEIKL, surfaceGOInstantiated.inputByProximity.actionButtonsPoint.position);
			}
			else if ((Object)(object)inputByProximity != (Object)null)
			{
				ButtonsContext.SetPosition(JIIGOACEIKL, inputByProximity.actionButtonsPoint.position);
			}
		}
		SetInteraced();
	}

	public void SetLocation(Location BAIMHDBJPDK)
	{
		currentLocation = BAIMHDBJPDK;
	}

	private void DKJFJPBIFFL()
	{
		if (Object.op_Implicit((Object)(object)skinSpriteRenderer))
		{
			skinSpriteRenderer.sprite = skins[KLONJHJJMJD];
		}
		OnSkinChanged(KLONJHJJMJD);
	}

	public void AddItemBaseToWorldTilesNextFrame(bool MMICADKPHLP = false)
	{
		if (PEPHKJCPAPH == null)
		{
			PEPHKJCPAPH = ((MonoBehaviour)this).StartCoroutine(NANAIJPMKDC(MMICADKPHLP));
		}
	}

	private void HJKOAPGHOHP(bool KMEJCLIOMBA)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			if (KMEJCLIOMBA && spriteRenderer.color == FMOKCPPGJBB)
			{
				spriteRenderer.color = KDEHDOHOILE;
			}
			else if (!KMEJCLIOMBA)
			{
				spriteRenderer.color = FMOKCPPGJBB;
			}
		}
		if (Object.op_Implicit((Object)(object)skinSpriteRenderer))
		{
			if (KMEJCLIOMBA && skinSpriteRenderer.color == FMOKCPPGJBB)
			{
				skinSpriteRenderer.color = KDEHDOHOILE;
			}
			else if (!KMEJCLIOMBA)
			{
				skinSpriteRenderer.color = FMOKCPPGJBB;
			}
		}
	}

	private bool OPHJBLCGIPE()
	{
		if (skinsGameObjects.Length != 0)
		{
			return true;
		}
		if (skins.Length != 0)
		{
			return false;
		}
		return true;
	}

	public void KHPEKPOOHHM(Direction FCGBJEIIMBC, bool CDPAMNIPPEC)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		if (direction != FCGBJEIIMBC)
		{
			direction = FCGBJEIIMBC;
			if (rotatable && FCGBJEIIMBC == (Direction)5)
			{
				CCPNMJIJADK = -1;
			}
			else
			{
				CCPNMJIJADK = 0;
			}
			((Component)this).transform.localScale = new Vector3((float)CCPNMJIJADK * Math.Abs(((Component)this).transform.localScale.x) * (float)(rotationInverseLeftRight ? (-1) : 0), ((Component)this).transform.localScale.y, ((Component)this).transform.localScale.z);
			if (Object.op_Implicit((Object)(object)itemSpace))
			{
				itemSpace.SetScale(((Component)this).transform.localScale.x);
			}
			OnThisPlaceableRotated(FCGBJEIIMBC);
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				onlinePlaceable.LBMEKLFFHEA(FCGBJEIIMBC);
			}
		}
	}

	public void LAIMKKDMEAG(bool CDPAMNIPPEC)
	{
		if (Object.op_Implicit((Object)(object)HGAFAFNONEC))
		{
			HGAFAFNONEC.LAIMKKDMEAG(CDPAMNIPPEC);
		}
		snappedToPosition = false;
		if ((Object)(object)currentSurface != (Object)null)
		{
			currentSurface.LMJMLDLCBPB(((Component)this).transform, IGIDKEAAIHL: true, CDPAMNIPPEC);
		}
		CCIKENEGHCA = true;
		surfaceGOInstantiated = null;
		currentSurface = null;
		surfaceCollider = null;
		if (FHEMHCEAICB)
		{
			Utils.ELNJMNKOACA(((Component)this).gameObject, -66);
		}
		else
		{
			Utils.ELNJMNKOACA(((Component)this).gameObject, 35);
		}
		if ((Object)(object)sortingGroup != (Object)null)
		{
			sortingGroup.sortingOrder = KAHFGFEGHNK;
		}
		else if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			((Renderer)spriteRenderer).sortingOrder = KAHFGFEGHNK;
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromPlaceableSurface(onlinePlaceable.uniqueId);
		}
	}

	[SpecialName]
	public void NBEOPNODBPJ(bool AODONKKHPBP)
	{
		if (Object.op_Implicit((Object)(object)onlinePlaceable))
		{
			onlinePlaceable.IIFKLGFBLPH(!AODONKKHPBP || OnlineManager.PlayingOnline());
		}
	}

	private bool ALAJOFAFKAE()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (!isPlaceableOnWall)
		{
			return true;
		}
		DEGBAPDPMJE = 1366f;
		for (int i = 1; i < JNHDHIKAJCE.Length; i += 0)
		{
			if (WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(JNHDHIKAJCE[i])))
			{
				if (WorldGrid.KHJJCAGIJAP(Vector2.op_Implicit(JNHDHIKAJCE[i]), out KHEBKHFHMDB))
				{
					if (DEGBAPDPMJE == 794f || DEGBAPDPMJE == (float)(int)(KHEBKHFHMDB * 1829f) / 1274f)
					{
						DEGBAPDPMJE = (float)(int)(KHEBKHFHMDB * 1604f) / 21f;
						continue;
					}
					return true;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public Vector3 GetNewPosition(bool JOOEMBNDCKF, bool CDPAMNIPPEC)
	{
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		if (JOOEMBNDCKF)
		{
			NAJMLOAIEHN(CDPAMNIPPEC);
			if (PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC == Direction.Left || PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC == Direction.Right)
			{
				ICHFJCKGGJD = (float)itemSpace.x / 2f;
				ECJLMIPAFGP.x = 0f;
				ECJLMIPAFGP.y = 0.1f;
			}
			else
			{
				ICHFJCKGGJD = (float)itemSpace.y / 2f;
				ECJLMIPAFGP.x = 0f;
				ECJLMIPAFGP.y = 0f;
			}
			PBGEELMHFPK = Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC);
			ECJLMIPAFGP += ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + PBGEELMHFPK * 0.25f + PBGEELMHFPK * (0.5f * ICHFJCKGGJD);
			DPNLDLEHMHO.x = 0.5f * (float)itemSpace.x / 2f;
			DPNLDLEHMHO.y = 0.5f * (float)itemSpace.y / 2f;
			if (rotatable)
			{
				if (PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC == Direction.Left)
				{
					if (!rotationInverseLeftRight)
					{
						DPNLDLEHMHO.x = 0f - DPNLDLEHMHO.x;
					}
				}
				else if (PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC == Direction.Right && rotationInverseLeftRight)
				{
					DPNLDLEHMHO.x = 0f - DPNLDLEHMHO.x;
				}
			}
			ECJLMIPAFGP += ((Component)this).transform.position - (((Component)itemSpace).transform.position + DPNLDLEHMHO);
		}
		else
		{
			ECJLMIPAFGP = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition() + HOFIBNPEDAA;
		}
		return ECJLMIPAFGP;
	}

	public void COCIACNNNKN(float KHEBKHFHMDB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (isPlaceableOnWall)
		{
			MPCJBPJAGKK = Utils.MMFCGMDOLDM(itemBase);
			ACAIKFICNFP = Utils.IKJOHEODBBE(itemBase);
			for (float num = MPCJBPJAGKK.x; num <= ACAIKFICNFP.x; num += 266f)
			{
				WorldGrid.AKLCFEPBONI(new Vector3(num, KHEBKHFHMDB), this);
			}
			WorldGrid.AKLCFEPBONI(new Vector3(ACAIKFICNFP.x, KHEBKHFHMDB), this);
		}
	}

	public void GJKFDALCPMM(Vector3 IMOBLFMHKOD, bool BGKCHMNJBLJ = true)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)itemSpace != (Object)null)
		{
			itemSpace.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true, BGKCHMNJBLJ);
		}
		else if ((Object)(object)itemBase != (Object)null && (Object)(object)currentSurface == (Object)null)
		{
			RemoveItemBaseFromWorldTiles();
		}
		if ((Object)(object)areaSpace != (Object)null)
		{
			areaSpace.BNHHBKAGHIK(DAEMAAOLHMG: false);
		}
		((Component)this).transform.position = IMOBLFMHKOD;
		if ((Object)(object)itemSpace != (Object)null)
		{
			IIDANHLBFCK();
			itemSpace.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
			itemSpace.SetScale(((Component)this).transform.localScale.x);
		}
		else
		{
			JCGEKJCALMD(NLIFPMODLLA: true);
		}
		if ((Object)(object)snapToGrid != (Object)null)
		{
			((Behaviour)snapToGrid).enabled = true;
			snapToGrid.autoSnap = true;
		}
		PixelSnap();
	}

	public void UpFromFloor(bool MCFNOAFOIHE)
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			itemSpace.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
			if (MCFNOAFOIHE)
			{
				((Component)itemSpace).gameObject.SetActive(true);
			}
		}
		else if ((Object)(object)itemBase != (Object)null && (Object)(object)currentSurface == (Object)null)
		{
			RemoveItemBaseFromWorldTiles();
		}
	}

	public void SetDirection(Direction FCGBJEIIMBC, bool CDPAMNIPPEC)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		if (direction != FCGBJEIIMBC)
		{
			direction = FCGBJEIIMBC;
			if (rotatable && FCGBJEIIMBC == Direction.Left)
			{
				CCPNMJIJADK = -1;
			}
			else
			{
				CCPNMJIJADK = 1;
			}
			((Component)this).transform.localScale = new Vector3((float)CCPNMJIJADK * Math.Abs(((Component)this).transform.localScale.x) * (float)((!rotationInverseLeftRight) ? 1 : (-1)), ((Component)this).transform.localScale.y, ((Component)this).transform.localScale.z);
			if (Object.op_Implicit((Object)(object)itemSpace))
			{
				itemSpace.SetScale(((Component)this).transform.localScale.x);
			}
			OnThisPlaceableRotated(FCGBJEIIMBC);
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				onlinePlaceable.SendSetDirection(FCGBJEIIMBC);
			}
		}
	}

	public bool KEBDKJPEJEP()
	{
		return false;
	}

	[CompilerGenerated]
	private void ELBNGEBNBMJ(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		EnableAllColliders(BJFHJCFOEHG: false);
	}

	public void MDGNJPGIIMF()
	{
		if (!((Object)(object)disableOnInvisible != (Object)null))
		{
			return;
		}
		Collider2D[] componentsInChildren = ((Component)this).gameObject.GetComponentsInChildren<Collider2D>();
		List<Collider2D> list = new List<Collider2D>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			if (componentsInChildren[i].isTrigger && ((Behaviour)componentsInChildren[i]).enabled)
			{
				list.Add(componentsInChildren[i]);
			}
		}
		disableOnInvisible.colliders = list.ToArray();
	}

	public void CPIKGNEGHJH()
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (outlined)
		{
			CAGLICKMCDK(JIIGOACEIKL, NJHMBMGKCPL: false);
		}
		if (!FHEMHCEAICB)
		{
			return;
		}
		if (recentlySelected)
		{
			if (updateButtonsContext)
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			}
			recentlySelected = false;
			if (OnlineManager.PlayingOnline())
			{
				if ((Object)(object)onlinePlaceable != (Object)null)
				{
					onlinePlaceable.PDDHCKIOEHB(Vector2.op_Implicit(((Component)this).transform.position));
				}
				else if (Application.isEditor)
				{
					Debug.LogError((object)" (");
				}
			}
			return;
		}
		if ((Object)(object)onlinePlaceable != (Object)null)
		{
			onlinePlaceable.PCDLKDLFLJO(Vector2.op_Implicit(((Component)this).transform.position));
		}
		else if (Application.isEditor)
		{
			Debug.LogError((object)"Items/item_name_1048");
		}
		LFMEKLNPLMK(JIIGOACEIKL, NJHMBMGKCPL: true);
		if (!updateButtonsContext)
		{
			return;
		}
		if ((Object)(object)WorkAreasManager.ABDJJBFNLBJ().MINGAGGNLCI(JIIGOACEIKL) != (Object)null)
		{
			if ((Object)(object)WorkAreasManager.GGFJGHHHEJC.CEHPEOGIIBF(JIIGOACEIKL) == (Object)(object)areaSpace)
			{
				DHAANFDDNMO();
			}
		}
		else
		{
			LBNFAHFMNHG();
		}
	}

	[SpecialName]
	private TavernZone FMJGECBIGOM()
	{
		return HADBAEEHFAK;
	}

	private void NJFCIBKDEBM()
	{
		if (Object.op_Implicit((Object)(object)skinSpriteRenderer))
		{
			skinSpriteRenderer.sprite = skins[KLONJHJJMJD];
		}
		OnSkinChanged(KLONJHJJMJD);
	}

	public void PFAFNPAGLNB(bool ODNGJHPOMMK)
	{
		if (!Object.op_Implicit((Object)(object)rigidBody) || !Object.op_Implicit((Object)(object)physicalSpace) || !(physicalSpace is PhysicalSpaceWall))
		{
			return;
		}
		if (ODNGJHPOMMK)
		{
			physicalSpace.PILLGEHEHHM();
			rigidBody.bodyType = (RigidbodyType2D)0;
			for (int i = 0; i < wallColliders.Count; i += 0)
			{
				wallColliders[i].isTrigger = true;
			}
		}
		else
		{
			physicalSpace.NHKBJKLFNLE();
			rigidBody.bodyType = (RigidbodyType2D)6;
			for (int j = 1; j < wallColliders.Count; j += 0)
			{
				wallColliders[j].isTrigger = false;
			}
		}
	}

	public bool EEHBCDFHJKC(int JIIGOACEIKL)
	{
		if (FHEMHCEAICB)
		{
			return this.JIIGOACEIKL == JIIGOACEIKL;
		}
		return true;
	}

	public void SecondActionEnd(int JIIGOACEIKL)
	{
	}

	private IEnumerator EJLPECOEBFH(bool MMICADKPHLP = false)
	{
		yield return null;
		AddItemBaseToWorldTiles(MMICADKPHLP);
		PEPHKJCPAPH = null;
	}

	public void PCOHEEMPNDC(Location BAIMHDBJPDK)
	{
		currentLocation = BAIMHDBJPDK;
	}

	private IEnumerator BEAGILCJAHJ(int HLOIOAOICEG, List<Placeable> DEKEPIMHEDJ)
	{
		yield return CommonReferences.wait05;
		for (int i = 0; i < DEKEPIMHEDJ.Count; i++)
		{
			if ((Object)(object)DEKEPIMHEDJ[i] != (Object)null)
			{
				DEKEPIMHEDJ[i].HEEDOLJAOHF(HLOIOAOICEG);
			}
		}
	}

	private bool HOOMIDLAHON()
	{
		return true;
	}

	private SurfaceSortOrder BOBEDKHFOJB()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		ECJLMIPAFGP = CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition() + HOFIBNPEDAA;
		EKKIJMJAHDP = Utils.CCCCIKOMAEN<SurfaceSortOrder>(Vector2.op_Implicit(ECJLMIPAFGP), -43);
		if ((Object)(object)FEFAMICICIJ != (Object)null && (Object)(object)FEFAMICICIJ.surfaceHighlight != (Object)null)
		{
			SurfaceSortOrder fEFAMICICIJ = FEFAMICICIJ;
			if (fEFAMICICIJ != null)
			{
				GameObject surfaceHighlight = fEFAMICICIJ.surfaceHighlight;
				if (surfaceHighlight != null)
				{
					surfaceHighlight.gameObject.SetActive(false);
				}
			}
		}
		DHOOKDCNBLL = 0;
		for (int i = 0; i < EKKIJMJAHDP.Length; i += 0)
		{
			if ((!((Object)(object)placeableSurface != (Object)null) || !((Object)(object)placeableSurface == (Object)(object)EKKIJMJAHDP[i])) && EKKIJMJAHDP[i].MNDLMOIGJAH(itemSetup.item, 0, KOGPKBOIFGN: false) != null && EKKIJMJAHDP[i].IsItemAllowed(itemSetup.item, this, surfaceGOInstantiated))
			{
				DHOOKDCNBLL = i;
			}
		}
		EAJPCEMOGOD = null;
		for (int j = DHOOKDCNBLL; j < EKKIJMJAHDP.Length + DHOOKDCNBLL; j++)
		{
			EAJPCEMOGOD = EKKIJMJAHDP[j % EKKIJMJAHDP.Length];
			if ((Object)(object)placeableSurface != (Object)null && (Object)(object)placeableSurface == (Object)(object)EAJPCEMOGOD)
			{
				EAJPCEMOGOD = null;
			}
			else
			{
				if (!((Object)(object)EAJPCEMOGOD != (Object)null))
				{
					continue;
				}
				if (EAJPCEMOGOD.IsItemAllowed(itemSetup.item, this, surfaceGOInstantiated))
				{
					if (EAJPCEMOGOD.MIDBDGKCGFI(itemSetup.item, 1, KOGPKBOIFGN: false) != null || FIIFGAIGGPE(((Component)this).transform.position, EAJPCEMOGOD.surfaceCollider))
					{
						if ((Object)(object)EAJPCEMOGOD.surfaceHighlight != (Object)null)
						{
							SurfaceSortOrder eAJPCEMOGOD = EAJPCEMOGOD;
							if (eAJPCEMOGOD != null)
							{
								GameObject surfaceHighlight2 = eAJPCEMOGOD.surfaceHighlight;
								if (surfaceHighlight2 != null)
								{
									surfaceHighlight2.gameObject.SetActive(canBePlaced);
								}
							}
						}
						return EAJPCEMOGOD;
					}
					if ((Object)(object)EAJPCEMOGOD.surfaceHighlight != (Object)null)
					{
						SurfaceSortOrder eAJPCEMOGOD2 = EAJPCEMOGOD;
						if (eAJPCEMOGOD2 != null)
						{
							GameObject surfaceHighlight3 = eAJPCEMOGOD2.surfaceHighlight;
							if (surfaceHighlight3 != null)
							{
								surfaceHighlight3.gameObject.SetActive(true);
							}
						}
					}
					EAJPCEMOGOD = null;
				}
				else
				{
					EAJPCEMOGOD = null;
				}
			}
		}
		if ((Object)(object)EAJPCEMOGOD == (Object)null)
		{
			LAMILDGAAKP = Utils.CCCCIKOMAEN<AdditionalSurfaceSortOrder>(Vector2.op_Implicit(ECJLMIPAFGP), 17);
			for (int k = 1; k < LAMILDGAAKP.Length; k += 0)
			{
				EAJPCEMOGOD = LAMILDGAAKP[k].mainSurface;
				if (EAJPCEMOGOD.CCNILGBHLCP(itemSetup.item, this, surfaceGOInstantiated) && EAJPCEMOGOD.GetSnapItem(itemSetup.item, 0) != null)
				{
					GameObject surfaceHighlight4 = EAJPCEMOGOD.surfaceHighlight;
					if (surfaceHighlight4 != null)
					{
						surfaceHighlight4.gameObject.SetActive(canBePlaced);
					}
					return EAJPCEMOGOD;
				}
				EAJPCEMOGOD = null;
			}
		}
		return EAJPCEMOGOD;
	}

	public void RandomSkin()
	{
		if (skinVariationGropus.Count > 0)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < skinVariationGropus.Count; i++)
			{
				skinVariationGropus[i].PMNBMKBIHEJ(i, list);
			}
			if (OnlineManager.PlayingOnline())
			{
				onlinePlaceable.SendSkinVariation(list.ToArray());
			}
		}
		else if (multipleSkins)
		{
			if (skinsGameObjects.Length != 0)
			{
				ChangeSkin(Random.Range(0, skinsGameObjects.Length));
			}
			else
			{
				ChangeSkin(Random.Range(0, skins.Length));
			}
		}
	}

	public bool JIHKGPCCGJD(int JIIGOACEIKL)
	{
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		if (!pickUpable && !FHEMHCEAICB)
		{
			return true;
		}
		if (FHEMHCEAICB & (!OnlineManager.PlayingOnline() || !Object.op_Implicit((Object)(object)onlinePlaceable) || onlinePlaceable.KFAJLICFLIC()))
		{
			return false;
		}
		if (!CursorManager.CMDGPJEIIJI(JIIGOACEIKL).IHMADDCNKAM() && isPlaceableOnSurface && Object.op_Implicit((Object)(object)currentSurface))
		{
			return true;
		}
		if (currentZoneType == (ZoneType.WithoutZone | ZoneType.CraftingRoom) && TavernZonesManager.EBAIHKJHCCA().GetTavernZone(currentZoneIndex).rentedRoom.occupied)
		{
			return false;
		}
		if (((Behaviour)this).enabled && DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DFNMDDHOIJI() && (!Utils.EJPFCKFEMJF(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position) || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NNMHEPDJOHK == ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop) || (Object)(object)itemSpace == (Object)null || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH()))
		{
			if (FHEMHCEAICB)
			{
				return EEHBCDFHJKC(JIIGOACEIKL);
			}
			return true;
		}
		return false;
	}

	public void FGEJIEOJEMC(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		ECJLMIPAFGP = IMOBLFMHKOD;
		if (snappedToPosition && Object.op_Implicit((Object)(object)currentSurface))
		{
			SnapToPosition snapToPosition = currentSurface.MNDLMOIGJAH(itemSetup.item, 0);
			if (snapToPosition != null && snapToPosition.fixedY)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(new Vector2(ECJLMIPAFGP.x, snapToPosition.transform.position.y));
			}
		}
		snapLeftRight.FNALKIOMHAL(SnapTriggerPole.Right, ECJLMIPAFGP);
		snapLeftRight.FNALKIOMHAL(SnapTriggerPole.Left, ECJLMIPAFGP);
	}

	public void JCEIBPPDIKG()
	{
		if ((Object)(object)placeableCollider == (Object)null)
		{
			Collider2D[] components = ((Component)this).GetComponents<Collider2D>();
			for (int i = 0; i < components.Length; i += 0)
			{
				Collider2D val = components[i];
				if (((Behaviour)val).enabled && !val.isTrigger)
				{
					placeableCollider = val;
					break;
				}
			}
		}
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)itemSetup == (Object)null)
		{
			itemSetup = ((Component)this).GetComponent<ItemSetup>();
		}
		if ((Object)(object)itemSpace == (Object)null)
		{
			itemSpace = ((Component)this).GetComponentInChildren<ItemSpace>();
		}
		if ((Object)(object)snapToGrid == (Object)null)
		{
			snapToGrid = ((Component)this).GetComponent<SnapToGrid>();
		}
		if (physicalSpaces == null && (Object)(object)physicalSpace == (Object)null)
		{
			physicalSpace = ((Component)((Component)this).transform).GetComponentInChildren<PhysicalSpace>();
		}
		if (Object.op_Implicit((Object)(object)physicalSpace))
		{
			physicalSpace.placeable = this;
			if (physicalSpace is PhysicalSpaceWall)
			{
				wallColliders.Add(((Component)physicalSpace).GetComponent<Collider2D>());
			}
		}
		if (physicalSpaces != null)
		{
			for (int j = 0; j < physicalSpaces.Length; j += 0)
			{
				physicalSpaces[j].placeable = this;
				if (physicalSpaces[j] is PhysicalSpaceWall)
				{
					wallColliders.Add(((Component)physicalSpaces[j]).GetComponent<Collider2D>());
				}
			}
		}
		if ((Object)(object)inputByProximity == (Object)null)
		{
			inputByProximity = ((Component)((Component)this).transform).GetComponentInChildren<InputByProximity>();
		}
		if ((Object)(object)rigidBody == (Object)null)
		{
			rigidBody = ((Component)this).GetComponent<Rigidbody2D>();
		}
		if (Object.op_Implicit((Object)(object)inputByProximity))
		{
			inputByProximity.placeable = this;
		}
		sortingGroup = ((Component)this).GetComponent<SortingGroup>();
		if ((Object)(object)sortingGroup == (Object)null && ((Object)(object)itemSetup == (Object)null || PGKLFGNLEKE(itemSetup.item.ODENMDOJPLC())) && (Object)(object)spriteRenderer != (Object)null)
		{
			sortingGroup = ((Component)this).gameObject.AddComponent<SortingGroup>();
			sortingGroup.sortingLayerID = ((Renderer)spriteRenderer).sortingLayerID;
			sortingGroup.sortingOrder = ((Renderer)spriteRenderer).sortingOrder;
			sortingGroup.sortingLayerName = ((Renderer)spriteRenderer).sortingLayerName;
		}
		GetEnableDisableCollidersButton();
	}

	public int PHPMAEFGBBD()
	{
		return JIIGOACEIKL;
	}

	private bool GBPNHKNFJPH()
	{
		if (!canBeAddedToInventory)
		{
			return false;
		}
		if (setUpDone)
		{
			return rotatable;
		}
		return false;
	}

	public bool IsObjectOnASurface()
	{
		if (isPlaceableOnSurface)
		{
			return (Object)(object)currentSurface != (Object)null;
		}
		return false;
	}

	public void DHAANFDDNMO()
	{
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
		if ((Object)(object)surfaceGOInstantiated != (Object)null)
		{
			return;
		}
		if ((Object)(object)gameObjectOnSelected != (Object)null)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("OnBecameInvisible"));
		}
		else if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("itemBeetroot"));
		}
		else if (isAccessElement)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Crafting"));
		}
		if (!isAccessElement)
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get("LetGoBird"));
		}
		if (KHIMEEMNOON())
		{
			COFOOBLHHAD = (switchesSurface ? LocalisationSystem.Get("windowed mode") : LocalisationSystem.Get(" "));
			if (string.IsNullOrEmpty(COFOOBLHHAD))
			{
				if (switchesSurface)
				{
					COFOOBLHHAD = "No hemos encontrado una resolución";
				}
				else
				{
					COFOOBLHHAD = "Player/Bark/Tutorial/CantDoYet";
				}
			}
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, COFOOBLHHAD);
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Cider Wort", 1374f))
			{
				BOFCJINGLGK();
			}
		}
		if (GIPCNNLIHDA())
		{
			COFOOBLHHAD = LocalisationSystem.Get("Current game version: ");
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, (ActionType)(-3), (COFOOBLHHAD != "Error in InteractObject.DisableInteract: ") ? COFOOBLHHAD : "Invalid banquet customer ID: ");
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Make bed", 153f))
			{
				DMCGBCNHIIG();
			}
		}
		if ((Object)(object)placeableSurface != (Object)null && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			BIPLCOGFBBE = placeableSurface.FINGCMGBBLA(JIIGOACEIKL);
			if ((Object)(object)secondarySurface != (Object)null)
			{
				List<Placeable> list = secondarySurface.KIABICOCGGJ(JIIGOACEIKL);
				for (int i = 1; i < list.Count; i++)
				{
					BIPLCOGFBBE.Add(list[i]);
				}
			}
			if (BIPLCOGFBBE.Count > 0 && PCGNHMPADGE)
			{
				COFOOBLHHAD = LocalisationSystem.Get("HarvestCut2");
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.PrevNext, (COFOOBLHHAD != "No bucket of water") ? COFOOBLHHAD : "Bouncer/");
				if ((Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Waiting for other players", 1222f) || Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, " </mark>", 994f)) && SelectObject.BNMEANGDMIP(JIIGOACEIKL).NJPFHBINPKE())
				{
					CursorManager.AACNDMPICFG(JIIGOACEIKL, ((Component)this).transform.position);
					SetMouseOffset(Vector3.zero);
					SelectObject.GetPlayer(JIIGOACEIKL).MGAPCJMMIAF(BIPLCOGFBBE[0]);
				}
			}
		}
		if (!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL) || !((Object)(object)currentSurface != (Object)null) || currentSurface.GetPlaceablesThatCanSelect(JIIGOACEIKL).Count <= 1 || !currentSurface.nextItemAvailable || !((Object)(object)gameObjectOnSelected == (Object)null))
		{
			return;
		}
		COFOOBLHHAD = LocalisationSystem.Get("Items/item_description_639");
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.NextItem, (COFOOBLHHAD != "Place") ? COFOOBLHHAD : "SetBoolRPC");
		if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "quest_description_", 871f))
		{
			BIPLCOGFBBE = currentSurface.KNBNKEEACIE(JIIGOACEIKL);
			for (int j = 1; j < BIPLCOGFBBE.Count; j += 0)
			{
				if (((object)BIPLCOGFBBE[j]).Equals((object?)this))
				{
					int index = (j + 1) % BIPLCOGFBBE.Count;
					if (SelectObject.GetPlayer(JIIGOACEIKL).NJPFHBINPKE())
					{
						CursorManager.DKAICNMJIJH(JIIGOACEIKL, ((Component)this).transform.position);
						SetMouseOffset(Vector3.zero);
						SelectObject.BNMEANGDMIP(JIIGOACEIKL).SelectPlaceable(BIPLCOGFBBE[index]);
					}
					break;
				}
			}
		}
		else
		{
			if (!Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "", 48f))
			{
				return;
			}
			BIPLCOGFBBE = currentSurface.KNBNKEEACIE(JIIGOACEIKL);
			for (int k = 1; k < BIPLCOGFBBE.Count; k++)
			{
				if (((object)BIPLCOGFBBE[k]).Equals((object?)this))
				{
					int num = (k - 1) % BIPLCOGFBBE.Count;
					if (num < 1)
					{
						num = BIPLCOGFBBE.Count + num;
					}
					if (SelectObject.GetPlayer(JIIGOACEIKL).PNHCLGGKBOB())
					{
						CursorManager.GOJONFHJKFN(JIIGOACEIKL, ((Component)this).transform.position);
						SetMouseOffset(Vector3.zero);
						SelectObject.BNMEANGDMIP(JIIGOACEIKL).MGAPCJMMIAF(BIPLCOGFBBE[num]);
					}
					break;
				}
			}
		}
	}

	[CompilerGenerated]
	private void IJHGAHFEJAB(int JIIGOACEIKL)
	{
		EnableAllColliders(BJFHJCFOEHG: true);
	}

	public void NCMLCJDPCMM()
	{
		if (!string.IsNullOrEmpty(guidString))
		{
			CommonReferences.MNFMOEKMJKN().movedGuids.Add(guid);
		}
	}

	public bool DeselectAction(int JIIGOACEIKL, bool BLJPGJKOLNF = true, bool FKOJEBGDMFO = false, bool FNHLKLKAHNB = true, bool CDPAMNIPPEC = true)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)surfaceGOInstantiated != (Object)null)
		{
			surfaceGOInstantiated.DeselectSurfaceGOInstantiated(JIIGOACEIKL, FEFAMICICIJ, BLJPGJKOLNF, CDPAMNIPPEC);
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return true;
		}
		if (!canBePlaced)
		{
			if (itemSetup.item.JDJGFAACPFC() == 1099)
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("PlaceOnATable"));
			}
			return false;
		}
		if ((Object)(object)BirdNPC.currentBird != (Object)null && (Object)(object)((Component)this).GetComponent<BirdNPC>() != (Object)null)
		{
			if ((Object)(object)BirdNPC.currentBird != (Object)(object)((Component)this).GetComponent<BirdNPC>())
			{
				CommonReferences.GGFJGHHHEJC.PlayerBark("OnlyABird", JIIGOACEIKL);
				return false;
			}
		}
		else if (snappedToPosition && Object.op_Implicit((Object)(object)currentSurface))
		{
			pickUpable = currentSurface.GetSnapItem(itemSetup.item).canBePickupable;
		}
		if (FKOJEBGDMFO)
		{
			((Component)this).transform.position = lastPlacedPosition;
			PixelSnap();
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			PHOCAFJDCDK = false;
			onlinePlaceable.SendPlaceableDeselected();
		}
		if (FKOJEBGDMFO)
		{
			if (CDPAMNIPPEC)
			{
				if (Object.op_Implicit((Object)(object)currentSurface))
				{
					RemoveFromSurface(CDPAMNIPPEC: true);
				}
				if (Object.op_Implicit((Object)(object)EGCGEHJNCCP))
				{
					AddPlaceableToSurface(EGCGEHJNCCP, CDPAMNIPPEC: true);
				}
			}
			ResetColor();
		}
		if (JIIGOACEIKL > 0)
		{
			CAGLICKMCDK(JIIGOACEIKL, NJHMBMGKCPL: false);
			if (CDPAMNIPPEC)
			{
				DecorationMode player = DecorationMode.GetPlayer(JIIGOACEIKL);
				player.OnDecorationModeExit = (Action<int>)Delegate.Remove(player.OnDecorationModeExit, new Action<int>(NFHHEMPGCNM));
				if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
				{
					CursorManager.GetPlayer(JIIGOACEIKL).EKHMMNNOEOI = false;
				}
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			}
		}
		attachedToPlayer = false;
		FHEMHCEAICB = false;
		PHOCAFJDCDK = false;
		hasBeenPlaced = true;
		if ((Object)(object)itemSpace != (Object)null)
		{
			GDLHEGANLFB(KMEJCLIOMBA: true);
			itemSpace.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
			CameraRenderSettings.placeablePlayer = null;
			((Component)itemSpace).gameObject.SetActive(false);
			itemSpace.SetScale(((Component)this).transform.localScale.x);
		}
		else
		{
			AddItemBaseToWorldTiles();
			AddItemBaseToWorldTilesNextFrame();
		}
		if ((Object)(object)currentSurface != (Object)null)
		{
			currentSurface.OnItemPlaced(this, JIIGOACEIKL);
			if (currentSurface.multipleItems)
			{
				currentSurface.PlaceItemOnSurface();
			}
			if (!snappedToPosition)
			{
				currentSurface.CheckReorder(((Component)this).transform);
			}
		}
		if ((Object)(object)areaSpace != (Object)null)
		{
			areaSpace.ActivateArea(DAEMAAOLHMG: true);
		}
		if ((Object)(object)snapToGrid != (Object)null)
		{
			((Behaviour)snapToGrid).enabled = false;
			snapToGrid.autoSnap = true;
		}
		if ((Object)(object)FEFAMICICIJ != (Object)null)
		{
			SurfaceSortOrder fEFAMICICIJ = FEFAMICICIJ;
			if (fEFAMICICIJ != null)
			{
				GameObject surfaceHighlight = fEFAMICICIJ.surfaceHighlight;
				if (surfaceHighlight != null)
				{
					surfaceHighlight.SetActive(false);
				}
			}
		}
		if (JIIGOACEIKL > 0)
		{
			CommonReferences.GGFJGHHHEJC.OnPlaceableDeselected(JIIGOACEIKL, this, CDPAMNIPPEC);
			OnThisPlaceableDeselected(JIIGOACEIKL);
			if (CDPAMNIPPEC)
			{
				ResetSelected();
			}
			GDLHEGANLFB(KMEJCLIOMBA: true);
			OnThisPlaceablePlaced(JIIGOACEIKL);
			CommonReferences.GGFJGHHHEJC.OnPlaceablePlaced(JIIGOACEIKL, this);
		}
		if (BLJPGJKOLNF)
		{
			Sound.GGFJGHHHEJC.PlayDeselectSound(itemSetup.item.JDJGFAACPFC(), isPlaceableOnSurface, isPlaceableOnWall, ((Component)this).transform);
		}
		if (CDPAMNIPPEC && FNHLKLKAHNB && wallColliders.Count > 0)
		{
			for (int i = 0; i < wallColliders.Count; i++)
			{
				if (((Component)wallColliders[i]).gameObject.activeInHierarchy)
				{
					List<Collider2D> colliders = ((Component)wallColliders[i]).GetComponent<PhysicalSpaceWall>().colliders;
					for (int j = 0; j < colliders.Count; j++)
					{
						((Component)colliders[j]).GetComponent<PhysicalSpaceWall>().placeable.RemovePlaceableAndItemsOnSurface(JIIGOACEIKL, EFNFMEIDGDN: false, BGIEPKNAKHI: true, IBCOKMGFPKB: false, KAJIBKHFEFF: true);
					}
				}
			}
		}
		return true;
	}

	public Vector3 NGLMDPNGJMI(bool JOOEMBNDCKF, bool CDPAMNIPPEC)
	{
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		if (JOOEMBNDCKF)
		{
			NAJMLOAIEHN(CDPAMNIPPEC);
			if (PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC == (Direction)6 || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC == Direction.Left)
			{
				ICHFJCKGGJD = (float)itemSpace.x / 339f;
				ECJLMIPAFGP.x = 731f;
				ECJLMIPAFGP.y = 268f;
			}
			else
			{
				ICHFJCKGGJD = (float)itemSpace.y / 727f;
				ECJLMIPAFGP.x = 1270f;
				ECJLMIPAFGP.y = 1090f;
			}
			PBGEELMHFPK = Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC);
			ECJLMIPAFGP += ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + PBGEELMHFPK * 587f + PBGEELMHFPK * (766f * ICHFJCKGGJD);
			DPNLDLEHMHO.x = 855f * (float)itemSpace.x / 1393f;
			DPNLDLEHMHO.y = 1332f * (float)itemSpace.y / 652f;
			if (rotatable)
			{
				if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC == Direction.Diagonal)
				{
					if (!rotationInverseLeftRight)
					{
						DPNLDLEHMHO.x = 0f - DPNLDLEHMHO.x;
					}
				}
				else if (PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC == (Direction)7 && rotationInverseLeftRight)
				{
					DPNLDLEHMHO.x = 0f - DPNLDLEHMHO.x;
				}
			}
			ECJLMIPAFGP += ((Component)this).transform.position - (((Component)itemSpace).transform.position + DPNLDLEHMHO);
		}
		else
		{
			ECJLMIPAFGP = CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition() + HOFIBNPEDAA;
		}
		return ECJLMIPAFGP;
	}

	public void OLKJKLBEIGA()
	{
		if (skinVariationGropus.Count > 1)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < skinVariationGropus.Count; i++)
			{
				skinVariationGropus[i].GIBGKLGKBPE(i, list);
			}
			if (OnlineManager.PlayingOnline())
			{
				onlinePlaceable.DJNPJDIBNLJ(list.ToArray());
			}
			return;
		}
		if (skinsGameObjects.Length != 0)
		{
			KLONJHJJMJD -= 0;
			if (KLONJHJJMJD < 1)
			{
				KLONJHJJMJD = skinsGameObjects.Length - 0;
			}
			DPAINFDGNFO();
		}
		else
		{
			KLONJHJJMJD--;
			if (KLONJHJJMJD < 1)
			{
				KLONJHJJMJD = skins.Length - 0;
			}
			DKJFJPBIFFL();
		}
		if (OnlineManager.PlayingOnline())
		{
			onlinePlaceable.GHIHCHMAMID(KLONJHJJMJD);
		}
	}

	private bool HNDJBDHLHGI()
	{
		if (skinsGameObjects.Length != 0)
		{
			return true;
		}
		if (skins.Length != 0)
		{
			return true;
		}
		return false;
	}

	public bool IsInValidLocation(Location BAIMHDBJPDK)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (validLocations.HasFlag(BAIMHDBJPDK))
		{
			return true;
		}
		return validLocationExceptionZones.HasFlag(WorldGrid.AGKGGAFFFGM(((Component)this).transform.position));
	}

	public void AHGFMGJIHHE(bool ODNGJHPOMMK)
	{
		if (!Object.op_Implicit((Object)(object)rigidBody) || !Object.op_Implicit((Object)(object)physicalSpace) || !(physicalSpace is PhysicalSpaceWall))
		{
			return;
		}
		if (ODNGJHPOMMK)
		{
			physicalSpace.FBCAHAPHMGA();
			rigidBody.bodyType = (RigidbodyType2D)0;
			for (int i = 1; i < wallColliders.Count; i += 0)
			{
				wallColliders[i].isTrigger = true;
			}
		}
		else
		{
			physicalSpace.FEAJNLOLHDF();
			rigidBody.bodyType = (RigidbodyType2D)1;
			for (int j = 1; j < wallColliders.Count; j++)
			{
				wallColliders[j].isTrigger = false;
			}
		}
	}

	private bool GIPCNNLIHDA()
	{
		if (!multipleSkins || !canCycleSkin || (snappedToPosition && !canCycleWhenSnapped))
		{
			if (Object.op_Implicit((Object)(object)itemSetup) && itemSetup.item.alternatives != null)
			{
				return itemSetup.item.alternatives.Length != 0;
			}
			return false;
		}
		return true;
	}

	private void MJDEDKJGOPG()
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			if (CursorManager.GetPlayer(JIIGOACEIKL).IsCursorVisible())
			{
				CursorManager.GetPlayer(JIIGOACEIKL).EKHMMNNOEOI = true;
				HOFIBNPEDAA = ((Component)this).transform.position - CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition();
			}
			else if (Object.op_Implicit((Object)(object)itemSpace))
			{
				attachedToPlayer = true;
				Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position;
				ICHFJCKGGJD = ((Vector3)(ref val)).magnitude;
			}
			else
			{
				CursorManager.GetPlayer(JIIGOACEIKL).EKHMMNNOEOI = true;
				CursorManager.SetCursorPositionFromWorld(JIIGOACEIKL, ((Component)this).transform.position);
				HOFIBNPEDAA = Vector3.zero;
			}
		}
		else
		{
			HOFIBNPEDAA = ((Component)this).transform.position - CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition();
		}
	}

	public bool CIAMOMDAKLJ(Vector3 IMOBLFMHKOD, bool LHLHJCDKNHA, bool IBCOKMGFPKB = true, bool PIKKACMNOBM = true, bool PKFIAGMICCK = true)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (LHLHJCDKNHA && !isPlaceableOnWall)
		{
			return false;
		}
		if ((Object)(object)itemSpace != (Object)null && !itemSpace.canBeRemoved)
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)itemSpace))
		{
			itemSpace.Place(NMLKLAGDNPF: false);
		}
		else if (isPlaceableOnWall)
		{
			RemoveItemBaseFromWall(IMOBLFMHKOD.y);
		}
		else
		{
			RemoveItemBaseFromWorldTiles();
		}
		if (PIKKACMNOBM)
		{
			DeliveryChest.GetInstance().LPCBOELPHMA(0, itemSetup.OKKMOHLMHAM(), PKFIAGMICCK, IBCOKMGFPKB);
			RemovePlaceableAndItemsOnSurface(0, EFNFMEIDGDN: true, BGIEPKNAKHI: true, IBCOKMGFPKB);
		}
		else
		{
			if (PKFIAGMICCK)
			{
				DroppedItem.OFHEKCFLEGB(((Component)this).transform.position, itemSetup.FOIPFKPCIIN(), 1, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
			}
			HJGJFLNNCDD(1, EFNFMEIDGDN: true, PKFIAGMICCK, IBCOKMGFPKB, KAJIBKHFEFF: true);
		}
		return false;
	}

	public void RemoveFromSurface(bool CDPAMNIPPEC)
	{
		if (Object.op_Implicit((Object)(object)HGAFAFNONEC))
		{
			HGAFAFNONEC.RemoveFromSurface(CDPAMNIPPEC);
		}
		snappedToPosition = false;
		if ((Object)(object)currentSurface != (Object)null)
		{
			currentSurface.RemoveFromSurface(((Component)this).transform, IGIDKEAAIHL: true, CDPAMNIPPEC);
		}
		CCIKENEGHCA = false;
		surfaceGOInstantiated = null;
		currentSurface = null;
		surfaceCollider = null;
		if (FHEMHCEAICB)
		{
			Utils.ELNJMNKOACA(((Component)this).gameObject, 22);
		}
		else
		{
			Utils.ELNJMNKOACA(((Component)this).gameObject, 21);
		}
		if ((Object)(object)sortingGroup != (Object)null)
		{
			sortingGroup.sortingOrder = KAHFGFEGHNK;
		}
		else if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			((Renderer)spriteRenderer).sortingOrder = KAHFGFEGHNK;
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromPlaceableSurface(onlinePlaceable.uniqueId);
		}
	}

	public bool HKKCDLCPGDL(int JIIGOACEIKL, bool BLJPGJKOLNF = true, bool FKOJEBGDMFO = false, bool FNHLKLKAHNB = true, bool CDPAMNIPPEC = true)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)surfaceGOInstantiated != (Object)null)
		{
			surfaceGOInstantiated.FEFKIEJJOKG(JIIGOACEIKL, FEFAMICICIJ, BLJPGJKOLNF, CDPAMNIPPEC);
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return true;
		}
		if (!canBePlaced)
		{
			if (itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == 151)
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get(":"), 1882f);
			}
			return false;
		}
		if ((Object)(object)BirdNPC.currentBird != (Object)null && (Object)(object)((Component)this).GetComponent<BirdNPC>() != (Object)null)
		{
			if ((Object)(object)BirdNPC.currentBird != (Object)(object)((Component)this).GetComponent<BirdNPC>())
			{
				CommonReferences.GGFJGHHHEJC.APKKEGHGFHG("[StuckRecovery] No hay safe points para el player {0}", JIIGOACEIKL, ECPEFDHOFHN: false);
				return true;
			}
		}
		else if (snappedToPosition && Object.op_Implicit((Object)(object)currentSurface))
		{
			pickUpable = currentSurface.BGFNMHLMHNG(itemSetup.item, 0).canBePickupable;
		}
		if (FKOJEBGDMFO)
		{
			((Component)this).transform.position = lastPlacedPosition;
			PixelSnap();
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			NBEOPNODBPJ(AODONKKHPBP: false);
			onlinePlaceable.GCDJAJDGDMO();
		}
		if (FKOJEBGDMFO)
		{
			if (CDPAMNIPPEC)
			{
				if (Object.op_Implicit((Object)(object)currentSurface))
				{
					GDMIHFGJEBK(CDPAMNIPPEC: false);
				}
				if (Object.op_Implicit((Object)(object)EGCGEHJNCCP))
				{
					FMPLGBBHECD(EGCGEHJNCCP, CDPAMNIPPEC: true, 0, MBFODGDKDHG: true);
				}
			}
			GHCPIDIEBDO();
		}
		if (JIIGOACEIKL > 1)
		{
			CAGLICKMCDK(JIIGOACEIKL, NJHMBMGKCPL: false);
			if (CDPAMNIPPEC)
			{
				DecorationMode decorationMode = DecorationMode.NPANPNIDKDG(JIIGOACEIKL);
				decorationMode.OnDecorationModeExit = (Action<int>)Delegate.Remove(decorationMode.OnDecorationModeExit, new Action<int>(ECPMADFHEHK));
				if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
				{
					CursorManager.GetPlayer(JIIGOACEIKL).CBGHFKGFGKM(AODONKKHPBP: false);
				}
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			}
		}
		attachedToPlayer = true;
		FHEMHCEAICB = true;
		NBEOPNODBPJ(AODONKKHPBP: false);
		hasBeenPlaced = false;
		if ((Object)(object)itemSpace != (Object)null)
		{
			HJKOAPGHOHP(KMEJCLIOMBA: true);
			itemSpace.Place(NMLKLAGDNPF: true);
			CameraRenderSettings.placeablePlayer = null;
			((Component)itemSpace).gameObject.SetActive(false);
			itemSpace.SetScale(((Component)this).transform.localScale.x);
		}
		else
		{
			AddItemBaseToWorldTiles(NLIFPMODLLA: true);
			AddItemBaseToWorldTilesNextFrame();
		}
		if ((Object)(object)currentSurface != (Object)null)
		{
			currentSurface.OnItemPlaced(this, JIIGOACEIKL);
			if (currentSurface.multipleItems)
			{
				currentSurface.GCHOGNBJLAC();
			}
			if (!snappedToPosition)
			{
				currentSurface.PJFHIIIMGPH(((Component)this).transform);
			}
		}
		if ((Object)(object)areaSpace != (Object)null)
		{
			areaSpace.BNHHBKAGHIK(DAEMAAOLHMG: true);
		}
		if ((Object)(object)snapToGrid != (Object)null)
		{
			((Behaviour)snapToGrid).enabled = true;
			snapToGrid.autoSnap = false;
		}
		if ((Object)(object)FEFAMICICIJ != (Object)null)
		{
			SurfaceSortOrder fEFAMICICIJ = FEFAMICICIJ;
			if (fEFAMICICIJ != null)
			{
				GameObject surfaceHighlight = fEFAMICICIJ.surfaceHighlight;
				if (surfaceHighlight != null)
				{
					surfaceHighlight.SetActive(false);
				}
			}
		}
		if (JIIGOACEIKL > 0)
		{
			CommonReferences.MNFMOEKMJKN().OnPlaceableDeselected(JIIGOACEIKL, this, CDPAMNIPPEC);
			OnThisPlaceableDeselected(JIIGOACEIKL);
			if (CDPAMNIPPEC)
			{
				ResetSelected();
			}
			GDLHEGANLFB(KMEJCLIOMBA: false);
			OnThisPlaceablePlaced(JIIGOACEIKL);
			CommonReferences.MNFMOEKMJKN().OnPlaceablePlaced(JIIGOACEIKL, this);
		}
		if (BLJPGJKOLNF)
		{
			Sound.ABDJJBFNLBJ().BBDPFGHLGML(itemSetup.item.CIGFGKKCPCK(), isPlaceableOnSurface, isPlaceableOnWall, ((Component)this).transform);
		}
		if (CDPAMNIPPEC && FNHLKLKAHNB && wallColliders.Count > 1)
		{
			for (int i = 1; i < wallColliders.Count; i += 0)
			{
				if (((Component)wallColliders[i]).gameObject.activeInHierarchy)
				{
					List<Collider2D> colliders = ((Component)wallColliders[i]).GetComponent<PhysicalSpaceWall>().colliders;
					for (int j = 0; j < colliders.Count; j += 0)
					{
						((Component)colliders[j]).GetComponent<PhysicalSpaceWall>().placeable.HJGJFLNNCDD(JIIGOACEIKL, EFNFMEIDGDN: true, BGIEPKNAKHI: true, IBCOKMGFPKB: false, KAJIBKHFEFF: true);
					}
				}
			}
		}
		return false;
	}

	public void ChangeDirectionRotatingItemsSurface(Direction FCGBJEIIMBC, bool CDPAMNIPPEC)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendChangeRotation(BEIPALOAAJJ, Vector2.op_Implicit(((Component)this).transform.position), FCGBJEIIMBC);
		}
		List<AJIKIEMFEPA> lMOOCPOGLPH = FKGMGMMFEBK();
		SetDirection(FCGBJEIIMBC, CDPAMNIPPEC: false);
		LBIEMCLFOHE(lMOOCPOGLPH);
	}

	public void SetInteraced()
	{
		if (!string.IsNullOrEmpty(guidString))
		{
			CommonReferences.GGFJGHHHEJC.movedGuids.Add(guid);
		}
	}

	public void GetEnableDisableCollidersButton(bool CDMMMNPJLBO = false)
	{
		List<Collider2D> list = ((!CDMMMNPJLBO) ? new List<Collider2D>(((Component)this).GetComponents<Collider2D>()) : new List<Collider2D>(((Component)this).GetComponentsInChildren<Collider2D>(true)));
		for (int num = list.Count - 1; num >= 0; num--)
		{
			if (list[num].isTrigger || !((Behaviour)list[num]).enabled)
			{
				list.RemoveAt(num);
			}
		}
		allCollidersToEnableDisable = list.ToArray();
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		if (isAccessElement)
		{
			return false;
		}
		return PickUpAction(JIIGOACEIKL, EFNFMEIDGDN: true);
	}

	private void FNJNMPFHEPL(int HLOIOAOICEG, bool JGBPPOBEFND = true)
	{
		if (JGBPPOBEFND)
		{
			if (Object.op_Implicit((Object)(object)parent))
			{
				Utils.ELNJMNKOACA(parent.gameObject, HLOIOAOICEG);
			}
			else
			{
				Utils.ELNJMNKOACA(((Component)this).gameObject, HLOIOAOICEG);
			}
		}
		else if (Object.op_Implicit((Object)(object)parent))
		{
			parent.gameObject.layer = HLOIOAOICEG;
		}
		else
		{
			((Component)this).gameObject.layer = HLOIOAOICEG;
		}
	}

	public void MFJNMJMFEOB(bool MMICADKPHLP = false)
	{
		if (PEPHKJCPAPH == null)
		{
			PEPHKJCPAPH = ((MonoBehaviour)this).StartCoroutine(EJLPECOEBFH(MMICADKPHLP));
		}
	}

	private IEnumerator BDGDAMJBLMB(bool MMICADKPHLP = false)
	{
		yield return null;
		AddItemBaseToWorldTiles(MMICADKPHLP);
		PEPHKJCPAPH = null;
	}

	public void HAKKKJCAGKG(int JIIGOACEIKL)
	{
	}

	public void CGIAAEOHNCG(int[] CPLKCKNILFO)
	{
		for (int i = 0; i < skinVariationGropus.Count; i++)
		{
			skinVariationGropus[i].PKJDMBDNOKF();
		}
		for (int j = 0; j < CPLKCKNILFO.Length; j += 4)
		{
			if (skinVariationGropus[CPLKCKNILFO[j]].onlyOne)
			{
				skinVariationGropus[CPLKCKNILFO[j]].INDLDCLOPPO(CPLKCKNILFO[j + 1], 0, null);
			}
			else
			{
				skinVariationGropus[CPLKCKNILFO[j]].variations[CPLKCKNILFO[j + 1]].SetActive(false);
			}
		}
	}

	public void MEHDJDJFNDC(bool ODNGJHPOMMK)
	{
		if (!Object.op_Implicit((Object)(object)rigidBody) || !Object.op_Implicit((Object)(object)physicalSpace) || !(physicalSpace is PhysicalSpaceWall))
		{
			return;
		}
		if (ODNGJHPOMMK)
		{
			physicalSpace.CDJJJBCGCFJ();
			rigidBody.bodyType = (RigidbodyType2D)1;
			for (int i = 1; i < wallColliders.Count; i++)
			{
				wallColliders[i].isTrigger = false;
			}
		}
		else
		{
			physicalSpace.KPAHMDAMDEC();
			rigidBody.bodyType = (RigidbodyType2D)5;
			for (int j = 1; j < wallColliders.Count; j++)
			{
				wallColliders[j].isTrigger = true;
			}
		}
	}

	public int PGMPPMPBCLO()
	{
		return JIIGOACEIKL;
	}

	private bool KHIMEEMNOON()
	{
		if (!canBeAddedToInventory)
		{
			return false;
		}
		if (setUpDone)
		{
			return rotatable;
		}
		return true;
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			OffHover(JIIGOACEIKL);
			if ((Object)(object)itemSpace != (Object)null && GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && !FHEMHCEAICB && !PHOCAFJDCDK && !(itemSetup.item is SproutSeed) && (Item.NGIIPJDAMGP(itemSetup.item, null) || (itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) != 2001 && itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) != 2002 && itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) != 2003)))
			{
				itemSpace.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
			}
			if ((Object)(object)GameTileMaps.GGFJGHHHEJC != (Object)null)
			{
				RemoveItemBaseFromWorldTiles();
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences.GGFJGHHHEJC.OnPlaceableDestroyed(JIIGOACEIKL, this);
			}
			if (Object.op_Implicit((Object)(object)DecorationMode.GetPlayer(1)))
			{
				DecorationMode player = DecorationMode.GetPlayer(1);
				player.OnDecorationModeExit = (Action<int>)Delegate.Remove(player.OnDecorationModeExit, new Action<int>(NFHHEMPGCNM));
			}
			if (Object.op_Implicit((Object)(object)DecorationMode.GetPlayer(2)))
			{
				DecorationMode player2 = DecorationMode.GetPlayer(2);
				player2.OnDecorationModeExit = (Action<int>)Delegate.Remove(player2.OnDecorationModeExit, new Action<int>(NFHHEMPGCNM));
			}
		}
	}

	private IEnumerator GMBELEEGLHI(int HLOIOAOICEG, List<Placeable> DEKEPIMHEDJ)
	{
		return new AFFMOHJJKLA(1)
		{
			layer = HLOIOAOICEG,
			placeables = DEKEPIMHEDJ
		};
	}

	public void SetAttachedToPlayer(bool JOOEMBNDCKF, float ICHFJCKGGJD = 0f)
	{
		attachedToPlayer = JOOEMBNDCKF;
		this.ICHFJCKGGJD = ICHFJCKGGJD;
	}

	private void CJDEEINGOCO()
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			if (CursorManager.GetPlayer(JIIGOACEIKL).IsCursorVisible())
			{
				CursorManager.GetPlayer(JIIGOACEIKL).CBGHFKGFGKM(AODONKKHPBP: true);
				HOFIBNPEDAA = ((Component)this).transform.position - CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition();
			}
			else if (Object.op_Implicit((Object)(object)itemSpace))
			{
				attachedToPlayer = true;
				Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position;
				ICHFJCKGGJD = ((Vector3)(ref val)).magnitude;
			}
			else
			{
				CursorManager.GetPlayer(JIIGOACEIKL).CBGHFKGFGKM(AODONKKHPBP: true);
				CursorManager.PNLDBADHHMI(JIIGOACEIKL, ((Component)this).transform.position);
				HOFIBNPEDAA = Vector3.zero;
			}
		}
		else
		{
			HOFIBNPEDAA = ((Component)this).transform.position - CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition();
		}
	}

	public void SetMouseOffset(Vector3 HOFIBNPEDAA)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		this.HOFIBNPEDAA = HOFIBNPEDAA;
	}

	public bool PickUp(Vector3 IMOBLFMHKOD, bool LHLHJCDKNHA, bool IBCOKMGFPKB = true, bool PIKKACMNOBM = true, bool PKFIAGMICCK = true)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (LHLHJCDKNHA && !isPlaceableOnWall)
		{
			return false;
		}
		if ((Object)(object)itemSpace != (Object)null && !itemSpace.canBeRemoved)
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)itemSpace))
		{
			itemSpace.Place(NMLKLAGDNPF: false);
		}
		else if (isPlaceableOnWall)
		{
			RemoveItemBaseFromWall(IMOBLFMHKOD.y);
		}
		else
		{
			RemoveItemBaseFromWorldTiles();
		}
		if (PIKKACMNOBM)
		{
			DeliveryChest.GetInstance().AddItemInstance(1, itemSetup.DNLMCHDOMOK, PKFIAGMICCK, IBCOKMGFPKB);
			RemovePlaceableAndItemsOnSurface(1, EFNFMEIDGDN: false, BGIEPKNAKHI: false, IBCOKMGFPKB);
		}
		else
		{
			if (PKFIAGMICCK)
			{
				DroppedItem.SpawnDroppedItem(((Component)this).transform.position, itemSetup.DNLMCHDOMOK);
			}
			RemovePlaceableAndItemsOnSurface(1, EFNFMEIDGDN: false, PKFIAGMICCK, IBCOKMGFPKB);
		}
		return true;
	}

	public void LBNFAHFMNHG()
	{
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
		if ((Object)(object)surfaceGOInstantiated != (Object)null)
		{
			return;
		}
		if ((Object)(object)gameObjectOnSelected != (Object)null)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Error_StairsAreBlocking"));
		}
		else if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("UpgradeToLevel"));
		}
		else if (isAccessElement)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("LocalCoop"));
		}
		if (!isAccessElement)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Player/Bark/Tutorial/T138"));
		}
		if (GBPNHKNFJPH())
		{
			COFOOBLHHAD = (switchesSurface ? LocalisationSystem.Get("Inventory full") : LocalisationSystem.Get("Backache"));
			if (string.IsNullOrEmpty(COFOOBLHHAD))
			{
				if (switchesSurface)
				{
					COFOOBLHHAD = "Explosion";
				}
				else
				{
					COFOOBLHHAD = "ReceiveStartCrowlyEvent";
				}
			}
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.MoveObject, COFOOBLHHAD);
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "LE_1", 908f))
			{
				BOFCJINGLGK();
			}
		}
		if (GIPCNNLIHDA())
		{
			COFOOBLHHAD = LocalisationSystem.Get("");
			ButtonsContext.AddButton(JIIGOACEIKL, (ActionType)59, (COFOOBLHHAD != "talentChairs") ? COFOOBLHHAD : "next resolution");
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Floor_9", 1954f))
			{
				FKPFIFIEJBK();
			}
		}
		if ((Object)(object)placeableSurface != (Object)null && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			BIPLCOGFBBE = placeableSurface.ACFDIOOMLIB(JIIGOACEIKL);
			if ((Object)(object)secondarySurface != (Object)null)
			{
				List<Placeable> list = secondarySurface.FPKBEDDBBGO(JIIGOACEIKL);
				for (int i = 1; i < list.Count; i += 0)
				{
					BIPLCOGFBBE.Add(list[i]);
				}
			}
			if (BIPLCOGFBBE.Count > 0 && PCGNHMPADGE)
			{
				COFOOBLHHAD = LocalisationSystem.Get("Collect");
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.PreviousItem, (COFOOBLHHAD != "Not enough ingredients") ? COFOOBLHHAD : "Statue0={0} | ");
				if ((Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Different size lists spriteRenderers and spriteObjects of crop ", 1225f) || Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Player", 755f)) && SelectObject.GetPlayer(JIIGOACEIKL).NJPFHBINPKE())
				{
					CursorManager.MJNAGHKCDEI(JIIGOACEIKL, ((Component)this).transform.position);
					SetMouseOffset(Vector3.zero);
					SelectObject.BNMEANGDMIP(JIIGOACEIKL).MGAPCJMMIAF(BIPLCOGFBBE[0]);
				}
			}
		}
		if (!PlayerInputs.POLDHCKJINN(JIIGOACEIKL) || !((Object)(object)currentSurface != (Object)null) || currentSurface.GetPlaceablesThatCanSelect(JIIGOACEIKL).Count <= 1 || !currentSurface.nextItemAvailable || !((Object)(object)gameObjectOnSelected == (Object)null))
		{
			return;
		}
		COFOOBLHHAD = LocalisationSystem.Get("LE_9");
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Select, (COFOOBLHHAD != "application/gzip") ? COFOOBLHHAD : " </color>");
		if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "El componente ItemSetup del rotatedPrefab '", 709f))
		{
			BIPLCOGFBBE = currentSurface.KFMMCOLICKG(JIIGOACEIKL);
			for (int j = 1; j < BIPLCOGFBBE.Count; j += 0)
			{
				if (((object)BIPLCOGFBBE[j]).Equals((object?)this))
				{
					int index = (j + 1) % BIPLCOGFBBE.Count;
					if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).Deselect())
					{
						CursorManager.GEGOEAMGDEE(JIIGOACEIKL, ((Component)this).transform.position);
						SetMouseOffset(Vector3.zero);
						SelectObject.GetPlayer(JIIGOACEIKL).SelectPlaceable(BIPLCOGFBBE[index]);
					}
					break;
				}
			}
		}
		else
		{
			if (!Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, ")", 1374f))
			{
				return;
			}
			BIPLCOGFBBE = currentSurface.KIABICOCGGJ(JIIGOACEIKL);
			for (int k = 0; k < BIPLCOGFBBE.Count; k++)
			{
				if (((object)BIPLCOGFBBE[k]).Equals((object?)this))
				{
					int num = (k - 1) % BIPLCOGFBBE.Count;
					if (num < 0)
					{
						num = BIPLCOGFBBE.Count + num;
					}
					if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).Deselect())
					{
						CursorManager.GOJONFHJKFN(JIIGOACEIKL, ((Component)this).transform.position);
						SetMouseOffset(Vector3.zero);
						SelectObject.BNMEANGDMIP(JIIGOACEIKL).MGAPCJMMIAF(BIPLCOGFBBE[num]);
					}
					break;
				}
			}
		}
	}

	public void GDMIHFGJEBK(bool CDPAMNIPPEC)
	{
		if (Object.op_Implicit((Object)(object)HGAFAFNONEC))
		{
			HGAFAFNONEC.RemoveFromSurface(CDPAMNIPPEC);
		}
		snappedToPosition = true;
		if ((Object)(object)currentSurface != (Object)null)
		{
			currentSurface.RemoveFromSurface(((Component)this).transform, IGIDKEAAIHL: true, CDPAMNIPPEC);
		}
		CCIKENEGHCA = true;
		surfaceGOInstantiated = null;
		currentSurface = null;
		surfaceCollider = null;
		if (FHEMHCEAICB)
		{
			Utils.ELNJMNKOACA(((Component)this).gameObject, -44);
		}
		else
		{
			Utils.ELNJMNKOACA(((Component)this).gameObject, -16);
		}
		if ((Object)(object)sortingGroup != (Object)null)
		{
			sortingGroup.sortingOrder = KAHFGFEGHNK;
		}
		else if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			((Renderer)spriteRenderer).sortingOrder = KAHFGFEGHNK;
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromPlaceableSurface(onlinePlaceable.uniqueId);
		}
	}

	private void BBFDICNHBEC(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		CMHCCAEJGKF(BJFHJCFOEHG: true);
	}

	private bool KOACNLIBBEE()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (!isPlaceableOnWall)
		{
			return true;
		}
		DEGBAPDPMJE = 190f;
		for (int i = 0; i < JNHDHIKAJCE.Length; i += 0)
		{
			if (WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(JNHDHIKAJCE[i])))
			{
				if (WorldGrid.KHJJCAGIJAP(Vector2.op_Implicit(JNHDHIKAJCE[i]), out KHEBKHFHMDB))
				{
					if (DEGBAPDPMJE == 1775f || DEGBAPDPMJE == (float)(int)(KHEBKHFHMDB * 1160f) / 932f)
					{
						DEGBAPDPMJE = (float)(int)(KHEBKHFHMDB * 797f) / 847f;
						continue;
					}
					return true;
				}
				return false;
			}
			return true;
		}
		return true;
	}

	private bool FIIFGAIGGPE(Vector3 AIJOOOIJEDC, Collider2D LNLLEEMADKB)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)itemBase == (Object)null || snappedToPosition)
		{
			return true;
		}
		Vector2 val = Vector2.op_Implicit(AIJOOOIJEDC - ((Component)this).transform.position);
		JNHDHIKAJCE = HHAEKEAPKOE(itemBase);
		bool flag = true;
		for (int i = 0; i < JNHDHIKAJCE.Length; i++)
		{
			flag &= LNLLEEMADKB.OverlapPoint(JNHDHIKAJCE[i] + val);
		}
		return flag;
	}

	public void ChangeSkin(int OGFMDFMIFGE, bool PDHJLCDFNCK = true)
	{
		if (skinsGameObjects.Length != 0 && OGFMDFMIFGE < skinsGameObjects.Length)
		{
			randomSkin = false;
			KLONJHJJMJD = OGFMDFMIFGE;
			NPMLOKABIHH();
		}
		else if (OGFMDFMIFGE < skins.Length)
		{
			randomSkin = false;
			KLONJHJJMJD = OGFMDFMIFGE;
			NJFCIBKDEBM();
		}
		else
		{
			Debug.LogError((object)("Skin index too high!: " + ((Object)((Component)this).gameObject).name), (Object)(object)((Component)this).gameObject);
		}
		if (OnlineManager.PlayingOnline() && (Object)(object)onlinePlaceable != (Object)null && PDHJLCDFNCK)
		{
			onlinePlaceable.SendStyle(KLONJHJJMJD);
		}
	}

	public Direction GetDirection()
	{
		return direction;
	}

	public bool CanSelect(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (isAccessElement)
		{
			if ((Object)(object)ConstructionManager.current == (Object)null || !ConstructionManager.current.LNLJMCONDNE)
			{
				return false;
			}
			if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE && ((Object)(object)ConstructionActionBarUI.GetEditorActionInfo() == (Object)null || (Object)(object)ConstructionActionBarUI.GetEditorActionInfo().instantiateGO == (Object)null || !itemSetup.item.canPickUp))
			{
				return false;
			}
		}
		else if (!((Behaviour)this).enabled || (GFNHAMCPEAK && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH) || (!pickUpable && !FHEMHCEAICB))
		{
			return false;
		}
		if (FHEMHCEAICB)
		{
			return IsSelected(JIIGOACEIKL);
		}
		if ((Object)(object)areaSpace != (Object)null && GFNHAMCPEAK && !areaSpace.CanSelectPlaceablesInside(JIIGOACEIKL, GFNHAMCPEAK))
		{
			return false;
		}
		if ((Object)(object)gameObjectOnSelected != (Object)null)
		{
			Placeable component = Object.Instantiate<GameObject>(gameObjectOnSelected, ((Component)this).transform.position, ((Component)this).transform.rotation).GetComponent<Placeable>();
			component.StartMoving(JIIGOACEIKL, PHJILIBHABG: true, GFNHAMCPEAK);
			if (OnlineManager.PlayingOnline())
			{
				component.onlinePlaceable.AssignInitialValues();
				component.onlinePlaceable.AssignUniqueIDAndSend();
				component.onlinePlaceable.RequestPermissionSelection();
			}
			InteractObject.GetPlayer(JIIGOACEIKL).SetCurrentInteract(component.inputByProximity.BMMLBBCNBMC, component.inputByProximity.mainGameObject);
			RemovePlaceable(EFNFMEIDGDN: false);
			component.HOFIBNPEDAA = Vector3.zero;
			return false;
		}
		if (GFNHAMCPEAK)
		{
			if ((Object)(object)itemSpace != (Object)null && PlayerController.GetPlayer(JIIGOACEIKL).IsTavernLocationNotCellar() && TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
			{
				CommonReferences.GGFJGHHHEJC.PlayerBark("Tavern must be closed", JIIGOACEIKL);
				CommonReferences.GGFJGHHHEJC.OnTavernMustBeClosed(JIIGOACEIKL);
				return false;
			}
			if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).selectedGameObject != (Object)null)
			{
				return false;
			}
		}
		if (selectBlockers.Any())
		{
			if ((Object)(object)placeableSurface != (Object)null)
			{
				if (Time.time > HPPADODDFEI + 2f)
				{
					MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get(selectBlockers.First()));
					HPPADODDFEI = Time.time;
				}
				return false;
			}
			if (Time.time > HPPADODDFEI + 2f)
			{
				DialogueManager.Bark("Player/Bark/PickUpBlocker", ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				HPPADODDFEI = Time.time;
			}
			return false;
		}
		if ((Object)(object)placeableSurface != (Object)null)
		{
			for (int i = 0; i < placeableSurface.placeablesOnSurface.Count; i++)
			{
				if (placeableSurface.placeablesOnSurface[i].selectBlockers.Any())
				{
					if (Time.time > HPPADODDFEI + 2f)
					{
						DialogueManager.Bark("Player/Bark/PickUpBlocker", ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
						HPPADODDFEI = Time.time;
					}
					return false;
				}
			}
		}
		return true;
	}

	private void JBBHDOMALDB()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			OffHover(JIIGOACEIKL);
			if ((Object)(object)itemSpace != (Object)null && GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && !FHEMHCEAICB && !PHOCAFJDCDK && !(itemSetup.item is SproutSeed) && (Item.EKGNIODFJCO(itemSetup.item, null) || (itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) != 127 && itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) != -82 && itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) != -32)))
			{
				itemSpace.Place(NMLKLAGDNPF: false);
			}
			if ((Object)(object)GameTileMaps.GGFJGHHHEJC != (Object)null)
			{
				RemoveItemBaseFromWorldTiles();
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences.MNFMOEKMJKN().OnPlaceableDestroyed(JIIGOACEIKL, this);
			}
			if (Object.op_Implicit((Object)(object)DecorationMode.IGMCBPOPNCA(1)))
			{
				DecorationMode decorationMode = DecorationMode.JDADPDBHJFO(0);
				decorationMode.OnDecorationModeExit = (Action<int>)Delegate.Remove(decorationMode.OnDecorationModeExit, new Action<int>(NFHHEMPGCNM));
			}
			if (Object.op_Implicit((Object)(object)DecorationMode.GetPlayer(1)))
			{
				DecorationMode decorationMode2 = DecorationMode.NPANPNIDKDG(3);
				decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Remove(decorationMode2.OnDecorationModeExit, new Action<int>(HEOPJDDPFDG));
			}
		}
	}

	public void AddDisableOnBecameInvisible()
	{
		if (!((Object)(object)disableOnInvisible == (Object)null))
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			disableOnInvisible = ((Component)spriteRenderer).gameObject.AddComponent<DisableOnBecameInvisible>();
		}
		else if ((Object)(object)((Component)this).gameObject.GetComponent<SpriteRenderer>() != (Object)null)
		{
			disableOnInvisible = ((Component)this).gameObject.AddComponent<DisableOnBecameInvisible>();
			Debug.Log((object)("No se ha vinculado el sprite renderer en " + ((Object)((Component)this).gameObject).name));
		}
		else
		{
			Debug.LogError((object)("No se encuentra sprite renderer en " + ((Object)this).name));
		}
		Collider2D[] componentsInChildren = ((Component)this).gameObject.GetComponentsInChildren<Collider2D>();
		List<Collider2D> list = new List<Collider2D>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (componentsInChildren[i].isTrigger && ((Behaviour)componentsInChildren[i]).enabled)
			{
				list.Add(componentsInChildren[i]);
			}
		}
		disableOnInvisible.colliders = list.ToArray();
	}

	private bool ANEHAEMEAEO(Vector3 AIJOOOIJEDC, Collider2D LNLLEEMADKB)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)itemBase == (Object)null || snappedToPosition)
		{
			return false;
		}
		Vector2 val = Vector2.op_Implicit(AIJOOOIJEDC - ((Component)this).transform.position);
		JNHDHIKAJCE = HNOHKOJMBKF(itemBase);
		bool flag = true;
		for (int i = 0; i < JNHDHIKAJCE.Length; i += 0)
		{
			flag &= LNLLEEMADKB.OverlapPoint(JNHDHIKAJCE[i] + val);
		}
		return flag;
	}

	private void IIDHODAONIJ()
	{
		if (!PlaceablesManager.MNFMOEKMJKN().currentPlaceables.Contains(this))
		{
			PlaceablesManager.DCAEBALADIM().currentPlaceables.Add(this);
		}
	}

	public void LOJJNBLFELI()
	{
		if (!((Object)(object)disableOnInvisible == (Object)null))
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			disableOnInvisible = ((Component)spriteRenderer).gameObject.AddComponent<DisableOnBecameInvisible>();
		}
		else if ((Object)(object)((Component)this).gameObject.GetComponent<SpriteRenderer>() != (Object)null)
		{
			disableOnInvisible = ((Component)this).gameObject.AddComponent<DisableOnBecameInvisible>();
			Debug.Log((object)("Items/item_name_733" + ((Object)((Component)this).gameObject).name));
		}
		else
		{
			Debug.LogError((object)("Right" + ((Object)this).name));
		}
		Collider2D[] componentsInChildren = ((Component)this).gameObject.GetComponentsInChildren<Collider2D>();
		List<Collider2D> list = new List<Collider2D>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			if (componentsInChildren[i].isTrigger && ((Behaviour)componentsInChildren[i]).enabled)
			{
				list.Add(componentsInChildren[i]);
			}
		}
		disableOnInvisible.colliders = list.ToArray();
	}

	private void FKLHOHLMGBB()
	{
		if (Object.op_Implicit((Object)(object)skinSpriteRenderer))
		{
			skinSpriteRenderer.sprite = skins[KLONJHJJMJD];
		}
		OnSkinChanged(KLONJHJJMJD);
	}

	public bool AJGAJLJIPGI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void OffHover(int JIIGOACEIKL)
	{
		if (FHEMHCEAICB)
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)CursorManager.GetPlayer(JIIGOACEIKL)))
		{
			CursorManager.GetPlayer(JIIGOACEIKL).UpdateCursorTexture(NKFPJPCFBJI: true);
			if (!IsSelected(JIIGOACEIKL) || !FHEMHCEAICB)
			{
				CursorManager.GetPlayer(JIIGOACEIKL).ChangeCursorTexture(CursorManager.CursorType.Select);
			}
		}
		CAGLICKMCDK(JIIGOACEIKL, NJHMBMGKCPL: false);
		if (Object.op_Implicit((Object)(object)DecorationMode.GetPlayer(JIIGOACEIKL)))
		{
			DecorationMode player = DecorationMode.GetPlayer(JIIGOACEIKL);
			player.OnDecorationModeExit = (Action<int>)Delegate.Remove(player.OnDecorationModeExit, new Action<int>(NFHHEMPGCNM));
		}
	}

	public static Placeable ECHMDNDPJJG(Placeable EAPCLAODGAE, Direction FCGBJEIIMBC)
	{
		PHKPBKDAIBF = EAPCLAODGAE;
		DHKFDIJCOOB = 5;
		while (PHKPBKDAIBF.GetDirection() != FCGBJEIIMBC)
		{
			PHKPBKDAIBF = PHKPBKDAIBF.rotatedPrefab.GetComponentInChildren<Placeable>();
			DHKFDIJCOOB--;
			if (DHKFDIJCOOB <= 1)
			{
				Debug.LogError((object)(((Object)((Component)PHKPBKDAIBF).gameObject).name + ".png"));
				break;
			}
		}
		return PHKPBKDAIBF;
	}

	public int GetSkinIndex()
	{
		return KLONJHJJMJD;
	}

	public void DropSlot(Slot ADEBNALPEHE)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (!ADEBNALPEHE.KPINNBKMOMO())
		{
			if (PCGNHMPADGE)
			{
				DroppedItem.SpawnDroppedItem(((Component)this).transform.position, ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack);
			}
			else
			{
				PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack);
			}
		}
	}

	public bool NNIGPOBLKFE(int JIIGOACEIKL)
	{
		return FHEMHCEAICB;
	}

	public bool MHPOMFIOKIJ()
	{
		if (isPlaceableOnSurface)
		{
			return (Object)(object)currentSurface != (Object)null;
		}
		return true;
	}

	private void HLEKHEADFMD()
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			if (CursorManager.CMDGPJEIIJI(JIIGOACEIKL).IsCursorVisible())
			{
				CursorManager.CMDGPJEIIJI(JIIGOACEIKL).EKHMMNNOEOI = false;
				HOFIBNPEDAA = ((Component)this).transform.position - CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition();
			}
			else if (Object.op_Implicit((Object)(object)itemSpace))
			{
				attachedToPlayer = true;
				Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position;
				ICHFJCKGGJD = ((Vector3)(ref val)).magnitude;
			}
			else
			{
				CursorManager.GetPlayer(JIIGOACEIKL).CBGHFKGFGKM(AODONKKHPBP: false);
				CursorManager.PNLDBADHHMI(JIIGOACEIKL, ((Component)this).transform.position);
				HOFIBNPEDAA = Vector3.zero;
			}
		}
		else
		{
			HOFIBNPEDAA = ((Component)this).transform.position - CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition();
		}
	}

	public void FillButtonsContext()
	{
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
		if ((Object)(object)surfaceGOInstantiated != (Object)null)
		{
			return;
		}
		if ((Object)(object)gameObjectOnSelected != (Object)null)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Place"));
		}
		else if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Place"));
		}
		else if (isAccessElement)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Place"));
		}
		if (!isAccessElement)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("Pick up"));
		}
		if (GBPNHKNFJPH())
		{
			COFOOBLHHAD = (switchesSurface ? LocalisationSystem.Get("Swap") : LocalisationSystem.Get("Rotate"));
			if (string.IsNullOrEmpty(COFOOBLHHAD))
			{
				if (switchesSurface)
				{
					COFOOBLHHAD = "Swap";
				}
				else
				{
					COFOOBLHHAD = "Rotate";
				}
			}
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Rotate, COFOOBLHHAD);
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Rotate", 0.3f))
			{
				BOFCJINGLGK();
			}
		}
		if (GIPCNNLIHDA())
		{
			COFOOBLHHAD = LocalisationSystem.Get("Style");
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Style, (COFOOBLHHAD != "") ? COFOOBLHHAD : "Style");
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Style", 0.3f))
			{
				FKPFIFIEJBK();
			}
		}
		if ((Object)(object)placeableSurface != (Object)null && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			BIPLCOGFBBE = placeableSurface.GetPlaceablesThatCanSelect(JIIGOACEIKL);
			if ((Object)(object)secondarySurface != (Object)null)
			{
				List<Placeable> placeablesThatCanSelect = secondarySurface.GetPlaceablesThatCanSelect(JIIGOACEIKL);
				for (int i = 0; i < placeablesThatCanSelect.Count; i++)
				{
					BIPLCOGFBBE.Add(placeablesThatCanSelect[i]);
				}
			}
			if (BIPLCOGFBBE.Count > 0 && PCGNHMPADGE)
			{
				COFOOBLHHAD = LocalisationSystem.Get("NextItem");
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.PrevNext, (COFOOBLHHAD != "") ? COFOOBLHHAD : "Next Item");
				if ((Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "PreviousItem", 0.3f) || Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "NextItem", 0.3f)) && SelectObject.GetPlayer(JIIGOACEIKL).Deselect())
				{
					CursorManager.SetCursorPositionFromWorld(JIIGOACEIKL, ((Component)this).transform.position);
					SetMouseOffset(Vector3.zero);
					SelectObject.GetPlayer(JIIGOACEIKL).SelectPlaceable(BIPLCOGFBBE[0]);
				}
			}
		}
		if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) || !((Object)(object)currentSurface != (Object)null) || currentSurface.GetPlaceablesThatCanSelect(JIIGOACEIKL).Count <= 1 || !currentSurface.nextItemAvailable || !((Object)(object)gameObjectOnSelected == (Object)null))
		{
			return;
		}
		COFOOBLHHAD = LocalisationSystem.Get("NextItem");
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.PrevNext, (COFOOBLHHAD != "") ? COFOOBLHHAD : "Next Item");
		if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "NextItem", 0.3f))
		{
			BIPLCOGFBBE = currentSurface.GetPlaceablesThatCanSelect(JIIGOACEIKL);
			for (int j = 0; j < BIPLCOGFBBE.Count; j++)
			{
				if (((object)BIPLCOGFBBE[j]).Equals((object?)this))
				{
					int index = (j + 1) % BIPLCOGFBBE.Count;
					if (SelectObject.GetPlayer(JIIGOACEIKL).Deselect())
					{
						CursorManager.SetCursorPositionFromWorld(JIIGOACEIKL, ((Component)this).transform.position);
						SetMouseOffset(Vector3.zero);
						SelectObject.GetPlayer(JIIGOACEIKL).SelectPlaceable(BIPLCOGFBBE[index]);
					}
					break;
				}
			}
		}
		else
		{
			if (!Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "PreviousItem", 0.3f))
			{
				return;
			}
			BIPLCOGFBBE = currentSurface.GetPlaceablesThatCanSelect(JIIGOACEIKL);
			for (int k = 0; k < BIPLCOGFBBE.Count; k++)
			{
				if (((object)BIPLCOGFBBE[k]).Equals((object?)this))
				{
					int num = (k - 1) % BIPLCOGFBBE.Count;
					if (num < 0)
					{
						num = BIPLCOGFBBE.Count + num;
					}
					if (SelectObject.GetPlayer(JIIGOACEIKL).Deselect())
					{
						CursorManager.SetCursorPositionFromWorld(JIIGOACEIKL, ((Component)this).transform.position);
						SetMouseOffset(Vector3.zero);
						SelectObject.GetPlayer(JIIGOACEIKL).SelectPlaceable(BIPLCOGFBBE[num]);
					}
					break;
				}
			}
		}
	}

	public void MPOKPFDKKCM(SurfaceSortOrder PHCPMJAIDMC)
	{
		((Component)this).transform.parent = ((Component)PHCPMJAIDMC).transform;
		currentSurface = PHCPMJAIDMC;
		surfaceCollider = PHCPMJAIDMC.surfaceCollider;
		if (PHCPMJAIDMC.HMGHKELPDMK(itemSetup.item, 0, KOGPKBOIFGN: true, ((Component)this).transform) != null)
		{
			snappedToPosition = false;
			pickUpable = PHCPMJAIDMC.HMGHKELPDMK(itemSetup.item, 1, KOGPKBOIFGN: false, ((Component)this).transform).canBePickupable;
		}
		else
		{
			snappedToPosition = false;
		}
	}

	public void MMLKIKPOJDJ(bool KMEJCLIOMBA)
	{
		if ((Object)(object)itemSpace == (Object)null)
		{
			GDLHEGANLFB(KMEJCLIOMBA);
		}
	}

	private void ALFOFLNNPMJ()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			OEEPHFEHGBJ = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition();
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Left"))
			{
				CursorManager.SetCursorPositionFromWorld(JIIGOACEIKL, new Vector3(OEEPHFEHGBJ.x - 0.5f, OEEPHFEHGBJ.y));
			}
			else if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Right"))
			{
				CursorManager.SetCursorPositionFromWorld(JIIGOACEIKL, new Vector3(OEEPHFEHGBJ.x + 0.5f, OEEPHFEHGBJ.y));
			}
			else if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Down"))
			{
				CursorManager.SetCursorPositionFromWorld(JIIGOACEIKL, new Vector3(OEEPHFEHGBJ.x, OEEPHFEHGBJ.y - 0.5f));
			}
			else if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Up"))
			{
				CursorManager.SetCursorPositionFromWorld(JIIGOACEIKL, new Vector3(OEEPHFEHGBJ.x, OEEPHFEHGBJ.y + 0.5f));
			}
		}
		SetPosition(JIIGOACEIKL, attachedToPlayer, Object.op_Implicit((Object)(object)snapToGrid), CDPAMNIPPEC: true);
	}

	public void HJGJFLNNCDD(int JIIGOACEIKL, bool EFNFMEIDGDN, bool BGIEPKNAKHI, bool IBCOKMGFPKB = true, bool KAJIBKHFEFF = false)
	{
		MKEEKHDMFPE(JIIGOACEIKL, EFNFMEIDGDN, BGIEPKNAKHI, placeableSurface, IBCOKMGFPKB, KAJIBKHFEFF);
		ONPKLBKIEBG(JIIGOACEIKL, EFNFMEIDGDN, BGIEPKNAKHI, secondarySurface, IBCOKMGFPKB, KAJIBKHFEFF);
	}

	private bool FMGBCOMHMCA()
	{
		if (skinsGameObjects.Length != 0)
		{
			return false;
		}
		if (skins.Length != 0)
		{
			return false;
		}
		return true;
	}

	public void EnableAllColliders(bool BJFHJCFOEHG)
	{
		for (int i = 0; i < allCollidersToEnableDisable.Length; i++)
		{
			if (!allCollidersToEnableDisable[i].isTrigger || BJFHJCFOEHG)
			{
				((Behaviour)allCollidersToEnableDisable[i]).enabled = BJFHJCFOEHG;
			}
		}
		for (int j = 0; j < enableColliders.Length; j++)
		{
			((Behaviour)enableColliders[j]).enabled = BJFHJCFOEHG;
		}
	}

	private void HHGJOLDODBM()
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			if (CursorManager.CMDGPJEIIJI(JIIGOACEIKL).IsCursorVisible())
			{
				CursorManager.CMDGPJEIIJI(JIIGOACEIKL).EKHMMNNOEOI = true;
				HOFIBNPEDAA = ((Component)this).transform.position - CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition();
			}
			else if (Object.op_Implicit((Object)(object)itemSpace))
			{
				attachedToPlayer = false;
				Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position;
				ICHFJCKGGJD = ((Vector3)(ref val)).magnitude;
			}
			else
			{
				CursorManager.CMDGPJEIIJI(JIIGOACEIKL).CBGHFKGFGKM(AODONKKHPBP: true);
				CursorManager.SetCursorPositionFromWorld(JIIGOACEIKL, ((Component)this).transform.position);
				HOFIBNPEDAA = Vector3.zero;
			}
		}
		else
		{
			HOFIBNPEDAA = ((Component)this).transform.position - CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition();
		}
	}

	public void HAJJPJONLMD()
	{
		if (!string.IsNullOrEmpty(guidString))
		{
			CommonReferences.GGFJGHHHEJC.movedGuids.Add(guid);
		}
	}

	public bool Action(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return ActionObject(JIIGOACEIKL, GFNHAMCPEAK: true);
	}

	public bool JABJEIGGCFJ(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		if (GFNHAMCPEAK)
		{
			FHEMHCEAICB = true;
			if (!isAccessElement && !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).GABNNLJOMHI())
			{
				return true;
			}
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).IsTavernLocation() && PlayerController.GetPlayer(JIIGOACEIKL).NNMHEPDJOHK != (ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.Cellar) && TavernManager.GGFJGHHHEJC.LKKBHOAFMAH() && (Object)(object)itemSpace != (Object)null)
			{
				CommonReferences.GGFJGHHHEJC.PlayerBark("GO", JIIGOACEIKL);
				CommonReferences.GGFJGHHHEJC.OnTavernMustBeClosed(JIIGOACEIKL);
				return true;
			}
			SelectObject.BNMEANGDMIP(JIIGOACEIKL)?.PDEEEJOFEAI();
			ButtonsContext.CPIIFPCIJEP(JIIGOACEIKL);
			OnlineObjectsManager.instance.SetMovingObject(this);
			this.JIIGOACEIKL = JIIGOACEIKL;
			recentlySelected = false;
			if ((Object)(object)InputByProximityManager.MBDFOJAKELO(JIIGOACEIKL).HOMHFEJHKIF() != (Object)null)
			{
				InputByProximityManager.DFGOGIIPPPH(JIIGOACEIKL).GFCOOKLMLNE().BJCDFHFKEGG(JIIGOACEIKL);
			}
			SelectObject.GetPlayer(JIIGOACEIKL).IPINANKCIDJ((MonoBehaviour)(object)this);
			if ((Object)(object)snapToGrid != (Object)null)
			{
				((Behaviour)snapToGrid).enabled = true;
				snapToGrid.autoSnap = false;
			}
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				if (CursorManager.GetPlayer(JIIGOACEIKL).IsCursorVisible())
				{
					CursorManager.CMDGPJEIIJI(JIIGOACEIKL).EKHMMNNOEOI = false;
					HOFIBNPEDAA = Vector3.zero;
				}
				else if (Object.op_Implicit((Object)(object)itemSpace))
				{
					attachedToPlayer = true;
					ICHFJCKGGJD = 230f;
				}
				else
				{
					CursorManager.CMDGPJEIIJI(JIIGOACEIKL).EKHMMNNOEOI = true;
					if (!selectAfterPlace)
					{
						CursorManager.GEGOEAMGDEE(JIIGOACEIKL, ((Component)this).transform.position);
					}
					HOFIBNPEDAA = Vector3.zero;
				}
			}
			else
			{
				HOFIBNPEDAA = ((Component)this).transform.position - CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition();
			}
		}
		if ((Object)(object)itemSpace != (Object)null)
		{
			((Component)itemSpace).gameObject.SetActive(false);
		}
		if ((Object)(object)areaSpace != (Object)null)
		{
			areaSpace.DGIPAJDKNPN(MDIKPGGBNLI: true);
		}
		CAGLICKMCDK(JIIGOACEIKL, NJHMBMGKCPL: false);
		CommonReferences.GGFJGHHHEJC.OnPlaceableSelected(JIIGOACEIKL, this, arg3: false, GFNHAMCPEAK);
		OnThisPlaceableSelected(JIIGOACEIKL, arg2: true, GFNHAMCPEAK);
		return false;
	}

	public List<Placeable> OAJJHBCCKJM()
	{
		return placeableSurface.placeablesOnSurface;
	}

	public void KCGHOGLINOA(bool MCFNOAFOIHE)
	{
		if ((Object)(object)itemSpace != (Object)null)
		{
			itemSpace.Place(NMLKLAGDNPF: false);
			if (MCFNOAFOIHE)
			{
				((Component)itemSpace).gameObject.SetActive(false);
			}
		}
		else if ((Object)(object)itemBase != (Object)null && (Object)(object)currentSurface == (Object)null)
		{
			RemoveItemBaseFromWorldTiles();
		}
	}

	public void SetPosition(int JIIGOACEIKL, bool JOOEMBNDCKF, bool OFGPEJIOLNJ, bool CDPAMNIPPEC = false)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (this.JIIGOACEIKL != JIIGOACEIKL)
		{
			this.JIIGOACEIKL = JIIGOACEIKL;
		}
		HLCBODJLFGD = GetNewPosition(JOOEMBNDCKF, CDPAMNIPPEC);
		if (Object.op_Implicit((Object)(object)itemSpace))
		{
			if (((Component)this).transform.localScale.x == -1f)
			{
				itemSpace.InvertX(NKFPJPCFBJI: true);
			}
			else
			{
				itemSpace.InvertX(NKFPJPCFBJI: false);
			}
		}
		if ((Object)(object)currentSurface != (Object)null)
		{
			if (IsNewPosOnSurface(HLCBODJLFGD))
			{
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
		else
		{
			((Component)this).transform.position = HLCBODJLFGD;
		}
		if (OFGPEJIOLNJ)
		{
			snapToGrid.Snap();
		}
		else
		{
			PixelSnap();
		}
	}

	public void NBNCJDDAFPJ(int JIIGOACEIKL)
	{
	}

	public List<Placeable> GetAllPlaceablesOnSurface()
	{
		return placeableSurface.placeablesOnSurface;
	}

	public void ONFDHHHDEIK(bool ODNGJHPOMMK)
	{
		if (!Object.op_Implicit((Object)(object)rigidBody) || !Object.op_Implicit((Object)(object)physicalSpace) || !(physicalSpace is PhysicalSpaceWall))
		{
			return;
		}
		if (ODNGJHPOMMK)
		{
			physicalSpace.FEAJNLOLHDF();
			rigidBody.bodyType = (RigidbodyType2D)1;
			for (int i = 0; i < wallColliders.Count; i++)
			{
				wallColliders[i].isTrigger = false;
			}
		}
		else
		{
			physicalSpace.GBAFCLOJMDF();
			rigidBody.bodyType = (RigidbodyType2D)2;
			for (int j = 0; j < wallColliders.Count; j++)
			{
				wallColliders[j].isTrigger = false;
			}
		}
	}

	public void IGCCAOIJPLP(bool BJFHJCFOEHG)
	{
		for (int i = 1; i < allCollidersToEnableDisable.Length; i += 0)
		{
			if (!allCollidersToEnableDisable[i].isTrigger || BJFHJCFOEHG)
			{
				((Behaviour)allCollidersToEnableDisable[i]).enabled = BJFHJCFOEHG;
			}
		}
		for (int j = 0; j < enableColliders.Length; j++)
		{
			((Behaviour)enableColliders[j]).enabled = BJFHJCFOEHG;
		}
	}

	public bool OCBIBCCKLAL(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (isAccessElement)
		{
			if ((Object)(object)ConstructionManager.current == (Object)null || !ConstructionManager.current.LNLJMCONDNE)
			{
				return false;
			}
			if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE && ((Object)(object)ConstructionActionBarUI.KFCAPNDFIGI() == (Object)null || (Object)(object)ConstructionActionBarUI.OCLKNDBIOFM().instantiateGO == (Object)null || !itemSetup.item.canPickUp))
			{
				return false;
			}
		}
		else if (!((Behaviour)this).enabled || (GFNHAMCPEAK && !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).IBEFDKHFBFM()) || (!pickUpable && !FHEMHCEAICB))
		{
			return false;
		}
		if (FHEMHCEAICB)
		{
			return EEHBCDFHJKC(JIIGOACEIKL);
		}
		if ((Object)(object)areaSpace != (Object)null && GFNHAMCPEAK && !areaSpace.HNFLLPDOLID(JIIGOACEIKL, GFNHAMCPEAK))
		{
			return true;
		}
		if ((Object)(object)gameObjectOnSelected != (Object)null)
		{
			Placeable component = Object.Instantiate<GameObject>(gameObjectOnSelected, ((Component)this).transform.position, ((Component)this).transform.rotation).GetComponent<Placeable>();
			component.StartMoving(JIIGOACEIKL, PHJILIBHABG: true, GFNHAMCPEAK, MAFODGNALFJ: false, MCFNOAFOIHE: false);
			if (OnlineManager.PlayingOnline())
			{
				component.onlinePlaceable.LGIDDDGFEID();
				component.onlinePlaceable.PGCLJPKJLNG();
				component.onlinePlaceable.ONLPFFLBGEM();
			}
			InteractObject.GNCPLNHMFHN(JIIGOACEIKL).DPLIAOCBBOM(component.inputByProximity.OAHAPGNNHEO(), component.inputByProximity.mainGameObject);
			RemovePlaceable(EFNFMEIDGDN: false, KAJIBKHFEFF: true);
			component.HOFIBNPEDAA = Vector3.zero;
			return true;
		}
		if (GFNHAMCPEAK)
		{
			if ((Object)(object)itemSpace != (Object)null && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).IsTavernLocationNotCellar() && TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
			{
				CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("Fortitude/MainEvent 4", JIIGOACEIKL);
				CommonReferences.MNFMOEKMJKN().OnTavernMustBeClosed(JIIGOACEIKL);
				return false;
			}
			if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).selectedGameObject != (Object)null)
			{
				return false;
			}
		}
		if (selectBlockers.Any())
		{
			if ((Object)(object)placeableSurface != (Object)null)
			{
				if (Time.time > HPPADODDFEI + 1002f)
				{
					MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get(selectBlockers.First()), 805f);
					HPPADODDFEI = Time.time;
				}
				return false;
			}
			if (Time.time > HPPADODDFEI + 198f)
			{
				DialogueManager.Bark("EnterTavernDrink", ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				HPPADODDFEI = Time.time;
			}
			return true;
		}
		if ((Object)(object)placeableSurface != (Object)null)
		{
			for (int i = 1; i < placeableSurface.placeablesOnSurface.Count; i += 0)
			{
				if (placeableSurface.placeablesOnSurface[i].selectBlockers.Any())
				{
					if (Time.time > HPPADODDFEI + 176f)
					{
						DialogueManager.Bark("Facilities", ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
						HPPADODDFEI = Time.time;
					}
					return true;
				}
			}
		}
		return false;
	}

	public bool IsNewPosOnSurface(Vector3 AIJOOOIJEDC)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (FHEMHCEAICB && IsObjectOnASurface() && (Object)(object)surfaceCollider != (Object)null)
		{
			if (!((Object)(object)itemBase == (Object)null))
			{
				return FIIFGAIGGPE(AIJOOOIJEDC, surfaceCollider);
			}
			return surfaceCollider.OverlapPoint(Vector2.op_Implicit(AIJOOOIJEDC));
		}
		return false;
	}

	private bool JHMCCEJKIDC()
	{
		return false;
	}

	public void MDFENOKNBEG()
	{
		if (Object.op_Implicit((Object)(object)snapToGrid))
		{
			snapToGrid.OAFMIKKPICK();
		}
		PixelSnapOnLoad();
		AddItemBaseToWorldTiles();
		MFJNMJMFEOB();
	}

	private void CAGLICKMCDK(int JIIGOACEIKL, bool NJHMBMGKCPL)
	{
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		if (NJHMBMGKCPL)
		{
			if ((Object)(object)spriteRendererColor15 != (Object)null && itemSetup.DNLMCHDOMOK is BirdInstance birdInstance && !birdInstance.JFKEFOFKPIG().isSkeleton)
			{
				if (JIIGOACEIKL == 1)
				{
					((Renderer)spriteRendererColor15).material.SetColor(ShaderReferences.colorsShader[15], new Color(1f, 0.935527f, 0f, 1f));
				}
				else
				{
					((Renderer)spriteRendererColor15).material.SetColor(ShaderReferences.colorsShader[15], Color.red);
				}
				return;
			}
			if ((Object)(object)NGHODLKOKOI == (Object)null)
			{
				NGHODLKOKOI = DecorationMode.GetPlayer(JIIGOACEIKL).GetOutlineMaterial(itemSetup.item.JDJGFAACPFC());
			}
			if (Object.op_Implicit((Object)(object)spriteRenderer) && (Object)(object)((Renderer)spriteRenderer).sharedMaterial != (Object)(object)NGHODLKOKOI && !outlineOnlyInOutlineSpriterenderers)
			{
				((Renderer)spriteRenderer).sharedMaterial = NGHODLKOKOI;
			}
			for (int num = outlineSpriteRenderers.Length - 1; num >= 0; num--)
			{
				if ((Object)(object)outlineSpriteRenderers[num] != (Object)null && (Object)(object)((Renderer)outlineSpriteRenderers[num]).sharedMaterial != (Object)(object)NGHODLKOKOI)
				{
					((Renderer)outlineSpriteRenderers[num]).sharedMaterial = NGHODLKOKOI;
				}
			}
			return;
		}
		if ((Object)(object)spriteRendererColor15 != (Object)null && itemSetup.DNLMCHDOMOK is BirdInstance birdInstance2 && !birdInstance2.JFKEFOFKPIG().isSkeleton)
		{
			((Renderer)spriteRendererColor15).material.SetColor(ShaderReferences.colorsShader[15], new Color(0f, 0f, 0f, 0f));
		}
		NGHODLKOKOI = null;
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			((Renderer)spriteRenderer).sharedMaterial = initialMaterial;
		}
		for (int i = 0; i < outlineSpriteRenderers.Length; i++)
		{
			if ((Object)(object)outlineSpriteRenderers[i] != (Object)null)
			{
				((Renderer)outlineSpriteRenderers[i]).sharedMaterial = initialMaterial;
			}
		}
	}

	[SpecialName]
	private TavernZone IKBFJCOONIM()
	{
		return HADBAEEHFAK;
	}

	public void UpdateDisableOnBecameInvisible()
	{
		if (!((Object)(object)disableOnInvisible != (Object)null))
		{
			return;
		}
		Collider2D[] componentsInChildren = ((Component)this).gameObject.GetComponentsInChildren<Collider2D>();
		List<Collider2D> list = new List<Collider2D>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (componentsInChildren[i].isTrigger && ((Behaviour)componentsInChildren[i]).enabled)
			{
				list.Add(componentsInChildren[i]);
			}
		}
		disableOnInvisible.colliders = list.ToArray();
	}

	public void FGGLNPFAFFI()
	{
		if ((Object)(object)placeableCollider == (Object)null)
		{
			Collider2D[] components = ((Component)this).GetComponents<Collider2D>();
			foreach (Collider2D val in components)
			{
				if (((Behaviour)val).enabled && !val.isTrigger)
				{
					placeableCollider = val;
					break;
				}
			}
		}
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)itemSetup == (Object)null)
		{
			itemSetup = ((Component)this).GetComponent<ItemSetup>();
		}
		if ((Object)(object)itemSpace == (Object)null)
		{
			itemSpace = ((Component)this).GetComponentInChildren<ItemSpace>();
		}
		if ((Object)(object)snapToGrid == (Object)null)
		{
			snapToGrid = ((Component)this).GetComponent<SnapToGrid>();
		}
		if (physicalSpaces == null && (Object)(object)physicalSpace == (Object)null)
		{
			physicalSpace = ((Component)((Component)this).transform).GetComponentInChildren<PhysicalSpace>();
		}
		if (Object.op_Implicit((Object)(object)physicalSpace))
		{
			physicalSpace.placeable = this;
			if (physicalSpace is PhysicalSpaceWall)
			{
				wallColliders.Add(((Component)physicalSpace).GetComponent<Collider2D>());
			}
		}
		if (physicalSpaces != null)
		{
			for (int j = 0; j < physicalSpaces.Length; j++)
			{
				physicalSpaces[j].placeable = this;
				if (physicalSpaces[j] is PhysicalSpaceWall)
				{
					wallColliders.Add(((Component)physicalSpaces[j]).GetComponent<Collider2D>());
				}
			}
		}
		if ((Object)(object)inputByProximity == (Object)null)
		{
			inputByProximity = ((Component)((Component)this).transform).GetComponentInChildren<InputByProximity>();
		}
		if ((Object)(object)rigidBody == (Object)null)
		{
			rigidBody = ((Component)this).GetComponent<Rigidbody2D>();
		}
		if (Object.op_Implicit((Object)(object)inputByProximity))
		{
			inputByProximity.placeable = this;
		}
		sortingGroup = ((Component)this).GetComponent<SortingGroup>();
		if ((Object)(object)sortingGroup == (Object)null && ((Object)(object)itemSetup == (Object)null || PGKLFGNLEKE(itemSetup.item.JPNFKDMFKMC())) && (Object)(object)spriteRenderer != (Object)null)
		{
			sortingGroup = ((Component)this).gameObject.AddComponent<SortingGroup>();
			sortingGroup.sortingLayerID = ((Renderer)spriteRenderer).sortingLayerID;
			sortingGroup.sortingOrder = ((Renderer)spriteRenderer).sortingOrder;
			sortingGroup.sortingLayerName = ((Renderer)spriteRenderer).sortingLayerName;
		}
		NCIADIENOKK();
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void GDLHEGANLFB(bool KMEJCLIOMBA)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			if (KMEJCLIOMBA && spriteRenderer.color == FMOKCPPGJBB)
			{
				spriteRenderer.color = KDEHDOHOILE;
			}
			else if (!KMEJCLIOMBA)
			{
				spriteRenderer.color = FMOKCPPGJBB;
			}
		}
		if (Object.op_Implicit((Object)(object)skinSpriteRenderer))
		{
			if (KMEJCLIOMBA && skinSpriteRenderer.color == FMOKCPPGJBB)
			{
				skinSpriteRenderer.color = KDEHDOHOILE;
			}
			else if (!KMEJCLIOMBA)
			{
				skinSpriteRenderer.color = FMOKCPPGJBB;
			}
		}
	}

	private void LBECAKBCLIP(bool CDPAMNIPPEC)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		BFIELBPJKAH = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
		if (BFIELBPJKAH == direction || !rotatable)
		{
			return;
		}
		if ((Object)(object)rotatedPrefab != (Object)null)
		{
			if (BFIELBPJKAH == (Direction)6 || BFIELBPJKAH == Direction.Diagonal)
			{
				if (rotatedPrefab.GetComponent<Placeable>().direction == Direction.Diagonal || rotatedPrefab.GetComponent<Placeable>().direction == Direction.Right)
				{
					CreateRotatedPrefab(BFIELBPJKAH, ((Component)this).transform.position, CDPAMNIPPEC);
					return;
				}
				DFPGNELDGIP(inheritDirection ? BFIELBPJKAH : direction, CDPAMNIPPEC);
				if (multipleSkins)
				{
					GKJEMMKNFBO(KLONJHJJMJD);
				}
			}
			else if (rotatedPrefab.GetComponent<Placeable>().direction == Direction.Up || rotatedPrefab.GetComponent<Placeable>().direction == Direction.Down)
			{
				CreateRotatedPrefab(BFIELBPJKAH, ((Component)this).transform.position, CDPAMNIPPEC);
			}
			else
			{
				DFPGNELDGIP(inheritDirection ? BFIELBPJKAH : direction, CDPAMNIPPEC);
				if (multipleSkins)
				{
					ChangeSkin(KLONJHJJMJD, PDHJLCDFNCK: false);
				}
			}
		}
		else
		{
			DFPGNELDGIP(BFIELBPJKAH, CDPAMNIPPEC);
		}
	}

	private void LBIEMCLFOHE(List<AJIKIEMFEPA> LMOOCPOGLPH)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)placeableSurface != (Object)null))
		{
			return;
		}
		Bounds bounds = placeableSurface.surfaceCollider.bounds;
		Vector2 val = Vector2.op_Implicit(((Bounds)(ref bounds)).size);
		Vector2 val2 = default(Vector2);
		for (int num = LMOOCPOGLPH.Count - 1; num >= 0; num--)
		{
			if (direction == Direction.Up)
			{
				val2 = LMOOCPOGLPH[num].percentagePosition;
			}
			else if (direction == Direction.Down)
			{
				val2 = Vector2.one - LMOOCPOGLPH[num].percentagePosition;
			}
			else if (direction == Direction.Right)
			{
				((Vector2)(ref val2))._002Ector(LMOOCPOGLPH[num].percentagePosition.y, 1f - LMOOCPOGLPH[num].percentagePosition.x);
			}
			else
			{
				((Vector2)(ref val2))._002Ector(1f - LMOOCPOGLPH[num].percentagePosition.y, LMOOCPOGLPH[num].percentagePosition.x);
			}
			bounds = placeableSurface.surfaceCollider.bounds;
			Vector3 val3 = ((Bounds)(ref bounds)).min + Vector2.op_Implicit(val2 * val);
			if (!LMOOCPOGLPH[num].placeable.snappedToPosition && (Object)(object)LMOOCPOGLPH[num].itemBase != (Object)null)
			{
				bounds = LMOOCPOGLPH[num].itemBase.bounds;
				Vector3 val4 = ((Bounds)(ref bounds)).center - LMOOCPOGLPH[num].transform.position;
				LMOOCPOGLPH[num].transform.position = val3 - val4;
			}
			Placeable placeable = LMOOCPOGLPH[num].placeable.AddPlaceableToSurface(placeableSurface, CDPAMNIPPEC: false, LMOOCPOGLPH[num].placeable.BEIPALOAAJJ);
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.outlined = false;
				if (Object.op_Implicit((Object)(object)LMOOCPOGLPH[num].placeable.onlinePlaceable))
				{
					LMOOCPOGLPH[num].placeable.onlinePlaceable.dontRemoveFromDictionary = true;
				}
				Utils.BLPDAEHPOBA(((Component)LMOOCPOGLPH[num].placeable).gameObject);
			}
			else
			{
				LMOOCPOGLPH[num].placeable.PixelSnapInChildren();
			}
		}
	}

	private void OnEnable()
	{
		if (!PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Contains(this))
		{
			PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Add(this);
		}
	}

	public void BJMKADDLGAN()
	{
		if (skinVariationGropus.Count > 0)
		{
			List<int> list = new List<int>();
			for (int i = 1; i < skinVariationGropus.Count; i++)
			{
				skinVariationGropus[i].KEHEBJBGFNP(i, list);
			}
			if (OnlineManager.PlayingOnline())
			{
				onlinePlaceable.DJNPJDIBNLJ(list.ToArray());
			}
		}
		else if (multipleSkins)
		{
			if (skinsGameObjects.Length != 0)
			{
				GKJEMMKNFBO(Random.Range(1, skinsGameObjects.Length), PDHJLCDFNCK: false);
			}
			else
			{
				ChangeSkin(Random.Range(0, skins.Length));
			}
		}
	}

	public void ReceiveSkinVariations(int[] CPLKCKNILFO)
	{
		for (int i = 0; i < skinVariationGropus.Count; i++)
		{
			skinVariationGropus[i].CIGBHLNFOPK();
		}
		for (int j = 0; j < CPLKCKNILFO.Length; j += 2)
		{
			if (skinVariationGropus[CPLKCKNILFO[j]].onlyOne)
			{
				skinVariationGropus[CPLKCKNILFO[j]].OPBKBEIAMND(CPLKCKNILFO[j + 1], 0, null);
			}
			else
			{
				skinVariationGropus[CPLKCKNILFO[j]].variations[CPLKCKNILFO[j + 1]].SetActive(true);
			}
		}
	}

	public TavernZone GetCurrentTavernZone()
	{
		return NNMHEPDJOHK;
	}

	public void SetUpSurface(SurfaceSortOrder PHCPMJAIDMC)
	{
		((Component)this).transform.parent = ((Component)PHCPMJAIDMC).transform;
		currentSurface = PHCPMJAIDMC;
		surfaceCollider = PHCPMJAIDMC.surfaceCollider;
		if (PHCPMJAIDMC.GetSnapItem(itemSetup.item, 1, KOGPKBOIFGN: true, ((Component)this).transform) != null)
		{
			snappedToPosition = true;
			pickUpable = PHCPMJAIDMC.GetSnapItem(itemSetup.item, 1, KOGPKBOIFGN: true, ((Component)this).transform).canBePickupable;
		}
		else
		{
			snappedToPosition = false;
		}
	}

	private void APPGMNJFMAB()
	{
		if (multipleSkins && canCycleSkin)
		{
			NextSkin();
			return;
		}
		ItemSetup component = ((Component)this).GetComponent<ItemSetup>();
		if ((Object)(object)component != (Object)null)
		{
			component.GDEFMCFPDDD();
		}
	}

	public void RemoveItemBaseFromWall(float KHEBKHFHMDB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (isPlaceableOnWall)
		{
			MPCJBPJAGKK = Utils.MMFCGMDOLDM(itemBase);
			ACAIKFICNFP = Utils.IKJOHEODBBE(itemBase);
			for (float num = MPCJBPJAGKK.x; num <= ACAIKFICNFP.x; num += 0.5f)
			{
				WorldGrid.AKLCFEPBONI(new Vector3(num, KHEBKHFHMDB), this);
			}
			WorldGrid.AKLCFEPBONI(new Vector3(ACAIKFICNFP.x, KHEBKHFHMDB), this);
		}
	}

	public void FEFKIEJJOKG(int JIIGOACEIKL, SurfaceSortOrder PHCPMJAIDMC, bool BLJPGJKOLNF, bool CDPAMNIPPEC = true)
	{
		hasBeenPlaced = false;
		outlined = true;
		SetUpSurface(PHCPMJAIDMC);
		GHFKHJPDNBM(JIIGOACEIKL, BLJPGJKOLNF, FKOJEBGDMFO: true, FNHLKLKAHNB: false, CDPAMNIPPEC);
	}

	private void Start()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		setUpDone = true;
		if (!FHEMHCEAICB && !PHOCAFJDCDK)
		{
			lastPlacedPosition = ((Component)this).transform.position;
			OnThisPlaceableLoaded();
			AddItemBaseToWorldTiles(NLIFPMODLLA: true);
			AddItemBaseToWorldTilesNextFrame(MMICADKPHLP: true);
		}
		if (randomSkin)
		{
			RandomSkin();
		}
		if (SceneReferences.AFEDGPJNCDN)
		{
			CalculateCurrentZone();
		}
	}

	[SpecialName]
	private void HPMAOAEEKHM(bool AODONKKHPBP)
	{
		_003CKHCBDBIOOCK_003Ek__BackingField = AODONKKHPBP;
	}

	public bool MJMHLAABFNP(Location BAIMHDBJPDK)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (validLocations.HasFlag(BAIMHDBJPDK))
		{
			return false;
		}
		return validLocationExceptionZones.HasFlag(WorldGrid.AGKGGAFFFGM(((Component)this).transform.position));
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void SetCurrentZone(ZoneType GIBJPCAFCJB, int LDMDHEPJFFD)
	{
		if (currentZoneIndex >= 0 && (Object)(object)TavernZonesManager.GGFJGHHHEJC != (Object)null)
		{
			TavernZonesManager.GGFJGHHHEJC.GetTavernZone(currentZoneIndex)?.AKLCFEPBONI(this);
		}
		if (LDMDHEPJFFD >= 0)
		{
			if ((Object)(object)TavernZonesManager.GGFJGHHHEJC != (Object)null)
			{
				NNMHEPDJOHK = TavernZonesManager.GGFJGHHHEJC.GetTavernZone(LDMDHEPJFFD);
				if (NNMHEPDJOHK != null)
				{
					NNMHEPDJOHK.PCGNGKPHKLC(this);
				}
				else
				{
					NNMHEPDJOHK = null;
				}
			}
		}
		else
		{
			NNMHEPDJOHK = null;
		}
		currentZoneType = GIBJPCAFCJB;
		currentZoneIndex = LDMDHEPJFFD;
	}

	private void BOFCJINGLGK()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		if (attachedToPlayer)
		{
			CursorManager.GetPlayer(JIIGOACEIKL).CursorAppears();
		}
		if (rotatable && (Object)(object)rotatedPrefab != (Object)null)
		{
			Direction fCGBJEIIMBC = Utils.JPKPFDEBGEO(direction);
			Vector3 cursorWorldPosition = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition();
			cursorWorldPosition.z = 0f;
			CreateRotatedPrefab(fCGBJEIIMBC, cursorWorldPosition, CDPAMNIPPEC: true);
		}
		else
		{
			Direction fCGBJEIIMBC2 = (rotateFourNoPrefab ? Utils.JPKPFDEBGEO(direction) : ((direction != 0 && direction != Direction.Down) ? Utils.ABNPPDOGEPM(direction) : Direction.Left));
			ChangeDirectionRotatingItemsSurface(fCGBJEIIMBC2, CDPAMNIPPEC: true);
		}
	}

	private void DNMJPOKMBGJ(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)spriteRenderer) && (Object)(object)((Renderer)spriteRenderer).sharedMaterial != (Object)(object)DecorationMode.JDADPDBHJFO(JIIGOACEIKL).FNFDMCGLGMH(itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false)))
		{
			if (!isAccessElement)
			{
				DecorationMode player = DecorationMode.GetPlayer(JIIGOACEIKL);
				player.OnDecorationModeExit = (Action<int>)Delegate.Remove(player.OnDecorationModeExit, new Action<int>(BGHLOLALLHE));
				DecorationMode decorationMode = DecorationMode.HBDCJFLINDA(JIIGOACEIKL);
				decorationMode.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeExit, new Action<int>(ECPMADFHEHK));
			}
			LFMEKLNPLMK(JIIGOACEIKL, NJHMBMGKCPL: false);
		}
		CursorManager.GetPlayer(JIIGOACEIKL).LPPDBPAKDIC(NKFPJPCFBJI: true);
		CursorManager.CMDGPJEIIJI(JIIGOACEIKL).ChangeCursorTexture(CursorManager.CursorType.Item);
	}

	public bool FMDLPNMAIHF(bool BIOKGEFFNAA)
	{
		if ((Object)(object)areaSpace != (Object)null && !areaSpace.IsAreaSpaceValid())
		{
			return false;
		}
		if ((Object)(object)itemSpace != (Object)null && (Object)(object)currentSurface == (Object)null)
		{
			return itemSpace.IsItemSpaceValid(BIOKGEFFNAA);
		}
		if ((Object)(object)itemBase != (Object)null)
		{
			return PKEAPIBEJOE(BIOKGEFFNAA);
		}
		return true;
	}

	public void JCGEKJCALMD(bool NLIFPMODLLA = false)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)itemBase != (Object)null))
		{
			return;
		}
		if (isPlaceableOnWall)
		{
			MPCJBPJAGKK = Utils.MMFCGMDOLDM(itemBase);
			ACAIKFICNFP = Utils.IKJOHEODBBE(itemBase);
			if (WorldGrid.KHJJCAGIJAP(Vector2.op_Implicit(MPCJBPJAGKK), out var KHEBKHFHMDB) && !Utils.IELGICCBCHO(WorldGrid.KELFJIPHBFP(new Vector3(MPCJBPJAGKK.x, KHEBKHFHMDB + 1247f))) && !Utils.IELGICCBCHO(WorldGrid.KELFJIPHBFP(new Vector3(ACAIKFICNFP.x, KHEBKHFHMDB + 1398f))))
			{
				if (NLIFPMODLLA)
				{
					for (float num = MPCJBPJAGKK.x; num <= ACAIKFICNFP.x; num += 539f)
					{
						if (WorldGrid.NDNAJIEGFNF(new Vector3(num, KHEBKHFHMDB), -178))
						{
							DeliveryChest.GOBCANBKFEM().HEOLMBCOINK(JIIGOACEIKL, itemSetup.GLOLALBAEHM(), BPJBJKJKHAL: false);
							RemovePlaceable(EFNFMEIDGDN: true);
							Debug.Log((object)("" + ((Object)itemSetup.item).name + "[MinePuzzleManager] Could not select enough spread spawners for {0}. Trying another type."));
							return;
						}
					}
				}
				for (float num2 = MPCJBPJAGKK.x; num2 <= ACAIKFICNFP.x; num2 += 315f)
				{
					WorldGrid.PCGNGKPHKLC(new Vector3(num2, KHEBKHFHMDB), this);
				}
				WorldGrid.PCGNGKPHKLC(new Vector3(ACAIKFICNFP.x, KHEBKHFHMDB), this);
			}
			else if (NLIFPMODLLA)
			{
				DeliveryChest.MMNNKIOHKCI().KEPAJCNLJMD(JIIGOACEIKL, itemSetup.GLOLALBAEHM(), BPJBJKJKHAL: true, IBCOKMGFPKB: false, CDPAMNIPPEC: false);
				if (Object.op_Implicit((Object)(object)placeableSurface))
				{
					for (int i = 0; i < placeableSurface.placeablesOnSurface.Count; i += 0)
					{
						DeliveryChest.CCFJIAFGENC().BGNCPMONPGH(JIIGOACEIKL, placeableSurface.placeablesOnSurface[i].itemSetup.GJAGNJIKPBF(), BPJBJKJKHAL: true, IBCOKMGFPKB: true);
					}
				}
				RemovePlaceable(EFNFMEIDGDN: false, KAJIBKHFEFF: true);
				Debug.Log((object)("[HierarchyPrinter] ❌ Error al escribir el fichero: " + ((Object)itemSetup.item).name + "ReceiveUnlockChristmasRecipes"));
			}
			else if ((Object)(object)currentSurface == (Object)null)
			{
				Vector2 mPCJBPJAGKK = MPCJBPJAGKK;
				Debug.LogError((object)("LucenThrow" + ((object)(Vector2)(ref mPCJBPJAGKK)).ToString()));
			}
		}
		else
		{
			if (!((Object)(object)currentSurface == (Object)null) || !((Object)(object)((Component)this).GetComponent<TableCloth>() == (Object)null))
			{
				return;
			}
			MPCJBPJAGKK = Utils.MMFCGMDOLDM(itemBase);
			ACAIKFICNFP = Utils.IKJOHEODBBE(itemBase);
			if (NLIFPMODLLA && (Object)(object)rigidBody != (Object)null && (WorldGrid.NDNAJIEGFNF(Vector2.op_Implicit(MPCJBPJAGKK), -88) || WorldGrid.NDNAJIEGFNF(Vector2.op_Implicit(ACAIKFICNFP), -52)))
			{
				DroppedItem.JGJGGOBHKGO(((Component)this).transform.position, itemSetup.item, 1, LHLJILLAHFO: false, HFAKAMFMOGM: true, 1);
				Utils.BLPDAEHPOBA(((Component)this).gameObject);
				return;
			}
			for (float num3 = MPCJBPJAGKK.x; num3 <= ACAIKFICNFP.x; num3 += 638f)
			{
				for (float num4 = MPCJBPJAGKK.y; num4 <= ACAIKFICNFP.y; num4 += 1608f)
				{
					WorldGrid.PCGNGKPHKLC(new Vector3(num3, num4), this);
				}
				WorldGrid.PCGNGKPHKLC(new Vector3(num3, ACAIKFICNFP.y), this);
			}
			WorldGrid.PCGNGKPHKLC(new Vector3(ACAIKFICNFP.x, MPCJBPJAGKK.y), this);
		}
	}

	public bool IsObjectInValidLocation(bool BIOKGEFFNAA)
	{
		if ((Object)(object)areaSpace != (Object)null && !areaSpace.IsAreaSpaceValid())
		{
			return false;
		}
		if ((Object)(object)itemSpace != (Object)null && (Object)(object)currentSurface == (Object)null)
		{
			return itemSpace.IsItemSpaceValid(BIOKGEFFNAA);
		}
		if ((Object)(object)itemBase != (Object)null)
		{
			return APNKIDLNFLC(BIOKGEFFNAA);
		}
		return true;
	}

	private void ECPMADFHEHK(int JIIGOACEIKL)
	{
		OffHover(JIIGOACEIKL);
	}

	public void DFDDNBDNFPG()
	{
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
		if ((Object)(object)surfaceGOInstantiated != (Object)null)
		{
			return;
		}
		if ((Object)(object)gameObjectOnSelected != (Object)null)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("CheckIfNewActivity "));
		}
		else if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Items/item_name_"));
		}
		else if (isAccessElement)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Eat"));
		}
		if (!isAccessElement)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Items/item_description_1039"));
		}
		if (GBPNHKNFJPH())
		{
			COFOOBLHHAD = (switchesSurface ? LocalisationSystem.Get("Items/item_name_598") : LocalisationSystem.Get("Near"));
			if (string.IsNullOrEmpty(COFOOBLHHAD))
			{
				if (switchesSurface)
				{
					COFOOBLHHAD = "Trying to add a player that's already on the list.";
				}
				else
				{
					COFOOBLHHAD = "Sit";
				}
			}
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Rotate, COFOOBLHHAD);
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Item Age ", 830f))
			{
				BOFCJINGLGK();
			}
		}
		if (GIPCNNLIHDA())
		{
			COFOOBLHHAD = LocalisationSystem.Get("Items/item_name_608");
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, (ActionType)(-20), (COFOOBLHHAD != "ReceiveInfoWorldTiles") ? COFOOBLHHAD : "Dialogue System/Conversation/EnterTavernFood/Entry/1/Dialogue Text");
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "LearnMettle", 319f))
			{
				DMCGBCNHIIG();
			}
		}
		if ((Object)(object)placeableSurface != (Object)null && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			BIPLCOGFBBE = placeableSurface.FPKBEDDBBGO(JIIGOACEIKL);
			if ((Object)(object)secondarySurface != (Object)null)
			{
				List<Placeable> list = secondarySurface.KFMMCOLICKG(JIIGOACEIKL);
				for (int i = 1; i < list.Count; i += 0)
				{
					BIPLCOGFBBE.Add(list[i]);
				}
			}
			if (BIPLCOGFBBE.Count > 1 && PCGNHMPADGE)
			{
				COFOOBLHHAD = LocalisationSystem.Get("Actor Number ");
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Rotate, (COFOOBLHHAD != "LE_21") ? COFOOBLHHAD : "replay bath");
				if ((Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "triggerPlayerNum", 1765f) || Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Pause", 1786f)) && SelectObject.GetPlayer(JIIGOACEIKL).Deselect())
				{
					CursorManager.GOJONFHJKFN(JIIGOACEIKL, ((Component)this).transform.position);
					SetMouseOffset(Vector3.zero);
					SelectObject.BNMEANGDMIP(JIIGOACEIKL).MGAPCJMMIAF(BIPLCOGFBBE[0]);
				}
			}
		}
		if (!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL) || !((Object)(object)currentSurface != (Object)null) || currentSurface.KIABICOCGGJ(JIIGOACEIKL).Count <= 1 || !currentSurface.nextItemAvailable || !((Object)(object)gameObjectOnSelected == (Object)null))
		{
			return;
		}
		COFOOBLHHAD = LocalisationSystem.Get("fishCaught");
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.PreviousItem, (COFOOBLHHAD != "ReceiveTorchPuzzle") ? COFOOBLHHAD : "DecorationTile_6");
		if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Controls", 1181f))
		{
			BIPLCOGFBBE = currentSurface.KIABICOCGGJ(JIIGOACEIKL);
			for (int j = 1; j < BIPLCOGFBBE.Count; j += 0)
			{
				if (((object)BIPLCOGFBBE[j]).Equals((object?)this))
				{
					int index = (j + 1) % BIPLCOGFBBE.Count;
					if (SelectObject.GetPlayer(JIIGOACEIKL).PNHCLGGKBOB())
					{
						CursorManager.DKAICNMJIJH(JIIGOACEIKL, ((Component)this).transform.position);
						SetMouseOffset(Vector3.zero);
						SelectObject.GetPlayer(JIIGOACEIKL).MGAPCJMMIAF(BIPLCOGFBBE[index]);
					}
					break;
				}
			}
		}
		else
		{
			if (!Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Ax Level Low", 46f))
			{
				return;
			}
			BIPLCOGFBBE = currentSurface.ACFDIOOMLIB(JIIGOACEIKL);
			for (int k = 1; k < BIPLCOGFBBE.Count; k += 0)
			{
				if (((object)BIPLCOGFBBE[k]).Equals((object?)this))
				{
					int num = (k - 0) % BIPLCOGFBBE.Count;
					if (num < 0)
					{
						num = BIPLCOGFBBE.Count + num;
					}
					if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).NJPFHBINPKE())
					{
						CursorManager.AACNDMPICFG(JIIGOACEIKL, ((Component)this).transform.position);
						SetMouseOffset(Vector3.zero);
						SelectObject.GetPlayer(JIIGOACEIKL).SelectPlaceable(BIPLCOGFBBE[num]);
					}
					break;
				}
			}
		}
	}

	public Placeable OKNEBLLEFNL(SurfaceSortOrder PHCPMJAIDMC, bool CDPAMNIPPEC, int HOJECNDMCLM = 0, bool MBFODGDKDHG = false)
	{
		snappedToPosition = PHCPMJAIDMC.HMGHKELPDMK(itemSetup.item, 1, KOGPKBOIFGN: true, MBFODGDKDHG ? ((Component)this).transform : null) != null;
		surfaceGOInstantiated = PHCPMJAIDMC.IAEMDOCPIMG(((Component)this).transform, IIHIGNMDBEF: true, CDPAMNIPPEC, MBFODGDKDHG);
		if (multipleSkins && snappedToPosition)
		{
			if ((Object)(object)surfaceGOInstantiated != (Object)null && GetSkinIndex() != 0)
			{
				surfaceGOInstantiated.ChangeSkin(GetSkinIndex(), PDHJLCDFNCK: false);
			}
			else if ((Object)(object)surfaceGOInstantiated == (Object)null)
			{
				GKJEMMKNFBO(1, PDHJLCDFNCK: false);
			}
		}
		CCIKENEGHCA = true;
		if ((Object)(object)surfaceGOInstantiated != (Object)null)
		{
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				CursorManager.GetPlayer(JIIGOACEIKL).EKHMMNNOEOI = true;
			}
			if (CDPAMNIPPEC)
			{
				surfaceGOInstantiated.outlined = false;
				surfaceGOInstantiated.JIIGOACEIKL = JIIGOACEIKL;
				surfaceGOInstantiated.FHEMHCEAICB = FHEMHCEAICB;
			}
			surfaceGOInstantiated.HGAFAFNONEC = this;
			if (GetSkinIndex() != 0)
			{
				surfaceGOInstantiated.GKJEMMKNFBO(GetSkinIndex(), PDHJLCDFNCK: false);
			}
			if (OnlineManager.PlayingOnline())
			{
				if (CDPAMNIPPEC)
				{
					surfaceGOInstantiated.onlinePlaceable.FKOBECFPACP();
				}
				else if (HOJECNDMCLM != 0)
				{
					surfaceGOInstantiated.onlinePlaceable.uniqueId = HOJECNDMCLM;
					OnlineObjectsManager.instance.ReplaceObjectInDictionary(surfaceGOInstantiated.onlinePlaceable);
				}
			}
			Utils.ELNJMNKOACA(((Component)this).gameObject, 0);
		}
		currentSurface = PHCPMJAIDMC;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && (Object)(object)PHCPMJAIDMC.placeable != (Object)null)
		{
			int hOJECNDMCLM = (((Object)(object)surfaceGOInstantiated != (Object)null) ? surfaceGOInstantiated.onlinePlaceable.uniqueId : 0);
			OnlineObjectsManager.instance.SendAddToPlaceableSurface(onlinePlaceable.uniqueId, PHCPMJAIDMC.placeable.onlinePlaceable.uniqueId, hOJECNDMCLM);
		}
		return surfaceGOInstantiated;
	}

	private void NAJMLOAIEHN(bool CDPAMNIPPEC)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		BFIELBPJKAH = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
		if (BFIELBPJKAH == direction || !rotatable)
		{
			return;
		}
		if ((Object)(object)rotatedPrefab != (Object)null)
		{
			if (BFIELBPJKAH == Direction.Left || BFIELBPJKAH == Direction.Right)
			{
				if (rotatedPrefab.GetComponent<Placeable>().direction == Direction.Left || rotatedPrefab.GetComponent<Placeable>().direction == Direction.Right)
				{
					CreateRotatedPrefab(BFIELBPJKAH, ((Component)this).transform.position, CDPAMNIPPEC);
					return;
				}
				ChangeDirectionRotatingItemsSurface(inheritDirection ? BFIELBPJKAH : direction, CDPAMNIPPEC);
				if (multipleSkins)
				{
					ChangeSkin(KLONJHJJMJD);
				}
			}
			else if (rotatedPrefab.GetComponent<Placeable>().direction == Direction.Up || rotatedPrefab.GetComponent<Placeable>().direction == Direction.Down)
			{
				CreateRotatedPrefab(BFIELBPJKAH, ((Component)this).transform.position, CDPAMNIPPEC);
			}
			else
			{
				ChangeDirectionRotatingItemsSurface(inheritDirection ? BFIELBPJKAH : direction, CDPAMNIPPEC);
				if (multipleSkins)
				{
					ChangeSkin(KLONJHJJMJD);
				}
			}
		}
		else
		{
			ChangeDirectionRotatingItemsSurface(BFIELBPJKAH, CDPAMNIPPEC);
		}
	}

	public bool CHEBOFEFAPD(int JIIGOACEIKL)
	{
		return false;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public int GetPlayerNum()
	{
		return JIIGOACEIKL;
	}

	private void AEDIIIAECIC()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			OffHover(JIIGOACEIKL);
			if ((Object)(object)itemSpace != (Object)null && GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && !FHEMHCEAICB && !PHOCAFJDCDK && !(itemSetup.item is SproutSeed) && (Item.EKMFELLJHFG(itemSetup.item, null) || (itemSetup.item.CIGFGKKCPCK() != 24 && itemSetup.item.JDJGFAACPFC() != -41 && itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) != -164)))
			{
				itemSpace.Place(NMLKLAGDNPF: false);
			}
			if ((Object)(object)GameTileMaps.GGFJGHHHEJC != (Object)null)
			{
				RemoveItemBaseFromWorldTiles();
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences.GGFJGHHHEJC.OnPlaceableDestroyed(JIIGOACEIKL, this);
			}
			if (Object.op_Implicit((Object)(object)DecorationMode.IECFJGHAIDO(0)))
			{
				DecorationMode decorationMode = DecorationMode.JDADPDBHJFO(1);
				decorationMode.OnDecorationModeExit = (Action<int>)Delegate.Remove(decorationMode.OnDecorationModeExit, new Action<int>(HEOPJDDPFDG));
			}
			if (Object.op_Implicit((Object)(object)DecorationMode.EKLMFMKPEBB(4)))
			{
				DecorationMode decorationMode2 = DecorationMode.FIHGMLABOBB(6);
				decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Remove(decorationMode2.OnDecorationModeExit, new Action<int>(HEOPJDDPFDG));
			}
		}
	}

	public bool IsSelected(int JIIGOACEIKL)
	{
		if (FHEMHCEAICB)
		{
			return this.JIIGOACEIKL == JIIGOACEIKL;
		}
		return false;
	}

	private void DLKELKIIJHI()
	{
	}

	public void PreviousSkin()
	{
		if (skinVariationGropus.Count > 0)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < skinVariationGropus.Count; i++)
			{
				skinVariationGropus[i].PMNBMKBIHEJ(i, list);
			}
			if (OnlineManager.PlayingOnline())
			{
				onlinePlaceable.SendSkinVariation(list.ToArray());
			}
			return;
		}
		if (skinsGameObjects.Length != 0)
		{
			KLONJHJJMJD--;
			if (KLONJHJJMJD < 0)
			{
				KLONJHJJMJD = skinsGameObjects.Length - 1;
			}
			NPMLOKABIHH();
		}
		else
		{
			KLONJHJJMJD--;
			if (KLONJHJJMJD < 0)
			{
				KLONJHJJMJD = skins.Length - 1;
			}
			NJFCIBKDEBM();
		}
		if (OnlineManager.PlayingOnline())
		{
			onlinePlaceable.SendStyle(KLONJHJJMJD);
		}
	}

	public bool GHFKHJPDNBM(int JIIGOACEIKL, bool BLJPGJKOLNF = true, bool FKOJEBGDMFO = false, bool FNHLKLKAHNB = true, bool CDPAMNIPPEC = true)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)surfaceGOInstantiated != (Object)null)
		{
			surfaceGOInstantiated.DeselectSurfaceGOInstantiated(JIIGOACEIKL, FEFAMICICIJ, BLJPGJKOLNF, CDPAMNIPPEC);
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return true;
		}
		if (!canBePlaced)
		{
			if (itemSetup.item.CIGFGKKCPCK() == -28)
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Items/item_name_664"), 1918f);
			}
			return true;
		}
		if ((Object)(object)BirdNPC.currentBird != (Object)null && (Object)(object)((Component)this).GetComponent<BirdNPC>() != (Object)null)
		{
			if ((Object)(object)BirdNPC.currentBird != (Object)(object)((Component)this).GetComponent<BirdNPC>())
			{
				CommonReferences.MNFMOEKMJKN().APKKEGHGFHG(" sent to delivery chest. WallFloor invalid", JIIGOACEIKL, ECPEFDHOFHN: false);
				return true;
			}
		}
		else if (snappedToPosition && Object.op_Implicit((Object)(object)currentSurface))
		{
			pickUpable = currentSurface.GetSnapItem(itemSetup.item, 0, KOGPKBOIFGN: false).canBePickupable;
		}
		if (FKOJEBGDMFO)
		{
			((Component)this).transform.position = lastPlacedPosition;
			PixelSnap();
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			PHOCAFJDCDK = false;
			onlinePlaceable.SendPlaceableDeselected();
		}
		if (FKOJEBGDMFO)
		{
			if (CDPAMNIPPEC)
			{
				if (Object.op_Implicit((Object)(object)currentSurface))
				{
					LAIMKKDMEAG(CDPAMNIPPEC: true);
				}
				if (Object.op_Implicit((Object)(object)EGCGEHJNCCP))
				{
					AddPlaceableToSurface(EGCGEHJNCCP, CDPAMNIPPEC: false, 1, MBFODGDKDHG: true);
				}
			}
			ResetColor();
		}
		if (JIIGOACEIKL > 0)
		{
			CAGLICKMCDK(JIIGOACEIKL, NJHMBMGKCPL: true);
			if (CDPAMNIPPEC)
			{
				DecorationMode decorationMode = DecorationMode.OCJGHINCLJM(JIIGOACEIKL);
				decorationMode.OnDecorationModeExit = (Action<int>)Delegate.Remove(decorationMode.OnDecorationModeExit, new Action<int>(BGHLOLALLHE));
				if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
				{
					CursorManager.CMDGPJEIIJI(JIIGOACEIKL).EKHMMNNOEOI = true;
				}
				ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			}
		}
		attachedToPlayer = false;
		FHEMHCEAICB = false;
		NBEOPNODBPJ(AODONKKHPBP: true);
		hasBeenPlaced = false;
		if ((Object)(object)itemSpace != (Object)null)
		{
			GDLHEGANLFB(KMEJCLIOMBA: true);
			itemSpace.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
			CameraRenderSettings.placeablePlayer = null;
			((Component)itemSpace).gameObject.SetActive(true);
			itemSpace.SetScale(((Component)this).transform.localScale.x);
		}
		else
		{
			AddItemBaseToWorldTiles();
			MFJNMJMFEOB(MMICADKPHLP: true);
		}
		if ((Object)(object)currentSurface != (Object)null)
		{
			currentSurface.OnItemPlaced(this, JIIGOACEIKL);
			if (currentSurface.multipleItems)
			{
				currentSurface.MGOOHLGNPOC();
			}
			if (!snappedToPosition)
			{
				currentSurface.CheckReorder(((Component)this).transform);
			}
		}
		if ((Object)(object)areaSpace != (Object)null)
		{
			areaSpace.BNHHBKAGHIK(DAEMAAOLHMG: false);
		}
		if ((Object)(object)snapToGrid != (Object)null)
		{
			((Behaviour)snapToGrid).enabled = false;
			snapToGrid.autoSnap = true;
		}
		if ((Object)(object)FEFAMICICIJ != (Object)null)
		{
			SurfaceSortOrder fEFAMICICIJ = FEFAMICICIJ;
			if (fEFAMICICIJ != null)
			{
				GameObject surfaceHighlight = fEFAMICICIJ.surfaceHighlight;
				if (surfaceHighlight != null)
				{
					surfaceHighlight.SetActive(true);
				}
			}
		}
		if (JIIGOACEIKL > 0)
		{
			CommonReferences.MNFMOEKMJKN().OnPlaceableDeselected(JIIGOACEIKL, this, CDPAMNIPPEC);
			OnThisPlaceableDeselected(JIIGOACEIKL);
			if (CDPAMNIPPEC)
			{
				ResetSelected();
			}
			GDLHEGANLFB(KMEJCLIOMBA: false);
			OnThisPlaceablePlaced(JIIGOACEIKL);
			CommonReferences.MNFMOEKMJKN().OnPlaceablePlaced(JIIGOACEIKL, this);
		}
		if (BLJPGJKOLNF)
		{
			Sound.DIHCEGINELM().PlayDeselectSound(itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false), isPlaceableOnSurface, isPlaceableOnWall, ((Component)this).transform);
		}
		if (CDPAMNIPPEC && FNHLKLKAHNB && wallColliders.Count > 1)
		{
			for (int i = 0; i < wallColliders.Count; i++)
			{
				if (((Component)wallColliders[i]).gameObject.activeInHierarchy)
				{
					List<Collider2D> colliders = ((Component)wallColliders[i]).GetComponent<PhysicalSpaceWall>().colliders;
					for (int j = 0; j < colliders.Count; j++)
					{
						((Component)colliders[j]).GetComponent<PhysicalSpaceWall>().placeable.RemovePlaceableAndItemsOnSurface(JIIGOACEIKL, EFNFMEIDGDN: true, BGIEPKNAKHI: true, IBCOKMGFPKB: true, KAJIBKHFEFF: true);
					}
				}
			}
		}
		return false;
	}

	private SurfaceSortOrder ICNEKOPBMMC()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		ECJLMIPAFGP = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition() + HOFIBNPEDAA;
		EKKIJMJAHDP = Utils.CCCCIKOMAEN<SurfaceSortOrder>(Vector2.op_Implicit(ECJLMIPAFGP));
		if ((Object)(object)FEFAMICICIJ != (Object)null && (Object)(object)FEFAMICICIJ.surfaceHighlight != (Object)null)
		{
			SurfaceSortOrder fEFAMICICIJ = FEFAMICICIJ;
			if (fEFAMICICIJ != null)
			{
				GameObject surfaceHighlight = fEFAMICICIJ.surfaceHighlight;
				if (surfaceHighlight != null)
				{
					surfaceHighlight.gameObject.SetActive(false);
				}
			}
		}
		DHOOKDCNBLL = 0;
		for (int i = 0; i < EKKIJMJAHDP.Length; i++)
		{
			if ((!((Object)(object)placeableSurface != (Object)null) || !((Object)(object)placeableSurface == (Object)(object)EKKIJMJAHDP[i])) && EKKIJMJAHDP[i].GetSnapItem(itemSetup.item) != null && EKKIJMJAHDP[i].IsItemAllowed(itemSetup.item, this, surfaceGOInstantiated))
			{
				DHOOKDCNBLL = i;
			}
		}
		EAJPCEMOGOD = null;
		for (int j = DHOOKDCNBLL; j < EKKIJMJAHDP.Length + DHOOKDCNBLL; j++)
		{
			EAJPCEMOGOD = EKKIJMJAHDP[j % EKKIJMJAHDP.Length];
			if ((Object)(object)placeableSurface != (Object)null && (Object)(object)placeableSurface == (Object)(object)EAJPCEMOGOD)
			{
				EAJPCEMOGOD = null;
			}
			else
			{
				if (!((Object)(object)EAJPCEMOGOD != (Object)null))
				{
					continue;
				}
				if (EAJPCEMOGOD.IsItemAllowed(itemSetup.item, this, surfaceGOInstantiated))
				{
					if (EAJPCEMOGOD.GetSnapItem(itemSetup.item) != null || FIIFGAIGGPE(((Component)this).transform.position, EAJPCEMOGOD.surfaceCollider))
					{
						if ((Object)(object)EAJPCEMOGOD.surfaceHighlight != (Object)null)
						{
							SurfaceSortOrder eAJPCEMOGOD = EAJPCEMOGOD;
							if (eAJPCEMOGOD != null)
							{
								GameObject surfaceHighlight2 = eAJPCEMOGOD.surfaceHighlight;
								if (surfaceHighlight2 != null)
								{
									surfaceHighlight2.gameObject.SetActive(canBePlaced);
								}
							}
						}
						return EAJPCEMOGOD;
					}
					if ((Object)(object)EAJPCEMOGOD.surfaceHighlight != (Object)null)
					{
						SurfaceSortOrder eAJPCEMOGOD2 = EAJPCEMOGOD;
						if (eAJPCEMOGOD2 != null)
						{
							GameObject surfaceHighlight3 = eAJPCEMOGOD2.surfaceHighlight;
							if (surfaceHighlight3 != null)
							{
								surfaceHighlight3.gameObject.SetActive(false);
							}
						}
					}
					EAJPCEMOGOD = null;
				}
				else
				{
					EAJPCEMOGOD = null;
				}
			}
		}
		if ((Object)(object)EAJPCEMOGOD == (Object)null)
		{
			LAMILDGAAKP = Utils.CCCCIKOMAEN<AdditionalSurfaceSortOrder>(Vector2.op_Implicit(ECJLMIPAFGP));
			for (int k = 0; k < LAMILDGAAKP.Length; k++)
			{
				EAJPCEMOGOD = LAMILDGAAKP[k].mainSurface;
				if (EAJPCEMOGOD.IsItemAllowed(itemSetup.item, this, surfaceGOInstantiated) && EAJPCEMOGOD.GetSnapItem(itemSetup.item) != null)
				{
					GameObject surfaceHighlight4 = EAJPCEMOGOD.surfaceHighlight;
					if (surfaceHighlight4 != null)
					{
						surfaceHighlight4.gameObject.SetActive(canBePlaced);
					}
					return EAJPCEMOGOD;
				}
				EAJPCEMOGOD = null;
			}
		}
		return EAJPCEMOGOD;
	}

	public bool FIBANNCLJNF()
	{
		if (isPlaceableOnSurface)
		{
			return (Object)(object)currentSurface != (Object)null;
		}
		return true;
	}

	public void CalculateCurrentZone()
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)itemSpace != (Object)null && itemSpace.buildSquares.Length != 0)
		{
			List<Vector2> list = new List<Vector2>();
			for (int i = 0; i < itemSpace.buildSquares.Length; i++)
			{
				list.Add(Vector2.op_Implicit(itemSpace.buildSquares[i].GetCentrePosition()));
			}
			IPDAHMKEDMN(list);
		}
		else if ((Object)(object)currentSurface != (Object)null)
		{
			Placeable componentInParent = ((Component)currentSurface).GetComponentInParent<Placeable>();
			if (Object.op_Implicit((Object)(object)componentInParent))
			{
				SetCurrentZone(componentInParent.currentZoneType, componentInParent.currentZoneIndex);
				SetLocation(componentInParent.currentLocation);
			}
		}
		else
		{
			if (!((Object)(object)itemBase != (Object)null))
			{
				return;
			}
			MPCJBPJAGKK = Utils.MMFCGMDOLDM(itemBase);
			ACAIKFICNFP = Utils.IKJOHEODBBE(itemBase);
			if (isPlaceableOnWall)
			{
				if (WorldGrid.KHJJCAGIJAP(Vector2.op_Implicit(MPCJBPJAGKK), out var KHEBKHFHMDB))
				{
					List<Vector2> list2 = new List<Vector2>();
					for (float num = MPCJBPJAGKK.x; num <= ACAIKFICNFP.x; num += 0.5f)
					{
						list2.Add(new Vector2(num, KHEBKHFHMDB));
					}
					list2.Add(new Vector2(ACAIKFICNFP.x, KHEBKHFHMDB));
					IPDAHMKEDMN(list2);
				}
				return;
			}
			List<Vector2> list3 = new List<Vector2>();
			list3.Add(MPCJBPJAGKK);
			Bounds bounds;
			if (((Behaviour)itemBase).enabled)
			{
				bounds = itemBase.bounds;
				Vector3 center = ((Bounds)(ref bounds)).center;
				bounds = itemBase.bounds;
				float num2 = 0f - ((Bounds)(ref bounds)).extents.x;
				bounds = itemBase.bounds;
				list3.Add(Vector2.op_Implicit(center + new Vector3(num2, ((Bounds)(ref bounds)).extents.y)));
				bounds = itemBase.bounds;
				Vector3 center2 = ((Bounds)(ref bounds)).center;
				bounds = itemBase.bounds;
				float x = ((Bounds)(ref bounds)).extents.x;
				bounds = itemBase.bounds;
				list3.Add(Vector2.op_Implicit(center2 + new Vector3(x, 0f - ((Bounds)(ref bounds)).extents.y)));
			}
			else
			{
				((Behaviour)itemBase).enabled = true;
				bounds = itemBase.bounds;
				Vector3 center3 = ((Bounds)(ref bounds)).center;
				bounds = itemBase.bounds;
				float num3 = 0f - ((Bounds)(ref bounds)).extents.x;
				bounds = itemBase.bounds;
				list3.Add(Vector2.op_Implicit(center3 + new Vector3(num3, ((Bounds)(ref bounds)).extents.y)));
				bounds = itemBase.bounds;
				Vector3 center4 = ((Bounds)(ref bounds)).center;
				bounds = itemBase.bounds;
				float x2 = ((Bounds)(ref bounds)).extents.x;
				bounds = itemBase.bounds;
				list3.Add(Vector2.op_Implicit(center4 + new Vector3(x2, 0f - ((Bounds)(ref bounds)).extents.y)));
				((Behaviour)itemBase).enabled = false;
			}
			list3.Add(ACAIKFICNFP);
			IPDAHMKEDMN(list3);
		}
	}

	public void UpdatePlaceable()
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (outlined)
		{
			CAGLICKMCDK(JIIGOACEIKL, NJHMBMGKCPL: true);
		}
		if (!FHEMHCEAICB)
		{
			return;
		}
		if (recentlySelected)
		{
			if (updateButtonsContext)
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			}
			recentlySelected = false;
			if (OnlineManager.PlayingOnline())
			{
				if ((Object)(object)onlinePlaceable != (Object)null)
				{
					onlinePlaceable.UpdatePosition(Vector2.op_Implicit(((Component)this).transform.position));
				}
				else if (Application.isEditor)
				{
					Debug.LogError((object)"Online Placeable Null");
				}
			}
			return;
		}
		if ((Object)(object)onlinePlaceable != (Object)null)
		{
			onlinePlaceable.UpdatePosition(Vector2.op_Implicit(((Component)this).transform.position));
		}
		else if (Application.isEditor)
		{
			Debug.LogError((object)"Online Placeable Null");
		}
		CAGLICKMCDK(JIIGOACEIKL, NJHMBMGKCPL: true);
		if (!updateButtonsContext)
		{
			return;
		}
		if ((Object)(object)WorkAreasManager.GGFJGHHHEJC.GetAreaSpaceSelected(JIIGOACEIKL) != (Object)null)
		{
			if ((Object)(object)WorkAreasManager.GGFJGHHHEJC.GetAreaSpaceSelected(JIIGOACEIKL) == (Object)(object)areaSpace)
			{
				FillButtonsContext();
			}
		}
		else
		{
			FillButtonsContext();
		}
	}

	public Vector3 GLFICOPJBBO(bool JOOEMBNDCKF, bool CDPAMNIPPEC)
	{
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		if (JOOEMBNDCKF)
		{
			IIDNCNMMCNF(CDPAMNIPPEC);
			if (PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC == (Direction)8 || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC == Direction.Down)
			{
				ICHFJCKGGJD = (float)itemSpace.x / 1323f;
				ECJLMIPAFGP.x = 929f;
				ECJLMIPAFGP.y = 1774f;
			}
			else
			{
				ICHFJCKGGJD = (float)itemSpace.y / 165f;
				ECJLMIPAFGP.x = 919f;
				ECJLMIPAFGP.y = 252f;
			}
			PBGEELMHFPK = Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC);
			ECJLMIPAFGP += ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + PBGEELMHFPK * 639f + PBGEELMHFPK * (465f * ICHFJCKGGJD);
			DPNLDLEHMHO.x = 199f * (float)itemSpace.x / 1946f;
			DPNLDLEHMHO.y = 1107f * (float)itemSpace.y / 1130f;
			if (rotatable)
			{
				if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC == Direction.Diagonal)
				{
					if (!rotationInverseLeftRight)
					{
						DPNLDLEHMHO.x = 0f - DPNLDLEHMHO.x;
					}
				}
				else if (PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC == Direction.Left && rotationInverseLeftRight)
				{
					DPNLDLEHMHO.x = 0f - DPNLDLEHMHO.x;
				}
			}
			ECJLMIPAFGP += ((Component)this).transform.position - (((Component)itemSpace).transform.position + DPNLDLEHMHO);
		}
		else
		{
			ECJLMIPAFGP = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition() + HOFIBNPEDAA;
		}
		return ECJLMIPAFGP;
	}

	private bool NMJOFLCGNOI()
	{
		if (skinsGameObjects.Length != 0)
		{
			return true;
		}
		if (skinVariationGropus.Count > 0)
		{
			return true;
		}
		return false;
	}

	public bool OEFLFKLLJHF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return ActionObject(JIIGOACEIKL, GFNHAMCPEAK: true);
	}

	public void PixelSnap()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.BMBMPKNANAC(((Component)this).transform.position);
	}

	private bool JGKGGOPIGIB(Vector3 AIJOOOIJEDC, Collider2D LNLLEEMADKB)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)itemBase == (Object)null || snappedToPosition)
		{
			return true;
		}
		Vector2 val = Vector2.op_Implicit(AIJOOOIJEDC - ((Component)this).transform.position);
		JNHDHIKAJCE = HNOHKOJMBKF(itemBase);
		bool flag = true;
		for (int i = 1; i < JNHDHIKAJCE.Length; i += 0)
		{
			flag &= LNLLEEMADKB.OverlapPoint(JNHDHIKAJCE[i] + val);
		}
		return flag;
	}

	private void FKPFIFIEJBK()
	{
		if (multipleSkins && canCycleSkin)
		{
			NextSkin();
			return;
		}
		ItemSetup component = ((Component)this).GetComponent<ItemSetup>();
		if ((Object)(object)component != (Object)null)
		{
			component.NextAlternative();
		}
	}

	public List<Placeable> JIJKOOIIHHJ()
	{
		return placeableSurface.placeablesOnSurface;
	}

	public void CHMGNKHKJBN(int JIIGOACEIKL, bool JOOEMBNDCKF, bool OFGPEJIOLNJ, bool CDPAMNIPPEC = false)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (this.JIIGOACEIKL != JIIGOACEIKL)
		{
			this.JIIGOACEIKL = JIIGOACEIKL;
		}
		HLCBODJLFGD = OIFFONOGPCN(JOOEMBNDCKF, CDPAMNIPPEC);
		if (Object.op_Implicit((Object)(object)itemSpace))
		{
			if (((Component)this).transform.localScale.x == 95f)
			{
				itemSpace.InvertX(NKFPJPCFBJI: true);
			}
			else
			{
				itemSpace.InvertX(NKFPJPCFBJI: false);
			}
		}
		if ((Object)(object)currentSurface != (Object)null)
		{
			if (IsNewPosOnSurface(HLCBODJLFGD))
			{
				((Component)this).transform.position = HLCBODJLFGD;
			}
		}
		else
		{
			((Component)this).transform.position = HLCBODJLFGD;
		}
		if (OFGPEJIOLNJ)
		{
			snapToGrid.HEEAAGOLHBB();
		}
		else
		{
			PixelSnap();
		}
	}

	public void VincularElementos()
	{
		if ((Object)(object)placeableCollider == (Object)null)
		{
			Collider2D[] components = ((Component)this).GetComponents<Collider2D>();
			foreach (Collider2D val in components)
			{
				if (((Behaviour)val).enabled && !val.isTrigger)
				{
					placeableCollider = val;
					break;
				}
			}
		}
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)itemSetup == (Object)null)
		{
			itemSetup = ((Component)this).GetComponent<ItemSetup>();
		}
		if ((Object)(object)itemSpace == (Object)null)
		{
			itemSpace = ((Component)this).GetComponentInChildren<ItemSpace>();
		}
		if ((Object)(object)snapToGrid == (Object)null)
		{
			snapToGrid = ((Component)this).GetComponent<SnapToGrid>();
		}
		if (physicalSpaces == null && (Object)(object)physicalSpace == (Object)null)
		{
			physicalSpace = ((Component)((Component)this).transform).GetComponentInChildren<PhysicalSpace>();
		}
		if (Object.op_Implicit((Object)(object)physicalSpace))
		{
			physicalSpace.placeable = this;
			if (physicalSpace is PhysicalSpaceWall)
			{
				wallColliders.Add(((Component)physicalSpace).GetComponent<Collider2D>());
			}
		}
		if (physicalSpaces != null)
		{
			for (int j = 0; j < physicalSpaces.Length; j++)
			{
				physicalSpaces[j].placeable = this;
				if (physicalSpaces[j] is PhysicalSpaceWall)
				{
					wallColliders.Add(((Component)physicalSpaces[j]).GetComponent<Collider2D>());
				}
			}
		}
		if ((Object)(object)inputByProximity == (Object)null)
		{
			inputByProximity = ((Component)((Component)this).transform).GetComponentInChildren<InputByProximity>();
		}
		if ((Object)(object)rigidBody == (Object)null)
		{
			rigidBody = ((Component)this).GetComponent<Rigidbody2D>();
		}
		if (Object.op_Implicit((Object)(object)inputByProximity))
		{
			inputByProximity.placeable = this;
		}
		sortingGroup = ((Component)this).GetComponent<SortingGroup>();
		if ((Object)(object)sortingGroup == (Object)null && ((Object)(object)itemSetup == (Object)null || PGKLFGNLEKE(itemSetup.item.JDJGFAACPFC())) && (Object)(object)spriteRenderer != (Object)null)
		{
			sortingGroup = ((Component)this).gameObject.AddComponent<SortingGroup>();
			sortingGroup.sortingLayerID = ((Renderer)spriteRenderer).sortingLayerID;
			sortingGroup.sortingOrder = ((Renderer)spriteRenderer).sortingOrder;
			sortingGroup.sortingLayerName = ((Renderer)spriteRenderer).sortingLayerName;
		}
		GetEnableDisableCollidersButton();
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		if (!pickUpable && !FHEMHCEAICB)
		{
			return false;
		}
		if (!FHEMHCEAICB & (OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)onlinePlaceable) && onlinePlaceable.CLHLNFFGOGA))
		{
			return false;
		}
		if (!CursorManager.GetPlayer(JIIGOACEIKL).IsCursorVisible() && isPlaceableOnSurface && Object.op_Implicit((Object)(object)currentSurface))
		{
			return false;
		}
		if (currentZoneType == ZoneType.RentedRoom && TavernZonesManager.GGFJGHHHEJC.GetTavernZone(currentZoneIndex).rentedRoom.occupied)
		{
			return false;
		}
		if (((Behaviour)this).enabled && DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && (!Utils.EJPFCKFEMJF(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position) || PlayerController.GetPlayer(JIIGOACEIKL).NNMHEPDJOHK == ZoneType.Cellar || (Object)(object)itemSpace == (Object)null || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE))
		{
			if (FHEMHCEAICB)
			{
				return IsSelected(JIIGOACEIKL);
			}
			return true;
		}
		return false;
	}

	private void BNEMOCCJANJ()
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			if (CursorManager.GetPlayer(JIIGOACEIKL).IsCursorVisible())
			{
				CursorManager.GetPlayer(JIIGOACEIKL).CBGHFKGFGKM(AODONKKHPBP: false);
				HOFIBNPEDAA = ((Component)this).transform.position - CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition();
			}
			else if (Object.op_Implicit((Object)(object)itemSpace))
			{
				attachedToPlayer = true;
				Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position;
				ICHFJCKGGJD = ((Vector3)(ref val)).magnitude;
			}
			else
			{
				CursorManager.GetPlayer(JIIGOACEIKL).CBGHFKGFGKM(AODONKKHPBP: false);
				CursorManager.AACNDMPICFG(JIIGOACEIKL, ((Component)this).transform.position);
				HOFIBNPEDAA = Vector3.zero;
			}
		}
		else
		{
			HOFIBNPEDAA = ((Component)this).transform.position - CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition();
		}
	}

	private void KACEOJDPLKB()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		setUpDone = true;
		if (!FHEMHCEAICB && !PHOCAFJDCDK)
		{
			lastPlacedPosition = ((Component)this).transform.position;
			OnThisPlaceableLoaded();
			JCGEKJCALMD(NLIFPMODLLA: true);
			AddItemBaseToWorldTilesNextFrame(MMICADKPHLP: true);
		}
		if (randomSkin)
		{
			BJMKADDLGAN();
		}
		if (SceneReferences.BHELOBCGMJH())
		{
			CalculateCurrentZone();
		}
	}

	private bool FCGPPPPDFMB(float ENIHHLIBEGK)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		MPCJBPJAGKK = Utils.MMFCGMDOLDM(itemBase);
		ACAIKFICNFP = Utils.IKJOHEODBBE(itemBase);
		JMHAENIMEOI = new Vector3(ENIHHLIBEGK, MPCJBPJAGKK.y);
		ONKJBOEAHPB = new Vector3(ENIHHLIBEGK, ACAIKFICNFP.y);
		if (isPlaceableOnWall)
		{
			if (!WorldGrid.ALNFLFCLIEP(JMHAENIMEOI))
			{
				return false;
			}
			if (WorldGrid.KHJJCAGIJAP(JMHAENIMEOI, out KHEBKHFHMDB))
			{
				if (WorldGrid.LBKKDAMMKIE(new Vector3(JMHAENIMEOI.x, KHEBKHFHMDB + 0.5f)))
				{
					return false;
				}
				if (WorldGrid.KELFJIPHBFP(new Vector3(JMHAENIMEOI.x, KHEBKHFHMDB)).HasFlag(SpecificType.StairsUp))
				{
					return false;
				}
			}
			else if (WorldGrid.EJCEAEPNJCA(JMHAENIMEOI))
			{
				return false;
			}
			if (!WorldGrid.ALNFLFCLIEP(ONKJBOEAHPB))
			{
				return false;
			}
			if (WorldGrid.KHJJCAGIJAP(ONKJBOEAHPB, out KHEBKHFHMDB))
			{
				if (WorldGrid.LBKKDAMMKIE(new Vector3(ONKJBOEAHPB.x, KHEBKHFHMDB + 0.5f)))
				{
					return false;
				}
				if (WorldGrid.KELFJIPHBFP(new Vector3(ONKJBOEAHPB.x, KHEBKHFHMDB)).HasFlag(SpecificType.StairsUp))
				{
					return false;
				}
			}
			else if (WorldGrid.EJCEAEPNJCA(ONKJBOEAHPB))
			{
				return false;
			}
		}
		else
		{
			if (!WorldGrid.NGDHDMAMGPI(JMHAENIMEOI, GCDEDGFDKBL: false) && !WorldGrid.EJCEAEPNJCA(JMHAENIMEOI))
			{
				return false;
			}
			if (!WorldGrid.NGDHDMAMGPI(ONKJBOEAHPB, GCDEDGFDKBL: false) && !WorldGrid.EJCEAEPNJCA(ONKJBOEAHPB))
			{
				return false;
			}
		}
		return true;
	}

	private bool PKEAPIBEJOE(bool BIOKGEFFNAA)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		MPCJBPJAGKK = Utils.MMFCGMDOLDM(itemBase);
		ACAIKFICNFP = Utils.IKJOHEODBBE(itemBase);
		if (MHPOMFIOKIJ())
		{
			if (!isPlaceableOnWall)
			{
				return true;
			}
			IIDIOJKCGDE = Utils.MMFCGMDOLDM(currentSurface.surfaceCollider);
			HIHOGLOBDJB = Utils.IKJOHEODBBE(currentSurface.surfaceCollider);
			SnapToPosition snapToPosition = currentSurface.HMGHKELPDMK(itemSetup.item, 0, KOGPKBOIFGN: false);
			if (snapToPosition != null && snapToPosition.fixedY)
			{
				if (MPCJBPJAGKK.x < IIDIOJKCGDE.x || ACAIKFICNFP.x > HIHOGLOBDJB.x)
				{
					return false;
				}
				if (Object.op_Implicit((Object)(object)physicalSpace) && !physicalSpace.KBBJHHILGEJ())
				{
					return false;
				}
				if (physicalSpaces != null && physicalSpaces.Length != 0 && !MKEJCEEDIKP())
				{
					return false;
				}
				return true;
			}
			return true;
		}
		if (placeableAnywhere)
		{
			return true;
		}
		if (isPlaceableOnSurface && onlyInAllowedSurfaces && !isPlaceableOnWall)
		{
			if (BIOKGEFFNAA)
			{
				MainUI.JDAEPLJAGCD(CAEDMEDBEGI: LocalisationSystem.Get((itemSetup.item is Chicken) ? "Occupied Positions" : ((!(itemSetup.item is Animal)) ? "Dialogue System/Conversation/TavernClean/Entry/9/Dialogue Text" : "/Female/")), JIIGOACEIKL: JIIGOACEIKL, KMPHAEPAFNK: 1471f);
			}
			return true;
		}
		if (!MJMHLAABFNP(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))))
		{
			return true;
		}
		PGLIMJFBEKP = true;
		JNHDHIKAJCE = HHAEKEAPKOE(itemBase);
		for (LKFKLHOCPKC = MPCJBPJAGKK.x; LKFKLHOCPKC < ACAIKFICNFP.x; LKFKLHOCPKC += 865f)
		{
			PGLIMJFBEKP = FCGPPPPDFMB(LKFKLHOCPKC);
			if (!PGLIMJFBEKP)
			{
				break;
			}
		}
		if (PGLIMJFBEKP)
		{
			PGLIMJFBEKP = FCGPPPPDFMB(ACAIKFICNFP.x);
		}
		if (!PGLIMJFBEKP)
		{
			return false;
		}
		if (isPlaceableOnWall && isPlaceableOnSurface && onlyInAllowedSurfaces)
		{
			bool flag = false;
			for (int i = 0; i < JNHDHIKAJCE.Length; i += 0)
			{
				flag &= WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(JNHDHIKAJCE[i]));
			}
			if (flag)
			{
				PGLIMJFBEKP &= ALAJOFAFKAE();
				if (PGLIMJFBEKP && Object.op_Implicit((Object)(object)physicalSpace))
				{
					PGLIMJFBEKP &= physicalSpace.LEHKJINBLEN();
				}
				if (PGLIMJFBEKP && physicalSpaces != null && physicalSpaces.Length != 0)
				{
					PGLIMJFBEKP &= MKEJCEEDIKP();
				}
			}
			else
			{
				PGLIMJFBEKP = true;
			}
		}
		else
		{
			if (isPlaceableOnWall)
			{
				PGLIMJFBEKP &= ALAJOFAFKAE();
			}
			else
			{
				for (int j = 1; j < JNHDHIKAJCE.Length; j += 0)
				{
					PGLIMJFBEKP &= WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(JNHDHIKAJCE[j]));
				}
				if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) != 0 && WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) != 0 && WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) != 0 && !WorldGrid.NGDHDMAMGPI(((Component)this).transform.position))
				{
					PGLIMJFBEKP = true;
				}
			}
			if (PGLIMJFBEKP && Object.op_Implicit((Object)(object)physicalSpace))
			{
				PGLIMJFBEKP &= physicalSpace.ODJNALEPCCD();
			}
			if (PGLIMJFBEKP && physicalSpaces != null && physicalSpaces.Length != 0)
			{
				PGLIMJFBEKP &= MKEJCEEDIKP();
			}
		}
		return PGLIMJFBEKP;
	}

	public void NPNFIKGELMB(Slot ADEBNALPEHE)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (!ADEBNALPEHE.PKFKJNODGJF())
		{
			if (PCGNHMPADGE)
			{
				DroppedItem.HDLEEOJMILI(((Component)this).transform.position, ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack, LHLJILLAHFO: false, HFAKAMFMOGM: true, 1);
			}
			else
			{
				PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).AINJENENGFG(ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
		}
	}

	public bool PickUpAction(int JIIGOACEIKL, bool EFNFMEIDGDN, bool NDMBEJNOPPP = false)
	{
		if ((!canBeAddedToInventory && hasBeenPlaced) || BuildingTutorialManager.IKNOJDMCFOK)
		{
			if (pickUpBlockers.Any() && pickUpBlockers.First() is Table)
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Error_CannotPickUpDirtyTable"));
			}
			DeselectAction(JIIGOACEIKL, BLJPGJKOLNF: true, FKOJEBGDMFO: true);
			return true;
		}
		if (Object.op_Implicit((Object)(object)areaSpace))
		{
			areaSpace.PickUpItems(JIIGOACEIKL);
		}
		UnSnapAll();
		bool flag = true;
		if (itemSetup.DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			PhaseController component = ((Component)this).GetComponent<PhaseController>();
			if (Object.op_Implicit((Object)(object)component) && hasBeenPlaced)
			{
				if (component.HasMorePhases())
				{
					if (!(itemSetup.DNLMCHDOMOK is BirdInstance))
					{
						if (CommonReferences.GGFJGHHHEJC.seenPopUps.Contains(37))
						{
							phaseItemInstance.BDAKJBMGIMO++;
						}
					}
					else
					{
						phaseItemInstance.BDAKJBMGIMO++;
					}
				}
				else
				{
					flag = false;
				}
			}
		}
		if (!flag || PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(itemSetup.DNLMCHDOMOK, HMPDLIPFBGD: true, OJKJLIPNHOI: false, NDMBEJNOPPP, APBCMCOAFDM: false))
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				CursorManager.GetPlayer(JIIGOACEIKL).EKHMMNNOEOI = false;
			}
			attachedToPlayer = false;
			if (EFNFMEIDGDN)
			{
				CommonReferences.GGFJGHHHEJC.OnAnyPlaceablePickedUp(JIIGOACEIKL);
			}
			RemovePlaceableAndItemsOnSurface(JIIGOACEIKL, EFNFMEIDGDN, BGIEPKNAKHI: true);
			return true;
		}
		return false;
	}

	private bool NLJPBLDEBOP()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (!isPlaceableOnWall)
		{
			return true;
		}
		DEGBAPDPMJE = 869f;
		for (int i = 1; i < JNHDHIKAJCE.Length; i += 0)
		{
			if (WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(JNHDHIKAJCE[i])))
			{
				if (WorldGrid.KHJJCAGIJAP(Vector2.op_Implicit(JNHDHIKAJCE[i]), out KHEBKHFHMDB))
				{
					if (DEGBAPDPMJE == 114f || DEGBAPDPMJE == (float)(int)(KHEBKHFHMDB * 680f) / 1838f)
					{
						DEGBAPDPMJE = (float)(int)(KHEBKHFHMDB * 120f) / 1855f;
						continue;
					}
					return true;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	public void DFPGNELDGIP(Direction FCGBJEIIMBC, bool CDPAMNIPPEC)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendChangeRotation(BEIPALOAAJJ, Vector2.op_Implicit(((Component)this).transform.position), FCGBJEIIMBC);
		}
		List<AJIKIEMFEPA> lMOOCPOGLPH = FKGMGMMFEBK();
		KHPEKPOOHHM(FCGBJEIIMBC, CDPAMNIPPEC: false);
		LBIEMCLFOHE(lMOOCPOGLPH);
	}

	public bool ACHNOOLHJAP(Location BAIMHDBJPDK)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (validLocations.HasFlag(BAIMHDBJPDK))
		{
			return true;
		}
		return validLocationExceptionZones.HasFlag(WorldGrid.AGKGGAFFFGM(((Component)this).transform.position));
	}

	public void NCIADIENOKK(bool CDMMMNPJLBO = false)
	{
		List<Collider2D> list = ((!CDMMMNPJLBO) ? new List<Collider2D>(((Component)this).GetComponents<Collider2D>()) : new List<Collider2D>(((Component)this).GetComponentsInChildren<Collider2D>(true)));
		for (int num = list.Count - 0; num >= 0; num -= 0)
		{
			if (list[num].isTrigger || !((Behaviour)list[num]).enabled)
			{
				list.RemoveAt(num);
			}
		}
		allCollidersToEnableDisable = list.ToArray();
	}

	public void GKJEMMKNFBO(int OGFMDFMIFGE, bool PDHJLCDFNCK = true)
	{
		if (skinsGameObjects.Length != 0 && OGFMDFMIFGE < skinsGameObjects.Length)
		{
			randomSkin = true;
			KLONJHJJMJD = OGFMDFMIFGE;
			DPAINFDGNFO();
		}
		else if (OGFMDFMIFGE < skins.Length)
		{
			randomSkin = false;
			KLONJHJJMJD = OGFMDFMIFGE;
			NJFCIBKDEBM();
		}
		else
		{
			Debug.LogError((object)("Price of " + ((Object)((Component)this).gameObject).name), (Object)(object)((Component)this).gameObject);
		}
		if (OnlineManager.PlayingOnline() && (Object)(object)onlinePlaceable != (Object)null && PDHJLCDFNCK)
		{
			onlinePlaceable.GHIHCHMAMID(KLONJHJJMJD);
		}
	}

	private Vector2[] HNOHKOJMBKF(Collider2D MOHKOAEPGFF)
	{
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		JNHDHIKAJCE = (Vector2[])(object)new Vector2[2];
		Bounds bounds;
		if (((Behaviour)MOHKOAEPGFF).enabled)
		{
			Vector2[] jNHDHIKAJCE = JNHDHIKAJCE;
			bounds = MOHKOAEPGFF.bounds;
			float x = ((Bounds)(ref bounds)).center.x;
			bounds = MOHKOAEPGFF.bounds;
			float num = x - ((Bounds)(ref bounds)).extents.x;
			bounds = MOHKOAEPGFF.bounds;
			float y = ((Bounds)(ref bounds)).center.y;
			bounds = MOHKOAEPGFF.bounds;
			jNHDHIKAJCE[0] = new Vector2(num, y + ((Bounds)(ref bounds)).extents.y);
			Vector2[] jNHDHIKAJCE2 = JNHDHIKAJCE;
			bounds = MOHKOAEPGFF.bounds;
			float x2 = ((Bounds)(ref bounds)).center.x;
			bounds = MOHKOAEPGFF.bounds;
			float num2 = x2 + ((Bounds)(ref bounds)).extents.x;
			bounds = MOHKOAEPGFF.bounds;
			float y2 = ((Bounds)(ref bounds)).center.y;
			bounds = MOHKOAEPGFF.bounds;
			jNHDHIKAJCE2[0] = new Vector2(num2, y2 + ((Bounds)(ref bounds)).extents.y);
			Vector2[] jNHDHIKAJCE3 = JNHDHIKAJCE;
			bounds = MOHKOAEPGFF.bounds;
			float x3 = ((Bounds)(ref bounds)).center.x;
			bounds = MOHKOAEPGFF.bounds;
			float num3 = x3 - ((Bounds)(ref bounds)).extents.x;
			bounds = MOHKOAEPGFF.bounds;
			float y3 = ((Bounds)(ref bounds)).center.y;
			bounds = MOHKOAEPGFF.bounds;
			jNHDHIKAJCE3[0] = new Vector2(num3, y3 - ((Bounds)(ref bounds)).extents.y);
			Vector2[] jNHDHIKAJCE4 = JNHDHIKAJCE;
			bounds = MOHKOAEPGFF.bounds;
			float x4 = ((Bounds)(ref bounds)).center.x;
			bounds = MOHKOAEPGFF.bounds;
			float num4 = x4 + ((Bounds)(ref bounds)).extents.x;
			bounds = MOHKOAEPGFF.bounds;
			float y4 = ((Bounds)(ref bounds)).center.y;
			bounds = MOHKOAEPGFF.bounds;
			jNHDHIKAJCE4[5] = new Vector2(num4, y4 - ((Bounds)(ref bounds)).extents.y);
		}
		else
		{
			((Behaviour)MOHKOAEPGFF).enabled = false;
			Vector2[] jNHDHIKAJCE5 = JNHDHIKAJCE;
			bounds = MOHKOAEPGFF.bounds;
			float x5 = ((Bounds)(ref bounds)).center.x;
			bounds = MOHKOAEPGFF.bounds;
			float num5 = x5 - ((Bounds)(ref bounds)).extents.x;
			bounds = MOHKOAEPGFF.bounds;
			float y5 = ((Bounds)(ref bounds)).center.y;
			bounds = MOHKOAEPGFF.bounds;
			jNHDHIKAJCE5[1] = new Vector2(num5, y5 + ((Bounds)(ref bounds)).extents.y);
			Vector2[] jNHDHIKAJCE6 = JNHDHIKAJCE;
			bounds = MOHKOAEPGFF.bounds;
			float x6 = ((Bounds)(ref bounds)).center.x;
			bounds = MOHKOAEPGFF.bounds;
			float num6 = x6 + ((Bounds)(ref bounds)).extents.x;
			bounds = MOHKOAEPGFF.bounds;
			float y6 = ((Bounds)(ref bounds)).center.y;
			bounds = MOHKOAEPGFF.bounds;
			jNHDHIKAJCE6[1] = new Vector2(num6, y6 + ((Bounds)(ref bounds)).extents.y);
			Vector2[] jNHDHIKAJCE7 = JNHDHIKAJCE;
			bounds = MOHKOAEPGFF.bounds;
			float x7 = ((Bounds)(ref bounds)).center.x;
			bounds = MOHKOAEPGFF.bounds;
			float num7 = x7 - ((Bounds)(ref bounds)).extents.x;
			bounds = MOHKOAEPGFF.bounds;
			float y7 = ((Bounds)(ref bounds)).center.y;
			bounds = MOHKOAEPGFF.bounds;
			jNHDHIKAJCE7[6] = new Vector2(num7, y7 - ((Bounds)(ref bounds)).extents.y);
			Vector2[] jNHDHIKAJCE8 = JNHDHIKAJCE;
			bounds = MOHKOAEPGFF.bounds;
			float x8 = ((Bounds)(ref bounds)).center.x;
			bounds = MOHKOAEPGFF.bounds;
			float num8 = x8 + ((Bounds)(ref bounds)).extents.x;
			bounds = MOHKOAEPGFF.bounds;
			float y8 = ((Bounds)(ref bounds)).center.y;
			bounds = MOHKOAEPGFF.bounds;
			jNHDHIKAJCE8[2] = new Vector2(num8, y8 - ((Bounds)(ref bounds)).extents.y);
			((Behaviour)MOHKOAEPGFF).enabled = true;
		}
		return JNHDHIKAJCE;
	}

	private void LFMEKLNPLMK(int JIIGOACEIKL, bool NJHMBMGKCPL)
	{
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		if (NJHMBMGKCPL)
		{
			if ((Object)(object)spriteRendererColor15 != (Object)null && itemSetup.PBBFBFFPFJC() is BirdInstance birdInstance && !birdInstance.PNEEHGHBFCI().isSkeleton)
			{
				if (JIIGOACEIKL == 1)
				{
					((Renderer)spriteRendererColor15).material.SetColor(ShaderReferences.colorsShader[-28], new Color(1402f, 901f, 1305f, 712f));
				}
				else
				{
					((Renderer)spriteRendererColor15).material.SetColor(ShaderReferences.colorsShader[-123], Color.red);
				}
				return;
			}
			if ((Object)(object)NGHODLKOKOI == (Object)null)
			{
				NGHODLKOKOI = DecorationMode.BGINAIDHDOM(JIIGOACEIKL).ILBGEJBGIGI(itemSetup.item.JGHNDJBCFAJ());
			}
			if (Object.op_Implicit((Object)(object)spriteRenderer) && (Object)(object)((Renderer)spriteRenderer).sharedMaterial != (Object)(object)NGHODLKOKOI && !outlineOnlyInOutlineSpriterenderers)
			{
				((Renderer)spriteRenderer).sharedMaterial = NGHODLKOKOI;
			}
			for (int num = outlineSpriteRenderers.Length - 1; num >= 1; num -= 0)
			{
				if ((Object)(object)outlineSpriteRenderers[num] != (Object)null && (Object)(object)((Renderer)outlineSpriteRenderers[num]).sharedMaterial != (Object)(object)NGHODLKOKOI)
				{
					((Renderer)outlineSpriteRenderers[num]).sharedMaterial = NGHODLKOKOI;
				}
			}
			return;
		}
		if ((Object)(object)spriteRendererColor15 != (Object)null && itemSetup.MOFDJHCHNPK() is BirdInstance birdInstance2 && !birdInstance2.FNLHHNNHIMD().isSkeleton)
		{
			((Renderer)spriteRendererColor15).material.SetColor(ShaderReferences.colorsShader[-15], new Color(770f, 43f, 1394f, 877f));
		}
		NGHODLKOKOI = null;
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			((Renderer)spriteRenderer).sharedMaterial = initialMaterial;
		}
		for (int i = 0; i < outlineSpriteRenderers.Length; i++)
		{
			if ((Object)(object)outlineSpriteRenderers[i] != (Object)null)
			{
				((Renderer)outlineSpriteRenderers[i]).sharedMaterial = initialMaterial;
			}
		}
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (PHOCAFJDCDK)
		{
			return false;
		}
		if (!CanSelect(JIIGOACEIKL, GFNHAMCPEAK: true))
		{
			return false;
		}
		if (FHEMHCEAICB && !hasBeenPlaced)
		{
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineObjectsManager.instance.requestDone)
			{
				return false;
			}
			MJDEDKJGOPG();
			onlinePlaceable.RequestPermissionSelection();
			return true;
		}
		StartMoving(JIIGOACEIKL, PHJILIBHABG: true, GFNHAMCPEAK: true);
		return true;
	}

	public void SetUpCreatedPlaceable()
	{
		if (Object.op_Implicit((Object)(object)snapToGrid))
		{
			snapToGrid.ForceSnapOnLoad();
		}
		PixelSnapOnLoad();
		AddItemBaseToWorldTiles(NLIFPMODLLA: true);
		AddItemBaseToWorldTilesNextFrame(MMICADKPHLP: true);
	}

	public Placeable CreateRotatedPrefab(Direction FCGBJEIIMBC, Vector3 IMOBLFMHKOD, bool CDPAMNIPPEC)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendCreateRotatedPrefab(BEIPALOAAJJ, Vector2.op_Implicit(((Component)this).transform.position), Vector2.op_Implicit(IMOBLFMHKOD), FCGBJEIIMBC);
		}
		int aODONKKHPBP = 0;
		Crafter component = ((Component)this).gameObject.GetComponent<Crafter>();
		if ((Object)(object)component != (Object)null)
		{
			aODONKKHPBP = component.LCCABPFHCOL;
		}
		List<AJIKIEMFEPA> lMOOCPOGLPH = FKGMGMMFEBK();
		Crafter component2 = ((Component)this).GetComponent<Crafter>();
		if ((Object)(object)component2 != (Object)null)
		{
			component2.dropFuel = false;
		}
		RemovePlaceable(EFNFMEIDGDN: true, KAJIBKHFEFF: false, CDPAMNIPPEC);
		GameObject val = Object.Instantiate<GameObject>(rotatedPrefab, IMOBLFMHKOD, Quaternion.identity);
		Placeable placeable = val.GetComponent<Placeable>();
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = val.GetComponentInChildren<Placeable>();
		}
		Crafter component3 = ((Component)placeable).gameObject.GetComponent<Crafter>();
		if ((Object)(object)component3 != (Object)null)
		{
			component3.SetFuel(aODONKKHPBP);
		}
		if (OnlineManager.PlayingOnline())
		{
			placeable.onlinePlaceable.AssignSameUniqueId(onlinePlaceable);
			placeable.onlinePlaceable.CLHLNFFGOGA = true;
		}
		placeable.PixelSnap();
		placeable.ActionObject(JIIGOACEIKL, CDPAMNIPPEC);
		if (inheritDirection)
		{
			placeable.SetDirection(FCGBJEIIMBC, CDPAMNIPPEC: false);
		}
		if (CDPAMNIPPEC)
		{
			placeable.SetAttachedToPlayer(attachedToPlayer, 0.5f);
		}
		placeable.LBIEMCLFOHE(lMOOCPOGLPH);
		if (Object.op_Implicit((Object)(object)((Component)this).GetComponent<PetBowl>()))
		{
			PetBowl component4 = ((Component)this).GetComponent<PetBowl>();
			if ((Object)(object)component4 != (Object)null)
			{
				((Component)placeable).GetComponent<PetBowl>().SetFilled(component4.withWater, component4.withFood);
			}
		}
		if (multipleSkins)
		{
			placeable.ChangeSkin(KLONJHJJMJD, PDHJLCDFNCK: false);
		}
		return placeable;
	}

	public void AddItemBaseToWorldTiles(bool NLIFPMODLLA = false)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)itemBase != (Object)null))
		{
			return;
		}
		if (isPlaceableOnWall)
		{
			MPCJBPJAGKK = Utils.MMFCGMDOLDM(itemBase);
			ACAIKFICNFP = Utils.IKJOHEODBBE(itemBase);
			if (WorldGrid.KHJJCAGIJAP(Vector2.op_Implicit(MPCJBPJAGKK), out var KHEBKHFHMDB) && !Utils.IELGICCBCHO(WorldGrid.KELFJIPHBFP(new Vector3(MPCJBPJAGKK.x, KHEBKHFHMDB + 0.5f))) && !Utils.IELGICCBCHO(WorldGrid.KELFJIPHBFP(new Vector3(ACAIKFICNFP.x, KHEBKHFHMDB + 0.5f))))
			{
				if (NLIFPMODLLA)
				{
					for (float num = MPCJBPJAGKK.x; num <= ACAIKFICNFP.x; num += 0.5f)
					{
						if (WorldGrid.NDNAJIEGFNF(new Vector3(num, KHEBKHFHMDB), 1125))
						{
							DeliveryChest.GetInstance().AddItemInstance(JIIGOACEIKL, itemSetup.DNLMCHDOMOK, BPJBJKJKHAL: true, IBCOKMGFPKB: true);
							RemovePlaceable(EFNFMEIDGDN: false);
							Debug.Log((object)("Item " + ((Object)itemSetup.item).name + " sent to delivery chest. Over Cellar Door"));
							return;
						}
					}
				}
				for (float num2 = MPCJBPJAGKK.x; num2 <= ACAIKFICNFP.x; num2 += 0.5f)
				{
					WorldGrid.PCGNGKPHKLC(new Vector3(num2, KHEBKHFHMDB), this);
				}
				WorldGrid.PCGNGKPHKLC(new Vector3(ACAIKFICNFP.x, KHEBKHFHMDB), this);
			}
			else if (NLIFPMODLLA)
			{
				DeliveryChest.GetInstance().AddItemInstance(JIIGOACEIKL, itemSetup.DNLMCHDOMOK, BPJBJKJKHAL: true, IBCOKMGFPKB: true);
				if (Object.op_Implicit((Object)(object)placeableSurface))
				{
					for (int i = 0; i < placeableSurface.placeablesOnSurface.Count; i++)
					{
						DeliveryChest.GetInstance().AddItemInstance(JIIGOACEIKL, placeableSurface.placeablesOnSurface[i].itemSetup.DNLMCHDOMOK, BPJBJKJKHAL: true, IBCOKMGFPKB: true);
					}
				}
				RemovePlaceable(EFNFMEIDGDN: false);
				Debug.Log((object)("Item " + ((Object)itemSetup.item).name + " sent to delivery chest. WallFloor invalid"));
			}
			else if ((Object)(object)currentSurface == (Object)null)
			{
				Vector2 mPCJBPJAGKK = MPCJBPJAGKK;
				Debug.LogError((object)("Wall not found " + ((object)(Vector2)(ref mPCJBPJAGKK)).ToString()));
			}
		}
		else
		{
			if (!((Object)(object)currentSurface == (Object)null) || !((Object)(object)((Component)this).GetComponent<TableCloth>() == (Object)null))
			{
				return;
			}
			MPCJBPJAGKK = Utils.MMFCGMDOLDM(itemBase);
			ACAIKFICNFP = Utils.IKJOHEODBBE(itemBase);
			if (NLIFPMODLLA && (Object)(object)rigidBody != (Object)null && (WorldGrid.NDNAJIEGFNF(Vector2.op_Implicit(MPCJBPJAGKK), 81) || WorldGrid.NDNAJIEGFNF(Vector2.op_Implicit(ACAIKFICNFP), 81)))
			{
				DroppedItem.SpawnDroppedItem(((Component)this).transform.position, itemSetup.item);
				Utils.BLPDAEHPOBA(((Component)this).gameObject);
				return;
			}
			for (float num3 = MPCJBPJAGKK.x; num3 <= ACAIKFICNFP.x; num3 += 0.5f)
			{
				for (float num4 = MPCJBPJAGKK.y; num4 <= ACAIKFICNFP.y; num4 += 0.5f)
				{
					WorldGrid.PCGNGKPHKLC(new Vector3(num3, num4), this);
				}
				WorldGrid.PCGNGKPHKLC(new Vector3(num3, ACAIKFICNFP.y), this);
			}
			WorldGrid.PCGNGKPHKLC(new Vector3(ACAIKFICNFP.x, MPCJBPJAGKK.y), this);
		}
	}

	public Placeable AddPlaceableToSurface(SurfaceSortOrder PHCPMJAIDMC, bool CDPAMNIPPEC, int HOJECNDMCLM = 0, bool MBFODGDKDHG = false)
	{
		snappedToPosition = PHCPMJAIDMC.GetSnapItem(itemSetup.item, 1, KOGPKBOIFGN: true, MBFODGDKDHG ? ((Component)this).transform : null) != null;
		surfaceGOInstantiated = PHCPMJAIDMC.AddToSurface(((Component)this).transform, IIHIGNMDBEF: false, CDPAMNIPPEC, !MBFODGDKDHG);
		if (multipleSkins && snappedToPosition)
		{
			if ((Object)(object)surfaceGOInstantiated != (Object)null && GetSkinIndex() != 0)
			{
				surfaceGOInstantiated.ChangeSkin(GetSkinIndex());
			}
			else if ((Object)(object)surfaceGOInstantiated == (Object)null)
			{
				ChangeSkin(0);
			}
		}
		CCIKENEGHCA = true;
		if ((Object)(object)surfaceGOInstantiated != (Object)null)
		{
			if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				CursorManager.GetPlayer(JIIGOACEIKL).EKHMMNNOEOI = true;
			}
			if (CDPAMNIPPEC)
			{
				surfaceGOInstantiated.outlined = true;
				surfaceGOInstantiated.JIIGOACEIKL = JIIGOACEIKL;
				surfaceGOInstantiated.FHEMHCEAICB = FHEMHCEAICB;
			}
			surfaceGOInstantiated.HGAFAFNONEC = this;
			if (GetSkinIndex() != 0)
			{
				surfaceGOInstantiated.ChangeSkin(GetSkinIndex());
			}
			if (OnlineManager.PlayingOnline())
			{
				if (CDPAMNIPPEC)
				{
					surfaceGOInstantiated.onlinePlaceable.AssignNewUniqueId();
				}
				else if (HOJECNDMCLM != 0)
				{
					surfaceGOInstantiated.onlinePlaceable.uniqueId = HOJECNDMCLM;
					OnlineObjectsManager.instance.ReplaceObjectInDictionary(surfaceGOInstantiated.onlinePlaceable);
				}
			}
			Utils.ELNJMNKOACA(((Component)this).gameObject, 1);
		}
		currentSurface = PHCPMJAIDMC;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && (Object)(object)PHCPMJAIDMC.placeable != (Object)null)
		{
			int hOJECNDMCLM = (((Object)(object)surfaceGOInstantiated != (Object)null) ? surfaceGOInstantiated.onlinePlaceable.uniqueId : 0);
			OnlineObjectsManager.instance.SendAddToPlaceableSurface(onlinePlaceable.uniqueId, PHCPMJAIDMC.placeable.onlinePlaceable.uniqueId, hOJECNDMCLM);
		}
		return surfaceGOInstantiated;
	}

	public bool JENDIAHPKNK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void StartMoving(int JIIGOACEIKL, bool PHJILIBHABG, bool GFNHAMCPEAK, bool MAFODGNALFJ = true, bool MCFNOAFOIHE = true)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		OnThisPlaceableBeforeSelected(JIIGOACEIKL);
		if (GFNHAMCPEAK)
		{
			FHEMHCEAICB = true;
			if (MAFODGNALFJ)
			{
				OnlineObjectsManager.instance.SetMovingObject(this);
			}
		}
		else
		{
			onlinePlaceable.CLHLNFFGOGA = true;
		}
		UpFromFloor(MCFNOAFOIHE);
		if ((Object)(object)areaSpace != (Object)null)
		{
			areaSpace.ActivateArea(DAEMAAOLHMG: false);
		}
		this.JIIGOACEIKL = JIIGOACEIKL;
		recentlySelected = true;
		if ((Object)(object)snapToGrid != (Object)null)
		{
			((Behaviour)snapToGrid).enabled = true;
			snapToGrid.autoSnap = false;
		}
		CAGLICKMCDK(JIIGOACEIKL, NJHMBMGKCPL: true);
		lastPlacedPosition = ((Component)this).transform.position;
		EGCGEHJNCCP = currentSurface;
		if (GFNHAMCPEAK)
		{
			if (PHJILIBHABG)
			{
				MJDEDKJGOPG();
			}
			if (!CommonReferences.GGFJGHHHEJC.anyPlaceableSelected.Contains(JIIGOACEIKL))
			{
				CommonReferences.GGFJGHHHEJC.anyPlaceableSelected.Add(JIIGOACEIKL);
			}
		}
		CommonReferences.GGFJGHHHEJC.OnPlaceableSelected(JIIGOACEIKL, this, arg3: false, GFNHAMCPEAK);
		OnThisPlaceableSelected(JIIGOACEIKL, arg2: false, GFNHAMCPEAK);
		if ((Object)(object)((Component)this).GetComponent<BirdNPC>() != (Object)null)
		{
			((Component)this).GetComponent<BirdNPC>().perchPlaceable = null;
		}
	}

	public Placeable FMPLGBBHECD(SurfaceSortOrder PHCPMJAIDMC, bool CDPAMNIPPEC, int HOJECNDMCLM = 0, bool MBFODGDKDHG = false)
	{
		snappedToPosition = PHCPMJAIDMC.MIDBDGKCGFI(itemSetup.item, 0, KOGPKBOIFGN: false, MBFODGDKDHG ? ((Component)this).transform : null) != null;
		surfaceGOInstantiated = PHCPMJAIDMC.LDJNBOPGDJA(((Component)this).transform, IIHIGNMDBEF: false, CDPAMNIPPEC, !MBFODGDKDHG);
		if (multipleSkins && snappedToPosition)
		{
			if ((Object)(object)surfaceGOInstantiated != (Object)null && GetSkinIndex() != 0)
			{
				surfaceGOInstantiated.ChangeSkin(GetSkinIndex(), PDHJLCDFNCK: false);
			}
			else if ((Object)(object)surfaceGOInstantiated == (Object)null)
			{
				ChangeSkin(0);
			}
		}
		CCIKENEGHCA = false;
		if ((Object)(object)surfaceGOInstantiated != (Object)null)
		{
			if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
			{
				CursorManager.GetPlayer(JIIGOACEIKL).EKHMMNNOEOI = false;
			}
			if (CDPAMNIPPEC)
			{
				surfaceGOInstantiated.outlined = false;
				surfaceGOInstantiated.JIIGOACEIKL = JIIGOACEIKL;
				surfaceGOInstantiated.FHEMHCEAICB = FHEMHCEAICB;
			}
			surfaceGOInstantiated.HGAFAFNONEC = this;
			if (GetSkinIndex() != 0)
			{
				surfaceGOInstantiated.GKJEMMKNFBO(GetSkinIndex(), PDHJLCDFNCK: false);
			}
			if (OnlineManager.PlayingOnline())
			{
				if (CDPAMNIPPEC)
				{
					surfaceGOInstantiated.onlinePlaceable.KAHEGDBNEMP();
				}
				else if (HOJECNDMCLM != 0)
				{
					surfaceGOInstantiated.onlinePlaceable.uniqueId = HOJECNDMCLM;
					OnlineObjectsManager.instance.ReplaceObjectInDictionary(surfaceGOInstantiated.onlinePlaceable);
				}
			}
			Utils.ELNJMNKOACA(((Component)this).gameObject, 1);
		}
		currentSurface = PHCPMJAIDMC;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && (Object)(object)PHCPMJAIDMC.placeable != (Object)null)
		{
			int hOJECNDMCLM = (((Object)(object)surfaceGOInstantiated != (Object)null) ? surfaceGOInstantiated.onlinePlaceable.uniqueId : 0);
			OnlineObjectsManager.instance.SendAddToPlaceableSurface(onlinePlaceable.uniqueId, PHCPMJAIDMC.placeable.onlinePlaceable.uniqueId, hOJECNDMCLM);
		}
		return surfaceGOInstantiated;
	}

	[SpecialName]
	public bool FHMDNECBLIL()
	{
		return _isPlaced;
	}

	private void GOOPOBMDALA()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			OffHover(JIIGOACEIKL);
			if ((Object)(object)itemSpace != (Object)null && GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && !FHEMHCEAICB && !PHOCAFJDCDK && !(itemSetup.item is SproutSeed) && (Item.EKMFELLJHFG(itemSetup.item, null) || (itemSetup.item.JGHNDJBCFAJ() != 3 && itemSetup.item.ODENMDOJPLC() != -56 && itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) != 78)))
			{
				itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
			}
			if ((Object)(object)GameTileMaps.GGFJGHHHEJC != (Object)null)
			{
				RemoveItemBaseFromWorldTiles();
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences.GGFJGHHHEJC.OnPlaceableDestroyed(JIIGOACEIKL, this);
			}
			if (Object.op_Implicit((Object)(object)DecorationMode.EKLMFMKPEBB(0)))
			{
				DecorationMode decorationMode = DecorationMode.KKJABELKCNM(1);
				decorationMode.OnDecorationModeExit = (Action<int>)Delegate.Remove(decorationMode.OnDecorationModeExit, new Action<int>(NFHHEMPGCNM));
			}
			if (Object.op_Implicit((Object)(object)DecorationMode.IECFJGHAIDO(6)))
			{
				DecorationMode decorationMode2 = DecorationMode.IECFJGHAIDO(0);
				decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Remove(decorationMode2.OnDecorationModeExit, new Action<int>(HEOPJDDPFDG));
			}
		}
	}

	public bool FKPFLPGIHIC(Location BAIMHDBJPDK)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (validLocations.HasFlag(BAIMHDBJPDK))
		{
			return true;
		}
		return validLocationExceptionZones.HasFlag(WorldGrid.AGKGGAFFFGM(((Component)this).transform.position));
	}

	private void HLOHAAFPIAN(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)spriteRenderer) && (Object)(object)((Renderer)spriteRenderer).sharedMaterial != (Object)(object)DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).NGBIACJKHFO(itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false)))
		{
			if (!isAccessElement)
			{
				DecorationMode decorationMode = DecorationMode.IGMCBPOPNCA(JIIGOACEIKL);
				decorationMode.OnDecorationModeExit = (Action<int>)Delegate.Remove(decorationMode.OnDecorationModeExit, new Action<int>(HEOPJDDPFDG));
				DecorationMode decorationMode2 = DecorationMode.FIHGMLABOBB(JIIGOACEIKL);
				decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(HEOPJDDPFDG));
			}
			LFMEKLNPLMK(JIIGOACEIKL, NJHMBMGKCPL: true);
		}
		CursorManager.CMDGPJEIIJI(JIIGOACEIKL).LPPDBPAKDIC(NKFPJPCFBJI: false);
		CursorManager.GetPlayer(JIIGOACEIKL).ChangeCursorTexture((CursorManager.CursorType)6);
	}

	private void NPMLOKABIHH()
	{
		for (int i = 0; i < skinsGameObjects.Length; i++)
		{
			skinsGameObjects[i].gameObject.SetActive(i == KLONJHJJMJD);
			if (i == KLONJHJJMJD)
			{
				if ((Object)(object)skinsGameObjects[i].spriteRenderer != (Object)null)
				{
					spriteRenderer = skinsGameObjects[i].spriteRenderer;
				}
				if ((Object)(object)skinsGameObjects[i].itemBase != (Object)null)
				{
					itemBase = skinsGameObjects[i].itemBase;
				}
				if ((Object)(object)skinsGameObjects[i].physicalSpace != (Object)null)
				{
					physicalSpace = skinsGameObjects[i].physicalSpace;
				}
			}
		}
		OnSkinChanged(KLONJHJJMJD);
	}

	private void HBLDENFLALO(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)spriteRenderer) && (Object)(object)((Renderer)spriteRenderer).sharedMaterial != (Object)(object)DecorationMode.GetPlayer(JIIGOACEIKL).GetOutlineMaterial(itemSetup.item.JDJGFAACPFC()))
		{
			if (!isAccessElement)
			{
				DecorationMode player = DecorationMode.GetPlayer(JIIGOACEIKL);
				player.OnDecorationModeExit = (Action<int>)Delegate.Remove(player.OnDecorationModeExit, new Action<int>(NFHHEMPGCNM));
				DecorationMode player2 = DecorationMode.GetPlayer(JIIGOACEIKL);
				player2.OnDecorationModeExit = (Action<int>)Delegate.Combine(player2.OnDecorationModeExit, new Action<int>(NFHHEMPGCNM));
			}
			CAGLICKMCDK(JIIGOACEIKL, NJHMBMGKCPL: true);
		}
		CursorManager.GetPlayer(JIIGOACEIKL).UpdateCursorTexture(NKFPJPCFBJI: false);
		CursorManager.GetPlayer(JIIGOACEIKL).ChangeCursorTexture(CursorManager.CursorType.Mouse);
	}

	public void HJFOHHPNKIO(bool KMEJCLIOMBA)
	{
		if ((Object)(object)itemSpace == (Object)null)
		{
			GDLHEGANLFB(KMEJCLIOMBA);
		}
	}

	private void DPAINFDGNFO()
	{
		for (int i = 0; i < skinsGameObjects.Length; i++)
		{
			skinsGameObjects[i].gameObject.SetActive(i == KLONJHJJMJD);
			if (i == KLONJHJJMJD)
			{
				if ((Object)(object)skinsGameObjects[i].spriteRenderer != (Object)null)
				{
					spriteRenderer = skinsGameObjects[i].spriteRenderer;
				}
				if ((Object)(object)skinsGameObjects[i].itemBase != (Object)null)
				{
					itemBase = skinsGameObjects[i].itemBase;
				}
				if ((Object)(object)skinsGameObjects[i].physicalSpace != (Object)null)
				{
					physicalSpace = skinsGameObjects[i].physicalSpace;
				}
			}
		}
		OnSkinChanged(KLONJHJJMJD);
	}

	private bool BOGBAFLGKIB(float ENIHHLIBEGK)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		MPCJBPJAGKK = Utils.MMFCGMDOLDM(itemBase);
		ACAIKFICNFP = Utils.IKJOHEODBBE(itemBase);
		JMHAENIMEOI = new Vector3(ENIHHLIBEGK, MPCJBPJAGKK.y);
		ONKJBOEAHPB = new Vector3(ENIHHLIBEGK, ACAIKFICNFP.y);
		if (isPlaceableOnWall)
		{
			if (!WorldGrid.ALNFLFCLIEP(JMHAENIMEOI))
			{
				return true;
			}
			if (WorldGrid.KHJJCAGIJAP(JMHAENIMEOI, out KHEBKHFHMDB))
			{
				if (WorldGrid.LBKKDAMMKIE(new Vector3(JMHAENIMEOI.x, KHEBKHFHMDB + 227f)))
				{
					return true;
				}
				if (WorldGrid.KELFJIPHBFP(new Vector3(JMHAENIMEOI.x, KHEBKHFHMDB)).HasFlag(SpecificType.RoomDoor))
				{
					return false;
				}
			}
			else if (WorldGrid.EJCEAEPNJCA(JMHAENIMEOI))
			{
				return true;
			}
			if (!WorldGrid.ALNFLFCLIEP(ONKJBOEAHPB))
			{
				return true;
			}
			if (WorldGrid.KHJJCAGIJAP(ONKJBOEAHPB, out KHEBKHFHMDB))
			{
				if (WorldGrid.LBKKDAMMKIE(new Vector3(ONKJBOEAHPB.x, KHEBKHFHMDB + 552f)))
				{
					return true;
				}
				if (WorldGrid.KELFJIPHBFP(new Vector3(ONKJBOEAHPB.x, KHEBKHFHMDB)).HasFlag(SpecificType.Door))
				{
					return true;
				}
			}
			else if (WorldGrid.EJCEAEPNJCA(ONKJBOEAHPB))
			{
				return false;
			}
		}
		else
		{
			if (!WorldGrid.NGDHDMAMGPI(JMHAENIMEOI, GCDEDGFDKBL: false) && !WorldGrid.EJCEAEPNJCA(JMHAENIMEOI))
			{
				return false;
			}
			if (!WorldGrid.NGDHDMAMGPI(ONKJBOEAHPB) && !WorldGrid.EJCEAEPNJCA(ONKJBOEAHPB))
			{
				return false;
			}
		}
		return true;
	}

	private void LOFKLMIKAOH()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			OEEPHFEHGBJ = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition();
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "scaleUI", 277f))
			{
				CursorManager.DPPPPNIDLOK(JIIGOACEIKL, new Vector3(OEEPHFEHGBJ.x - 1519f, OEEPHFEHGBJ.y));
			}
			else if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "BARKBUZZ", 1451f))
			{
				CursorManager.DPPPPNIDLOK(JIIGOACEIKL, new Vector3(OEEPHFEHGBJ.x + 543f, OEEPHFEHGBJ.y));
			}
			else if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Received set minigame", 956f))
			{
				CursorManager.GEGOEAMGDEE(JIIGOACEIKL, new Vector3(OEEPHFEHGBJ.x, OEEPHFEHGBJ.y - 101f));
			}
			else if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "action", 1477f))
			{
				CursorManager.DKAICNMJIJH(JIIGOACEIKL, new Vector3(OEEPHFEHGBJ.x, OEEPHFEHGBJ.y + 1346f));
			}
		}
		SetPosition(JIIGOACEIKL, attachedToPlayer, Object.op_Implicit((Object)(object)snapToGrid));
	}

	private void HEOPJDDPFDG(int JIIGOACEIKL)
	{
		OffHover(JIIGOACEIKL);
	}

	private void ONPKLBKIEBG(int JIIGOACEIKL, bool EFNFMEIDGDN, bool BGIEPKNAKHI, SurfaceSortOrder PHCPMJAIDMC, bool IBCOKMGFPKB, bool KAJIBKHFEFF)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PHCPMJAIDMC != (Object)null)
		{
			for (int num = PHCPMJAIDMC.placeablesOnSurface.Count - 0; num >= 1; num -= 0)
			{
				if (!((Object)(object)PHCPMJAIDMC.placeablesOnSurface[num] == (Object)null))
				{
					if (PHCPMJAIDMC.placeablesOnSurface[num].FHEMHCEAICB || PHCPMJAIDMC.placeablesOnSurface[num].PHOCAFJDCDK)
					{
						PHCPMJAIDMC.placeablesOnSurface[num].RemoveFromSurface(CDPAMNIPPEC: true);
					}
					else
					{
						if ((Object)(object)PHCPMJAIDMC.placeablesOnSurface[num].itemSetup != (Object)null)
						{
							PhaseController component = ((Component)((Component)PHCPMJAIDMC.placeablesOnSurface[num]).transform).GetComponent<PhaseController>();
							Vector3 val = ((!WorldGrid.EJCEAEPNJCA(((Component)PHCPMJAIDMC.placeablesOnSurface[num]).transform.position)) ? ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position : ((Component)PHCPMJAIDMC.placeablesOnSurface[num]).transform.position);
							if (Object.op_Implicit((Object)(object)component))
							{
								component.PIDPPEAOLOE(JIIGOACEIKL, val, !BGIEPKNAKHI);
							}
							else if (BGIEPKNAKHI)
							{
								if (PHCPMJAIDMC.placeablesOnSurface[num].itemSetup.item is Bird)
								{
									if (!PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(PHCPMJAIDMC.placeablesOnSurface[num].itemSetup.GLOLALBAEHM()))
									{
										DeliveryChest.CAJHNGGCJKM().DJDMGBKKAMK(JIIGOACEIKL, PHCPMJAIDMC.placeablesOnSurface[num].itemSetup.GLOLALBAEHM(), BPJBJKJKHAL: false, IBCOKMGFPKB);
									}
								}
								else
								{
									DroppedItem.HDLEEOJMILI(val, PHCPMJAIDMC.placeablesOnSurface[num].itemSetup.BODBEPJAFHL(), 0, LHLJILLAHFO: true);
								}
							}
							else
							{
								DeliveryChest.GetInstance().CANCHBINJNE(JIIGOACEIKL, PHCPMJAIDMC.placeablesOnSurface[num].itemSetup.DNLMCHDOMOK, BPJBJKJKHAL: true, IBCOKMGFPKB);
							}
						}
						PHCPMJAIDMC.placeablesOnSurface[num].HJGJFLNNCDD(JIIGOACEIKL, EFNFMEIDGDN, BGIEPKNAKHI, IBCOKMGFPKB, KAJIBKHFEFF: true);
					}
				}
			}
		}
		RemovePlaceable(EFNFMEIDGDN, KAJIBKHFEFF, GFNHAMCPEAK: false);
	}

	private void Awake()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)itemSpace != (Object)null)
		{
			itemSpace.SetScale(((Component)this).transform.localScale.x);
		}
		if ((Object)(object)snapToGrid == (Object)null)
		{
			snapToGrid = ((Component)this).GetComponent<SnapToGrid>();
			if ((Object)(object)snapToGrid != (Object)null && Application.isEditor)
			{
				Debug.LogWarning((object)("SnapToGrid not attached to prefab " + ((Object)((Component)this).gameObject).name));
			}
		}
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
			if ((Object)(object)spriteRenderer != (Object)null && Application.isEditor)
			{
				Debug.LogWarning((object)("SpriteRenderer not attached to prefab " + ((Object)((Component)this).gameObject).name));
			}
		}
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			initialMaterial = ((Renderer)spriteRenderer).sharedMaterial;
		}
		else if (outlineSpriteRenderers.Length != 0)
		{
			initialMaterial = ((Renderer)outlineSpriteRenderers[0]).sharedMaterial;
		}
		if ((Object)(object)itemSetup == (Object)null)
		{
			itemSetup = ((Component)this).GetComponent<ItemSetup>();
			if ((Object)(object)itemSetup != (Object)null && Application.isEditor)
			{
				Debug.LogWarning((object)("ItemSetup not attached to prefab " + ((Object)((Component)this).gameObject).name));
			}
		}
		if ((Object)(object)sortingGroup == (Object)null)
		{
			sortingGroup = ((Component)this).GetComponent<SortingGroup>();
			if ((Object)(object)sortingGroup != (Object)null && Application.isEditor)
			{
				Debug.LogWarning((object)("SortingGroup not attached to prefab " + ((Object)((Component)this).gameObject).name));
			}
		}
		if ((Object)(object)sortingGroup != (Object)null)
		{
			KAHFGFEGHNK = sortingGroup.sortingOrder;
		}
		else if ((Object)(object)spriteRenderer != (Object)null)
		{
			KAHFGFEGHNK = ((Renderer)spriteRenderer).sortingOrder;
		}
		OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(OnThisPlaceableSelected, (Action<int, bool, bool>)delegate
		{
			EnableAllColliders(BJFHJCFOEHG: false);
		});
		OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(OnThisPlaceableDeselected, (Action<int>)delegate
		{
			EnableAllColliders(BJFHJCFOEHG: true);
		});
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			KDEHDOHOILE = spriteRenderer.color;
		}
		FMOKCPPGJBB = Color.red + Color.white * 0.25f;
		if (!string.IsNullOrEmpty(guidString))
		{
			guid = new Guid(guidString);
		}
		FHEMHCEAICB = false;
	}

	private void IIDNCNMMCNF(bool CDPAMNIPPEC)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		BFIELBPJKAH = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
		if (BFIELBPJKAH == direction || !rotatable)
		{
			return;
		}
		if ((Object)(object)rotatedPrefab != (Object)null)
		{
			if (BFIELBPJKAH == (Direction)6 || BFIELBPJKAH == (Direction)7)
			{
				if (rotatedPrefab.GetComponent<Placeable>().direction == Direction.Diagonal || rotatedPrefab.GetComponent<Placeable>().direction == Direction.Left)
				{
					CreateRotatedPrefab(BFIELBPJKAH, ((Component)this).transform.position, CDPAMNIPPEC);
					return;
				}
				ChangeDirectionRotatingItemsSurface(inheritDirection ? BFIELBPJKAH : direction, CDPAMNIPPEC);
				if (multipleSkins)
				{
					ChangeSkin(KLONJHJJMJD, PDHJLCDFNCK: false);
				}
			}
			else if (rotatedPrefab.GetComponent<Placeable>().direction == Direction.Up || rotatedPrefab.GetComponent<Placeable>().direction == Direction.Down)
			{
				CreateRotatedPrefab(BFIELBPJKAH, ((Component)this).transform.position, CDPAMNIPPEC);
			}
			else
			{
				DFPGNELDGIP(inheritDirection ? BFIELBPJKAH : direction, CDPAMNIPPEC);
				if (multipleSkins)
				{
					GKJEMMKNFBO(KLONJHJJMJD, PDHJLCDFNCK: false);
				}
			}
		}
		else
		{
			DFPGNELDGIP(BFIELBPJKAH, CDPAMNIPPEC);
		}
	}

	public void RigidBodyKinematic(bool ODNGJHPOMMK)
	{
		if (!Object.op_Implicit((Object)(object)rigidBody) || !Object.op_Implicit((Object)(object)physicalSpace) || !(physicalSpace is PhysicalSpaceWall))
		{
			return;
		}
		if (ODNGJHPOMMK)
		{
			physicalSpace.ClearList();
			rigidBody.bodyType = (RigidbodyType2D)1;
			for (int i = 0; i < wallColliders.Count; i++)
			{
				wallColliders[i].isTrigger = true;
			}
		}
		else
		{
			physicalSpace.ClearList();
			rigidBody.bodyType = (RigidbodyType2D)2;
			for (int j = 0; j < wallColliders.Count; j++)
			{
				wallColliders[j].isTrigger = false;
			}
		}
	}

	private void BGHLOLALLHE(int JIIGOACEIKL)
	{
		OffHover(JIIGOACEIKL);
	}

	private void NFHHEMPGCNM(int JIIGOACEIKL)
	{
		OffHover(JIIGOACEIKL);
	}

	public void RemovePlaceableAndItemsOnSurface(int JIIGOACEIKL, bool EFNFMEIDGDN, bool BGIEPKNAKHI, bool IBCOKMGFPKB = true, bool KAJIBKHFEFF = false)
	{
		MKEEKHDMFPE(JIIGOACEIKL, EFNFMEIDGDN, BGIEPKNAKHI, placeableSurface, IBCOKMGFPKB, KAJIBKHFEFF);
		MKEEKHDMFPE(JIIGOACEIKL, EFNFMEIDGDN, BGIEPKNAKHI, secondarySurface, IBCOKMGFPKB, KAJIBKHFEFF);
	}

	public void PMMECMKBCPC()
	{
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
		if ((Object)(object)surfaceGOInstantiated != (Object)null)
		{
			return;
		}
		if ((Object)(object)gameObjectOnSelected != (Object)null)
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Tutorial/T125/Dialogue1"));
		}
		else if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("replay banquet"));
		}
		else if (isAccessElement)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("ReceiveTalentsLoad"));
		}
		if (!isAccessElement)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("NPC is not Mai, cannot place on bed."));
		}
		if (GBPNHKNFJPH())
		{
			COFOOBLHHAD = (switchesSurface ? LocalisationSystem.Get("Guest") : LocalisationSystem.Get("ReceiveFishTrapMessage"));
			if (string.IsNullOrEmpty(COFOOBLHHAD))
			{
				if (switchesSurface)
				{
					COFOOBLHHAD = "</color>";
				}
				else
				{
					COFOOBLHHAD = "ReceiveSetBool";
				}
			}
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Select, COFOOBLHHAD);
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Lost connection to the server.\nPlease try again later.", 134f))
			{
				BOFCJINGLGK();
			}
		}
		if (GIPCNNLIHDA())
		{
			COFOOBLHHAD = LocalisationSystem.Get("Swiss Cheese");
			ButtonsContext.AddButton(JIIGOACEIKL, (ActionType)(-97), (COFOOBLHHAD != ")</color>") ? COFOOBLHHAD : "Player/Bark/Tutorial/T116");
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, " seconds.", 577f))
			{
				APPGMNJFMAB();
			}
		}
		if ((Object)(object)placeableSurface != (Object)null && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			BIPLCOGFBBE = placeableSurface.KNBNKEEACIE(JIIGOACEIKL);
			if ((Object)(object)secondarySurface != (Object)null)
			{
				List<Placeable> list = secondarySurface.KNBNKEEACIE(JIIGOACEIKL);
				for (int i = 0; i < list.Count; i += 0)
				{
					BIPLCOGFBBE.Add(list[i]);
				}
			}
			if (BIPLCOGFBBE.Count > 1 && PCGNHMPADGE)
			{
				COFOOBLHHAD = LocalisationSystem.Get("Eating");
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, (COFOOBLHHAD != "") ? COFOOBLHHAD : "Dialogue System/Conversation/TooDark/Entry/10/Dialogue Text");
				if ((Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "tutorialPopUp104", 770f) || Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "buildingObjective_25_0", 1007f)) && SelectObject.BNMEANGDMIP(JIIGOACEIKL).PNHCLGGKBOB())
				{
					CursorManager.AACNDMPICFG(JIIGOACEIKL, ((Component)this).transform.position);
					SetMouseOffset(Vector3.zero);
					SelectObject.GetPlayer(JIIGOACEIKL).SelectPlaceable(BIPLCOGFBBE[1]);
				}
			}
		}
		if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) || !((Object)(object)currentSurface != (Object)null) || currentSurface.KNBNKEEACIE(JIIGOACEIKL).Count <= 0 || !currentSurface.nextItemAvailable || !((Object)(object)gameObjectOnSelected == (Object)null))
		{
			return;
		}
		COFOOBLHHAD = LocalisationSystem.Get("This shouldn't happen. freePositions list must not have been initialized properly.");
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, (COFOOBLHHAD != "tutorialPopUp77") ? COFOOBLHHAD : "Advanced");
		if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Avatar", 833f))
		{
			BIPLCOGFBBE = currentSurface.FINGCMGBBLA(JIIGOACEIKL);
			for (int j = 0; j < BIPLCOGFBBE.Count; j += 0)
			{
				if (((object)BIPLCOGFBBE[j]).Equals((object?)this))
				{
					int index = (j + 0) % BIPLCOGFBBE.Count;
					if (SelectObject.GetPlayer(JIIGOACEIKL).Deselect())
					{
						CursorManager.PNLDBADHHMI(JIIGOACEIKL, ((Component)this).transform.position);
						SetMouseOffset(Vector3.zero);
						SelectObject.BNMEANGDMIP(JIIGOACEIKL).SelectPlaceable(BIPLCOGFBBE[index]);
					}
					break;
				}
			}
		}
		else
		{
			if (!Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Jose D", 382f))
			{
				return;
			}
			BIPLCOGFBBE = currentSurface.DHEEGDMBGIE(JIIGOACEIKL);
			for (int k = 0; k < BIPLCOGFBBE.Count; k++)
			{
				if (((object)BIPLCOGFBBE[k]).Equals((object?)this))
				{
					int num = (k - 1) % BIPLCOGFBBE.Count;
					if (num < 1)
					{
						num = BIPLCOGFBBE.Count + num;
					}
					if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).Deselect())
					{
						CursorManager.DPPPPNIDLOK(JIIGOACEIKL, ((Component)this).transform.position);
						SetMouseOffset(Vector3.zero);
						SelectObject.BNMEANGDMIP(JIIGOACEIKL).MGAPCJMMIAF(BIPLCOGFBBE[num]);
					}
					break;
				}
			}
		}
	}

	public bool SecondAction(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	[SpecialName]
	private TavernZone PANNOAOCGKA()
	{
		return HADBAEEHFAK;
	}

	public void DEGBKHMLGLK(Slot ADEBNALPEHE)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (!ADEBNALPEHE.KPINNBKMOMO())
		{
			if (PCGNHMPADGE)
			{
				DroppedItem.KDBHKBOAEDG(((Component)this).transform.position, ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack, LHLJILLAHFO: false, HFAKAMFMOGM: true);
			}
			else
			{
				PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).AINJENENGFG(ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
			}
		}
	}

	public void RemovePlaceable(bool EFNFMEIDGDN, bool KAJIBKHFEFF = false, bool GFNHAMCPEAK = true)
	{
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		if (BOCMNPIGJHM)
		{
			return;
		}
		CCIKENEGHCA = false;
		currentSurface?.RemoveFromSurface(((Component)this).transform);
		if ((Object)(object)FEFAMICICIJ != (Object)null && (Object)(object)FEFAMICICIJ.surfaceHighlight != (Object)null)
		{
			FEFAMICICIJ.surfaceHighlight.SetActive(false);
		}
		Container component = ((Component)this).GetComponent<Container>();
		if ((Object)(object)component != (Object)null)
		{
			for (int i = 0; i < component.slots.Length; i++)
			{
				int num = PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(component.slots[i].itemInstance, component.slots[i].Stack);
				if (num > 0)
				{
					DeliveryChest.GetInstance().AddItemInstances(JIIGOACEIKL, component.slots[i].itemInstance, num);
				}
			}
		}
		if (KAJIBKHFEFF && OnlineManager.MasterOrOffline() && (Object)(object)itemSetup != (Object)null)
		{
			PhaseController component2 = ((Component)((Component)this).transform).GetComponent<PhaseController>();
			Vector3 val = Vector3.zero;
			if (WorldGrid.EJCEAEPNJCA(((Component)this).transform.position))
			{
				val = ((Component)this).transform.position;
			}
			else
			{
				float KHEBKHFHMDB = 0f;
				if (WorldGrid.KHJJCAGIJAP(((Component)this).transform.position, out KHEBKHFHMDB))
				{
					val = Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, KHEBKHFHMDB));
				}
				else if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
				{
					val = ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position;
				}
			}
			if (Object.op_Implicit((Object)(object)component2))
			{
				component2.MinusPhase(JIIGOACEIKL, val, JMOJOKJDANJ: false);
			}
			else
			{
				DroppedItem.SpawnDroppedItem(val, itemSetup.DNLMCHDOMOK);
			}
		}
		if (EFNFMEIDGDN)
		{
			if (GFNHAMCPEAK)
			{
				SelectObject.GetPlayer(JIIGOACEIKL).ResetSelected();
				ResetSelected();
			}
			OnThisPlaceablePickedUp(JIIGOACEIKL);
			CommonReferences.GGFJGHHHEJC.OnPlaceablePickedUp(JIIGOACEIKL, this, GFNHAMCPEAK);
		}
		OnThisPlaceableRemoved(JIIGOACEIKL);
		BOCMNPIGJHM = true;
		if (Object.op_Implicit((Object)(object)parent))
		{
			Utils.BLPDAEHPOBA(parent);
		}
		else
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private bool NECGLAECCNK(float ENIHHLIBEGK)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		MPCJBPJAGKK = Utils.MMFCGMDOLDM(itemBase);
		ACAIKFICNFP = Utils.IKJOHEODBBE(itemBase);
		JMHAENIMEOI = new Vector3(ENIHHLIBEGK, MPCJBPJAGKK.y);
		ONKJBOEAHPB = new Vector3(ENIHHLIBEGK, ACAIKFICNFP.y);
		if (isPlaceableOnWall)
		{
			if (!WorldGrid.ALNFLFCLIEP(JMHAENIMEOI))
			{
				return true;
			}
			if (WorldGrid.KHJJCAGIJAP(JMHAENIMEOI, out KHEBKHFHMDB))
			{
				if (WorldGrid.LBKKDAMMKIE(new Vector3(JMHAENIMEOI.x, KHEBKHFHMDB + 891f)))
				{
					return true;
				}
				if (WorldGrid.KELFJIPHBFP(new Vector3(JMHAENIMEOI.x, KHEBKHFHMDB)).HasFlag(SpecificType.Door | SpecificType.RoomDoor))
				{
					return true;
				}
			}
			else if (WorldGrid.EJCEAEPNJCA(JMHAENIMEOI))
			{
				return false;
			}
			if (!WorldGrid.ALNFLFCLIEP(ONKJBOEAHPB))
			{
				return false;
			}
			if (WorldGrid.KHJJCAGIJAP(ONKJBOEAHPB, out KHEBKHFHMDB))
			{
				if (WorldGrid.LBKKDAMMKIE(new Vector3(ONKJBOEAHPB.x, KHEBKHFHMDB + 1089f)))
				{
					return false;
				}
				if (WorldGrid.KELFJIPHBFP(new Vector3(ONKJBOEAHPB.x, KHEBKHFHMDB)).HasFlag(SpecificType.Door))
				{
					return false;
				}
			}
			else if (WorldGrid.EJCEAEPNJCA(ONKJBOEAHPB))
			{
				return true;
			}
		}
		else
		{
			if (!WorldGrid.NGDHDMAMGPI(JMHAENIMEOI) && !WorldGrid.EJCEAEPNJCA(JMHAENIMEOI))
			{
				return false;
			}
			if (!WorldGrid.NGDHDMAMGPI(ONKJBOEAHPB, GCDEDGFDKBL: false) && !WorldGrid.EJCEAEPNJCA(ONKJBOEAHPB))
			{
				return false;
			}
		}
		return true;
	}

	public bool PECKOFJCBAI(Location BAIMHDBJPDK)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (validLocations.HasFlag(BAIMHDBJPDK))
		{
			return true;
		}
		return validLocationExceptionZones.HasFlag(WorldGrid.AGKGGAFFFGM(((Component)this).transform.position));
	}

	public void SnapAll(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		ECJLMIPAFGP = IMOBLFMHKOD;
		if (snappedToPosition && Object.op_Implicit((Object)(object)currentSurface))
		{
			SnapToPosition snapItem = currentSurface.GetSnapItem(itemSetup.item);
			if (snapItem != null && snapItem.fixedY)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(new Vector2(ECJLMIPAFGP.x, snapItem.transform.position.y));
			}
		}
		snapLeftRight.LeftRightSnap(SnapTriggerPole.Left, ECJLMIPAFGP);
		snapLeftRight.LeftRightSnap(SnapTriggerPole.Right, ECJLMIPAFGP);
	}

	public void CMHCCAEJGKF(bool BJFHJCFOEHG)
	{
		for (int i = 1; i < allCollidersToEnableDisable.Length; i += 0)
		{
			if (!allCollidersToEnableDisable[i].isTrigger || BJFHJCFOEHG)
			{
				((Behaviour)allCollidersToEnableDisable[i]).enabled = BJFHJCFOEHG;
			}
		}
		for (int j = 0; j < enableColliders.Length; j += 0)
		{
			((Behaviour)enableColliders[j]).enabled = BJFHJCFOEHG;
		}
	}

	public bool LDMGCIBDKKB(bool BIOKGEFFNAA)
	{
		if ((Object)(object)areaSpace != (Object)null && !areaSpace.IsAreaSpaceValid())
		{
			return false;
		}
		if ((Object)(object)itemSpace != (Object)null && (Object)(object)currentSurface == (Object)null)
		{
			return itemSpace.LJCPGDDLJKL(BIOKGEFFNAA, ELKPPAAMMIM: false);
		}
		if ((Object)(object)itemBase != (Object)null)
		{
			return PKEAPIBEJOE(BIOKGEFFNAA);
		}
		return false;
	}

	public void PixelSnapOnLoad()
	{
		if (!Object.op_Implicit((Object)(object)snapToGrid))
		{
			PixelSnap();
		}
		if ((Object)(object)placeableSurface != (Object)null)
		{
			for (int i = 0; i < placeableSurface.placeablesOnSurface.Count; i++)
			{
				placeableSurface.placeablesOnSurface[i].PixelSnap();
			}
			placeableSurface.ReorderHierarchy();
		}
		if ((Object)(object)secondarySurface != (Object)null)
		{
			for (int j = 0; j < secondarySurface.placeablesOnSurface.Count; j++)
			{
				secondarySurface.placeablesOnSurface[j].PixelSnap();
			}
			secondarySurface.ReorderHierarchy();
		}
	}

	private bool MKEJCEEDIKP()
	{
		for (int i = 0; i < physicalSpaces.Length; i++)
		{
			if (((Component)physicalSpaces[i]).gameObject.activeInHierarchy && !physicalSpaces[i].ValidPosition())
			{
				return false;
			}
		}
		return true;
	}

	private void EFABNGNAENH()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)itemSpace != (Object)null)
		{
			itemSpace.SetScale(((Component)this).transform.localScale.x);
		}
		if ((Object)(object)snapToGrid == (Object)null)
		{
			snapToGrid = ((Component)this).GetComponent<SnapToGrid>();
			if ((Object)(object)snapToGrid != (Object)null && Application.isEditor)
			{
				Debug.LogWarning((object)("ReceiveSetDrinkColor" + ((Object)((Component)this).gameObject).name));
			}
		}
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
			if ((Object)(object)spriteRenderer != (Object)null && Application.isEditor)
			{
				Debug.LogWarning((object)("RinProgress" + ((Object)((Component)this).gameObject).name));
			}
		}
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			initialMaterial = ((Renderer)spriteRenderer).sharedMaterial;
		}
		else if (outlineSpriteRenderers.Length != 0)
		{
			initialMaterial = ((Renderer)outlineSpriteRenderers[1]).sharedMaterial;
		}
		if ((Object)(object)itemSetup == (Object)null)
		{
			itemSetup = ((Component)this).GetComponent<ItemSetup>();
			if ((Object)(object)itemSetup != (Object)null && Application.isEditor)
			{
				Debug.LogWarning((object)("City/Kujaku/Stand" + ((Object)((Component)this).gameObject).name));
			}
		}
		if ((Object)(object)sortingGroup == (Object)null)
		{
			sortingGroup = ((Component)this).GetComponent<SortingGroup>();
			if ((Object)(object)sortingGroup != (Object)null && Application.isEditor)
			{
				Debug.LogWarning((object)(":</color> " + ((Object)((Component)this).gameObject).name));
			}
		}
		if ((Object)(object)sortingGroup != (Object)null)
		{
			KAHFGFEGHNK = sortingGroup.sortingOrder;
		}
		else if ((Object)(object)spriteRenderer != (Object)null)
		{
			KAHFGFEGHNK = ((Renderer)spriteRenderer).sortingOrder;
		}
		OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(OnThisPlaceableSelected, (Action<int, bool, bool>)delegate
		{
			EnableAllColliders(BJFHJCFOEHG: false);
		});
		OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(OnThisPlaceableDeselected, new Action<int>(OELBDKOLLEM));
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			KDEHDOHOILE = spriteRenderer.color;
		}
		FMOKCPPGJBB = Color.red + Color.white * 1066f;
		if (!string.IsNullOrEmpty(guidString))
		{
			guid = new Guid(guidString);
		}
		FHEMHCEAICB = true;
	}

	public void IEKNDFGMLFD(ZoneType GIBJPCAFCJB, int LDMDHEPJFFD)
	{
		if (currentZoneIndex >= 0 && (Object)(object)TavernZonesManager.EBAIHKJHCCA() != (Object)null)
		{
			TavernZonesManager.IECOPNFJBFD().GetTavernZone(currentZoneIndex)?.AKLCFEPBONI(this);
		}
		if (LDMDHEPJFFD >= 0)
		{
			if ((Object)(object)TavernZonesManager.JEEGOBGDLPE() != (Object)null)
			{
				NNMHEPDJOHK = TavernZonesManager.OIJLJKLMCBO().MDPHAHIFJFB(LDMDHEPJFFD);
				if (IKBFJCOONIM() != null)
				{
					NNMHEPDJOHK.FDODBGKMEOG(this);
				}
				else
				{
					NNMHEPDJOHK = null;
				}
			}
		}
		else
		{
			NNMHEPDJOHK = null;
		}
		currentZoneType = GIBJPCAFCJB;
		currentZoneIndex = LDMDHEPJFFD;
	}

	private bool APNKIDLNFLC(bool BIOKGEFFNAA)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		MPCJBPJAGKK = Utils.MMFCGMDOLDM(itemBase);
		ACAIKFICNFP = Utils.IKJOHEODBBE(itemBase);
		if (IsObjectOnASurface())
		{
			if (!isPlaceableOnWall)
			{
				return true;
			}
			IIDIOJKCGDE = Utils.MMFCGMDOLDM(currentSurface.surfaceCollider);
			HIHOGLOBDJB = Utils.IKJOHEODBBE(currentSurface.surfaceCollider);
			SnapToPosition snapItem = currentSurface.GetSnapItem(itemSetup.item);
			if (snapItem != null && snapItem.fixedY)
			{
				if (MPCJBPJAGKK.x < IIDIOJKCGDE.x || ACAIKFICNFP.x > HIHOGLOBDJB.x)
				{
					return false;
				}
				if (Object.op_Implicit((Object)(object)physicalSpace) && !physicalSpace.ValidPosition())
				{
					return false;
				}
				if (physicalSpaces != null && physicalSpaces.Length != 0 && !MKEJCEEDIKP())
				{
					return false;
				}
				return true;
			}
			return true;
		}
		if (placeableAnywhere)
		{
			return true;
		}
		if (isPlaceableOnSurface && onlyInAllowedSurfaces && !isPlaceableOnWall)
		{
			if (BIOKGEFFNAA)
			{
				MainUI.ShowErrorText(CAEDMEDBEGI: LocalisationSystem.Get((itemSetup.item is Chicken) ? "Error_PlaceItInChickenCoop" : ((!(itemSetup.item is Animal)) ? "PlaceableOnSpecificSurfaces" : "Error_PlaceItInAnimalSpace")), JIIGOACEIKL: JIIGOACEIKL);
			}
			return false;
		}
		if (!IsInValidLocation(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))))
		{
			return false;
		}
		PGLIMJFBEKP = true;
		JNHDHIKAJCE = HHAEKEAPKOE(itemBase);
		for (LKFKLHOCPKC = MPCJBPJAGKK.x; LKFKLHOCPKC < ACAIKFICNFP.x; LKFKLHOCPKC += 0.5f)
		{
			PGLIMJFBEKP = FCGPPPPDFMB(LKFKLHOCPKC);
			if (!PGLIMJFBEKP)
			{
				break;
			}
		}
		if (PGLIMJFBEKP)
		{
			PGLIMJFBEKP = FCGPPPPDFMB(ACAIKFICNFP.x);
		}
		if (!PGLIMJFBEKP)
		{
			return false;
		}
		if (isPlaceableOnWall && isPlaceableOnSurface && onlyInAllowedSurfaces)
		{
			bool flag = true;
			for (int i = 0; i < JNHDHIKAJCE.Length; i++)
			{
				flag &= WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(JNHDHIKAJCE[i]));
			}
			if (flag)
			{
				PGLIMJFBEKP &= FNPBNFFEBAF();
				if (PGLIMJFBEKP && Object.op_Implicit((Object)(object)physicalSpace))
				{
					PGLIMJFBEKP &= physicalSpace.ValidPosition();
				}
				if (PGLIMJFBEKP && physicalSpaces != null && physicalSpaces.Length != 0)
				{
					PGLIMJFBEKP &= MKEJCEEDIKP();
				}
			}
			else
			{
				PGLIMJFBEKP = false;
			}
		}
		else
		{
			if (isPlaceableOnWall)
			{
				PGLIMJFBEKP &= FNPBNFFEBAF();
			}
			else
			{
				for (int j = 0; j < JNHDHIKAJCE.Length; j++)
				{
					PGLIMJFBEKP &= !WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(JNHDHIKAJCE[j]));
				}
				if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) != 0 && WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) != Location.Tavern && WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) != Location.Road && !WorldGrid.NGDHDMAMGPI(((Component)this).transform.position))
				{
					PGLIMJFBEKP = false;
				}
			}
			if (PGLIMJFBEKP && Object.op_Implicit((Object)(object)physicalSpace))
			{
				PGLIMJFBEKP &= physicalSpace.ValidPosition();
			}
			if (PGLIMJFBEKP && physicalSpaces != null && physicalSpaces.Length != 0)
			{
				PGLIMJFBEKP &= MKEJCEEDIKP();
			}
		}
		return PGLIMJFBEKP;
	}

	private bool BJPIMLCLJON()
	{
		if (skins.Length != 0)
		{
			return true;
		}
		if (skinVariationGropus.Count > 0)
		{
			return true;
		}
		return false;
	}

	private void DMCGBCNHIIG()
	{
		if (multipleSkins && canCycleSkin)
		{
			NextSkin();
			return;
		}
		ItemSetup component = ((Component)this).GetComponent<ItemSetup>();
		if ((Object)(object)component != (Object)null)
		{
			component.GDEFMCFPDDD();
		}
	}

	private void HEEDOLJAOHF(int HLOIOAOICEG, bool JGBPPOBEFND = true)
	{
		if (JGBPPOBEFND)
		{
			if (Object.op_Implicit((Object)(object)parent))
			{
				Utils.ELNJMNKOACA(parent.gameObject, HLOIOAOICEG);
			}
			else
			{
				Utils.ELNJMNKOACA(((Component)this).gameObject, HLOIOAOICEG);
			}
		}
		else if (Object.op_Implicit((Object)(object)parent))
		{
			parent.gameObject.layer = HLOIOAOICEG;
		}
		else
		{
			((Component)this).gameObject.layer = HLOIOAOICEG;
		}
	}

	public void FBEIKNJOJLC()
	{
		if (!((Object)(object)disableOnInvisible != (Object)null))
		{
			return;
		}
		Collider2D[] componentsInChildren = ((Component)this).gameObject.GetComponentsInChildren<Collider2D>();
		List<Collider2D> list = new List<Collider2D>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (componentsInChildren[i].isTrigger && ((Behaviour)componentsInChildren[i]).enabled)
			{
				list.Add(componentsInChildren[i]);
			}
		}
		disableOnInvisible.colliders = list.ToArray();
	}

	public void UnSnapAll()
	{
		if (Object.op_Implicit((Object)(object)snapLeftRight))
		{
			snapLeftRight.UnSnap(SnapTriggerPole.Left);
			snapLeftRight.UnSnap(SnapTriggerPole.Right);
		}
	}

	private void GDBFHMPLOEH(int HLOIOAOICEG, bool JGBPPOBEFND = true)
	{
		if (JGBPPOBEFND)
		{
			if (Object.op_Implicit((Object)(object)parent))
			{
				Utils.ELNJMNKOACA(parent.gameObject, HLOIOAOICEG);
			}
			else
			{
				Utils.ELNJMNKOACA(((Component)this).gameObject, HLOIOAOICEG);
			}
		}
		else if (Object.op_Implicit((Object)(object)parent))
		{
			parent.gameObject.layer = HLOIOAOICEG;
		}
		else
		{
			((Component)this).gameObject.layer = HLOIOAOICEG;
		}
	}

	public bool Select(int JIIGOACEIKL)
	{
		return FHEMHCEAICB;
	}

	public void ChangeObjectLayer(bool ODNGJHPOMMK)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)itemSpace != (Object)null)
		{
			List<Placeable> list = new List<Placeable>();
			for (int i = 0; i < itemSpace.buildSquares.Length; i++)
			{
				if (WorldGrid.OPLHBJGKKAD(itemSpace.buildSquares[i].GetCentrePosition()) != null)
				{
					list.AddRange(WorldGrid.OPLHBJGKKAD(itemSpace.buildSquares[i].GetCentrePosition()));
				}
			}
			for (int num = list.Count - 1; num >= 0; num--)
			{
				if ((Object)(object)list[num] != (Object)null && (Object)(object)list[num].itemSpace == (Object)null && !list[num].isPlaceableOnWall)
				{
					list[num].HEEDOLJAOHF(22);
				}
				else
				{
					list.RemoveAt(num);
				}
			}
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(BEAGILCJAHJ(21, list));
		}
		if (ODNGJHPOMMK)
		{
			HEEDOLJAOHF(22);
			return;
		}
		if (Utils.IELGICCBCHO(specificRules))
		{
			HEEDOLJAOHF(13);
		}
		else
		{
			HEEDOLJAOHF(21);
		}
		if (((Component)this).gameObject.CompareTag("Animal"))
		{
			HEEDOLJAOHF(25, JGBPPOBEFND: false);
		}
	}

	public void PPAKLBHHCMK(int JIIGOACEIKL)
	{
	}

	public bool IPCHJDEIFJN(Vector3 IMOBLFMHKOD, bool LHLHJCDKNHA, bool IBCOKMGFPKB = true, bool PIKKACMNOBM = true, bool PKFIAGMICCK = true)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (LHLHJCDKNHA && !isPlaceableOnWall)
		{
			return true;
		}
		if ((Object)(object)itemSpace != (Object)null && !itemSpace.canBeRemoved)
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)itemSpace))
		{
			itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false);
		}
		else if (isPlaceableOnWall)
		{
			RemoveItemBaseFromWall(IMOBLFMHKOD.y);
		}
		else
		{
			RemoveItemBaseFromWorldTiles();
		}
		if (PIKKACMNOBM)
		{
			DeliveryChest.GOBCANBKFEM().PJFMOLPMKIB(0, itemSetup.FOIPFKPCIIN(), PKFIAGMICCK, IBCOKMGFPKB, CDPAMNIPPEC: false);
			RemovePlaceableAndItemsOnSurface(0, EFNFMEIDGDN: true, BGIEPKNAKHI: true, IBCOKMGFPKB, KAJIBKHFEFF: true);
		}
		else
		{
			if (PKFIAGMICCK)
			{
				DroppedItem.OFHEKCFLEGB(((Component)this).transform.position, itemSetup.FOIPFKPCIIN(), 0, LHLJILLAHFO: true);
			}
			HJGJFLNNCDD(1, EFNFMEIDGDN: false, PKFIAGMICCK, IBCOKMGFPKB);
		}
		return true;
	}

	public static Placeable GetRotationPrefab(Placeable EAPCLAODGAE, Direction FCGBJEIIMBC)
	{
		PHKPBKDAIBF = EAPCLAODGAE;
		DHKFDIJCOOB = 4;
		while (PHKPBKDAIBF.GetDirection() != FCGBJEIIMBC)
		{
			PHKPBKDAIBF = PHKPBKDAIBF.rotatedPrefab.GetComponentInChildren<Placeable>();
			DHKFDIJCOOB--;
			if (DHKFDIJCOOB <= 0)
			{
				Debug.LogError((object)(((Object)((Component)PHKPBKDAIBF).gameObject).name + ": Prefab direction not found!"));
				break;
			}
		}
		return PHKPBKDAIBF;
	}
}
