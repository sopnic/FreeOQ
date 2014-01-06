﻿// Type: SmartQuant.Optimization.OptimizationParameterAttribute
// Assembly: SmartQuant.Optimization, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 1C417731-0514-4808-9329-6B635F19637E
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Optimization.dll

using E32I8CMPFnk6XwkgnC;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Optimization
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
  public class OptimizationParameterAttribute : Attribute
  {
    private double LdRDXSRAOu;
    private double FESDpQtr6q;
    private double DadDi5QRSS;

    public double LowerBound
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.LdRDXSRAOu;
      }
    }

    public double UpperBound
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.FESDpQtr6q;
      }
    }

    public double Step
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.DadDi5QRSS;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OptimizationParameterAttribute(double lowerBound, double upperBound, double step)
    {
      C7bjlF4Ph208kGmVJO.IHdBTbCzDaa6o();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.LdRDXSRAOu = lowerBound;
      this.FESDpQtr6q = upperBound;
      this.DadDi5QRSS = step;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OptimizationParameterAttribute(double lowerBound, double upperBound)
    {
      C7bjlF4Ph208kGmVJO.IHdBTbCzDaa6o();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.LdRDXSRAOu = lowerBound;
      this.FESDpQtr6q = upperBound;
      this.DadDi5QRSS = 1.0;
    }
  }
}