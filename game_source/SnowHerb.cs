using System;
using UnityEngine;

public class SnowHerb : MonoBehaviour
{
	public SpriteRenderer herbRenderer;

	public Sprite herbSnow;

	public Sprite herb;

	public bool herbIsFrozen;

	private void KJOJLHCDFPP()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(HEGMOPECCAB));
		DJENIMOBKDC();
	}

	public void JPJOCHMBJLE()
	{
		herbRenderer.sprite = herb;
		herbIsFrozen = true;
	}

	public void KJAGJOGHHAJ()
	{
		herbRenderer.sprite = herb;
		herbIsFrozen = false;
	}

	private void ACFABFCGIGH()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(PFCPJLPIEPH));
	}

	private void MMNBJPDJHGK()
	{
		herbIsFrozen = false;
	}

	private void ALEAOANPHIO()
	{
		herbIsFrozen = true;
	}

	private void Start()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(GLFFNFFAIBA));
		GLFFNFFAIBA();
	}

	public void UnfrozenHerb()
	{
		herbRenderer.sprite = herb;
		herbIsFrozen = false;
	}

	private void KJHKBGDJNDC()
	{
		herbIsFrozen = false;
	}

	private void KHONOODGLBI()
	{
		herbIsFrozen = true;
	}

	private void HEGMOPECCAB()
	{
		herbRenderer.sprite = herbSnow;
		herbIsFrozen = false;
	}

	private void BKJFLMPOLCH()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(DJENIMOBKDC));
	}

	public void FEOJGENKELO()
	{
		herbRenderer.sprite = herb;
		herbIsFrozen = true;
	}

	private void Awake()
	{
		herbIsFrozen = true;
	}

	private void PFCPJLPIEPH()
	{
		herbRenderer.sprite = herbSnow;
		herbIsFrozen = true;
	}

	private void ELEGGKIBHGC()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(PFCPJLPIEPH));
	}

	private void GLFFNFFAIBA()
	{
		herbRenderer.sprite = herbSnow;
		herbIsFrozen = true;
	}

	private void PMLBFEFMNPF()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(DJENIMOBKDC));
	}

	private void JPOLFKMLHNH()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(HEGMOPECCAB));
		GLFFNFFAIBA();
	}

	private void MCMKNBIBDFF()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(PFCPJLPIEPH));
		DJENIMOBKDC();
	}

	private void JNJCCIFIKOC()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(POPFPJCLNNL));
	}

	private void CLLAKJADGIH()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(GLFFNFFAIBA));
	}

	public void DJFOGCLCEFB()
	{
		herbRenderer.sprite = herb;
		herbIsFrozen = true;
	}

	private void DFFDKIPCCKK()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(GLFFNFFAIBA));
	}

	private void OnDestroy()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(GLFFNFFAIBA));
	}

	private void POPFPJCLNNL()
	{
		herbRenderer.sprite = herbSnow;
		herbIsFrozen = false;
	}

	private void PHBJOOFMOFE()
	{
		herbRenderer.sprite = herbSnow;
		herbIsFrozen = false;
	}

	private void DJENIMOBKDC()
	{
		herbRenderer.sprite = herbSnow;
		herbIsFrozen = true;
	}

	private void EMJKKALMGLK()
	{
		herbIsFrozen = true;
	}

	private void GONDLJKGLGO()
	{
		herbIsFrozen = true;
	}

	private void LALJNGFGKPA()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(POPFPJCLNNL));
	}
}
