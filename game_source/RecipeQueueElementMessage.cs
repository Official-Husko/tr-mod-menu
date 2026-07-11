using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

[Serializable]
public class RecipeQueueElementMessage : IOnlineSerializable
{
	[JsonProperty("rI")]
	public int recipeId;

	[JsonProperty("o")]
	public ItemInstanceWrapperMessage output;

	[JsonProperty("a")]
	public short amount;

	[JsonProperty("iU")]
	public IngredientUsedMessage[] ingredientsUsed;

	[JsonProperty("fU")]
	public int fuelUsed;

	public RecipeQueueElement OHGAGHGPHGK()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.GetRecipe(recipeId), new ItemInstanceAmount(output.HGFGODMGGPM(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].ABNGOCGAHKL());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement ELNNMFPDFJM()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.AJFFBGIOGOG(recipeId), new ItemInstanceAmount(output.EJOAGMLFPCK(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].BKLHGICNBAF());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement POELOOIHKAE()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.ILMHDDEBLCG(recipeId), new ItemInstanceAmount(output.DNAPLEAGBKJ(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].IBPNOFDBCJO());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement MOIDJMPGIJO()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.AJFFBGIOGOG(recipeId), new ItemInstanceAmount(output.GBPFODKFMAB(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].ABNGOCGAHKL());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement NCCPOJKHPJD()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.IFAAHCALEPD(recipeId), new ItemInstanceAmount(output.ANMBPDJLNFN(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].MONCIPBGGBO());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement IOBJOALIPBG()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.AJFFBGIOGOG(recipeId), new ItemInstanceAmount(output.BFKEPBIDNBM(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].ABNGOCGAHKL());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement CECIKIACHAF()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.GetRecipe(recipeId), new ItemInstanceAmount(output.OEACAPPALIP(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].ABNGOCGAHKL());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement NFKHBPCBNCP()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.AJFFBGIOGOG(recipeId), new ItemInstanceAmount(output.AAKOBEMJFBM(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].BHCNOCEOLCN());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement AOILBDJMPFJ()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.GetRecipe(recipeId), new ItemInstanceAmount(output.DLFOMGKFBND(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].CABAFLBMHOH());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement NOPNAGIGKND()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.AJFFBGIOGOG(recipeId), new ItemInstanceAmount(output.IHAALKCAPEE(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].CABAFLBMHOH());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement BNCOMPGPCGE()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.ILMHDDEBLCG(recipeId), new ItemInstanceAmount(output.BLGHALFGLBF(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].IBPNOFDBCJO());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement NCJBLHOFJKI()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.AJFFBGIOGOG(recipeId), new ItemInstanceAmount(output.ANMBPDJLNFN(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].NCJMBGIOPFO());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement LEJGIBDJBEA()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.AJFFBGIOGOG(recipeId), new ItemInstanceAmount(output.JFMDMECFCKL(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].NCJMBGIOPFO());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement AKBJMJLJOKC()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.GetRecipe(recipeId), new ItemInstanceAmount(output.ODLODIBLGIO(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].KPIIKNAPHJL());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement HFOFIJHBPFJ()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.ILMHDDEBLCG(recipeId), new ItemInstanceAmount(output.CGLNBKOHBIH(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].BKLHGICNBAF());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement BLPLFNOMKAL()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.ILMHDDEBLCG(recipeId), new ItemInstanceAmount(output.FDADKINGADJ(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].CABAFLBMHOH());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement OBNDGGMIHFF()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.ILMHDDEBLCG(recipeId), new ItemInstanceAmount(output.DLFOMGKFBND(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].OLPCMJPOEOA());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement NGOMJBBONLL()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.GetRecipe(recipeId), new ItemInstanceAmount(output.FKCEFMOLIAB(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].IBPNOFDBCJO());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement KNHENIGJHKN()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.ILMHDDEBLCG(recipeId), new ItemInstanceAmount(output.ANMBPDJLNFN(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].BHCNOCEOLCN());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement JJGMGDFNMFG()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.IFAAHCALEPD(recipeId), new ItemInstanceAmount(output.BIIBOFGOFME(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].ADKEFGCFOBI());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement AFLIDCDOLEP()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.GetRecipe(recipeId), new ItemInstanceAmount(output.PLAALMCLGMO(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].MONCIPBGGBO());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement PKMPAKJPKFK()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.ILMHDDEBLCG(recipeId), new ItemInstanceAmount(output.LEIKEJOAAKF(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].CABAFLBMHOH());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement CPBGMMJODMH()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.AJFFBGIOGOG(recipeId), new ItemInstanceAmount(output.LDFNHFAOHLB(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].BKLHGICNBAF());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement BADBCFFBIGP()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.IFAAHCALEPD(recipeId), new ItemInstanceAmount(output.MJNLGNACHEL(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].BKLHGICNBAF());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement MHHAELDJHFF()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.GetRecipe(recipeId), new ItemInstanceAmount(output.MEBJICJFALH(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].MONCIPBGGBO());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement FDNABEBPAFD()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.IFAAHCALEPD(recipeId), new ItemInstanceAmount(output.DLFOMGKFBND(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].BKLHGICNBAF());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement MPILMGJLLFA()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.AJFFBGIOGOG(recipeId), new ItemInstanceAmount(output.EMKKJLBBANJ(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].BKLHGICNBAF());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement HLOFKKFGCLC()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.GetRecipe(recipeId), new ItemInstanceAmount(output.AMOEODNHNCB(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].BKLHGICNBAF());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement CJLCPBFPDDM()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.ILMHDDEBLCG(recipeId), new ItemInstanceAmount(output.IHBKMGFGGNE(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].BKLHGICNBAF());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement JHIGNFLPBJE()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.GetRecipe(recipeId), new ItemInstanceAmount(output.LEIKEJOAAKF(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].MONCIPBGGBO());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement CHODDHLEFNP()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.AJFFBGIOGOG(recipeId), new ItemInstanceAmount(output.PLAALMCLGMO(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].MONCIPBGGBO());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement PJEFGHPCABB()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.GetRecipe(recipeId), new ItemInstanceAmount(output.EMFCKLAFIED(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].ABNGOCGAHKL());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement HMBPHGEOFPP()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.GetRecipe(recipeId), new ItemInstanceAmount(output.JFMDMECFCKL(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].MONCIPBGGBO());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement LCLFBGDKHOL()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.IFAAHCALEPD(recipeId), new ItemInstanceAmount(output.JJFKOPICIHJ(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].NCJMBGIOPFO());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement EKFFHJGNLPH()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.AJFFBGIOGOG(recipeId), new ItemInstanceAmount(output.ECAEFDNJMDD(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].BKLHGICNBAF());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement NLEMJODINPI()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.IFAAHCALEPD(recipeId), new ItemInstanceAmount(output.JJACMHPLEPO(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].IBPNOFDBCJO());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement KACDFCDPOIE()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.ILMHDDEBLCG(recipeId), new ItemInstanceAmount(output.IMEMGKABHOM(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].IBPNOFDBCJO());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement IJOAJJBJKAL()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.AJFFBGIOGOG(recipeId), new ItemInstanceAmount(output.BLGHALFGLBF(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].OLPCMJPOEOA());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement MHOINBJPNHF()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.ILMHDDEBLCG(recipeId), new ItemInstanceAmount(output.FDADKINGADJ(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].MONCIPBGGBO());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement ODJLPPDKBND()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.ILMHDDEBLCG(recipeId), new ItemInstanceAmount(output.LEIKEJOAAKF(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].IBPNOFDBCJO());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement LGNFJMOCOKL()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.GetRecipe(recipeId), new ItemInstanceAmount(output.NJKMGGPONFC(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].NCJMBGIOPFO());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement OJIGHLHOOBF()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.IFAAHCALEPD(recipeId), new ItemInstanceAmount(output.LNELHNKCFBL(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].JDFLKBMOIDC());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement HKLNLLBHHDF()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.ILMHDDEBLCG(recipeId), new ItemInstanceAmount(output.ANMBPDJLNFN(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].MONCIPBGGBO());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElementMessage(RecipeQueueElement FFNGGJENDKI)
	{
		recipeId = FFNGGJENDKI.recipe.id;
		output = new ItemInstanceWrapperMessage(FFNGGJENDKI.output.itemInstance);
		amount = (short)FFNGGJENDKI.output.amount;
		if (FFNGGJENDKI.ingredientsUsed != null)
		{
			ingredientsUsed = FFNGGJENDKI.ingredientsUsed.Select((IngredientUsedInfo iu) => new IngredientUsedMessage(iu)).ToArray();
		}
		else
		{
			ingredientsUsed = new IngredientUsedMessage[0];
		}
		fuelUsed = FFNGGJENDKI.fuelUsed;
	}

