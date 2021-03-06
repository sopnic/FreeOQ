using FreeQuant.Charting;
using System;
using System.Collections;
using System.Drawing;

namespace FreeQuant.Neural
{
  [Serializable]
  public class TPerceptron : TNeuralNetwork
  {
    private int kB5uny9D9;
    private int HnCyxyTcM;
    private ArrayList rCHgEckPw;
    private double[] cGqCj2YUM;
    private TNeuralDataSet tD5M1LlFx;
    private TNeuralDataSet WKl1lduPx;
    private EActivationMode wAeTg5Tjg;
    private Graph V8laR9xb7;
    private Graph XOwvCEen2;
    private double wm8s050QY;
    private double MSg9cpEpW;
    private bool x1tDaZE2v;

    public Graph TrainingErrorGraph
    {
      get
      {
        return this.V8laR9xb7;
      }
    }

    public Graph ValidationErrorGraph
    {
      get
      {
        return this.XOwvCEen2;
      }
    }

   
		public TPerceptron():base()
    {
      this.kB5uny9D9 = 0;
      this.wAeTg5Tjg = EActivationMode.Approximation;
      this.tD5M1LlFx = (TNeuralDataSet) null;
      this.WKl1lduPx = (TNeuralDataSet) null;
    }

   
    public TPerceptron(string Name, string Title, int NInput, int NHidden, int NOutput, EActivationMode Mode)
			:base(Name, Title){
      this.fNInput = NInput;
      this.kB5uny9D9 = NHidden;
      this.fNOutput = NOutput;
      this.wAeTg5Tjg = Mode;
      this.tD5M1LlFx = (TNeuralDataSet) null;
      this.WKl1lduPx = (TNeuralDataSet) null;
      this.Configure();
    }

   
    public TPerceptron(string Name, string Title, TNeuralDataSet TrainingSet, int NHidden, EActivationMode Mode)
			: base(Name, Title) {

      this.tD5M1LlFx = TrainingSet;
      this.WKl1lduPx = (TNeuralDataSet) null;
      this.fNInput = TrainingSet.NInput;
      this.kB5uny9D9 = NHidden;
      this.fNOutput = TrainingSet.NOutput;
      this.wAeTg5Tjg = Mode;
      this.Configure();
    }

   
    public TPerceptron(string Name, string Title, TNeuralDataSet TrainingSet, TNeuralDataSet ValidationSet, int NHidden, EActivationMode Mode)
			: base(Name, Title) {
      this.tD5M1LlFx = TrainingSet;
      this.WKl1lduPx = ValidationSet;
      this.fNInput = TrainingSet.NInput;
      this.kB5uny9D9 = NHidden;
      this.fNOutput = TrainingSet.NOutput;
      this.wAeTg5Tjg = Mode;
      this.Configure();
    }

   
    public void Configure()
    {
      this.fInputLayer = (TNeuralLayer) new TInputNeuralLayer(this.fNInput, true);
      TNeuralLayer Layer = (TNeuralLayer) new THiddenNeuralLayer(this.kB5uny9D9);
      Layer.Connect(this.fInputLayer);
      this.rCHgEckPw = new ArrayList();
      this.HnCyxyTcM = 1;
      this.rCHgEckPw.Add((object) Layer);
      this.fOutputLayer = (TNeuralLayer) new TOutputNeuralLayer(this.fNOutput, this.wAeTg5Tjg);
      this.fOutputLayer.Connect(Layer);
      this.fOutput = new double[this.fNOutput];
      this.cGqCj2YUM = new double[this.fNOutput];
      this.fMaxNX = Math.Max(this.fNInput + 1, this.fNOutput);
      this.fMaxNX = Math.Max(this.fMaxNX, this.kB5uny9D9 + 1);
      this.fMaxNY = 3;
      this.fNPattern = 0;
      this.wm8s050QY = 0.0;
      this.MSg9cpEpW = 0.0;
      this.V8laR9xb7 = new Graph();
			this.V8laR9xb7.Title = "title";
      this.V8laR9xb7.LineColor = Color.Red;
      this.XOwvCEen2 = new Graph();
			this.XOwvCEen2.Title = "title";
      this.XOwvCEen2.LineColor = Color.Blue;
      this.x1tDaZE2v = false;
    }

   
    public void ReConfigure(int NHidden)
    {
      this.fNInput = this.tD5M1LlFx.NInput;
      this.kB5uny9D9 = NHidden;
      this.fNOutput = this.tD5M1LlFx.NOutput;
      this.Configure();
    }

   
    public void ResetError()
    {
      this.V8laR9xb7 = new Graph();
			this.V8laR9xb7.Title = "title";
      this.V8laR9xb7.LineColor = Color.Red;
      this.XOwvCEen2 = new Graph();
			this.XOwvCEen2.Title = "title";
      this.XOwvCEen2.LineColor = Color.Blue;
    }
   
