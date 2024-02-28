using OpenAI_API;

// See https://aka.ms/new-console-template for more information Console.WriteLine("Hello, World!");

var key = new APIAuthentication("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");

var api = new OpenAIAPI(key);

var prompt = "A long time ago, in a galaxy far, far away...";

var request = new OpenAI_API.Completions.CompletionRequest(prompt, model: OpenAI_API.Models.model.DavinciText, max_tokens: 100, temperature: 0.7)

var response = awaut api.Completions.CreateCompletionAsync(request);

Ar completion = response.Completions[0].Text;

Console.WriteLine("Generated Text: {0}", completion);