	public RecipeQueueElement JNAMDKPNPKK()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.GetRecipe(recipeId), new ItemInstanceAmount(output.DJNIFPEOAEP(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].CABAFLBMHOH());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement GCBIEMLLEGG()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.AJFFBGIOGOG(recipeId), new ItemInstanceAmount(output.PLAALMCLGMO(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].ABNGOCGAHKL());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement APIMNILJGFJ()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.GetRecipe(recipeId), new ItemInstanceAmount(output.HGFGODMGGPM(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].MONCIPBGGBO());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement KIJBBEAHEDG()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.ILMHDDEBLCG(recipeId), new ItemInstanceAmount(output.DJNIFPEOAEP(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 1; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].ADKEFGCFOBI());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement FBHFCGOCLJF()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.ILMHDDEBLCG(recipeId), new ItemInstanceAmount(output.OKLPOAAEKBJ(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i += 0)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].BHCNOCEOLCN());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}

	public RecipeQueueElement MMANNOMOCMP()
	{
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(RecipeDatabaseAccessor.GetRecipe(recipeId), new ItemInstanceAmount(output.ANMBPDJLNFN(), amount));
		if (ingredientsUsed != null)
		{
			recipeQueueElement.ingredientsUsed = new List<IngredientUsedInfo>();
			for (int i = 0; i < ingredientsUsed.Length; i++)
			{
				recipeQueueElement.ingredientsUsed.Add(ingredientsUsed[i].NCJMBGIOPFO());
			}
		}
		recipeQueueElement.fuelUsed = fuelUsed;
		return recipeQueueElement;
	}
}