    public override void Reset()
    {
      TNeuralNetwork.Network.Reset();
      this.ResetError();
    }

    public void AddHiddenLayer(int NHidden)
    {
      TNeuralLayer Layer1 = (TNeuralLayer) this.rCHgEckPw[this.rCHgEckPw.Count - 1];
      TNeuralLayer Layer2 = (TNeuralLayer) new THiddenNeuralLayer(NHidden);
      this.fOutputLayer.Disconnect(Layer1);
      this.fOutputLayer.Connect(Layer2);
      Layer2.Connect(Layer1);
      this.rCHgEckPw.Add((object) Layer2);
      ++this.HnCyxyTcM;
      this.kB5uny9D9 += NHidden;
      this.fMaxNX = Math.Max(this.fMaxNX, NHidden + 1);
      TPerceptron tperceptron = this;
      int num = tperceptron.fMaxNY + 1;
      tperceptron.fMaxNY = num;
    }

   
    public int GetNHidden(int i)
    {
      if (i != 0)
        return ((TNeuralLayer) this.rCHgEckPw[i - 1]).GetNNeuron() - 1;
      else
        return this.kB5uny9D9;
    }

   
    public void FeedForward()
    {
      ((TInputNeuralLayer) this.fInputLayer).FeedInput(this.fInput);
      this.fInputLayer.ProcessInput();
      for (int index = 0; index < this.HnCyxyTcM; ++index)
        ((TNeuralLayer) this.rCHgEckPw[index]).ProcessInput();
      this.fOutputLayer.ProcessInput();
      this.fOutput = ((TOutputNeuralLayer) this.fOutputLayer).GetOutput();
    }

   
    public void FeedBackward()
    {
      ((TOutputNeuralLayer) this.fOutputLayer).FeedError(this.cGqCj2YUM);
      this.fOutputLayer.ProcessError();
      for (int index = this.HnCyxyTcM - 1; index >= 0; --index)
        ((TNeuralLayer) this.rCHgEckPw[index]).ProcessError();
    }

   
    public void ComputeError()
    {
      for (int index = 0; index < this.fNOutput; ++index)
        this.cGqCj2YUM[index] = this.fTarget[index] - this.fOutput[index];
    }

   
    public override void Update(int Param)
    {
      base.Update(0);
      this.fOutputLayer.Update();
      for (int index = this.HnCyxyTcM - 1; index >= 0; --index)
        ((TNeuralLayer) this.rCHgEckPw[index]).Update();
    }

   
    public void TrainPerceptron()
    {
      this.x1tDaZE2v = false;
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
label_1:
      do
      {
        do
        {
          for (int index = 0; index < this.fNBatch; ++index)
          {
            TNeuralData data = this.tD5M1LlFx.GetData();
            this.fInput = data.Input;
            this.fTarget = data.Output;
            this.FeedForward();
            this.ComputeError();
            this.FeedBackward();
          }
          this.Update(0);
          TPerceptron tperceptron = this;
          int num4 = tperceptron.fNPattern + this.fNBatch;
          tperceptron.fNPattern = num4;
          num1 += this.fNBatch;
          num2 += this.fNBatch;
          if (this.x1tDaZE2v)
          {
						Console.WriteLine("");
            return;
          }
          else if (this.fSMethod == EStoppingMethod.PatternNumber && (double) num1 >= this.fSParameter)
          {
						Console.WriteLine("", this.fSParameter);
            return;
          }
        }
        while (num2 < this.fNGraphUpdate);
        num2 = 0;
        this.wm8s050QY = this.GetTrainingSetError();
        this.V8laR9xb7.Add((double) num3, this.wm8s050QY);
        if (this.WKl1lduPx != null)
        {
          this.MSg9cpEpW = this.GetValidationSetError();
          this.XOwvCEen2.Add((double) num3, this.MSg9cpEpW);
        }
        ++num3;
      }
      while (this.fViewMode != EViewMode.OnLine);
      goto label_1;
    }

   
    public double GetError()
    {
      double num = 0.0;
      for (int index = 0; index < this.fNOutput; ++index)
        num += this.cGqCj2YUM[index] * this.cGqCj2YUM[index];
      return 0.5 * num;
    }

   
    public double GetTrainingSetError(int Option)
    {
      if (Option != 0)
        return this.wm8s050QY;
      int ndata = this.tD5M1LlFx.GetNData();
      double num = 0.0;
      for (int Seek = 0; Seek < ndata; ++Seek)
      {
        TNeuralData data = this.tD5M1LlFx.GetData(Seek);
        this.fInput = data.Input;
        this.fTarget = data.Output;
        this.FeedForward();
        this.ComputeError();
        num += this.GetError();
      }
      return num / (double) ndata;
    }

   
    public double GetValidationSetError(int Option)
    {
      if (Option != 0)
        return this.MSg9cpEpW;
      if (this.WKl1lduPx == null)
        return 0.0;
      int ndata = this.WKl1lduPx.GetNData();
      double num = 0.0;
      for (int Seek = 0; Seek < ndata; ++Seek)
      {
        TNeuralData data = this.WKl1lduPx.GetData(Seek);
        this.fInput = data.Input;
        this.fTarget = data.Output;
        this.FeedForward();
        this.ComputeError();
        num += this.GetError();
      }
      return num / (double) ndata;
    }

   
    public double GetTrainingSetError()
    {
      return this.GetTrainingSetError(0);
    }

   
    public double GetValidationSetError()
    {
      return this.GetValidationSetError(0);
    }

   
    public void PrintError()
    {
      if (this.fTarget[1] == 0.0)
        return;
			Console.WriteLine("",  this.GetError());
      for (int index = 0; index < this.fNOutput; ++index)
      {
				Console.WriteLine("", this.GetWinner());
				Console.WriteLine("", this.fTarget[index], this.fOutput[index], this.cGqCj2YUM[index]);
      }
    }

   
    public void PrintTrainingSetError()
    {
      int ndata = this.tD5M1LlFx.GetNData();
      double num = 0.0;
      for (int Seek = 0; Seek < ndata; ++Seek)
      {
        TNeuralData data = this.tD5M1LlFx.GetData(Seek);
        this.fInput = data.Input;
        this.fTarget = data.Output;
        this.FeedForward();
        this.ComputeError();
        num += this.GetError();
        this.PrintError();
      }
    }

   
    public int GetWinner()
    {
      int index1 = 0;
      for (int index2 = 0; index2 < this.fNOutput; ++index2)
      {
        if (this.fOutput[index2] > this.fOutput[index1])
          index1 = index2;
      }
      return index1;
    }

   
    public double GetWinnerConfidence()
    {
      int index1 = 0;
      double num = 0.0;
      for (int index2 = 0; index2 < this.fNOutput; ++index2)
      {
        if (this.fOutput[index2] > this.fOutput[index1])
          index1 = index2;
        num += this.fOutput[index2];
      }
      return this.fOutput[index1] / num;
    }

   
    public void SetInputName(int i, string Name)
    {
      this.fInputLayer.SetName(i, Name);
    }

   
    public void SetOutputName(int i, string Name)
    {
      this.fOutputLayer.SetName(i - 1, Name);
    }

   
    public void Print(string Option)
    {
    }
  }
}
