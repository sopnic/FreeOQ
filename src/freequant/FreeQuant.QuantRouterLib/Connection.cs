using FreeQuant.QuantRouterLib.Messages;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace FreeQuant.QuantRouterLib
{
  public abstract class Connection : IConnection
  {
    private ManualResetEventSlim pr5mw3rRZ;

    public string ConnectionString {  get;  set; }

    public bool RaiseEvents
    {
       get
      {
        return this.pr5mw3rRZ.IsSet;
      }
       set
      {
        if (value)
          this.pr5mw3rRZ.Set();
        else
          this.pr5mw3rRZ.Reset();
      }
    }

    public event EventHandler Closed;

    public event EventHandler<ExceptionEventArgs> Error;

    public event EventHandler<MessageEventArgs> MessageReceived;

	protected Connection() : base()
    {
      this.pr5mw3rRZ = new ManualResetEventSlim(false);
    }

    public abstract void Open();

    public abstract void Close();

    public abstract void Send(Message message);

    public abstract void Send(Message[] message);

    protected void OnClosed()
    {
      this.pr5mw3rRZ.Wait();
      if (this.NLrcRQrxc == null)
        return;
      this.NLrcRQrxc((object) this, EventArgs.Empty);
    }

    
    protected void OnError(Exception exception)
    {
      this.pr5mw3rRZ.Wait();
      if (this.qCL1jQUQt == null)
        return;
      this.qCL1jQUQt((object) this, new ExceptionEventArgs(exception));
    }

    
    protected void OnMessageReceived(Message message)
    {
      this.pr5mw3rRZ.Wait();
      if (this.pJeLILmmI == null)
        return;
      this.pJeLILmmI((object) this, new MessageEventArgs(message));
    }

    
    protected Message CreateMessage(int type)
    {
      Message message;
      switch (type)
      {
        case 1100:
          message = (Message) new MsgCommand();
          break;
        case 1101:
          message = (Message) new MsgReport();
          break;
        case 1102:
          message = (Message) new MsgOrderCancelReject();
          break;
        case 2001:
          message = (Message) new MsgBrokerInfo();
          break;
        case 1:
          message = (Message) new MsgLogon();
          break;
        case 2:
          message = (Message) new MsgLogonStatus();
          break;
        case 3:
          message = (Message) new MsgHeartbeat();
          break;
        case 10:
          message = (Message) new MsgSubscribe();
          break;
        case 11:
          message = (Message) new MsgUnsubscribe();
          break;
        case 12:
          message = (Message) new MsgProviderError();
          break;
        case 13:
          message = (Message) new MsgSubscriptionStatus();
          break;
        case 1000:
          message = (Message) new MsgTick();
          break;
        case 1001:
          message = (Message) new MsgLevel2();
          break;
        default:
          message = (Message) new MsgUnknown(type);
          break;
      }
      return message;
    }
  }
}
