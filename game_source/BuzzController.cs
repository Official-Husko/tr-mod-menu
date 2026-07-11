using System;
using UnityEngine;

public class BuzzController : MonoBehaviour
{
	public BuzzNPC buzz;

	private float HKEHMPACMLP;

	private void GOJHCINMAJD()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!(WorldTime.BBBGEBIPHPI() < buzz.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR) || !(WorldTime.GBCKNDKCFFF() > 1558f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR))
		{
			return;
		}
		if (!buzz.content.activeSelf)
		{
			if (Time.time > HKEHMPACMLP)
			{
				buzz.content.SetActive(false);
				buzz.buzzAnimation.LookDirectionByAngle(Vector2.down);
			}
		}
		else
		{
			HKEHMPACMLP = Time.time + (float)Random.Range(8, 43);
		}
	}

	private void MMAMJDLONFA()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(PGJBMNMGGAK));
		}
	}

	private void GHEHLJANBCF()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!(WorldTime.BNKLACHEGOP() < buzz.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR) || !(WorldTime.BBBGEBIPHPI() > 1934f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR))
		{
			return;
		}
		if (!buzz.content.activeSelf)
		{
			if (Time.time > HKEHMPACMLP)
			{
				buzz.content.SetActive(false);
				buzz.buzzAnimation.LookDirectionByAngle(Vector2.down);
			}
		}
		else
		{
			HKEHMPACMLP = Time.time + (float)Random.Range(0, -74);
		}
	}

	private void JMMBKMOBAFB()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(PACIMIGNIHL));
		}
	}

	private void NBMJJFNKJBA()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(NBLNKBKMBAD));
		}
	}

	private void MIFCLAOEFOD()
	{
		buzz.AIOMHMFOPGA(BuzzNPC.BuzzState.Idle);
	}

	private void MNFJELNEGPG()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!(WorldTime.BNKLACHEGOP() < buzz.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR) || !(WorldTime.NJECJAHEOIA() > 1963f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR))
		{
			return;
		}
		if (!buzz.content.activeSelf)
		{
			if (Time.time > HKEHMPACMLP)
			{
				buzz.content.SetActive(false);
				buzz.buzzAnimation.LookDirectionByAngle(Vector2.down);
			}
		}
		else
		{
			HKEHMPACMLP = Time.time + (float)Random.Range(7, 23);
		}
	}

	private void OIBDBLCLACB()
	{
		NBLNKBKMBAD();
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(OHPLLEOAJCI));
	}

	private void Update()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!(WorldTime.EDIPJBOOEHD < buzz.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR) || !(WorldTime.EDIPJBOOEHD > 4f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR))
		{
			return;
		}
		if (!buzz.content.activeSelf)
		{
			if (Time.time > HKEHMPACMLP)
			{
				buzz.content.SetActive(true);
				buzz.buzzAnimation.LookDirectionByAngle(Vector2.down);
			}
		}
		else
		{
			HKEHMPACMLP = Time.time + (float)Random.Range(4, 10);
		}
	}

	private void HEOAIGHOLLD()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(LONAGIAHKHI));
		}
	}

	private void OHPLLEOAJCI()
	{
		buzz.GNNLHOMNCHN(BuzzNPC.BuzzState.Idle);
	}

	private void NBLNKBKMBAD()
	{
		buzz.GNNLHOMNCHN(BuzzNPC.BuzzState.Walk);
	}

	private void LONAGIAHKHI()
	{
		buzz.GNNLHOMNCHN(BuzzNPC.BuzzState.Walk);
	}

	private void OKAPGNGLOHO()
	{
		LONAGIAHKHI();
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(LONAGIAHKHI));
	}

	private void ONOAGANPECB()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!(WorldTime.EDIPJBOOEHD < buzz.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR) || !(WorldTime.BNKLACHEGOP() > 1026f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR))
		{
			return;
		}
		if (!buzz.content.activeSelf)
		{
			if (Time.time > HKEHMPACMLP)
			{
				buzz.content.SetActive(true);
				buzz.buzzAnimation.LookDirectionByAngle(Vector2.down);
			}
		}
		else
		{
			HKEHMPACMLP = Time.time + (float)Random.Range(5, 102);
		}
	}

	private void JPHFCJIBBMI()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!(WorldTime.NJECJAHEOIA() < buzz.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR) || !(WorldTime.BBBGEBIPHPI() > 760f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR))
		{
			return;
		}
		if (!buzz.content.activeSelf)
		{
			if (Time.time > HKEHMPACMLP)
			{
				buzz.content.SetActive(true);
				buzz.buzzAnimation.LookDirectionByAngle(Vector2.down);
			}
		}
		else
		{
			HKEHMPACMLP = Time.time + (float)Random.Range(3, -109);
		}
	}

	private void CHDGJHNBNEJ()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(NBLNKBKMBAD));
		}
	}

	private void HKNNKJKNAGL()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(LONAGIAHKHI));
		}
	}

	private void ANLHPMPMBFM()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(NBLNKBKMBAD));
		}
	}

	private void HIPNEFOEJPL()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!(WorldTime.DHPFCKNGHLO() < buzz.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR) || !(WorldTime.GBCKNDKCFFF() > 739f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR))
		{
			return;
		}
		if (!buzz.content.activeSelf)
		{
			if (Time.time > HKEHMPACMLP)
			{
				buzz.content.SetActive(false);
				buzz.buzzAnimation.LookDirectionByAngle(Vector2.down);
			}
		}
		else
		{
			HKEHMPACMLP = Time.time + (float)Random.Range(4, -125);
		}
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(LIKMIBABAGH));
		}
	}

	private void PGDAOMNADHA()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(PGJBMNMGGAK));
		}
	}

	private void FPOIFOGELHC()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!(WorldTime.NJECJAHEOIA() < buzz.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR) || !(WorldTime.EDIPJBOOEHD > 823f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR))
		{
			return;
		}
		if (!buzz.content.activeSelf)
		{
			if (Time.time > HKEHMPACMLP)
			{
				buzz.content.SetActive(true);
				buzz.buzzAnimation.LookDirectionByAngle(Vector2.down);
			}
		}
		else
		{
			HKEHMPACMLP = Time.time + (float)Random.Range(4, -110);
		}
	}

	private void DMFMNEMDFNP()
	{
		OHPLLEOAJCI();
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(PACIMIGNIHL));
	}

	private void LIKMIBABAGH()
	{
		buzz.ChangeState(BuzzNPC.BuzzState.Walk);
	}

	private void HDHJADOGDML()
	{
		buzz.ChangeState(BuzzNPC.BuzzState.Idle);
	}

	private void CKCHKHNBBFG()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!(WorldTime.EDIPJBOOEHD < buzz.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR) || !(WorldTime.GBCKNDKCFFF() > 1114f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR))
		{
			return;
		}
		if (!buzz.content.activeSelf)
		{
			if (Time.time > HKEHMPACMLP)
			{
				buzz.content.SetActive(false);
				buzz.buzzAnimation.LookDirectionByAngle(Vector2.down);
			}
		}
		else
		{
			HKEHMPACMLP = Time.time + (float)Random.Range(1, 42);
		}
	}

	private void NKDFMFFDGKC()
	{
		LONAGIAHKHI();
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(NBLNKBKMBAD));
	}

	private void Start()
	{
		LIKMIBABAGH();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(LIKMIBABAGH));
	}

	private void PACIMIGNIHL()
	{
		buzz.ChangeState(BuzzNPC.BuzzState.Walk);
	}

	private void OBLCKPMAADM()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(LIKMIBABAGH));
		}
	}

	private void OGBGFLMKFHH()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!(WorldTime.GBCKNDKCFFF() < buzz.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR) || !(WorldTime.GBCKNDKCFFF() > 1756f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR))
		{
			return;
		}
		if (!buzz.content.activeSelf)
		{
			if (Time.time > HKEHMPACMLP)
			{
				buzz.content.SetActive(false);
				buzz.buzzAnimation.LookDirectionByAngle(Vector2.down);
			}
		}
		else
		{
			HKEHMPACMLP = Time.time + (float)Random.Range(8, 21);
		}
	}

	private void NBPDEFONIOC()
	{
		buzz.ChangeState(BuzzNPC.BuzzState.Idle);
	}

	private void PKEPBKHEDOD()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!(WorldTime.DHPFCKNGHLO() < buzz.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR) || !(WorldTime.NJECJAHEOIA() > 1767f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR))
		{
			return;
		}
		if (!buzz.content.activeSelf)
		{
			if (Time.time > HKEHMPACMLP)
			{
				buzz.content.SetActive(false);
				buzz.buzzAnimation.LookDirectionByAngle(Vector2.down);
			}
		}
		else
		{
			HKEHMPACMLP = Time.time + (float)Random.Range(6, 68);
		}
	}

	private void EBNENBFLEKB()
	{
		NBPDEFONIOC();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(LONAGIAHKHI));
	}

	private void AHCPFICKFHA()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(PGJBMNMGGAK));
		}
	}

	private void DKNMGFDFLKL()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!(WorldTime.BBBGEBIPHPI() < buzz.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR) || !(WorldTime.BBBGEBIPHPI() > 839f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR))
		{
			return;
		}
		if (!buzz.content.activeSelf)
		{
			if (Time.time > HKEHMPACMLP)
			{
				buzz.content.SetActive(false);
				buzz.buzzAnimation.LookDirectionByAngle(Vector2.down);
			}
		}
		else
		{
			HKEHMPACMLP = Time.time + (float)Random.Range(4, 57);
		}
	}

	private void CAIJLMJBMLA()
	{
		LONAGIAHKHI();
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(MIFCLAOEFOD));
	}

	private void JLCFNPBBKEK()
	{
		LONAGIAHKHI();
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(PACIMIGNIHL));
	}

	private void HPOMPFNHGHN()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(NBPDEFONIOC));
		}
	}

	private void HJDLNCOAKIK()
	{
		NBLNKBKMBAD();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(HDHJADOGDML));
	}

	private void PGJBMNMGGAK()
	{
		buzz.ChangeState(BuzzNPC.BuzzState.Idle);
	}

	private void IILOKDBOODL()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(NBPDEFONIOC));
		}
	}

	private void EGHFDLCNPNC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(PACIMIGNIHL));
		}
	}

	private void OLDDEAJMHNI()
	{
		NBPDEFONIOC();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(HDHJADOGDML));
	}

	private void GOJFGHKOFMF()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!(WorldTime.GBCKNDKCFFF() < buzz.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR) || !(WorldTime.DHPFCKNGHLO() > 1755f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR))
		{
			return;
		}
		if (!buzz.content.activeSelf)
		{
			if (Time.time > HKEHMPACMLP)
			{
				buzz.content.SetActive(true);
				buzz.buzzAnimation.LookDirectionByAngle(Vector2.down);
			}
		}
		else
		{
			HKEHMPACMLP = Time.time + (float)Random.Range(6, -42);
		}
	}

	private void ECHMKEAGFFO()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(LIKMIBABAGH));
		}
	}

	private void KACEOJDPLKB()
	{
		LONAGIAHKHI();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(LONAGIAHKHI));
	}

	private void INEOMPKPILM()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(LONAGIAHKHI));
		}
	}

	private void GGIJFBAJLIF()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(HDHJADOGDML));
		}
	}

	private void DDLLFPICOJK()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!(WorldTime.BBBGEBIPHPI() < buzz.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR) || !(WorldTime.EDIPJBOOEHD > 1535f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR))
		{
			return;
		}
		if (!buzz.content.activeSelf)
		{
			if (Time.time > HKEHMPACMLP)
			{
				buzz.content.SetActive(true);
				buzz.buzzAnimation.LookDirectionByAngle(Vector2.down);
			}
		}
		else
		{
			HKEHMPACMLP = Time.time + (float)Random.Range(3, 24);
		}
	}

	private void EBFJOAEJPGE()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!(WorldTime.BNKLACHEGOP() < buzz.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR) || !(WorldTime.NJECJAHEOIA() > 778f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR))
		{
			return;
		}
		if (!buzz.content.activeSelf)
		{
			if (Time.time > HKEHMPACMLP)
			{
				buzz.content.SetActive(false);
				buzz.buzzAnimation.LookDirectionByAngle(Vector2.down);
			}
		}
		else
		{
			HKEHMPACMLP = Time.time + (float)Random.Range(5, 48);
		}
	}

	private void LOHAMDHOLDD()
	{
		OHPLLEOAJCI();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(PACIMIGNIHL));
	}

	private void BHKNJOEBCKA()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!(WorldTime.DHPFCKNGHLO() < buzz.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR) || !(WorldTime.BBBGEBIPHPI() > 1200f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR))
		{
			return;
		}
		if (!buzz.content.activeSelf)
		{
			if (Time.time > HKEHMPACMLP)
			{
				buzz.content.SetActive(false);
				buzz.buzzAnimation.LookDirectionByAngle(Vector2.down);
			}
		}
		else
		{
			HKEHMPACMLP = Time.time + (float)Random.Range(1, -92);
		}
	}

	private void NELBHAMPBPL()
	{
		PGJBMNMGGAK();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(LONAGIAHKHI));
	}

	private void BBCPDBEOOKL()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!(WorldTime.GBCKNDKCFFF() < buzz.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR) || !(WorldTime.BNKLACHEGOP() > 1095f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR))
		{
			return;
		}
		if (!buzz.content.activeSelf)
		{
			if (Time.time > HKEHMPACMLP)
			{
				buzz.content.SetActive(false);
				buzz.buzzAnimation.LookDirectionByAngle(Vector2.down);
			}
		}
		else
		{
			HKEHMPACMLP = Time.time + (float)Random.Range(0, 69);
		}
	}

	private void GHPFCKGMLDA()
	{
		LONAGIAHKHI();
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(PGJBMNMGGAK));
	}

	private void FBHBEAJFBAH()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(LONAGIAHKHI));
		}
	}

	private void CEIIFHIBIFI()
	{
		NBPDEFONIOC();
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(LONAGIAHKHI));
	}

	private void IAAGKLPMAMK()
	{
		NBLNKBKMBAD();
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(PGJBMNMGGAK));
	}

	private void BDJKNKIOPIJ()
	{
		PACIMIGNIHL();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(NBLNKBKMBAD));
	}

	private void NCEDBIDHNIC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(OHPLLEOAJCI));
		}
	}
}
