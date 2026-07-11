using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ConstructionSlotUI : MonoBehaviour
{
	public Action<ConstructionSlotUI> OnButtonPressed = delegate
	{
	};

	public Image icon;

	public Image checkbox;

	public Button button;

	public IconMaterial ICEAJNDEOAB { get; private set; }

	public SpritesList ONLCBJNNJMB { get; private set; }

	public void OOEEMHGPCKC(SpritesList ONLCBJNNJMB, bool HGNKFFMDOOL)
	{
		OBCDKGAFGPM(ONLCBJNNJMB);
		icon.sprite = ONLCBJNNJMB.icon;
		BKOAGIAFMKJ(HGNKFFMDOOL);
	}

	[SpecialName]
	private void JNGGNPAAJNG(IconMaterial AODONKKHPBP)
	{
		_003CBLADDPJGNKG_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	private void PHNPIEICGPE(SpritesList AODONKKHPBP)
	{
		_003CDHOPMGFHLDB_003Ek__BackingField = AODONKKHPBP;
	}

	public void LAMGIENNNLH()
	{
		OnButtonPressed(this);
	}

	[SpecialName]
	private void JPNHCJFHNPC(SpritesList AODONKKHPBP)
	{
		_003CDHOPMGFHLDB_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public IconMaterial POHKABMMKDG()
	{
		return _003CBLADDPJGNKG_003Ek__BackingField;
	}

	public void DANKFLGFKCI(IconMaterial GGHLHODEPIK, bool HGNKFFMDOOL)
	{
		JNGGNPAAJNG(GGHLHODEPIK);
		icon.sprite = GGHLHODEPIK.icon;
		FOBPLPONDNJ(HGNKFFMDOOL);
	}

	[SpecialName]
	private void JGKPAIMFDIN(IconMaterial AODONKKHPBP)
	{
		_003CBLADDPJGNKG_003Ek__BackingField = AODONKKHPBP;
	}

	public void OCACOLMODDN(bool HGNKFFMDOOL)
	{
		((Component)checkbox).gameObject.SetActive(HGNKFFMDOOL);
	}

	public void IKBGFIEJHCB(IconMaterial GGHLHODEPIK, bool HGNKFFMDOOL)
	{
		IPKPKDEFFIK(GGHLHODEPIK);
		icon.sprite = GGHLHODEPIK.icon;
		FOBPLPONDNJ(HGNKFFMDOOL);
	}

	public void DDEONCGGFBG()
	{
		OnButtonPressed(this);
	}

	[SpecialName]
	private void PCGIIENIGFH(SpritesList AODONKKHPBP)
	{
		_003CDHOPMGFHLDB_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	private void POPDJBBJMNH(SpritesList AODONKKHPBP)
	{
		_003CDHOPMGFHLDB_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	private void KFMJDDCPLPI(SpritesList AODONKKHPBP)
	{
		_003CDHOPMGFHLDB_003Ek__BackingField = AODONKKHPBP;
	}

	public void BKOAGIAFMKJ(bool HGNKFFMDOOL)
	{
		((Component)checkbox).gameObject.SetActive(HGNKFFMDOOL);
	}

	public void UpdateSlot(SpritesList ONLCBJNNJMB, bool HGNKFFMDOOL)
	{
		this.ONLCBJNNJMB = ONLCBJNNJMB;
		icon.sprite = ONLCBJNNJMB.icon;
		SetSelected(HGNKFFMDOOL);
	}

	public void FANLFCHLDBH(IconMaterial GGHLHODEPIK, bool HGNKFFMDOOL)
	{
		JNGGNPAAJNG(GGHLHODEPIK);
		icon.sprite = GGHLHODEPIK.icon;
		LAIHGJCLIAD(HGNKFFMDOOL);
	}

	public void MIHNOABDHIK(SpritesList ONLCBJNNJMB, bool HGNKFFMDOOL)
	{
		JPNHCJFHNPC(ONLCBJNNJMB);
		icon.sprite = ONLCBJNNJMB.icon;
		IMHAPJNDPMM(HGNKFFMDOOL);
	}

	public void UpdateSlot(IconMaterial GGHLHODEPIK, bool HGNKFFMDOOL)
	{
		ICEAJNDEOAB = GGHLHODEPIK;
		icon.sprite = GGHLHODEPIK.icon;
		SetSelected(HGNKFFMDOOL);
	}

	[SpecialName]
	private void IPKPKDEFFIK(IconMaterial AODONKKHPBP)
	{
		_003CBLADDPJGNKG_003Ek__BackingField = AODONKKHPBP;
	}

	public void ButtonPressed()
	{
		OnButtonPressed(this);
	}

	public void AKMEOFBFNOM(SpritesList ONLCBJNNJMB, bool HGNKFFMDOOL)
	{
		FKKLPCLJKLI(ONLCBJNNJMB);
		icon.sprite = ONLCBJNNJMB.icon;
		LAIHGJCLIAD(HGNKFFMDOOL);
	}

	[SpecialName]
	private void CLLABENENPK(IconMaterial AODONKKHPBP)
	{
		_003CBLADDPJGNKG_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public IconMaterial OFCOIADADFD()
	{
		return _003CBLADDPJGNKG_003Ek__BackingField;
	}

	public void OPMGIPJMJDA(SpritesList ONLCBJNNJMB, bool HGNKFFMDOOL)
	{
		this.ONLCBJNNJMB = ONLCBJNNJMB;
		icon.sprite = ONLCBJNNJMB.icon;
		IMHAPJNDPMM(HGNKFFMDOOL);
	}

	public void PDPFLAKIMKL(IconMaterial GGHLHODEPIK, bool HGNKFFMDOOL)
	{
		KOEHNLDLEOF(GGHLHODEPIK);
		icon.sprite = GGHLHODEPIK.icon;
		BKOAGIAFMKJ(HGNKFFMDOOL);
	}

	[SpecialName]
	private void MCJJMOEANCP(SpritesList AODONKKHPBP)
	{
		_003CDHOPMGFHLDB_003Ek__BackingField = AODONKKHPBP;
	}

	public void DMEEHPJCFIN(IconMaterial GGHLHODEPIK, bool HGNKFFMDOOL)
	{
		ICEAJNDEOAB = GGHLHODEPIK;
		icon.sprite = GGHLHODEPIK.icon;
		FOBPLPONDNJ(HGNKFFMDOOL);
	}

	[SpecialName]
	public SpritesList IIDBBIKDBGM()
	{
		return _003CDHOPMGFHLDB_003Ek__BackingField;
	}

	public void FOBPLPONDNJ(bool HGNKFFMDOOL)
	{
		((Component)checkbox).gameObject.SetActive(HGNKFFMDOOL);
	}

	public void OBDCCMBDOGN()
	{
		OnButtonPressed(this);
	}

	[SpecialName]
	private void FKKLPCLJKLI(SpritesList AODONKKHPBP)
	{
		_003CDHOPMGFHLDB_003Ek__BackingField = AODONKKHPBP;
	}

	public void SetSelected(bool HGNKFFMDOOL)
	{
		((Component)checkbox).gameObject.SetActive(HGNKFFMDOOL);
	}

	[SpecialName]
	public SpritesList JPMHLAOKPOJ()
	{
		return _003CDHOPMGFHLDB_003Ek__BackingField;
	}

	public void EPONOAAKIPO(SpritesList ONLCBJNNJMB, bool HGNKFFMDOOL)
	{
		KFMJDDCPLPI(ONLCBJNNJMB);
		icon.sprite = ONLCBJNNJMB.icon;
		FOBPLPONDNJ(HGNKFFMDOOL);
	}

	[SpecialName]
	private void BLOEMJEKLEK(SpritesList AODONKKHPBP)
	{
		_003CDHOPMGFHLDB_003Ek__BackingField = AODONKKHPBP;
	}

	public void IPMFHNDCMJI()
	{
		OnButtonPressed(this);
	}

	public void EHEMKKCGLHI(IconMaterial GGHLHODEPIK, bool HGNKFFMDOOL)
	{
		IPKPKDEFFIK(GGHLHODEPIK);
		icon.sprite = GGHLHODEPIK.icon;
		LAIHGJCLIAD(HGNKFFMDOOL);
	}

	public void ABFPLCMOMML(IconMaterial GGHLHODEPIK, bool HGNKFFMDOOL)
	{
		ICEAJNDEOAB = GGHLHODEPIK;
		icon.sprite = GGHLHODEPIK.icon;
		IMHAPJNDPMM(HGNKFFMDOOL);
	}

	[SpecialName]
	private void KOEHNLDLEOF(IconMaterial AODONKKHPBP)
	{
		_003CBLADDPJGNKG_003Ek__BackingField = AODONKKHPBP;
	}

	public void LAIHGJCLIAD(bool HGNKFFMDOOL)
	{
		((Component)checkbox).gameObject.SetActive(HGNKFFMDOOL);
	}

	public void MBNLOLOMDBD(SpritesList ONLCBJNNJMB, bool HGNKFFMDOOL)
	{
		KFMJDDCPLPI(ONLCBJNNJMB);
		icon.sprite = ONLCBJNNJMB.icon;
		IMHAPJNDPMM(HGNKFFMDOOL);
	}

	[SpecialName]
	private void PDAMGKOALGM(SpritesList AODONKKHPBP)
	{
		_003CDHOPMGFHLDB_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	private void OBCDKGAFGPM(SpritesList AODONKKHPBP)
	{
		_003CDHOPMGFHLDB_003Ek__BackingField = AODONKKHPBP;
	}

	public void IMHAPJNDPMM(bool HGNKFFMDOOL)
	{
		((Component)checkbox).gameObject.SetActive(HGNKFFMDOOL);
	}

	[SpecialName]
	public IconMaterial MDBJJONDIFP()
	{
		return _003CBLADDPJGNKG_003Ek__BackingField;
	}

	[SpecialName]
	public SpritesList FHOCLENCNOK()
	{
		return _003CDHOPMGFHLDB_003Ek__BackingField;
	}
}
