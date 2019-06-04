using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.ML;
using RaveSpeakML.Service.DataModels;

namespace RaveSpeakML.Service
{
    public class RaveSpeakMLService : IRaveSpeakMLService
    {
        private PredictionEngine<ModelInput, ModelOutput> predictionEngine;

        public RaveSpeakMLService()
        {
            ConsumeModel();
        }
        private void ConsumeModel()
        {
            // Load the model
            MLContext mlContext = new MLContext();

            var directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            ITransformer mlModel = mlContext.Model.Load(directoryName + "\\MLModel.zip", out var modelInputSchema);

            predictionEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);            
        }

        public ModelOutput Predict(string input)
        {
            // Use the code below to add input data
            var modelInput = new ModelInput();
            modelInput.SentimentText = input;

            // Try model on sample data
            // True is toxic, false is non-toxic
            ModelOutput result = predictionEngine.Predict(modelInput);

            return result;
        }
    }
}
