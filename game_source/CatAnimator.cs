using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class CatAnimator : BaseAnimator
{
	[CompilerGenerated]
	private sealed class ANNCCJLOLDJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CatAnimator _003C_003E4__this;

		private float _003Ctiempo_003E5__2;

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
		public ANNCCJLOLDJ(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CatAnimator catAnimator = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003Ctiempo_003E5__2 = 0f;
				catAnimator.DIFKLOCALFE = catAnimator.catNpc.transform.position;
				catAnimator.PLGBNELHDMJ = (0f - 2f * catAnimator.alturaMaxima) / (catAnimator.duracionSubida * catAnimator.duracionSubida);
				catAnimator.JGLCFPDGIFN = (0f - catAnimator.PLGBNELHDMJ) * catAnimator.duracionSubida;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (_003Ctiempo_003E5__2 < catAnimator.duracionSubida)
			{
				float deltaTime = Time.deltaTime;
				_003Ctiempo_003E5__2 += deltaTime;
				catAnimator.JGLCFPDGIFN += catAnimator.PLGBNELHDMJ * deltaTime;
				Transform transform = catAnimator.catNpc.transform;
				transform.position += new Vector3(0f, catAnimator.JGLCFPDGIFN * deltaTime, 0f);
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			catAnimator.catNpc.transform.position = catAnimator.DIFKLOCALFE + new Vector3(0f, catAnimator.alturaMaxima, 0f);
			return false;
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

	public Animator animator;

	[SerializeField]
	public int catIndex;

	public int shadowIndex;

	public ReskinAnimation[] allReskins;

	public ReskinAnimation[] reskins;

	public ReskinAnimation[] shadowReskins;

	private int AIIGJBGJMJK;

	private int CKMGPHJOHDN;

	public bool safeMovement = true;

	public GameObject catNpc;

	public float alturaMaxima = 2.5f;

	public float duracionSubida = 0.5f;

	private float PLGBNELHDMJ;

	private float JGLCFPDGIFN;

	private Vector3 DIFKLOCALFE;

	private void INCOGEMNFNH()
	{
		HDBEDEGEMCC();
	}

	private IEnumerator BDCOMCGBBHF()
	{
		return new ANNCCJLOLDJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void KNEMEOCNLIA()
	{
		for (int i = 0; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		ONLHEJPEMEC();
		for (int j = 0; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void CCFJKGJPHJF()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void ABKDJFEHEFG()
	{
		KIJGAEMEHGL();
	}

	public void GBPBKNDDLJA()
	{
		for (int i = 1; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		PHGEBLFGPKM();
		for (int j = 0; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void JDCBLACBJAP()
	{
		for (int i = 0; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		MCNIBEKFHGN();
		for (int j = 0; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void KNJECDLOAGK()
	{
		for (int i = 0; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		MCNIBEKFHGN();
		for (int j = 1; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void JFKIOIFNCCF()
	{
		for (int i = 1; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		GLBNPJDAILO();
		for (int j = 1; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void GLBNPJDAILO()
	{
		if (catIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = catIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].KFHGLOFHCHH(catIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].KFHGLOFHCHH(shadowIndex);
			}
		}
	}

	public void DPFHCNNALJP()
	{
		((MonoBehaviour)this).StartCoroutine(NCHLIBCKHMK());
	}

	public void EPCHANNEBFK(SpriteInfo OJKJDNNBJOF)
	{
		reskins[0].ChangeSpriteInfo(OJKJDNNBJOF);
	}

	private void KIJGAEMEHGL()
	{
		if (catIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = catIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(catIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	private void DKFGDMNBAAK()
	{
		GLBNPJDAILO();
	}

	private void GKBIHFPDDKN()
	{
		if (catIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = catIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].UpdateSprite(catIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].KFHGLOFHCHH(shadowIndex);
			}
		}
	}

	public void DOHAFEIOAIL()
	{
		((MonoBehaviour)this).StartCoroutine(LJEHELMKFGE());
	}

	private IEnumerator EFPEHAHGNIM()
	{
		return new ANNCCJLOLDJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DPCGJANDCGA()
	{
		for (int i = 1; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		GLBNPJDAILO();
		for (int j = 1; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void AGGOEIPCANE(SpriteInfo OJKJDNNBJOF)
	{
		reskins[0].ChangeSpriteInfo(OJKJDNNBJOF);
	}

	private void LACNIDGMKON()
	{
		if (catIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = catIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(catIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].UpdateSprite(shadowIndex);
			}
		}
	}

	private IEnumerator MEAMANGJBHP()
	{
		return new ANNCCJLOLDJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DFKDJPBMLKN()
	{
		float tiempo = 0f;
		DIFKLOCALFE = catNpc.transform.position;
		PLGBNELHDMJ = (0f - 2f * alturaMaxima) / (duracionSubida * duracionSubida);
		JGLCFPDGIFN = (0f - PLGBNELHDMJ) * duracionSubida;
		while (tiempo < duracionSubida)
		{
			float deltaTime = Time.deltaTime;
			tiempo += deltaTime;
			JGLCFPDGIFN += PLGBNELHDMJ * deltaTime;
			Transform transform = catNpc.transform;
			transform.position += new Vector3(0f, JGLCFPDGIFN * deltaTime, 0f);
			yield return null;
		}
		catNpc.transform.position = DIFKLOCALFE + new Vector3(0f, alturaMaxima, 0f);
	}

	private IEnumerator OEEFOGOOLDK()
	{
		float tiempo = 0f;
		DIFKLOCALFE = catNpc.transform.position;
		PLGBNELHDMJ = (0f - 2f * alturaMaxima) / (duracionSubida * duracionSubida);
		JGLCFPDGIFN = (0f - PLGBNELHDMJ) * duracionSubida;
		while (tiempo < duracionSubida)
		{
			float deltaTime = Time.deltaTime;
			tiempo += deltaTime;
			JGLCFPDGIFN += PLGBNELHDMJ * deltaTime;
			Transform transform = catNpc.transform;
			transform.position += new Vector3(0f, JGLCFPDGIFN * deltaTime, 0f);
			yield return null;
		}
		catNpc.transform.position = DIFKLOCALFE + new Vector3(0f, alturaMaxima, 0f);
	}

	public void KOFIEODBFIG(SpriteInfo OJKJDNNBJOF)
	{
		reskins[1].ChangeSpriteInfo(OJKJDNNBJOF);
	}

	public void DMANOGNBLKN()
	{
		((MonoBehaviour)this).StartCoroutine(MLLFKLMLCIO());
	}

	private void IIPGMPFHHIA()
	{
		if (catIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = catIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].UpdateSprite(catIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].KFHGLOFHCHH(shadowIndex);
			}
		}
	}

	private void BODEIHFOAMI()
	{
		LACNIDGMKON();
	}

	public void DCKJIFCBECA(SpriteInfo OJKJDNNBJOF)
	{
		reskins[0].ChangeSpriteInfo(OJKJDNNBJOF);
	}

	public void JIJDPHGJDCG(SpriteInfo OJKJDNNBJOF)
	{
		reskins[0].ChangeSpriteInfo(OJKJDNNBJOF);
	}

	private IEnumerator DFKKAOGHGCL()
	{
		return new ANNCCJLOLDJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NKIFOPEPICE()
	{
		return new ANNCCJLOLDJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void EGABJLFAACH()
	{
		((MonoBehaviour)this).StartCoroutine(NKIFOPEPICE());
	}

	public void ICLMNHPBMFN()
	{
		for (int i = 1; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		DIBFJEGCJGA();
		for (int j = 1; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void KHCPJLEHCJC()
	{
		for (int i = 0; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		MCNIBEKFHGN();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void OECJIIHIANE()
	{
		((MonoBehaviour)this).StartCoroutine(GPDNOEFBEOH());
	}

	private void FLHHGHJGPAD()
	{
		if (catIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = catIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].KFHGLOFHCHH(catIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].KFHGLOFHCHH(shadowIndex);
			}
		}
	}

	private void FLEODEFPJJF()
	{
		if (catIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = catIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].KFHGLOFHCHH(catIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].KFHGLOFHCHH(shadowIndex);
			}
		}
	}

	public void IKJLNIGGBDC()
	{
		((MonoBehaviour)this).StartCoroutine(LNJJIDAIIHG());
	}

	public void HBDPCJGIEMO()
	{
		((MonoBehaviour)this).StartCoroutine(PMCEBDOHBMH());
	}

	public void LMLNMIPGOEG()
	{
		((MonoBehaviour)this).StartCoroutine(HGMOJHMPKNF());
	}

	private IEnumerator LJEHELMKFGE()
	{
		float tiempo = 0f;
		DIFKLOCALFE = catNpc.transform.position;
		PLGBNELHDMJ = (0f - 2f * alturaMaxima) / (duracionSubida * duracionSubida);
		JGLCFPDGIFN = (0f - PLGBNELHDMJ) * duracionSubida;
		while (tiempo < duracionSubida)
		{
			float deltaTime = Time.deltaTime;
			tiempo += deltaTime;
			JGLCFPDGIFN += PLGBNELHDMJ * deltaTime;
			Transform transform = catNpc.transform;
			transform.position += new Vector3(0f, JGLCFPDGIFN * deltaTime, 0f);
			yield return null;
		}
		catNpc.transform.position = DIFKLOCALFE + new Vector3(0f, alturaMaxima, 0f);
	}

	private void HMGBIMHKFOD()
	{
		IIHOHMDMIBL();
	}

	private void EIMPOHJFEAL()
	{
		if (catIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = catIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].UpdateSprite(catIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].KFHGLOFHCHH(shadowIndex);
			}
		}
	}

	public void AddImages()
	{
		for (int i = 0; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		PHGEBLFGPKM();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void DJOBJFOEMJF()
	{
		((MonoBehaviour)this).StartCoroutine(GMELNENLJHJ());
	}

	private IEnumerator BDPBLPCAONE()
	{
		float tiempo = 0f;
		DIFKLOCALFE = catNpc.transform.position;
		PLGBNELHDMJ = (0f - 2f * alturaMaxima) / (duracionSubida * duracionSubida);
		JGLCFPDGIFN = (0f - PLGBNELHDMJ) * duracionSubida;
		while (tiempo < duracionSubida)
		{
			float deltaTime = Time.deltaTime;
			tiempo += deltaTime;
			JGLCFPDGIFN += PLGBNELHDMJ * deltaTime;
			Transform transform = catNpc.transform;
			transform.position += new Vector3(0f, JGLCFPDGIFN * deltaTime, 0f);
			yield return null;
		}
		catNpc.transform.position = DIFKLOCALFE + new Vector3(0f, alturaMaxima, 0f);
	}

	private IEnumerator LNJJIDAIIHG()
	{
		float tiempo = 0f;
		DIFKLOCALFE = catNpc.transform.position;
		PLGBNELHDMJ = (0f - 2f * alturaMaxima) / (duracionSubida * duracionSubida);
		JGLCFPDGIFN = (0f - PLGBNELHDMJ) * duracionSubida;
		while (tiempo < duracionSubida)
		{
			float deltaTime = Time.deltaTime;
			tiempo += deltaTime;
			JGLCFPDGIFN += PLGBNELHDMJ * deltaTime;
			Transform transform = catNpc.transform;
			transform.position += new Vector3(0f, JGLCFPDGIFN * deltaTime, 0f);
			yield return null;
		}
		catNpc.transform.position = DIFKLOCALFE + new Vector3(0f, alturaMaxima, 0f);
	}

	private IEnumerator GMELNENLJHJ()
	{
		float tiempo = 0f;
		DIFKLOCALFE = catNpc.transform.position;
		PLGBNELHDMJ = (0f - 2f * alturaMaxima) / (duracionSubida * duracionSubida);
		JGLCFPDGIFN = (0f - PLGBNELHDMJ) * duracionSubida;
		while (tiempo < duracionSubida)
		{
			float deltaTime = Time.deltaTime;
			tiempo += deltaTime;
			JGLCFPDGIFN += PLGBNELHDMJ * deltaTime;
			Transform transform = catNpc.transform;
			transform.position += new Vector3(0f, JGLCFPDGIFN * deltaTime, 0f);
			yield return null;
		}
		catNpc.transform.position = DIFKLOCALFE + new Vector3(0f, alturaMaxima, 0f);
	}

	private void PHGEBLFGPKM()
	{
		if (catIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = catIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].UpdateSprite(catIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].UpdateSprite(shadowIndex);
			}
		}
	}

	public void CPDMKOHGLBI()
	{
		for (int i = 1; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		LACNIDGMKON();
		for (int j = 1; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void CKJJHDGJMEL()
	{
		((MonoBehaviour)this).StartCoroutine(OEEFOGOOLDK());
	}

	private void IIHOHMDMIBL()
	{
		if (catIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = catIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(catIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].KFHGLOFHCHH(shadowIndex);
			}
		}
	}

	private void NIOCLHJJGLH()
	{
		if (catIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = catIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].UpdateSprite(catIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].UpdateSprite(shadowIndex);
			}
		}
	}

	public void OILCABPFJIH()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void DHNPMLNIGHM()
	{
		if (catIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = catIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].KFHGLOFHCHH(catIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].UpdateSprite(shadowIndex);
			}
		}
	}

	public void FGEHAEGDLDO(SpriteInfo OJKJDNNBJOF)
	{
		reskins[1].ChangeSpriteInfo(OJKJDNNBJOF);
	}

	private IEnumerator PCMLOBBDJFO()
	{
		return new ANNCCJLOLDJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ALFEMNIIHDO()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private IEnumerator NFBKDHANMAP()
	{
		return new ANNCCJLOLDJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KHKLJBJLBND()
	{
		KIJGAEMEHGL();
	}

	public void PKDHEIOBAEM()
	{
		((MonoBehaviour)this).StartCoroutine(MJMKGKHNPJB());
	}

	public void MGONCLCALLH()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private IEnumerator NCHLIBCKHMK()
	{
		float tiempo = 0f;
		DIFKLOCALFE = catNpc.transform.position;
		PLGBNELHDMJ = (0f - 2f * alturaMaxima) / (duracionSubida * duracionSubida);
		JGLCFPDGIFN = (0f - PLGBNELHDMJ) * duracionSubida;
		while (tiempo < duracionSubida)
		{
			float deltaTime = Time.deltaTime;
			tiempo += deltaTime;
			JGLCFPDGIFN += PLGBNELHDMJ * deltaTime;
			Transform transform = catNpc.transform;
			transform.position += new Vector3(0f, JGLCFPDGIFN * deltaTime, 0f);
			yield return null;
		}
		catNpc.transform.position = DIFKLOCALFE + new Vector3(0f, alturaMaxima, 0f);
	}

	public void NPJPJBBBOKP()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void ELNGHICFDON()
	{
		for (int i = 0; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		LACNIDGMKON();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void AIFHAEAFLHK()
	{
		for (int i = 1; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		FLHHGHJGPAD();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void DIBFJEGCJGA()
	{
		if (catIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = catIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].UpdateSprite(catIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].UpdateSprite(shadowIndex);
			}
		}
	}

	private IEnumerator LFNAIAFHCDF()
	{
		return new ANNCCJLOLDJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EOLLJKANPGH()
	{
		return new ANNCCJLOLDJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void NHCMKGEBOJG()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void PHPLJHDLLNG()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void EJBLHEGMJHA(SpriteInfo OJKJDNNBJOF)
	{
		reskins[1].ChangeSpriteInfo(OJKJDNNBJOF);
	}

	public void OLLNJGEKPCA()
	{
		for (int i = 0; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		IOLPFMKMLBH();
		for (int j = 1; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private IEnumerator LGCOHPHAGHO()
	{
		return new ANNCCJLOLDJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void GFIOAFNILKG()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void NFHJFGGOLPN()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void NJGCDCKKOAK()
	{
		if (catIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = catIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(catIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].UpdateSprite(shadowIndex);
			}
		}
	}

	private IEnumerator HGMOJHMPKNF()
	{
		float tiempo = 0f;
		DIFKLOCALFE = catNpc.transform.position;
		PLGBNELHDMJ = (0f - 2f * alturaMaxima) / (duracionSubida * duracionSubida);
		JGLCFPDGIFN = (0f - PLGBNELHDMJ) * duracionSubida;
		while (tiempo < duracionSubida)
		{
			float deltaTime = Time.deltaTime;
			tiempo += deltaTime;
			JGLCFPDGIFN += PLGBNELHDMJ * deltaTime;
			Transform transform = catNpc.transform;
			transform.position += new Vector3(0f, JGLCFPDGIFN * deltaTime, 0f);
			yield return null;
		}
		catNpc.transform.position = DIFKLOCALFE + new Vector3(0f, alturaMaxima, 0f);
	}

	public void LKLOLNFMAOG()
	{
		((MonoBehaviour)this).StartCoroutine(GMELNENLJHJ());
	}

	private IEnumerator FBKMBHHPGNC()
	{
		return new ANNCCJLOLDJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void AGNAEDGMKKN()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void OFFJDHLNHBF()
	{
		((MonoBehaviour)this).StartCoroutine(GMELNENLJHJ());
	}

	private IEnumerator MJMKGKHNPJB()
	{
		return new ANNCCJLOLDJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void FEGEMPIOJOD(SpriteInfo OJKJDNNBJOF)
	{
		reskins[0].ChangeSpriteInfo(OJKJDNNBJOF);
	}

	public void BBIMBNLHCIF()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private void NFPEFLHLIMM()
	{
		IIPGMPFHHIA();
	}

	private void NLEOMMPMBDF()
	{
		EIMPOHJFEAL();
	}

	public void OBNMFCBDKDB()
	{
		((MonoBehaviour)this).StartCoroutine(LGCOHPHAGHO());
	}

	public void MGKBFNJNEMN()
	{
		for (int i = 0; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		HDBEDEGEMCC();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void CIGEIPLDGDE()
	{
		((MonoBehaviour)this).StartCoroutine(OEEFOGOOLDK());
	}

	private void MCNIBEKFHGN()
	{
		if (catIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = catIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].KFHGLOFHCHH(catIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	public void DNANKCOCPIC(SpriteInfo OJKJDNNBJOF)
	{
		reskins[0].ChangeSpriteInfo(OJKJDNNBJOF);
	}

	private void ONLHEJPEMEC()
	{
		if (catIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = catIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].UpdateSprite(catIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].KFHGLOFHCHH(shadowIndex);
			}
		}
	}

	public void OPNANBAIHFB()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void ECLPOBGFELA()
	{
		EIMPOHJFEAL();
	}

	private IEnumerator DDADEDEGJFL()
	{
		float tiempo = 0f;
		DIFKLOCALFE = catNpc.transform.position;
		PLGBNELHDMJ = (0f - 2f * alturaMaxima) / (duracionSubida * duracionSubida);
		JGLCFPDGIFN = (0f - PLGBNELHDMJ) * duracionSubida;
		while (tiempo < duracionSubida)
		{
			float deltaTime = Time.deltaTime;
			tiempo += deltaTime;
			JGLCFPDGIFN += PLGBNELHDMJ * deltaTime;
			Transform transform = catNpc.transform;
			transform.position += new Vector3(0f, JGLCFPDGIFN * deltaTime, 0f);
			yield return null;
		}
		catNpc.transform.position = DIFKLOCALFE + new Vector3(0f, alturaMaxima, 0f);
	}

	private IEnumerator CGLBNDEMKKM()
	{
		return new ANNCCJLOLDJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void GNEPLHPJPKB()
	{
		for (int i = 1; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		GKBIHFPDDKN();
		for (int j = 1; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private IEnumerator JPHMJBDGGAO()
	{
		return new ANNCCJLOLDJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void CMLFLAJLGDH(SpriteInfo OJKJDNNBJOF)
	{
		reskins[1].ChangeSpriteInfo(OJKJDNNBJOF);
	}

	private void EKCDIPLBBOL()
	{
		NIOCLHJJGLH();
	}

	public void FGMJECNPEEF()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void LateUpdate()
	{
		PHGEBLFGPKM();
	}

	private void IOLPFMKMLBH()
	{
		if (catIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = catIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].KFHGLOFHCHH(catIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	public void FMBDIBNOEEA()
	{
		((MonoBehaviour)this).StartCoroutine(LJEHELMKFGE());
	}

	private void GPABCKFFLLM()
	{
		LACNIDGMKON();
	}

	private void CABBIPOHEFM()
	{
		ONLHEJPEMEC();
	}

	public void ChangeCatSkin(SpriteInfo OJKJDNNBJOF)
	{
		reskins[0].ChangeSpriteInfo(OJKJDNNBJOF);
	}

	public void IniciarMovimiento()
	{
		((MonoBehaviour)this).StartCoroutine(LNJJIDAIIHG());
	}

	private void KIPDGECFDFI()
	{
		HDBEDEGEMCC();
	}

	public void IKFLGBPNLGE(SpriteInfo OJKJDNNBJOF)
	{
		reskins[1].ChangeSpriteInfo(OJKJDNNBJOF);
	}

	public void OGFIMHDMJHA()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void HDBEDEGEMCC()
	{
		if (catIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = catIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(catIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].KFHGLOFHCHH(shadowIndex);
			}
		}
	}

	public void GDBAFCJDPIL()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void JJPAJNNJOKC()
	{
		((MonoBehaviour)this).StartCoroutine(LJEHELMKFGE());
	}

	public void DGBJLJOEDBA(SpriteInfo OJKJDNNBJOF)
	{
		reskins[1].ChangeSpriteInfo(OJKJDNNBJOF);
	}

	private void NEHIPNCNMCL()
	{
		if (catIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = catIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(catIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].UpdateSprite(shadowIndex);
			}
		}
	}

	public void HLIPFGOJFNF()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void OAGDJKMAKKC()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private IEnumerator PMCEBDOHBMH()
	{
		return new ANNCCJLOLDJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PFMHGKEDAPN()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private IEnumerator HFNAPIINMEE()
	{
		return new ANNCCJLOLDJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HOLBFJJHEPA()
	{
		for (int i = 1; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		HDBEDEGEMCC();
		for (int j = 1; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private IEnumerator IEMMIGJLEEK()
	{
		return new ANNCCJLOLDJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void KBNJNEJLCNG(SpriteInfo OJKJDNNBJOF)
	{
		reskins[1].ChangeSpriteInfo(OJKJDNNBJOF);
	}

	private IEnumerator MLLFKLMLCIO()
	{
		float tiempo = 0f;
		DIFKLOCALFE = catNpc.transform.position;
		PLGBNELHDMJ = (0f - 2f * alturaMaxima) / (duracionSubida * duracionSubida);
		JGLCFPDGIFN = (0f - PLGBNELHDMJ) * duracionSubida;
		while (tiempo < duracionSubida)
		{
			float deltaTime = Time.deltaTime;
			tiempo += deltaTime;
			JGLCFPDGIFN += PLGBNELHDMJ * deltaTime;
			Transform transform = catNpc.transform;
			transform.position += new Vector3(0f, JGLCFPDGIFN * deltaTime, 0f);
			yield return null;
		}
		catNpc.transform.position = DIFKLOCALFE + new Vector3(0f, alturaMaxima, 0f);
	}

	private IEnumerator JACLELCLKPH()
	{
		float tiempo = 0f;
		DIFKLOCALFE = catNpc.transform.position;
		PLGBNELHDMJ = (0f - 2f * alturaMaxima) / (duracionSubida * duracionSubida);
		JGLCFPDGIFN = (0f - PLGBNELHDMJ) * duracionSubida;
		while (tiempo < duracionSubida)
		{
			float deltaTime = Time.deltaTime;
			tiempo += deltaTime;
			JGLCFPDGIFN += PLGBNELHDMJ * deltaTime;
			Transform transform = catNpc.transform;
			transform.position += new Vector3(0f, JGLCFPDGIFN * deltaTime, 0f);
			yield return null;
		}
		catNpc.transform.position = DIFKLOCALFE + new Vector3(0f, alturaMaxima, 0f);
	}

	public void HDNIDCMNNAJ(SpriteInfo OJKJDNNBJOF)
	{
		reskins[0].ChangeSpriteInfo(OJKJDNNBJOF);
	}

	private void CEGIGMHMJOB()
	{
		NIOCLHJJGLH();
	}

	public void JNKHFGDEMAB()
	{
		for (int i = 0; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		NEHIPNCNMCL();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void ABOHMHGJFCC()
	{
		((MonoBehaviour)this).StartCoroutine(GPDNOEFBEOH());
	}

	public void EIOABHABHOI()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private IEnumerator GPDNOEFBEOH()
	{
		float tiempo = 0f;
		DIFKLOCALFE = catNpc.transform.position;
		PLGBNELHDMJ = (0f - 2f * alturaMaxima) / (duracionSubida * duracionSubida);
		JGLCFPDGIFN = (0f - PLGBNELHDMJ) * duracionSubida;
		while (tiempo < duracionSubida)
		{
			float deltaTime = Time.deltaTime;
			tiempo += deltaTime;
			JGLCFPDGIFN += PLGBNELHDMJ * deltaTime;
			Transform transform = catNpc.transform;
			transform.position += new Vector3(0f, JGLCFPDGIFN * deltaTime, 0f);
			yield return null;
		}
		catNpc.transform.position = DIFKLOCALFE + new Vector3(0f, alturaMaxima, 0f);
	}

	private void IFGLHEPFIKN()
	{
		KIJGAEMEHGL();
	}

	public void KAMJGLLCAFE()
	{
		((MonoBehaviour)this).StartCoroutine(EOLLJKANPGH());
	}

	public void GetAllReskins()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}
}
