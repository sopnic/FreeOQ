using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace FreeQuant
{
  public class Reference
  {
    protected AssemblyName assemblyName;
    protected ReferenceType referenceType;
    protected bool enabled;
    protected bool valid;
    private Configuration YwFLqei13;

    public AssemblyName AssemblyName
    {
      get
      {
        return null;
      }
    }

    public ReferenceType ReferenceType
    {
      get
      {
				return referenceType;
      }
    }

    [Browsable(false)]
    public bool Enabled
    {
      get
      {
        return true;
      }
      set
      {
      }
    }

    public bool Valid
    {
      get
      {
        return true;
      }
    }

    public virtual string Path
    {
      get
      {
        return null;
      }
    }

    
    protected Reference(ReferenceType referenceType, bool enabled)
    {
    }

		    internal void sq01wopyU(Configuration value)
    {
    }
  }
}
