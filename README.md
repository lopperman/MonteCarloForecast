# MonteCarloForecast

![Winforms Sample](https://github.com/lopperman/MonteCarloForecast/blob/master/winForecastScreenshot.PNG)

C# Implementation of the Monto Carlo Probability Forecast

We were using an excel spreadsheet to do Monte Carlo style forecasting for an Agile Software Development project.  That was working ok, but I wanted to be able to utilize a larger number of random probability models than excel allowed (spreadsheet supported 500 models, and adding more was tedious, and slow).  I found that increasing the model size to at least 100,000, the variation of forecast output was reduced drastically, but a horrible experience using a spreadsheet.

So, at the request of a member of my team, I decided to create this forecasting ability using C#.  My goal is to have a working front end Web App and Windows App that are easy to use.  The logic for the forecasting is all in a DLL, so feel free to use that and create your own front end.

An example for how to create a forecast is below:

	INPUTS:
	- Start Date (DateTime).  Usually this should be the current date.
	
	- Remaining Stories Low (int).  This is the minimum number of stories remaining to be completed for your forecast.  
	
	- Remaining Stories High (int).  This is the maximum number of stories remaining to be completed for your forecast.
	
	- Split Probability Low/High (double).  Likelihood that any story will split into 2 stories.  1.0 means 1 story for every story, 2.0 means 2 stories for every story.  
	
	- Model Size (int).  Number of random probability models that will be used to forecast likelihoods for completion.  Recommend at least 100,000.  The accuracy doesn't get much better any higher than that, even at 10,000,000.
	
	If estimating based on historic team velocity:
	
		- Historic Samples (int array) - Actual history of recent weeks actual team velocity.  (e.g.  5,6,3,3,1,18,13,5).  Minimum of 7 weeks required.
	
		- AverageTypeEnum (Averaging Type) - 'Simple' or 'Weighted'
	
	If estimating based on guessing high/low velocity:
	
		- Low weekly velocity guess (int)
		
		- High weekly velocity guess (int)
	
Example Code For forecasting based on history:

            DateTime StartDt = DateTime.Today;
            int RemainingStoriesGuessLow = 40;
            int RemainingStoriesGuessHigh = 45;
            double SplitProbabilityLow = 1.0;
            double SplitProbabilityHigh = 1.0;
            int[] samples = new int[] { 5, 6, 3, 1, 18, 13, 5, 4 };
            int modelSize = 100000;

            Forecast f = new Forecast(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh);
            
			--Use Simple Averaging
			List<ForecastResult> results = f.GetForecastBasedOnHistory(modelSize, samples, AverageTypeEnum.Simple);

			--Use Weighted Averaging
			List<ForecastResult> results = f.GetForecastBasedOnHistory(modelSize, samples, AverageTypeEnum.Weighted);

Example Code For forecasting based on velocity guesses:

            DateTime StartDt = DateTime.Now;
            int RemainingStoriesGuessLow = 40;
            int RemainingStoriesGuessHigh = 45;
            double SplitProbabilityLow = 1.0;
            double SplitProbabilityHigh = 1.0;
            int modelSize = 100000;
            int lowVelocityGuess = 6;
            int highVelocityGuess = 10;

            Forecast f = new Forecast(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh);

            List<ForecastResult> results = f.GetForecastBasedOnHighLowGuess(modelSize, lowVelocityGuess, highVelocityGuess);

Forecast results are a list of 'ForecastResult', which contain the following properties:

			Likelihood: Percentage represented as 0 - 100
			Weeks:		Number of weeks associated with Likelihood.
			Date:		Actual date (StartDt + Weeks)
			
