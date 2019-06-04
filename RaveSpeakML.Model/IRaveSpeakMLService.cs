using RaveSpeakML.Service.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaveSpeakML.Service
{
    public interface IRaveSpeakMLService
    {
        ModelOutput Predict(string input);
    }
}
