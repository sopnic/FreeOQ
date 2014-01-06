﻿// Type: SmartQuant.Providers.InstrumentProviderList
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using dW79p7NPlS6ZxObcx3;
using System.Runtime.CompilerServices;

namespace SmartQuant.Providers
{
  public class InstrumentProviderList : ProviderList
  {
    public IInstrumentProvider this[string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return base[name] as IInstrumentProvider;
      }
    }

    public IInstrumentProvider this[byte id]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return base[id] as IInstrumentProvider;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal InstrumentProviderList()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}