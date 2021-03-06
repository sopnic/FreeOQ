using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXBidDescriptorsGroup : FIXGroup
  {
    [FIXField("399", EFieldOption.Optional)]
    public int BidDescriptorType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(399).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(399, value);
      }
    }

    [FIXField("400", EFieldOption.Optional)]
    public string BidDescriptor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(400).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(400, value);
      }
    }

    [FIXField("401", EFieldOption.Optional)]
    public int SideValueInd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(401).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(401, value);
      }
    }

    [FIXField("404", EFieldOption.Optional)]
    public double LiquidityValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(404).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(404, value);
      }
    }

    [FIXField("441", EFieldOption.Optional)]
    public int LiquidityNumSecurities
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(441).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(441, value);
      }
    }

    [FIXField("402", EFieldOption.Optional)]
    public double LiquidityPctLow
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(402).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(402, value);
      }
    }

    [FIXField("403", EFieldOption.Optional)]
    public double LiquidityPctHigh
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(403).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(403, value);
      }
    }

    [FIXField("405", EFieldOption.Optional)]
    public double EFPTrackingError
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(405).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(405, value);
      }
    }

    [FIXField("406", EFieldOption.Optional)]
    public double FairValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(406).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(406, value);
      }
    }

    [FIXField("407", EFieldOption.Optional)]
    public double OutsideIndexPct
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(407).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(407, value);
      }
    }

    [FIXField("408", EFieldOption.Optional)]
    public double ValueOfFutures
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(408).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(408, value);
      }
    }


  }
}
