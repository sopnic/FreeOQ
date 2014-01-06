﻿// Type: SmartQuant.Instruments.InstrumentDbServer
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using SmartQuant.FIX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using VFUvY5knK01pUIalDo;

namespace SmartQuant.Instruments
{
  public class InstrumentDbServer : IInstrumentServer
  {
    private IDbConnection FUwdOuHiol;
    private Dictionary<int, Type> aKpdKBGUfP;
    private Dictionary<Type, int> cVFd9nJe3b;
    private Dictionary<int, Type> BuYdCExFpF;
    private Dictionary<Type, int> UXKdMsMyXN;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InstrumentDbServer()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.aKpdKBGUfP = new Dictionary<int, Type>();
      this.cVFd9nJe3b = new Dictionary<Type, int>();
      this.BuYdCExFpF = new Dictionary<int, Type>();
      this.UXKdMsMyXN = new Dictionary<Type, int>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Open(Type connectionType, string connectionString)
    {
      this.FUwdOuHiol = (IDbConnection) Activator.CreateInstance(connectionType);
      this.FUwdOuHiol.ConnectionString = connectionString;
      this.FUwdOuHiol.Open();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateDataBase()
    {
      throw new InvalidOperationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(11312));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Save(Instrument instrument)
    {
      if (instrument.Id == -1)
      {
        int num1 = this.nHGd3u0DoR(instrument);
        int num2 = this.tyvdN5fb3r(instrument.Pricer);
        IDbCommand command1 = this.FUwdOuHiol.CreateCommand();
        command1.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(11392);
        FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(11628), DbType.Int32, (object) num1);
        FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(11666), DbType.Int32, (object) num2);
        FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(11696), DbType.String, (object) instrument.Symbol);
        command1.ExecuteNonQuery();
        command1.Dispose();
        IDbCommand command2 = this.FUwdOuHiol.CreateCommand();
        command2.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(11714);
        instrument.Id = Convert.ToInt32(command2.ExecuteScalar());
        command2.Dispose();
      }
      else
      {
        IDbCommand command1 = this.FUwdOuHiol.CreateCommand();
        command1.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(11752);
        FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(11862), DbType.Int32, (object) instrument.Id);
        command1.ExecuteNonQuery();
        command1.Dispose();
        IDbCommand command2 = this.FUwdOuHiol.CreateCommand();
        command2.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(11882);
        FIXDbServer.SetCommandParameter(command2, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(11970), DbType.Int32, (object) instrument.Id);
        command2.ExecuteNonQuery();
        command2.Dispose();
        IDbCommand command3 = this.FUwdOuHiol.CreateCommand();
        command3.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(11992);
        FIXDbServer.SetCommandParameter(command3, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(12094), DbType.Int32, (object) instrument.Id);
        command3.ExecuteNonQuery();
        command3.Dispose();
        IDbCommand command4 = this.FUwdOuHiol.CreateCommand();
        command4.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(12116);
        FIXDbServer.SetCommandParameter(command4, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(12210), DbType.Int32, (object) instrument.Id);
        command4.ExecuteNonQuery();
        command4.Dispose();
        int num = this.tyvdN5fb3r(instrument.Pricer);
        IDbCommand command5 = this.FUwdOuHiol.CreateCommand();
        command5.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(12232);
        FIXDbServer.SetCommandParameter(command5, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(12364), DbType.Int32, (object) num);
        FIXDbServer.SetCommandParameter(command5, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(12394), DbType.Int32, (object) instrument.Id);
        command5.ExecuteNonQuery();
        command5.Dispose();
      }
      FIXDbServer.SaveFIXGroup(this.FUwdOuHiol, (FIXGroup) instrument, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(12404), instrument.Id);
      foreach (Leg leg in (FIXGroupList) instrument.Legs)
      {
        IDbCommand command1 = this.FUwdOuHiol.CreateCommand();
        command1.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(12442);
        FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(12596), DbType.Int32, (object) instrument.Id);
        FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(12618), DbType.Int32, (object) leg.Instrument.Id);
        command1.ExecuteNonQuery();
        command1.Dispose();
        IDbCommand command2 = this.FUwdOuHiol.CreateCommand();
        command2.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(12648);
        leg.Id = Convert.ToInt32(command2.ExecuteScalar());
        command2.Dispose();
        FIXDbServer.SaveFIXGroup(this.FUwdOuHiol, (FIXGroup) leg, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(12686), leg.Id);
      }
      foreach (Underlying underlying in (FIXGroupList) instrument.Underlyings)
      {
        IDbCommand command1 = this.FUwdOuHiol.CreateCommand();
        command1.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(12710);
        FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(12880), DbType.Int32, (object) instrument.Id);
        FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(12902), DbType.Int32, (object) underlying.Instrument.Id);
        command1.ExecuteNonQuery();
        command1.Dispose();
        IDbCommand command2 = this.FUwdOuHiol.CreateCommand();
        command2.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(12932);
        underlying.Id = Convert.ToInt32(command2.ExecuteScalar());
        command2.Dispose();
        FIXDbServer.SaveFIXGroup(this.FUwdOuHiol, (FIXGroup) underlying, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(12970), underlying.Id);
      }
      foreach (FIXSecurityAltIDGroup securityAltIdGroup in (FIXGroupList) instrument.SecurityAltIDGroup)
      {
        IDbCommand command1 = this.FUwdOuHiol.CreateCommand();
        command1.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13008);
        FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13112), DbType.Int32, (object) instrument.Id);
        command1.ExecuteNonQuery();
        command1.Dispose();
        IDbCommand command2 = this.FUwdOuHiol.CreateCommand();
        command2.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13134);
        securityAltIdGroup.Id = Convert.ToInt32(command2.ExecuteScalar());
        command2.Dispose();
        FIXDbServer.SaveFIXGroup(this.FUwdOuHiol, (FIXGroup) securityAltIdGroup, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13172), securityAltIdGroup.Id);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(Instrument instrument)
    {
      IDbCommand command = this.FUwdOuHiol.CreateCommand();
      command.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13202);
      FIXDbServer.SetCommandParameter(command, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13280), DbType.Int32, (object) instrument.Id);
      command.ExecuteNonQuery();
      command.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Close()
    {
      this.FUwdOuHiol.Close();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InstrumentList Load()
    {
      IDbCommand command1 = this.FUwdOuHiol.CreateCommand();
      command1.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13290);
      IDataReader dataReader1 = command1.ExecuteReader();
      while (dataReader1.Read())
      {
        int int32 = dataReader1.GetInt32(0);
        Type type = Type.GetType(dataReader1.GetString(1));
        this.aKpdKBGUfP.Add(int32, type);
        this.cVFd9nJe3b.Add(type, int32);
      }
      dataReader1.Close();
      command1.Dispose();
      IDbCommand command2 = this.FUwdOuHiol.CreateCommand();
      command2.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13354);
      IDataReader dataReader2 = command2.ExecuteReader();
      while (dataReader2.Read())
      {
        int int32 = dataReader2.GetInt32(0);
        Type type = Type.GetType(dataReader2.GetString(1));
        this.BuYdCExFpF.Add(int32, type);
        this.UXKdMsMyXN.Add(type, int32);
      }
      dataReader2.Close();
      command2.Dispose();
      InstrumentList instrumentList = new InstrumentList();
      IDbCommand command3 = this.FUwdOuHiol.CreateCommand();
      command3.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13410);
      IDataReader dataReader3 = command3.ExecuteReader();
      while (dataReader3.Read())
      {
        int int32 = dataReader3.GetInt32(0);
        Type type1 = this.aKpdKBGUfP[dataReader3.GetInt32(1)];
        Type type2 = this.BuYdCExFpF[dataReader3.GetInt32(2)];
        string @string = dataReader3.GetString(3);
        Instrument instrument = Activator.CreateInstance(type1, true) as Instrument;
        IPricer pricer = Activator.CreateInstance(type2) as IPricer;
        instrument.Symbol = @string;
        instrument.Id = int32;
        instrument.Pricer = pricer;
        if (instrumentList[@string] == null)
          instrumentList.Add(instrument);
      }
      dataReader3.Close();
      command3.Dispose();
      FIXDbServer.LoadFIXGroups(this.FUwdOuHiol, (FIXGroupList) instrumentList, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13464));
      LegList legList = new LegList();
      IDbCommand command4 = this.FUwdOuHiol.CreateCommand();
      command4.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13502);
      IDataReader dataReader4 = command4.ExecuteReader();
      while (dataReader4.Read())
      {
        int int32_1 = dataReader4.GetInt32(0);
        int int32_2 = dataReader4.GetInt32(1);
        int int32_3 = dataReader4.GetInt32(2);
        Leg leg = new Leg(instrumentList.GetById(int32_3));
        leg.Id = int32_1;
        instrumentList.GetById(int32_2).Legs.Add((FIXGroup) leg);
        legList.Add((FIXGroup) leg);
      }
      dataReader4.Close();
      command4.Dispose();
      FIXDbServer.LoadFIXGroups(this.FUwdOuHiol, (FIXGroupList) legList, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13542));
      UnderlyingList underlyingList = new UnderlyingList();
      IDbCommand command5 = this.FUwdOuHiol.CreateCommand();
      command5.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13566);
      IDataReader dataReader5 = command5.ExecuteReader();
      while (dataReader5.Read())
      {
        int int32_1 = dataReader5.GetInt32(0);
        int int32_2 = dataReader5.GetInt32(1);
        int int32_3 = dataReader5.GetInt32(2);
        Underlying underlying = new Underlying(instrumentList.GetById(int32_3));
        underlying.Id = int32_1;
        instrumentList.GetById(int32_2).Underlyings.Add((FIXGroup) underlying);
        underlyingList.Add((FIXGroup) underlying);
      }
      dataReader5.Close();
      command5.Dispose();
      FIXDbServer.LoadFIXGroups(this.FUwdOuHiol, (FIXGroupList) underlyingList, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13620));
      FIXSecurityAltIDGroupList securityAltIdGroupList = new FIXSecurityAltIDGroupList();
      IDbCommand command6 = this.FUwdOuHiol.CreateCommand();
      command6.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13658);
      IDataReader dataReader6 = command6.ExecuteReader();
      while (dataReader6.Read())
      {
        int int32_1 = dataReader6.GetInt32(0);
        int int32_2 = dataReader6.GetInt32(1);
        FIXSecurityAltIDGroup securityAltIdGroup = new FIXSecurityAltIDGroup();
        securityAltIdGroup.Id = int32_1;
        instrumentList.GetById(int32_2).SecurityAltIDGroup.Add((FIXGroup) securityAltIdGroup);
        securityAltIdGroupList.Add((FIXGroup) securityAltIdGroup);
      }
      dataReader6.Close();
      command6.Dispose();
      FIXDbServer.LoadFIXGroups(this.FUwdOuHiol, (FIXGroupList) securityAltIdGroupList, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13704));
      return instrumentList;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int nHGd3u0DoR([In] Instrument obj0)
    {
      Type type = obj0.GetType();
      if (!this.cVFd9nJe3b.ContainsKey(type))
      {
        string str = string.Format(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13734), (object) type.FullName, (object) type.Assembly.GetName().Name);
        IDbCommand command1 = this.FUwdOuHiol.CreateCommand();
        command1.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13754);
        FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13860), DbType.String, (object) str);
        command1.ExecuteNonQuery();
        command1.Dispose();
        IDbCommand command2 = this.FUwdOuHiol.CreateCommand();
        command2.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13874);
        int key = Convert.ToInt32(command2.ExecuteScalar());
        command2.Dispose();
        this.aKpdKBGUfP.Add(key, type);
        this.cVFd9nJe3b.Add(type, key);
      }
      return this.cVFd9nJe3b[type];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int tyvdN5fb3r([In] IPricer obj0)
    {
      Type type = obj0.GetType();
      if (!this.UXKdMsMyXN.ContainsKey(type))
      {
        string str = string.Format(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13912), (object) type.FullName, (object) type.Assembly.GetName().Name);
        IDbCommand command1 = this.FUwdOuHiol.CreateCommand();
        command1.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(13932);
        FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(14028), DbType.String, (object) str);
        command1.ExecuteNonQuery();
        command1.Dispose();
        IDbCommand command2 = this.FUwdOuHiol.CreateCommand();
        command2.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(14042);
        int key = Convert.ToInt32(command2.ExecuteScalar());
        command2.Dispose();
        this.BuYdCExFpF.Add(key, type);
        this.UXKdMsMyXN.Add(type, key);
      }
      return this.UXKdMsMyXN[type];
    }
  }
}