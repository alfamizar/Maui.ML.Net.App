using MauiAppML.Presentation.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MauiProgram;

namespace MauiAppML.Presentation.ViewModels
{
    public class PredictViewModel : BaseViewModel
    {
        private string _feedBackText;
        public string FeedBackText
        {
            get => _feedBackText;
            set => SetProperty(ref _feedBackText, value);
        }

        private string _predictionResult;
        public string PredictionResult
        {
            get => _predictionResult;
            set => SetProperty(ref _predictionResult, value);
        }
        public PredictViewModel()
        {
            Commands.Add("Predict", new Command(Predict));
            Commands.Add("ResetResult", new Command(ResetPredictionResult));
        }

        private async void Predict()
        {
            IsBusy = true;

            PredictionResult = await Task.Run(string () =>
            {
                var sampleData = new SentimentModel.ModelInput()
                {
                    Col0 = FeedBackText
                };

                return SentimentModel.Predict(sampleData).Prediction == 1 ? "Positive" : "Negative"; ;
            });

            IsBusy = false;
        }

        private void ResetPredictionResult()
        {
            PredictionResult = null;
        }
    }
}
