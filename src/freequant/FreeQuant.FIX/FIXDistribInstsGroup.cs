﻿// Type: SmartQuant.FIX.FIXDistribInstsGroup
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXDistribInstsGroup : FIXGroup
  {
    [FIXField("477", EFieldOption.Optional)]
    public int DistribPaymentMethod
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(477).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(477, value);
      }
    }

    [FIXField("512", EFieldOption.Optional)]
    public double DistribPercentage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(512).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(512, value);
      }
    }

    [FIXField("478", EFieldOption.Optional)]
    public double CashDistribCurr
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(478).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(478, value);
      }
    }

    [FIXField("498", EFieldOption.Optional)]
    public string CashDistribAgentName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(498).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(498, value);
      }
    }

    [FIXField("499", EFieldOption.Optional)]
    public string CashDistribAgentCode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(499).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(499, value);
      }
    }

    [FIXField("500", EFieldOption.Optional)]
    public string CashDistribAgentAcctNumber
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(500).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(500, value);
      }
    }

    [FIXField("501", EFieldOption.Optional)]
    public string CashDistribPayRef
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(501).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(501, value);
      }
    }

    [FIXField("502", EFieldOption.Optional)]
    public string CashDistribAgentAcctName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(502).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(502, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXDistribInstsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}