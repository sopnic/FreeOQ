﻿// Type: SmartQuant.QuantRouterLib.Data.OrderCancelReject
// Assembly: SmartQuant.QuantRouterLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: FDF277D6-C8FB-45C3-A0BD-1C1035F3B027
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantRouterLib.dll

using NI8YCE6tH4BIeIEcEy;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.QuantRouterLib.Data
{
  public class OrderCancelReject
  {
    public int CommandId { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string Text { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string ClOrdID { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string OrigClOrdID { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string OrderID { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public int CxlRejReason { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public char CxlRejResponseTo { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public char OrdStatus { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public DateTime TransactTime { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrderCancelReject()
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Text = string.Empty;
      this.ClOrdID = string.Empty;
      this.OrigClOrdID = string.Empty;
      this.OrderID = string.Empty;
      this.CxlRejResponseTo = char.MinValue;
      this.OrdStatus = char.MinValue;
    }
  }
}